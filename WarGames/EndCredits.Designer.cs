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
            this.EndCreditsPicture = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EndCreditsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // EndCreditsPicture
            // 
            this.EndCreditsPicture.Image = global::WarGames.Properties.Resources.aftermath_1;
            this.EndCreditsPicture.Location = new System.Drawing.Point(0, 0);
            this.EndCreditsPicture.Name = "EndCreditsPicture";
            this.EndCreditsPicture.Size = new System.Drawing.Size(1600, 900);
            this.EndCreditsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndCreditsPicture.TabIndex = 0;
            this.EndCreditsPicture.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(695, 677);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 58);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "End Game";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PlayAgainButton.Location = new System.Drawing.Point(467, 677);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(180, 58);
            this.PlayAgainButton.TabIndex = 2;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            // 
            // EndCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EndCreditsPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndCredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndCredits";
            ((System.ComponentModel.ISupportInitialize)(this.EndCreditsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EndCreditsPicture;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}