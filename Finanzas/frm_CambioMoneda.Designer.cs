﻿namespace Finanzas
{
    partial class frm_CambioMoneda
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_MonedaBase = new System.Windows.Forms.ComboBox();
            this.Cbo_MonedaObjetivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Cambio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "De: ";
            // 
            // Cbo_MonedaBase
            // 
            this.Cbo_MonedaBase.FormattingEnabled = true;
            this.Cbo_MonedaBase.Location = new System.Drawing.Point(94, 51);
            this.Cbo_MonedaBase.Name = "Cbo_MonedaBase";
            this.Cbo_MonedaBase.Size = new System.Drawing.Size(235, 28);
            this.Cbo_MonedaBase.TabIndex = 2;
            // 
            // Cbo_MonedaObjetivo
            // 
            this.Cbo_MonedaObjetivo.FormattingEnabled = true;
            this.Cbo_MonedaObjetivo.Location = new System.Drawing.Point(368, 52);
            this.Cbo_MonedaObjetivo.Name = "Cbo_MonedaObjetivo";
            this.Cbo_MonedaObjetivo.Size = new System.Drawing.Size(209, 28);
            this.Cbo_MonedaObjetivo.TabIndex = 4;
            this.Cbo_MonedaObjetivo.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "A:";
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.Location = new System.Drawing.Point(583, 44);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(111, 41);
            this.Btn_Consultar.TabIndex = 5;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de cambio:";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(368, 118);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(85, 22);
            this.Lbl_Resultado.TabIndex = 7;
            this.Lbl_Resultado.Text = "0.000000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Lbl_Resultado);
            this.panel1.Controls.Add(this.Cbo_MonedaBase);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_Consultar);
            this.panel1.Controls.Add(this.Cbo_MonedaObjetivo);
            this.panel1.Location = new System.Drawing.Point(37, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 189);
            this.panel1.TabIndex = 8;
            // 
            // frm_CambioMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frm_CambioMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CambioMoneda";
            this.Load += new System.EventHandler(this.Frm_CambioMoneda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_MonedaBase;
        private System.Windows.Forms.ComboBox Cbo_MonedaObjetivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Panel panel1;
    }
}