using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Tienda
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form f in forms)
            {
                if(f.Name != "FormMenu")
                {
                    f.Close();

                }
            }

            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario: " + Utilidades.UsuarioActual.Nombre;

            if (Utilidades.UsuarioActual.EsAdmin)
            {
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                usuariosToolStripMenuItem.Visible = false;
                mantenimiento1ToolStripMenuItem.Visible = Utilidades.UsuarioActual.PuedeAccederModelos;
                mantenimiento2ToolStripMenuItem.Visible = Utilidades.UsuarioActual.PuedeAccederClientes;
                transaccion1ToolStripMenuItem.Visible = Utilidades.UsuarioActual.PuedeAccederFacturas;
                reportesToolStripMenuItem.Visible = Utilidades.UsuarioActual.PuedeAccederReportes;
            }
        }

        private void mantenimiento1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formModelo = new FormModelo();
            formModelo.MdiParent = this;
            formModelo.Show();
        }

        private void mantenimiento2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }
                
        private void transaccion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteModelos = new FormReporteModelos();
            formReporteModelos.MdiParent = this;
            formReporteModelos.Show();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteClientes = new FormReporteClientes();
            formReporteClientes.MdiParent = this;
            formReporteClientes.Show();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();
        }
    }
}
