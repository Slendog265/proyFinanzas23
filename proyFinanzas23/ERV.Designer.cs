namespace proyFinanzas23
{
    partial class ERV
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
            dataGridView1 = new DataGridView();
            account = new DataGridViewTextBoxColumn();
            Vaa = new DataGridViewTextBoxColumn();
            perAa = new DataGridViewTextBoxColumn();
            Vab = new DataGridViewTextBoxColumn();
            perAb = new DataGridViewTextBoxColumn();
            accountBox = new TextBox();
            vaaBox = new TextBox();
            vabBox = new TextBox();
            tovaBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tovbBox = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(77, 35);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { account, Vaa, perAa, Vab, perAb });
            dataGridView1.Location = new Point(12, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 167);
            dataGridView1.TabIndex = 3;
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
            // accountBox
            // 
            accountBox.Location = new Point(109, 55);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(100, 23);
            accountBox.TabIndex = 4;
            // 
            // vaaBox
            // 
            vaaBox.Location = new Point(238, 55);
            vaaBox.Name = "vaaBox";
            vaaBox.Size = new Size(100, 23);
            vaaBox.TabIndex = 5;
            // 
            // vabBox
            // 
            vabBox.Location = new Point(354, 55);
            vabBox.Name = "vabBox";
            vabBox.Size = new Size(100, 23);
            vabBox.TabIndex = 6;
            // 
            // tovaBox
            // 
            tovaBox.Location = new Point(470, 55);
            tovaBox.Name = "tovaBox";
            tovaBox.Size = new Size(100, 23);
            tovaBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 32);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 9;
            label2.Text = "Valor Año \r\nAnalisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 17);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 10;
            label3.Text = "Valor Año \r\nBase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 17);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 11;
            label4.Text = "Total Ventas \r\nAnalisis";
            // 
            // tovbBox
            // 
            tovbBox.Location = new Point(576, 55);
            tovbBox.Name = "tovbBox";
            tovbBox.Size = new Size(100, 23);
            tovbBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 12);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 13;
            label5.Text = "Total Ventas \r\nBase";
            // 
            // button2
            // 
            button2.Location = new Point(109, 98);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(600, 180);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 17;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(583, 209);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 19;
            button5.Text = "Borrar todo Activo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(600, 151);
            button6.Name = "button6";
            button6.Size = new Size(93, 23);
            button6.TabIndex = 24;
            button6.Text = "Guardar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ERV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(tovbBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tovaBox);
            Controls.Add(vabBox);
            Controls.Add(vaaBox);
            Controls.Add(accountBox);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "ERV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn account;
        private DataGridViewTextBoxColumn Vaa;
        private DataGridViewTextBoxColumn perAa;
        private DataGridViewTextBoxColumn Vab;
        private DataGridViewTextBoxColumn perAb;
        private TextBox accountBox;
        private TextBox vaaBox;
        private TextBox vabBox;
        private TextBox tovaBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tovbBox;
        private Label label5;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}