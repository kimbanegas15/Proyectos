using BL.Tienda;
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
    public partial class FormReporte1 : Form
    {
        public FormReporte1()
        {
            InitializeComponent();

            var _clienteBL = new ClientesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _clienteBL.ObtenerClientes();

            var reporte = new clienteReporte();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
