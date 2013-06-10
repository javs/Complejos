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
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Igual = new System.Windows.Forms.Button();
            this.lEstado = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.basicoOp = new System.Windows.Forms.ComboBox();
            this.basicoOpB = new System.Windows.Forms.TextBox();
            this.basicoOpA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.raizGrado = new System.Windows.Forms.TextBox();
            this.raizOp = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.potenciaGrado = new System.Windows.Forms.TextBox();
            this.potenciaOp = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.fasoresOpB = new System.Windows.Forms.TextBox();
            this.fasoresOpA = new System.Windows.Forms.TextBox();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultado.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(417, 28);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(219, 51);
            this.Resultado.TabIndex = 6;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Igual
            // 
            this.Igual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Igual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(372, 33);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(38, 40);
            this.Igual.TabIndex = 5;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // lEstado
            // 
            this.lEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.IndianRed;
            this.lEstado.Location = new System.Drawing.Point(369, 6);
            this.lEstado.Margin = new System.Windows.Forms.Padding(3);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(267, 20);
            this.lEstado.TabIndex = 4;
            this.lEstado.Text = "Estado";
            this.lEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Controls.Add(this.tabPage5);
            this.tabs.Location = new System.Drawing.Point(6, 6);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(364, 76);
            this.tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.basicoOp);
            this.tabPage1.Controls.Add(this.basicoOpB);
            this.tabPage1.Controls.Add(this.basicoOpA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comp: + - / *";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // basicoOp
            // 
            this.basicoOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basicoOp.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoOp.FormattingEnabled = true;
            this.basicoOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.basicoOp.Location = new System.Drawing.Point(159, 6);
            this.basicoOp.Name = "basicoOp";
            this.basicoOp.Size = new System.Drawing.Size(38, 40);
            this.basicoOp.TabIndex = 3;
            // 
            // basicoOpB
            // 
            this.basicoOpB.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoOpB.Location = new System.Drawing.Point(203, 6);
            this.basicoOpB.Name = "basicoOpB";
            this.basicoOpB.Size = new System.Drawing.Size(147, 39);
            this.basicoOpB.TabIndex = 4;
            this.basicoOpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // basicoOpA
            // 
            this.basicoOpA.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoOpA.Location = new System.Drawing.Point(6, 6);
            this.basicoOpA.Name = "basicoOpA";
            this.basicoOpA.Size = new System.Drawing.Size(147, 39);
            this.basicoOpA.TabIndex = 2;
            this.basicoOpA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.raizGrado);
            this.tabPage2.Controls.Add(this.raizOp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comp: ˣ√";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "√";
            // 
            // raizGrado
            // 
            this.raizGrado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizGrado.Location = new System.Drawing.Point(6, 5);
            this.raizGrado.Name = "raizGrado";
            this.raizGrado.Size = new System.Drawing.Size(44, 26);
            this.raizGrado.TabIndex = 2;
            this.raizGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raizOp
            // 
            this.raizOp.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizOp.Location = new System.Drawing.Point(95, 6);
            this.raizOp.Name = "raizOp";
            this.raizOp.Size = new System.Drawing.Size(255, 39);
            this.raizOp.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.potenciaGrado);
            this.tabPage3.Controls.Add(this.potenciaOp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(356, 50);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comp: sˣ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // potenciaGrado
            // 
            this.potenciaGrado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaGrado.Location = new System.Drawing.Point(306, 5);
            this.potenciaGrado.Name = "potenciaGrado";
            this.potenciaGrado.Size = new System.Drawing.Size(44, 26);
            this.potenciaGrado.TabIndex = 3;
            this.potenciaGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // potenciaOp
            // 
            this.potenciaOp.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaOp.Location = new System.Drawing.Point(3, 6);
            this.potenciaOp.Name = "potenciaOp";
            this.potenciaOp.Size = new System.Drawing.Size(297, 39);
            this.potenciaOp.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(356, 50);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Comp: ˣ√ prim";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.fasoresOpB);
            this.tabPage5.Controls.Add(this.fasoresOpA);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(356, 50);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fasores";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            // 
            // fasoresOpB
            // 
            this.fasoresOpB.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasoresOpB.Location = new System.Drawing.Point(199, 6);
            this.fasoresOpB.Name = "fasoresOpB";
            this.fasoresOpB.Size = new System.Drawing.Size(151, 39);
            this.fasoresOpB.TabIndex = 3;
            this.fasoresOpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fasoresOpA
            // 
            this.fasoresOpA.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasoresOpA.Location = new System.Drawing.Point(6, 6);
            this.fasoresOpA.Name = "fasoresOpA";
            this.fasoresOpA.Size = new System.Drawing.Size(151, 39);
            this.fasoresOpA.TabIndex = 2;
            this.fasoresOpA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 87);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Central";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "WesselSoft";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox basicoOpA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox basicoOp;
        private System.Windows.Forms.TextBox basicoOpB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox raizGrado;
        private System.Windows.Forms.TextBox raizOp;
        private System.Windows.Forms.TextBox potenciaGrado;
        private System.Windows.Forms.TextBox potenciaOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fasoresOpB;
        private System.Windows.Forms.TextBox fasoresOpA;

    }
}

