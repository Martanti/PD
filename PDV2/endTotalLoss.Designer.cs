namespace PDV2
{
    partial class EndTotalLoss
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
            this.lbl_FinalText = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FinalText
            // 
            this.lbl_FinalText.AutoSize = true;
            this.lbl_FinalText.Location = new System.Drawing.Point(54, 21);
            this.lbl_FinalText.Name = "lbl_FinalText";
            this.lbl_FinalText.Size = new System.Drawing.Size(76, 13);
            this.lbl_FinalText.TabIndex = 0;
            this.lbl_FinalText.Text = "Čia yra tekstas";
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(57, 89);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(106, 23);
            this.btn_NewGame.TabIndex = 1;
            this.btn_NewGame.Text = "Pradėti iš naujo";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(205, 89);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(106, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Išeiti";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // EndTotalLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 129);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.lbl_FinalText);
            this.Name = "EndTotalLoss";
            this.Text = "Visiškai pralaimėjai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FinalText;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_exit;
    }
}