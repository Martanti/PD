namespace PDV2
{
    partial class ZaidimoLaukas
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
            this.btn_NewFigure = new System.Windows.Forms.Button();
            this.btn_IncreaseStakes = new System.Windows.Forms.Button();
            this.btn_EndRound = new System.Windows.Forms.Button();
            this.lbl_TurimosFiguros = new System.Windows.Forms.Label();
            this.lbl_Taskai = new System.Windows.Forms.Label();
            this.lbl_CurrentStakes = new System.Windows.Forms.Label();
            this.btn_Rules = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_NewFigure
            // 
            this.btn_NewFigure.Location = new System.Drawing.Point(8, 208);
            this.btn_NewFigure.Name = "btn_NewFigure";
            this.btn_NewFigure.Size = new System.Drawing.Size(664, 40);
            this.btn_NewFigure.TabIndex = 0;
            this.btn_NewFigure.Text = "Traukti naują figurą";
            this.btn_NewFigure.UseVisualStyleBackColor = true;
            this.btn_NewFigure.Click += new System.EventHandler(this.btn_NewFigure_Click);
            // 
            // btn_IncreaseStakes
            // 
            this.btn_IncreaseStakes.Location = new System.Drawing.Point(8, 256);
            this.btn_IncreaseStakes.Name = "btn_IncreaseStakes";
            this.btn_IncreaseStakes.Size = new System.Drawing.Size(664, 40);
            this.btn_IncreaseStakes.TabIndex = 1;
            this.btn_IncreaseStakes.Text = "Didinti taškų statymus\r\n";
            this.btn_IncreaseStakes.UseVisualStyleBackColor = true;
            this.btn_IncreaseStakes.Click += new System.EventHandler(this.btn_IncreaseStakes_Click);
            // 
            // btn_EndRound
            // 
            this.btn_EndRound.Location = new System.Drawing.Point(8, 304);
            this.btn_EndRound.Name = "btn_EndRound";
            this.btn_EndRound.Size = new System.Drawing.Size(664, 40);
            this.btn_EndRound.TabIndex = 2;
            this.btn_EndRound.Text = "Užbaigti raundą";
            this.btn_EndRound.UseVisualStyleBackColor = true;
            this.btn_EndRound.Click += new System.EventHandler(this.btn_EndRound_Click);
            // 
            // lbl_TurimosFiguros
            // 
            this.lbl_TurimosFiguros.AutoSize = true;
            this.lbl_TurimosFiguros.Location = new System.Drawing.Point(8, 8);
            this.lbl_TurimosFiguros.Name = "lbl_TurimosFiguros";
            this.lbl_TurimosFiguros.Size = new System.Drawing.Size(59, 13);
            this.lbl_TurimosFiguros.TabIndex = 3;
            this.lbl_TurimosFiguros.Text = "Čia yra pvz";
            // 
            // lbl_Taskai
            // 
            this.lbl_Taskai.AutoSize = true;
            this.lbl_Taskai.Location = new System.Drawing.Point(440, 8);
            this.lbl_Taskai.Name = "lbl_Taskai";
            this.lbl_Taskai.Size = new System.Drawing.Size(128, 13);
            this.lbl_Taskai.TabIndex = 4;
            this.lbl_Taskai.Text = "Čia yra vaizduojami taškai";
            // 
            // lbl_CurrentStakes
            // 
            this.lbl_CurrentStakes.AutoSize = true;
            this.lbl_CurrentStakes.Location = new System.Drawing.Point(264, 8);
            this.lbl_CurrentStakes.Name = "lbl_CurrentStakes";
            this.lbl_CurrentStakes.Size = new System.Drawing.Size(76, 13);
            this.lbl_CurrentStakes.TabIndex = 5;
            this.lbl_CurrentStakes.Text = "Statymų taškai";
            // 
            // btn_Rules
            // 
            this.btn_Rules.Location = new System.Drawing.Point(11, 350);
            this.btn_Rules.Name = "btn_Rules";
            this.btn_Rules.Size = new System.Drawing.Size(328, 40);
            this.btn_Rules.TabIndex = 6;
            this.btn_Rules.Text = "Taisyklės";
            this.btn_Rules.UseVisualStyleBackColor = true;
            this.btn_Rules.Click += new System.EventHandler(this.btn_Rules_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(345, 350);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(328, 40);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Nutraukti žaidimą ir išeiti";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ZaidimoLaukas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 403);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Rules);
            this.Controls.Add(this.lbl_CurrentStakes);
            this.Controls.Add(this.lbl_Taskai);
            this.Controls.Add(this.lbl_TurimosFiguros);
            this.Controls.Add(this.btn_EndRound);
            this.Controls.Add(this.btn_IncreaseStakes);
            this.Controls.Add(this.btn_NewFigure);
            this.Name = "ZaidimoLaukas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewFigure;
        private System.Windows.Forms.Button btn_IncreaseStakes;
        private System.Windows.Forms.Button btn_EndRound;
        private System.Windows.Forms.Label lbl_TurimosFiguros;
        private System.Windows.Forms.Label lbl_Taskai;
        private System.Windows.Forms.Label lbl_CurrentStakes;
        private System.Windows.Forms.Button btn_Rules;
        private System.Windows.Forms.Button btn_Exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}