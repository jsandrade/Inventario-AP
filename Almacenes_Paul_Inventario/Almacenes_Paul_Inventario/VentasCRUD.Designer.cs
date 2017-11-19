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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelVen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_GuardarVenta = new System.Windows.Forms.Button();
            this.pnlFunciones = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CliVen = new System.Windows.Forms.TextBox();
            this.txt_CIVen = new System.Windows.Forms.TextBox();
            this.grbAñadir = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.txt_TelfVen = new System.Windows.Forms.TextBox();
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DirecVen = new System.Windows.Forms.TextBox();
            this.grbOpciones.SuspendLayout();
            this.pnlFunciones.SuspendLayout();
            this.grbAñadir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbDatosProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenta)).BeginInit();
            this.grbDatosCliente.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.btnRegistrarVenta);
            this.grbOpciones.Controls.Add(this.btnCancelVen);
            this.grbOpciones.Location = new System.Drawing.Point(9, 132);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(161, 100);
            this.grbOpciones.TabIndex = 28;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Venta";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(11, 21);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(132, 28);
            this.btnRegistrarVenta.TabIndex = 25;
            this.btnRegistrarVenta.Text = "REGISTRAR";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click_1);
            // 
            // btnCancelVen
            // 
            this.btnCancelVen.Location = new System.Drawing.Point(11, 60);
            this.btnCancelVen.Name = "btnCancelVen";
            this.btnCancelVen.Size = new System.Drawing.Size(132, 28);
            this.btnCancelVen.TabIndex = 26;
            this.btnCancelVen.Text = "CANCELAR";
            this.btnCancelVen.UseVisualStyleBackColor = true;
            this.btnCancelVen.Click += new System.EventHandler(this.btnCancelVen_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 28);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 28);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "QUITAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarVenta
            // 
            this.btn_GuardarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_GuardarVenta.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_GuardarVenta.Location = new System.Drawing.Point(46, 46);
            this.btn_GuardarVenta.Name = "btn_GuardarVenta";
            this.btn_GuardarVenta.Size = new System.Drawing.Size(118, 102);
            this.btn_GuardarVenta.TabIndex = 0;
            this.btn_GuardarVenta.Text = "Guardar";
            this.btn_GuardarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_GuardarVenta.UseVisualStyleBackColor = true;
            // 
            // pnlFunciones
            // 
            this.pnlFunciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlFunciones.Controls.Add(this.btn_GuardarVenta);
            this.pnlFunciones.Location = new System.Drawing.Point(868, 42);
            this.pnlFunciones.Name = "pnlFunciones";
            this.pnlFunciones.Size = new System.Drawing.Size(178, 373);
            this.pnlFunciones.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "C.I.:";
            // 
            // txt_CliVen
            // 
            this.txt_CliVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CliVen.Location = new System.Drawing.Point(91, 19);
            this.txt_CliVen.Name = "txt_CliVen";
            this.txt_CliVen.ReadOnly = true;
            this.txt_CliVen.Size = new System.Drawing.Size(353, 24);
            this.txt_CliVen.TabIndex = 5;
            // 
            // txt_CIVen
            // 
            this.txt_CIVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CIVen.Location = new System.Drawing.Point(90, 34);
            this.txt_CIVen.Name = "txt_CIVen";
            this.txt_CIVen.Size = new System.Drawing.Size(235, 24);
            this.txt_CIVen.TabIndex = 6;
            // 
            // grbAñadir
            // 
            this.grbAñadir.Controls.Add(this.btnAdd);
            this.grbAñadir.Controls.Add(this.btnDelete);
            this.grbAñadir.Location = new System.Drawing.Point(9, 26);
            this.grbAñadir.Name = "grbAñadir";
            this.grbAñadir.Size = new System.Drawing.Size(160, 100);
            this.grbAñadir.TabIndex = 27;
            this.grbAñadir.TabStop = false;
            this.grbAñadir.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente:";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.Location = new System.Drawing.Point(528, 58);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(211, 24);
            this.txt_Fecha.TabIndex = 8;
            // 
            // txt_TelfVen
            // 
            this.txt_TelfVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelfVen.Location = new System.Drawing.Point(528, 20);
            this.txt_TelfVen.Name = "txt_TelfVen";
            this.txt_TelfVen.ReadOnly = true;
            this.txt_TelfVen.Size = new System.Drawing.Size(211, 24);
            this.txt_TelfVen.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grbDatosProd);
            this.groupBox1.Controls.Add(this.grbDatosCliente);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 453);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // grbDatosProd
            // 
            this.grbDatosProd.Controls.Add(this.grbOpciones);
            this.grbDatosProd.Controls.Add(this.grbAñadir);
            this.grbDatosProd.Controls.Add(this.label2);
            this.grbDatosProd.Controls.Add(this.dvgVenta);
            this.grbDatosProd.Controls.Add(this.label1);
            this.grbDatosProd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosProd.Location = new System.Drawing.Point(16, 205);
            this.grbDatosProd.Name = "grbDatosProd";
            this.grbDatosProd.Size = new System.Drawing.Size(831, 238);
            this.grbDatosProd.TabIndex = 3;
            this.grbDatosProd.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 44);
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
            this.dvgVenta.Location = new System.Drawing.Point(175, 26);
            this.dvgVenta.Name = "dvgVenta";
            this.dvgVenta.ReadOnly = true;
            this.dvgVenta.Size = new System.Drawing.Size(639, 206);
            this.dvgVenta.TabIndex = 0;
            // 
            // col_codigo
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.col_codigo.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 44);
            this.label1.TabIndex = 21;
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.btnBuscarCliente);
            this.grbDatosCliente.Controls.Add(this.grbCliente);
            this.grbDatosCliente.Controls.Add(this.label5);
            this.grbDatosCliente.Controls.Add(this.txt_CIVen);
            this.grbDatosCliente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCliente.Location = new System.Drawing.Point(16, 17);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(831, 182);
            this.grbDatosCliente.TabIndex = 2;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(347, 29);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(179, 33);
            this.btnBuscarCliente.TabIndex = 11;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.label3);
            this.grbCliente.Controls.Add(this.txt_Fecha);
            this.grbCliente.Controls.Add(this.txt_CliVen);
            this.grbCliente.Controls.Add(this.txt_TelfVen);
            this.grbCliente.Controls.Add(this.label7);
            this.grbCliente.Controls.Add(this.label6);
            this.grbCliente.Controls.Add(this.label8);
            this.grbCliente.Controls.Add(this.txt_DirecVen);
            this.grbCliente.Location = new System.Drawing.Point(9, 76);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(816, 100);
            this.grbCliente.TabIndex = 10;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Teléfono:";
            // 
            // txt_DirecVen
            // 
            this.txt_DirecVen.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DirecVen.Location = new System.Drawing.Point(91, 54);
            this.txt_DirecVen.Multiline = true;
            this.txt_DirecVen.Name = "txt_DirecVen";
            this.txt_DirecVen.ReadOnly = true;
            this.txt_DirecVen.Size = new System.Drawing.Size(353, 28);
            this.txt_DirecVen.TabIndex = 7;
            // 
            // VentasCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 500);
            this.Controls.Add(this.pnlFunciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentasCRUD";
            this.Text = "CRUDVentas";
            this.Load += new System.EventHandler(this.VentasCRUD_Load);
            this.grbOpciones.ResumeLayout(false);
            this.pnlFunciones.ResumeLayout(false);
            this.grbAñadir.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbDatosProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenta)).EndInit();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnCancelVen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_GuardarVenta;
        private System.Windows.Forms.Panel pnlFunciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CliVen;
        private System.Windows.Forms.TextBox txt_CIVen;
        private System.Windows.Forms.GroupBox grbAñadir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.TextBox txt_TelfVen;
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
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DirecVen;
    }
}