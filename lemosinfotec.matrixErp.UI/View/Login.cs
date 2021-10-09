using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.UI.Controllers;
using lemosinfotec.matrixErp.Repository.Repositories;
using lemosinfotec.matrixErp.Repository.Repositories.RepositoryUsuarioLogado;

namespace lemosinfotec.matrixErp.UI
{
    public partial class Login : Form
    {

        AccountRepository _accoutRepository = new AccountRepository();

        public Login()
        {
            InitializeComponent();
        }


        private void lblTitleLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Realmente deseja sair?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtSenha.Text;

            LoginRepository login = new LoginRepository();
            var validarLogin = login.Entrar(UserName, Password);
                        
            if(validarLogin!= false)
            {
                this.Hide();
                var nome = UserLoginCache.Nome;
                int Id = UserLoginCache.Id;

                Form1 principal = new Form1(nome,Id);
                
                principal.Show();
            }
            else
            {
                lblMsgError.Text = "Usuário ou senha invalidos";
            }


        }
    }
}
