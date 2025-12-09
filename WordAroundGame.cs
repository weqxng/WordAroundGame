using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace WordAroundGame
{
    public class WordAroundGame
    {
        private char[,] board;
        private char centerLetter;
        private List<string> validWords;
        private HashSet<string> foundWords;
        private int score;
        private Random random;
        private int boardSize;
        private GameDifficulty difficulty;
        private DateTime gameStartTime;
        private int timeLimit;

        public event EventHandler GameStateChanged;
        public event EventHandler TimeUpdated;
        public event EventHandler<string> WordChecked; // Новое событие для результатов проверки

        public char[,] Board => (char[,])board.Clone();
        public char CenterLetter => centerLetter;
        public int Score => score;
        public HashSet<string> FoundWords => new HashSet<string>(foundWords);
        public int WordCount => foundWords.Count;
        public int BoardSize => boardSize;
        public GameDifficulty Difficulty => difficulty;
        public TimeSpan TimePlayed => DateTime.Now - gameStartTime;
        public int TimeLeft => timeLimit > 0 ? timeLimit - (int)TimePlayed.TotalSeconds : 0;
        public bool IsTimeLimited => timeLimit > 0;
        public bool IsGameOver => IsTimeLimited && TimeLeft <= 0;

        public WordAroundGame(int size = 5, GameDifficulty difficulty = GameDifficulty.Medium)
        {
            if (size % 2 == 0) size++;
            boardSize = size;
            board = new char[size, size];
            centerLetter = ' ';
            validWords = new List<string>();
            foundWords = new HashSet<string>();
            score = 0;
            random = new Random();
            this.difficulty = difficulty;

            SetDifficultySettings();
            InitializeGame();
        }

        private void SetDifficultySettings()
        {
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    timeLimit = 300;
                    break;
                case GameDifficulty.Medium:
                    timeLimit = 180;
                    break;
                case GameDifficulty.Hard:
                    timeLimit = 120;
                    break;
                case GameDifficulty.Endless:
                    timeLimit = 0;
                    break;
            }
        }

        private void InitializeGame()
        {
            gameStartTime = DateTime.Now;
            LoadWordDictionary();
            GenerateBoard();
            OnGameStateChanged();
        }

        private void GenerateBoard()
        {
            int center = boardSize / 2;

            // Генерируем поле, которое гарантированно содержит слова
            GenerateBoardWithWords();

            // Устанавливаем центральную букву
            centerLetter = board[center, center];
        }

        private void GenerateBoardWithWords()
        {
            int center = boardSize / 2;
            int attempts = 0;
            int maxAttempts = 100;

            // Пытаемся сгенерировать поле, на котором есть хотя бы 5 слов
            do
            {
                attempts++;

                // Заполняем поле случайными буквами
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        board[i, j] = GetRandomLetter();
                    }
                }

                // Выбираем центральную букву как гласную из популярных слов
                centerLetter = GetPopularVowel();
                board[center, center] = centerLetter;

                // Гарантируем наличие общих букв для составления слов
                AddCommonWordLetters();

            } while (GetPossibleWordsCount() < 5 && attempts < maxAttempts);

            // Если не удалось найти слова, создаем поле с гарантированными словами
            if (GetPossibleWordsCount() < 3)
            {
                CreateGuaranteedBoard();
            }
        }

        private void CreateGuaranteedBoard()
        {
            int center = boardSize / 2;

            // Создаем поле с гарантированными словами
            string[] guaranteedWords = { "КОТ", "ДОМ", "СОК", "РОТ", "НОС", "УХО" };
            string word = guaranteedWords[random.Next(guaranteedWords.Length)];

            // Центральная буква - первая буква слова
            centerLetter = word[0];
            board[center, center] = centerLetter;

            // Добавляем остальные буквы слова на поле
            int index = 0;
            for (int i = 0; i < boardSize && index < word.Length; i++)
            {
                for (int j = 0; j < boardSize && index < word.Length; j++)
                {
                    if (i == center && j == center) continue;
                    board[i, j] = word[index];
                    index++;
                }
            }

            // Остальные ячейки заполняем случайными буквами
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[i, j] == '\0') // Если ячейка пустая
                    {
                        board[i, j] = GetRandomLetter();
                    }
                }
            }
        }

        private char GetPopularVowel()
        {
            string popularVowels = "АОИЕУ"; // Самые частые гласные в русском
            return popularVowels[random.Next(popularVowels.Length)];
        }

        private void AddCommonWordLetters()
        {
            // Добавляем частые буквы для составления слов
            string commonLetters = "КСТРНВЛПМДГБЗЖЧШЩЙФХЦ";
            int lettersToAdd = 8;

            for (int i = 0; i < lettersToAdd; i++)
            {
                int row, col;
                do
                {
                    row = random.Next(boardSize);
                    col = random.Next(boardSize);
                } while (row == boardSize / 2 && col == boardSize / 2);

                board[row, col] = commonLetters[random.Next(commonLetters.Length)];
            }
        }

        private int GetPossibleWordsCount()
        {
            var wordsWithCenterLetter = validWords
                .Where(w => w.Contains(centerLetter))
                .ToList();

            int count = 0;
            foreach (var word in wordsWithCenterLetter)
            {
                if (CanFormWord(word))
                    count++;
            }

            return count;
        }

        private char GetRandomLetter()
        {
            string russianLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            return russianLetters[random.Next(russianLetters.Length)];
        }

        private void LoadWordDictionary()
        {
            try
            {
                if (File.Exists("words.txt"))
                {
                    validWords = File.ReadAllLines("words.txt", Encoding.UTF8)
                        .Select(w => w.Trim().ToUpper())
                        .Where(w => w.Length >= 3)
                        .Distinct()
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки словаря: {ex.Message}");
            }

            // Добавляем базовые слова, если словарь пустой
            if (validWords.Count < 100)
            {
                validWords.AddRange(GetDefaultWords());
            }
        }

        private List<string> GetDefaultWords()
        {
            return new List<string>
            {
                "КОТ", "ДОМ", "СОК", "РОТ", "НОС", "УХО", "РОГ",
                "МАК", "РАК", "РОК", "ТОК", "КОМ", "ЛОМ", "РОМ",
                "СОМ", "ТОМ", "СТОЛ", "КОРА", "МОСТ", "ТРОС",
                "СОРТ", "ПАРК", "МАРТ", "КАТЕР", "КОМАР", "ТРОПА",
                "ПАРОМ", "СПОРТ", "КРОТ", "ДРАМА", "РАМКА", "КАРТА",
                "ТРАКТ", "АКТЕР", "ТЕАТР", "МОТОР", "ТОПОР", "РУКА",
                "НОГА", "ГОРА", "РЕКА", "МОРЕ", "ЛЕС", "СНЕГ", "ДОЖДЬ",
                "СОЛНЦЕ", "ЛУНА", "ЗВЕЗДА", "КНИГА", "ШКОЛА", "УЧИТЕЛЬ",
                "УТКА", "УХА", "УДАР", "УГОЛ", "УЗОР", "УКОЛ", "УМ"
            };
        }

        // Измененный метод CheckWord - теперь возвращает строку с результатом
        public string CheckWord(string word)
        {
            if (IsGameOver)
                return "Игра окончена! Время вышло.";

            if (string.IsNullOrEmpty(word) || word.Length < 3)
                return "Слово должно содержать минимум 3 буквы.";

            word = word.ToUpper();

            if (!word.Contains(centerLetter))
                return $"Слово должно содержать центральную букву '{centerLetter}'!";

            if (foundWords.Contains(word))
                return "Это слово уже было найдено!";

            if (!validWords.Contains(word))
                return "Такого слова нет в словаре!";

            if (!CanFormWord(word))
                return "Нельзя составить это слово из букв на поле!";

            // Если все проверки пройдены
            foundWords.Add(word);
            int wordScore = CalculateWordScore(word);
            score += wordScore;

            OnGameStateChanged();
            OnWordChecked($"Правильно! Слово \"{word}\" принято! +{wordScore} очков");

            return "success"; // Специальное значение для успеха
        }

        private int CalculateWordScore(string word)
        {
            int wordScore = word.Length * 10;

            if (word.Length >= 5)
                wordScore += 20;

            if (word.Length >= 7)
                wordScore += 30;

            return wordScore;
        }

        private bool CanFormWord(string word)
        {
            // Создаем словарь букв на поле с их количеством
            var boardLetters = new Dictionary<char, int>();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    char letter = board[i, j];
                    if (boardLetters.ContainsKey(letter))
                        boardLetters[letter]++;
                    else
                        boardLetters[letter] = 1;
                }
            }

            // Проверяем каждую букву слова
            foreach (char letter in word)
            {
                if (!boardLetters.ContainsKey(letter) || boardLetters[letter] == 0)
                    return false;

                boardLetters[letter]--;
            }

            return true;
        }

        public string GetHint()
        {
            var possibleWords = GetPossibleWords();

            if (possibleWords.Count == 0)
            {
                // Если нет возможных слов, предлагаем подсказку
                return $"Центральная буква: {centerLetter}. Попробуйте составить слова с этой буквой!";
            }

            // Выбираем короткое слово для подсказки
            var shortWords = possibleWords.Where(w => w.Length <= 4).ToList();
            if (shortWords.Count > 0)
            {
                return shortWords[random.Next(shortWords.Count)];
            }

            return possibleWords[random.Next(possibleWords.Count)];
        }

        public List<string> GetPossibleWords()
        {
            var possibleWords = new List<string>();

            foreach (var word in validWords)
            {
                if (word.Contains(centerLetter) &&
                    !foundWords.Contains(word) &&
                    CanFormWord(word))
                {
                    possibleWords.Add(word);
                }
            }

            return possibleWords
                .OrderBy(w => w.Length)
                .ThenBy(w => w)
                .ToList();
        }

        public void Restart()
        {
            foundWords.Clear();
            score = 0;
            gameStartTime = DateTime.Now;
            GenerateBoard();
            OnGameStateChanged();
        }

        public void ChangeDifficulty(GameDifficulty newDifficulty)
        {
            difficulty = newDifficulty;
            SetDifficultySettings();
            Restart();
        }

        public void UpdateTime()
        {
            TimeUpdated?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnGameStateChanged()
        {
            GameStateChanged?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnWordChecked(string message)
        {
            WordChecked?.Invoke(this, message);
        }

        public string GetBoardLetters()
        {
            var letters = new List<char>();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    letters.Add(board[i, j]);
                }
            }
            return new string(letters.OrderBy(c => c).ToArray());
        }

        public int GetPossibleWordsCountPublic()
        {
            return GetPossibleWordsCount();
        }
    }

    public enum GameDifficulty
    {
        Easy,
        Medium,
        Hard,
        Endless
    }
}