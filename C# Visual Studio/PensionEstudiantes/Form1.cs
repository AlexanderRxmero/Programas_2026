using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PensiónEstudiantes
{
    public partial class Form1 : Form
    {
        // Ponemos la cadena aquí arriba para que TODOS la puedan usar fácilmente
        string cadena = "Server=localhost; Port=3306; Database=EscuelaDB; Uid=root; Pwd=Alexander.2006;";

        public Form1()
        {
            InitializeComponent();
            // Llenar el combo
            cboCategoria.Items.Add("A");
            cboCategoria.Items.Add("B");
            cboCategoria.Items.Add("C");
            cboCategoria.Items.Add("D");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    con.Open();
                    this.Text = "Pensión de Estudiantes - CONECTADO A MYSQL";
                    con.Close();
                }
                // Llamamos a cargar la tabla apenas abra el programa
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + ex.Message);
            }
        }

        // --- MÉTODO NUEVO PARA MOSTRAR LA TABLA EN EL CUADRO ---
        void CargarTabla()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    string query = "SELECT * FROM Alumnos";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // dgvAlumnos es el nombre del DataGridView en tu diseño
                    dgvAlumnos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el cuadro: " + ex.Message);
            }
        }

        void LimpiarControles()
        {
            txtPromedio.Clear();
            cboCategoria.SelectedIndex = -1;
            cboCategoria.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            lstR.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estás seguro de salir?", "Pensión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        string Valida()
        {
            if (cboCategoria.SelectedIndex == -1) return "Categoría";
            if (string.IsNullOrEmpty(txtPromedio.Text)) return "Promedio";
            return "";
        }

        void Imprimir(double pension, double descuento, double nuevaPension)
        {
            lstR.Clear();
            lstR.AppendText($"La Pensión es: " + pension.ToString("F2") + "\n");
            lstR.AppendText($"El descuento es: " + descuento.ToString("F2") + "\n");
            lstR.AppendText($"La Nueva Pensión es: " + nuevaPension.ToString("F2"));
        }

        void GuardarEnMySQL(string cat, double prom, double pen, double desc, double np)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Alumnos (categoria, promedio, pension, descuento, nueva_pension) VALUES (@cat, @prom, @pen, @desc, @npen)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@cat", cat);
                    cmd.Parameters.AddWithValue("@prom", prom);
                    cmd.Parameters.AddWithValue("@pen", pen);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@npen", np);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("¡Datos guardados en MySQL!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string error = Valida();
            if (error == "")
            {
                try
                {
                    Pension objP = new Pension();
                    objP.categoria = cboCategoria.SelectedIndex;
                    objP.promedio = double.Parse(txtPromedio.Text);

                    double p = objP.determinaPension();
                    double d = objP.calculaDescuento();
                    double np = objP.determinaNuevaPension();

                    Imprimir(p, d, np);
                    GuardarEnMySQL(cboCategoria.Text, objP.promedio, p, d, np);

                    // IMPORTANTE: Después de guardar, refrescamos el cuadro
                    CargarTabla();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese un número válido en el promedio.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPromedio.Clear();
                    txtPromedio.Focus();
                }
            }
            else
            {
                MessageBox.Show("El error está en: " + error, "Pensión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este es para un botón extra si quieres "refrescar" manualmente
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        // Otros eventos vacíos que tenías
        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}