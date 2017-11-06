namespace Almacenes_Paul_Inventario
{
    partial class Login
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
            this.btnLoginIngresar = new System.Windows.Forms.Button();
            this.txtLoginContraseña = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginIngresar
            // 
            this.btnLoginIngresar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginIngresar.Location = new System.Drawing.Point(95, 172);
            this.btnLoginIngresar.Name = "btnLoginIngresar";
            this.btnLoginIngresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoginIngresar.Size = new System.Drawing.Size(103, 44);
            this.btnLoginIngresar.TabIndex = 10;
            this.btnLoginIngresar.Text = "Ingresar";
            this.btnLoginIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoginIngresar.UseVisualStyleBackColor = true;
            this.btnLoginIngresar.Click += new System.EventHandler(this.btnLoginIngresar_Click);
            // 
            // txtLoginContraseña
            // 
            this.txtLoginContraseña.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.txtLoginContraseña.Location = new System.Drawing.Point(160, 114);
            this.txtLoginContraseña.Name = "txtLoginContraseña";
            this.txtLoginContraseña.PasswordChar = '*';
            this.txtLoginContraseña.Size = new System.Drawing.Size(100, 28);
            this.txtLoginContraseña.TabIndex = 9;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLoginUsuario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.txtLoginUsuario.Location = new System.Drawing.Point(160, 67);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(100, 28);
            this.txtLoginUsuario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingreso al Sistema";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoginIngresar);
            this.Controls.Add(this.txtLoginContraseña);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoginIngresar;
        private System.Windows.Forms.TextBox txtLoginContraseña;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}