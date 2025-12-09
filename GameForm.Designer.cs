namespace WordAroundGame
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblCenterLetterValue;
        private System.Windows.Forms.Label lblCenterLetterLabel;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblTimeLabel;
        private System.Windows.Forms.Label lblWordsValue;
        private System.Windows.Forms.Label lblWordsLabel;
        private System.Windows.Forms.ProgressBar progressTime;
        private System.Windows.Forms.GroupBox grpWordInput;
        private System.Windows.Forms.Label lblWordLength;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInputHint;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtWordInput;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnPossibleWords;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox grpFoundWords;
        private System.Windows.Forms.ListBox lstFoundWords;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel scoreStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel wordsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyStatusLabel;

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
            this.boardPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.progressTime = new System.Windows.Forms.ProgressBar();
            this.lblWordsValue = new System.Windows.Forms.Label();
            this.lblWordsLabel = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblTimeLabel = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblCenterLetterValue = new System.Windows.Forms.Label();
            this.lblCenterLetterLabel = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.grpWordInput = new System.Windows.Forms.GroupBox();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInputHint = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtWordInput = new System.Windows.Forms.TextBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnPossibleWords = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpFoundWords = new System.Windows.Forms.GroupBox();
            this.lstFoundWords = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoPanel.SuspendLayout();
            this.grpWordInput.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.grpFoundWords.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPanel.Location = new System.Drawing.Point(27, 25);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(498, 458);
            this.boardPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.progressTime);
            this.infoPanel.Controls.Add(this.lblWordsValue);
            this.infoPanel.Controls.Add(this.lblWordsLabel);
            this.infoPanel.Controls.Add(this.lblTimeValue);
            this.infoPanel.Controls.Add(this.lblTimeLabel);
            this.infoPanel.Controls.Add(this.lblScoreValue);
            this.infoPanel.Controls.Add(this.lblScoreLabel);
            this.infoPanel.Controls.Add(this.lblCenterLetterValue);
            this.infoPanel.Controls.Add(this.lblCenterLetterLabel);
            this.infoPanel.Controls.Add(this.lblInfoTitle);
            this.infoPanel.Location = new System.Drawing.Point(533, 25);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(466, 270);
            this.infoPanel.TabIndex = 1;
            // 
            // progressTime
            // 
            this.progressTime.Location = new System.Drawing.Point(27, 246);
            this.progressTime.Margin = new System.Windows.Forms.Padding(4);
            this.progressTime.Name = "progressTime";
            this.progressTime.Size = new System.Drawing.Size(413, 12);
            this.progressTime.TabIndex = 9;
            this.progressTime.Value = 100;
            // 
            // lblWordsValue
            // 
            this.lblWordsValue.AutoSize = true;
            this.lblWordsValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblWordsValue.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWordsValue.Location = new System.Drawing.Point(187, 209);
            this.lblWordsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordsValue.Name = "lblWordsValue";
            this.lblWordsValue.Size = new System.Drawing.Size(26, 29);
            this.lblWordsValue.TabIndex = 8;
            this.lblWordsValue.Text = "0";
            // 
            // lblWordsLabel
            // 
            this.lblWordsLabel.AutoSize = true;
            this.lblWordsLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.lblWordsLabel.Location = new System.Drawing.Point(27, 209);
            this.lblWordsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordsLabel.Name = "lblWordsLabel";
            this.lblWordsLabel.Size = new System.Drawing.Size(138, 22);
            this.lblWordsLabel.TabIndex = 7;
            this.lblWordsLabel.Text = "Слов найдено:";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTimeValue.Location = new System.Drawing.Point(107, 160);
            this.lblTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(72, 29);
            this.lblTimeValue.TabIndex = 6;
            this.lblTimeValue.Text = "03:00";
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.AutoSize = true;
            this.lblTimeLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTimeLabel.Location = new System.Drawing.Point(27, 160);
            this.lblTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(73, 22);
            this.lblTimeLabel.TabIndex = 5;
            this.lblTimeLabel.Text = "Время:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.ForeColor = System.Drawing.Color.Green;
            this.lblScoreValue.Location = new System.Drawing.Point(107, 111);
            this.lblScoreValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(26, 29);
            this.lblScoreValue.TabIndex = 4;
            this.lblScoreValue.Text = "0";
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.lblScoreLabel.Location = new System.Drawing.Point(27, 111);
            this.lblScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(57, 22);
            this.lblScoreLabel.TabIndex = 3;
            this.lblScoreLabel.Text = "Счет:";
            // 
            // lblCenterLetterValue
            // 
            this.lblCenterLetterValue.BackColor = System.Drawing.Color.Yellow;
            this.lblCenterLetterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCenterLetterValue.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblCenterLetterValue.ForeColor = System.Drawing.Color.Red;
            this.lblCenterLetterValue.Location = new System.Drawing.Point(213, 49);
            this.lblCenterLetterValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterLetterValue.Name = "lblCenterLetterValue";
            this.lblCenterLetterValue.Size = new System.Drawing.Size(66, 49);
            this.lblCenterLetterValue.TabIndex = 2;
            this.lblCenterLetterValue.Text = "А";
            this.lblCenterLetterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCenterLetterLabel
            // 
            this.lblCenterLetterLabel.AutoSize = true;
            this.lblCenterLetterLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCenterLetterLabel.Location = new System.Drawing.Point(27, 62);
            this.lblCenterLetterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterLetterLabel.Name = "lblCenterLetterLabel";
            this.lblCenterLetterLabel.Size = new System.Drawing.Size(183, 22);
            this.lblCenterLetterLabel.TabIndex = 1;
            this.lblCenterLetterLabel.Text = "Центральная буква:";
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInfoTitle.Location = new System.Drawing.Point(13, 12);
            this.lblInfoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(304, 29);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "ИНФОРМАЦИЯ ОБ ИГРЕ";
            // 
            // grpWordInput
            // 
            this.grpWordInput.BackColor = System.Drawing.Color.LightYellow;
            this.grpWordInput.Controls.Add(this.lblWordLength);
            this.grpWordInput.Controls.Add(this.btnClear);
            this.grpWordInput.Controls.Add(this.lblInputHint);
            this.grpWordInput.Controls.Add(this.btnSubmit);
            this.grpWordInput.Controls.Add(this.txtWordInput);
            this.grpWordInput.Location = new System.Drawing.Point(27, 480);
            this.grpWordInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpWordInput.Name = "grpWordInput";
            this.grpWordInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpWordInput.Size = new System.Drawing.Size(493, 148);
            this.grpWordInput.TabIndex = 2;
            this.grpWordInput.TabStop = false;
            this.grpWordInput.Text = "ВВЕДИТЕ СЛОВО";
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Font = new System.Drawing.Font("Arial", 10F);
            this.lblWordLength.Location = new System.Drawing.Point(360, 68);
            this.lblWordLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(41, 19);
            this.lblWordLength.TabIndex = 4;
            this.lblWordLength.Text = "0/15";
            this.lblWordLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClear.Location = new System.Drawing.Point(187, 105);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "ОЧИСТИТЬ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInputHint
            // 
            this.lblInputHint.AutoSize = true;
            this.lblInputHint.Font = new System.Drawing.Font("Arial", 9F);
            this.lblInputHint.ForeColor = System.Drawing.Color.Gray;
            this.lblInputHint.Location = new System.Drawing.Point(13, 25);
            this.lblInputHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputHint.Name = "lblInputHint";
            this.lblInputHint.Size = new System.Drawing.Size(399, 17);
            this.lblInputHint.TabIndex = 2;
            this.lblInputHint.Text = "Минимум 3 буквы, должна содержать центральную букву";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(13, 105);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 37);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "ПРОВЕРИТЬ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtWordInput
            // 
            this.txtWordInput.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtWordInput.Location = new System.Drawing.Point(13, 55);
            this.txtWordInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtWordInput.MaxLength = 15;
            this.txtWordInput.Name = "txtWordInput";
            this.txtWordInput.Size = new System.Drawing.Size(332, 42);
            this.txtWordInput.TabIndex = 0;
            this.txtWordInput.TextChanged += new System.EventHandler(this.txtWordInput_TextChanged);
            this.txtWordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWordInput_KeyPress);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.btnHint);
            this.controlPanel.Controls.Add(this.btnPossibleWords);
            this.controlPanel.Controls.Add(this.btnRestart);
            this.controlPanel.Location = new System.Drawing.Point(533, 308);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(467, 49);
            this.controlPanel.TabIndex = 3;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.LightBlue;
            this.btnHint.Location = new System.Drawing.Point(0, 0);
            this.btnHint.Margin = new System.Windows.Forms.Padding(4);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(147, 43);
            this.btnHint.TabIndex = 0;
            this.btnHint.Text = "💡 Подсказка";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnPossibleWords
            // 
            this.btnPossibleWords.BackColor = System.Drawing.Color.LightYellow;
            this.btnPossibleWords.Location = new System.Drawing.Point(160, 0);
            this.btnPossibleWords.Margin = new System.Windows.Forms.Padding(4);
            this.btnPossibleWords.Name = "btnPossibleWords";
            this.btnPossibleWords.Size = new System.Drawing.Size(173, 43);
            this.btnPossibleWords.TabIndex = 1;
            this.btnPossibleWords.Text = "📋 Возможные слова";
            this.btnPossibleWords.UseVisualStyleBackColor = false;
            this.btnPossibleWords.Click += new System.EventHandler(this.btnPossibleWords_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightCoral;
            this.btnRestart.Location = new System.Drawing.Point(347, 0);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 43);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "🔄 Новая игра";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grpFoundWords
            // 
            this.grpFoundWords.Controls.Add(this.lstFoundWords);
            this.grpFoundWords.Location = new System.Drawing.Point(533, 369);
            this.grpFoundWords.Margin = new System.Windows.Forms.Padding(4);
            this.grpFoundWords.Name = "grpFoundWords";
            this.grpFoundWords.Padding = new System.Windows.Forms.Padding(4);
            this.grpFoundWords.Size = new System.Drawing.Size(467, 258);
            this.grpFoundWords.TabIndex = 4;
            this.grpFoundWords.TabStop = false;
            this.grpFoundWords.Text = "НАЙДЕННЫЕ СЛОВА";
            // 
            // lstFoundWords
            // 
            this.lstFoundWords.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstFoundWords.FormattingEnabled = true;
            this.lstFoundWords.ItemHeight = 20;
            this.lstFoundWords.Location = new System.Drawing.Point(13, 25);
            this.lstFoundWords.Margin = new System.Windows.Forms.Padding(4);
            this.lstFoundWords.Name = "lstFoundWords";
            this.lstFoundWords.ScrollAlwaysVisible = true;
            this.lstFoundWords.Size = new System.Drawing.Size(439, 224);
            this.lstFoundWords.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeStatusLabel,
            this.scoreStatusLabel,
            this.wordsStatusLabel,
            this.difficultyStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 33);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeStatusLabel
            // 
            this.timeStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.timeStatusLabel.Name = "timeStatusLabel";
            this.timeStatusLabel.Size = new System.Drawing.Size(104, 27);
            this.timeStatusLabel.Text = "Время: 0:00";
            // 
            // scoreStatusLabel
            // 
            this.scoreStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.scoreStatusLabel.Name = "scoreStatusLabel";
            this.scoreStatusLabel.Size = new System.Drawing.Size(69, 27);
            this.scoreStatusLabel.Text = "Счет: 0";
            // 
            // wordsStatusLabel
            // 
            this.wordsStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.wordsStatusLabel.Name = "wordsStatusLabel";
            this.wordsStatusLabel.Size = new System.Drawing.Size(71, 27);
            this.wordsStatusLabel.Text = "Слов: 0";
            // 
            // difficultyStatusLabel
            // 
            this.difficultyStatusLabel.Name = "difficultyStatusLabel";
            this.difficultyStatusLabel.Size = new System.Drawing.Size(803, 27);
            this.difficultyStatusLabel.Spring = true;
            this.difficultyStatusLabel.Text = "Сложность: Средняя";
            this.difficultyStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpFoundWords);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.grpWordInput);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.boardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вокруг Слова";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.grpWordInput.ResumeLayout(false);
            this.grpWordInput.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.grpFoundWords.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}