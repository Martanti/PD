namespace PDV2
{
    partial class PradinisLaukas
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
            this.pnl_Pradinis = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Scoreboard = new System.Windows.Forms.Button();
            this.btn_Rules = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.pnl_Pradinis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Pradinis
            // 
            this.pnl_Pradinis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_Pradinis.Controls.Add(this.btn_Exit);
            this.pnl_Pradinis.Controls.Add(this.btn_Scoreboard);
            this.pnl_Pradinis.Controls.Add(this.btn_Rules);
            this.pnl_Pradinis.Controls.Add(this.btn_NewGame);
            this.pnl_Pradinis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Pradinis.Location = new System.Drawing.Point(0, 0);
            this.pnl_Pradinis.Name = "pnl_Pradinis";
            this.pnl_Pradinis.Size = new System.Drawing.Size(309, 291);
            this.pnl_Pradinis.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(74, 194);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(160, 23);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Išeiti";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Scoreboard
            // 
            this.btn_Scoreboard.Location = new System.Drawing.Point(74, 154);
            this.btn_Scoreboard.Name = "btn_Scoreboard";
            this.btn_Scoreboard.Size = new System.Drawing.Size(160, 23);
            this.btn_Scoreboard.TabIndex = 2;
            this.btn_Scoreboard.Text = "Top žaidėjų taškai";
            this.btn_Scoreboard.UseVisualStyleBackColor = true;
            this.btn_Scoreboard.Click += new System.EventHandler(this.btn_Scoreboard_Click);
            // 
            // btn_Rules
            // 
            this.btn_Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Rules.Location = new System.Drawing.Point(74, 114);
            this.btn_Rules.Name = "btn_Rules";
            this.btn_Rules.Size = new System.Drawing.Size(160, 23);
            this.btn_Rules.TabIndex = 1;
            this.btn_Rules.Text = "Taisyklės";
            this.btn_Rules.UseVisualStyleBackColor = false;
            this.btn_Rules.Click += new System.EventHandler(this.btn_Rules_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_NewGame.Location = new System.Drawing.Point(74, 74);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(160, 23);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "Pradėti naują žaidimą";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // PradinisLaukas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 291);
            this.Controls.Add(this.pnl_Pradinis);
            this.Name = "PradinisLaukas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Pradinis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Pradinis;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Scoreboard;
        private System.Windows.Forms.Button btn_Rules;
        private System.Windows.Forms.Button btn_NewGame;
    }
}

