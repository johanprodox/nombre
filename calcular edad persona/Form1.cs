namespace calcular_edad_persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;
            if(fechaActual < dtpFechaNacimientou.Vale.AddYears(edad)) edad--;
            lblEdad.Text = "Tienes" + edad.ToString() + " años";

        }
    }
}