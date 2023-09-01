namespace proyFinanzas23
{
    partial class ERPro
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
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label7 = new Label();
            maskedTextBox7 = new MaskedTextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label9 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(148, 91);
            maskedTextBox2.Mask = "999999999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(276, 91);
            maskedTextBox3.Mask = "999999999";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 3;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(27, 25, 36);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 60);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(27, 25, 36);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 61);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Ventas Unitarias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(27, 25, 36);
            label3.ForeColor = Color.White;
            label3.Location = new Point(276, 60);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio de ventas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3 });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 175);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cuenta";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ventas Unitarías";
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio de Venta";
            Column6.Name = "Column6";
            // 
            // Column3
            // 
            Column3.HeaderText = "Ventas";
            Column3.Name = "Column3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(27, 25, 36);
            label4.ForeColor = Color.White;
            label4.Location = new Point(148, 321);
            label4.Name = "label4";
            label4.Size = new Size(97, 45);
            label4.TabIndex = 8;
            label4.Text = "Costos de Bienes\r\nEstado Resultado\r\n Actual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(27, 25, 36);
            label5.ForeColor = Color.White;
            label5.Location = new Point(274, 321);
            label5.Name = "label5";
            label5.Size = new Size(102, 45);
            label5.TabIndex = 9;
            label5.Text = "Gastos Operativos\r\nEstado Resultado\r\nActual";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(27, 25, 36);
            label6.ForeColor = Color.White;
            label6.Location = new Point(395, 321);
            label6.Name = "label6";
            label6.Size = new Size(97, 45);
            label6.TabIndex = 10;
            label6.Text = "Gastos Intereses\r\nEstado Resultado\r\nActual";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5 });
            dataGridView2.Location = new Point(11, 401);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1023, 175);
            dataGridView2.TabIndex = 11;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cuenta";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Monto";
            Column5.Name = "Column5";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(148, 372);
            maskedTextBox4.Mask = "999999999";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 12;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(276, 372);
            maskedTextBox5.Mask = "999999999";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 13;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(395, 372);
            maskedTextBox6.Mask = "999999999";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(100, 23);
            maskedTextBox6.TabIndex = 14;
            maskedTextBox6.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(422, 69);
            button1.Name = "button1";
            button1.Size = new Size(118, 45);
            button1.TabIndex = 15;
            button1.Text = "Calcular \r\nPronostico Ventas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(768, 351);
            button2.Name = "button2";
            button2.Size = new Size(107, 44);
            button2.TabIndex = 16;
            button2.Text = "Calcular \r\nEstado Resultado";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(562, 90);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 18;
            button3.Text = "Sumar Ventas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(27, 25, 36);
            label7.ForeColor = Color.White;
            label7.Location = new Point(523, 343);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 19;
            label7.Text = "Impuestos";
            // 
            // maskedTextBox7
            // 
            maskedTextBox7.Location = new Point(645, 372);
            maskedTextBox7.Mask = "999999999";
            maskedTextBox7.Name = "maskedTextBox7";
            maskedTextBox7.Size = new Size(100, 23);
            maskedTextBox7.TabIndex = 21;
            maskedTextBox7.ValidatingType = typeof(int);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(27, 25, 36);
            label8.ForeColor = Color.White;
            label8.Location = new Point(645, 343);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 22;
            label8.Text = "Dividendos Acciones";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(523, 372);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 372);
            maskedTextBox1.Mask = "999999999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 24;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(27, 25, 36);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 336);
            label9.Name = "label9";
            label9.Size = new Size(44, 30);
            label9.TabIndex = 25;
            label9.Text = "Ventas\r\n Actual";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 20, 20);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(960, 56);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 26;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 20, 20);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(960, 343);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 27;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(20, 20, 20);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(960, 91);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 28;
            button6.Text = "Borrar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(20, 20, 20);
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(960, 372);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 29;
            button7.Text = "Borrar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // ERPro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(maskedTextBox7);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox6);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            ForeColor = Color.White;
            Name = "ERPro";
            Text = "ERPro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBox1;
        private Button button3;
        private Label label7;
        private MaskedTextBox maskedTextBox7;
        private Label label8;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}