﻿namespace LifeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPlayerTwo = new System.Windows.Forms.Panel();
            this.pnlPlayerOne = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 0;
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
            this.pnlPlayerTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerTwo.Location = new System.Drawing.Point(3, 245);
            this.pnlPlayerTwo.Name = "pnlPlayerTwo";
            this.pnlPlayerTwo.Size = new System.Drawing.Size(410, 237);
            this.pnlPlayerTwo.TabIndex = 0;
            // 
            // pnlPlayerOne
            // 
            this.pnlPlayerOne.AutoSize = true;
            this.pnlPlayerOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayerOne.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayerOne.Name = "pnlPlayerOne";
            this.pnlPlayerOne.Size = new System.Drawing.Size(410, 236);
            this.pnlPlayerOne.TabIndex = 1;
            // 
            // FormTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(416, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTwoPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Two players";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTwoPlayers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPlayerTwo;
        private Panel pnlPlayerOne;
    }
}