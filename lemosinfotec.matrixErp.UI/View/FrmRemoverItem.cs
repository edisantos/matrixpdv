using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Repository.Repositories;
using System;
using System.Windows.Forms;

namespace lemosinfotec.matrixErp.UI.View
{
    public partial class FrmRemoverItem : Form
    {
       
       
        VendasRepository _vendasRepository = new VendasRepository();
        public FrmRemoverItem()
        {
            InitializeComponent();
        }

        private void btnRemoverItemVenda_Click(object sender, EventArgs e)
        {
            if(txtRemoverItem.Text != "")
            {
                int Id = Convert.ToInt32(txtRemoverItem.Text);
                if (Id > 0)
                {
                    _vendasRepository.RemoveItemVenda(Id);
                    var produtoId = _vendasRepository.GetVendasProdutoById(Id);
                    if (produtoId != null)
                    {
                        _vendasRepository.RetornoEstoqueAposRemoverItem(produtoId.ProdutoId);
                    }
                    MessageBox.Show("Item removido com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Nenhum código foi adicionado!\n Para remover o item digite o número do item.");
            }
           
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
