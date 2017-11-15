namespace Almacenes_Paul_Inventario
{
    partial class VentasCRUD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbDatosProd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgVenta = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.pic_RegLlenarD = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TelfVen = new System.Windows.Forms.TextBox();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_DirecVen = new System.Windows.Forms.TextBox();
            this.txt_CIVen = new System.Windows.Forms.TextBox();
            this.txt_CliVen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbFormaPagos = new System.Windows.Forms.GroupBox();
            this.check_Contado = new System.Windows.Forms.CheckBox();
            this.check_Credito = new System.Windows.Forms.CheckBox();
            this.grbCalculos = new System.Windows.Forms.GroupBox();
            this.cmDescuento = new System.Windows.Forms.ComboBox();
            this.rndNo = new System.Windows.Forms.RadioButton();
            this.rndSi = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdSi = new System.Windows.Forms.RadioButton();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_IvaCatorce = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlFunciones = new System.Windows.Forms.Panel();
            this.btn_GuardarVenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbDatosProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenta)).BeginInit();
            this.grbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RegLlenarD)).BeginInit();
            this.grbFormaPagos.SuspendLayout();
            this.grbCalculos.SuspendLayout();
            this.pnlFunciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grbDatosProd);
            this.groupBox1.Controls.Add(this.grbDatosCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(999, 496);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // grbDatosProd
            // 
            this.grbDatosProd.Controls.Add(this.label2);
            this.grbDatosProd.Controls.Add(this.dvgVenta);
            this.grbDatosProd.Controls.Add(this.label1);
            this.grbDatosProd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosProd.Location = new System.Drawing.Point(21, 196);
            this.grbDatosProd.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosProd.Name = "grbDatosProd";
            this.grbDatosProd.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosProd.Size = new System.Drawing.Size(949, 293);
            this.grbDatosProd.TabIndex = 3;
            this.grbDatosProd.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 42);
            this.label2.TabIndex = 22;
            // 
            // dvgVenta
            // 
            this.dvgVenta.AllowUserToAddRows = false;
            this.dvgVenta.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dvgVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_cantidad,
            this.col_descripcion,
            this.col_precioUni,
            this.col_total});
            this.dvgVenta.Location = new System.Drawing.Point(75, 32);
            this.dvgVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dvgVenta.Name = "dvgVenta";
            this.dvgVenta.ReadOnly = true;
            this.dvgVenta.Size = new System.Drawing.Size(852, 254);
            this.dvgVenta.TabIndex = 0;
            // 
            // col_codigo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.col_codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            this.col_codigo.Width = 70;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "Cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            this.col_cantidad.Width = 70;
            // 
            // col_descripcion
            // 
            this.col_descripcion.HeaderText = "Descripción";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.ReadOnly = true;
            this.col_descripcion.Width = 235;
            // 
            // col_precioUni
            // 
            this.col_precioUni.HeaderText = "Precio Unit.";
            this.col_precioUni.Name = "col_precioUni";
            this.col_precioUni.ReadOnly = true;
            this.col_precioUni.Width = 110;
            // 
            // col_total
            // 
            this.col_total.HeaderText = "Total";
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 110;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 42);
            this.label1.TabIndex = 21;
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.pic_RegLlenarD);
            this.grbDatosCliente.Controls.Add(this.label9);
            this.grbDatosCliente.Controls.Add(this.txt_TelfVen);
            this.grbDatosCliente.Controls.Add(this.txt_Fecha);
            this.grbDatosCliente.Controls.Add(this.txt_DirecVen);
            this.grbDatosCliente.Controls.Add(this.txt_CIVen);
            this.grbDatosCliente.Controls.Add(this.txt_CliVen);
            this.grbDatosCliente.Controls.Add(this.label8);
            this.grbDatosCliente.Controls.Add(this.label7);
            this.grbDatosCliente.Controls.Add(this.label6);
            this.grbDatosCliente.Controls.Add(this.label5);
            this.grbDatosCliente.Controls.Add(this.label3);
            this.grbDatosCliente.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCliente.Location = new System.Drawing.Point(21, 21);
            this.grbDatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosCliente.Size = new System.Drawing.Size(949, 164);
            this.grbDatosCliente.TabIndex = 2;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del cliente";
            // 
            // pic_RegLlenarD
            // 
            this.pic_RegLlenarD.BackColor = System.Drawing.Color.Beige;
            this.pic_RegLlenarD.Location = new System.Drawing.Point(817, 73);
            this.pic_RegLlenarD.Margin = new System.Windows.Forms.Padding(4);
            this.pic_RegLlenarD.Name = "pic_RegLlenarD";
            this.pic_RegLlenarD.Size = new System.Drawing.Size(99, 79);
            this.pic_RegLlenarD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_RegLlenarD.TabIndex = 19;
            this.pic_RegLlenarD.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Beige;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(805, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 53);
            this.label9.TabIndex = 20;
            this.label9.Text = "Llenar datos del cliente";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TelfVen
            // 
            this.txt_TelfVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelfVen.Location = new System.Drawing.Point(464, 73);
            this.txt_TelfVen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TelfVen.Name = "txt_TelfVen";
            this.txt_TelfVen.ReadOnly = true;
            this.txt_TelfVen.Size = new System.Drawing.Size(273, 28);
            this.txt_TelfVen.TabIndex = 9;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.Location = new System.Drawing.Point(464, 31);
            this.txt_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(273, 28);
            this.txt_Fecha.TabIndex = 8;
            // 
            // txt_DirecVen
            // 
            this.txt_DirecVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DirecVen.Location = new System.Drawing.Point(103, 116);
            this.txt_DirecVen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DirecVen.Name = "txt_DirecVen";
            this.txt_DirecVen.ReadOnly = true;
            this.txt_DirecVen.Size = new System.Drawing.Size(635, 28);
            this.txt_DirecVen.TabIndex = 7;
            // 
            // txt_CIVen
            // 
            this.txt_CIVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CIVen.Location = new System.Drawing.Point(104, 73);
            this.txt_CIVen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CIVen.Name = "txt_CIVen";
            this.txt_CIVen.ReadOnly = true;
            this.txt_CIVen.Size = new System.Drawing.Size(273, 28);
            this.txt_CIVen.TabIndex = 6;
            // 
            // txt_CliVen
            // 
            this.txt_CliVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CliVen.Location = new System.Drawing.Point(104, 31);
            this.txt_CliVen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CliVen.Name = "txt_CliVen";
            this.txt_CliVen.ReadOnly = true;
            this.txt_CliVen.Size = new System.Drawing.Size(273, 28);
            this.txt_CliVen.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(384, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "RUC/C.I.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente:";
            // 
            // grbFormaPagos
            // 
            this.grbFormaPagos.BackColor = System.Drawing.Color.Transparent;
            this.grbFormaPagos.Controls.Add(this.check_Contado);
            this.grbFormaPagos.Controls.Add(this.check_Credito);
            this.grbFormaPagos.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFormaPagos.Location = new System.Drawing.Point(1030, 382);
            this.grbFormaPagos.Margin = new System.Windows.Forms.Padding(4);
            this.grbFormaPagos.Name = "grbFormaPagos";
            this.grbFormaPagos.Padding = new System.Windows.Forms.Padding(4);
            this.grbFormaPagos.Size = new System.Drawing.Size(361, 106);
            this.grbFormaPagos.TabIndex = 30;
            this.grbFormaPagos.TabStop = false;
            this.grbFormaPagos.Text = "Forma de pago";
            // 
            // check_Contado
            // 
            this.check_Contado.AutoSize = true;
            this.check_Contado.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Contado.Location = new System.Drawing.Point(47, 46);
            this.check_Contado.Margin = new System.Windows.Forms.Padding(4);
            this.check_Contado.Name = "check_Contado";
            this.check_Contado.Size = new System.Drawing.Size(97, 27);
            this.check_Contado.TabIndex = 1;
            this.check_Contado.Text = "Contado";
            this.check_Contado.UseVisualStyleBackColor = true;
            // 
            // check_Credito
            // 
            this.check_Credito.AutoSize = true;
            this.check_Credito.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Credito.Location = new System.Drawing.Point(216, 46);
            this.check_Credito.Margin = new System.Windows.Forms.Padding(4);
            this.check_Credito.Name = "check_Credito";
            this.check_Credito.Size = new System.Drawing.Size(89, 27);
            this.check_Credito.TabIndex = 0;
            this.check_Credito.Text = "Crédito";
            this.check_Credito.UseVisualStyleBackColor = true;
            // 
            // grbCalculos
            // 
            this.grbCalculos.BackColor = System.Drawing.Color.Transparent;
            this.grbCalculos.Controls.Add(this.cmDescuento);
            this.grbCalculos.Controls.Add(this.rndNo);
            this.grbCalculos.Controls.Add(this.rndSi);
            this.grbCalculos.Controls.Add(this.label14);
            this.grbCalculos.Controls.Add(this.rdNo);
            this.grbCalculos.Controls.Add(this.rdSi);
            this.grbCalculos.Controls.Add(this.txt_Total);
            this.grbCalculos.Controls.Add(this.txt_IvaCatorce);
            this.grbCalculos.Controls.Add(this.label12);
            this.grbCalculos.Controls.Add(this.label13);
            this.grbCalculos.Controls.Add(this.txt_SubTotal);
            this.grbCalculos.Controls.Add(this.label11);
            this.grbCalculos.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCalculos.Location = new System.Drawing.Point(1030, 13);
            this.grbCalculos.Margin = new System.Windows.Forms.Padding(4);
            this.grbCalculos.Name = "grbCalculos";
            this.grbCalculos.Padding = new System.Windows.Forms.Padding(4);
            this.grbCalculos.Size = new System.Drawing.Size(361, 362);
            this.grbCalculos.TabIndex = 29;
            this.grbCalculos.TabStop = false;
            this.grbCalculos.Text = "Cálculos";
            // 
            // cmDescuento
            // 
            this.cmDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmDescuento.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.cmDescuento.FormattingEnabled = true;
            this.cmDescuento.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.cmDescuento.Location = new System.Drawing.Point(165, 218);
            this.cmDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.cmDescuento.Name = "cmDescuento";
            this.cmDescuento.Size = new System.Drawing.Size(145, 30);
            this.cmDescuento.TabIndex = 25;
            // 
            // rndNo
            // 
            this.rndNo.AutoSize = true;
            this.rndNo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndNo.Location = new System.Drawing.Point(165, 91);
            this.rndNo.Margin = new System.Windows.Forms.Padding(4);
            this.rndNo.Name = "rndNo";
            this.rndNo.Size = new System.Drawing.Size(54, 27);
            this.rndNo.TabIndex = 24;
            this.rndNo.TabStop = true;
            this.rndNo.Text = "No";
            this.rndNo.UseVisualStyleBackColor = true;
            // 
            // rndSi
            // 
            this.rndSi.AutoSize = true;
            this.rndSi.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndSi.Location = new System.Drawing.Point(267, 91);
            this.rndSi.Margin = new System.Windows.Forms.Padding(4);
            this.rndSi.Name = "rndSi";
            this.rndSi.Size = new System.Drawing.Size(46, 27);
            this.rndSi.TabIndex = 23;
            this.rndSi.TabStop = true;
            this.rndSi.Text = "Si";
            this.rndSi.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 183);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "Descuento:";
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNo.Location = new System.Drawing.Point(164, 183);
            this.rdNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(54, 27);
            this.rdNo.TabIndex = 18;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "No";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // rdSi
            // 
            this.rdSi.AutoSize = true;
            this.rdSi.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSi.Location = new System.Drawing.Point(265, 183);
            this.rdSi.Margin = new System.Windows.Forms.Padding(4);
            this.rdSi.Name = "rdSi";
            this.rdSi.Size = new System.Drawing.Size(46, 27);
            this.rdSi.TabIndex = 17;
            this.rdSi.TabStop = true;
            this.rdSi.Text = "Si";
            this.rdSi.UseVisualStyleBackColor = true;
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_Total.Location = new System.Drawing.Point(165, 308);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(148, 40);
            this.txt_Total.TabIndex = 14;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_IvaCatorce
            // 
            this.txt_IvaCatorce.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IvaCatorce.Location = new System.Drawing.Point(164, 133);
            this.txt_IvaCatorce.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IvaCatorce.Name = "txt_IvaCatorce";
            this.txt_IvaCatorce.ReadOnly = true;
            this.txt_IvaCatorce.Size = new System.Drawing.Size(148, 28);
            this.txt_IvaCatorce.TabIndex = 13;
            this.txt_IvaCatorce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 315);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "IVA 14%";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.Location = new System.Drawing.Point(163, 42);
            this.txt_SubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(148, 28);
            this.txt_SubTotal.TabIndex = 9;
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Subtotal";
            // 
            // pnlFunciones
            // 
            this.pnlFunciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlFunciones.Controls.Add(this.btn_GuardarVenta);
            this.pnlFunciones.Location = new System.Drawing.Point(1399, 36);
            this.pnlFunciones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFunciones.Name = "pnlFunciones";
            this.pnlFunciones.Size = new System.Drawing.Size(238, 459);
            this.pnlFunciones.TabIndex = 31;
            // 
            // btn_GuardarVenta
            // 
            this.btn_GuardarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_GuardarVenta.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_GuardarVenta.Location = new System.Drawing.Point(61, 57);
            this.btn_GuardarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarVenta.Name = "btn_GuardarVenta";
            this.btn_GuardarVenta.Size = new System.Drawing.Size(157, 126);
            this.btn_GuardarVenta.TabIndex = 0;
            this.btn_GuardarVenta.Text = "Guardar";
            this.btn_GuardarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_GuardarVenta.UseVisualStyleBackColor = true;
            // 
            // VentasCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 515);
            this.Controls.Add(this.pnlFunciones);
            this.Controls.Add(this.grbFormaPagos);
            this.Controls.Add(this.grbCalculos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentasCRUD";
            this.Text = "CRUDVentas";
            this.Load += new System.EventHandler(this.VentasCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbDatosProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenta)).EndInit();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RegLlenarD)).EndInit();
            this.grbFormaPagos.ResumeLayout(false);
            this.grbFormaPagos.PerformLayout();
            this.grbCalculos.ResumeLayout(false);
            this.grbCalculos.PerformLayout();
            this.pnlFunciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbDatosProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.PictureBox pic_RegLlenarD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TelfVen;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.TextBox txt_DirecVen;
        private System.Windows.Forms.TextBox txt_CIVen;
        private System.Windows.Forms.TextBox txt_CliVen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbFormaPagos;
        private System.Windows.Forms.CheckBox check_Contado;
        private System.Windows.Forms.CheckBox check_Credito;
        private System.Windows.Forms.GroupBox grbCalculos;
        private System.Windows.Forms.ComboBox cmDescuento;
        private System.Windows.Forms.RadioButton rndNo;
        private System.Windows.Forms.RadioButton rndSi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.RadioButton rdSi;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_IvaCatorce;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlFunciones;
        private System.Windows.Forms.Button btn_GuardarVenta;
    }
}