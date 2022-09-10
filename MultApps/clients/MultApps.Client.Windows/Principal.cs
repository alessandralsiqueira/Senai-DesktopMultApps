using MultApps.Client.Windows.Funcionalidades;

namespace MultApps.Client.Windows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAbrirFormMatriculaAluno_Click(object sender, EventArgs e)
        {
            var form = new frmMatriculaAluno();
            form.Show();
        }

        private void btnAbrirFormPesoIdeal_Click(object sender, EventArgs e)
        {
            var form = new frmPesoIdeal();
            form.Show();
        }

        private void btnAbrirFormReajusteSalarial_Click(object sender, EventArgs e)
        {
            var form = new frmReajusteSalarial();
            form.Show();
        }
    }
}