using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordAroundGame
{
    public partial class DifficultySelectionForm : Form
    {
        public GameDifficulty SelectedDifficulty { get; private set; }

        public DifficultySelectionForm()
        {
            InitializeComponent();
            SelectedDifficulty = GameDifficulty.Medium;
        }

        private void DifficultyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked) SelectedDifficulty = GameDifficulty.Easy;
            else if (rbMedium.Checked) SelectedDifficulty = GameDifficulty.Medium;
            else if (rbHard.Checked) SelectedDifficulty = GameDifficulty.Hard;
            else if (rbEndless.Checked) SelectedDifficulty = GameDifficulty.Endless;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DifficultySelectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}