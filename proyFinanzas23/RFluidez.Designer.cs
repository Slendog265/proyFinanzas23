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
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
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
            button1.Location = new Point(404, 138);
            button1.Name = "button1";
            button1.Size = new Size(97, 61);
            button1.TabIndex = 0;
            button1.Text = "Calcular Razon \r\nSolvencia Actual";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 404);
            button2.Name = "button2";
            button2.Size = new Size(100, 61);
            button2.TabIndex = 1;
            button2.Text = "Calcular Razon\r\nPrueba Rapida\r\nActual";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RdS, RPR, Column1 });
            dataGridView1.Location = new Point(49, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(337, 155);
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
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(70, 26);
            button3.TabIndex = 3;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Activo Circulante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 54);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Pasivo Circulante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 310);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Inventario";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(651, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(49, 74);
            maskedTextBox1.Mask = "99999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(166, 74);
            maskedTextBox2.Mask = "99999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // button4
            // 
            button4.Location = new Point(404, 205);
            button4.Name = "button4";
            button4.Size = new Size(97, 61);
            button4.TabIndex = 11;
            button4.Text = "Calcular Razon \r\nSolvencia Base";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(413, 471);
            button5.Name = "button5";
            button5.Size = new Size(100, 61);
            button5.TabIndex = 12;
            button5.Text = "Calcular Razon\r\nPrueba Rapida\r\nBase";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dataGridView2.Location = new Point(54, 366);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(344, 180);
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
            maskedTextBox4.Location = new Point(54, 328);
            maskedTextBox4.Mask = "99999";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 14;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(168, 328);
            maskedTextBox5.Mask = "99999";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 15;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(298, 328);
            maskedTextBox6.Mask = "99999";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(100, 23);
            maskedTextBox6.TabIndex = 16;
            maskedTextBox6.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 310);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 17;
            label4.Text = "Pasivo Circulante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 310);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 18;
            label5.Text = "Activo Circulante";
            // 
            // button6
            // 
            button6.Location = new Point(519, 404);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 19;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(519, 433);
            button7.Name = "button7";
            button7.Size = new Size(75, 21);
            button7.TabIndex = 20;
            button7.Text = "Borrar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(507, 167);
            button8.Name = "button8";
            button8.Size = new Size(75, 21);
            button8.TabIndex = 22;
            button8.Text = "Borrar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(507, 138);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 21;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // RFluidez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 558);
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
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RFluidez";
            Text = "RFluidez";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
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