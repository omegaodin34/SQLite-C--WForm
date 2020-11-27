using System;

namespace BaseDatos
{
    /***
     * Creado por Jose Manuel Rodriguez Altamirano
     * */
    partial class Form1
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.txtIndicativo = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.Puntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RSTLabel = new System.Windows.Forms.Label();
            this.txtRST = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(723, 71);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 20);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Red;
            this.labelName.Location = new System.Drawing.Point(3, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Indicativo";
            this.labelName.UseMnemonic = false;
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Location = new System.Drawing.Point(35, 143);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.Size = new System.Drawing.Size(688, 232);
            this.dtgrid.TabIndex = 2;
            // 
            // txtIndicativo
            // 
            this.txtIndicativo.Location = new System.Drawing.Point(62, 72);
            this.txtIndicativo.Name = "txtIndicativo";
            this.txtIndicativo.Size = new System.Drawing.Size(69, 20);
            this.txtIndicativo.TabIndex = 3;
            this.txtIndicativo.TextChanged += new System.EventHandler(this.txtIndicativo_TextChanged);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.ForeColor = System.Drawing.Color.Red;
            this.labelColor.Location = new System.Drawing.Point(137, 79);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(22, 13);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "TG";
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(181, 72);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(78, 20);
            this.txtTG.TabIndex = 5;
            this.txtTG.TextChanged += new System.EventHandler(this.txtBanda_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(308, 72);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(79, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.ForeColor = System.Drawing.Color.Red;
            this.Fecha.Location = new System.Drawing.Point(265, 79);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 7;
            this.Fecha.Text = "Fecha";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.ForeColor = System.Drawing.Color.Red;
            this.Hora.Location = new System.Drawing.Point(393, 79);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(30, 13);
            this.Hora.TabIndex = 8;
            this.Hora.Text = "Hora";
            this.Hora.Click += new System.EventHandler(this.Hora_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(427, 72);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(70, 20);
            this.txtHora.TabIndex = 9;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(624, 72);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(73, 20);
            this.txtPuntos.TabIndex = 10;
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.ForeColor = System.Drawing.Color.Red;
            this.Puntos.Location = new System.Drawing.Point(578, 79);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(40, 13);
            this.Puntos.TabIndex = 11;
            this.Puntos.Text = "Puntos";
            this.Puntos.Click += new System.EventHandler(this.Puntos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(212, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "10º DIPLOMA EN HONOR A LA MUJER RADIOAFICIONADA";
            // 
            // RSTLabel
            // 
            this.RSTLabel.AutoSize = true;
            this.RSTLabel.ForeColor = System.Drawing.Color.Red;
            this.RSTLabel.Location = new System.Drawing.Point(503, 79);
            this.RSTLabel.Name = "RSTLabel";
            this.RSTLabel.Size = new System.Drawing.Size(29, 13);
            this.RSTLabel.TabIndex = 13;
            this.RSTLabel.Text = "RST";
            // 
            // txtRST
            // 
            this.txtRST.Location = new System.Drawing.Point(533, 72);
            this.txtRST.Name = "txtRST";
            this.txtRST.Size = new System.Drawing.Size(39, 20);
            this.txtRST.TabIndex = 14;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Titulo.Location = new System.Drawing.Point(295, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(128, 13);
            this.Titulo.TabIndex = 15;
            this.Titulo.Text = "RADIO CLUB QUIJOTES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.txtRST);
            this.Controls.Add(this.RSTLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtTG);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.txtIndicativo);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.TextBox txtIndicativo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RSTLabel;
        private System.Windows.Forms.TextBox txtRST;
        private System.Windows.Forms.Label Titulo;
    }
}