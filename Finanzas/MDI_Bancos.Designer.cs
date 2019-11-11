namespace Finanzas
{
    partial class MDI_Bancos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificadorDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conciliacionBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeBancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarConciliacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioPolizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.consultarConciliacionBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioPolizasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1353, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasBancariasToolStripMenuItem,
            this.chequeraToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.clasificadorDeMovimientosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // cuentasBancariasToolStripMenuItem
            // 
            this.cuentasBancariasToolStripMenuItem.Name = "cuentasBancariasToolStripMenuItem";
            this.cuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cuentasBancariasToolStripMenuItem.Text = "Cuentas Bancarias";
            this.cuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.cuentasBancariasToolStripMenuItem_Click);
            // 
            // chequeraToolStripMenuItem
            // 
            this.chequeraToolStripMenuItem.Name = "chequeraToolStripMenuItem";
            this.chequeraToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.chequeraToolStripMenuItem.Text = "Chequera";
            this.chequeraToolStripMenuItem.Click += new System.EventHandler(this.chequeraToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.bancosToolStripMenuItem.Text = "Bancos";
            this.bancosToolStripMenuItem.Click += new System.EventHandler(this.bancosToolStripMenuItem_Click);
            // 
            // clasificadorDeMovimientosToolStripMenuItem
            // 
            this.clasificadorDeMovimientosToolStripMenuItem.Name = "clasificadorDeMovimientosToolStripMenuItem";
            this.clasificadorDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.clasificadorDeMovimientosToolStripMenuItem.Text = "Clasificador de Movimientos";
            this.clasificadorDeMovimientosToolStripMenuItem.Click += new System.EventHandler(this.clasificadorDeMovimientosToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conciliacionBancariaToolStripMenuItem,
            this.movimientosDeBancosToolStripMenuItem,
            this.tipoDeCambioToolStripMenuItem,
            this.consultarConciliacionToolStripMenuItem,
            this.envioPolizasToolStripMenuItem1});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // conciliacionBancariaToolStripMenuItem
            // 
            this.conciliacionBancariaToolStripMenuItem.Name = "conciliacionBancariaToolStripMenuItem";
            this.conciliacionBancariaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.conciliacionBancariaToolStripMenuItem.Text = "Conciliacion Bancaria";
            this.conciliacionBancariaToolStripMenuItem.Click += new System.EventHandler(this.conciliacionBancariaToolStripMenuItem_Click);
            // 
            // movimientosDeBancosToolStripMenuItem
            // 
            this.movimientosDeBancosToolStripMenuItem.Name = "movimientosDeBancosToolStripMenuItem";
            this.movimientosDeBancosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.movimientosDeBancosToolStripMenuItem.Text = "Movimientos de Bancos";
            this.movimientosDeBancosToolStripMenuItem.Click += new System.EventHandler(this.movimientosDeBancosToolStripMenuItem_Click);
            // 
            // tipoDeCambioToolStripMenuItem
            // 
            this.tipoDeCambioToolStripMenuItem.Name = "tipoDeCambioToolStripMenuItem";
            this.tipoDeCambioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.tipoDeCambioToolStripMenuItem.Text = "Tipo de Cambio";
            this.tipoDeCambioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCambioToolStripMenuItem_Click);
            // 
            // consultarConciliacionToolStripMenuItem
            // 
            this.consultarConciliacionToolStripMenuItem.Name = "consultarConciliacionToolStripMenuItem";
            this.consultarConciliacionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.consultarConciliacionToolStripMenuItem.Text = "Consultar conciliacion";
            this.consultarConciliacionToolStripMenuItem.Click += new System.EventHandler(this.ConsultarConciliacionToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // envioPolizasToolStripMenuItem
            // 
            this.envioPolizasToolStripMenuItem.Name = "envioPolizasToolStripMenuItem";
            this.envioPolizasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 639);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1353, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // consultarConciliacionBancariaToolStripMenuItem
            // 
            this.consultarConciliacionBancariaToolStripMenuItem.Name = "consultarConciliacionBancariaToolStripMenuItem";
            this.consultarConciliacionBancariaToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.consultarConciliacionBancariaToolStripMenuItem.Text = "Consultar Conciliacion Bancaria";
            this.consultarConciliacionBancariaToolStripMenuItem.Click += new System.EventHandler(this.ConsultarConciliacionBancariaToolStripMenuItem_Click);
            // 
            // envioPolizasToolStripMenuItem1
            // 
            this.envioPolizasToolStripMenuItem1.Name = "envioPolizasToolStripMenuItem1";
            this.envioPolizasToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.envioPolizasToolStripMenuItem1.Text = "Envio Polizas";
            this.envioPolizasToolStripMenuItem1.Click += new System.EventHandler(this.envioPolizasToolStripMenuItem1_Click);
            // 
            // MDI_Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 661);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_Bancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conciliacionBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeBancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCambioToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem clasificadorDeMovimientosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem envioPolizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarConciliacionBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarConciliacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioPolizasToolStripMenuItem1;
    }
}



