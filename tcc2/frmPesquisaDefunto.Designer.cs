namespace tcc2
{
    partial class frmPesquisaDefunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaDefunto));
            this.dgvDefunto = new System.Windows.Forms.DataGridView();
            this.txtPesquisaGeralDefunto = new System.Windows.Forms.TextBox();
            this.lblPesquisaDefunto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefunto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDefunto
            // 
            this.dgvDefunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefunto.Location = new System.Drawing.Point(19, 85);
            this.dgvDefunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDefunto.Name = "dgvDefunto";
            this.dgvDefunto.Size = new System.Drawing.Size(951, 463);
            this.dgvDefunto.TabIndex = 8;
            this.dgvDefunto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefunto_CellContentClick);
            // 
            // txtPesquisaGeralDefunto
            // 
            this.txtPesquisaGeralDefunto.Location = new System.Drawing.Point(19, 39);
            this.txtPesquisaGeralDefunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaGeralDefunto.Name = "txtPesquisaGeralDefunto";
            this.txtPesquisaGeralDefunto.Size = new System.Drawing.Size(949, 22);
            this.txtPesquisaGeralDefunto.TabIndex = 7;
            this.txtPesquisaGeralDefunto.TextChanged += new System.EventHandler(this.txtPesquisaGeralDefunto_TextChanged);
            // 
            // lblPesquisaDefunto
            // 
            this.lblPesquisaDefunto.AutoSize = true;
            this.lblPesquisaDefunto.Location = new System.Drawing.Point(19, 20);
            this.lblPesquisaDefunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisaDefunto.Name = "lblPesquisaDefunto";
            this.lblPesquisaDefunto.Size = new System.Drawing.Size(70, 17);
            this.lblPesquisaDefunto.TabIndex = 6;
            this.lblPesquisaDefunto.Text = "Pesquisa:";
            // 
            // frmPesquisaDefunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 562);
            this.Controls.Add(this.dgvDefunto);
            this.Controls.Add(this.txtPesquisaGeralDefunto);
            this.Controls.Add(this.lblPesquisaDefunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPesquisaDefunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Geral - Falecido";
            this.Load += new System.EventHandler(this.frmPesquisaDefunto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDefunto;
        private System.Windows.Forms.TextBox txtPesquisaGeralDefunto;
        private System.Windows.Forms.Label lblPesquisaDefunto;
    }
}