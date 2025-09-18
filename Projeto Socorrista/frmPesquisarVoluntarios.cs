using CpfLibrary;
using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
            desabilitaBotoes();
            desativaCampos();
        }

        public void desabilitaBotoes()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public void habilitaBotoes()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        public void desativaCampos()
        {
            txtCodigo.Enabled = false;
            txtNomeCompleto.Enabled = false;
            mkbCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            mkbCep.Enabled = false;
            txtCidade.Enabled = false;
            cbbUf.Enabled = false;
            mkbTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtAlterarSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
        }

        public void habilitaCampos()
        {
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            mkbCep.Enabled = true;
            txtCidade.Enabled = true;
            cbbUf.Enabled = true;
            mkbTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtAlterarSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;
        }

        private void limparCampos()
        {
            txtCodigo.Clear();
            txtNomeCompleto.Clear();
            txtDescricao.Clear();
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
            txtAlterarSenha.Clear();
            txtConfirmaSenha.Clear();
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

        private int alterarVoluntarios(string nome, string telCel, string cpf, string cep, string nomeRua, string numero, string complemento, string bairro, string cidade, string estado, string email, string senha, string salt, int codVol)
        {

            string senhaCriptografada = GerarHashComSalt(senha, salt);

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbVoluntarios SET nome=@nome,telCel=@telCel,cpf=@cpf,cep=@cep,nomeRua=@nomeRua,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado,email=@email,senha=@senha,salt=@salt WHERE codVol = @codVol;";
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

            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol; //Parametro de codVoluntarios -> Para localizar no WHERE 'codVol = @codVol'.

            comm.Connection = ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            ConectaBanco.FecharConexao();

            return resp;

        }

        private int excluirVoluntarios(int codVol)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbVoluntarios WHERE codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;

            comm.Connection = ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            ConectaBanco.FecharConexao();

            return resp;
        }

        public void pesquisarPorCodigo(int codVol)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbVoluntarios WHERE codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = (DR.GetInt32(0).ToString());

            txtNomeCompleto.Text = (DR.GetString(1));

            mkbTelefone.Text = (DR.GetString(2));

            mkbCpf.Text = (DR.GetString(3));

            mkbCep.Text = (DR.GetString(4));

            txtEndereco.Text = (DR.GetString(5));

            txtNumero.Text = (DR.GetString(6));

            txtComplemento.Text = (DR.GetString(7));

            txtBairro.Text = (DR.GetString(8));

            txtCidade.Text = (DR.GetString(9));

            cbbUf.Text = (DR.GetString(10));

            txtEmail.Text = (DR.GetString(11));

            ConectaBanco.FecharConexao();

        }

        public void pesquisarPorNome(string usuarios)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbVoluntarios WHERE nome LIKE '%" + usuarios + "%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                txtCodigo.Text = (DR.GetInt32(0).ToString());

                txtNomeCompleto.Text = (DR.GetString(1));

                mkbTelefone.Text = (DR.GetString(2));

                mkbCpf.Text = (DR.GetString(3));

                mkbCep.Text = (DR.GetString(4));

                txtEndereco.Text = (DR.GetString(5));

                txtNumero.Text = (DR.GetString(6));

                txtComplemento.Text = (DR.GetString(7));

                txtBairro.Text = (DR.GetString(8));

                txtCidade.Text = (DR.GetString(9));

                cbbUf.Text = (DR.GetString(10));

                txtEmail.Text = (DR.GetString(11));
            }

            ConectaBanco.FecharConexao();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked || rdbNome.Checked)
            {
                if (rdbCodigo.Checked && !txtDescricao.Text.Equals(""))
                {
                    try
                    {
                        habilitaCampos();
                        habilitaBotoes();
                        pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
                        txtDescricao.Focus();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor inserir somente números inteiros");
                        txtDescricao.Clear();
                        txtDescricao.Focus();
                        desabilitaBotoes();
                    }

                }
                else if (rdbNome.Checked && !txtDescricao.Text.Equals(""))
                {
                    habilitaBotoes();
                    habilitaCampos();
                    pesquisarPorNome(txtDescricao.Text);
                    txtDescricao.Focus();
                }
                else
                {
                    MessageBox.Show("Favor inserir um código ou nome");
                    txtDescricao.Focus();
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar um método de pesquisa.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastroVoluntarios abrir = new frmCadastroVoluntarios();
            abrir.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (verficaEmailCadastrado(txtEmail.Text))
            {
                MessageBox.Show("Email já Cadastrado!", "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);

                txtEmail.Clear();
                txtEmail.Focus();
            }
            else if (txtEmail.Text.Equals("") || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || mkbCep.Text.Equals("     -") || txtCidade.Text.Equals("") || cbbUf.Text.Equals("") || mkbTelefone.Text.Equals("(  )    -") || txtEmail.Text.Equals("") || txtAlterarSenha.Text.Equals("") || txtConfirmaSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                alterarVoluntarios(txtNomeCompleto.Text, mkbTelefone.Text, mkbCpf.Text, mkbCep.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbbUf.Text, txtEmail.Text, txtAlterarSenha.Text, GerarSaltSeguro(), Convert.ToInt32(txtCodigo.Text));
                {
                    MessageBox.Show("Voluntário alterado com sucesso!", "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);

                    limparCampos();
                    txtDescricao.Focus();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?", "Mensagem do Sistema",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result.Equals(DialogResult.Yes))
            {
                int resp = excluirVoluntarios(Convert.ToInt32(txtCodigo.Text));

                if (resp.Equals(1))
                {
                    MessageBox.Show("Excluido com Sucesso", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                limparCampos();
                //desabilitarCamposNovo();
                //btnNovo.Enabled = true;

            }
        }

        // criando método validador de senha

        int contador = 0;

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtAlterarSenha.Text.Equals(txtConfirmaSenha.Text) && txtConfirmaSenha.Text.Length.Equals(12))
            {
                btnCheck.Visible = true;
                btnErro.Visible = false;
            }
            else
            {
                btnCheck.Visible = false;
            }
            if (!txtConfirmaSenha.Text.Equals(txtAlterarSenha.Text) && txtConfirmaSenha.Text.Length.Equals(12))
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
                txtAlterarSenha.Enabled = false;
                contador = 0;
            }
        }
    }
}
