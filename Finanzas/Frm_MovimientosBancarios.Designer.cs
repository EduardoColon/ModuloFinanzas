namespace Finanzas
{
    partial class Frm_MovimientosBancarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxtransac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.txtanombre = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.boxcredito = new System.Windows.Forms.ComboBox();
            this.boxdebito = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.boxctacontablecredito = new System.Windows.Forms.ComboBox();
            this.boxctacontabledebito = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxClasifGastos = new System.Windows.Forms.ComboBox();
            this.txtctacredito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transacción:";
            // 
            // boxtransac
            // 
            this.boxtransac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxtransac.FormattingEnabled = true;
            this.boxtransac.Items.AddRange(new object[] {
            "Cheques",
            "Depositos",
            "ACH (Pagos por transferencia)",
            "Transacciones entre Cuentas propias"});
            this.boxtransac.Location = new System.Drawing.Point(226, 32);
            this.boxtransac.Name = "boxtransac";
            this.boxtransac.Size = new System.Drawing.Size(200, 21);
            this.boxtransac.TabIndex = 1;
            this.boxtransac.SelectedIndexChanged += new System.EventHandler(this.txttransac_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cuenta Bancaria Crédito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cuenta Bancaria Débito:";
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(226, 69);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(100, 20);
            this.txtdoc.TabIndex = 7;
            // 
            // txtanombre
            // 
            this.txtanombre.Location = new System.Drawing.Point(226, 262);
            this.txtanombre.Name = "txtanombre";
            this.txtanombre.Size = new System.Drawing.Size(604, 20);
            this.txtanombre.TabIndex = 11;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(226, 288);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(604, 75);
            this.txtdes.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "A nombre de:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Valor:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(606, 99);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(224, 20);
            this.txtvalor.TabIndex = 17;
            // 
            // boxcredito
            // 
            this.boxcredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxcredito.FormattingEnabled = true;
            this.boxcredito.Location = new System.Drawing.Point(226, 149);
            this.boxcredito.Name = "boxcredito";
            this.boxcredito.Size = new System.Drawing.Size(202, 21);
            this.boxcredito.TabIndex = 20;
            // 
            // boxdebito
            // 
            this.boxdebito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxdebito.FormattingEnabled = true;
            this.boxdebito.Location = new System.Drawing.Point(606, 164);
            this.boxdebito.Name = "boxdebito";
            this.boxdebito.Size = new System.Drawing.Size(165, 21);
            this.boxdebito.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(719, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(593, 382);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 42);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxctacontablecredito
            // 
            this.boxctacontablecredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxctacontablecredito.FormattingEnabled = true;
            this.boxctacontablecredito.Location = new System.Drawing.Point(226, 221);
            this.boxctacontablecredito.Name = "boxctacontablecredito";
            this.boxctacontablecredito.Size = new System.Drawing.Size(202, 21);
            this.boxctacontablecredito.TabIndex = 24;
            // 
            // boxctacontabledebito
            // 
            this.boxctacontabledebito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxctacontabledebito.FormattingEnabled = true;
            this.boxctacontabledebito.Location = new System.Drawing.Point(606, 221);
            this.boxctacontabledebito.Name = "boxctacontabledebito";
            this.boxctacontabledebito.Size = new System.Drawing.Size(165, 21);
            this.boxctacontabledebito.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cuenta Contable Crédito:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(458, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cuenta Contable Débito:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 32);
            this.label11.TabIndex = 28;
            this.label11.Text = "Clasificación \r\nde Movimiento:";
            // 
            // boxClasifGastos
            // 
            this.boxClasifGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxClasifGastos.FormattingEnabled = true;
            this.boxClasifGastos.Location = new System.Drawing.Point(226, 395);
            this.boxClasifGastos.Name = "boxClasifGastos";
            this.boxClasifGastos.Size = new System.Drawing.Size(189, 21);
            this.boxClasifGastos.TabIndex = 29;
            // 
            // txtctacredito
            // 
            this.txtctacredito.Location = new System.Drawing.Point(226, 176);
            this.txtctacredito.Name = "txtctacredito";
            this.txtctacredito.Size = new System.Drawing.Size(202, 20);
            this.txtctacredito.TabIndex = 30;
            // 
            // Frm_MovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(909, 448);
            this.Controls.Add(this.txtctacredito);
            this.Controls.Add(this.boxClasifGastos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxctacontabledebito);
            this.Controls.Add(this.boxctacontablecredito);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxdebito);
            this.Controls.Add(this.boxcredito);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtanombre);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxtransac);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MovimientosBancarios";
            this.Text = "Frm_MovimientosBancarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxtransac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.TextBox txtanombre;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox boxcredito;
        private System.Windows.Forms.ComboBox boxdebito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox boxctacontablecredito;
        private System.Windows.Forms.ComboBox boxctacontabledebito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox boxClasifGastos;
        private System.Windows.Forms.TextBox txtctacredito;
    }
}