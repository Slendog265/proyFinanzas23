namespace proyFinanzas23
{
    partial class resgiBG
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
            Act = new DataGridViewTextBoxColumn();
            VAA = new DataGridViewTextBoxColumn();
            VAB = new DataGridViewTextBoxColumn();
            AumDis = new DataGridViewTextBoxColumn();
            perAD = new DataGridViewTextBoxColumn();
            perAA = new DataGridViewTextBoxColumn();
            perAB = new DataGridViewTextBoxColumn();
            acc = new Label();
            accountBox = new TextBox();
            label1 = new Label();
            vaaBox = new TextBox();
            vabBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            TotABox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TotbBox = new TextBox();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Act, VAA, VAB, AumDis, perAD, perAA, perAB });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 480);
            dataGridView1.TabIndex = 1;
            // 
            // Act
            // 
            Act.HeaderText = "Cuentas";
            Act.Name = "Act";
            // 
            // VAA
            // 
            VAA.HeaderText = "Valor Año Analisis";
            VAA.Name = "VAA";
            // 
            // VAB
            // 
            VAB.HeaderText = "Valor Año Base";
            VAB.Name = "VAB";
            // 
            // AumDis
            // 
            AumDis.HeaderText = "Aumento Disminución";
            AumDis.Name = "AumDis";
            // 
            // perAD
            // 
            perAD.HeaderText = "AD %";
            perAD.Name = "perAD";
            // 
            // perAA
            // 
            perAA.HeaderText = "%";
            perAA.Name = "perAA";
            // 
            // perAB
            // 
            perAB.HeaderText = "%";
            perAB.Name = "perAB";
            // 
            // acc
            // 
            acc.AutoSize = true;
            acc.ForeColor = Color.White;
            acc.Location = new Point(12, 66);
            acc.Name = "acc";
            acc.Size = new Size(45, 15);
            acc.TabIndex = 3;
            acc.Text = "Cuenta";
            // 
            // accountBox
            // 
            accountBox.Location = new Point(12, 91);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(100, 23);
            accountBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 66);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor Año Analisis";
            // 
            // vaaBox
            // 
            vaaBox.Location = new Point(169, 91);
            vaaBox.Name = "vaaBox";
            vaaBox.Size = new Size(100, 23);
            vaaBox.TabIndex = 6;
            // 
            // vabBox
            // 
            vabBox.Location = new Point(323, 91);
            vabBox.Name = "vabBox";
            vabBox.Size = new Size(100, 23);
            vabBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(323, 66);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Valor Año Base";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(727, 62);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
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
            button2.Location = new Point(727, 91);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 10;
            button2.Text = "Agregar Pasivo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TotABox
            // 
            TotABox.Location = new Point(468, 91);
            TotABox.Name = "TotABox";
            TotABox.Size = new Size(100, 23);
            TotABox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(469, 54);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 13;
            label3.Text = "Total de la cuenta\r\n Analisis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(596, 55);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 14;
            label4.Text = "Total de la cuenta \r\nBase";
            // 
            // TotbBox
            // 
            TotbBox.Location = new Point(596, 91);
            TotbBox.Name = "TotbBox";
            TotbBox.Size = new Size(100, 23);
            TotbBox.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(942, 61);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 17;
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
            button5.Location = new Point(910, 90);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 19;
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
            button6.Location = new Point(942, 32);
            button6.Name = "button6";
            button6.Size = new Size(93, 23);
            button6.TabIndex = 21;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // resgiBG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 36);
            ClientSize = new Size(1047, 602);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(TotbBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TotABox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(vabBox);
            Controls.Add(vaaBox);
            Controls.Add(label1);
            Controls.Add(accountBox);
            Controls.Add(acc);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "resgiBG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro BG";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label acc;
        private TextBox accountBox;
        private Label label1;
        private TextBox vaaBox;
        private TextBox vabBox;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox TotABox;
        private Label label3;
        private Label label4;
        private TextBox TotbBox;
        private Button button3;
        private Button button5;
        private Button button6;
        private DataGridViewTextBoxColumn Act;
        private DataGridViewTextBoxColumn VAA;
        private DataGridViewTextBoxColumn VAB;
        private DataGridViewTextBoxColumn AumDis;
        private DataGridViewTextBoxColumn perAD;
        private DataGridViewTextBoxColumn perAA;
        private DataGridViewTextBoxColumn perAB;
    }
}