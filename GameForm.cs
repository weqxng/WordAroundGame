using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Linq;

namespace WordAroundGame
{
    public partial class GameForm : Form
    {
        private WordAroundGame game;
        private Label[,] boardLabels;
        private System.Timers.Timer gameTimer;

        public GameForm(GameDifficulty difficulty)
        {
            InitializeComponent();
            InitializeGame(difficulty);
            SetupTimer();
        }

        private void InitializeGame(GameDifficulty difficulty)
        {
            game = new WordAroundGame(5, difficulty);
            game.GameStateChanged += Game_GameStateChanged;
            game.TimeUpdated += Game_TimeUpdated;
            game.WordChecked += Game_WordChecked; // Подписываемся на новое событие

            InitializeBoard();
            UpdateGameInfo();
            txtWordInput.Focus();
        }

        // Обработчик события проверки слова
        private void Game_WordChecked(object sender, string message)
        {
            if (message != "success")
            {
                // Показываем сообщение об ошибке
                MessageBox.Show(message, "Результат проверки",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Измененный метод проверки слова в GameForm.cs
        private void CheckWord()
        {
            string word = txtWordInput.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введите слово!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вызываем метод CheckWord, который теперь возвращает строку
            string result = game.CheckWord(word);

            if (result == "success")
            {
                // Слово принято успешно - очищаем поле ввода
                txtWordInput.Clear();
                txtWordInput.Focus();
            }
            else
            {
                // Показываем сообщение об ошибке
                MessageBox.Show(result, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWordInput.SelectAll();
                txtWordInput.Focus();
            }
        }

        // Остальной код GameForm остается без изменений...
        private void InitializeBoard()
        {
            boardPanel.Controls.Clear();
            int size = game.BoardSize;
            boardLabels = new Label[size, size];

            int cellSize = 350 / size;
            int padding = 5;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var label = new Label
                    {
                        Text = " ",
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(j * (cellSize + padding), i * (cellSize + padding)),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 18, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = SystemColors.ControlLight
                    };

                    if (i == size / 2 && j == size / 2)
                    {
                        label.BackColor = Color.Yellow;
                        label.ForeColor = Color.Red;
                    }

                    boardPanel.Controls.Add(label);
                    boardLabels[i, j] = label;
                }
            }
        }

        private void SetupTimer()
        {
            gameTimer = new System.Timers.Timer(1000);
            gameTimer.Elapsed += GameTimer_Elapsed;
            gameTimer.AutoReset = true;
            gameTimer.Enabled = true;
        }

        private void GameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                game.UpdateTime();

                if (game.IsGameOver)
                {
                    gameTimer.Stop();
                    EndGame();
                }
            }));
        }

        private void UpdateBoard()
        {
            char[,] board = game.Board;
            int center = board.GetLength(0) / 2;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    boardLabels[i, j].Text = board[i, j].ToString();

                    if (i == center && j == center)
                    {
                        boardLabels[i, j].BackColor = Color.Yellow;
                        boardLabels[i, j].ForeColor = Color.Red;
                    }
                    else
                    {
                        boardLabels[i, j].BackColor = SystemColors.ControlLight;
                        boardLabels[i, j].ForeColor = SystemColors.ControlText;
                    }
                }
            }
        }

        private void UpdateGameInfo()
        {
            lblCenterLetterValue.Text = game.CenterLetter.ToString();
            lblScoreValue.Text = game.Score.ToString();

            if (game.IsTimeLimited)
            {
                int minutes = game.TimeLeft / 60;
                int seconds = game.TimeLeft % 60;
                lblTimeValue.Text = $"{minutes:00}:{seconds:00}";
                lblTimeValue.ForeColor = game.TimeLeft < 30 ? Color.Red : Color.Black;
                progressTime.Value = (game.TimeLeft * 100) / (game.TimeLeft > 0 ? game.TimeLeft : 1);
            }
            else
            {
                lblTimeValue.Text = game.TimePlayed.ToString(@"mm\:ss");
            }

            lblWordsValue.Text = game.WordCount.ToString();
            //lblDifficulty.Text = game.Difficulty.ToString().ToUpper();

            timeStatusLabel.Text = $"Время: {lblTimeValue.Text}";
            scoreStatusLabel.Text = $"Счет: {game.Score}";
            wordsStatusLabel.Text = $"Слов: {game.WordCount}";
            difficultyStatusLabel.Text = $"Сложность: {game.Difficulty}";
        }

        private void Game_GameStateChanged(object sender, EventArgs e)
        {
            UpdateBoard();
            UpdateGameInfo();
            UpdateFoundWordsList();
        }

        private void Game_TimeUpdated(object sender, EventArgs e)
        {
            UpdateGameInfo();
        }

        private void UpdateFoundWordsList()
        {
            lstFoundWords.Items.Clear();
            foreach (var word in game.FoundWords.OrderBy(w => w.Length))
            {
                lstFoundWords.Items.Add($"{word} ({word.Length} букв)");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckWord();
        }

        private void txtWordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckWord();
                e.Handled = true;
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            string hint = game.GetHint();
            MessageBox.Show($"Подсказка: {hint}", "Подсказка",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPossibleWords_Click(object sender, EventArgs e)
        {
            var possibleWords = game.GetPossibleWords();

            if (possibleWords.Count == 0)
            {
                string boardLetters = game.GetBoardLetters();
                MessageBox.Show(
                    $"Нет возможных слов для текущего поля.\n" +
                    $"Центральная буква: {game.CenterLetter}\n" +
                    $"Буквы на поле: {boardLetters}\n\n" +
                    $"Попробуйте другие комбинации или нажмите 'Новая игра'",
                    "Возможные слова",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            string message = $"Всего возможных слов: {possibleWords.Count}\n";
            message += $"Центральная буква: {game.CenterLetter}\n\n";

            // Группируем слова по длине для удобства
            var wordsByLength = possibleWords.GroupBy(w => w.Length)
                                             .OrderBy(g => g.Key);

            foreach (var group in wordsByLength)
            {
                message += $"--- {group.Key} букв ({group.Count()}) ---\n";
                message += string.Join(", ", group.Take(10).OrderBy(w => w)) + "\n\n";

                if (group.Count() > 10)
                    message += $"... и еще {group.Count() - 10} слов\n\n";
            }

            if (possibleWords.Count > 30)
                message += $"\nПоказано 30 из {possibleWords.Count} слов";

            MessageBox.Show(message, "Возможные слова",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Начать новую игру?\nТекущий прогресс будет потерян.",
                "Новая игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                game.Restart();
                txtWordInput.Clear();
                txtWordInput.Focus();
                gameTimer.Start();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWordInput.Clear();
            txtWordInput.Focus();
        }

        private void txtWordInput_TextChanged(object sender, EventArgs e)
        {
            txtWordInput.Text = txtWordInput.Text.ToUpper();
            txtWordInput.SelectionStart = txtWordInput.Text.Length;
            lblWordLength.Text = $"{txtWordInput.Text.Length}/15";
        }

        private void EndGame()
        {
            string message = $"Время вышло!\n\n" +
                           $"Ваш результат:\n" +
                           $"• Счет: {game.Score}\n" +
                           $"• Найдено слов: {game.WordCount}\n\n" +
                           $"Хотите сыграть еще раз?";

            var result = MessageBox.Show(message, "Игра окончена",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                game.Restart();
                gameTimer.Start();
            }
            else
            {
                this.Close();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameTimer?.Stop();
            gameTimer?.Dispose();
        }
    }
}