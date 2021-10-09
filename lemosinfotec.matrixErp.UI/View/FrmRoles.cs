using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemosinfotec.matrixErp.UI.View
{

    public partial class FrmRoles : Form
    {
        AccountRepository _accountRepository = new AccountRepository();
        public FrmRoles()
        {
            InitializeComponent();
            ListaDrops();
        }
        public async void ListaDrops()
        {
            var usuarios = await _accountRepository.GetUsuarios();
            if (usuarios != null)
            {
                cmbUsuarios.DataSource = usuarios;
                cmbUsuarios.ValueMember = "Id";
                cmbUsuarios.DisplayMember = "NomeCompleto";
                cmbUsuarios.Text = "SELECIONE O USUÀRIO";
            }

            var role = await _accountRepository.GetRoles();

            if (role != null)
            {
                cmbPermissao.DataSource = role;
                cmbPermissao.ValueMember = "Id";
                cmbPermissao.DisplayMember = "Name";
                cmbPermissao.Text = "SELECIONE UMA PERMISSÂO";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                LoginModel login = new LoginModel();
                if (login != null)
                {
                    if(txtSenha.Text == txtConfirmaSenha.Text)
                    {
                        login.UserName = txtUserName.Text;
                        login.Password = txtSenha.Text;
                        login.UsuarioId = (int)cmbUsuarios.SelectedValue;
                        await _accountRepository.RegistrarLogin(login);
                        Permissoes permissoes = new Permissoes();
                        if (permissoes != null)
                        {
                            permissoes.UsuarioId = (int)cmbUsuarios.SelectedValue;
                            permissoes.RoleId = (int)cmbPermissao.SelectedValue;
                            await _accountRepository.RegistrarPermissoes(permissoes);
                        }
                    }
                    else
                    {
                        MessageBox.Show("As senhas não conferem");
                    }
                    MessageBox.Show("Permissões aplicadas com sucesso!");
                }
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
