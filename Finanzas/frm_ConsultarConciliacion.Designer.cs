namespace Finanzas
{
    partial class frm_ConsultarConciliacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CboMonedas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_bancos = new System.Windows.Forms.ComboBox();
            this.DtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvConciliacion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.CboMonedas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cbo_bancos);
            this.groupBox1.Controls.Add(this.DtpPeriodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Conciliación";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(996, 50);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(159, 51);
            this.BtnConsultar.TabIndex = 40;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CboMonedas
            // 
            this.CboMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMonedas.FormattingEnabled = true;
            this.CboMonedas.Location = new System.Drawing.Point(530, 60);
            this.CboMonedas.Margin = new System.Windows.Forms.Padding(2);
            this.CboMonedas.Name = "CboMonedas";
            this.CboMonedas.Size = new System.Drawing.Size(168, 37);
            this.CboMonedas.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Moneda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mes:";
            // 
            // Cbo_bancos
            // 
            this.Cbo_bancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_bancos.FormattingEnabled = true;
            this.Cbo_bancos.Location = new System.Drawing.Point(117, 60);
            this.Cbo_bancos.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_bancos.Name = "Cbo_bancos";
            this.Cbo_bancos.Size = new System.Drawing.Size(282, 37);
            this.Cbo_bancos.TabIndex = 36;
            // 
            // DtpPeriodo
            // 
            this.DtpPeriodo.CustomFormat = "MM/yyyy";
            this.DtpPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPeriodo.Location = new System.Drawing.Point(778, 58);
            this.DtpPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.DtpPeriodo.Name = "DtpPeriodo";
            this.DtpPeriodo.Size = new System.Drawing.Size(158, 35);
            this.DtpPeriodo.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Banco:";
            // 
            // DgvConciliacion
            // 
            this.DgvConciliacion.AllowUserToAddRows = false;
            this.DgvConciliacion.AllowUserToDeleteRows = false;
            this.DgvConciliacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvConciliacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConciliacion.Location = new System.Drawing.Point(39, 192);
            this.DgvConciliacion.Name = "DgvConciliacion";
            this.DgvConciliacion.ReadOnly = true;
            this.DgvConciliacion.RowHeadersWidth = 62;
            this.DgvConciliacion.RowTemplate.Height = 28;
            this.DgvConciliacion.Size = new System.Drawing.Size(1173, 472);
            this.DgvConciliacion.TabIndex = 1;
            this.DgvConciliacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConciliacion_CellClick);
            // 
            // frm_ConsultarConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1251, 716);
            this.Controls.Add(this.DgvConciliacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ConsultarConciliacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ConsultarConciliacion";
            this.Load += new System.EventHandler(this.Frm_ConsultarConciliacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CboMonedas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_bancos;
        private System.Windows.Forms.DateTimePicker DtpPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvConciliacion;
    }
}