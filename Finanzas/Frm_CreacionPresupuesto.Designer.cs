namespace Finanzas
{
    partial class Frm_CreacionPresupuesto
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
            this.navegador1 = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Location = new System.Drawing.Point(-1, -1);
            this.navegador1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1168, 656);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.Navegador1_Load_1);
            // 
            // Frm_CreacionPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 672);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_CreacionPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CreacionPresupuesto";
            this.Load += new System.EventHandler(this.Frm_CreacionPresupuesto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador navegador1;
    }
}