namespace Projeto_Socorrista
{
    partial class frmPesquisarVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarVoluntarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.gpbCrud = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbInfoPessoais = new System.Windows.Forms.GroupBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.gpbInfoVoluntarios = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnErro = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.cbbUf = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtAlterarSenha = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCriarSenha = new System.Windows.Forms.Label();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.gpbCrud.SuspendLayout();
            this.gpbInfoPessoais.SuspendLayout();
            this.gpbInfoVoluntarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(232, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(382, 42);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Pesquisar Voluntários";
            // 
            // pcbLogo
            //            
            this.pcbLogo.Location = new System.Drawing.Point(10, 9);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(69, 63);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 24;
            this.pcbLogo.TabStop = false;
            // 
            // gpbCrud
            // 
            this.gpbCrud.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbCrud.Controls.Add(this.btnExcluir);
            this.gpbCrud.Controls.Add(this.btnVoltar);
            this.gpbCrud.Controls.Add(this.btnAlterar);
            this.gpbCrud.Controls.Add(this.btnSair);
            this.gpbCrud.Location = new System.Drawing.Point(10, 461);
            this.gpbCrud.Name = "gpbCrud";
            this.gpbCrud.Size = new System.Drawing.Size(812, 60);
            this.gpbCrud.TabIndex = 27;
            this.gpbCrud.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(209, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 39);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(111, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 39);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Gold;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterar.Location = new System.Drawing.Point(13, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 39);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Brown;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(711, 14);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 39);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(15, 58);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(501, 19);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(10, 31);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;            
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(661, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 38);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gpbInfoPessoais
            // 
            this.gpbInfoPessoais.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbInfoPessoais.Controls.Add(this.rdbNome);
            this.gpbInfoPessoais.Controls.Add(this.rdbCodigo);
            this.gpbInfoPessoais.Controls.Add(this.btnSearch);
            this.gpbInfoPessoais.Controls.Add(this.lblDescricao);
            this.gpbInfoPessoais.Controls.Add(this.txtDescricao);
            this.gpbInfoPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoPessoais.Location = new System.Drawing.Point(10, 78);
            this.gpbInfoPessoais.Name = "gpbInfoPessoais";
            this.gpbInfoPessoais.Size = new System.Drawing.Size(812, 105);
            this.gpbInfoPessoais.TabIndex = 25;
            this.gpbInfoPessoais.TabStop = false;
            this.gpbInfoPessoais.Text = "Informações Pessoais";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(535, 38);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 26;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(535, 68);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 25;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // gpbInfoVoluntarios
            // 
            this.gpbInfoVoluntarios.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbInfoVoluntarios.Controls.Add(this.lblCodigo);
            this.gpbInfoVoluntarios.Controls.Add(this.txtCodigo);
            this.gpbInfoVoluntarios.Controls.Add(this.btnErro);
            this.gpbInfoVoluntarios.Controls.Add(this.btnCheck);
            this.gpbInfoVoluntarios.Controls.Add(this.txtCidade);
            this.gpbInfoVoluntarios.Controls.Add(this.lblComplemento);
            this.gpbInfoVoluntarios.Controls.Add(this.txtComplemento);
            this.gpbInfoVoluntarios.Controls.Add(this.cbbUf);
            this.gpbInfoVoluntarios.Controls.Add(this.lblUF);
            this.gpbInfoVoluntarios.Controls.Add(this.lblCidade);
            this.gpbInfoVoluntarios.Controls.Add(this.lblEmail);
            this.gpbInfoVoluntarios.Controls.Add(this.lblBairro);
            this.gpbInfoVoluntarios.Controls.Add(this.txtEmail);
            this.gpbInfoVoluntarios.Controls.Add(this.lblNumero);
            this.gpbInfoVoluntarios.Controls.Add(this.txtAlterarSenha);
            this.gpbInfoVoluntarios.Controls.Add(this.txtBairro);
            this.gpbInfoVoluntarios.Controls.Add(this.lblEndereco);
            this.gpbInfoVoluntarios.Controls.Add(this.lblCriarSenha);
            this.gpbInfoVoluntarios.Controls.Add(this.mkbCep);
            this.gpbInfoVoluntarios.Controls.Add(this.txtNumero);
            this.gpbInfoVoluntarios.Controls.Add(this.txtConfirmaSenha);
            this.gpbInfoVoluntarios.Controls.Add(this.lblConfirmarSenha);
            this.gpbInfoVoluntarios.Controls.Add(this.txtEndereco);
            this.gpbInfoVoluntarios.Controls.Add(this.lblCep);
            this.gpbInfoVoluntarios.Controls.Add(this.mkbTelefone);
            this.gpbInfoVoluntarios.Controls.Add(this.mkbCpf);
            this.gpbInfoVoluntarios.Controls.Add(this.lblNomeCompleto);
            this.gpbInfoVoluntarios.Controls.Add(this.txtNomeCompleto);
            this.gpbInfoVoluntarios.Controls.Add(this.lblTelefone);
            this.gpbInfoVoluntarios.Controls.Add(this.lblCpf);
            this.gpbInfoVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoVoluntarios.Location = new System.Drawing.Point(10, 189);
            this.gpbInfoVoluntarios.Name = "gpbInfoVoluntarios";
            this.gpbInfoVoluntarios.Size = new System.Drawing.Size(812, 269);
            this.gpbInfoVoluntarios.TabIndex = 28;
            this.gpbInfoVoluntarios.TabStop = false;
            this.gpbInfoVoluntarios.Text = "Informações Voluntário";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(11, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 21);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(14, 53);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 19);
            this.txtCodigo.TabIndex = 24;
            // 
            // btnErro
            // 
            this.btnErro.FlatAppearance.BorderSize = 0;
            this.btnErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;           
            this.btnErro.Location = new System.Drawing.Point(758, 217);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(48, 45);
            this.btnErro.TabIndex = 23;
            this.btnErro.UseVisualStyleBackColor = true;
            this.btnErro.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;            
            this.btnCheck.Location = new System.Drawing.Point(758, 217);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(48, 45);
            this.btnCheck.TabIndex = 22;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCidade.Location = new System.Drawing.Point(532, 172);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(149, 19);
            this.txtCidade.TabIndex = 8;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(11, 145);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(123, 21);
            this.lblComplemento.TabIndex = 21;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtComplemento.Location = new System.Drawing.Point(15, 172);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(213, 19);
            this.txtComplemento.TabIndex = 5;
            // 
            // cbbUf
            // 
            this.cbbUf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbUf.FormattingEnabled = true;
            this.cbbUf.Items.AddRange(new object[] {
            "AC",
            "AL\t\t",
            "AP",
            "AM\t\t",
            "BA\t",
            "CE\t",
            "DF\t",
            "ES\t",
            "GO\t",
            "MA\t",
            "MT\t",
            "MS\t",
            "MG\t",
            "PA\t",
            "PB\t",
            "PR\t",
            "PE\t",
            "PI\t",
            "RJ\t",
            "RN\t",
            "RS\t",
            "RO\t",
            "RR\t",
            "SC\t",
            "SP\t",
            "SE",
            "TO"});
            this.cbbUf.Location = new System.Drawing.Point(687, 167);
            this.cbbUf.Name = "cbbUf";
            this.cbbUf.Size = new System.Drawing.Size(87, 28);
            this.cbbUf.TabIndex = 9;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(683, 145);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 21);
            this.lblUF.TabIndex = 17;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(525, 145);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 21);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(153, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(241, 145);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 21);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(157, 231);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 19);
            this.txtEmail.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(525, 85);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 21);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Número:";
            // 
            // txtAlterarSenha
            // 
            this.txtAlterarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlterarSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtAlterarSenha.Location = new System.Drawing.Point(368, 231);
            this.txtAlterarSenha.MaxLength = 12;
            this.txtAlterarSenha.Name = "txtAlterarSenha";
            this.txtAlterarSenha.PasswordChar = 'l';
            this.txtAlterarSenha.Size = new System.Drawing.Size(190, 18);
            this.txtAlterarSenha.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBairro.Location = new System.Drawing.Point(245, 172);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 19);
            this.txtBairro.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(11, 85);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 21);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCriarSenha
            // 
            this.lblCriarSenha.AutoSize = true;
            this.lblCriarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarSenha.Location = new System.Drawing.Point(364, 205);
            this.lblCriarSenha.Name = "lblCriarSenha";
            this.lblCriarSenha.Size = new System.Drawing.Size(117, 21);
            this.lblCriarSenha.TabIndex = 15;
            this.lblCriarSenha.Text = "Alterar Senha:";
            // 
            // mkbCep
            // 
            this.mkbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkbCep.Location = new System.Drawing.Point(429, 168);
            this.mkbCep.Mask = "99999-999";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(87, 26);
            this.mkbCep.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumero.Location = new System.Drawing.Point(529, 109);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 19);
            this.txtNumero.TabIndex = 4;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(575, 231);
            this.txtConfirmaSenha.MaxLength = 12;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = 'l';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(190, 18);
            this.txtConfirmaSenha.TabIndex = 13;
            this.txtConfirmaSenha.TextChanged += new System.EventHandler(this.txtConfirmaSenha_TextChanged);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(571, 205);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(143, 21);
            this.lblConfirmarSenha.TabIndex = 9;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndereco.Location = new System.Drawing.Point(14, 109);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(502, 19);
            this.txtEndereco.TabIndex = 3;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(425, 145);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(44, 21);
            this.lblCep.TabIndex = 15;
            this.lblCep.Text = "CEP:";
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkbTelefone.Location = new System.Drawing.Point(15, 227);
            this.mkbTelefone.Mask = "(99)99999-9999";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(125, 26);
            this.mkbTelefone.TabIndex = 10;
            // 
            // mkbCpf
            // 
            this.mkbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkbCpf.Location = new System.Drawing.Point(648, 49);
            this.mkbCpf.Mask = "999,999,999-99";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(126, 26);
            this.mkbCpf.TabIndex = 2;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(113, 25);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(141, 21);
            this.lblNomeCompleto.TabIndex = 3;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(117, 53);
            this.txtNomeCompleto.MaxLength = 100;
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(501, 19);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(11, 205);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(80, 21);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(644, 25);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 21);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF:";
            // 
            // frmPesquisarVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 532);
            this.Controls.Add(this.gpbInfoVoluntarios);
            this.Controls.Add(this.gpbCrud);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.gpbInfoPessoais);            
            this.MaximizeBox = false;
            this.Name = "frmPesquisarVoluntarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo S. Francisco - Pesquisar Voluntários";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.gpbCrud.ResumeLayout(false);
            this.gpbInfoPessoais.ResumeLayout(false);
            this.gpbInfoPessoais.PerformLayout();
            this.gpbInfoVoluntarios.ResumeLayout(false);
            this.gpbInfoVoluntarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.GroupBox gpbCrud;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gpbInfoPessoais;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.GroupBox gpbInfoVoluntarios;
        private System.Windows.Forms.Button btnErro;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.ComboBox cbbUf;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtAlterarSenha;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCriarSenha;
        private System.Windows.Forms.MaskedTextBox mkbCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}