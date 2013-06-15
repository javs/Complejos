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
            this.components = new System.ComponentModel.Container();
            this.lEstado = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.basicoResultado = new System.Windows.Forms.TextBox();
            this.basicoIgual = new System.Windows.Forms.Button();
            this.basicoOp = new System.Windows.Forms.ComboBox();
            this.basicoOpB = new System.Windows.Forms.TextBox();
            this.basicoOpA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.raizResultado = new System.Windows.Forms.TextBox();
            this.raizIgual = new System.Windows.Forms.Button();
            this.raizSeleccionar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raizGrado = new System.Windows.Forms.TextBox();
            this.raizOp = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.potenciaResultado = new System.Windows.Forms.TextBox();
            this.potenciaIgual = new System.Windows.Forms.Button();
            this.potenciaGrado = new System.Windows.Forms.TextBox();
            this.potenciaOp = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.primitivaResultado = new System.Windows.Forms.TextBox();
            this.primitivaIgual = new System.Windows.Forms.Button();
            this.primitivaSeleccionar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.primitivaGrado = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fasoresResultado = new System.Windows.Forms.TextBox();
            this.fasoresIgual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fasoresOpB = new System.Windows.Forms.TextBox();
            this.fasoresOpA = new System.Windows.Forms.TextBox();
            this.tEstado = new System.Windows.Forms.ToolTip(this.components);
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lEstado
            // 
            this.lEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.IndianRed;
            this.lEstado.Location = new System.Drawing.Point(325, 6);
            this.lEstado.Margin = new System.Windows.Forms.Padding(3);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(239, 19);
            this.lEstado.TabIndex = 4;
            this.lEstado.Text = "Estado";
            this.lEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Controls.Add(this.tabPage5);
            this.tabs.Location = new System.Drawing.Point(6, 6);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(560, 76);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.Operacion_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.basicoResultado);
            this.tabPage1.Controls.Add(this.basicoIgual);
            this.tabPage1.Controls.Add(this.basicoOp);
            this.tabPage1.Controls.Add(this.basicoOpB);
            this.tabPage1.Controls.Add(this.basicoOpA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comp: + - / *";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // basicoResultado
            // 
            this.basicoResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicoResultado.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoResultado.Location = new System.Drawing.Point(400, 6);
            this.basicoResultado.Name = "basicoResultado";
            this.basicoResultado.ReadOnly = true;
            this.basicoResultado.Size = new System.Drawing.Size(146, 39);
            this.basicoResultado.TabIndex = 6;
            this.basicoResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.basicoResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // basicoIgual
            // 
            this.basicoIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.basicoIgual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoIgual.Location = new System.Drawing.Point(355, 6);
            this.basicoIgual.Name = "basicoIgual";
            this.basicoIgual.Size = new System.Drawing.Size(39, 39);
            this.basicoIgual.TabIndex = 5;
            this.basicoIgual.Text = "=";
            this.basicoIgual.UseVisualStyleBackColor = true;
            this.basicoIgual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // basicoOp
            // 
            this.basicoOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basicoOp.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.basicoOp.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.basicoOp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // basicoOpB
            // 
            this.basicoOpB.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoOpB.Location = new System.Drawing.Point(203, 6);
            this.basicoOpB.Name = "basicoOpB";
            this.basicoOpB.Size = new System.Drawing.Size(147, 39);
            this.basicoOpB.TabIndex = 4;
            this.basicoOpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.basicoOpB.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.basicoOpB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // basicoOpA
            // 
            this.basicoOpA.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicoOpA.Location = new System.Drawing.Point(6, 6);
            this.basicoOpA.Name = "basicoOpA";
            this.basicoOpA.Size = new System.Drawing.Size(147, 39);
            this.basicoOpA.TabIndex = 2;
            this.basicoOpA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.basicoOpA.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.basicoOpA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.raizResultado);
            this.tabPage2.Controls.Add(this.raizIgual);
            this.tabPage2.Controls.Add(this.raizSeleccionar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.raizGrado);
            this.tabPage2.Controls.Add(this.raizOp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comp: ˣ√";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // raizResultado
            // 
            this.raizResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raizResultado.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizResultado.Location = new System.Drawing.Point(400, 6);
            this.raizResultado.Name = "raizResultado";
            this.raizResultado.ReadOnly = true;
            this.raizResultado.Size = new System.Drawing.Size(146, 39);
            this.raizResultado.TabIndex = 6;
            this.raizResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.raizResultado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.raizResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // raizIgual
            // 
            this.raizIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.raizIgual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizIgual.Location = new System.Drawing.Point(310, 6);
            this.raizIgual.Name = "raizIgual";
            this.raizIgual.Size = new System.Drawing.Size(39, 39);
            this.raizIgual.TabIndex = 4;
            this.raizIgual.Text = "=";
            this.raizIgual.UseVisualStyleBackColor = true;
            this.raizIgual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // raizSeleccionar
            // 
            this.raizSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raizSeleccionar.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizSeleccionar.FormattingEnabled = true;
            this.raizSeleccionar.Location = new System.Drawing.Point(355, 5);
            this.raizSeleccionar.Name = "raizSeleccionar";
            this.raizSeleccionar.Size = new System.Drawing.Size(39, 40);
            this.raizSeleccionar.TabIndex = 5;
            this.raizSeleccionar.SelectedIndexChanged += new System.EventHandler(this.raizSeleccionar_SelectedIndexChanged);
            this.raizSeleccionar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "√";
            // 
            // raizGrado
            // 
            this.raizGrado.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizGrado.Location = new System.Drawing.Point(6, 5);
            this.raizGrado.Name = "raizGrado";
            this.raizGrado.Size = new System.Drawing.Size(44, 26);
            this.raizGrado.TabIndex = 2;
            this.raizGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.raizGrado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.raizGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // raizOp
            // 
            this.raizOp.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizOp.Location = new System.Drawing.Point(95, 6);
            this.raizOp.Name = "raizOp";
            this.raizOp.Size = new System.Drawing.Size(209, 39);
            this.raizOp.TabIndex = 3;
            this.raizOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.raizOp.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.raizOp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.potenciaResultado);
            this.tabPage3.Controls.Add(this.potenciaIgual);
            this.tabPage3.Controls.Add(this.potenciaGrado);
            this.tabPage3.Controls.Add(this.potenciaOp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(552, 50);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comp: sˣ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // potenciaResultado
            // 
            this.potenciaResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.potenciaResultado.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaResultado.Location = new System.Drawing.Point(400, 6);
            this.potenciaResultado.Name = "potenciaResultado";
            this.potenciaResultado.ReadOnly = true;
            this.potenciaResultado.Size = new System.Drawing.Size(146, 39);
            this.potenciaResultado.TabIndex = 5;
            this.potenciaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.potenciaResultado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.potenciaResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // potenciaIgual
            // 
            this.potenciaIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.potenciaIgual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaIgual.Location = new System.Drawing.Point(355, 6);
            this.potenciaIgual.Name = "potenciaIgual";
            this.potenciaIgual.Size = new System.Drawing.Size(39, 39);
            this.potenciaIgual.TabIndex = 4;
            this.potenciaIgual.Text = "=";
            this.potenciaIgual.UseVisualStyleBackColor = true;
            this.potenciaIgual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // potenciaGrado
            // 
            this.potenciaGrado.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaGrado.Location = new System.Drawing.Point(305, 6);
            this.potenciaGrado.Name = "potenciaGrado";
            this.potenciaGrado.Size = new System.Drawing.Size(44, 26);
            this.potenciaGrado.TabIndex = 3;
            this.potenciaGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.potenciaGrado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.potenciaGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // potenciaOp
            // 
            this.potenciaOp.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaOp.Location = new System.Drawing.Point(3, 6);
            this.potenciaOp.Name = "potenciaOp";
            this.potenciaOp.Size = new System.Drawing.Size(296, 39);
            this.potenciaOp.TabIndex = 2;
            this.potenciaOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.potenciaOp.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.potenciaOp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.primitivaResultado);
            this.tabPage4.Controls.Add(this.primitivaIgual);
            this.tabPage4.Controls.Add(this.primitivaSeleccionar);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.primitivaGrado);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(552, 50);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Comp: ˣ√ prim";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // primitivaResultado
            // 
            this.primitivaResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primitivaResultado.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primitivaResultado.Location = new System.Drawing.Point(400, 6);
            this.primitivaResultado.Name = "primitivaResultado";
            this.primitivaResultado.ReadOnly = true;
            this.primitivaResultado.Size = new System.Drawing.Size(146, 39);
            this.primitivaResultado.TabIndex = 5;
            this.primitivaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.primitivaResultado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.primitivaResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // primitivaIgual
            // 
            this.primitivaIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.primitivaIgual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primitivaIgual.Location = new System.Drawing.Point(310, 6);
            this.primitivaIgual.Name = "primitivaIgual";
            this.primitivaIgual.Size = new System.Drawing.Size(39, 39);
            this.primitivaIgual.TabIndex = 3;
            this.primitivaIgual.Text = "=";
            this.primitivaIgual.UseVisualStyleBackColor = true;
            this.primitivaIgual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // primitivaSeleccionar
            // 
            this.primitivaSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primitivaSeleccionar.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primitivaSeleccionar.FormattingEnabled = true;
            this.primitivaSeleccionar.Location = new System.Drawing.Point(355, 5);
            this.primitivaSeleccionar.Name = "primitivaSeleccionar";
            this.primitivaSeleccionar.Size = new System.Drawing.Size(39, 40);
            this.primitivaSeleccionar.TabIndex = 4;
            this.primitivaSeleccionar.SelectedIndexChanged += new System.EventHandler(this.primitivaSeleccionar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "√1";
            // 
            // primitivaGrado
            // 
            this.primitivaGrado.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primitivaGrado.Location = new System.Drawing.Point(6, 5);
            this.primitivaGrado.Name = "primitivaGrado";
            this.primitivaGrado.Size = new System.Drawing.Size(44, 26);
            this.primitivaGrado.TabIndex = 2;
            this.primitivaGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.primitivaGrado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.primitivaGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.fasoresResultado);
            this.tabPage5.Controls.Add(this.fasoresIgual);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.fasoresOpB);
            this.tabPage5.Controls.Add(this.fasoresOpA);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(552, 50);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fasores";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // fasoresResultado
            // 
            this.fasoresResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fasoresResultado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasoresResultado.Location = new System.Drawing.Point(400, 12);
            this.fasoresResultado.Name = "fasoresResultado";
            this.fasoresResultado.ReadOnly = true;
            this.fasoresResultado.Size = new System.Drawing.Size(146, 26);
            this.fasoresResultado.TabIndex = 5;
            this.fasoresResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fasoresResultado.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.fasoresResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // fasoresIgual
            // 
            this.fasoresIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fasoresIgual.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasoresIgual.Location = new System.Drawing.Point(355, 6);
            this.fasoresIgual.Name = "fasoresIgual";
            this.fasoresIgual.Size = new System.Drawing.Size(39, 39);
            this.fasoresIgual.TabIndex = 4;
            this.fasoresIgual.Text = "=";
            this.fasoresIgual.UseVisualStyleBackColor = true;
            this.fasoresIgual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            // 
            // fasoresOpB
            // 
            this.fasoresOpB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasoresOpB.Location = new System.Drawing.Point(199, 12);
            this.fasoresOpB.Name = "fasoresOpB";
            this.fasoresOpB.Size = new System.Drawing.Size(151, 26);
            this.fasoresOpB.TabIndex = 3;
            this.fasoresOpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fasoresOpB.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.fasoresOpB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // fasoresOpA
            // 
            this.fasoresOpA.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasoresOpA.Location = new System.Drawing.Point(6, 12);
            this.fasoresOpA.Name = "fasoresOpA";
            this.fasoresOpA.Size = new System.Drawing.Size(151, 26);
            this.fasoresOpA.TabIndex = 2;
            this.fasoresOpA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fasoresOpA.TextChanged += new System.EventHandler(this.Operacion_TextChanged);
            this.fasoresOpA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Operacion_KeyPress);
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 87);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.tabs);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TextBox basicoResultado;
        private System.Windows.Forms.Button basicoIgual;
        private System.Windows.Forms.ComboBox raizSeleccionar;
        private System.Windows.Forms.TextBox raizResultado;
        private System.Windows.Forms.Button raizIgual;
        private System.Windows.Forms.TextBox potenciaResultado;
        private System.Windows.Forms.Button potenciaIgual;
        private System.Windows.Forms.TextBox fasoresResultado;
        private System.Windows.Forms.Button fasoresIgual;
        private System.Windows.Forms.ToolTip tEstado;
        private System.Windows.Forms.TextBox primitivaResultado;
        private System.Windows.Forms.Button primitivaIgual;
        private System.Windows.Forms.ComboBox primitivaSeleccionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox primitivaGrado;

    }
}

