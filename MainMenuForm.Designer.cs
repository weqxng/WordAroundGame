namespace WordAroundGame
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnExit;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(133, 62);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ВОКРУГ СЛОВА";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Pink;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(200, 185);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(400, 62);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "🎮 НОВАЯ ИГРА";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnSettings.Location = new System.Drawing.Point(200, 271);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(400, 62);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "⚙️ НАСТРОЙКИ";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.MistyRose;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnRules.Location = new System.Drawing.Point(200, 357);
            this.btnRules.Margin = new System.Windows.Forms.Padding(4);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(400, 62);
            this.btnRules.TabIndex = 3;
            this.btnRules.Text = "📚 ПРАВИЛА";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F);
            this.btnExit.Location = new System.Drawing.Point(300, 443);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "🚪 ВЫХОД";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вокруг Слова - Главное меню";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}