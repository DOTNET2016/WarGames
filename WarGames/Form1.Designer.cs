namespace WarGames
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Background = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.CountryBox = new System.Windows.Forms.GroupBox();
            this.CountryListBox = new System.Windows.Forms.ListBox();
            this.PressStart = new System.Windows.Forms.Button();
            this.Background.SuspendLayout();
            this.CountryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.AutoSize = true;
            this.Background.BackgroundImage = global::WarGames.Properties.Resources.map;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Controls.Add(this.ExitButton);
            this.Background.Controls.Add(this.PauseButton);
            this.Background.Controls.Add(this.StartButton);
            this.Background.Controls.Add(this.CountryBox);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Margin = new System.Windows.Forms.Padding(4);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1685, 838);
            this.Background.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(215, 798);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 28);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PauseButton.BackColor = System.Drawing.SystemColors.Control;
            this.PauseButton.Enabled = false;
            this.PauseButton.ForeColor = System.Drawing.Color.Black;
            this.PauseButton.Location = new System.Drawing.Point(215, 736);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(80, 28);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(215, 700);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(80, 28);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CountryBox
            // 
            this.CountryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountryBox.BackColor = System.Drawing.Color.Transparent;
            this.CountryBox.Controls.Add(this.CountryListBox);
            this.CountryBox.ForeColor = System.Drawing.Color.White;
            this.CountryBox.Location = new System.Drawing.Point(0, 361);
            this.CountryBox.Margin = new System.Windows.Forms.Padding(4);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Padding = new System.Windows.Forms.Padding(4);
            this.CountryBox.Size = new System.Drawing.Size(205, 478);
            this.CountryBox.TabIndex = 0;
            this.CountryBox.TabStop = false;
            this.CountryBox.Text = "Countries";
            // 
            // CountryListBox
            // 
            this.CountryListBox.BackColor = System.Drawing.Color.Black;
            this.CountryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryListBox.FormattingEnabled = true;
            this.CountryListBox.ItemHeight = 16;
            this.CountryListBox.Location = new System.Drawing.Point(2, 15);
            this.CountryListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CountryListBox.Name = "CountryListBox";
            this.CountryListBox.Size = new System.Drawing.Size(196, 448);
            this.CountryListBox.TabIndex = 0;
            // 
            // PressStart
            // 
            this.PressStart.BackColor = System.Drawing.Color.Black;
            this.PressStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PressStart.BackgroundImage")));
            this.PressStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PressStart.FlatAppearance.BorderSize = 0;
            this.PressStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PressStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressStart.Location = new System.Drawing.Point(671, 537);
            this.PressStart.Margin = new System.Windows.Forms.Padding(4);
            this.PressStart.Name = "PressStart";
            this.PressStart.Size = new System.Drawing.Size(295, 137);
            this.PressStart.TabIndex = 0;
            this.PressStart.Text = "Press to Continue";
            this.PressStart.UseVisualStyleBackColor = false;
            this.PressStart.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Background.ResumeLayout(false);
            this.CountryBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.GroupBox CountryBox;
        private System.Windows.Forms.ListBox CountryListBox;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        //private System.Windows.Forms.Panel Popup;
        private System.Windows.Forms.Button PressStart;
        private System.Windows.Forms.Button ExitButton;
    }
}

