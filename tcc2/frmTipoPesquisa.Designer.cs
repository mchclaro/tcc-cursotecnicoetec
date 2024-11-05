namespace tcc2
{
    partial class frmTipoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPesquisa));
            this.lblTipoPesquisa = new System.Windows.Forms.Label();
            this.btnPesquisaGeralTumulo = new System.Windows.Forms.Button();
            this.btnPesquisaGeralDefunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoPesquisa
            // 
            this.lblTipoPesquisa.AutoSize = true;
            this.lblTipoPesquisa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPesquisa.Location = new System.Drawing.Point(11, 9);
            this.lblTipoPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPesquisa.Name = "lblTipoPesquisa";
            this.lblTipoPesquisa.Size = new System.Drawing.Size(251, 18);
            this.lblTipoPesquisa.TabIndex = 0;
            this.lblTipoPesquisa.Text = "Qual pesquisa deseja realizar?";
            // 
            // btnPesquisaGeralTumulo
            // 
            this.btnPesquisaGeralTumulo.Location = new System.Drawing.Point(47, 43);
            this.btnPesquisaGeralTumulo.Name = "btnPesquisaGeralTumulo";
            this.btnPesquisaGeralTumulo.Size = new System.Drawing.Size(61, 40);
            this.btnPesquisaGeralTumulo.TabIndex = 1;
            this.btnPesquisaGeralTumulo.Text = "Túmulo";
            this.btnPesquisaGeralTumulo.UseVisualStyleBackColor = true;
            this.btnPesquisaGeralTumulo.Click += new System.EventHandler(this.btnPesquisaGeralTumulo_Click);
            // 
            // btnPesquisaGeralDefunto
            // 
            this.btnPesquisaGeralDefunto.Location = new System.Drawing.Point(151, 43);
            this.btnPesquisaGeralDefunto.Name = "btnPesquisaGeralDefunto";
            this.btnPesquisaGeralDefunto.Size = new System.Drawing.Size(61, 40);
            this.btnPesquisaGeralDefunto.TabIndex = 2;
            this.btnPesquisaGeralDefunto.Text = "Falecido";
            this.btnPesquisaGeralDefunto.UseVisualStyleBackColor = true;
            this.btnPesquisaGeralDefunto.Click += new System.EventHandler(this.btnPesquisaGeralDefunto_Click);
            // 
            // frmTipoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 110);
            this.Controls.Add(this.btnPesquisaGeralDefunto);
            this.Controls.Add(this.btnPesquisaGeralTumulo);
            this.Controls.Add(this.lblTipoPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Geral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPesquisa;
        private System.Windows.Forms.Button btnPesquisaGeralTumulo;
        private System.Windows.Forms.Button btnPesquisaGeralDefunto;
    }
}