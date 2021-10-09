using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Repository.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lemosinfotec.matrixErp.UI.View
{
    public partial class FrmFornecedor : Form
    {
        FornecedoresRepository _fornecedoresRepository = new FornecedoresRepository();
        AccountRepository _accountRepository = new AccountRepository();
        int _IdUserLogado;
        public FrmFornecedor(int IdUsr)
        {
            InitializeComponent();
            lblMsgAlerta.Visible = false;
            _IdUserLogado = IdUsr;
            ListaFornecedores();
           
        }

        private void lblCnpj_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            Fornecedores mod = new Fornecedores();
            if (mod != null)
            {
                var empresaId = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                if(btnRegister.Text != "Atualizar") {
                    mod.FornecedorNome = txtFornecedor.Text;
                    mod.Cnpj = txtCNPJ.Text;
                    mod.Endereco = txtEnd.Text;
                    mod.Numero = Convert.ToInt32(txtNum.Text);
                    mod.Cep = txtCep.Text;
                    mod.Cidade = txtCidade.Text;
                    mod.Estado = txtSp.Text;
                    mod.Telefone = txtTelefone.Text;
                    mod.Celular = txtCelular.Text;
                    mod.EmpresaId = empresaId.EmpresaId;
                    await _fornecedoresRepository.RegistrarFornecedor(mod);
                    MessageBox.Show("Registro salvo com sucesso!");
                }
                else
                {
                    mod = await _fornecedoresRepository.GetFornecedoresById(Convert.ToInt32(txtSearch.Text));
                    mod.FornecedorNome = txtFornecedor.Text;
                    mod.Cnpj = txtCNPJ.Text;
                    mod.Endereco = txtEnd.Text;
                    mod.Numero = Convert.ToInt32(txtNum.Text);
                    mod.Cep = txtCep.Text;
                    mod.Cidade = txtCidade.Text;
                    mod.Estado = txtSp.Text;
                    mod.Telefone = txtTelefone.Text;
                    mod.Celular = txtCelular.Text;
                    mod.EmpresaId = empresaId.EmpresaId;
                    _fornecedoresRepository.AlterarDadosFornecedor(mod);
                    MessageBox.Show("Dados do fornecedor alterado com sucesso!");
                    btnRegister.Text = "Registrar";
                    txtSearch.Text = string.Empty;
                }
              

                LimparCampos();
                ListaFornecedores();
            }
        }

        public async void ListaFornecedores()
        {
            try
            {
                var empresaId = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                gridListaFornecedores.AutoGenerateColumns = false;
                var fornecedores = new BindingSource();
                fornecedores.DataSource = await _fornecedoresRepository.GetListaFornecedores(empresaId.EmpresaId);

                //var estoque = new BindingList<Estoque>(await _estoqueRepository.GetEstoque());
                gridListaFornecedores.DataSource = fornecedores;
            }
            catch (Exception ex)
            {
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.Text = $"{ex.Message}";
                lblMsgAlerta.ForeColor = Color.DarkRed;
            }
        }
        private void LimparCampos()
        {
            txtFornecedor.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtSp.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcluit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                var msg = MessageBox.Show("Realmente deseja excluir este item?", "",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    _fornecedoresRepository.ExcluirFornecedor(Convert.ToInt32(txtSearch.Text));
                    MessageBox.Show("Fornecedor excluido com sucesso!");
                    txtSearch.Text = string.Empty;
                    ListaFornecedores();
                }
                
            }
            else
            {
                MessageBox.Show("Campo esta vazio! Digite o código do fornecedor e tente excluir novamente");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                int codigo = Convert.ToInt32(txtSearch.Text);
                gridListaFornecedores.AutoGenerateColumns = false;
                var fornecedoresId = new BindingSource();
               if(fornecedoresId!=null)
                {
                    Fornecedores mod = new Fornecedores();
                    fornecedoresId.DataSource = await _fornecedoresRepository.GetListaFornecedores(codigo);
                    mod = await _fornecedoresRepository.GetFornecedoresById(codigo);
                    gridListaFornecedores.DataSource = fornecedoresId;

                    if (mod != null)
                    {
                        txtFornecedor.Text = mod.FornecedorNome;
                        txtCNPJ.Text = mod.Cnpj;
                        txtEnd.Text = mod.Endereco;
                        txtNum.Text = Convert.ToString(mod.Numero);
                        txtCep.Text = mod.Cep;
                        txtCidade.Text = mod.Cidade;
                        txtSp.Text = mod.Estado;
                        txtTelefone.Text = mod.Telefone;
                        txtCelular.Text = mod.Celular;
                        btnRegister.Text = "Atualizar";
                    }
                   
                }
               
                else
                {
                    MessageBox.Show("Nenhum resultando encontrado");
                }
            }
            else
            {
                ListaFornecedores();
            }
           
        }
    }
}
