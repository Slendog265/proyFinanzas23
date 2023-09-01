namespace proyFinanzas23
{
    partial class BGV
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
            account = new DataGridViewTextBoxColumn();
            Vaa = new DataGridViewTextBoxColumn();
            perAa = new DataGridViewTextBoxColumn();
            Vab = new DataGridViewTextBoxColumn();
            perAb = new DataGridViewTextBoxColumn();
            accounBox = new TextBox();
            VaaBox = new TextBox();
            VabBox = new TextBox();
            TcaBox = new TextBox();
            tcbBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button7 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { account, Vaa, perAa, Vab, perAb });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 480);
            dataGridView1.TabIndex = 2;
            // 
            // account
            // 
            account.HeaderText = "Cuenta";
            account.Name = "account";
            // 
            // Vaa
            // 
            Vaa.HeaderText = "Valor Año Analisis";
            Vaa.Name = "Vaa";
            // 
            // perAa
            // 
            perAa.HeaderText = "%";
            perAa.Name = "perAa";
            // 
            // Vab
            // 
            Vab.HeaderText = "Valor Año Base";
            Vab.Name = "Vab";
            // 
            // perAb
            // 
            perAb.HeaderText = "%";
            perAb.Name = "perAb";
            // 
            // accounBox
            // 
            accounBox.Location = new Point(12, 83);
            accounBox.Name = "accounBox";
            accounBox.Size = new Size(100, 23);
            accounBox.TabIndex = 3;
            // 
            // VaaBox
            // 
            VaaBox.Location = new Point(162, 83);
            VaaBox.Name = "VaaBox";
            VaaBox.Size = new Size(100, 23);
            VaaBox.TabIndex = 4;
            // 
            // VabBox
            // 
            VabBox.Location = new Point(310, 83);
            VabBox.Name = "VabBox";
            VabBox.Size = new Size(100, 23);
            VabBox.TabIndex = 5;
            // 
            // TcaBox
            // 
            TcaBox.Location = new Point(431, 83);
            TcaBox.Name = "TcaBox";
            TcaBox.Size = new Size(100, 23);
            TcaBox.TabIndex = 6;
            // 
            // tcbBox
            // 
            tcbBox.Location = new Point(561, 83);
            tcbBox.Name = "tcbBox";
            tcbBox.Size = new Size(100, 23);
            tcbBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 46);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 9;
            label2.Text = "Valor Año \r\nAnalisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(310, 46);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 10;
            label3.Text = "Valor Año \r\nBase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(431, 46);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 11;
            label4.Text = "Total Cuenta \r\nAnalisis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(561, 46);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 12;
            label5.Text = "Total Cuenta\r\nBase";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(698, 46);
            button1.Name = "button1";
            button1.Size = new Size(99, 30);
            button1.TabIndex = 13;
            button1.Text = "Agregar Activo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(698, 84);
            button2.Name = "button2";
            button2.Size = new Size(99, 30);
            button2.TabIndex = 14;
            button2.Text = "Agregar Pasivo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button3.TabIndex = 16;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(20, 20, 20);
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(910, 91);
            button7.Name = "button7";
            button7.Size = new Size(125, 23);
            button7.TabIndex = 20;
            button7.Text = "Borrar todo";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            button6.TabIndex = 23;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // BGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tcbBox);
            Controls.Add(TcaBox);
            Controls.Add(VabBox);
            Controls.Add(VaaBox);
            Controls.Add(accounBox);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BGV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn account;
        private DataGridViewTextBoxColumn Vaa;
        private DataGridViewTextBoxColumn perAa;
        private DataGridViewTextBoxColumn Vab;
        private DataGridViewTextBoxColumn perAb;
        private TextBox accounBox;
        private TextBox VaaBox;
        private TextBox VabBox;
        private TextBox TcaBox;
        private TextBox tcbBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button button6;
        private Panel panel1;
        public PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}