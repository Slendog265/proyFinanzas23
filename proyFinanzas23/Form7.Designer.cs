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
            Back = new Button();
            dataGridView1 = new DataGridView();
            Act = new DataGridViewTextBoxColumn();
            VAA = new DataGridViewTextBoxColumn();
            VAB = new DataGridViewTextBoxColumn();
            AumDis = new DataGridViewTextBoxColumn();
            perAD = new DataGridViewTextBoxColumn();
            perAA = new DataGridViewTextBoxColumn();
            perAB = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            PyC = new DataGridViewTextBoxColumn();
            VAAP = new DataGridViewTextBoxColumn();
            VABP = new DataGridViewTextBoxColumn();
            perAP = new DataGridViewTextBoxColumn();
            ADP = new DataGridViewTextBoxColumn();
            perADP = new DataGridViewTextBoxColumn();
            perBP = new DataGridViewTextBoxColumn();
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
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(80, 31);
            Back.TabIndex = 0;
            Back.Text = "Volver";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Act, VAA, VAB, AumDis, perAD, perAA, perAB });
            dataGridView1.Location = new Point(2, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 252);
            dataGridView1.TabIndex = 1;
            // 
            // Act
            // 
            Act.HeaderText = "Activos";
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { PyC, VAAP, VABP, perAP, ADP, perADP, perBP });
            dataGridView2.Location = new Point(4, 388);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(743, 252);
            dataGridView2.TabIndex = 2;
            // 
            // PyC
            // 
            PyC.HeaderText = "Pasivos y Capital";
            PyC.Name = "PyC";
            // 
            // VAAP
            // 
            VAAP.HeaderText = "Valor Año Analisis";
            VAAP.Name = "VAAP";
            // 
            // VABP
            // 
            VABP.HeaderText = "Valor Año Base";
            VABP.Name = "VABP";
            // 
            // perAP
            // 
            perAP.HeaderText = "%";
            perAP.Name = "perAP";
            // 
            // ADP
            // 
            ADP.HeaderText = "Aumento Disminución";
            ADP.Name = "ADP";
            // 
            // perADP
            // 
            perADP.HeaderText = "AD %";
            perADP.Name = "perADP";
            // 
            // perBP
            // 
            perBP.HeaderText = "%";
            perBP.Name = "perBP";
            // 
            // acc
            // 
            acc.AutoSize = true;
            acc.Location = new Point(125, 20);
            acc.Name = "acc";
            acc.Size = new Size(45, 15);
            acc.TabIndex = 3;
            acc.Text = "Cuenta";
            // 
            // accountBox
            // 
            accountBox.Location = new Point(125, 38);
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(100, 23);
            accountBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor Año Analisis";
            // 
            // vaaBox
            // 
            vaaBox.Location = new Point(241, 38);
            vaaBox.Name = "vaaBox";
            vaaBox.Size = new Size(100, 23);
            vaaBox.TabIndex = 6;
            // 
            // vabBox
            // 
            vabBox.Location = new Point(362, 38);
            vabBox.Name = "vabBox";
            vabBox.Size = new Size(100, 23);
            vabBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 20);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Valor Año Base";
            // 
            // button1
            // 
            button1.Location = new Point(125, 88);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar Activo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(241, 88);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 10;
            button2.Text = "Agregar Pasivo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TotABox
            // 
            TotABox.Location = new Point(468, 38);
            TotABox.Name = "TotABox";
            TotABox.Size = new Size(100, 23);
            TotABox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 5);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 13;
            label3.Text = "Total de la cuenta\r\n Analisis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 5);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 14;
            label4.Text = "Total de la cuenta \r\nBase";
            // 
            // TotbBox
            // 
            TotbBox.Location = new Point(586, 38);
            TotbBox.Name = "TotbBox";
            TotbBox.Size = new Size(100, 23);
            TotbBox.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(776, 130);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 17;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(776, 617);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 19;
            button5.Text = "Borrar todo Activo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(776, 388);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 20;
            button4.Text = "Borrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // resgiBG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 656);
            Controls.Add(button4);
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
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(Back);
            MaximizeBox = false;
            Name = "resgiBG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro BG";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label acc;
        private TextBox accountBox;
        private Label label1;
        private TextBox vaaBox;
        private TextBox vabBox;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Act;
        private DataGridViewTextBoxColumn VAA;
        private DataGridViewTextBoxColumn VAB;
        private DataGridViewTextBoxColumn AumDis;
        private DataGridViewTextBoxColumn perAD;
        private DataGridViewTextBoxColumn perAA;
        private DataGridViewTextBoxColumn perAB;
        private DataGridViewTextBoxColumn PyC;
        private DataGridViewTextBoxColumn VAAP;
        private DataGridViewTextBoxColumn VABP;
        private DataGridViewTextBoxColumn perAP;
        private DataGridViewTextBoxColumn ADP;
        private DataGridViewTextBoxColumn perADP;
        private DataGridViewTextBoxColumn perBP;
        private TextBox TotABox;
        private Label label3;
        private Label label4;
        private TextBox TotbBox;
        private Button button3;
        private Button button5;
        private Button button4;
    }
}