﻿namespace Finanzas
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
            this.label7 = new System.Windows.Forms.Label();
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
            this.pdfEstadoCuenta = new AxAcroPDFLib.AxAcroPDF();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibroBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfEstadoCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 617);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Finalizar conciliacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 626);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "QQQQ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 626);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Saldo pendiente por cuadrar:";
            // 
            // DgvConciliado
            // 
            this.DgvConciliado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConciliado.Location = new System.Drawing.Point(47, 423);
            this.DgvConciliado.Name = "DgvConciliado";
            this.DgvConciliado.RowHeadersWidth = 62;
            this.DgvConciliado.Size = new System.Drawing.Size(716, 164);
            this.DgvConciliado.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Movimientos validados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Movimientos libro bancos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 46);
            this.label3.TabIndex = 20;
            this.label3.Text = "Conciliaciones bancarias";
            // 
            // btn_EstadoCuenta
            // 
            this.btn_EstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EstadoCuenta.Location = new System.Drawing.Point(877, 77);
            this.btn_EstadoCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EstadoCuenta.Name = "btn_EstadoCuenta";
            this.btn_EstadoCuenta.Size = new System.Drawing.Size(327, 54);
            this.btn_EstadoCuenta.TabIndex = 19;
            this.btn_EstadoCuenta.Text = "Abrir estado de cuenta";
            this.btn_EstadoCuenta.UseVisualStyleBackColor = true;
            this.btn_EstadoCuenta.Click += new System.EventHandler(this.Btn_EstadoCuenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mes:";
            // 
            // Cbo_bancos
            // 
            this.Cbo_bancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_bancos.FormattingEnabled = true;
            this.Cbo_bancos.Location = new System.Drawing.Point(135, 83);
            this.Cbo_bancos.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_bancos.Name = "Cbo_bancos";
            this.Cbo_bancos.Size = new System.Drawing.Size(281, 37);
            this.Cbo_bancos.TabIndex = 17;
            this.Cbo_bancos.SelectedIndexChanged += new System.EventHandler(this.Cbo_bancos_SelectedIndexChanged);
            // 
            // DtpPeriodo
            // 
            this.DtpPeriodo.CustomFormat = "MM/yyyy";
            this.DtpPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPeriodo.Location = new System.Drawing.Point(512, 85);
            this.DtpPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.DtpPeriodo.Name = "DtpPeriodo";
            this.DtpPeriodo.Size = new System.Drawing.Size(158, 35);
            this.DtpPeriodo.TabIndex = 16;
            this.DtpPeriodo.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Banco:";
            // 
            // DgvLibroBancos
            // 
            this.DgvLibroBancos.AllowUserToAddRows = false;
            this.DgvLibroBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLibroBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibroBancos.Location = new System.Drawing.Point(47, 184);
            this.DgvLibroBancos.Name = "DgvLibroBancos";
            this.DgvLibroBancos.RowHeadersWidth = 62;
            this.DgvLibroBancos.RowTemplate.Height = 28;
            this.DgvLibroBancos.Size = new System.Drawing.Size(716, 174);
            this.DgvLibroBancos.TabIndex = 29;
            this.DgvLibroBancos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibroBancos_CellContentClick);
            // 
            // pdfEstadoCuenta
            // 
            this.pdfEstadoCuenta.Enabled = true;
            this.pdfEstadoCuenta.Location = new System.Drawing.Point(819, 158);
            this.pdfEstadoCuenta.Name = "pdfEstadoCuenta";
            this.pdfEstadoCuenta.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfEstadoCuenta.OcxState")));
            this.pdfEstadoCuenta.Size = new System.Drawing.Size(434, 497);
            this.pdfEstadoCuenta.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 47);
            this.button2.TabIndex = 30;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 47);
            this.button3.TabIndex = 31;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm_conciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DgvLibroBancos);
            this.Controls.Add(this.pdfEstadoCuenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
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
            this.Name = "frm_conciliacionBancaria";
            this.Text = "frm_conciliacionBancaria";
            this.Load += new System.EventHandler(this.Frm_conciliacionBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibroBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfEstadoCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
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
        private AxAcroPDFLib.AxAcroPDF pdfEstadoCuenta;
        private System.Windows.Forms.DataGridView DgvLibroBancos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}