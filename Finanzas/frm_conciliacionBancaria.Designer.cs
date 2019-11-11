namespace Finanzas
{
    partial class frm_conciliacionBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conciliacionBancaria));
            this.button1 = new System.Windows.Forms.Button();
            this.LblDiferencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvConciliado = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EstadoCuenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_bancos = new System.Windows.Forms.ComboBox();
            this.DtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLibroBancos = new System.Windows.Forms.DataGridView();
            this.BtnAgregarConciliado = new System.Windows.Forms.Button();
            this.BtnRegresarConciliado = new System.Windows.Forms.Button();
            this.CboMonedas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblDebe = new System.Windows.Forms.Label();
            this.LblHaber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdfEstadoCuenta = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibroBancos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfEstadoCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 51);
            this.button1.TabIndex = 27;
            this.button1.Text = "Finalizar conciliacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LblDiferencia
            // 
            this.LblDiferencia.AutoSize = true;
            this.LblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiferencia.Location = new System.Drawing.Point(262, 466);
            this.LblDiferencia.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblDiferencia.Name = "LblDiferencia";
            this.LblDiferencia.Size = new System.Drawing.Size(40, 20);
            this.LblDiferencia.TabIndex = 26;
            this.LblDiferencia.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Saldo pendiente por cuadrar:";
            // 
            // DgvConciliado
            // 
            this.DgvConciliado.AllowUserToAddRows = false;
            this.DgvConciliado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvConciliado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConciliado.Location = new System.Drawing.Point(41, 291);
            this.DgvConciliado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvConciliado.Name = "DgvConciliado";
            this.DgvConciliado.ReadOnly = true;
            this.DgvConciliado.RowHeadersWidth = 62;
            this.DgvConciliado.Size = new System.Drawing.Size(603, 129);
            this.DgvConciliado.TabIndex = 24;
            this.DgvConciliado.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvConciliado_DataBindingComplete);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Movimientos validados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Movimientos libro bancos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Conciliaciones bancarias";
            // 
            // btn_EstadoCuenta
            // 
            this.btn_EstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EstadoCuenta.Location = new System.Drawing.Point(755, 71);
            this.btn_EstadoCuenta.Margin = new System.Windows.Forms.Padding(1);
            this.btn_EstadoCuenta.Name = "btn_EstadoCuenta";
            this.btn_EstadoCuenta.Size = new System.Drawing.Size(218, 35);
            this.btn_EstadoCuenta.TabIndex = 19;
            this.btn_EstadoCuenta.Text = "Abrir estado de cuenta";
            this.btn_EstadoCuenta.UseVisualStyleBackColor = true;
            this.btn_EstadoCuenta.Click += new System.EventHandler(this.Btn_EstadoCuenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mes:";
            // 
            // Cbo_bancos
            // 
            this.Cbo_bancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_bancos.FormattingEnabled = true;
            this.Cbo_bancos.Location = new System.Drawing.Point(98, 53);
            this.Cbo_bancos.Margin = new System.Windows.Forms.Padding(1);
            this.Cbo_bancos.Name = "Cbo_bancos";
            this.Cbo_bancos.Size = new System.Drawing.Size(189, 28);
            this.Cbo_bancos.TabIndex = 17;
            this.Cbo_bancos.SelectedIndexChanged += new System.EventHandler(this.Cbo_bancos_SelectedIndexChanged);
            // 
            // DtpPeriodo
            // 
            this.DtpPeriodo.CustomFormat = "MM/yyyy";
            this.DtpPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPeriodo.Location = new System.Drawing.Point(539, 52);
            this.DtpPeriodo.Margin = new System.Windows.Forms.Padding(1);
            this.DtpPeriodo.Name = "DtpPeriodo";
            this.DtpPeriodo.Size = new System.Drawing.Size(107, 26);
            this.DtpPeriodo.TabIndex = 16;
            this.DtpPeriodo.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Banco:";
            // 
            // DgvLibroBancos
            // 
            this.DgvLibroBancos.AllowUserToAddRows = false;
            this.DgvLibroBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLibroBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibroBancos.Location = new System.Drawing.Point(39, 120);
            this.DgvLibroBancos.Margin = new System.Windows.Forms.Padding(2);
            this.DgvLibroBancos.Name = "DgvLibroBancos";
            this.DgvLibroBancos.ReadOnly = true;
            this.DgvLibroBancos.RowHeadersWidth = 62;
            this.DgvLibroBancos.RowTemplate.Height = 28;
            this.DgvLibroBancos.Size = new System.Drawing.Size(605, 123);
            this.DgvLibroBancos.TabIndex = 29;
            this.DgvLibroBancos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibroBancos_CellContentClick);
            this.DgvLibroBancos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvLibroBancos_DataBindingComplete);
            // 
            // BtnAgregarConciliado
            // 
            this.BtnAgregarConciliado.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarConciliado.Image")));
            this.BtnAgregarConciliado.Location = new System.Drawing.Point(534, 247);
            this.BtnAgregarConciliado.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregarConciliado.Name = "BtnAgregarConciliado";
            this.BtnAgregarConciliado.Size = new System.Drawing.Size(53, 40);
            this.BtnAgregarConciliado.TabIndex = 30;
            this.BtnAgregarConciliado.UseVisualStyleBackColor = true;
            this.BtnAgregarConciliado.Click += new System.EventHandler(this.BtnAgregarConciliado_Click);
            // 
            // BtnRegresarConciliado
            // 
            this.BtnRegresarConciliado.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresarConciliado.Image")));
            this.BtnRegresarConciliado.Location = new System.Drawing.Point(591, 247);
            this.BtnRegresarConciliado.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegresarConciliado.Name = "BtnRegresarConciliado";
            this.BtnRegresarConciliado.Size = new System.Drawing.Size(53, 40);
            this.BtnRegresarConciliado.TabIndex = 31;
            this.BtnRegresarConciliado.UseVisualStyleBackColor = true;
            this.BtnRegresarConciliado.Click += new System.EventHandler(this.BtnRegresarConciliado_Click);
            // 
            // CboMonedas
            // 
            this.CboMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMonedas.FormattingEnabled = true;
            this.CboMonedas.Location = new System.Drawing.Point(373, 53);
            this.CboMonedas.Margin = new System.Windows.Forms.Padding(1);
            this.CboMonedas.Name = "CboMonedas";
            this.CboMonedas.Size = new System.Drawing.Size(113, 28);
            this.CboMonedas.TabIndex = 33;
            this.CboMonedas.SelectedIndexChanged += new System.EventHandler(this.CboMonedas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Moneda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Debe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 446);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Haber:";
            // 
            // LblDebe
            // 
            this.LblDebe.AutoSize = true;
            this.LblDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDebe.Location = new System.Drawing.Point(262, 427);
            this.LblDebe.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblDebe.Name = "LblDebe";
            this.LblDebe.Size = new System.Drawing.Size(40, 20);
            this.LblDebe.TabIndex = 36;
            this.LblDebe.Text = "0.00";
            // 
            // LblHaber
            // 
            this.LblHaber.AutoSize = true;
            this.LblHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHaber.Location = new System.Drawing.Point(262, 446);
            this.LblHaber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblHaber.Name = "LblHaber";
            this.LblHaber.Size = new System.Drawing.Size(40, 20);
            this.LblHaber.TabIndex = 37;
            this.LblHaber.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pdfEstadoCuenta);
            this.panel1.Location = new System.Drawing.Point(675, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 364);
            this.panel1.TabIndex = 38;
            // 
            // pdfEstadoCuenta
            // 
            this.pdfEstadoCuenta.Enabled = true;
            this.pdfEstadoCuenta.Location = new System.Drawing.Point(3, 3);
            this.pdfEstadoCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.pdfEstadoCuenta.Name = "pdfEstadoCuenta";
            this.pdfEstadoCuenta.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfEstadoCuenta.OcxState")));
            this.pdfEstadoCuenta.Size = new System.Drawing.Size(555, 554);
            this.pdfEstadoCuenta.TabIndex = 28;
            this.pdfEstadoCuenta.Enter += new System.EventHandler(this.PdfEstadoCuenta_Enter);
            // 
            // frm_conciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1139, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblHaber);
            this.Controls.Add(this.LblDebe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboMonedas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnRegresarConciliado);
            this.Controls.Add(this.BtnAgregarConciliado);
            this.Controls.Add(this.DgvLibroBancos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblDiferencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvConciliado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_EstadoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbo_bancos);
            this.Controls.Add(this.DtpPeriodo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_conciliacionBancaria";
            this.Text = "frm_conciliacionBancaria";
            this.Load += new System.EventHandler(this.Frm_conciliacionBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibroBancos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfEstadoCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDiferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvConciliado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_EstadoCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_bancos;
        private System.Windows.Forms.DateTimePicker DtpPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLibroBancos;
        private System.Windows.Forms.Button BtnAgregarConciliado;
        private System.Windows.Forms.Button BtnRegresarConciliado;
        private System.Windows.Forms.ComboBox CboMonedas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblDebe;
        private System.Windows.Forms.Label LblHaber;
        private System.Windows.Forms.Panel panel1;
        private AxAcroPDFLib.AxAcroPDF pdfEstadoCuenta;
    }
}