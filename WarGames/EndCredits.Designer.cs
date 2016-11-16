namespace WarGames
{
    partial class EndCredits
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
            this.ExitGameBtn = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.ExitGameBtn.Location = new System.Drawing.Point(853, 651);
            this.ExitGameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(237, 84);
            this.ExitGameBtn.TabIndex = 3;
            this.ExitGameBtn.Text = "Exit Game";
            this.ExitGameBtn.UseVisualStyleBackColor = false;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PlayAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgainButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PlayAgainButton.FlatAppearance.BorderSize = 2;
            this.PlayAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.PlayAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.PlayAgainButton.Location = new System.Drawing.Point(493, 651);
            this.PlayAgainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(237, 84);
            this.PlayAgainButton.TabIndex = 4;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            // 
            // EndCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarGames.Properties.Resources.aftermath_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ExitGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndCredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndCredits";
            this.Load += new System.EventHandler(this.EndCredits_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitGameBtn;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}