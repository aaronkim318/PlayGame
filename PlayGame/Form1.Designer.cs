
namespace PlayGame
{
    partial class BackGroundImage1
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
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.GameStartsIn1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.BackColor = System.Drawing.Color.Black;
            this.PlayGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameButton.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.Location = new System.Drawing.Point(306, 180);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(181, 69);
            this.PlayGameButton.TabIndex = 0;
            this.PlayGameButton.Text = "Press To Play";
            this.PlayGameButton.UseVisualStyleBackColor = false;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // GameStartsIn1
            // 
            this.GameStartsIn1.BackColor = System.Drawing.Color.Black;
            this.GameStartsIn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartsIn1.ForeColor = System.Drawing.Color.Black;
            this.GameStartsIn1.Location = new System.Drawing.Point(253, 307);
            this.GameStartsIn1.Name = "GameStartsIn1";
            this.GameStartsIn1.Size = new System.Drawing.Size(287, 55);
            this.GameStartsIn1.TabIndex = 1;
            this.GameStartsIn1.Text = "Game Starts In 3";
            this.GameStartsIn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameStartsIn1.Click += new System.EventHandler(this.GameStartsIn1_Click);
            // 
            // BackGroundImage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameStartsIn1);
            this.Controls.Add(this.PlayGameButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BackGroundImage1";
            this.Text = "Space Invaded";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Label GameStartsIn1;
    }
}

