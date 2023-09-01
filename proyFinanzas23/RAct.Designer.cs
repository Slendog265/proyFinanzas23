namespace proyFinanzas23
{
    partial class RAct
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
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 72);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Activos Fijos";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 90);
            maskedTextBox1.Mask = "999999999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(164, 91);
            maskedTextBox2.Mask = "999999999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 175);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Rotación del Activo Fijo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Año Analisis";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Año base";
            Column3.Name = "Column3";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(342, 53);
            button2.Name = "button2";
            button2.Size = new Size(109, 61);
            button2.TabIndex = 6;
            button2.Text = "Calcular Rotación\r\n Activo Fijo Actual";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 20, 20);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(479, 53);
            button4.Name = "button4";
            button4.Size = new Size(109, 61);
            button4.TabIndex = 12;
            button4.Text = "Calcular Rotación\r\nActivo Fijo Base";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(20, 20, 20);
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(960, 60);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 22;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(20, 20, 20);
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(960, 89);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 23;
            button8.Text = "Borrar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new Point(11, 401);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1023, 175);
            dataGridView2.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Rotación del Activo Totales";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Año Analisis";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Año base";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(12, 372);
            maskedTextBox3.Mask = "999999999";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 25;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(164, 372);
            maskedTextBox4.Mask = "999999999";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 26;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 354);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 27;
            label3.Text = "Ventas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(164, 354);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 28;
            label4.Text = "Activos Totales";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(342, 334);
            button3.Name = "button3";
            button3.Size = new Size(109, 61);
            button3.TabIndex = 29;
            button3.Text = "Calcular Rotación\r\nActivo Totales Actual";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 20, 20);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(479, 331);
            button5.Name = "button5";
            button5.Size = new Size(109, 61);
            button5.TabIndex = 30;
            button5.Text = "Calcular Rotación Activo Totales Base";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(20, 20, 20);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(960, 343);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 31;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(20, 20, 20);
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(959, 372);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 32;
            button7.Text = "Borrar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // RAct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(dataGridView2);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RAct";
            Text = "RAct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button2;
        private Button button4;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}