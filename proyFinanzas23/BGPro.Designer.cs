namespace proyFinanzas23
{
    partial class BGPro
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            Calcular = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 80;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cuenta";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Monto";
            Column2.Name = "Column2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(170, 53);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Monto";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(170, 91);
            maskedTextBox1.Mask = "999999999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.FromArgb(20, 20, 20);
            Calcular.FlatAppearance.BorderColor = Color.Black;
            Calcular.FlatStyle = FlatStyle.Flat;
            Calcular.ForeColor = Color.White;
            Calcular.Location = new Point(344, 84);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 30);
            Calcular.TabIndex = 5;
            Calcular.Text = "Agregar";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(942, 62);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 18;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 20, 20);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(910, 91);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 20;
            button5.Text = "Borrar todo Activo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(20, 20, 20);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(942, 33);
            button6.Name = "button6";
            button6.Size = new Size(93, 23);
            button6.TabIndex = 22;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // BGPro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(Calcular);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ForeColor = Color.White;
            Name = "BGPro";
            Text = "BGPro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Button Calcular;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}