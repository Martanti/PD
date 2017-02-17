namespace PDV2
{
    partial class PradinisStatymas
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
            this.lbl_CurrentPoints = new System.Windows.Forms.Label();
            this.lbl_PradinisStatimas = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.txtBx_Statymai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_CurrentPoints
            // 
            this.lbl_CurrentPoints.AutoSize = true;
            this.lbl_CurrentPoints.Location = new System.Drawing.Point(12, 88);
            this.lbl_CurrentPoints.Name = "lbl_CurrentPoints";
            this.lbl_CurrentPoints.Size = new System.Drawing.Size(87, 13);
            this.lbl_CurrentPoints.TabIndex = 0;
            this.lbl_CurrentPoints.Text = "Kiek Turite tasku";
            // 
            // lbl_PradinisStatimas
            // 
            this.lbl_PradinisStatimas.AutoSize = true;
            this.lbl_PradinisStatimas.Location = new System.Drawing.Point(174, 88);
            this.lbl_PradinisStatimas.Name = "lbl_PradinisStatimas";
            this.lbl_PradinisStatimas.Size = new System.Drawing.Size(134, 13);
            this.lbl_PradinisStatimas.TabIndex = 1;
            this.lbl_PradinisStatimas.Text = "Kiek taškų norite pastatyti?";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(204, 176);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Tęsti";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txtBx_Statymai
            // 
            this.txtBx_Statymai.Location = new System.Drawing.Point(191, 128);
            this.txtBx_Statymai.Name = "txtBx_Statymai";
            this.txtBx_Statymai.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Statymai.TabIndex = 3;
            // 
            // PradinisStatymas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.txtBx_Statymai);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_PradinisStatimas);
            this.Controls.Add(this.lbl_CurrentPoints);
            this.Name = "PradinisStatymas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pradinis Statymas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CurrentPoints;
        private System.Windows.Forms.Label lbl_PradinisStatimas;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txtBx_Statymai;
    }
}