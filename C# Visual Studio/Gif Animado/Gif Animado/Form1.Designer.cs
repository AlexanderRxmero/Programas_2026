namespace GifAnimado
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.animacion;
            pictureBox1.Location = new Point(176, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 343);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cute Dino", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 367);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 1;
            label1.Text = "Gif Animado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cute Dino", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(250, 390);
            label2.Name = "label2";
            label2.Size = new Size(356, 23);
            label2.TabIndex = 2;
            label2.Text = "Autor: Alexander Romero Ramirez";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Eras Bold ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(368, 416);
            button1.Name = "button1";
            button1.Size = new Size(100, 26);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gif Animado";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
