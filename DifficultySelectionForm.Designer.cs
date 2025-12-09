namespace WordAroundGame
{
    partial class DifficultySelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbEndless;
        private System.Windows.Forms.Label lblEasyDesc;
        private System.Windows.Forms.Label lblMediumDesc;
        private System.Windows.Forms.Label lblHardDesc;
        private System.Windows.Forms.Label lblEndlessDesc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblDescription = new System.Windows.Forms.Label();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbEndless = new System.Windows.Forms.RadioButton();
            this.lblEasyDesc = new System.Windows.Forms.Label();
            this.lblMediumDesc = new System.Windows.Forms.Label();
            this.lblHardDesc = new System.Windows.Forms.Label();
            this.lblEndlessDesc = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(67, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ВЫБЕРИТЕ СЛОЖНОСТЬ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDescription.Location = new System.Drawing.Point(67, 86);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(399, 19);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Сложность влияет на время игры и буквы на поле";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Arial", 11F);
            this.rbEasy.Location = new System.Drawing.Point(80, 135);
            this.rbEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(104, 26);
            this.rbEasy.TabIndex = 2;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "ЛЁГКАЯ";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.DifficultyRadio_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.rbMedium.Location = new System.Drawing.Point(80, 203);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(124, 26);
            this.rbMedium.TabIndex = 3;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "СРЕДНЯЯ";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.DifficultyRadio_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Arial", 11F);
            this.rbHard.Location = new System.Drawing.Point(80, 271);
            this.rbHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(129, 26);
            this.rbHard.TabIndex = 4;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "СЛОЖНАЯ";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.DifficultyRadio_CheckedChanged);
            // 
            // rbEndless
            // 
            this.rbEndless.AutoSize = true;
            this.rbEndless.Font = new System.Drawing.Font("Arial", 11F);
            this.rbEndless.Location = new System.Drawing.Point(80, 338);
            this.rbEndless.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEndless.Name = "rbEndless";
            this.rbEndless.Size = new System.Drawing.Size(175, 26);
            this.rbEndless.TabIndex = 5;
            this.rbEndless.TabStop = true;
            this.rbEndless.Text = "БЕСКОНЕЧНАЯ";
            this.rbEndless.UseVisualStyleBackColor = true;
            this.rbEndless.CheckedChanged += new System.EventHandler(this.DifficultyRadio_CheckedChanged);
            // 
            // lblEasyDesc
            // 
            this.lblEasyDesc.AutoSize = true;
            this.lblEasyDesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblEasyDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblEasyDesc.Location = new System.Drawing.Point(107, 166);
            this.lblEasyDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEasyDesc.Name = "lblEasyDesc";
            this.lblEasyDesc.Size = new System.Drawing.Size(224, 17);
            this.lblEasyDesc.TabIndex = 6;
            this.lblEasyDesc.Text = "5 минут, больше гласных букв";
            // 
            // lblMediumDesc
            // 
            this.lblMediumDesc.AutoSize = true;
            this.lblMediumDesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblMediumDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblMediumDesc.Location = new System.Drawing.Point(107, 234);
            this.lblMediumDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMediumDesc.Name = "lblMediumDesc";
            this.lblMediumDesc.Size = new System.Drawing.Size(247, 17);
            this.lblMediumDesc.TabIndex = 7;
            this.lblMediumDesc.Text = "3 минуты, стандартные правила";
            // 
            // lblHardDesc
            // 
            this.lblHardDesc.AutoSize = true;
            this.lblHardDesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblHardDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblHardDesc.Location = new System.Drawing.Point(107, 302);
            this.lblHardDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHardDesc.Name = "lblHardDesc";
            this.lblHardDesc.Size = new System.Drawing.Size(179, 17);
            this.lblHardDesc.TabIndex = 8;
            this.lblHardDesc.Text = "2 минуты, редкие буквы";
            // 
            // lblEndlessDesc
            // 
            this.lblEndlessDesc.AutoSize = true;
            this.lblEndlessDesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblEndlessDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblEndlessDesc.Location = new System.Drawing.Point(107, 369);
            this.lblEndlessDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndlessDesc.Name = "lblEndlessDesc";
            this.lblEndlessDesc.Size = new System.Drawing.Size(186, 17);
            this.lblEndlessDesc.TabIndex = 9;
            this.lblEndlessDesc.Text = "Без ограничения времени";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(67, 418);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 49);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "НАЧАТЬ ИГРУ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancel.Location = new System.Drawing.Point(280, 418);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 49);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DifficultySelectionForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(533, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEndlessDesc);
            this.Controls.Add(this.rbEndless);
            this.Controls.Add(this.lblHardDesc);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.lblMediumDesc);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.lblEasyDesc);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DifficultySelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор сложности";
            this.Load += new System.EventHandler(this.DifficultySelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}