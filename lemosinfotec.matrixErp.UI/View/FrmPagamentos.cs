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
    public partial class FrmPagamentos : Form
    {
        TipoPagamentoRepository _tipoPagamento = new TipoPagamentoRepository();
        VendasRepository _vendasRepository = new VendasRepository();
        int Id;
        public FrmPagamentos(int Caixaid)
        {
            InitializeComponent();
            LoadFormaPagamento();
            label1.Text = Convert.ToString(Caixaid);
            Id = Caixaid;
        }

        private void btnSalvarValorPago_Click(object sender, EventArgs e)
        {
            var caixabase = new CaixaVendasBase();
            decimal valorPago = _vendasRepository.GetSomaValoresGastos(Id);
            if (caixabase != null)
            {
              
                caixabase.ValorRecebido = Convert.ToDecimal(txtValorPago.Text);
                caixabase.ValorPago = valorPago;
                caixabase.ValorTroco = Convert.ToDecimal(txtValorPago.Text) - valorPago;
                caixabase.TipoPagamentoId = Convert.ToInt32(ccmbTipoPag.SelectedValue);
                _vendasRepository.PagamentoCaixaBase(caixabase,Id);
            }
           
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        async void LoadFormaPagamento()
        {
            var tipopagamentos = await _tipoPagamento.GetPagamentos();
            if (tipopagamentos != null)
            {
                ccmbTipoPag.DataSource = tipopagamentos;
                ccmbTipoPag.ValueMember = "Id";
                ccmbTipoPag.DisplayMember = "Nome";
                ccmbTipoPag.Text = "--SELECIONE A FORMA DE PAGAMENTO--";
            }
        }

        private void FrmPagamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var caixabase = new CaixaVendasBase();
                decimal valorPago = _vendasRepository.GetSomaValoresGastos(Id);
                if (caixabase != null)
                {

                    caixabase.ValorRecebido = Convert.ToDecimal(txtValorPago.Text);
                    caixabase.ValorPago = valorPago;
                    caixabase.ValorTroco = Convert.ToDecimal(txtValorPago.Text) - valorPago;
                    caixabase.TipoPagamentoId = Convert.ToInt32(ccmbTipoPag.SelectedValue);
                    _vendasRepository.PagamentoCaixaBase(caixabase, Id);
                }
            }
        }
    }
}
