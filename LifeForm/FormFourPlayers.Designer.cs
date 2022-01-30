namespace LifeForm
{
    partial class FormFourPlayers
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
            this.pnlPlayerFour = new System.Windows.Forms.Panel();
            this.pnlPlayerThree = new System.Windows.Forms.Panel();
            this.pnlPlayerOne = new System.Windows.Forms.Panel();
            this.pnlPlayerTwo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerFour, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerThree, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPlayerTwo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPlayerFour
            // 
            this.pnlPlayerFour.AutoSize = true;
            this.pnlPlayerFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerFour.Location = new System.Drawing.Point(420, 246);
            this.pnlPlayerFour.Name = "pnlPlayerFour";
            this.pnlPlayerFour.Size = new System.Drawing.Size(411, 238);
            this.pnlPlayerFour.TabIndex = 0;
            // 
            // pnlPlayerThree
            // 
            this.pnlPlayerThree.AutoSize = true;
            this.pnlPlayerThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerThree.Location = new System.Drawing.Point(3, 246);
            this.pnlPlayerThree.Name = "pnlPlayerThree";
            this.pnlPlayerThree.Size = new System.Drawing.Size(411, 238);
            this.pnlPlayerThree.TabIndex = 0;
            // 
            // pnlPlayerOne
            // 
            this.pnlPlayerOne.AutoSize = true;
            this.pnlPlayerOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerOne.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayerOne.Name = "pnlPlayerOne";
            this.pnlPlayerOne.Size = new System.Drawing.Size(411, 237);
            this.pnlPlayerOne.TabIndex = 0;
            // 
            // pnlPlayerTwo
            // 
            this.pnlPlayerTwo.AutoSize = true;
            this.pnlPlayerTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerTwo.Location = new System.Drawing.Point(420, 3);
            this.pnlPlayerTwo.Name = "pnlPlayerTwo";
            this.pnlPlayerTwo.Size = new System.Drawing.Size(411, 237);
            this.pnlPlayerTwo.TabIndex = 1;
            // 
            // FormFourPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFourPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Four players";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormFourPlayers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPlayerFour;
        private Panel pnlPlayerThree;
        private Panel pnlPlayerOne;
        private Panel pnlPlayerTwo;
    }
}