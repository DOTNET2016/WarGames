namespace WarGames
{
    partial class IntroMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayGameBtn = new System.Windows.Forms.Button();
            this.CustomizeGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarGames.Properties.Resources.ShallWePlay;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1669, 792);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayGameBtn
            // 
            this.PlayGameBtn.BackColor = System.Drawing.Color.Red;
            this.PlayGameBtn.Font = new System.Drawing.Font("DS-Digital", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameBtn.Location = new System.Drawing.Point(361, 642);
            this.PlayGameBtn.Name = "PlayGameBtn";
            this.PlayGameBtn.Size = new System.Drawing.Size(237, 84);
            this.PlayGameBtn.TabIndex = 1;
            this.PlayGameBtn.Text = "Play Game";
            this.PlayGameBtn.UseVisualStyleBackColor = false;
            this.PlayGameBtn.Click += new System.EventHandler(this.PlayGameBtn_Click);
            // 
            // CustomizeGameBtn
            // 
            this.CustomizeGameBtn.BackColor = System.Drawing.Color.Red;
            this.CustomizeGameBtn.Font = new System.Drawing.Font("DS-Digital", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomizeGameBtn.Location = new System.Drawing.Point(1062, 642);
            this.CustomizeGameBtn.Name = "CustomizeGameBtn";
            this.CustomizeGameBtn.Size = new System.Drawing.Size(237, 84);
            this.CustomizeGameBtn.TabIndex = 2;
            this.CustomizeGameBtn.Text = "Customize Game";
            this.CustomizeGameBtn.UseVisualStyleBackColor = false;
            this.CustomizeGameBtn.Click += new System.EventHandler(this.CustomizeGameBtn_Click);
            // 
            // IntroMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 791);
            this.Controls.Add(this.CustomizeGameBtn);
            this.Controls.Add(this.PlayGameBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayGameBtn;
        private System.Windows.Forms.Button CustomizeGameBtn;
    }
}