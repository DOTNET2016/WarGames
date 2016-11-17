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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroMenu));
            this.PlayGameBtn = new System.Windows.Forms.Button();
            this.ExitGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayGameBtn
            // 
            this.PlayGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PlayGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayGameBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PlayGameBtn.FlatAppearance.BorderSize = 2;
            this.PlayGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.PlayGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.PlayGameBtn.Location = new System.Drawing.Point(520, 590);
            this.PlayGameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayGameBtn.Name = "PlayGameBtn";
            this.PlayGameBtn.Size = new System.Drawing.Size(237, 84);
            this.PlayGameBtn.TabIndex = 1;
            this.PlayGameBtn.Text = "YES";
            this.PlayGameBtn.UseVisualStyleBackColor = false;
            // 
            // ExitGameBtn
            // 
            this.ExitGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExitGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitGameBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitGameBtn.FlatAppearance.BorderSize = 2;
            this.ExitGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ExitGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGameBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.ExitGameBtn.Location = new System.Drawing.Point(934, 590);
            this.ExitGameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(237, 84);
            this.ExitGameBtn.TabIndex = 2;
            this.ExitGameBtn.Text = "NO";
            this.ExitGameBtn.UseVisualStyleBackColor = false;
            // 
            // IntroMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarGames.Properties.Resources.ShallWePlay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.ExitGameBtn);
            this.Controls.Add(this.PlayGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroMenu";
            this.Load += new System.EventHandler(this.IntroMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayGameBtn;
        private System.Windows.Forms.Button ExitGameBtn;
    }
}