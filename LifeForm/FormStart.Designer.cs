namespace LifeForm
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.btnFourPlayers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThreePlayers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboxTimer = new System.Windows.Forms.CheckBox();
            this.cboxNames = new System.Windows.Forms.CheckBox();
            this.cboxSounds = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.BackColor = System.Drawing.Color.Black;
            this.btnTwoPlayers.BackgroundImage = global::LifeForm.Properties.Resources.TwoPlayers;
            this.btnTwoPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwoPlayers.FlatAppearance.BorderSize = 3;
            this.btnTwoPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoPlayers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwoPlayers.ForeColor = System.Drawing.Color.Black;
            this.btnTwoPlayers.Location = new System.Drawing.Point(10, 8);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(142, 136);
            this.btnTwoPlayers.TabIndex = 0;
            this.btnTwoPlayers.UseVisualStyleBackColor = false;
            this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);
            // 
            // btnFourPlayers
            // 
            this.btnFourPlayers.BackColor = System.Drawing.Color.Black;
            this.btnFourPlayers.BackgroundImage = global::LifeForm.Properties.Resources.FourPlayers;
            this.btnFourPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFourPlayers.FlatAppearance.BorderSize = 3;
            this.btnFourPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourPlayers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFourPlayers.ForeColor = System.Drawing.Color.Black;
            this.btnFourPlayers.Location = new System.Drawing.Point(304, 8);
            this.btnFourPlayers.Name = "btnFourPlayers";
            this.btnFourPlayers.Size = new System.Drawing.Size(140, 136);
            this.btnFourPlayers.TabIndex = 2;
            this.btnFourPlayers.UseVisualStyleBackColor = false;
            this.btnFourPlayers.Click += new System.EventHandler(this.btnFourPlayers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "2 players";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "4 players";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnThreePlayers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTwoPlayers);
            this.panel1.Controls.Add(this.btnFourPlayers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 182);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(191, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "3 players";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThreePlayers
            // 
            this.btnThreePlayers.BackColor = System.Drawing.Color.Black;
            this.btnThreePlayers.BackgroundImage = global::LifeForm.Properties.Resources.ThreePlayers;
            this.btnThreePlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThreePlayers.FlatAppearance.BorderSize = 3;
            this.btnThreePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThreePlayers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThreePlayers.ForeColor = System.Drawing.Color.Black;
            this.btnThreePlayers.Location = new System.Drawing.Point(158, 8);
            this.btnThreePlayers.Name = "btnThreePlayers";
            this.btnThreePlayers.Size = new System.Drawing.Size(140, 136);
            this.btnThreePlayers.TabIndex = 1;
            this.btnThreePlayers.UseVisualStyleBackColor = false;
            this.btnThreePlayers.Click += new System.EventHandler(this.btnThreePlayers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboxTimer);
            this.panel2.Controls.Add(this.cboxNames);
            this.panel2.Controls.Add(this.cboxSounds);
            this.panel2.Location = new System.Drawing.Point(12, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 47);
            this.panel2.TabIndex = 5;
            // 
            // cboxTimer
            // 
            this.cboxTimer.AutoSize = true;
            this.cboxTimer.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cboxTimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxTimer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxTimer.ForeColor = System.Drawing.Color.Black;
            this.cboxTimer.Location = new System.Drawing.Point(352, 3);
            this.cboxTimer.Name = "cboxTimer";
            this.cboxTimer.Size = new System.Drawing.Size(40, 34);
            this.cboxTimer.TabIndex = 2;
            this.cboxTimer.Text = "Timer";
            this.cboxTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxTimer.UseVisualStyleBackColor = false;
            this.cboxTimer.Click += new System.EventHandler(this.cboxTimer_Click);
            // 
            // cboxNames
            // 
            this.cboxNames.AutoSize = true;
            this.cboxNames.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cboxNames.Checked = true;
            this.cboxNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxNames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxNames.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxNames.ForeColor = System.Drawing.Color.Black;
            this.cboxNames.Location = new System.Drawing.Point(187, 3);
            this.cboxNames.Name = "cboxNames";
            this.cboxNames.Size = new System.Drawing.Size(81, 34);
            this.cboxNames.TabIndex = 1;
            this.cboxNames.Text = "Player names";
            this.cboxNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxNames.UseVisualStyleBackColor = false;
            this.cboxNames.Click += new System.EventHandler(this.cboxNames_Click);
            // 
            // cboxSounds
            // 
            this.cboxSounds.AutoSize = true;
            this.cboxSounds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxSounds.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cboxSounds.Checked = true;
            this.cboxSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxSounds.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxSounds.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxSounds.ForeColor = System.Drawing.Color.Black;
            this.cboxSounds.Location = new System.Drawing.Point(51, 3);
            this.cboxSounds.Name = "cboxSounds";
            this.cboxSounds.Size = new System.Drawing.Size(48, 34);
            this.cboxSounds.TabIndex = 0;
            this.cboxSounds.Text = "Sounds";
            this.cboxSounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxSounds.UseVisualStyleBackColor = false;
            this.cboxSounds.Click += new System.EventHandler(this.cboxSounds_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 260);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LifeForm v0.7.0.111";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTwoPlayers;
        private Button btnFourPlayers;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Button btnThreePlayers;
        private Panel panel2;
        public CheckBox cboxTimer;
        public CheckBox cboxNames;
        public CheckBox cboxSounds;
    }
}