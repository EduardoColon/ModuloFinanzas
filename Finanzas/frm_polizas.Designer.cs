namespace Finanzas
{
    partial class frm_polizas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_tipoPoliza = new System.Windows.Forms.ComboBox();
            this.btn_IngresoLibroDiario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.No_Poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_consulta);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbo_tipoPoliza);
            this.groupBox2.Controls.Add(this.btn_IngresoLibroDiario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtp_fechaFinal);
            this.groupBox2.Controls.Add(this.dtp_fechaInicial);
            this.groupBox2.Controls.Add(this.dgv_polizas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1304, 643);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de Polizas";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(1017, 65);
            this.btn_consulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(112, 35);
            this.btn_consulta.TabIndex = 9;
            this.btn_consulta.Text = "consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(831, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tipo Poliza";
            // 
            // cbo_tipoPoliza
            // 
            this.cbo_tipoPoliza.FormattingEnabled = true;
            this.cbo_tipoPoliza.Location = new System.Drawing.Point(792, 60);
            this.cbo_tipoPoliza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_tipoPoliza.Name = "cbo_tipoPoliza";
            this.cbo_tipoPoliza.Size = new System.Drawing.Size(180, 30);
            this.cbo_tipoPoliza.TabIndex = 7;
            // 
            // btn_IngresoLibroDiario
            // 
            this.btn_IngresoLibroDiario.Location = new System.Drawing.Point(1035, 592);
            this.btn_IngresoLibroDiario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_IngresoLibroDiario.Name = "btn_IngresoLibroDiario";
            this.btn_IngresoLibroDiario.Size = new System.Drawing.Size(234, 42);
            this.btn_IngresoLibroDiario.TabIndex = 6;
            this.btn_IngresoLibroDiario.Text = "Ingresar a Libro Diario";
            this.btn_IngresoLibroDiario.UseVisualStyleBackColor = true;
            this.btn_IngresoLibroDiario.Click += new System.EventHandler(this.btn_IngresoLibroDiario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Inicio";
            // 
            // dtp_fechaFinal
            // 
            this.dtp_fechaFinal.Location = new System.Drawing.Point(464, 65);
            this.dtp_fechaFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_fechaFinal.Name = "dtp_fechaFinal";
            this.dtp_fechaFinal.Size = new System.Drawing.Size(301, 28);
            this.dtp_fechaFinal.TabIndex = 2;
            // 
            // dtp_fechaInicial
            // 
            this.dtp_fechaInicial.Location = new System.Drawing.Point(110, 65);
            this.dtp_fechaInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_fechaInicial.Name = "dtp_fechaInicial";
            this.dtp_fechaInicial.Size = new System.Drawing.Size(298, 28);
            this.dtp_fechaInicial.TabIndex = 1;
            // 
            // dgv_polizas
            // 
            this.dgv_polizas.AllowUserToAddRows = false;
            this.dgv_polizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_Poliza,
            this.Cuenta_Contable,
            this.Debe,
            this.Haber});
            this.dgv_polizas.Location = new System.Drawing.Point(34, 123);
            this.dgv_polizas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.RowHeadersWidth = 62;
            this.dgv_polizas.Size = new System.Drawing.Size(1234, 460);
            this.dgv_polizas.TabIndex = 0;
            // 
            // No_Poliza
            // 
            this.No_Poliza.HeaderText = "No. Poliza";
            this.No_Poliza.MinimumWidth = 8;
            this.No_Poliza.Name = "No_Poliza";
            // 
            // Cuenta_Contable
            // 
            this.Cuenta_Contable.HeaderText = "Cuenta Contable";
            this.Cuenta_Contable.MinimumWidth = 8;
            this.Cuenta_Contable.Name = "Cuenta_Contable";
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.MinimumWidth = 8;
            this.Debe.Name = "Debe";
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.MinimumWidth = 8;
            this.Haber.Name = "Haber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESO DE POLIZAS A LIBRO DIARIO";
            // 
            // frm_polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 791);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_polizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Polizas";
            this.Load += new System.EventHandler(this.frm_polizas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fechaFinal;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicial;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.Button btn_IngresoLibroDiario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_tipoPoliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.Button btn_consulta;
    }
}