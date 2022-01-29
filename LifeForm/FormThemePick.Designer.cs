namespace LifeForm
{
    partial class FormThemePick
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
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhite
            // 
            this.btnWhite.AutoSize = true;
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.BackgroundImage = global::LifeForm.Properties.Resources.White;
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhite.Location = new System.Drawing.Point(0, 0);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(86, 86);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.AutoSize = true;
            this.btnBlack.BackColor = System.Drawing.Color.DimGray;
            this.btnBlack.BackgroundImage = global::LifeForm.Properties.Resources.Black;
            this.btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlack.Location = new System.Drawing.Point(92, 0);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(86, 86);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.AutoSize = true;
            this.btnBlue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBlue.BackgroundImage = global::LifeForm.Properties.Resources.Blue;
            this.btnBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlue.Location = new System.Drawing.Point(184, 0);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(86, 86);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.AutoSize = true;
            this.btnRed.BackColor = System.Drawing.Color.LightCoral;
            this.btnRed.BackgroundImage = global::LifeForm.Properties.Resources.Red;
            this.btnRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRed.Location = new System.Drawing.Point(276, 0);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(86, 86);
            this.btnRed.TabIndex = 3;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.AutoSize = true;
            this.btnGreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGreen.BackgroundImage = global::LifeForm.Properties.Resources.Green;
            this.btnGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreen.Location = new System.Drawing.Point(368, 0);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(86, 86);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // FormThemePick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(447, 79);
            this.ControlBox = false;
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormThemePick";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose a theme";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWhite;
        private Button btnBlack;
        private Button btnBlue;
        private Button btnRed;
        private Button btnGreen;
    }
}