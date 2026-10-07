using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            if (lstDatos.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un valor");
            }
            else
            {
                MessageBox.Show($"El indice es {lstDatos.SelectedIndex.ToString()} ");
            }    
        }

        private void btnElemento_Click(object sender, EventArgs e)
        {
            if (lstDatos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un valor");
            }
            else
            {
                MessageBox.Show($"El elemento  es {lstDatos.Text} ");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.RemoveAt(lstDatos.SelectedIndex);
        }

        private void lstDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult resp;
            if (lstDatos.Items.Count==0)
            {
                MessageBox.Show("No existe mas elementos");
            }
            else { 
                resp = MessageBox.Show("Seguro para Eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                lstDatos.Items.RemoveAt(lstDatos.SelectedIndex);
            }
            }

        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            lstDatos2.Items.AddRange(lstDatos.Items);
        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Insert(1,"Hola");
        }
    }
}
