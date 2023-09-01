namespace proyFinanzas23
{
    partial class RFluidez
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            RdS = new DataGridViewTextBoxColumn();
            RPR = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            button4 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(612, 334);
            button1.Name = "button1";
            button1.Size = new Size(97, 61);
            button1.TabIndex = 0;
            button1.Text = "Calcular Razon \r\nSolvencia Actual";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(609, 50);
            button2.Name = "button2";
            button2.Size = new Size(100, 61);
            button2.TabIndex = 1;
            button2.Text = "Calcular Razon\r\nPrueba Rapida\r\nActual";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RdS, RPR, Column1 });
            dataGridView1.Location = new Point(11, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 175);
            dataGridView1.TabIndex = 2;
            // 
            // RdS
            // 
            RdS.HeaderText = "Ratio de Solvencia";
            RdS.Name = "RdS";
            // 
            // RPR
            // 
            RPR.HeaderText = "Año Analisis";
            RPR.Name = "RPR";
            // 
            // Column1
            // 
            Column1.HeaderText = "Año Base";
            Column1.Name = "Column1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 73);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Activo Circulante";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(166, 73);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Pasivo Circulante";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(310, 348);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Inventario";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 91);
            maskedTextBox1.Mask = "999999999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(166, 91);
            maskedTextBox2.Mask = "999999999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 20, 20);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(474, 334);
            button4.Name = "button4";
            button4.Size = new Size(97, 61);
            button4.TabIndex = 11;
            button4.Text = "Calcular Razon \r\nSolvencia Base";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 20, 20);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(471, 50);
            button5.Name = "button5";
            button5.Size = new Size(100, 61);
            button5.TabIndex = 12;
            button5.Text = "Calcular Razon\r\nPrueba Rapida\r\nBase";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dataGridView2.Location = new Point(11, 120);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1023, 175);
            dataGridView2.TabIndex = 13;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ratio Prueba Rapida";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Año Analisis";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Año Base";
            Column4.Name = "Column4";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(14, 372);
            maskedTextBox4.Mask = "999999999";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 14;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(168, 372);
            maskedTextBox5.Mask = "999999999";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 15;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(310, 372);
            maskedTextBox6.Mask = "999999999";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(100, 23);
            maskedTextBox6.TabIndex = 16;
            maskedTextBox6.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(168, 348);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 17;
            label4.Text = "Pasivo Circulante";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 348);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 18;
            label5.Text = "Activo Circulante";
            label5.Click += label5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(20, 20, 20);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(960, 345);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 19;
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
            button7.Location = new Point(960, 374);
            button7.Name = "button7";
            button7.Size = new Size(75, 21);
            button7.TabIndex = 20;
            button7.Text = "Borrar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(20, 20, 20);
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(960, 94);
            button8.Name = "button8";
            button8.Size = new Size(75, 21);
            button8.TabIndex = 22;
            button8.Text = "Borrar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(20, 20, 20);
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(960, 65);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 21;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // RFluidez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBox6);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox4);
            Controls.Add(dataGridView2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RFluidez";
            Text = "RFluidez";
            Load += RFluidez_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private DataGridViewTextBoxColumn RdS;
        private DataGridViewTextBoxColumn RPR;
        private DataGridViewTextBoxColumn Column1;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView2;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}