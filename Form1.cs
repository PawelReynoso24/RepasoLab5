namespace RepasoLab5
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();

        public Form1()
        {
            InitializeComponent();
        }

         private void CargarEmpleados()
         {
            FileStream stream = new FileStream("Empleado.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
            {
                Empleado empleado = new Empleado();
                empleado.Noempleado = Convert.ToInt16(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());

                empleados.Add(empleado);
            }

            reader.Close();
         }

        private void CargarAsistencias()
        {
            FileStream stream = new FileStream("Empleado.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Asistencia asistencia = new Asistencia();
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.Mes = reader.ReadLine();

                asistencias.Add(asistencia);
            }

            reader.Close();
        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = empleados;

            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = asistencias;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarAsistencias();
        }
    }
}