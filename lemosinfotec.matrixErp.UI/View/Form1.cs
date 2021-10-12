using lemosinfotec.matrixErp.Data.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using lemosinfotec.matrixErp.UI.View;
using lemosinfotec.matrixErp.Repository.Repositories;

namespace lemosinfotec.matrixErp.UI
{
    public partial class Form1 : Form
    {
        private Form _objForm;
        private readonly DataContexto _context;
        AccountRepository _accountRepository = new AccountRepository();
        int IdUsr;
        public Form1(string nome, int Id)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.btnRestaurar.Hide();
            }

            IdUsr = Id;
            
           
            
            InitializeComponent();

            LoadingFormHome();
            lblNome.Text = "Ola, " + nome + " seja bem vindo!";




        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void btnSair_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Realmente deseja sair?","",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msg == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            
        }

     

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnRestaurar.Visible = true;
            BtnMaximinizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = false;
            BtnMaximinizar.Visible =true;
        }

        private void BtnMaximinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = true;
            BtnMaximinizar.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
           
            _objForm?.Close();

            _objForm = new FrmProdutos(IdUsr)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                 Dock = DockStyle.Fill
               
            };

            pnlConteudos.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmEstoqueProdutos(IdUsr)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill

            };
            
            pnlConteudos.Controls.Add(_objForm);
            _objForm.Show();
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new frmVendas(IdUsr)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
               
               

            };
           
            pnlConteudos.Controls.Add(_objForm);
            _objForm.Show();
          
        }
        private void LoadingFormHome()
        {
            _objForm?.Close();

            _objForm = new FrmHome
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill



            };

            pnlConteudos.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
           
            _objForm = new FrmFornecedor(IdUsr)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
                

               

            };

            pnlConteudos.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var checkPermissoes = _accountRepository.CheckRole(IdUsr);
            if (checkPermissoes.RoleId == 1)
            {

                _objForm?.Close();

                _objForm = new FrmAdmin
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill



                };

                pnlConteudos.Controls.Add(_objForm);
                _objForm.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para entrar nesta pagina!");
            }
        }

        private void iconFinanceiro_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new FrmFinanceiro(IdUsr)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill




            };

            pnlConteudos.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
