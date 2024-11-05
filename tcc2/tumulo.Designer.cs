namespace tcc2
{
    partial class frmTumulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTumulo));
            this.btnSalvarTumulo = new System.Windows.Forms.Button();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtResponsavelTumulo = new System.Windows.Forms.TextBox();
            this.txtCodigoTumulo = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnNovoTumulo = new System.Windows.Forms.Button();
            this.lblSalvarTumulo = new System.Windows.Forms.Label();
            this.lblNovoTumulo = new System.Windows.Forms.Label();
            this.btnEditarTumulo = new System.Windows.Forms.Button();
            this.lblEditarTumulo = new System.Windows.Forms.Label();
            this.lblGravarTumulo = new System.Windows.Forms.Label();
            this.btnGravarTumulo = new System.Windows.Forms.Button();
            this.lblCancelarTumulo = new System.Windows.Forms.Label();
            this.btnCancelarTumulo = new System.Windows.Forms.Button();
            this.btnPesquisarTumulo = new System.Windows.Forms.Button();
            this.txtPesquisaTumulo = new System.Windows.Forms.TextBox();
            this.ltbResponsavelTumulo = new System.Windows.Forms.ListBox();
            this.ltbCodigoTumulo = new System.Windows.Forms.ListBox();
            this.lblExcluirTumulo = new System.Windows.Forms.Label();
            this.btnExcluirTumulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvarTumulo
            // 
            this.btnSalvarTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarTumulo.BackgroundImage")));
            this.btnSalvarTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvarTumulo.Location = new System.Drawing.Point(369, 251);
            this.btnSalvarTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarTumulo.Name = "btnSalvarTumulo";
            this.btnSalvarTumulo.Size = new System.Drawing.Size(64, 64);
            this.btnSalvarTumulo.TabIndex = 54;
            this.btnSalvarTumulo.UseVisualStyleBackColor = true;
            this.btnSalvarTumulo.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(132, 241);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 17);
            this.lblCelular.TabIndex = 53;
            this.lblCelular.Text = "Celular";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(135, 261);
            this.mskCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCelular.Mask = "(99)99999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(117, 22);
            this.mskCelular.TabIndex = 9;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(12, 261);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTelefone.Mask = "(99)9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(103, 22);
            this.mskTelefone.TabIndex = 8;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 241);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 50;
            this.lblTelefone.Text = "Telefone";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "",
            "Acre-AC",
            "Alagoas-AL",
            "Amapá-AP",
            "Amazonas-AM",
            "Bahia-BA",
            "Ceará-CE",
            "Distrito Federal-DF",
            "Espírito Santo-ES",
            "Goiás-GO",
            "Maranhão-MA",
            "Mato Grosso-MT",
            "Mato Grosso do Sul-MS",
            "Minas Gerais-MG",
            "Pará-PA",
            "Paraíba-PB",
            "Paraná-PR\t",
            "Pernambuco-PE",
            "Piauí-PI",
            "Rio de Janeiro-RJ",
            "Rio Grande do Norte-RN",
            "Rio Grande do Sul-RS",
            "Rondônia-RO",
            "Roraima-RR",
            "Santa Catarina-SC",
            "São Paulo-SP",
            "Sergipe-SE",
            "Tocantins-TO "});
            this.cmbEstado.Location = new System.Drawing.Point(279, 197);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(160, 24);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(172, 177);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 17);
            this.lblCEP.TabIndex = 48;
            this.lblCEP.Text = "CEP";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(175, 197);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(84, 22);
            this.mskCEP.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(276, 177);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 46;
            this.lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(341, 123);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(129, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(339, 103);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 17);
            this.lblCidade.TabIndex = 44;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 199);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(135, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 177);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 17);
            this.lblBairro.TabIndex = 42;
            this.lblBairro.Text = "Bairro";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(13, 103);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(69, 17);
            this.lblEndereco.TabIndex = 41;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 123);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(303, 22);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtResponsavelTumulo
            // 
            this.txtResponsavelTumulo.Location = new System.Drawing.Point(116, 53);
            this.txtResponsavelTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResponsavelTumulo.Name = "txtResponsavelTumulo";
            this.txtResponsavelTumulo.Size = new System.Drawing.Size(353, 22);
            this.txtResponsavelTumulo.TabIndex = 2;
            // 
            // txtCodigoTumulo
            // 
            this.txtCodigoTumulo.Location = new System.Drawing.Point(13, 53);
            this.txtCodigoTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoTumulo.Name = "txtCodigoTumulo";
            this.txtCodigoTumulo.Size = new System.Drawing.Size(71, 22);
            this.txtCodigoTumulo.TabIndex = 1;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(113, 33);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(94, 17);
            this.lblResponsavel.TabIndex = 37;
            this.lblResponsavel.Text = "Responsável ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Código";
            // 
            // btnNovoTumulo
            // 
            this.btnNovoTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoTumulo.BackgroundImage")));
            this.btnNovoTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoTumulo.Location = new System.Drawing.Point(460, 251);
            this.btnNovoTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovoTumulo.Name = "btnNovoTumulo";
            this.btnNovoTumulo.Size = new System.Drawing.Size(64, 64);
            this.btnNovoTumulo.TabIndex = 56;
            this.btnNovoTumulo.UseVisualStyleBackColor = true;
            this.btnNovoTumulo.Click += new System.EventHandler(this.btnNovoTumulo_Click);
            // 
            // lblSalvarTumulo
            // 
            this.lblSalvarTumulo.AutoSize = true;
            this.lblSalvarTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvarTumulo.Location = new System.Drawing.Point(365, 318);
            this.lblSalvarTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalvarTumulo.Name = "lblSalvarTumulo";
            this.lblSalvarTumulo.Size = new System.Drawing.Size(69, 23);
            this.lblSalvarTumulo.TabIndex = 57;
            this.lblSalvarTumulo.Text = "Salvar";
            // 
            // lblNovoTumulo
            // 
            this.lblNovoTumulo.AutoSize = true;
            this.lblNovoTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoTumulo.Location = new System.Drawing.Point(456, 318);
            this.lblNovoTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNovoTumulo.Name = "lblNovoTumulo";
            this.lblNovoTumulo.Size = new System.Drawing.Size(58, 23);
            this.lblNovoTumulo.TabIndex = 58;
            this.lblNovoTumulo.Text = "Novo";
            // 
            // btnEditarTumulo
            // 
            this.btnEditarTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarTumulo.BackgroundImage")));
            this.btnEditarTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarTumulo.Enabled = false;
            this.btnEditarTumulo.Location = new System.Drawing.Point(279, 251);
            this.btnEditarTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarTumulo.Name = "btnEditarTumulo";
            this.btnEditarTumulo.Size = new System.Drawing.Size(64, 64);
            this.btnEditarTumulo.TabIndex = 10;
            this.btnEditarTumulo.UseVisualStyleBackColor = true;
            this.btnEditarTumulo.Click += new System.EventHandler(this.btnEditarTumulo_Click);
            // 
            // lblEditarTumulo
            // 
            this.lblEditarTumulo.AutoSize = true;
            this.lblEditarTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTumulo.Location = new System.Drawing.Point(275, 318);
            this.lblEditarTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarTumulo.Name = "lblEditarTumulo";
            this.lblEditarTumulo.Size = new System.Drawing.Size(69, 23);
            this.lblEditarTumulo.TabIndex = 60;
            this.lblEditarTumulo.Text = "Editar";
            // 
            // lblGravarTumulo
            // 
            this.lblGravarTumulo.AutoSize = true;
            this.lblGravarTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravarTumulo.Location = new System.Drawing.Point(365, 318);
            this.lblGravarTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGravarTumulo.Name = "lblGravarTumulo";
            this.lblGravarTumulo.Size = new System.Drawing.Size(77, 23);
            this.lblGravarTumulo.TabIndex = 62;
            this.lblGravarTumulo.Text = "Gravar";
            this.lblGravarTumulo.Visible = false;
            // 
            // btnGravarTumulo
            // 
            this.btnGravarTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravarTumulo.BackgroundImage")));
            this.btnGravarTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGravarTumulo.Location = new System.Drawing.Point(369, 251);
            this.btnGravarTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarTumulo.Name = "btnGravarTumulo";
            this.btnGravarTumulo.Size = new System.Drawing.Size(64, 64);
            this.btnGravarTumulo.TabIndex = 11;
            this.btnGravarTumulo.UseVisualStyleBackColor = true;
            this.btnGravarTumulo.Visible = false;
            this.btnGravarTumulo.Click += new System.EventHandler(this.btnGravarTumulo_Click);
            // 
            // lblCancelarTumulo
            // 
            this.lblCancelarTumulo.AutoSize = true;
            this.lblCancelarTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarTumulo.Location = new System.Drawing.Point(447, 318);
            this.lblCancelarTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelarTumulo.Name = "lblCancelarTumulo";
            this.lblCancelarTumulo.Size = new System.Drawing.Size(97, 23);
            this.lblCancelarTumulo.TabIndex = 64;
            this.lblCancelarTumulo.Text = "Cancelar";
            this.lblCancelarTumulo.Visible = false;
            // 
            // btnCancelarTumulo
            // 
            this.btnCancelarTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarTumulo.BackgroundImage")));
            this.btnCancelarTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarTumulo.Location = new System.Drawing.Point(460, 251);
            this.btnCancelarTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarTumulo.Name = "btnCancelarTumulo";
            this.btnCancelarTumulo.Size = new System.Drawing.Size(64, 64);
            this.btnCancelarTumulo.TabIndex = 12;
            this.btnCancelarTumulo.UseVisualStyleBackColor = true;
            this.btnCancelarTumulo.Visible = false;
            this.btnCancelarTumulo.Click += new System.EventHandler(this.btnCancelarTumulo_Click);
            // 
            // btnPesquisarTumulo
            // 
            this.btnPesquisarTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarTumulo.Location = new System.Drawing.Point(32, 318);
            this.btnPesquisarTumulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarTumulo.Name = "btnPesquisarTumulo";
            this.btnPesquisarTumulo.Size = new System.Drawing.Size(152, 33);
            this.btnPesquisarTumulo.TabIndex = 13;
            this.btnPesquisarTumulo.Text = "Pesquisa";
            this.btnPesquisarTumulo.UseVisualStyleBackColor = true;
            this.btnPesquisarTumulo.Click += new System.EventHandler(this.btnPesquisarTumulo_Click);
            // 
            // txtPesquisaTumulo
            // 
            this.txtPesquisaTumulo.Location = new System.Drawing.Point(116, 53);
            this.txtPesquisaTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisaTumulo.Name = "txtPesquisaTumulo";
            this.txtPesquisaTumulo.Size = new System.Drawing.Size(353, 22);
            this.txtPesquisaTumulo.TabIndex = 2;
            this.txtPesquisaTumulo.Visible = false;
            this.txtPesquisaTumulo.TextChanged += new System.EventHandler(this.txtPesquisaTumulo_TextChanged);
            // 
            // ltbResponsavelTumulo
            // 
            this.ltbResponsavelTumulo.FormattingEnabled = true;
            this.ltbResponsavelTumulo.ItemHeight = 16;
            this.ltbResponsavelTumulo.Location = new System.Drawing.Point(117, 80);
            this.ltbResponsavelTumulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltbResponsavelTumulo.Name = "ltbResponsavelTumulo";
            this.ltbResponsavelTumulo.Size = new System.Drawing.Size(352, 164);
            this.ltbResponsavelTumulo.TabIndex = 67;
            this.ltbResponsavelTumulo.Visible = false;
            // 
            // ltbCodigoTumulo
            // 
            this.ltbCodigoTumulo.FormattingEnabled = true;
            this.ltbCodigoTumulo.ItemHeight = 16;
            this.ltbCodigoTumulo.Location = new System.Drawing.Point(13, 80);
            this.ltbCodigoTumulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltbCodigoTumulo.Name = "ltbCodigoTumulo";
            this.ltbCodigoTumulo.Size = new System.Drawing.Size(71, 164);
            this.ltbCodigoTumulo.TabIndex = 68;
            this.ltbCodigoTumulo.Visible = false;
            this.ltbCodigoTumulo.SelectedIndexChanged += new System.EventHandler(this.ltbCodigoTumulo_SelectedIndexChanged);
            // 
            // lblExcluirTumulo
            // 
            this.lblExcluirTumulo.AutoSize = true;
            this.lblExcluirTumulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluirTumulo.Location = new System.Drawing.Point(275, 318);
            this.lblExcluirTumulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExcluirTumulo.Name = "lblExcluirTumulo";
            this.lblExcluirTumulo.Size = new System.Drawing.Size(80, 23);
            this.lblExcluirTumulo.TabIndex = 72;
            this.lblExcluirTumulo.Text = "Excluir";
            this.lblExcluirTumulo.Visible = false;
            // 
            // btnExcluirTumulo
            // 
            this.btnExcluirTumulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirTumulo.BackgroundImage")));
            this.btnExcluirTumulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirTumulo.Location = new System.Drawing.Point(279, 251);
            this.btnExcluirTumulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirTumulo.Name = "btnExcluirTumulo";
            this.btnExcluirTumulo.Size = new System.Drawing.Size(64, 64);
            this.btnExcluirTumulo.TabIndex = 69;
            this.btnExcluirTumulo.UseVisualStyleBackColor = true;
            this.btnExcluirTumulo.Visible = false;
            this.btnExcluirTumulo.Click += new System.EventHandler(this.btnExcluirTumulo_Click);
            // 
            // frmTumulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.lblExcluirTumulo);
            this.Controls.Add(this.btnExcluirTumulo);
            this.Controls.Add(this.ltbResponsavelTumulo);
            this.Controls.Add(this.ltbCodigoTumulo);
            this.Controls.Add(this.txtPesquisaTumulo);
            this.Controls.Add(this.btnPesquisarTumulo);
            this.Controls.Add(this.lblCancelarTumulo);
            this.Controls.Add(this.btnCancelarTumulo);
            this.Controls.Add(this.lblGravarTumulo);
            this.Controls.Add(this.btnGravarTumulo);
            this.Controls.Add(this.lblEditarTumulo);
            this.Controls.Add(this.btnEditarTumulo);
            this.Controls.Add(this.lblNovoTumulo);
            this.Controls.Add(this.lblSalvarTumulo);
            this.Controls.Add(this.btnNovoTumulo);
            this.Controls.Add(this.btnSalvarTumulo);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtResponsavelTumulo);
            this.Controls.Add(this.txtCodigoTumulo);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTumulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Túmulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSplash_FormClosing);
            this.Load += new System.EventHandler(this.tumulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarTumulo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtResponsavelTumulo;
        private System.Windows.Forms.TextBox txtCodigoTumulo;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnNovoTumulo;
        private System.Windows.Forms.Label lblSalvarTumulo;
        private System.Windows.Forms.Label lblNovoTumulo;
        private System.Windows.Forms.Button btnEditarTumulo;
        private System.Windows.Forms.Label lblEditarTumulo;
        private System.Windows.Forms.Label lblGravarTumulo;
        private System.Windows.Forms.Button btnGravarTumulo;
        private System.Windows.Forms.Label lblCancelarTumulo;
        private System.Windows.Forms.Button btnCancelarTumulo;
        private System.Windows.Forms.Button btnPesquisarTumulo;
        private System.Windows.Forms.TextBox txtPesquisaTumulo;
        private System.Windows.Forms.ListBox ltbResponsavelTumulo;
        private System.Windows.Forms.ListBox ltbCodigoTumulo;
        private System.Windows.Forms.Label lblExcluirTumulo;
        private System.Windows.Forms.Button btnExcluirTumulo;
    }
}