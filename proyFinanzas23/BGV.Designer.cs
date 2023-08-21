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
            Back = new Button();
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
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(80, 31);
            Back.TabIndex = 1;
            Back.Text = "Volver";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { account, Vaa, perAa, Vab, perAb });
            dataGridView1.Location = new Point(12, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 167);
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
            accounBox.Location = new Point(86, 67);
            accounBox.Name = "accounBox";
            accounBox.Size = new Size(100, 23);
            accounBox.TabIndex = 3;
            // 
            // VaaBox
            // 
            VaaBox.Location = new Point(201, 67);
            VaaBox.Name = "VaaBox";
            VaaBox.Size = new Size(100, 23);
            VaaBox.TabIndex = 4;
            // 
            // VabBox
            // 
            VabBox.Location = new Point(332, 67);
            VabBox.Name = "VabBox";
            VabBox.Size = new Size(100, 23);
            VabBox.TabIndex = 5;
            // 
            // TcaBox
            // 
            TcaBox.Location = new Point(455, 67);
            TcaBox.Name = "TcaBox";
            TcaBox.Size = new Size(100, 23);
            TcaBox.TabIndex = 6;
            // 
            // tcbBox
            // 
            tcbBox.Location = new Point(561, 67);
            tcbBox.Name = "tcbBox";
            tcbBox.Size = new Size(100, 23);
            tcbBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 31);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 9;
            label2.Text = "Valor Año \r\nAnalisis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 31);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 10;
            label3.Text = "Valor Año \r\nBase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 31);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 11;
            label4.Text = "Total Cuenta \r\nAnalisis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 31);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 12;
            label5.Text = "Total Cuenta\r\nBase";
            // 
            // button1
            // 
            button1.Location = new Point(87, 112);
            button1.Name = "button1";
            button1.Size = new Size(99, 30);
            button1.TabIndex = 13;
            button1.Text = "Agregar Activo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 112);
            button2.Name = "button2";
            button2.Size = new Size(99, 30);
            button2.TabIndex = 14;
            button2.Text = "Agregar Pasivo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(12, 364);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(543, 167);
            dataGridView2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Valor Año Analisis";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "%";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Valor Año Base";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "%";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button3
            // 
            button3.Location = new Point(582, 176);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 16;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(582, 364);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 17;
            button4.Text = "Borrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(572, 205);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 18;
            button5.Text = "Borrar todo Activo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(572, 393);
            button6.Name = "button6";
            button6.Size = new Size(125, 23);
            button6.TabIndex = 19;
            button6.Text = "Borrar todo Pasivo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(572, 517);
            button7.Name = "button7";
            button7.Size = new Size(125, 23);
            button7.TabIndex = 20;
            button7.Text = "Borrar todo";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // BGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 552);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
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
            Controls.Add(Back);
            MaximizeBox = false;
            Name = "BGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BGV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
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
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}