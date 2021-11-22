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
    public partial class FormReporteModelos : Form
    {
        public FormReporteModelos()
        {
            InitializeComponent();

            var _modeloBL = new ModeloBL();
            var bindingSourge = new BindingSource();
            bindingSourge.DataSource = _modeloBL.ObtenerModelos();

            var reporte = new ReporteModelos();
            reporte.SetDataSource(bindingSourge);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
