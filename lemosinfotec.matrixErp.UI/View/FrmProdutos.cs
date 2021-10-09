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
    public partial class FrmProdutos : Form
    {
        ProdtutosRepository _repository = new ProdtutosRepository();
        AccountRepository _accountRepository = new AccountRepository();
        int _IdUserLogado;
        public FrmProdutos(int IdUsr)
        {
            InitializeComponent();
            _IdUserLogado = IdUsr;
            ListaProdutos();
            Contator();

        }
        void DataLoading()
        {
            for (int i = 0; i <= 300; i++)
                Thread.Sleep(10);
        }
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSalvarProdutos_Click(object sender, EventArgs e)
        {
            try
            {

                using (frmLoading frmLoading = new frmLoading(DataLoading))
                {
                    frmLoading.ShowDialog(this);
                }


                var empresaId = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                Produtos mod = new Produtos();
                mod.ProdutoNome = txtNovoProduto.Text.ToUpper();
                mod.EmpresaId = empresaId.EmpresaId;
                bool check = _repository.CheckProdutos(mod.ProdutoNome);
                if (check == false)
                {
                    
                    await _repository.AddNovoProdutos(mod);
                    lblMsgAlerta.ForeColor = Color.GreenYellow;
                    lblMsgAlerta.Text = mod.ProdutoNome + " registrado feito com sucesso!";
                    txtNovoProduto.Text = string.Empty;
                    ListaProdutos();
                    Contator();
                }
                else
                {
                    lblMsgAlerta.ForeColor = Color.DarkRed;
                    lblMsgAlerta.Text = mod.ProdutoNome + " já esta cadastro!";
                }

            }
            catch (Exception ex)
            {
                lblMsgAlerta.ForeColor = Color.DarkRed;
                lblMsgAlerta.Text = $"{ex.Message}";
            }

        }
        /// <summary>
        /// 
        /// </summary>
        private async void ListaProdutos()
        {
            try
            {
                var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                grwListaProdutos.AutoGenerateColumns = false;
                var listar = new BindingList<Produtos>(await _repository.GetProdutos(empresa.EmpresaId));
                grwListaProdutos.DataSource = listar;

            }
            catch (Exception ex)
            {

                lblMsgAlerta.ForeColor = Color.DarkRed;
                lblMsgAlerta.Text = $"{ex.Message}";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Contator()
        {
            try
            {

                var total = _repository.Contador();
                lblContator.Text = "Total de produtos: " + Convert.ToString(total);






            }
            catch (Exception ex)
            {

                lblMsgAlerta.ForeColor = Color.DarkRed;
                lblMsgAlerta.Text = $"{ex.Message}";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Pesquise aqui";
                txtSearch.ForeColor = Color.DimGray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Pesquise aqui")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.LightGray;

            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string ProdutoNome = txtSearch.Text.ToUpper();
            if (ProdutoNome != "")
            {
                grwListaProdutos.AutoGenerateColumns = false;
                var listar = new BindingList<Produtos>(await _repository.GetProdutosPorItem(ProdutoNome));
                grwListaProdutos.DataSource = listar;
                var total = _repository.Contador(ProdutoNome);
                lblContator.Text = "Total de produtos: " + Convert.ToString(total);
            }
            else
            {
                grwListaProdutos.AutoGenerateColumns = false;
                var listar = new BindingList<Produtos>(await _repository.GetProdutos());
                grwListaProdutos.DataSource = listar;
                Contator();
            }

            txtSearch.Text = string.Empty;
        }
    }
}
