namespace conversiontemperaturas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            valor = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            Resultado = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(valor);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Eras Medium ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 76);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // valor
            // 
            valor.Location = new Point(134, 28);
            valor.Name = "valor";
            valor.Size = new Size(121, 26);
            valor.TabIndex = 1;
            valor.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eras Medium ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingresa Valor:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Eras Medium ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 106);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones de Conversión";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Eras Bold ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(74, 68);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 2;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Eras Bold ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(152, 28);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 1;
            button2.Text = "CENTÍGRADOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Eras Bold ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 28);
            button1.Name = "button1";
            button1.Size = new Size(133, 34);
            button1.TabIndex = 0;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Resultado);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Eras Medium ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(25, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 104);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado en Grados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 32);
            label2.Name = "label2";
            label2.Size = new Size(178, 19);
            label2.TabIndex = 0;
            label2.Text = "Equivalente en Grados:";
            label2.Click += label2_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(61, 63);
            Resultado.Name = "Resultado";
            Resultado.ReadOnly = true;
            Resultado.Size = new Size(143, 26);
            Resultado.TabIndex = 1;
            Resultado.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 325);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversiones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox valor;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button3;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox Resultado;
    }
}
