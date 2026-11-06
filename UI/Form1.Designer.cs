namespace UI
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
            groupBox1 = new GroupBox();
            btnAltaGuardar = new Button();
            btnAltaAgregar = new Button();
            txtAltaPrecio = new TextBox();
            txtAltaDesarrolladora = new TextBox();
            txtAltaDescripcion = new TextBox();
            txtAltaTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtModificacionId = new TextBox();
            label9 = new Label();
            btnModificar = new Button();
            txtModificacionPrecio = new TextBox();
            txtModificacionDesarrolladora = new TextBox();
            txtModificacionDescripcion = new TextBox();
            txtModificacionTitulo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnAltaGuardar);
            groupBox1.Controls.Add(btnAltaAgregar);
            groupBox1.Controls.Add(txtAltaPrecio);
            groupBox1.Controls.Add(txtAltaDesarrolladora);
            groupBox1.Controls.Add(txtAltaDescripcion);
            groupBox1.Controls.Add(txtAltaTitulo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta";
            // 
            // btnAltaGuardar
            // 
            btnAltaGuardar.AllowDrop = true;
            btnAltaGuardar.Location = new Point(275, 105);
            btnAltaGuardar.Name = "btnAltaGuardar";
            btnAltaGuardar.Size = new Size(92, 45);
            btnAltaGuardar.TabIndex = 9;
            btnAltaGuardar.Text = "Guardar";
            btnAltaGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAltaAgregar
            // 
            btnAltaAgregar.AllowDrop = true;
            btnAltaAgregar.Location = new Point(275, 23);
            btnAltaAgregar.Name = "btnAltaAgregar";
            btnAltaAgregar.Size = new Size(92, 45);
            btnAltaAgregar.TabIndex = 8;
            btnAltaAgregar.Text = "Agregar";
            btnAltaAgregar.UseVisualStyleBackColor = true;
            // 
            // txtAltaPrecio
            // 
            txtAltaPrecio.Location = new Point(148, 105);
            txtAltaPrecio.Name = "txtAltaPrecio";
            txtAltaPrecio.Size = new Size(100, 23);
            txtAltaPrecio.TabIndex = 7;
            // 
            // txtAltaDesarrolladora
            // 
            txtAltaDesarrolladora.Location = new Point(148, 72);
            txtAltaDesarrolladora.Name = "txtAltaDesarrolladora";
            txtAltaDesarrolladora.Size = new Size(100, 23);
            txtAltaDesarrolladora.TabIndex = 6;
            // 
            // txtAltaDescripcion
            // 
            txtAltaDescripcion.Location = new Point(148, 45);
            txtAltaDescripcion.Name = "txtAltaDescripcion";
            txtAltaDescripcion.Size = new Size(100, 23);
            txtAltaDescripcion.TabIndex = 5;
            // 
            // txtAltaTitulo
            // 
            txtAltaTitulo.Location = new Point(148, 18);
            txtAltaTitulo.Name = "txtAltaTitulo";
            txtAltaTitulo.Size = new Size(100, 23);
            txtAltaTitulo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 108);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 75);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Desarrolladora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 48);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtModificacionId);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(txtModificacionPrecio);
            groupBox2.Controls.Add(txtModificacionDesarrolladora);
            groupBox2.Controls.Add(txtModificacionDescripcion);
            groupBox2.Controls.Add(txtModificacionTitulo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 177);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificacion";
            // 
            // txtModificacionId
            // 
            txtModificacionId.Location = new Point(142, 141);
            txtModificacionId.Name = "txtModificacionId";
            txtModificacionId.Size = new Size(100, 23);
            txtModificacionId.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 144);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 20;
            label9.Text = "ID";
            // 
            // btnModificar
            // 
            btnModificar.AllowDrop = true;
            btnModificar.Location = new Point(275, 40);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 86);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtModificacionPrecio
            // 
            txtModificacionPrecio.Location = new Point(142, 108);
            txtModificacionPrecio.Name = "txtModificacionPrecio";
            txtModificacionPrecio.Size = new Size(100, 23);
            txtModificacionPrecio.TabIndex = 17;
            // 
            // txtModificacionDesarrolladora
            // 
            txtModificacionDesarrolladora.Location = new Point(142, 75);
            txtModificacionDesarrolladora.Name = "txtModificacionDesarrolladora";
            txtModificacionDesarrolladora.Size = new Size(100, 23);
            txtModificacionDesarrolladora.TabIndex = 16;
            // 
            // txtModificacionDescripcion
            // 
            txtModificacionDescripcion.Location = new Point(142, 48);
            txtModificacionDescripcion.Name = "txtModificacionDescripcion";
            txtModificacionDescripcion.Size = new Size(100, 23);
            txtModificacionDescripcion.TabIndex = 15;
            // 
            // txtModificacionTitulo
            // 
            txtModificacionTitulo.Location = new Point(142, 21);
            txtModificacionTitulo.Name = "txtModificacionTitulo";
            txtModificacionTitulo.Size = new Size(100, 23);
            txtModificacionTitulo.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 111);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 78);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 12;
            label6.Text = "Desarrolladora";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 51);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 11;
            label7.Text = "Descripcion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 24);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 10;
            label8.Text = "Titulo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(438, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(484, 347);
            dataGridView1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 140);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 10;
            label10.Text = "Categoria";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 23);
            comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAltaAgregar;
        private TextBox txtAltaPrecio;
        private TextBox txtAltaDesarrolladora;
        private TextBox txtAltaDescripcion;
        private TextBox txtAltaTitulo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnAltaGuardar;
        private TextBox txtModificacionId;
        private Label label9;
        private Button btnModificar;
        private TextBox txtModificacionPrecio;
        private TextBox txtModificacionDesarrolladora;
        private TextBox txtModificacionDescripcion;
        private TextBox txtModificacionTitulo;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label10;
    }
}
