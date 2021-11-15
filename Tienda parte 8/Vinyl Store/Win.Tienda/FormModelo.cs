using BL.Tienda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Tienda
{
    public partial class FormModelo : Form
    {
        ModeloBL _modelos;
        CategoriasBL _categorias;
        TiposBL _tiposBL;

        public FormModelo()
        {
            InitializeComponent();

            _modelos = new ModeloBL();
            listaModelosBindingSource.DataSource = _modelos.ObtenerModelos();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tiposBL = new TiposBL();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();
        }

        private void listaModelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaModelosBindingSource.EndEdit();
            var modelo = (Modelo)listaModelosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                modelo.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
                {
                    modelo.Foto = null;
                }

            var resultado = _modelos.GuardarModelo(modelo);

            if (resultado.Exitoso == true)
            {
                listaModelosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");

            }
            else
                {
                MessageBox.Show(resultado.Mensaje);
                }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _modelos.AgregarModelo();
            listaModelosBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
                
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _modelos.EliminarModelo(id);

            if (resultado == true)
            {
                listaModelosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el modelo");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _modelos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);            
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var modelo = (Modelo)listaModelosBindingSource.Current;

            if (modelo != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
                {
                    MessageBox.Show("Cree un producto antes de asignarle una imagen");
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
