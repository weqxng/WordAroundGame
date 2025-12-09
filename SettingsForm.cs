using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WordAroundGame
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            chkSound.Checked = true;
            chkMusic.Checked = false;
            trkVolume.Value = 75;
            cmbBoardSize.SelectedIndex = 1;
            cmbTimeLimit.SelectedIndex = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Настройки сохранены!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сбросить все настройки к значениям по умолчанию?",
                "Сброс настроек", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadSettings();
            }
        }

        private void trkVolume_Scroll(object sender, EventArgs e)
        {

        }
    }
}
