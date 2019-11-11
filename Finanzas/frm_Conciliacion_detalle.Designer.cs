namespace Finanzas
{
    partial class frm_Conciliacion_detalle
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
            this.LblBanco = new System.Windows.Forms.Label();
            this.LblMoneda = new System.Windows.Forms.Label();
            this.LblMes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvConciliacion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblBanco);
            this.groupBox1.Controls.Add(this.LblMoneda);
            this.groupBox1.Controls.Add(this.LblMes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conciliación a detalle";
            // 
            // LblBanco
            // 
            this.LblBanco.AutoSize = true;
            this.LblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBanco.Location = new System.Drawing.Point(117, 61);
            this.LblBanco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBanco.Name = "LblBanco";
            this.LblBanco.Size = new System.Drawing.Size(98, 29);
            this.LblBanco.TabIndex = 42;
            this.LblBanco.Text = "BANCO";
            // 
            // LblMoneda
            // 
            this.LblMoneda.AutoSize = true;
            this.LblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneda.Location = new System.Drawing.Point(137, 99);
            this.LblMoneda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMoneda.Name = "LblMoneda";
            this.LblMoneda.Size = new System.Drawing.Size(66, 29);
            this.LblMoneda.TabIndex = 41;
            this.LblMoneda.Text = "GTQ";
            // 
            // LblMes
            // 
            this.LblMes.AutoSize = true;
            this.LblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMes.Location = new System.Drawing.Point(95, 143);
            this.LblMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(65, 29);
            this.LblMes.TabIndex = 40;
            this.LblMes.Text = "MES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 99);
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
            this.label2.Location = new System.Drawing.Point(26, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mes:";
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
            this.DgvConciliacion.Location = new System.Drawing.Point(21, 239);
            this.DgvConciliacion.Name = "DgvConciliacion";
            this.DgvConciliacion.ReadOnly = true;
            this.DgvConciliacion.RowHeadersWidth = 62;
            this.DgvConciliacion.RowTemplate.Height = 28;
            this.DgvConciliacion.Size = new System.Drawing.Size(1013, 438);
            this.DgvConciliacion.TabIndex = 2;
            // 
            // frm_Conciliacion_detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1065, 689);
            this.Controls.Add(this.DgvConciliacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Conciliacion_detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Conciliacion_detalle";
            this.Load += new System.EventHandler(this.Frm_Conciliacion_detalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConciliacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblBanco;
        private System.Windows.Forms.Label LblMoneda;
        private System.Windows.Forms.Label LblMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvConciliacion;
    }
}