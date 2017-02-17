namespace PDV2
{
    partial class NewPlayer
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
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.txtBx_playerName = new System.Windows.Forms.TextBox();
            this.btn_createPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(181, 32);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(141, 13);
            this.lbl_playerName.TabIndex = 0;
            this.lbl_playerName.Text = "Prašome įvesti žaidėjo vardą";
            // 
            // txtBx_playerName
            // 
            this.txtBx_playerName.Location = new System.Drawing.Point(201, 80);
            this.txtBx_playerName.Name = "txtBx_playerName";
            this.txtBx_playerName.Size = new System.Drawing.Size(100, 20);
            this.txtBx_playerName.TabIndex = 1;
            // 
            // btn_createPlayer
            // 
            this.btn_createPlayer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_createPlayer.Location = new System.Drawing.Point(202, 136);
            this.btn_createPlayer.Name = "btn_createPlayer";
            this.btn_createPlayer.Size = new System.Drawing.Size(98, 23);
            this.btn_createPlayer.TabIndex = 2;
            this.btn_createPlayer.Text = "Sukurti žaidėją";
            this.btn_createPlayer.UseVisualStyleBackColor = false;
            this.btn_createPlayer.Click += new System.EventHandler(this.btn_createPlayer_Click);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 258);
            this.Controls.Add(this.btn_createPlayer);
            this.Controls.Add(this.txtBx_playerName);
            this.Controls.Add(this.lbl_playerName);
            this.Name = "NewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Žaidėjo sukurimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.TextBox txtBx_playerName;
        private System.Windows.Forms.Button btn_createPlayer;
    }
}