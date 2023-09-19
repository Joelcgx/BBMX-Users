namespace BBMX_Users
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Eventos HAndler
            btn_log_in.Click += new EventHandler(iniciar_sesion);
            btn_cancel.Click += new EventHandler(salir);
        }
        //Funcion de los widgets
        private void iniciar_sesion(object sender, EventArgs e)
        {

        }
        private void salir(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Realmente desea salir?", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // No haces nada aquí y el cuadro de mensaje se cierra
            }
        }
    }
}