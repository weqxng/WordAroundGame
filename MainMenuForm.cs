using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordAroundGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            var difficultyForm = new DifficultySelectionForm();
            if (difficultyForm.ShowDialog() == DialogResult.OK)
            {
                var gameForm = new GameForm(difficultyForm.SelectedDifficulty);
                this.Hide();
                gameForm.ShowDialog();
                this.Show();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "ПРАВИЛА ИГРЫ 'ВОКРУГ СЛОВА'\n\n" +
                "🎯 ЦЕЛЬ: Составлять слова из букв на поле\n" +
                "📌 ПРАВИЛА:\n" +
                "1. Слово должно содержать центральную букву\n" +
                "2. Минимум 3 буквы\n" +
                "3. Используйте только русские буквы\n" +
                "4. Повторы не допускаются\n\n" +
                "🏆 ОЧКИ: 3 буквы = 30 очков, 4 = 40, 5+ = бонусы!",
                "Правила игры",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}