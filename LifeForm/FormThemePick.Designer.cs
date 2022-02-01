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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWhite
            // 
            this.btnWhite.AutoSize = true;
            this.btnWhite.BackColor = System.Drawing.Color.Ivory;
            this.btnWhite.BackgroundImage = global::LifeForm.Properties.Resources.White;
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Location = new System.Drawing.Point(9, 10);
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
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(101, 10);
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
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(193, 10);
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
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(285, 10);
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
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(377, 10);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(86, 86);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGreen);
            this.panel1.Controls.Add(this.btnRed);
            this.panel1.Controls.Add(this.btnBlue);
            this.panel1.Controls.Add(this.btnBlack);
            this.panel1.Controls.Add(this.btnWhite);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 106);
            this.panel1.TabIndex = 5;
            // 
            // FormThemePick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(496, 127);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormThemePick";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose a theme";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnWhite;
        private Button btnBlack;
        private Button btnBlue;
        private Button btnRed;
        private Button btnGreen;
        private Panel panel1;
    }
}