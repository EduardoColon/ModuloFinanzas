namespace Finanzas
{
    partial class frm_BalanceGeneral
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dgv_balancegeneral = new System.Windows.Forms.DataGridView();
            this.Codigo_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primera_Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segunda_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_balancegeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_fechaInicial
            // 
            this.dtp_fechaInicial.Location = new System.Drawing.Point(101, 52);
            this.dtp_fechaInicial.Name = "dtp_fechaInicial";
            this.dtp_fechaInicial.Size = new System.Drawing.Size(217, 22);
            this.dtp_fechaInicial.TabIndex = 1;
            // 
            // dtp_fechaFinal
            // 
            this.dtp_fechaFinal.Location = new System.Drawing.Point(101, 89);
            this.dtp_fechaFinal.Name = "dtp_fechaFinal";
            this.dtp_fechaFinal.Size = new System.Drawing.Size(217, 22);
            this.dtp_fechaFinal.TabIndex = 2;
            // 
            // dgv_balancegeneral
            // 
            this.dgv_balancegeneral.AllowUserToAddRows = false;
            this.dgv_balancegeneral.AllowUserToDeleteRows = false;
            this.dgv_balancegeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_balancegeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_balancegeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Cuenta,
            this.Cuenta,
            this.Primera_Columna,
            this.Segunda_Column});
            this.dgv_balancegeneral.Location = new System.Drawing.Point(360, 12);
            this.dgv_balancegeneral.Name = "dgv_balancegeneral";
            this.dgv_balancegeneral.ReadOnly = true;
            this.dgv_balancegeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_balancegeneral.Size = new System.Drawing.Size(820, 646);
            this.dgv_balancegeneral.TabIndex = 3;
            // 
            // Codigo_Cuenta
            // 
            this.Codigo_Cuenta.FillWeight = 62.94415F;
            this.Codigo_Cuenta.HeaderText = "Codigo Cuenta";
            this.Codigo_Cuenta.Name = "Codigo_Cuenta";
            this.Codigo_Cuenta.ReadOnly = true;
            // 
            // Cuenta
            // 
            this.Cuenta.FillWeight = 169.0395F;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Primera_Columna
            // 
            this.Primera_Columna.FillWeight = 84.00813F;
            this.Primera_Columna.HeaderText = "";
            this.Primera_Columna.Name = "Primera_Columna";
            this.Primera_Columna.ReadOnly = true;
            // 
            // Segunda_Column
            // 
            this.Segunda_Column.FillWeight = 84.00813F;
            this.Segunda_Column.HeaderText = "";
            this.Segunda_Column.Name = "Segunda_Column";
            this.Segunda_Column.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Final";
            // 
            // frm_BalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1189, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_balancegeneral);
            this.Controls.Add(this.dtp_fechaFinal);
            this.Controls.Add(this.dtp_fechaInicial);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_BalanceGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance General";
            this.Load += new System.EventHandler(this.btn_consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_balancegeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicial;
        private System.Windows.Forms.DateTimePicker dtp_fechaFinal;
        private System.Windows.Forms.DataGridView dgv_balancegeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primera_Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segunda_Column;
    }
}