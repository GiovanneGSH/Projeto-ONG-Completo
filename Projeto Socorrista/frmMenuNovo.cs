using ProjetoGSFranciscoAssis;
using SistemaArrecadacaoAlimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmMenuNovo : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmMenuNovo()
        {
            InitializeComponent();
        }

        private void frmMenuNovo_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            FrmDashboard abrir = new FrmDashboard();
            abrir.Show();
            this.Hide();
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            frmCadastroVoluntarios abrir = new frmCadastroVoluntarios();
            abrir.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmCadastrarAlimentos abrir = new frmCadastrarAlimentos();
            abrir.Show();
            this.Hide();
        }
    }
}
