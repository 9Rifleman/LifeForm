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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPlayerTwoTotals = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlPlayerOne = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayerOnePoison = new System.Windows.Forms.Button();
            this.btnPlayerOneLife = new System.Windows.Forms.Button();
            this.btnPlayerOneMinus = new System.Windows.Forms.Button();
            this.btnPlayerOnePlus = new System.Windows.Forms.Button();
            this.lblPlayerOneTotals = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPlayerTwo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPlayerOne.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerTwo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerOne, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblPlayerTwoTotals);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(18, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(102, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Poison";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPlayerTwoTotals
            // 
            this.lblPlayerTwoTotals.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTwoTotals.Location = new System.Drawing.Point(3, -2);
            this.lblPlayerTwoTotals.Name = "lblPlayerTwoTotals";
            this.lblPlayerTwoTotals.Size = new System.Drawing.Size(192, 97);
            this.lblPlayerTwoTotals.TabIndex = 0;
            this.lblPlayerTwoTotals.Text = "999";
            this.lblPlayerTwoTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(36, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Life";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(102, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(36, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.btnPlayerOnePoison);
            this.panel1.Controls.Add(this.btnPlayerOneLife);
            this.panel1.Controls.Add(this.btnPlayerOneMinus);
            this.panel1.Controls.Add(this.btnPlayerOnePlus);
            this.panel1.Controls.Add(this.lblPlayerOneTotals);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 1;
            // 
            // btnPlayerOnePoison
            // 
            this.btnPlayerOnePoison.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOnePoison.Location = new System.Drawing.Point(102, 164);
            this.btnPlayerOnePoison.Name = "btnPlayerOnePoison";
            this.btnPlayerOnePoison.Size = new System.Drawing.Size(60, 23);
            this.btnPlayerOnePoison.TabIndex = 4;
            this.btnPlayerOnePoison.Text = "Poison";
            this.btnPlayerOnePoison.UseVisualStyleBackColor = true;
            // 
            // btnPlayerOneLife
            // 
            this.btnPlayerOneLife.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOneLife.Location = new System.Drawing.Point(36, 164);
            this.btnPlayerOneLife.Name = "btnPlayerOneLife";
            this.btnPlayerOneLife.Size = new System.Drawing.Size(60, 23);
            this.btnPlayerOneLife.TabIndex = 3;
            this.btnPlayerOneLife.Text = "Life";
            this.btnPlayerOneLife.UseVisualStyleBackColor = true;
            // 
            // btnPlayerOneMinus
            // 
            this.btnPlayerOneMinus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOneMinus.Location = new System.Drawing.Point(102, 98);
            this.btnPlayerOneMinus.Name = "btnPlayerOneMinus";
            this.btnPlayerOneMinus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerOneMinus.TabIndex = 2;
            this.btnPlayerOneMinus.Text = "-";
            this.btnPlayerOneMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlayerOnePlus
            // 
            this.btnPlayerOnePlus.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayerOnePlus.Location = new System.Drawing.Point(36, 98);
            this.btnPlayerOnePlus.Name = "btnPlayerOnePlus";
            this.btnPlayerOnePlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlayerOnePlus.TabIndex = 1;
            this.btnPlayerOnePlus.Text = "+";
            this.btnPlayerOnePlus.UseVisualStyleBackColor = true;
            // 
            // lblPlayerOneTotals
            // 
            this.lblPlayerOneTotals.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOneTotals.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerOneTotals.Name = "lblPlayerOneTotals";
            this.lblPlayerOneTotals.Size = new System.Drawing.Size(192, 83);
            this.lblPlayerOneTotals.TabIndex = 0;
            this.lblPlayerOneTotals.Text = "999";
            this.lblPlayerOneTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(416, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTwoPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Two players";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTwoPlayers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPlayerTwo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlPlayerOne.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private Button btnPlayerOnePoison;
        private Button btnPlayerOneLife;
        private Button btnPlayerOneMinus;
        private Button btnPlayerOnePlus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}