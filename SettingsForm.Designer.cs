namespace WordAroundGame
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpSound;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.GroupBox grpGame;
        private System.Windows.Forms.Label lblBoardSize;
        private System.Windows.Forms.ComboBox cmbBoardSize;
        private System.Windows.Forms.Label lblTimeLimit;
        private System.Windows.Forms.ComboBox cmbTimeLimit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpSound = new System.Windows.Forms.GroupBox();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.grpGame = new System.Windows.Forms.GroupBox();
            this.cmbTimeLimit = new System.Windows.Forms.ComboBox();
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.cmbBoardSize = new System.Windows.Forms.ComboBox();
            this.lblBoardSize = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.grpGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSound
            // 
            this.grpSound.Controls.Add(this.trkVolume);
            this.grpSound.Controls.Add(this.lblVolume);
            this.grpSound.Controls.Add(this.chkMusic);
            this.grpSound.Controls.Add(this.chkSound);
            this.grpSound.Location = new System.Drawing.Point(27, 25);
            this.grpSound.Margin = new System.Windows.Forms.Padding(4);
            this.grpSound.Name = "grpSound";
            this.grpSound.Padding = new System.Windows.Forms.Padding(4);
            this.grpSound.Size = new System.Drawing.Size(600, 123);
            this.grpSound.TabIndex = 0;
            this.grpSound.TabStop = false;
            this.grpSound.Text = "Звук";
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(373, 37);
            this.trkVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(200, 56);
            this.trkVolume.TabIndex = 3;
            this.trkVolume.TickFrequency = 10;
            this.trkVolume.Value = 50;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(267, 37);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(78, 16);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Громкость:";
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(27, 68);
            this.chkMusic.Margin = new System.Windows.Forms.Padding(4);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(139, 20);
            this.chkMusic.TabIndex = 1;
            this.chkMusic.Text = "Фоновая музыка";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(27, 31);
            this.chkSound.Margin = new System.Windows.Forms.Padding(4);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(135, 20);
            this.chkSound.TabIndex = 0;
            this.chkSound.Text = "Включить звуки";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // grpGame
            // 
            this.grpGame.Controls.Add(this.cmbTimeLimit);
            this.grpGame.Controls.Add(this.lblTimeLimit);
            this.grpGame.Controls.Add(this.cmbBoardSize);
            this.grpGame.Controls.Add(this.lblBoardSize);
            this.grpGame.Location = new System.Drawing.Point(27, 172);
            this.grpGame.Margin = new System.Windows.Forms.Padding(4);
            this.grpGame.Name = "grpGame";
            this.grpGame.Padding = new System.Windows.Forms.Padding(4);
            this.grpGame.Size = new System.Drawing.Size(600, 98);
            this.grpGame.TabIndex = 1;
            this.grpGame.TabStop = false;
            this.grpGame.Text = "Параметры игры";
            // 
            // cmbTimeLimit
            // 
            this.cmbTimeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeLimit.FormattingEnabled = true;
            this.cmbTimeLimit.Items.AddRange(new object[] {
            "1 минута",
            "2 минуты",
            "3 минуты",
            "5 минут",
            "Без лимита"});
            this.cmbTimeLimit.Location = new System.Drawing.Point(173, 68);
            this.cmbTimeLimit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTimeLimit.Name = "cmbTimeLimit";
            this.cmbTimeLimit.Size = new System.Drawing.Size(132, 24);
            this.cmbTimeLimit.TabIndex = 3;
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.AutoSize = true;
            this.lblTimeLimit.Location = new System.Drawing.Point(27, 68);
            this.lblTimeLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(111, 16);
            this.lblTimeLimit.TabIndex = 2;
            this.lblTimeLimit.Text = "Лимит времени:";
            // 
            // cmbBoardSize
            // 
            this.cmbBoardSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoardSize.FormattingEnabled = true;
            this.cmbBoardSize.Items.AddRange(new object[] {
            "3x3",
            "5x5",
            "7x7"});
            this.cmbBoardSize.Location = new System.Drawing.Point(173, 31);
            this.cmbBoardSize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoardSize.Name = "cmbBoardSize";
            this.cmbBoardSize.Size = new System.Drawing.Size(132, 24);
            this.cmbBoardSize.TabIndex = 1;
            // 
            // lblBoardSize
            // 
            this.lblBoardSize.AutoSize = true;
            this.lblBoardSize.Location = new System.Drawing.Point(27, 31);
            this.lblBoardSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoardSize.Name = "lblBoardSize";
            this.lblBoardSize.Size = new System.Drawing.Size(94, 16);
            this.lblBoardSize.TabIndex = 0;
            this.lblBoardSize.Text = "Размер поля:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(200, 308);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(347, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "❌ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F);
            this.btnReset.Location = new System.Drawing.Point(493, 308);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 49);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "🔄 Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(667, 382);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpGame);
            this.Controls.Add(this.grpSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки игры";
            this.grpSound.ResumeLayout(false);
            this.grpSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.grpGame.ResumeLayout(false);
            this.grpGame.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}