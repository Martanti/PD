namespace PDV2
{
    partial class Nugaletojai
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
            this.components = new System.ComponentModel.Container();
            this.pDNugaletojuSarasasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pD_NugaletojuSarasasDataSet = new PDV2.PD_NugaletojuSarasasDataSet();
            this.lbl_top = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pDNugaletojuSarasasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pD_NugaletojuSarasasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pDNugaletojuSarasasDataSetBindingSource
            // 
            this.pDNugaletojuSarasasDataSetBindingSource.DataSource = this.pD_NugaletojuSarasasDataSet;
            this.pDNugaletojuSarasasDataSetBindingSource.Position = 0;
            // 
            // pD_NugaletojuSarasasDataSet
            // 
            this.pD_NugaletojuSarasasDataSet.DataSetName = "PD_NugaletojuSarasasDataSet";
            this.pD_NugaletojuSarasasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Location = new System.Drawing.Point(13, 13);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(35, 13);
            this.lbl_top.TabIndex = 0;
            this.lbl_top.Text = "label1";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(200, 361);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Išeiti";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Nugaletojai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 396);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_top);
            this.Name = "Nugaletojai";
            this.Text = "Nugaletojai";
            ((System.ComponentModel.ISupportInitialize)(this.pDNugaletojuSarasasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pD_NugaletojuSarasasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pDNugaletojuSarasasDataSetBindingSource;
        private PD_NugaletojuSarasasDataSet pD_NugaletojuSarasasDataSet;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Button btn_Exit;
    }
}