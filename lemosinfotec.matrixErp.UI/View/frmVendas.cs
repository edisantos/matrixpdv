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
    public partial class frmVendas : Form
    {
        VendasRepository _vendasRepository = new VendasRepository();
        CaixaRepostitory _caixaRepostitory = new CaixaRepostitory();
        TipoPagamentoRepository _tipoPagamento = new TipoPagamentoRepository();
        CaixaVendasBase caixaVendasModel = new CaixaVendasBase();
        AccountRepository _accountRepository = new AccountRepository();
        int _IdUserLogado;
        public frmVendas(int IdUsr)
        {
            InitializeComponent();

            _IdUserLogado = IdUsr;
            lblMsgAlerta.Visible = false;
            Combox();
            GetListaVendas();
            TotalItemVendas();
            if (cmbCaixa.SelectedIndex < 1)
            {
                lblStatusCaixa.Text = "NENHUM CAIXA SELECIONADO";
                btnAtivarCaixa.Visible = true;

            }
           // btnFinalizar.Enabled = false;


        }

        public async void Combox()
        {
            var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
            var caixas = await _caixaRepostitory.GetNumeroCaixas(empresa.EmpresaId);

            cmbCaixa.DataSource = caixas;
            cmbCaixa.ValueMember = "Id";
            cmbCaixa.DisplayMember = "Nome";
            cmbCaixa.Text = "--DEFINA O CAIXA--";


        }

        private void lblTotalEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodeItem_KeyUp(object sender, KeyEventArgs e)
        {
            //LerCodigo();
        }

        private void LerCodigo()
        {
            int combo = Convert.ToInt32(cmbCaixa.SelectedValue);
            if (combo > 0)
            {
                var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                Estoque mod = new Estoque();
                int ProdutoId = Convert.ToInt32(txtCodeItem.Text);
                mod = _vendasRepository.GetValorUnit(ProdutoId, empresa.EmpresaId);
                if (mod != null)
                {
                    lblValorUnitario.Font = new Font(lblValorUnitario.Font.Name, 24F);
                    lblValorUnitario.Text = mod.ValorUnit.ToString("C");
                    txtCodeItem.Text = string.Empty;
                    lblMsgAlerta.Visible = false;



                }
                else
                {
                    lblMsgAlerta.Visible = true;
                    lblMsgAlerta.ForeColor = Color.DarkRed;
                    lblMsgAlerta.Text = "Produto não encontrado no estoque";
                }

            }
            else
            {
                lblMsgAlerta.Visible = true;
                lblMsgAlerta.ForeColor = Color.DarkRed;
                lblMsgAlerta.Text = "Nenhum caixa foi selecionado!";
            }



        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
            CaixaVendasBase mod = new CaixaVendasBase();
            mod.CaixaId = Convert.ToInt32(cmbCaixa.SelectedValue);
            mod.EmpresaId = empresa.EmpresaId;
            var statusCaixa = btnFinalizar.Text;
            switch (statusCaixa)
            {
                case "INICIAR VENDAS":
                    _vendasRepository.AbrirCaixa(mod);
                   
                    var check = _vendasRepository.CheckStatusCaixa(mod.CaixaId,empresa.EmpresaId);
                    if (check != null)
                    {
                        btnFinalizar.Text = "INICIAR VENDAS";
                        lblStatusCaixa.Text = "CAIXA OCUPADO";
                        btnFinalizar.Enabled = false;
                    }
                    break;
                case "FINALIZAR VENDAS":

                    
                    caixaVendasModel = _vendasRepository.CheckStatusCaixa(mod.CaixaId, empresa.EmpresaId);
                    _vendasRepository.FinalizarVenda(caixaVendasModel.Id);
                    GetListaVendas();
                    TotalItemVendas();
                    CheckStatus(Convert.ToInt32(cmbCaixa.SelectedValue));
                    lblSubTotal.Text = "R$: 00,00";
                    lblTotalRecebido.Text = "R$: 00,00";
                    lblTroco.Text = "R$: 00,00";
                    lblTotalItem.Text = "R$: 00,00";
                    lblValorUnitario.Text = "R$: 00,00";
                    break;

            }


        }


        private void txtCodeItem_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeItem.Text != "")
            {
                var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                bool check = _vendasRepository.CheckProdutoEstoque(Convert.ToInt32(txtCodeItem.Text),empresa.EmpresaId);
                if (check == true)
                {
                    if(lblStatusCaixa.Text !="CAIXA LIVRE")
                    {
                       
                        Estoque estoque = new Estoque();
                        var CaixaId = Convert.ToInt32(cmbCaixa.SelectedValue);
                        caixaVendasModel = _vendasRepository.CheckStatusCaixa(CaixaId,empresa.EmpresaId);
                        Vendas vendas = new Vendas();
                        vendas.ProdutoId = Convert.ToInt32(txtCodeItem.Text);
                        estoque = _vendasRepository.CheckQtyEstoque(Convert.ToInt32(txtCodeItem.Text),empresa.EmpresaId);
                        if (estoque.Quantidade < estoque.EstoqueMin)
                        {
                            MessageBox.Show("Estoque Baixo!" + "Há apenas " + estoque.Quantidade + " itens no estoque. É necessarios repor.");
                        }
                        if (estoque.Quantidade > 0)
                        {
                            
                            vendas.CaixaId = CaixaId;
                            vendas.TotalItem = 1;
                            vendas.OperadorId = empresa.Id;
                            vendas.VendasBaseId = caixaVendasModel.Id;
                            vendas.EmpresaId = empresa.EmpresaId;
                            _vendasRepository.RegistrarVendas(vendas);

                            int novaQuantidadeEstoque = estoque.Quantidade - 1;
                            estoque.Quantidade = novaQuantidadeEstoque;
                            _vendasRepository.AtualiarEstoqueVendas(estoque);

                            int getVendasId = _vendasRepository.GetVendasId(Convert.ToInt32(txtCodeItem.Text),empresa.EmpresaId);

                            FrmSetPeso formPeso = new FrmSetPeso(getVendasId, empresa.EmpresaId);
                            formPeso.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Não há produto em estoque");
                        }


                        LerCodigo();
                        GetListaVendas();
                        TotalItemVendas();
                        SubTotal();
                    }
                    else
                    {
                        MessageBox.Show("NENHUMA VENDA FOI INICIADA!\nINICIE UMA VENDA DEPOIS TENTE ENTRAR COM O ITEM");
                    }
                   

                }
                else
                {
                    //lblMsgAlerta.Visible = true;
                    //lblMsgAlerta.ForeColor = Color.DarkRed;
                    //lblMsgAlerta.Font = new Font(lblMsgAlerta.Font.Name, 24F);
                    //lblMsgAlerta.Text = "Produto não encontrado no estoque";
                    MessageBox.Show("Produto não encontrado no estoque");
                    txtCodeItem.Text = string.Empty;
                }




            }



        }
        /// <summary>
        /// 
        /// </summary>
        private async void GetListaVendas()
        {
            try
            {
                var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                int caixa = Convert.ToInt32(cmbCaixa.SelectedValue);
                grwListaItem.AutoGenerateColumns = false;
                grwListaItem.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                grwListaItem.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                grwListaItem.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                grwListaItem.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                grwListaItem.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                grwListaItem.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                grwListaItem.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                grwListaItem.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                grwListaItem.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                grwListaItem.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                var vendas = new BindingSource();
                vendas.DataSource = await _vendasRepository.GetVendas(caixa,empresas.EmpresaId);
                grwListaItem.DataSource = vendas;

            }
            catch (Exception ex)
            {

                lblMsgAlerta.ForeColor = Color.DarkRed;
                lblMsgAlerta.Text = $"{ex.Message}";
            }
        }

        public void TotalItemVendas()
        {
            try
            {
                int caixa = Convert.ToInt32(cmbCaixa.SelectedValue);
                lblTotalItem.Font = new Font(lblTotalItem.Font.Name, 24F);
                decimal total = _vendasRepository.TotalItem(caixa);
                lblTotalItem.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {

                lblMsgAlerta.ForeColor = Color.DarkRed;
                lblMsgAlerta.Text = $"{ex.Message}";
            }
        }

        public void SubTotal()
        {
            try
            {
                var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                int caixa = Convert.ToInt32(cmbCaixa.SelectedValue);
                var subtotal = _vendasRepository.SubTotal(caixa,empresas.EmpresaId);
                lblSubTotal.Text = subtotal.ToString("C");
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
        /// <param name="CaixaId"></param>
        private void CheckStatus(int CaixaId)
        {
            var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
            caixaVendasModel = _vendasRepository.CheckStatusCaixa(CaixaId,empresas.EmpresaId);
            if (caixaVendasModel != null)
            {
                btnFinalizar.Text = "INICIAR VENDAS";
                lblStatusCaixa.Text = "CAIXA OCUPADO";
            }
            else
            {
                btnFinalizar.Text = "INICIAR VENDAS";
                lblStatusCaixa.Text = "CAIXA LIVRE";
            }
        }



        private void btnAtivarCaixa_Click(object sender, EventArgs e)
        {
            var empresa = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
            CaixaVendasBase mod = new CaixaVendasBase();
            mod.CaixaId = Convert.ToInt32(cmbCaixa.SelectedValue);
            if (Convert.ToInt32(cmbCaixa.SelectedValue) > 0)
            {
                var check = _vendasRepository.CheckStatusCaixa(mod.CaixaId, empresa.EmpresaId);
                if (check != null)
                {
                    
                    lblStatusCaixa.Text = "CAIXA OCUPADO";
                    btnFinalizar.Enabled = false;
                }
                CheckStatus(Convert.ToInt32(cmbCaixa.SelectedValue));
                GetListaVendas();
                TotalItemVendas();
                SubTotal();

            }
            else
            {
                lblStatusCaixa.Text = "NENHUM CAIXA SELECIONADO";
            }


        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F11:
                    btnFinalizar_Click(sender, e);
                    break;
            }
        }


        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            FrmRemoverItem frmRemoverItem = new FrmRemoverItem();
            frmRemoverItem.ShowDialog();
            GetListaVendas();
            TotalItemVendas();
            SubTotal();
        }



        private void frmVendas_KeyDown_1(object sender, KeyEventArgs e)
        {
            int CaixaId = Convert.ToInt32(cmbCaixa.SelectedValue);
            switch (e.KeyCode)
            {
               
                case Keys.F1:
                    var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                    caixaVendasModel = _vendasRepository.CheckStatusCaixa(CaixaId, empresas.EmpresaId);
                    FrmPagamentos pagamentos = new FrmPagamentos(caixaVendasModel.Id);
                    pagamentos.ShowDialog();
                    GetValoresPagamentos(caixaVendasModel.Id);
                    btnFinalizar.Enabled = true;
                    btnFinalizar.Text = "FINALIZAR VENDAS";
                    break;
                case Keys.F2:
                    FrmRemoverItem frmRemoverItem = new FrmRemoverItem();
                    frmRemoverItem.ShowDialog();
                    GetListaVendas();
                    TotalItemVendas();
                    SubTotal();
                    break;
            }

        }

        private void linkPagamento_Click(object sender, EventArgs e)
        {
            var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
            int CaixaId = Convert.ToInt32(cmbCaixa.SelectedValue);
            caixaVendasModel = _vendasRepository.CheckStatusCaixa(CaixaId,empresas.EmpresaId);
            FrmPagamentos pagamentos = new FrmPagamentos(caixaVendasModel.Id);
            pagamentos.ShowDialog();

        }
        void GetValoresPagamentos(int Id)
        {
            caixaVendasModel = _vendasRepository.GetValoresPagamentos(Id);
            if (caixaVendasModel != null)
            {
                lblTotalRecebido.Text = Convert.ToDecimal(caixaVendasModel.ValorRecebido).ToString("C");
                lblTroco.Text = Convert.ToDecimal(caixaVendasModel.ValorTroco).ToString("C");
            }
        }
    }
}
