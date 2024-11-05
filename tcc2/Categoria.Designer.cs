namespace tcc2
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblValorCaixao = new System.Windows.Forms.Label();
            this.txtValorCaixao = new System.Windows.Forms.TextBox();
            this.lblFlores = new System.Windows.Forms.Label();
            this.txtFlores = new System.Windows.Forms.TextBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.txtCarro = new System.Windows.Forms.TextBox();
            this.lblCoroaDeFlores = new System.Windows.Forms.Label();
            this.txtCoroaDeFlores = new System.Windows.Forms.TextBox();
            this.lblParamentacao = new System.Windows.Forms.Label();
            this.txtParamentacao = new System.Windows.Forms.TextBox();
            this.lblHigienizaçao = new System.Windows.Forms.Label();
            this.txtHigienizacao = new System.Windows.Forms.TextBox();
            this.lblVeu = new System.Windows.Forms.Label();
            this.txtVeu = new System.Windows.Forms.TextBox();
            this.grpFalecido = new System.Windows.Forms.GroupBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblEditarCategoria = new System.Windows.Forms.Label();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.lblGravarCategoria = new System.Windows.Forms.Label();
            this.btnGravarCategoria = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblCancelarCategoria = new System.Windows.Forms.Label();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.grpFalecido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 11);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "",
            "Urna sem visor ",
            "Urna com visor ",
            "Urna Médio Luxo Busquet",
            "Urna Luxo Busquet",
            "Urna Luxo 01",
            "Urna Luxo 02",
            "Urna Luxo 03",
            "Urna Luxo 04",
            "Urna Super Luxo 01",
            "Urna Super Luxo 02"});
            this.cmbModelo.Location = new System.Drawing.Point(20, 31);
            this.cmbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(190, 24);
            this.cmbModelo.TabIndex = 1;
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            this.cmbModelo.SelectionChangeCommitted += new System.EventHandler(this.cmbModelo_SelectionChangeCommitted);
            // 
            // lblValorCaixao
            // 
            this.lblValorCaixao.AutoSize = true;
            this.lblValorCaixao.Location = new System.Drawing.Point(265, 11);
            this.lblValorCaixao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorCaixao.Name = "lblValorCaixao";
            this.lblValorCaixao.Size = new System.Drawing.Size(89, 17);
            this.lblValorCaixao.TabIndex = 2;
            this.lblValorCaixao.Text = "Valor caixão:";
            // 
            // txtValorCaixao
            // 
            this.txtValorCaixao.Enabled = false;
            this.txtValorCaixao.Location = new System.Drawing.Point(269, 32);
            this.txtValorCaixao.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorCaixao.Name = "txtValorCaixao";
            this.txtValorCaixao.Size = new System.Drawing.Size(132, 22);
            this.txtValorCaixao.TabIndex = 2;
            // 
            // lblFlores
            // 
            this.lblFlores.AutoSize = true;
            this.lblFlores.Location = new System.Drawing.Point(16, 92);
            this.lblFlores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlores.Name = "lblFlores";
            this.lblFlores.Size = new System.Drawing.Size(168, 17);
            this.lblFlores.TabIndex = 4;
            this.lblFlores.Text = "Ornamentação em flores:";
            // 
            // txtFlores
            // 
            this.txtFlores.Enabled = false;
            this.txtFlores.Location = new System.Drawing.Point(20, 112);
            this.txtFlores.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlores.Name = "txtFlores";
            this.txtFlores.Size = new System.Drawing.Size(132, 22);
            this.txtFlores.TabIndex = 3;
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(16, 252);
            this.lblCarro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(104, 17);
            this.lblCarro.TabIndex = 6;
            this.lblCarro.Text = "Carro Funebre:";
            // 
            // txtCarro
            // 
            this.txtCarro.Enabled = false;
            this.txtCarro.Location = new System.Drawing.Point(20, 272);
            this.txtCarro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarro.Name = "txtCarro";
            this.txtCarro.Size = new System.Drawing.Size(132, 22);
            this.txtCarro.TabIndex = 8;
            // 
            // lblCoroaDeFlores
            // 
            this.lblCoroaDeFlores.AutoSize = true;
            this.lblCoroaDeFlores.Location = new System.Drawing.Point(263, 92);
            this.lblCoroaDeFlores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoroaDeFlores.Name = "lblCoroaDeFlores";
            this.lblCoroaDeFlores.Size = new System.Drawing.Size(140, 17);
            this.lblCoroaDeFlores.TabIndex = 8;
            this.lblCoroaDeFlores.Text = "Uma coroa de flores:";
            // 
            // txtCoroaDeFlores
            // 
            this.txtCoroaDeFlores.Enabled = false;
            this.txtCoroaDeFlores.Location = new System.Drawing.Point(269, 112);
            this.txtCoroaDeFlores.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoroaDeFlores.Name = "txtCoroaDeFlores";
            this.txtCoroaDeFlores.Size = new System.Drawing.Size(132, 22);
            this.txtCoroaDeFlores.TabIndex = 4;
            // 
            // lblParamentacao
            // 
            this.lblParamentacao.AutoSize = true;
            this.lblParamentacao.Location = new System.Drawing.Point(8, 27);
            this.lblParamentacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParamentacao.Name = "lblParamentacao";
            this.lblParamentacao.Size = new System.Drawing.Size(170, 17);
            this.lblParamentacao.TabIndex = 10;
            this.lblParamentacao.Text = "Paramentação de velório:";
            // 
            // txtParamentacao
            // 
            this.txtParamentacao.Enabled = false;
            this.txtParamentacao.Location = new System.Drawing.Point(12, 47);
            this.txtParamentacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtParamentacao.Name = "txtParamentacao";
            this.txtParamentacao.Size = new System.Drawing.Size(132, 22);
            this.txtParamentacao.TabIndex = 5;
            // 
            // lblHigienizaçao
            // 
            this.lblHigienizaçao.AutoSize = true;
            this.lblHigienizaçao.Location = new System.Drawing.Point(212, 27);
            this.lblHigienizaçao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHigienizaçao.Name = "lblHigienizaçao";
            this.lblHigienizaçao.Size = new System.Drawing.Size(93, 17);
            this.lblHigienizaçao.TabIndex = 12;
            this.lblHigienizaçao.Text = "Higienização:";
            // 
            // txtHigienizacao
            // 
            this.txtHigienizacao.Enabled = false;
            this.txtHigienizacao.Location = new System.Drawing.Point(219, 47);
            this.txtHigienizacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtHigienizacao.Name = "txtHigienizacao";
            this.txtHigienizacao.Size = new System.Drawing.Size(132, 22);
            this.txtHigienizacao.TabIndex = 6;
            // 
            // lblVeu
            // 
            this.lblVeu.AutoSize = true;
            this.lblVeu.Location = new System.Drawing.Point(407, 27);
            this.lblVeu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeu.Name = "lblVeu";
            this.lblVeu.Size = new System.Drawing.Size(37, 17);
            this.lblVeu.TabIndex = 14;
            this.lblVeu.Text = "Véu:";
            // 
            // txtVeu
            // 
            this.txtVeu.Enabled = false;
            this.txtVeu.Location = new System.Drawing.Point(411, 47);
            this.txtVeu.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeu.Name = "txtVeu";
            this.txtVeu.Size = new System.Drawing.Size(132, 22);
            this.txtVeu.TabIndex = 7;
            // 
            // grpFalecido
            // 
            this.grpFalecido.Controls.Add(this.lblVeu);
            this.grpFalecido.Controls.Add(this.txtParamentacao);
            this.grpFalecido.Controls.Add(this.txtHigienizacao);
            this.grpFalecido.Controls.Add(this.lblParamentacao);
            this.grpFalecido.Controls.Add(this.txtVeu);
            this.grpFalecido.Controls.Add(this.lblHigienizaçao);
            this.grpFalecido.Location = new System.Drawing.Point(20, 153);
            this.grpFalecido.Margin = new System.Windows.Forms.Padding(4);
            this.grpFalecido.Name = "grpFalecido";
            this.grpFalecido.Padding = new System.Windows.Forms.Padding(4);
            this.grpFalecido.Size = new System.Drawing.Size(568, 86);
            this.grpFalecido.TabIndex = 5;
            this.grpFalecido.TabStop = false;
            this.grpFalecido.Text = "Falecido";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(16, 320);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(93, 17);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblEditarCategoria
            // 
            this.lblEditarCategoria.AutoSize = true;
            this.lblEditarCategoria.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCategoria.Location = new System.Drawing.Point(323, 320);
            this.lblEditarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarCategoria.Name = "lblEditarCategoria";
            this.lblEditarCategoria.Size = new System.Drawing.Size(69, 23);
            this.lblEditarCategoria.TabIndex = 103;
            this.lblEditarCategoria.Text = "Editar";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarCategoria.BackgroundImage")));
            this.btnEditarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarCategoria.Location = new System.Drawing.Point(327, 254);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(64, 64);
            this.btnEditarCategoria.TabIndex = 10;
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // lblGravarCategoria
            // 
            this.lblGravarCategoria.AutoSize = true;
            this.lblGravarCategoria.Enabled = false;
            this.lblGravarCategoria.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravarCategoria.Location = new System.Drawing.Point(415, 320);
            this.lblGravarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGravarCategoria.Name = "lblGravarCategoria";
            this.lblGravarCategoria.Size = new System.Drawing.Size(77, 23);
            this.lblGravarCategoria.TabIndex = 111;
            this.lblGravarCategoria.Text = "Gravar";
            // 
            // btnGravarCategoria
            // 
            this.btnGravarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravarCategoria.BackgroundImage")));
            this.btnGravarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGravarCategoria.Enabled = false;
            this.btnGravarCategoria.Location = new System.Drawing.Point(419, 254);
            this.btnGravarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarCategoria.Name = "btnGravarCategoria";
            this.btnGravarCategoria.Size = new System.Drawing.Size(64, 64);
            this.btnGravarCategoria.TabIndex = 11;
            this.btnGravarCategoria.UseVisualStyleBackColor = true;
            this.btnGravarCategoria.Click += new System.EventHandler(this.btnGravarCategoria_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(16, 340);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 22);
            this.txtValor.TabIndex = 9;
            // 
            // lblCancelarCategoria
            // 
            this.lblCancelarCategoria.AutoSize = true;
            this.lblCancelarCategoria.Enabled = false;
            this.lblCancelarCategoria.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarCategoria.Location = new System.Drawing.Point(505, 320);
            this.lblCancelarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelarCategoria.Name = "lblCancelarCategoria";
            this.lblCancelarCategoria.Size = new System.Drawing.Size(97, 23);
            this.lblCancelarCategoria.TabIndex = 113;
            this.lblCancelarCategoria.Text = "Cancelar";
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarCategoria.BackgroundImage")));
            this.btnCancelarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarCategoria.Enabled = false;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(524, 254);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(64, 64);
            this.btnCancelarCategoria.TabIndex = 114;
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 393);
            this.Controls.Add(this.lblCancelarCategoria);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblGravarCategoria);
            this.Controls.Add(this.btnGravarCategoria);
            this.Controls.Add(this.lblEditarCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.grpFalecido);
            this.Controls.Add(this.txtCoroaDeFlores);
            this.Controls.Add(this.lblCoroaDeFlores);
            this.Controls.Add(this.txtCarro);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.txtFlores);
            this.Controls.Add(this.lblFlores);
            this.Controls.Add(this.txtValorCaixao);
            this.Controls.Add(this.lblValorCaixao);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.lblModelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.grpFalecido.ResumeLayout(false);
            this.grpFalecido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblValorCaixao;
        private System.Windows.Forms.TextBox txtValorCaixao;
        private System.Windows.Forms.Label lblFlores;
        private System.Windows.Forms.TextBox txtFlores;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.TextBox txtCarro;
        private System.Windows.Forms.Label lblCoroaDeFlores;
        private System.Windows.Forms.TextBox txtCoroaDeFlores;
        private System.Windows.Forms.Label lblParamentacao;
        private System.Windows.Forms.TextBox txtParamentacao;
        private System.Windows.Forms.Label lblHigienizaçao;
        private System.Windows.Forms.TextBox txtHigienizacao;
        private System.Windows.Forms.Label lblVeu;
        private System.Windows.Forms.TextBox txtVeu;
        private System.Windows.Forms.GroupBox grpFalecido;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblEditarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Label lblGravarCategoria;
        private System.Windows.Forms.Button btnGravarCategoria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblCancelarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
    }
}