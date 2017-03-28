namespace PDV2
{
    partial class ArTikraiNoriIseiti
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
            this.lbl_BeforeExiting = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_NoSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_BeforeExiting
            // 
            this.lbl_BeforeExiting.AutoSize = true;
            this.lbl_BeforeExiting.Location = new System.Drawing.Point(131, 9);
            this.lbl_BeforeExiting.Name = "lbl_BeforeExiting";
            this.lbl_BeforeExiting.Size = new System.Drawing.Size(76, 13);
            this.lbl_BeforeExiting.TabIndex = 0;
            this.lbl_BeforeExiting.Text = "Čia yra tekstas";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(114, 98);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Išsaugoti";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_NoSave
            // 
            this.btn_NoSave.Location = new System.Drawing.Point(333, 98);
            this.btn_NoSave.Name = "btn_NoSave";
            this.btn_NoSave.Size = new System.Drawing.Size(75, 23);
            this.btn_NoSave.TabIndex = 2;
            this.btn_NoSave.Text = "Neišsaugoti";
            this.btn_NoSave.UseVisualStyleBackColor = true;
            this.btn_NoSave.Click += new System.EventHandler(this.btn_NoSave_Click);
            // 
            // ArTikraiNoriIseiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 133);
            this.Controls.Add(this.btn_NoSave);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_BeforeExiting);
            this.Name = "ArTikraiNoriIseiti";
            this.Text = "ArTikraiNoriIseiti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BeforeExiting;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_NoSave;
    }
}