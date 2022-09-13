using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{
    public partial class frmPesoIdeal : Form
    {
        public frmPesoIdeal()
        {
            InitializeComponent();
        }

    }
}

namespace ProjetoPesoIdeal
{
        public partial class CalculoDePesoIdeal : Form
        {
           private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
           {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }

            RadioButton rbnSelecionado = null;
           }

        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal;
                if (rbnSelecionado.Text.Equals("Masculino"))
                    pesoIdeal = (72.7 * altura) - 58;
                else
                    pesoIdeal = (62.1 * altura) - 44.7;
                lblPesoIdeal.Text = pesoIdeal.ToString("N");
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

    }
    
    }
}   

