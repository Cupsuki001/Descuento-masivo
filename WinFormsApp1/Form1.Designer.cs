namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Credito");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Contado");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Facrura", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.TREEVfactura = new System.Windows.Forms.TreeView();
            this.TXBdescuento = new System.Windows.Forms.TextBox();
            this.CHKBXdescuento = new System.Windows.Forms.CheckBox();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXBtotal = new System.Windows.Forms.TextBox();
            this.MASKEDventa = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TREEVfactura
            // 
            this.TREEVfactura.Location = new System.Drawing.Point(12, 25);
            this.TREEVfactura.Name = "TREEVfactura";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Credito";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Contado";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "Facrura";
            this.TREEVfactura.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.TREEVfactura.Size = new System.Drawing.Size(138, 69);
            this.TREEVfactura.TabIndex = 0;
            this.TREEVfactura.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREEVfactura_AfterSelect);
            // 
            // TXBdescuento
            // 
            this.TXBdescuento.BackColor = System.Drawing.Color.Honeydew;
            this.TXBdescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBdescuento.Location = new System.Drawing.Point(220, 75);
            this.TXBdescuento.Name = "TXBdescuento";
            this.TXBdescuento.Size = new System.Drawing.Size(100, 23);
            this.TXBdescuento.TabIndex = 2;
            // 
            // CHKBXdescuento
            // 
            this.CHKBXdescuento.AutoSize = true;
            this.CHKBXdescuento.BackColor = System.Drawing.Color.DarkTurquoise;
            this.CHKBXdescuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CHKBXdescuento.Location = new System.Drawing.Point(32, 182);
            this.CHKBXdescuento.Name = "CHKBXdescuento";
            this.CHKBXdescuento.Size = new System.Drawing.Size(93, 19);
            this.CHKBXdescuento.TabIndex = 4;
            this.CHKBXdescuento.Text = "DESCUENTO";
            this.CHKBXdescuento.UseVisualStyleBackColor = false;
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNcalcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BTNcalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNcalcular.Location = new System.Drawing.Point(224, 223);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 5;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = false;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNlimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BTNlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNlimpiar.Location = new System.Drawing.Point(335, 223);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 6;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = false;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNsalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BTNsalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNsalir.Location = new System.Drawing.Point(446, 223);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 7;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXBtotal);
            this.groupBox1.Controls.Add(this.MASKEDventa);
            this.groupBox1.Controls.Add(this.TXBdescuento);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(168, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "DESCUENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "SUBTOTAL VENTAS";
            // 
            // TXBtotal
            // 
            this.TXBtotal.BackColor = System.Drawing.Color.Honeydew;
            this.TXBtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBtotal.Location = new System.Drawing.Point(220, 127);
            this.TXBtotal.Name = "TXBtotal";
            this.TXBtotal.Size = new System.Drawing.Size(100, 23);
            this.TXBtotal.TabIndex = 13;
            // 
            // MASKEDventa
            // 
            this.MASKEDventa.BackColor = System.Drawing.Color.Honeydew;
            this.MASKEDventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MASKEDventa.Location = new System.Drawing.Point(220, 22);
            this.MASKEDventa.Mask = "99999";
            this.MASKEDventa.Name = "MASKEDventa";
            this.MASKEDventa.Size = new System.Drawing.Size(100, 23);
            this.MASKEDventa.TabIndex = 12;
            this.MASKEDventa.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "NINGUNO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 56);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ESTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(621, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.CHKBXdescuento);
            this.Controls.Add(this.TREEVfactura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView TREEVfactura;
        private TextBox TXBdescuento;
        private CheckBox CHKBXdescuento;
        private Button BTNcalcular;
        private Button BTNlimpiar;
        private Button BTNsalir;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TXBtotal;
        private MaskedTextBox MASKEDventa;
        private Label label5;
        private GroupBox groupBox2;
    }
}