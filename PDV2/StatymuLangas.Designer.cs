namespace PDV2
{
    partial class StatymuLangas
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
            this.txtBx_IncreaseStakes = new System.Windows.Forms.TextBox();
            this.lb_Stakes = new System.Windows.Forms.Label();
            this.btn_IncreaseStakes = new System.Windows.Forms.Button();
            this.lbl_taskai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx_IncreaseStakes
            // 
            this.txtBx_IncreaseStakes.Location = new System.Drawing.Point(202, 110);
            this.txtBx_IncreaseStakes.Name = "txtBx_IncreaseStakes";
            this.txtBx_IncreaseStakes.Size = new System.Drawing.Size(100, 20);
            this.txtBx_IncreaseStakes.TabIndex = 0;
            // 
            // lb_Stakes
            // 
            this.lb_Stakes.AutoSize = true;
            this.lb_Stakes.Location = new System.Drawing.Point(203, 70);
            this.lb_Stakes.Name = "lb_Stakes";
            this.lb_Stakes.Size = new System.Drawing.Size(98, 13);
            this.lb_Stakes.TabIndex = 1;
            this.lb_Stakes.Text = "Įveskite taškų kiekį";
            // 
            // btn_IncreaseStakes
            // 
            this.btn_IncreaseStakes.Location = new System.Drawing.Point(200, 166);
            this.btn_IncreaseStakes.Name = "btn_IncreaseStakes";
            this.btn_IncreaseStakes.Size = new System.Drawing.Size(104, 23);
            this.btn_IncreaseStakes.TabIndex = 2;
            this.btn_IncreaseStakes.Text = "Patvirtinti Sumą";
            this.btn_IncreaseStakes.UseVisualStyleBackColor = true;
            this.btn_IncreaseStakes.Click += new System.EventHandler(this.btn_IncreaseStakes_Click);
            // 
            // lbl_taskai
            // 
            this.lbl_taskai.AutoSize = true;
            this.lbl_taskai.Location = new System.Drawing.Point(12, 79);
            this.lbl_taskai.Name = "lbl_taskai";
            this.lbl_taskai.Size = new System.Drawing.Size(75, 13);
            this.lbl_taskai.TabIndex = 3;
            this.lbl_taskai.Text = "taškai eina čia";
            // 
            // StatymuLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 278);
            this.Controls.Add(this.lbl_taskai);
            this.Controls.Add(this.btn_IncreaseStakes);
            this.Controls.Add(this.lb_Stakes);
            this.Controls.Add(this.txtBx_IncreaseStakes);
            this.Name = "StatymuLangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatymuLangas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_IncreaseStakes;
        private System.Windows.Forms.Label lb_Stakes;
        private System.Windows.Forms.Button btn_IncreaseStakes;
        private System.Windows.Forms.Label lbl_taskai;
    }
}