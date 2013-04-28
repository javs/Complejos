namespace Complejos
{
    partial class Central
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
            this.lOperacion = new System.Windows.Forms.Label();
            this.Operacion = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Igual = new System.Windows.Forms.Button();
            this.lEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lOperacion
            // 
            this.lOperacion.AutoSize = true;
            this.lOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperacion.Location = new System.Drawing.Point(6, 6);
            this.lOperacion.Margin = new System.Windows.Forms.Padding(3);
            this.lOperacion.Name = "lOperacion";
            this.lOperacion.Size = new System.Drawing.Size(65, 13);
            this.lOperacion.TabIndex = 0;
            this.lOperacion.Text = "Operación";
            // 
            // Operacion
            // 
            this.Operacion.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operacion.Location = new System.Drawing.Point(6, 25);
            this.Operacion.Name = "Operacion";
            this.Operacion.Size = new System.Drawing.Size(332, 39);
            this.Operacion.TabIndex = 1;
            this.Operacion.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultado.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(388, 25);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(139, 39);
            this.Resultado.TabIndex = 3;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Igual
            // 
            this.Igual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Igual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(344, 24);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(38, 40);
            this.Igual.TabIndex = 2;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // lEstado
            // 
            this.lEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.IndianRed;
            this.lEstado.Location = new System.Drawing.Point(85, 6);
            this.lEstado.Margin = new System.Windows.Forms.Padding(3);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(442, 13);
            this.lEstado.TabIndex = 4;
            this.lEstado.Text = "Estado";
            this.lEstado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 71);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Operacion);
            this.Controls.Add(this.lOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Central";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "WesselSoft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lOperacion;
        private System.Windows.Forms.TextBox Operacion;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Label lEstado;

    }
}

