namespace proyFinanzas23
{
    partial class MAnalisisV
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
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(71, 25);
            button4.TabIndex = 5;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(72, 61);
            button1.Name = "button1";
            button1.Size = new Size(335, 68);
            button1.TabIndex = 6;
            button1.Text = "Balance General";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 154);
            button2.Name = "button2";
            button2.Size = new Size(335, 78);
            button2.TabIndex = 7;
            button2.Text = "Estado Resultado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 37);
            label1.TabIndex = 8;
            label1.Text = "Seleccione una opcion:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MAnalisisV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 325);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            MaximizeBox = false;
            Name = "MAnalisisV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAnalisisV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}