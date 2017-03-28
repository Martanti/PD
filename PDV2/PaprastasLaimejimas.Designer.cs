namespace PDV2
{
    partial class PaprastasLaimejimas
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(231, 104);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Išsaugoti ir išeiti";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(56, 104);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(125, 23);
            this.btn_Continue.TabIndex = 1;
            this.btn_Continue.Text = "Tęsti";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(168, 13);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(76, 13);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "Čia yra tekstas";
            // 
            // PaprastasLaimejimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 161);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_save);
            this.Name = "PaprastasLaimejimas";
            this.Text = "PaprastasLaimejimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Label lbl_text;
    }
}