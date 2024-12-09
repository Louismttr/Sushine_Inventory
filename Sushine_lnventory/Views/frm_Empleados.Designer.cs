namespace Sushine_lnventory.Views
{
    partial class frm_Empleados
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
            this.grpBox_Movimientos = new System.Windows.Forms.GroupBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.mtxtFechaNa = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNIdenti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGV_Empleados = new System.Windows.Forms.DataGridView();
            this.grpBox_Movimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_Movimientos
            // 
            this.grpBox_Movimientos.Controls.Add(this.cmbPuesto);
            this.grpBox_Movimientos.Controls.Add(this.cmbSexo);
            this.grpBox_Movimientos.Controls.Add(this.mtxtFechaNa);
            this.grpBox_Movimientos.Controls.Add(this.label9);
            this.grpBox_Movimientos.Controls.Add(this.txtCelular);
            this.grpBox_Movimientos.Controls.Add(this.label6);
            this.grpBox_Movimientos.Controls.Add(this.label7);
            this.grpBox_Movimientos.Controls.Add(this.label8);
            this.grpBox_Movimientos.Controls.Add(this.txtNIdenti);
            this.grpBox_Movimientos.Controls.Add(this.label5);
            this.grpBox_Movimientos.Controls.Add(this.txtSA);
            this.grpBox_Movimientos.Controls.Add(this.txtPA);
            this.grpBox_Movimientos.Controls.Add(this.txtSN);
            this.grpBox_Movimientos.Controls.Add(this.txtPN);
            this.grpBox_Movimientos.Controls.Add(this.label4);
            this.grpBox_Movimientos.Controls.Add(this.label3);
            this.grpBox_Movimientos.Controls.Add(this.label2);
            this.grpBox_Movimientos.Controls.Add(this.label1);
            this.grpBox_Movimientos.Controls.Add(this.btnRegistrar);
            this.grpBox_Movimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Movimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(141)))), ((int)(((byte)(133)))));
            this.grpBox_Movimientos.Location = new System.Drawing.Point(25, 17);
            this.grpBox_Movimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Movimientos.Name = "grpBox_Movimientos";
            this.grpBox_Movimientos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Movimientos.Size = new System.Drawing.Size(927, 249);
            this.grpBox_Movimientos.TabIndex = 1;
            this.grpBox_Movimientos.TabStop = false;
            this.grpBox_Movimientos.Text = "Datos de Empleado";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(435, 131);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(161, 33);
            this.cmbPuesto.TabIndex = 25;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(220, 131);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(165, 33);
            this.cmbSexo.TabIndex = 24;
            // 
            // mtxtFechaNa
            // 
            this.mtxtFechaNa.Location = new System.Drawing.Point(25, 206);
            this.mtxtFechaNa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtFechaNa.Mask = "00/00/0000";
            this.mtxtFechaNa.Name = "mtxtFechaNa";
            this.mtxtFechaNa.Size = new System.Drawing.Size(166, 30);
            this.mtxtFechaNa.TabIndex = 23;
            this.mtxtFechaNa.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha de Contratación";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(628, 136);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(162, 27);
            this.txtCelular.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(625, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(431, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Puesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(219, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sexo";
            // 
            // txtNIdenti
            // 
            this.txtNIdenti.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIdenti.Location = new System.Drawing.Point(28, 136);
            this.txtNIdenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNIdenti.Name = "txtNIdenti";
            this.txtNIdenti.Size = new System.Drawing.Size(162, 27);
            this.txtNIdenti.TabIndex = 15;
            this.txtNIdenti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIdenti_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "N° de Identificación";
            // 
            // txtSA
            // 
            this.txtSA.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSA.Location = new System.Drawing.Point(628, 64);
            this.txtSA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(162, 27);
            this.txtSA.TabIndex = 13;
            this.txtSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSA_KeyPress);
            // 
            // txtPA
            // 
            this.txtPA.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPA.Location = new System.Drawing.Point(435, 64);
            this.txtPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(162, 27);
            this.txtPA.TabIndex = 12;
            this.txtPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPA_KeyPress);
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(222, 64);
            this.txtSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(162, 27);
            this.txtSN.TabIndex = 11;
            this.txtSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSN_KeyPress);
            // 
            // txtPN
            // 
            this.txtPN.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPN.Location = new System.Drawing.Point(28, 64);
            this.txtPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(162, 27);
            this.txtPN.TabIndex = 10;
            this.txtPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(625, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(431, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(219, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Segundo Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primer Nombre";
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
            this.btnRegistrar.Location = new System.Drawing.Point(787, 201);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Buscar...";
            // 
            // dGV_Empleados
            // 
            this.dGV_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Empleados.Location = new System.Drawing.Point(29, 327);
            this.dGV_Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_Empleados.Name = "dGV_Empleados";
            this.dGV_Empleados.RowHeadersWidth = 62;
            this.dGV_Empleados.RowTemplate.Height = 28;
            this.dGV_Empleados.Size = new System.Drawing.Size(922, 207);
            this.dGV_Empleados.TabIndex = 3;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.dGV_Empleados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpBox_Movimientos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Empleados";
            this.Text = "frm_Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            this.grpBox_Movimientos.ResumeLayout(false);
            this.grpBox_Movimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Movimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtNIdenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtFechaNa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.DataGridView dGV_Empleados;
    }
}