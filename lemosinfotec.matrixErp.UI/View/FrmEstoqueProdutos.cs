using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemosinfotec.matrixErp.UI.View
{
    public partial class FrmEstoqueProdutos : Form
    {
        ProdtutosRepository _produtosRepository = new ProdtutosRepository();
        EstoqueRepository _estoqueRepository = new EstoqueRepository();
        FornecedoresRepository _fornecedoresRepository = new FornecedoresRepository();
        AccountRepository _accountRepository = new AccountRepository();
        int _IdUserLogado;
        public FrmEstoqueProdutos(int IdUsr)
        {
            InitializeComponent();
            lblMsgAlerta.Visible = false;
            _IdUserLogado = IdUsr;
            Drops();
            ListaEstoque();
            AplicarEventos(txtValorUnit);
            
        }

        void DataLoading()
        {
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(10);
        }

        private void AplicarMascadaMoeda(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
        private void RemoverMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += RemoverMascara;
           // txt.Leave += AplicarMascadaMoeda;
            txt.KeyPress += ApenasValorNumerico;
        }
        private void btnSalvarProdutos_Click(object sender, EventArgs e)
        {
            try
            {

                using (frmLoading frmLoading = new frmLoading(DataLoading))
                {
                    frmLoading.ShowDialog(this);
                }
                Button nome = (Button)sender;
                var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                var mod = new Estoque();
                mod.ProdutoId = (int)cmbProdutos.SelectedValue;
                mod.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                mod.ValorUnit = Convert.ToDouble(txtValorUnit.Text);
                mod.TipoProdutoId = (int)cmbTipoProd.SelectedValue;
                mod.EstoqueMin = Convert.ToInt32(txtEstoqueMin.Text);
                mod.FornecedorId = (int)cmbFornecedor.SelectedValue;
                mod.EmpresaId = empresa.EmpresaId;
                if(nome.Text == "Salvar")
                {
                    bool check = _estoqueRepository.checkEstoque(mod.ProdutoId);
                    if (check == false)
                    {
                        _estoqueRepository.AddEstoque(mod);
                        lblMsgAlerta.Visible = true;
                        lblMsgAlerta.ForeColor = Color.GreenYellow;
                        lblMsgAlerta.Text = "Registro feito com sucesso!";
                    }
                    else
                    {
                        lblMsgAlerta.Visible = true;
                        lblMsgAlerta.ForeColor = Color.DarkRed;
                        lblMsgAlerta.Text = "Este produto já existe no estoque!\n Você pode usuar o campo pesquisa para atualizar este produto.";
                    }
                   
                }
                if (nome.Text == "Atualizar")
                {
                    _estoqueRepository.AtualizarEstoque(mod);
                    lblMsgAlerta.Visible = true;
                    lblMsgAlerta.ForeColor = Color.GreenYellow;
                    lblMsgAlerta.Text = "Registro atualizado sucesso!";
                }

                LimparCompos();
                ListaEstoque();
            }
            catch (Exception ex)
            {
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.Text = $"{ex.Message}";
                lblMsgAlerta.ForeColor = Color.DarkRed;
            }
                

            

        }
        /// <summary>
        /// 
        /// </summary>
        public async void ListaEstoque()
        {
            try
            {
                var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                grwListaEstoque.AutoGenerateColumns = false;
                var estoque = new BindingSource();
                estoque.DataSource = await _estoqueRepository.GetEstoque(empresa.EmpresaId);
              
                //var estoque = new BindingList<Estoque>(await _estoqueRepository.GetEstoque());
                grwListaEstoque.DataSource = estoque;
            }
            catch (Exception ex)
            {
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.Text = $"{ex.Message}";
                lblMsgAlerta.ForeColor = Color.DarkRed;
            }
        }

        private void lblProdutos_Click(object sender, EventArgs e)
        {

        }

        public async void Drops()
        {
            try
            {
                var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                var produtos = await _produtosRepository.GetProdutos(empresa.EmpresaId);
                cmbProdutos.DataSource = produtos;
                cmbProdutos.ValueMember = "ProdutoId";
                cmbProdutos.DisplayMember = "ProdutoNome";
                cmbProdutos.Text = "--ESCOLHA O PRODUTO--";
                
                var fornecedores = await _fornecedoresRepository.GetFornecedores(empresa.EmpresaId);
                cmbFornecedor.DataSource = fornecedores;
                cmbFornecedor.ValueMember = "FornecedorId";
                cmbFornecedor.DisplayMember = "FornecedorNome";
                cmbFornecedor.Text = "--ESCOLHA O FORNECEDOR--";

                var tipoProdutos = await _estoqueRepository.GetTipos();
                cmbTipoProd.DataSource = tipoProdutos;
                cmbTipoProd.ValueMember = "Id";
                cmbTipoProd.DisplayMember = "Nome";
                cmbTipoProd.Text = "--ESCOLHA O TIPO--";
            }
            catch (Exception ex)
            {
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.Text = $"{ex.Message}";
                lblMsgAlerta.ForeColor = Color.DarkRed;
            }
        }

        public void LimparCompos()
        {
            Drops();
            txtQuantidade.Text = string.Empty;
            txtValorUnit.Text = string.Empty;
            txtEstoqueMin.Text = string.Empty;
            btnSalvarProdutos.Text = "Salvar";

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                string ProdutoNome = txtSearch.Text;
               

                if (ProdutoNome != "")
                {
                    /*Carrega os formulário para edição*/
                    Estoque mod = new Estoque();
                    mod = await _estoqueRepository.CarregarFormulario(ProdutoNome);

                    cmbProdutos.SelectedValue = (int)mod.ProdutoId;
                    txtQuantidade.Text = Convert.ToString(mod.Quantidade);
                    txtValorUnit.Text = Convert.ToString(mod.ValorUnit);
                    cmbTipoProd.SelectedValue = (int)mod.TipoProdutoId;
                    txtEstoqueMin.Text = Convert.ToString(mod.EstoqueMin);
                    cmbFornecedor.SelectedValue = (int)mod.FornecedorId;
                    btnSalvarProdutos.Text = "Atualizar";

                    /*Carrega o gridview*/
                    grwListaEstoque.AutoGenerateColumns = false;
                    var estoque = new BindingSource();
                    estoque.DataSource = await _estoqueRepository.GetEstoque(ProdutoNome);
                    grwListaEstoque.DataSource = estoque;
                    txtSearch.Text = string.Empty;
                }
                else
                {
                    ListaEstoque();
                    LimparCompos();
                    btnSalvarProdutos.Text = "Salvar";
                }
               
            }
            catch (Exception ex)
            {
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.Text = $"{ex.Message}";
                lblMsgAlerta.ForeColor = Color.DarkRed;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Realmente deseja excluir este item?", "",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(txtSearch.Text);
                _estoqueRepository.ExcluirProduto(Id);
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.Text = "Produto excluido com sucesso!";
                lblMsgAlerta.ForeColor = Color.GreenYellow;
                txtSearch.Text = string.Empty;

                ListaEstoque();
                LimparCompos();
               
            }
        }

        private void FrmEstoqueProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
