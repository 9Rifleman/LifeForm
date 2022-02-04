namespace LifeForm
{
    partial class FormTwoPlayers
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPlayerTwo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPlayerTwoTotals = new System.Windows.Forms.Label();
            this.btnPlayerTwoLife = new System.Windows.Forms.Button();
            this.btnPlayerTwoMinus = new System.Windows.Forms.Button();
            this.btnPlayerTwoPlus = new System.Windows.Forms.Button();
            this.pnlPlayerOne = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayerOneLife = new System.Windows.Forms.Button();
            this.btnPlayerOneMinus = new System.Windows.Forms.Button();
            this.btnPlayerOnePlus = new System.Windows.Forms.Button();
            this.lblPlayerOneTotals = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPlayerTwo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPlayerOne.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerTwo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerOne, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 485);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlPlayerTwo
            // 
            this.pnlPlayerTwo.AutoSize = true;
            this.pnlPlayerTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerTwo.Controls.Add(this.panel2);
            this.pnlPlayerTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerTwo.Location = new System.Drawing.Point(3, 245);
            this.pnlPlayerTwo.Name = "pnlPlayerTwo";
            this.pnlPlayerTwo.Size = new System.Drawing.Size(410, 237);
            this.pnlPlayerTwo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPlayerTwoName);
            this.panel2.Controls.Add(this.lblPlayerTwoTotals);
            this.panel2.Controls.Add(this.btnPlayerTwoLife);
            this.panel2.Controls.Add(this.btnPlayerTwoMinus);
            this.panel2.Controls.Add(this.btnPlayerTwoPlus);
            this.panel2.Location = new System.Drawing.Point(18, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 2;
            // 
            // lblPlayerTwoTotals
            // 
            this.lblPlayerTwoTotals.Font = new System.Drawing.Font("Bahnschrift Condensed", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTwoTotals.Location = new System.Drawing.Point(3, 14);
            this.lblPlayerTwoTotals.Name = "lblPlayerTwoTotals";
            this.lblPlayerTwoTotals.Size = new System.Drawing.Size(192, 81);
            this.lblPlayerTwoTotals.TabIndex = 0;
            this.lblPlayerTwoTotals.Text = "20";
            this.lblPlayerTwoTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayerTwoLife
            // 
            this.btnPlayerTwoLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerTwoLife.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerTwoLife.Location = new System.Drawing.Point(36, 164);
            this.btnPlayerTwoLife.Name = "btnPlayerTwoLife";
            this.btnPlayerTwoLife.Size = new System.Drawing.Size(126, 23);
            this.btnPlayerTwoLife.TabIndex = 7;
            this.btnPlayerTwoLife.TabStop = false;
            this.btnPlayerTwoLife.Text = "Life";
            this.btnPlayerTwoLife.UseVisualStyleBackColor = true;
            this.btnPlayerTwoLife.Click += new System.EventHandler(this.btnPlayerTwoLife_Click);
            // 
            // btnPlayerTwoMinus
            // 
            this.btnPlayerTwoMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerTwoMinus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerTwoMinus.Location = new System.Drawing.Point(102, 98);
            this.btnPlayerTwoMinus.Name = "btnPlayerTwoMinus";
            this.btnPlayerTwoMinus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerTwoMinus.TabIndex = 6;
            this.btnPlayerTwoMinus.TabStop = false;
            this.btnPlayerTwoMinus.Text = "-";
            this.btnPlayerTwoMinus.UseVisualStyleBackColor = true;
            this.btnPlayerTwoMinus.Click += new System.EventHandler(this.btnPlayerTwoMinus_Click);
            // 
            // btnPlayerTwoPlus
            // 
            this.btnPlayerTwoPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerTwoPlus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerTwoPlus.Location = new System.Drawing.Point(36, 98);
            this.btnPlayerTwoPlus.Name = "btnPlayerTwoPlus";
            this.btnPlayerTwoPlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerTwoPlus.TabIndex = 5;
            this.btnPlayerTwoPlus.TabStop = false;
            this.btnPlayerTwoPlus.Text = "+";
            this.btnPlayerTwoPlus.UseVisualStyleBackColor = true;
            this.btnPlayerTwoPlus.Click += new System.EventHandler(this.btnPlayerTwoPlus_Click);
            // 
            // pnlPlayerOne
            // 
            this.pnlPlayerOne.AutoSize = true;
            this.pnlPlayerOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerOne.Controls.Add(this.panel1);
            this.pnlPlayerOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerOne.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayerOne.Name = "pnlPlayerOne";
            this.pnlPlayerOne.Size = new System.Drawing.Size(410, 236);
            this.pnlPlayerOne.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPlayerOneName);
            this.panel1.Controls.Add(this.btnPlayerOneLife);
            this.panel1.Controls.Add(this.btnPlayerOneMinus);
            this.panel1.Controls.Add(this.btnPlayerOnePlus);
            this.panel1.Controls.Add(this.lblPlayerOneTotals);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 1;
            // 
            // btnPlayerOneLife
            // 
            this.btnPlayerOneLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerOneLife.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOneLife.Location = new System.Drawing.Point(36, 164);
            this.btnPlayerOneLife.Name = "btnPlayerOneLife";
            this.btnPlayerOneLife.Size = new System.Drawing.Size(126, 23);
            this.btnPlayerOneLife.TabIndex = 3;
            this.btnPlayerOneLife.TabStop = false;
            this.btnPlayerOneLife.Text = "Life";
            this.btnPlayerOneLife.UseVisualStyleBackColor = true;
            this.btnPlayerOneLife.Click += new System.EventHandler(this.btnPlayerOneLife_Click);
            // 
            // btnPlayerOneMinus
            // 
            this.btnPlayerOneMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerOneMinus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOneMinus.Location = new System.Drawing.Point(102, 98);
            this.btnPlayerOneMinus.Name = "btnPlayerOneMinus";
            this.btnPlayerOneMinus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerOneMinus.TabIndex = 2;
            this.btnPlayerOneMinus.TabStop = false;
            this.btnPlayerOneMinus.Text = "-";
            this.btnPlayerOneMinus.UseVisualStyleBackColor = true;
            this.btnPlayerOneMinus.Click += new System.EventHandler(this.btnPlayerOneMinus_Click);
            // 
            // btnPlayerOnePlus
            // 
            this.btnPlayerOnePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerOnePlus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOnePlus.Location = new System.Drawing.Point(36, 98);
            this.btnPlayerOnePlus.Name = "btnPlayerOnePlus";
            this.btnPlayerOnePlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerOnePlus.TabIndex = 1;
            this.btnPlayerOnePlus.TabStop = false;
            this.btnPlayerOnePlus.Text = "+";
            this.btnPlayerOnePlus.UseVisualStyleBackColor = true;
            this.btnPlayerOnePlus.Click += new System.EventHandler(this.btnPlayerOnePlus_Click);
            // 
            // lblPlayerOneTotals
            // 
            this.lblPlayerOneTotals.Font = new System.Drawing.Font("Bahnschrift Condensed", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOneTotals.Location = new System.Drawing.Point(3, 14);
            this.lblPlayerOneTotals.Name = "lblPlayerOneTotals";
            this.lblPlayerOneTotals.Size = new System.Drawing.Size(192, 81);
            this.lblPlayerOneTotals.TabIndex = 0;
            this.lblPlayerOneTotals.Text = "20";
            this.lblPlayerOneTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 506);
            this.panel3.TabIndex = 2;
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOneName.Location = new System.Drawing.Point(67, 8);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(58, 19);
            this.lblPlayerOneName.TabIndex = 4;
            this.lblPlayerOneName.Text = "Player 1";
            this.lblPlayerOneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerOneName.Click += new System.EventHandler(this.lblPlayerOneName_Click);
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTwoName.Location = new System.Drawing.Point(66, 9);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(60, 19);
            this.lblPlayerTwoName.TabIndex = 8;
            this.lblPlayerTwoName.Text = "Player 2";
            this.lblPlayerTwoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(461, 532);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTwoPlayers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Two players";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTwoPlayers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPlayerTwo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPlayerOne.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPlayerTwo;
        private Panel pnlPlayerOne;
        private Panel panel1;
        private Label lblPlayerOneTotals;
        private Panel panel2;
        private Label lblPlayerTwoTotals;
        private Button btnPlayerOneLife;
        private Button btnPlayerOneMinus;
        private Button btnPlayerOnePlus;
        private Button btnPlayerTwoLife;
        private Button btnPlayerTwoMinus;
        private Button btnPlayerTwoPlus;
        private Panel panel3;
        private Label lblPlayerTwoName;
        private Label lblPlayerOneName;
    }
}