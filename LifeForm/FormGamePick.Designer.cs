namespace LifeForm
{
    partial class FormGamePick
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxPlayerOneName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxGameTime = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tboxPlayerFourName = new System.Windows.Forms.TextBox();
            this.tboxPlayerThreeName = new System.Windows.Forms.TextBox();
            this.tboxPlayerTwoName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxPlayerOneName
            // 
            this.tboxPlayerOneName.BackColor = System.Drawing.Color.Gray;
            this.tboxPlayerOneName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPlayerOneName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPlayerOneName.Location = new System.Drawing.Point(9, 9);
            this.tboxPlayerOneName.MaxLength = 16;
            this.tboxPlayerOneName.Name = "tboxPlayerOneName";
            this.tboxPlayerOneName.Size = new System.Drawing.Size(193, 27);
            this.tboxPlayerOneName.TabIndex = 0;
            this.tboxPlayerOneName.Text = "Player 1";
            this.tboxPlayerOneName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxPlayerOneName.TextChanged += new System.EventHandler(this.tboxPlayerOneName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tboxGameTime);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.tboxPlayerFourName);
            this.panel1.Controls.Add(this.tboxPlayerThreeName);
            this.panel1.Controls.Add(this.tboxPlayerTwoName);
            this.panel1.Controls.Add(this.tboxPlayerOneName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 240);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(136, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game length:";
            // 
            // tboxGameTime
            // 
            this.tboxGameTime.BackColor = System.Drawing.Color.Gray;
            this.tboxGameTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxGameTime.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxGameTime.Location = new System.Drawing.Point(98, 141);
            this.tboxGameTime.MaxLength = 2;
            this.tboxGameTime.Name = "tboxGameTime";
            this.tboxGameTime.Size = new System.Drawing.Size(37, 27);
            this.tboxGameTime.TabIndex = 5;
            this.tboxGameTime.Text = "50";
            this.tboxGameTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Gray;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(43, 174);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(123, 58);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Done";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tboxPlayerFourName
            // 
            this.tboxPlayerFourName.BackColor = System.Drawing.Color.Gray;
            this.tboxPlayerFourName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPlayerFourName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPlayerFourName.Location = new System.Drawing.Point(9, 108);
            this.tboxPlayerFourName.MaxLength = 16;
            this.tboxPlayerFourName.Name = "tboxPlayerFourName";
            this.tboxPlayerFourName.Size = new System.Drawing.Size(193, 27);
            this.tboxPlayerFourName.TabIndex = 3;
            this.tboxPlayerFourName.Text = "Player 4";
            this.tboxPlayerFourName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxPlayerFourName.TextChanged += new System.EventHandler(this.tboxPlayerFourName_TextChanged);
            // 
            // tboxPlayerThreeName
            // 
            this.tboxPlayerThreeName.BackColor = System.Drawing.Color.Gray;
            this.tboxPlayerThreeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPlayerThreeName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPlayerThreeName.Location = new System.Drawing.Point(9, 75);
            this.tboxPlayerThreeName.MaxLength = 16;
            this.tboxPlayerThreeName.Name = "tboxPlayerThreeName";
            this.tboxPlayerThreeName.Size = new System.Drawing.Size(193, 27);
            this.tboxPlayerThreeName.TabIndex = 2;
            this.tboxPlayerThreeName.Text = "Player 3";
            this.tboxPlayerThreeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxPlayerThreeName.TextChanged += new System.EventHandler(this.tboxPlayerThreeName_TextChanged);
            // 
            // tboxPlayerTwoName
            // 
            this.tboxPlayerTwoName.BackColor = System.Drawing.Color.Gray;
            this.tboxPlayerTwoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPlayerTwoName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPlayerTwoName.Location = new System.Drawing.Point(9, 42);
            this.tboxPlayerTwoName.MaxLength = 16;
            this.tboxPlayerTwoName.Name = "tboxPlayerTwoName";
            this.tboxPlayerTwoName.Size = new System.Drawing.Size(193, 27);
            this.tboxPlayerTwoName.TabIndex = 1;
            this.tboxPlayerTwoName.Text = "Player 2";
            this.tboxPlayerTwoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxPlayerTwoName.TextChanged += new System.EventHandler(this.tboxPlayerTwoName_TextChanged);
            // 
            // FormGamePick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(231, 260);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGamePick";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game setup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormGamePick_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tboxPlayerOneName;
        private Panel panel1;
        private TextBox tboxPlayerFourName;
        private TextBox tboxPlayerThreeName;
        private TextBox tboxPlayerTwoName;
        private TextBox tboxGameTime;
        private Button btnStartGame;
        private Label label2;
        private Label label1;
    }
}