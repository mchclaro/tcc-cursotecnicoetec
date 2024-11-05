namespace tcc2
{
    partial class frmPesquisaTumulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaTumulo));
            this.dgvTumulo = new System.Windows.Forms.DataGridView();
            this.txtPesquisaGeralTumulo = new System.Windows.Forms.TextBox();
            this.lblPesquisaTumulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTumulo
            // 
            this.dgvTumulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumulo.Location = new System.Drawing.Point(16, 82);
            this.dgvTumulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTumulo.Name = "dgvTumulo";
            this.dgvTumulo.Size = new System.Drawing.Size(953, 462);
            this.dgvTumulo.TabIndex = 5;
            this.dgvTumulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTumulo_CellContentClick);
            // 
            // txtPesquisaGeralTumulo
            // 
            this.txtPesquisaGeralTumulo.Location = new System.Drawing.Point(16, 37);
            this.txtPesquisaGeralTumulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaGeralTumulo.Name = "txtPesquisaGeralTumulo";
            this.txtPesquisaGeralTumulo.Size = new System.Drawing.Size(952, 22);
            this.txtPesquisaGeralTumulo.TabIndex = 4;
            this.txtPesquisaGeralTumulo.TextChanged += new System.EventHandler(this.txtPesquisaGeralTumulo_TextChanged);
            // 
            // lblPesquisaTumulo
            // 
            this.lblPesquisaTumulo.AutoSize = true;
            this.lblPesquisaTumulo.Location = new System.Drawing.Point(16, 17);
            this.lblPesquisaTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisaTumulo.Name = "lblPesquisaTumulo";
            this.lblPesquisaTumulo.Size = new System.Drawing.Size(70, 17);
            this.lblPesquisaTumulo.TabIndex = 3;
            this.lblPesquisaTumulo.Text = "Pesquisa:";
            // 
            // frmPesquisaTumulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 562);
            this.Controls.Add(this.dgvTumulo);
            this.Controls.Add(this.txtPesquisaGeralTumulo);
            this.Controls.Add(this.lblPesquisaTumulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPesquisaTumulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Geral - Túmulo";
            this.Load += new System.EventHandler(this.frmPesquisaTumulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTumulo;
        private System.Windows.Forms.TextBox txtPesquisaGeralTumulo;
        private System.Windows.Forms.Label lblPesquisaTumulo;
    }
}