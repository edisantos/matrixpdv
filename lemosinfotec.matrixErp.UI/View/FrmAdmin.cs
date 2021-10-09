using lemosinfotec.matrixErp.Repository.Repositories.Administrador;
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
    public partial class FrmAdmin : Form
    {
        AdministradorRepository _administradorRepository = new AdministradorRepository();
        public FrmAdmin()
        {
            InitializeComponent();
            lblMsg.Visible = false;
            Lista();
        }

        public async void Lista()
        {
            try
            {
                gridUsuariosAdmin.AutoGenerateColumns = false;
                var listausuarios = new BindingSource();
                listausuarios.DataSource = await _administradorRepository.GetContaUsuarios();

               
                gridUsuariosAdmin.DataSource = listausuarios;
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = $"{ex.Message}";
                lblMsg.ForeColor = Color.DarkRed;
            }
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmNovoUsuario form = new FrmNovoUsuario();
            form.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();
            frm.ShowDialog();
        }
    }
}
