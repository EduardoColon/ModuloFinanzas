namespace Finanzas
{
    partial class Frm_FlujoEfectivo
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
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Total_Ingresos = new System.Windows.Forms.DataGridView();
            this.Ingresos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Total_Egresos = new System.Windows.Forms.DataGridView();
            this.Egresos = new System.Windows.Forms.DataGridView();
            this.Saldo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingresos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Egresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldo)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(901, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 33);
            this.button4.TabIndex = 28;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Flujo Efectivo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Total_Ingresos);
            this.panel1.Controls.Add(this.Ingresos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 364);
            this.panel1.TabIndex = 30;
            // 
            // Total_Ingresos
            // 
            this.Total_Ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Total_Ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Total_Ingresos.Location = new System.Drawing.Point(3, 311);
            this.Total_Ingresos.Name = "Total_Ingresos";
            this.Total_Ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Total_Ingresos.Size = new System.Drawing.Size(435, 46);
            this.Total_Ingresos.TabIndex = 32;
            // 
            // Ingresos
            // 
            this.Ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ingresos.Location = new System.Drawing.Point(7, 31);
            this.Ingresos.Name = "Ingresos";
            this.Ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ingresos.Size = new System.Drawing.Size(435, 274);
            this.Ingresos.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Detalle Ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Detalle Egresos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Total_Egresos);
            this.panel2.Controls.Add(this.Egresos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(483, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 364);
            this.panel2.TabIndex = 31;
            // 
            // Total_Egresos
            // 
            this.Total_Egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Total_Egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Total_Egresos.Location = new System.Drawing.Point(7, 311);
            this.Total_Egresos.Name = "Total_Egresos";
            this.Total_Egresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Total_Egresos.Size = new System.Drawing.Size(435, 46);
            this.Total_Egresos.TabIndex = 33;
            // 
            // Egresos
            // 
            this.Egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Egresos.Location = new System.Drawing.Point(7, 31);
            this.Egresos.Name = "Egresos";
            this.Egresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Egresos.Size = new System.Drawing.Size(435, 274);
            this.Egresos.TabIndex = 31;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Saldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Saldo.Location = new System.Drawing.Point(340, 447);
            this.Saldo.Name = "Saldo";
            this.Saldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Saldo.Size = new System.Drawing.Size(256, 41);
            this.Saldo.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Saldo Neto";
            // 
            // Frm_FlujoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(951, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FlujoEfectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FlujoEfectivo";
            this.Load += new System.EventHandler(this.Frm_FlujoEfectivo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingresos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Egresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Ingresos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Egresos;
        private System.Windows.Forms.DataGridView Total_Ingresos;
        private System.Windows.Forms.DataGridView Total_Egresos;
        private System.Windows.Forms.DataGridView Saldo;
        private System.Windows.Forms.Label label4;
    }
}