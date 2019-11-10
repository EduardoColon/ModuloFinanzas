namespace Finanzas
{
    partial class frm_ActualizacionPolizas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_TipoPoliza = new System.Windows.Forms.ComboBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.No_Poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualizacionpolizas = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_noPoliza = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_TipoPoliza);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtp_fechaFinal);
            this.groupBox2.Controls.Add(this.dtp_fechaInicial);
            this.groupBox2.Controls.Add(this.dgv_polizas);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 418);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta Libro Diario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione";
            // 
            // cbo_TipoPoliza
            // 
            this.cbo_TipoPoliza.FormattingEnabled = true;
            this.cbo_TipoPoliza.Location = new System.Drawing.Point(569, 39);
            this.cbo_TipoPoliza.Name = "cbo_TipoPoliza";
            this.cbo_TipoPoliza.Size = new System.Drawing.Size(121, 25);
            this.cbo_TipoPoliza.TabIndex = 7;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(690, 385);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(156, 27);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar Polizas";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Inicio";
            // 
            // dtp_fechaFinal
            // 
            this.dtp_fechaFinal.Location = new System.Drawing.Point(332, 42);
            this.dtp_fechaFinal.Name = "dtp_fechaFinal";
            this.dtp_fechaFinal.Size = new System.Drawing.Size(202, 22);
            this.dtp_fechaFinal.TabIndex = 2;
            // 
            // dtp_fechaInicial
            // 
            this.dtp_fechaInicial.Location = new System.Drawing.Point(96, 42);
            this.dtp_fechaInicial.Name = "dtp_fechaInicial";
            this.dtp_fechaInicial.Size = new System.Drawing.Size(200, 22);
            this.dtp_fechaInicial.TabIndex = 1;
            // 
            // dgv_polizas
            // 
            this.dgv_polizas.AllowUserToAddRows = false;
            this.dgv_polizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_Poliza,
            this.Tipo_Poliza,
            this.Codigo_Cuenta,
            this.Cuenta_Contable,
            this.Debe,
            this.Haber});
            this.dgv_polizas.Location = new System.Drawing.Point(23, 80);
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.Size = new System.Drawing.Size(823, 299);
            this.dgv_polizas.TabIndex = 0;
            // 
            // No_Poliza
            // 
            this.No_Poliza.HeaderText = "No. Poliza";
            this.No_Poliza.Name = "No_Poliza";
            // 
            // Tipo_Poliza
            // 
            this.Tipo_Poliza.HeaderText = "Tipo Poliza";
            this.Tipo_Poliza.Name = "Tipo_Poliza";
            // 
            // Codigo_Cuenta
            // 
            this.Codigo_Cuenta.HeaderText = "Codigo Cuenta";
            this.Codigo_Cuenta.Name = "Codigo_Cuenta";
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.HeaderText = "Cuenta Contable";
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            // 
            // actualizacionpolizas
            // 
            this.actualizacionpolizas.AutoSize = true;
            this.actualizacionpolizas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizacionpolizas.Location = new System.Drawing.Point(340, 29);
            this.actualizacionpolizas.Name = "actualizacionpolizas";
            this.actualizacionpolizas.Size = new System.Drawing.Size(293, 24);
            this.actualizacionpolizas.TabIndex = 3;
            this.actualizacionpolizas.Text = "ACTUALIZACION DE POLIZAS";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_noPoliza
            // 
            this.txt_noPoliza.Enabled = false;
            this.txt_noPoliza.Location = new System.Drawing.Point(854, 29);
            this.txt_noPoliza.Margin = new System.Windows.Forms.Padding(2);
            this.txt_noPoliza.Name = "txt_noPoliza";
            this.txt_noPoliza.Size = new System.Drawing.Size(68, 20);
            this.txt_noPoliza.TabIndex = 4;
            this.txt_noPoliza.Visible = false;
            // 
            // frm_ActualizacionPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1001, 513);
            this.Controls.Add(this.txt_noPoliza);
            this.Controls.Add(this.actualizacionpolizas);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_ActualizacionPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion de Polizas";
            this.Load += new System.EventHandler(this.frm_ActualizacionPolizas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fechaFinal;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicial;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.Label actualizacionpolizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_TipoPoliza;
        private System.Windows.Forms.TextBox txt_noPoliza;
    }
}