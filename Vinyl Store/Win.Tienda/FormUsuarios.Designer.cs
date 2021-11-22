namespace Win.Tienda
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label puedeAccederClientesLabel;
            System.Windows.Forms.Label puedeAccederFacturasLabel;
            System.Windows.Forms.Label puedeAccederModelosLabel;
            System.Windows.Forms.Label puedeAccederReportesLabel;
            this.listaUsuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaUsuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.puedeAccederClientesCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeAccederFacturasCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeAccederModelosCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeAccederReportesCheckBox = new System.Windows.Forms.CheckBox();
            this.listaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            puedeAccederClientesLabel = new System.Windows.Forms.Label();
            puedeAccederFacturasLabel = new System.Windows.Forms.Label();
            puedeAccederModelosLabel = new System.Windows.Forms.Label();
            puedeAccederReportesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).BeginInit();
            this.listaUsuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(78, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(50, 75);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // listaUsuariosBindingNavigator
            // 
            this.listaUsuariosBindingNavigator.AddNewItem = null;
            this.listaUsuariosBindingNavigator.BindingSource = this.listaUsuariosBindingSource;
            this.listaUsuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaUsuariosBindingNavigator.DeleteItem = null;
            this.listaUsuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaUsuariosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaUsuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaUsuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaUsuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaUsuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaUsuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaUsuariosBindingNavigator.Name = "listaUsuariosBindingNavigator";
            this.listaUsuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaUsuariosBindingNavigator.Size = new System.Drawing.Size(508, 25);
            this.listaUsuariosBindingNavigator.TabIndex = 0;
            this.listaUsuariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaUsuariosBindingNavigatorSaveItem
            // 
            this.listaUsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaUsuariosBindingNavigatorSaveItem.Name = "listaUsuariosBindingNavigatorSaveItem";
            this.listaUsuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaUsuariosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaUsuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaUsuariosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(103, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(339, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(103, 72);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(339, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.Tag = "";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new System.Drawing.Point(33, 101);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(64, 13);
            contrasenaLabel.TabIndex = 7;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Location = new System.Drawing.Point(103, 98);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '*';
            this.contrasenaTextBox.Size = new System.Drawing.Size(339, 20);
            this.contrasenaTextBox.TabIndex = 8;
            // 
            // puedeAccederClientesLabel
            // 
            puedeAccederClientesLabel.AutoSize = true;
            puedeAccederClientesLabel.Location = new System.Drawing.Point(110, 155);
            puedeAccederClientesLabel.Name = "puedeAccederClientesLabel";
            puedeAccederClientesLabel.Size = new System.Drawing.Size(124, 13);
            puedeAccederClientesLabel.TabIndex = 8;
            puedeAccederClientesLabel.Text = "Puede Acceder Clientes:";
            // 
            // puedeAccederClientesCheckBox
            // 
            this.puedeAccederClientesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "PuedeAccederClientes", true));
            this.puedeAccederClientesCheckBox.Location = new System.Drawing.Point(240, 150);
            this.puedeAccederClientesCheckBox.Name = "puedeAccederClientesCheckBox";
            this.puedeAccederClientesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.puedeAccederClientesCheckBox.TabIndex = 9;
            this.puedeAccederClientesCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeAccederFacturasLabel
            // 
            puedeAccederFacturasLabel.AutoSize = true;
            puedeAccederFacturasLabel.Location = new System.Drawing.Point(106, 178);
            puedeAccederFacturasLabel.Name = "puedeAccederFacturasLabel";
            puedeAccederFacturasLabel.Size = new System.Drawing.Size(128, 13);
            puedeAccederFacturasLabel.TabIndex = 9;
            puedeAccederFacturasLabel.Text = "Puede Acceder Facturas:";
            // 
            // puedeAccederFacturasCheckBox
            // 
            this.puedeAccederFacturasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "PuedeAccederReportes", true));
            this.puedeAccederFacturasCheckBox.Location = new System.Drawing.Point(240, 171);
            this.puedeAccederFacturasCheckBox.Name = "puedeAccederFacturasCheckBox";
            this.puedeAccederFacturasCheckBox.Size = new System.Drawing.Size(104, 24);
            this.puedeAccederFacturasCheckBox.TabIndex = 10;
            this.puedeAccederFacturasCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeAccederModelosLabel
            // 
            puedeAccederModelosLabel.AutoSize = true;
            puedeAccederModelosLabel.Location = new System.Drawing.Point(279, 155);
            puedeAccederModelosLabel.Name = "puedeAccederModelosLabel";
            puedeAccederModelosLabel.Size = new System.Drawing.Size(127, 13);
            puedeAccederModelosLabel.TabIndex = 11;
            puedeAccederModelosLabel.Text = "Puede Acceder Modelos:";
            // 
            // puedeAccederModelosCheckBox
            // 
            this.puedeAccederModelosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "PuedeAccederModelos", true));
            this.puedeAccederModelosCheckBox.Location = new System.Drawing.Point(412, 150);
            this.puedeAccederModelosCheckBox.Name = "puedeAccederModelosCheckBox";
            this.puedeAccederModelosCheckBox.Size = new System.Drawing.Size(104, 24);
            this.puedeAccederModelosCheckBox.TabIndex = 12;
            this.puedeAccederModelosCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeAccederReportesLabel
            // 
            puedeAccederReportesLabel.AutoSize = true;
            puedeAccederReportesLabel.Location = new System.Drawing.Point(276, 176);
            puedeAccederReportesLabel.Name = "puedeAccederReportesLabel";
            puedeAccederReportesLabel.Size = new System.Drawing.Size(130, 13);
            puedeAccederReportesLabel.TabIndex = 13;
            puedeAccederReportesLabel.Text = "Puede Acceder Reportes:";
            // 
            // puedeAccederReportesCheckBox
            // 
            this.puedeAccederReportesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource, "PuedeAccederReportes", true));
            this.puedeAccederReportesCheckBox.Location = new System.Drawing.Point(412, 171);
            this.puedeAccederReportesCheckBox.Name = "puedeAccederReportesCheckBox";
            this.puedeAccederReportesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.puedeAccederReportesCheckBox.TabIndex = 14;
            this.puedeAccederReportesCheckBox.UseVisualStyleBackColor = true;
            // 
            // listaUsuariosBindingSource
            // 
            this.listaUsuariosBindingSource.DataSource = typeof(BL.Tienda.Usuario);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 222);
            this.Controls.Add(puedeAccederReportesLabel);
            this.Controls.Add(this.puedeAccederReportesCheckBox);
            this.Controls.Add(puedeAccederModelosLabel);
            this.Controls.Add(this.puedeAccederModelosCheckBox);
            this.Controls.Add(puedeAccederFacturasLabel);
            this.Controls.Add(this.puedeAccederFacturasCheckBox);
            this.Controls.Add(puedeAccederClientesLabel);
            this.Controls.Add(this.puedeAccederClientesCheckBox);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaUsuariosBindingNavigator);
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).EndInit();
            this.listaUsuariosBindingNavigator.ResumeLayout(false);
            this.listaUsuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaUsuariosBindingSource;
        private System.Windows.Forms.BindingNavigator listaUsuariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaUsuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.CheckBox puedeAccederClientesCheckBox;
        private System.Windows.Forms.CheckBox puedeAccederFacturasCheckBox;
        private System.Windows.Forms.CheckBox puedeAccederModelosCheckBox;
        private System.Windows.Forms.CheckBox puedeAccederReportesCheckBox;
    }
}