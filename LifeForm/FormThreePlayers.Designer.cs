namespace LifeForm
{
    partial class FormThreePlayers
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
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.pnlPlayerThree = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPlayerThreeTotals = new System.Windows.Forms.Label();
            this.btnPlayerThreeLife = new System.Windows.Forms.Button();
            this.btnPlayerThreeMinus = new System.Windows.Forms.Button();
            this.btnPlayerThreePlus = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPlayerTwo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPlayerOne.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPlayerThree.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 748);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerTwo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerThree, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.10309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.89691F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 725);
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
            this.pnlPlayerTwo.Size = new System.Drawing.Size(410, 235);
            this.pnlPlayerTwo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.lblPlayerTwoTotals.Location = new System.Drawing.Point(3, -2);
            this.lblPlayerTwoTotals.Name = "lblPlayerTwoTotals";
            this.lblPlayerTwoTotals.Size = new System.Drawing.Size(192, 97);
            this.lblPlayerTwoTotals.TabIndex = 0;
            this.lblPlayerTwoTotals.Text = "20";
            this.lblPlayerTwoTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayerTwoLife
            // 
            this.btnPlayerTwoLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerTwoLife.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerTwoLife.Location = new System.Drawing.Point(36, 164);
            this.btnPlayerTwoLife.Name = "btnPlayerTwoLife";
            this.btnPlayerTwoLife.Size = new System.Drawing.Size(126, 23);
            this.btnPlayerTwoLife.TabIndex = 7;
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
            this.btnPlayerOneLife.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOneLife.Location = new System.Drawing.Point(36, 164);
            this.btnPlayerOneLife.Name = "btnPlayerOneLife";
            this.btnPlayerOneLife.Size = new System.Drawing.Size(126, 23);
            this.btnPlayerOneLife.TabIndex = 3;
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
            this.btnPlayerOnePlus.Text = "+";
            this.btnPlayerOnePlus.UseVisualStyleBackColor = true;
            this.btnPlayerOnePlus.Click += new System.EventHandler(this.btnPlayerOnePlus_Click);
            // 
            // lblPlayerOneTotals
            // 
            this.lblPlayerOneTotals.Font = new System.Drawing.Font("Bahnschrift Condensed", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOneTotals.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerOneTotals.Name = "lblPlayerOneTotals";
            this.lblPlayerOneTotals.Size = new System.Drawing.Size(192, 83);
            this.lblPlayerOneTotals.TabIndex = 0;
            this.lblPlayerOneTotals.Text = "20";
            this.lblPlayerOneTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayerThree
            // 
            this.pnlPlayerThree.AutoSize = true;
            this.pnlPlayerThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerThree.Controls.Add(this.panel5);
            this.pnlPlayerThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerThree.Location = new System.Drawing.Point(3, 486);
            this.pnlPlayerThree.Name = "pnlPlayerThree";
            this.pnlPlayerThree.Size = new System.Drawing.Size(410, 236);
            this.pnlPlayerThree.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblPlayerThreeTotals);
            this.panel5.Controls.Add(this.btnPlayerThreeLife);
            this.panel5.Controls.Add(this.btnPlayerThreeMinus);
            this.panel5.Controls.Add(this.btnPlayerThreePlus);
            this.panel5.Location = new System.Drawing.Point(18, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 200);
            this.panel5.TabIndex = 2;
            // 
            // lblPlayerThreeTotals
            // 
            this.lblPlayerThreeTotals.Font = new System.Drawing.Font("Bahnschrift Condensed", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerThreeTotals.Location = new System.Drawing.Point(3, -2);
            this.lblPlayerThreeTotals.Name = "lblPlayerThreeTotals";
            this.lblPlayerThreeTotals.Size = new System.Drawing.Size(192, 97);
            this.lblPlayerThreeTotals.TabIndex = 0;
            this.lblPlayerThreeTotals.Text = "20";
            this.lblPlayerThreeTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayerThreeLife
            // 
            this.btnPlayerThreeLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerThreeLife.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerThreeLife.Location = new System.Drawing.Point(36, 164);
            this.btnPlayerThreeLife.Name = "btnPlayerThreeLife";
            this.btnPlayerThreeLife.Size = new System.Drawing.Size(126, 23);
            this.btnPlayerThreeLife.TabIndex = 7;
            this.btnPlayerThreeLife.Text = "Life";
            this.btnPlayerThreeLife.UseVisualStyleBackColor = true;
            this.btnPlayerThreeLife.Click += new System.EventHandler(this.btnPlayerThreeLife_Click);
            // 
            // btnPlayerThreeMinus
            // 
            this.btnPlayerThreeMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerThreeMinus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerThreeMinus.Location = new System.Drawing.Point(102, 98);
            this.btnPlayerThreeMinus.Name = "btnPlayerThreeMinus";
            this.btnPlayerThreeMinus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerThreeMinus.TabIndex = 6;
            this.btnPlayerThreeMinus.Text = "-";
            this.btnPlayerThreeMinus.UseVisualStyleBackColor = true;
            this.btnPlayerThreeMinus.Click += new System.EventHandler(this.btnPlayerThreeMinus_Click);
            // 
            // btnPlayerThreePlus
            // 
            this.btnPlayerThreePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerThreePlus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerThreePlus.Location = new System.Drawing.Point(36, 98);
            this.btnPlayerThreePlus.Name = "btnPlayerThreePlus";
            this.btnPlayerThreePlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerThreePlus.TabIndex = 5;
            this.btnPlayerThreePlus.Text = "+";
            this.btnPlayerThreePlus.UseVisualStyleBackColor = true;
            this.btnPlayerThreePlus.Click += new System.EventHandler(this.btnPlayerThreePlus_Click);
            // 
            // FormThreePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 772);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormThreePlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Three players";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormThreePlayers_Load);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPlayerTwo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlPlayerOne.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlPlayerThree.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPlayerThree;
        private Panel panel5;
        private Label lblPlayerThreeTotals;
        private Button btnPlayerThreeLife;
        private Button btnPlayerThreeMinus;
        private Button btnPlayerThreePlus;
        private Panel pnlPlayerTwo;
        private Panel panel2;
        private Label lblPlayerTwoTotals;
        private Button btnPlayerTwoLife;
        private Button btnPlayerTwoMinus;
        private Button btnPlayerTwoPlus;
        private Panel pnlPlayerOne;
        private Panel panel1;
        private Button btnPlayerOneLife;
        private Button btnPlayerOneMinus;
        private Button btnPlayerOnePlus;
        private Label lblPlayerOneTotals;
    }
}