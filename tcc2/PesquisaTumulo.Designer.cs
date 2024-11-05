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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravarTumulo = new System.Windows.Forms.Button();
            this.btnEditarTumulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(372, 292);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 52);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravarTumulo
            // 
            this.btnGravarTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravarTumulo.BackgroundImage")));
            this.btnGravarTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGravarTumulo.Location = new System.Drawing.Point(249, 292);
            this.btnGravarTumulo.Name = "btnGravarTumulo";
            this.btnGravarTumulo.Size = new System.Drawing.Size(48, 52);
            this.btnGravarTumulo.TabIndex = 59;
            this.btnGravarTumulo.UseVisualStyleBackColor = true;
            // 
            // btnEditarTumulo
            // 
            this.btnEditarTumulo.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarTumulo.BackgroundImage")));
            this.btnEditarTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarTumulo.Location = new System.Drawing.Point(311, 292);
            this.btnEditarTumulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarTumulo.Name = "btnEditarTumulo";
            this.btnEditarTumulo.Size = new System.Drawing.Size(48, 52);
            this.btnEditarTumulo.TabIndex = 60;
            this.btnEditarTumulo.UseVisualStyleBackColor = false;
            // 
            // frmPesquisaTumulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 355);
            this.Controls.Add(this.btnEditarTumulo);
            this.Controls.Add(this.btnGravarTumulo);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisaTumulo";
            this.Text = "Consulta Túmulo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravarTumulo;
        private System.Windows.Forms.Button btnEditarTumulo;


    }
}