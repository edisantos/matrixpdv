using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Repository.Repositories;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class FrmFinanceiro : Form
    {
        FinanceiroRepository _financeiroRepository = new FinanceiroRepository();
        AccountRepository _accountRepository = new AccountRepository();
        int _IdUserLogado;
        public FrmFinanceiro(int IdUsr)
        {
            InitializeComponent();
            _IdUserLogado = IdUsr;
             ListaFinanceira();
            lblMsg.Visible = false;
            //Graficos();

        }

        public async void ListaFinanceira()
        {
            try
            {
                string Data1 = txtPickerData1.Value.ToString("yyyy/MM/dd");
                string Data2 = txtPickerData2.Value.ToString("yyyy/MM/dd"); 
                var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
                var listaFinanceira = new BindingSource();
                if (listaFinanceira != null)
                {
                    listaFinanceira.DataSource = await _financeiroRepository.GetFinancasDiarias(Data1, Data2, empresas.EmpresaId);
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Nenhuma venda encontrada feita hoje!";
                }
                

                grwListaFinanceira.AutoGenerateColumns = false;
                grwListaFinanceira.DataSource = listaFinanceira;

                var TotaDia = _financeiroRepository.GetTotalVendasHoje(empresas.EmpresaId);
                if (TotaDia.ValorPago > 0)
                {
                    lblTotalDia.Text = TotaDia.ValorPago.ToString("C");
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Nenhuma venda encontrada feita hoje!";
                }


                var TotalWeekDay = _financeiroRepository.GetTotalVendasWeek(empresas.EmpresaId);
                lblTotalWeekDay.Text = TotalWeekDay.ValorPago.ToString("C");

                var TotalMonth = _financeiroRepository.GetTotalVendasMonth(empresas.EmpresaId);
                lblTotalMonth.Text = TotalMonth.ValorPago.ToString("C");

                
                    lblSomaVendas.Text = "R$: "  + grwListaFinanceira.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[ValorVenda.Name].Value ?? 0)).ToString("##.00");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Houve um erro:  {ex.Message}");
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {

            ListaFinanceira();
            lblMsg.Visible = false;
            lblSomaVendas.Text = "R$: " +  grwListaFinanceira.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[ValorVenda.Name].Value ?? 0)).ToString("##.00");
        }

        private void lblTotalDia_Click(object sender, EventArgs e)
        {

        }

        private void lblSomaVendas_Click(object sender, EventArgs e)
        {

        }
        private void Graficos()
        {
           
            
            var empresas = _accountRepository.GetUsuarioById(Convert.ToInt32(_IdUserLogado));
            var graficos = _financeiroRepository.GetGraficoMensal(empresas.EmpresaId);

            
        }
    }
}
