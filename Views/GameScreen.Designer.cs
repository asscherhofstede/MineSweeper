namespace SimpleMinesweeper
{
    partial class GameScreen
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
            this.PanelGame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.Location = new System.Drawing.Point(12, 12);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(471, 422);
            this.PanelGame.TabIndex = 0;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 446);
            this.Controls.Add(this.PanelGame);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGame;
    }
}