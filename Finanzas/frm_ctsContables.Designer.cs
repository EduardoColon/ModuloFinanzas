namespace Finanzas
{
    partial class frm_ctsContables
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
            this.navegador1 = new CapaDeDisenoBARRA.Navegador();
            this.txt_descripcionCuenta = new System.Windows.Forms.RichTextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_nombreCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipoCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodigoCuenta = new System.Windows.Forms.TextBox();
            this.dgv_cuentasContables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuentasContables)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Location = new System.Drawing.Point(17, 22);
            this.navegador1.MaximumSize = new System.Drawing.Size(1143, 94);
            this.navegador1.MinimumSize = new System.Drawing.Size(1143, 94);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1143, 94);
            this.navegador1.TabIndex = 0;
            // 
            // txt_descripcionCuenta
            // 
            this.txt_descripcionCuenta.Location = new System.Drawing.Point(512, 280);
            this.txt_descripcionCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcionCuenta.Name = "txt_descripcionCuenta";
            this.txt_descripcionCuenta.Size = new System.Drawing.Size(335, 124);
            this.txt_descripcionCuenta.TabIndex = 41;
            this.txt_descripcionCuenta.Text = "";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(512, 417);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(132, 20);
            this.txt_estado.TabIndex = 40;
            // 
            // txt_nombreCuenta
            // 
            this.txt_nombreCuenta.Location = new System.Drawing.Point(512, 236);
            this.txt_nombreCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreCuenta.Name = "txt_nombreCuenta";
            this.txt_nombreCuenta.Size = new System.Drawing.Size(256, 20);
            this.txt_nombreCuenta.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descripcion de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre de Cuenta";
            // 
            // cbo_tipoCuenta
            // 
            this.cbo_tipoCuenta.FormattingEnabled = true;
            this.cbo_tipoCuenta.Location = new System.Drawing.Point(512, 149);
            this.cbo_tipoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_tipoCuenta.Name = "cbo_tipoCuenta";
            this.cbo_tipoCuenta.Size = new System.Drawing.Size(256, 21);
            this.cbo_tipoCuenta.TabIndex = 35;
            this.cbo_tipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cbo_tipoCuenta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Codigo de Cuenta";
            // 
            // txt_CodigoCuenta
            // 
            this.txt_CodigoCuenta.Location = new System.Drawing.Point(512, 189);
            this.txt_CodigoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoCuenta.Name = "txt_CodigoCuenta";
            this.txt_CodigoCuenta.Size = new System.Drawing.Size(256, 20);
            this.txt_CodigoCuenta.TabIndex = 32;
            // 
            // dgv_cuentasContables
            // 
            this.dgv_cuentasContables.AllowUserToAddRows = false;
            this.dgv_cuentasContables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuentasContables.Location = new System.Drawing.Point(87, 445);
            this.dgv_cuentasContables.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cuentasContables.Name = "dgv_cuentasContables";
            this.dgv_cuentasContables.ReadOnly = true;
            this.dgv_cuentasContables.Size = new System.Drawing.Size(984, 244);
            this.dgv_cuentasContables.TabIndex = 42;
            this.dgv_cuentasContables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cuentasContables_CellClick);
            // 
            // frm_ctsContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1174, 695);
            this.Controls.Add(this.dgv_cuentasContables);
            this.Controls.Add(this.txt_descripcionCuenta);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_nombreCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_tipoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CodigoCuenta);
            this.Controls.Add(this.navegador1);
            this.Name = "frm_ctsContables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ctsContables";
            this.Load += new System.EventHandler(this.frm_ctsContables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuentasContables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDeDisenoBARRA.Navegador navegador1;
        private System.Windows.Forms.RichTextBox txt_descripcionCuenta;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_nombreCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipoCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodigoCuenta;
        private System.Windows.Forms.DataGridView dgv_cuentasContables;
    }
}