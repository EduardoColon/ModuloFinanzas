namespace Finanzas
{
    partial class frm_BalanceDeSaldos
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
            this.dtp_fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dgv_BalanceDeSaldos = new System.Windows.Forms.DataGridView();
            this.codigo_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceDeSaldos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_fechaInicial
            // 
            this.dtp_fechaInicial.Location = new System.Drawing.Point(38, 38);
            this.dtp_fechaInicial.Name = "dtp_fechaInicial";
            this.dtp_fechaInicial.Size = new System.Drawing.Size(200, 23);
            this.dtp_fechaInicial.TabIndex = 0;
            // 
            // dtp_fechaFinal
            // 
            this.dtp_fechaFinal.Location = new System.Drawing.Point(38, 86);
            this.dtp_fechaFinal.Name = "dtp_fechaFinal";
            this.dtp_fechaFinal.Size = new System.Drawing.Size(200, 23);
            this.dtp_fechaFinal.TabIndex = 1;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(150, 115);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(88, 28);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dgv_BalanceDeSaldos
            // 
            this.dgv_BalanceDeSaldos.AllowUserToAddRows = false;
            this.dgv_BalanceDeSaldos.AllowUserToDeleteRows = false;
            this.dgv_BalanceDeSaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BalanceDeSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BalanceDeSaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_cuenta,
            this.Nombre,
            this.debe,
            this.haber});
            this.dgv_BalanceDeSaldos.Location = new System.Drawing.Point(268, 38);
            this.dgv_BalanceDeSaldos.Name = "dgv_BalanceDeSaldos";
            this.dgv_BalanceDeSaldos.ReadOnly = true;
            this.dgv_BalanceDeSaldos.Size = new System.Drawing.Size(675, 545);
            this.dgv_BalanceDeSaldos.TabIndex = 3;
            // 
            // codigo_cuenta
            // 
            this.codigo_cuenta.HeaderText = "Codigo Cuenta";
            this.codigo_cuenta.Name = "codigo_cuenta";
            this.codigo_cuenta.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // debe
            // 
            this.debe.HeaderText = "";
            this.debe.Name = "debe";
            this.debe.ReadOnly = true;
            // 
            // haber
            // 
            this.haber.HeaderText = "";
            this.haber.Name = "haber";
            this.haber.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Final";
            // 
            // frm_BalanceDeSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(977, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_BalanceDeSaldos);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dtp_fechaFinal);
            this.Controls.Add(this.dtp_fechaInicial);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BalanceDeSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance De Saldos";
            this.Load += new System.EventHandler(this.frm_BalanceDeSaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceDeSaldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fechaInicial;
        private System.Windows.Forms.DateTimePicker dtp_fechaFinal;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridView dgv_BalanceDeSaldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}