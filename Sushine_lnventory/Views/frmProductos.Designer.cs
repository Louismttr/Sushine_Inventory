namespace Sushine_lnventory.Views
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBox_Movimientos = new System.Windows.Forms.GroupBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCostoUni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.eProv1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.dGV_Productos = new System.Windows.Forms.DataGridView();
            this.grpBox_Movimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_Movimientos
            // 
            this.grpBox_Movimientos.Controls.Add(this.cmbCategorias);
            this.grpBox_Movimientos.Controls.Add(this.txtPrecioVenta);
            this.grpBox_Movimientos.Controls.Add(this.label8);
            this.grpBox_Movimientos.Controls.Add(this.txtCostoUni);
            this.grpBox_Movimientos.Controls.Add(this.label5);
            this.grpBox_Movimientos.Controls.Add(this.txtNamePro);
            this.grpBox_Movimientos.Controls.Add(this.txtCodPro);
            this.grpBox_Movimientos.Controls.Add(this.label3);
            this.grpBox_Movimientos.Controls.Add(this.label2);
            this.grpBox_Movimientos.Controls.Add(this.label1);
            this.grpBox_Movimientos.Controls.Add(this.btnRegistrar);
            this.grpBox_Movimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Movimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.grpBox_Movimientos.Location = new System.Drawing.Point(22, 28);
            this.grpBox_Movimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Movimientos.Name = "grpBox_Movimientos";
            this.grpBox_Movimientos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Movimientos.Size = new System.Drawing.Size(927, 178);
            this.grpBox_Movimientos.TabIndex = 2;
            this.grpBox_Movimientos.TabStop = false;
            this.grpBox_Movimientos.Text = "Datos de Productos";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.ForeColor = System.Drawing.Color.Gray;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(435, 64);
            this.cmbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(203, 27);
            this.cmbCategorias.TabIndex = 24;
            this.cmbCategorias.Text = "Seleccione una categoría";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecioVenta.Location = new System.Drawing.Point(222, 136);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(162, 27);
            this.txtPrecioVenta.TabIndex = 19;
            this.txtPrecioVenta.Text = "Precio de Venta";
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(219, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio de Venta";
            // 
            // txtCostoUni
            // 
            this.txtCostoUni.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUni.ForeColor = System.Drawing.Color.Gray;
            this.txtCostoUni.Location = new System.Drawing.Point(28, 136);
            this.txtCostoUni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoUni.Name = "txtCostoUni";
            this.txtCostoUni.Size = new System.Drawing.Size(162, 27);
            this.txtCostoUni.TabIndex = 15;
            this.txtCostoUni.Text = "Costo Unitario";
            this.txtCostoUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Costo Unitario";
            // 
            // txtNamePro
            // 
            this.txtNamePro.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePro.ForeColor = System.Drawing.Color.Gray;
            this.txtNamePro.Location = new System.Drawing.Point(222, 64);
            this.txtNamePro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(162, 27);
            this.txtNamePro.TabIndex = 11;
            this.txtNamePro.Text = "Nombre del Producto";
            this.txtNamePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamePro_KeyPress);
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.ForeColor = System.Drawing.Color.Gray;
            this.txtCodPro.Location = new System.Drawing.Point(28, 64);
            this.txtCodPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(162, 27);
            this.txtCodPro.TabIndex = 10;
            this.txtCodPro.Text = "Código del Producto";
            this.txtCodPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(431, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categorías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(219, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código del Producto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(191)))), ((int)(((byte)(178)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = global::Sushine_lnventory.Properties.Resources.AgregarE;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(772, 126);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(51, 228);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(309, 22);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Text = "Buscar...";
            // 
            // eProv1
            // 
            this.eProv1.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sushine_lnventory.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(24, 230);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(21, 18);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dGV_Productos
            // 
            this.dGV_Productos.AllowUserToAddRows = false;
            this.dGV_Productos.AllowUserToDeleteRows = false;
            this.dGV_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Productos.EnableHeadersVisualStyles = false;
            this.dGV_Productos.Location = new System.Drawing.Point(22, 264);
            this.dGV_Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Productos.Name = "dGV_Productos";
            this.dGV_Productos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(191)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_Productos.RowHeadersVisible = false;
            this.dGV_Productos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(191)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dGV_Productos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_Productos.RowTemplate.Height = 28;
            this.dGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Productos.Size = new System.Drawing.Size(927, 262);
            this.dGV_Productos.TabIndex = 6;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 549);
            this.Controls.Add(this.dGV_Productos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.grpBox_Movimientos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.grpBox_Movimientos.ResumeLayout(false);
            this.grpBox_Movimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Movimientos;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCostoUni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ErrorProvider eProv1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.DataGridView dGV_Productos;
    }
}