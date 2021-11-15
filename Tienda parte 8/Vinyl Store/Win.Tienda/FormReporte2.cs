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
    public partial class FormReporte2 : Form
    {
        public FormReporte2()
        {
            InitializeComponent();
            var _modeloBL = new ModeloBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _modeloBL.ObtenerModelos();

            var reporte = new productoReporte();
            reporte.SetDataSource(bindingSource);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
