namespace PDV2
{
    partial class TotalWin
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
            this.lbl_sveikinimai = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sveikinimai
            // 
            this.lbl_sveikinimai.AutoSize = true;
            this.lbl_sveikinimai.Location = new System.Drawing.Point(110, 40);
            this.lbl_sveikinimai.Name = "lbl_sveikinimai";
            this.lbl_sveikinimai.Size = new System.Drawing.Size(76, 13);
            this.lbl_sveikinimai.TabIndex = 0;
            this.lbl_sveikinimai.Text = "Čia yra tekstas";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(113, 179);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(129, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Išeiti į pradinį langą";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // TotalWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 295);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_sveikinimai);
            this.Name = "TotalWin";
            this.Text = "TotalWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sveikinimai;
        private System.Windows.Forms.Button btn_exit;
    }
}