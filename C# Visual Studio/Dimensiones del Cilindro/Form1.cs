namespace dimensionescilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double Radius, Height;
            double BaseArea, LateralArea, TotalArea;
            double Volume;

            Radius = double.Parse(textBox1.Text);
            Height = double.Parse(textBox2.Text);

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;

            textBox3.Text = BaseArea.ToString("0.##");
            textBox4.Text = LateralArea.ToString("0.##");
            textBox5.Text = TotalArea.ToString("0.##");
            textBox6.Text = Volume.ToString("0.##");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus(); // Pone el cursor de nuevo en el recuadro del radio
        }

        public void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}