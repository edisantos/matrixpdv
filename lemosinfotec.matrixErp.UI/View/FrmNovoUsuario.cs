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
    public partial class FrmNovoUsuario : Form
    {
        EmpresasRepository _empresaRepository = new EmpresasRepository();
        AccountRepository _accountRepository = new AccountRepository();
        public FrmNovoUsuario()
        {
            InitializeComponent();
            ListaEmpresa();
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var dia = txtDataVencimento.Text.Substring(0, 2);
                var usuarios = new Usuarios();
                if (usuarios != null)
                {
                    usuarios.Nome = txtNome.Text;
                    usuarios.SobreNome = txtSobreNome.Text;
                    usuarios.Email = txtEmail.Text;
                    usuarios.Endereco = txtEndereco.Text;
                    usuarios.Numero = Convert.ToInt32(txtNumero.Text);
                    usuarios.Cidade = txtCidade.Text;
                    usuarios.Estado = txtUf.Text;
                    usuarios.EmpresaId = (int)cmbEmpresa.SelectedValue;
                    usuarios.DataVencimento = Convert.ToDateTime(txtDataVencimento.Text);
                    usuarios.DiaVencimento = Convert.ToInt32(dia);
                    await _accountRepository.RegistrarUsuarios(usuarios);
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Houve um erro: {ex.Message}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void ListaEmpresa()
        {
            var empresas = await _empresaRepository.GetEmpresas();
            cmbEmpresa.DataSource = empresas;
            cmbEmpresa.ValueMember = "EmpresaId";
            cmbEmpresa.DisplayMember = "EmpresaNome";
            cmbEmpresa.Text = "SELECIONE A EMPRESA";
        }
    }
}
