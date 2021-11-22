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
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();

            var _clientesBL = new ClientesBL();
            var bindingSourge = new BindingSource();
            bindingSourge.DataSource = _clientesBL.ObtenerClientes();

            var reporte = new ReporteClientes();
            reporte.SetDataSource(bindingSourge);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
