﻿namespace Sushine_lnventory.Views
{
    partial class frm_Movimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBox_Movimientos = new System.Windows.Forms.GroupBox();
            this.gb_TMov = new System.Windows.Forms.GroupBox();
            this.rb_Salida = new System.Windows.Forms.RadioButton();
            this.rb_Entrada = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCostoU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Empleados = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Productos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDecargar = new System.Windows.Forms.Button();
            this.cmbFEmp2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFProd2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dGV_Movimientos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.grpBox_Movimientos.SuspendLayout();
            this.gb_TMov.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Movimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_Movimientos
            // 
            this.grpBox_Movimientos.Controls.Add(this.gb_TMov);
            this.grpBox_Movimientos.Controls.Add(this.btnRegistrar);
            this.grpBox_Movimientos.Controls.Add(this.txtCostoU);
            this.grpBox_Movimientos.Controls.Add(this.label2);
            this.grpBox_Movimientos.Controls.Add(this.cmb_Empleados);
            this.grpBox_Movimientos.Controls.Add(this.txtCantidad);
            this.grpBox_Movimientos.Controls.Add(this.label4);
            this.grpBox_Movimientos.Controls.Add(this.label3);
            this.grpBox_Movimientos.Controls.Add(this.cmb_Productos);
            this.grpBox_Movimientos.Controls.Add(this.label1);
            this.grpBox_Movimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Movimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.grpBox_Movimientos.Location = new System.Drawing.Point(27, 22);
            this.grpBox_Movimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Movimientos.Name = "grpBox_Movimientos";
            this.grpBox_Movimientos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Movimientos.Size = new System.Drawing.Size(927, 185);
            this.grpBox_Movimientos.TabIndex = 0;
            this.grpBox_Movimientos.TabStop = false;
            this.grpBox_Movimientos.Text = "Movimientos";
            // 
            // gb_TMov
            // 
            this.gb_TMov.Controls.Add(this.rb_Salida);
            this.gb_TMov.Controls.Add(this.rb_Entrada);
            this.gb_TMov.Location = new System.Drawing.Point(549, 42);
            this.gb_TMov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_TMov.Name = "gb_TMov";
            this.gb_TMov.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_TMov.Size = new System.Drawing.Size(141, 78);
            this.gb_TMov.TabIndex = 11;
            this.gb_TMov.TabStop = false;
            // 
            // rb_Salida
            // 
            this.rb_Salida.AutoSize = true;
            this.rb_Salida.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Salida.ForeColor = System.Drawing.Color.Black;
            this.rb_Salida.Location = new System.Drawing.Point(15, 49);
            this.rb_Salida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Salida.Name = "rb_Salida";
            this.rb_Salida.Size = new System.Drawing.Size(76, 26);
            this.rb_Salida.TabIndex = 5;
            this.rb_Salida.TabStop = true;
            this.rb_Salida.Tag = "2";
            this.rb_Salida.Text = "Salida";
            this.rb_Salida.UseVisualStyleBackColor = true;
            // 
            // rb_Entrada
            // 
            this.rb_Entrada.AutoSize = true;
            this.rb_Entrada.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Entrada.ForeColor = System.Drawing.Color.Black;
            this.rb_Entrada.Location = new System.Drawing.Point(15, 21);
            this.rb_Entrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Entrada.Name = "rb_Entrada";
            this.rb_Entrada.Size = new System.Drawing.Size(90, 26);
            this.rb_Entrada.TabIndex = 4;
            this.rb_Entrada.TabStop = true;
            this.rb_Entrada.Tag = "1";
            this.rb_Entrada.Text = "Entrada";
            this.rb_Entrada.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(191)))), ((int)(((byte)(178)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = global::Sushine_lnventory.Properties.Resources.Guardar;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(777, 126);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 40);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCostoU
            // 
            this.txtCostoU.Enabled = false;
            this.txtCostoU.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.txtCostoU.Location = new System.Drawing.Point(273, 54);
            this.txtCostoU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoU.Name = "txtCostoU";
            this.txtCostoU.Size = new System.Drawing.Size(215, 29);
            this.txtCostoU.TabIndex = 8;
            this.txtCostoU.Text = "Costo Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(278, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Costo Unitario";
            // 
            // cmb_Empleados
            // 
            this.cmb_Empleados.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cmb_Empleados.FormattingEnabled = true;
            this.cmb_Empleados.Location = new System.Drawing.Point(273, 134);
            this.cmb_Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Empleados.Name = "cmb_Empleados";
            this.cmb_Empleados.Size = new System.Drawing.Size(215, 30);
            this.cmb_Empleados.TabIndex = 12;
            this.cmb_Empleados.Text = "Empleados";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.txtCantidad.Location = new System.Drawing.Point(28, 134);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 29);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(278, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // cmb_Productos
            // 
            this.cmb_Productos.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Productos.ForeColor = System.Drawing.Color.Gray;
            this.cmb_Productos.FormattingEnabled = true;
            this.cmb_Productos.Location = new System.Drawing.Point(28, 54);
            this.cmb_Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Productos.Name = "cmb_Productos";
            this.cmb_Productos.Size = new System.Drawing.Size(205, 30);
            this.cmb_Productos.TabIndex = 10;
            this.cmb_Productos.Text = "Producto";
            this.cmb_Productos.SelectedIndexChanged += new System.EventHandler(this.cmb_Productos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDecargar);
            this.groupBox1.Controls.Add(this.cmbFEmp2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbFProd2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.groupBox1.Location = new System.Drawing.Point(421, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(532, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros y Descargas";
            // 
            // btnDecargar
            // 
            this.btnDecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecargar.Image = global::Sushine_lnventory.Properties.Resources.DescargarC;
            this.btnDecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecargar.Location = new System.Drawing.Point(391, 36);
            this.btnDecargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecargar.Name = "btnDecargar";
            this.btnDecargar.Size = new System.Drawing.Size(135, 39);
            this.btnDecargar.TabIndex = 2;
            this.btnDecargar.Text = "Descargar";
            this.btnDecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecargar.UseVisualStyleBackColor = true;
            this.btnDecargar.Click += new System.EventHandler(this.btnDecargar_Click);
            // 
            // cmbFEmp2
            // 
            this.cmbFEmp2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFEmp2.ForeColor = System.Drawing.Color.Gray;
            this.cmbFEmp2.FormattingEnabled = true;
            this.cmbFEmp2.Location = new System.Drawing.Point(190, 44);
            this.cmbFEmp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFEmp2.Name = "cmbFEmp2";
            this.cmbFEmp2.Size = new System.Drawing.Size(156, 30);
            this.cmbFEmp2.TabIndex = 8;
            this.cmbFEmp2.Text = "Empleados";
            this.cmbFEmp2.SelectedIndexChanged += new System.EventHandler(this.cmbFEmp2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(187, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Empleado";
            // 
            // cmbFProd2
            // 
            this.cmbFProd2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFProd2.ForeColor = System.Drawing.Color.Gray;
            this.cmbFProd2.FormattingEnabled = true;
            this.cmbFProd2.Location = new System.Drawing.Point(14, 44);
            this.cmbFProd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFProd2.Name = "cmbFProd2";
            this.cmbFProd2.Size = new System.Drawing.Size(157, 30);
            this.cmbFProd2.TabIndex = 4;
            this.cmbFProd2.Text = "Producto";
            this.cmbFProd2.SelectedIndexChanged += new System.EventHandler(this.cmbFProd2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Productos";
            // 
            // dGV_Movimientos
            // 
            this.dGV_Movimientos.AllowUserToAddRows = false;
            this.dGV_Movimientos.AllowUserToDeleteRows = false;
            this.dGV_Movimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Movimientos.EnableHeadersVisualStyles = false;
            this.dGV_Movimientos.Location = new System.Drawing.Point(28, 316);
            this.dGV_Movimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Movimientos.Name = "dGV_Movimientos";
            this.dGV_Movimientos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(191)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Movimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Movimientos.RowHeadersVisible = false;
            this.dGV_Movimientos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(191)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dGV_Movimientos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Movimientos.RowTemplate.Height = 28;
            this.dGV_Movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Movimientos.Size = new System.Drawing.Size(925, 223);
            this.dGV_Movimientos.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(72, 269);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(313, 22);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.Text = "Buscar...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Sushine_lnventory.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(27, 263);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 30);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frm_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 549);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dGV_Movimientos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_Movimientos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Movimientos";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.frm_Movimientos_Load);
            this.grpBox_Movimientos.ResumeLayout(false);
            this.grpBox_Movimientos.PerformLayout();
            this.gb_TMov.ResumeLayout(false);
            this.gb_TMov.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Movimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Movimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Empleados;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Productos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDecargar;
        private System.Windows.Forms.ComboBox cmbFEmp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFProd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGV_Movimientos;
        private System.Windows.Forms.RadioButton rb_Entrada;
        private System.Windows.Forms.RadioButton rb_Salida;
        private System.Windows.Forms.TextBox txtCostoU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gb_TMov;
        private System.Windows.Forms.PictureBox btnBuscar;
    }
}