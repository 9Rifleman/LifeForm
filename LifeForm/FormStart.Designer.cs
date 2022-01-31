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
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.btnFourPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.btnTwoPlayers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwoPlayers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwoPlayers.Location = new System.Drawing.Point(12, 12);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(142, 136);
            this.btnTwoPlayers.TabIndex = 0;
            this.btnTwoPlayers.Text = "2 players";
            this.btnTwoPlayers.UseVisualStyleBackColor = false;
            this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);
            // 
            // btnFourPlayers
            // 
            this.btnFourPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.btnFourPlayers.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFourPlayers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFourPlayers.Location = new System.Drawing.Point(160, 12);
            this.btnFourPlayers.Name = "btnFourPlayers";
            this.btnFourPlayers.Size = new System.Drawing.Size(140, 136);
            this.btnFourPlayers.TabIndex = 1;
            this.btnFourPlayers.Text = "4 players";
            this.btnFourPlayers.UseVisualStyleBackColor = false;
            this.btnFourPlayers.Click += new System.EventHandler(this.btnFourPlayers_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(312, 160);
            this.Controls.Add(this.btnFourPlayers);
            this.Controls.Add(this.btnTwoPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LifeForm v0.3.0.44";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTwoPlayers;
        private Button btnFourPlayers;
    }
}