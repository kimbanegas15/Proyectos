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
    public partial class FormReporte3 : Form
    {
        public FormReporte3()
        {
            InitializeComponent();
            var _facturaBL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturaBL.ObtenerFacturas();

            var reporte = new reporteFactura();
            reporte.SetDataSource(bindingSource);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
