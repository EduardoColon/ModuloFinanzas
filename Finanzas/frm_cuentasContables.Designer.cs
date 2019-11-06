namespace Finanzas
{
    partial class frm_cuentasContables
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
            this.dgv_cuentasContables = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_descripcionCuenta = new System.Windows.Forms.RichTextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_nombreCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipoCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodigoCuenta = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuentasContables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cuentasContables
            // 
            this.dgv_cuentasContables.AllowUserToAddRows = false;
            this.dgv_cuentasContables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuentasContables.Location = new System.Drawing.Point(54, 395);
            this.dgv_cuentasContables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cuentasContables.Name = "dgv_cuentasContables";
            this.dgv_cuentasContables.ReadOnly = true;
            this.dgv_cuentasContables.Size = new System.Drawing.Size(984, 244);
            this.dgv_cuentasContables.TabIndex = 6;
            this.dgv_cuentasContables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cuentasContables_CellClick_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(812, 11);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 43);
            this.btn_salir.TabIndex = 32;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // txt_descripcionCuenta
            // 
            this.txt_descripcionCuenta.Location = new System.Drawing.Point(464, 213);
            this.txt_descripcionCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descripcionCuenta.Name = "txt_descripcionCuenta";
            this.txt_descripcionCuenta.Size = new System.Drawing.Size(335, 124);
            this.txt_descripcionCuenta.TabIndex = 31;
            this.txt_descripcionCuenta.Text = "";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(464, 350);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(132, 23);
            this.txt_estado.TabIndex = 30;
            // 
            // txt_nombreCuenta
            // 
            this.txt_nombreCuenta.Location = new System.Drawing.Point(464, 169);
            this.txt_nombreCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombreCuenta.Name = "txt_nombreCuenta";
            this.txt_nombreCuenta.Size = new System.Drawing.Size(256, 23);
            this.txt_nombreCuenta.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Descripcion de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre de Cuenta";
            // 
            // cbo_tipoCuenta
            // 
            this.cbo_tipoCuenta.FormattingEnabled = true;
            this.cbo_tipoCuenta.Location = new System.Drawing.Point(464, 82);
            this.cbo_tipoCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_tipoCuenta.Name = "cbo_tipoCuenta";
            this.cbo_tipoCuenta.Size = new System.Drawing.Size(256, 25);
            this.cbo_tipoCuenta.TabIndex = 25;
            this.cbo_tipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cbo_tipoCuenta_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo de Cuenta";
            // 
            // txt_CodigoCuenta
            // 
            this.txt_CodigoCuenta.Location = new System.Drawing.Point(464, 122);
            this.txt_CodigoCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodigoCuenta.Name = "txt_CodigoCuenta";
            this.txt_CodigoCuenta.Size = new System.Drawing.Size(256, 23);
            this.txt_CodigoCuenta.TabIndex = 22;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(529, 11);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(120, 43);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(145, 11);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(109, 43);
            this.btn_ingresar.TabIndex = 17;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(669, 11);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(115, 43);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(275, 11);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(109, 43);
            this.btn_modificar.TabIndex = 18;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(407, 11);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(103, 43);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // frm_cuentasContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 652);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_descripcionCuenta);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_nombreCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_tipoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CodigoCuenta);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_cuentasContables);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_cuentasContables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas Contables";
            this.Load += new System.EventHandler(this.frm_cuentasContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuentasContables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cuentasContables;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.RichTextBox txt_descripcionCuenta;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_nombreCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipoCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodigoCuenta;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
    }
}