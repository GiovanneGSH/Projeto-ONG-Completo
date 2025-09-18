// Importando API CPF

using CpfLibrary;
// Importando API valida EMAIL
using EmailValidation;
// Importando API CEP
using MosaicoSolutions.ViaCep;
using MosaicoSolutions.ViaCep.Modelos;
// Importando SQL
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Projeto_Socorrista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Socorrista
{
    public partial class frmCadastroVoluntarios : Form
    {
        public frmCadastroVoluntarios()
        {
            InitializeComponent();
            desativaBotesNovo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void revisaDados()
        {
            lblMostraNome.Text = txtNomeCompleto.Text;
            lblMostraCPF.Text = mkbCpf.Text;
            lblMostraEndereco.Text = txtEndereco.Text;
            lblMostraNumero.Text = txtNumero.Text;
            lblMostraComplemento.Text = txtComplemento.Text;
            lblMostraBairro.Text = txtBairro.Text;
            lblMostraCEP.Text = mkbCep.Text;
            lblMostraCidade.Text = txtCidade.Text;
            lblMostraUF.Text = cbbUf.Text;
            lblMostraTelefone.Text = mkbTelefone.Text;
            lblMostraEmail.Text = txtEmail.Text;
        }

        public void desativaBotes()
        {
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
            btnSair.Enabled = false;
            btnVoltar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;
        }
        public void desativaBotesNovo()
        {
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            btnSair.Enabled = true;
            btnVoltar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;
        }
        public void ativaBotes()
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            btnSair.Enabled = true;
            btnVoltar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = true;
        }
        public void ativaBotesNovo()
        {
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;
            btnSair.Enabled = true;
            btnVoltar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
        }

        public void limpaCampos()
        {
            txtNomeCompleto.Clear();
            mkbCpf.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            mkbCep.Clear();
            txtCidade.Clear();
            cbbUf.Text = "";
            mkbTelefone.Clear();
            txtEmail.Clear();
            txtCriarSenha.Clear();
            txtConfirmaSenha.Clear();
            txtNomeCompleto.Focus();
        }

        public void limpaCamposNovo()
        {
            lblMostraNome.Text = "";
            lblMostraCPF.Text = "";
            lblMostraEndereco.Text = "";
            lblMostraNumero.Text = "";
            lblMostraComplemento.Text = "";
            lblMostraBairro.Text = "";
            lblMostraCEP.Text = "";
            lblMostraCidade.Text = "";
            lblMostraUF.Text = "";
            lblMostraTelefone.Text = "";
            lblMostraEmail.Text = "";
        }

        //criando o método busca cep
        public void buscaCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {
                var endereco = viaCEPService.ObterEndereco(cep);

                txtEndereco.Text = endereco.Logradouro.ToString();
                txtBairro.Text = endereco.Bairro.ToString();
                txtCidade.Text = endereco.Localidade.ToString();
                cbbUf.Text = endereco.UF.ToString();
                txtComplemento.Text = endereco.Complemento.ToString();

                txtNumero.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir um CEP válido", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                mkbCep.Clear();
                mkbCep.Focus();
            }
        }

        //criando o método check cpf
        public bool checkCPF(string cpf)
        {
            bool respCpf = Cpf.Check(cpf);

            return respCpf;
        }    
        

        // criando um numero aleatorio para conctenar com a senha 
        public string GerarSaltSeguro(int tamanho = 16)
        {
            byte[] saltBytes = new byte[tamanho];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // criando metodo que criptografa a senha do voluntário
        public string GerarHashComSalt(string senha, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string senhaComSalt = salt + senha;
                byte[] bytes = Encoding.UTF8.GetBytes(senhaComSalt);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        // criando metodo que verifica cpf existente
        public bool verficaCPFCadastrado(string cpf)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM TBvoluntarios where cpf = @cpf;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = cpf;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                string verificacpf = DR.GetString(2);

                if (verificacpf.Equals(""))
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            ConectaBanco.FecharConexao();

            return true;
        }

        // criando metodo que verifica email existente
        public bool verficaEmailCadastrado(string email)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM TBvoluntarios where email = @email;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                string verificaemail = DR.GetString(10);

                if (verificaemail.Equals(""))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            ConectaBanco.FecharConexao();

            return true;
        }

        // criando método cadastro de usuários

        //public int cadastroUsuarios(string email, string senha, string salt, int codVol)
        //{

        //    string senhaCriptografada = GerarHashComSalt(senha, salt);

        //    MySqlCommand comm = new MySqlCommand();
        //    comm.CommandText = "INSERT INTO tbUsuarios(email,senha,codVol)VALUES(@email,@senha,@codVol);";
        //    comm.CommandType = CommandType.Text;

        //    comm.Parameters.Clear();

        //    comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
        //    comm.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = senhaCriptografada;



        //    comm.Connection = ConectaBanco.ObterConexao();

        //    int resp = comm.ExecuteNonQuery();

        //    ConectaBanco.FecharConexao();

        //    return resp;

        //}      


        // criando método cadastro de voluntários

        public int cadastroVoluntarios(string nome, string telCel, string cpf, string cep, string nomeRua, string numero, string complemento, string bairro, string cidade, string estado, string email, string senha, string salt)
        {

            string senhaCriptografada = GerarHashComSalt(senha, salt);

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbVoluntarios(nome, telCel, cpf, cep, nomeRua, numero, complemento, bairro, cidade, estado, email, senha, salt)VALUES(@nome,@telCel,@cpf,@cep,@nomeRua,@numero,@complemento,@bairro,@cidade,@estado,@email,@senha,@salt);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = cpf;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@nomeRua", MySqlDbType.VarChar, 100).Value = nomeRua;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = complemento;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = senhaCriptografada;
            comm.Parameters.Add("@salt", MySqlDbType.VarChar, 64).Value = salt;


            comm.Connection = ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            ConectaBanco.FecharConexao();

            return resp;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            bool respCpf = checkCPF(mkbCpf.Text);

            if (respCpf.Equals(false))
            {

                MessageBox.Show("Favor inserir um CPF válido", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                mkbCpf.Text = "";
                mkbCpf.Focus();
            }                     

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desativaBotesNovo();
            limpaCamposNovo();
            txtNomeCompleto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            limpaCamposNovo();
            desativaBotesNovo();
        }

        private void mkbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mkbCep.Text);
            }

        }

        private void mkbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool respCpf = checkCPF(mkbCpf.Text);

                if (respCpf.Equals(false))
                {

                    MessageBox.Show("Favor inserir um CPF válido", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                    mkbCpf.Text = "";
                    mkbCpf.Focus();
                }

            }
        }        

        // criando método validador de senha

        int contador = 0;

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtCriarSenha.Text.Equals(txtConfirmaSenha.Text) && txtConfirmaSenha.Text.Length.Equals(12))
            {
                btnCheck.Visible = true;
                btnErro.Visible = false;
            }
            else
            {
                btnCheck.Visible = false;
            }
            if (!txtConfirmaSenha.Text.Equals(txtCriarSenha.Text) && txtConfirmaSenha.Text.Length.Equals(12))
            {
                btnErro.Visible = true;
                contador++;
                MessageBox.Show("As senhas não correspondem!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
            if (contador > 0)
            {
                btnErro.Visible = true;
                txtConfirmaSenha.Clear();
                txtConfirmaSenha.Focus();
                txtCriarSenha.Enabled = false;
                contador = 0;
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text.Equals("") || mkbTelefone.Text.Equals("(  )    -") || mkbCpf.Text.Equals("   .   .   -") || mkbCep.Text.Equals("     -") || txtEndereco.Text.Equals("") || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("") || cbbUf.Text.Equals("") || txtEmail.Text.Equals("") || txtCriarSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);

                txtNomeCompleto.Focus();
            }
            else if (mkbTelefone.Text.Length < 13)
            {
                MessageBox.Show("Favor preencher o campo Número!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                mkbTelefone.Focus();
            }
            else if (mkbCep.Text.Length < 9)
            {
                MessageBox.Show("Favor preencher o campo CEP!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                mkbCep.Focus();
            }
            else if (verficaCPFCadastrado(mkbCpf.Text))
            {
                MessageBox.Show("CPF já Cadastrado!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                mkbCpf.Text = "";
                mkbCpf.Focus();
            }
            else if (verficaEmailCadastrado(txtEmail.Text))
            {
                MessageBox.Show("Email já Cadastrado!", "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);

                txtEmail.Clear();
                txtEmail.Focus();
            }
            else
            {
                cadastroVoluntarios(txtNomeCompleto.Text, mkbTelefone.Text, mkbCpf.Text, mkbCep.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbbUf.Text, txtEmail.Text, txtCriarSenha.Text, GerarSaltSeguro());
                {
                    MessageBox.Show("Voluntário cadastrado com sucesso!", "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
                }

                limpaCampos();
                limpaCamposNovo();
                desativaBotesNovo();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntarios abrir = new frmPesquisarVoluntarios();
            abrir.Show();
            this.Hide();
        }
    }
}
