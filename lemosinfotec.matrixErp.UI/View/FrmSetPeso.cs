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
    public partial class FrmSetPeso : Form
    {
        frmVendas objVendas;
        VendasRepository _vendasRepository = new VendasRepository();
        int VendasId;
        int EmpId;
        public FrmSetPeso(int Id, int EmpresaId)
        {
            InitializeComponent();
            lblVendasId.Visible = false;
            VendasId = Id;
            EmpId = EmpresaId;
           
        }
         
        private void GetValores(Vendas vendas)
        {
            decimal valorUnitario = _vendasRepository.GetValorUnitById(VendasId, EmpId);
            decimal peso = Convert.ToDecimal(txtPeso.Text);
            decimal ValorVendas = peso * valorUnitario / 1000;

            vendas.Id = VendasId;
            vendas.ValorVenda = ValorVendas;
            vendas.Peso = peso;
            _vendasRepository.AddValorVendaAndPeso(vendas);


        }

       

        private void FrmSetPeso_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnAddPeso_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            GetValores(vendas);
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSetPeso_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Vendas vendas = new Vendas();
                GetValores(vendas);
                this.Close();
            }
        }
    }
}
