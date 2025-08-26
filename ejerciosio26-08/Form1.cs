using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciosio26_08
{
    public partial class Form1 : Form
    {
        #region.variables
        public string prenda;
        public string accesorio;
        public string color;
        public int vendedor;
        #endregion
        #region.forms
        public Form1()
        {
            InitializeComponent();
        }

        private void RdbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            prenda = "camisa";
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
             
            
            carga();
            
        }

        private void RdbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            prenda = "Pantalon";
        }

        private void RdbRemera_CheckedChanged(object sender, EventArgs e)
        {
            prenda = "Remera";
        }

        private void RdbAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            color = "Amarillo";
        }

        private void RdbVerde_CheckedChanged(object sender, EventArgs e)
        {
            color = "Verde";
        }

        private void RdbAzul_CheckedChanged(object sender, EventArgs e)
        {
            color = "Azul";
        }

        private void RdbRojo_CheckedChanged(object sender, EventArgs e)
        {
            color = "rojo";
        }

        private void ChkBoxLentes_CheckedChanged(object sender, EventArgs e)
        {
            accesorio = "lentes";
        }

        private void ChkBoxAros_CheckedChanged(object sender, EventArgs e)
        {
            accesorio = "aros";
        }

        private void ChkBoxGorra_CheckedChanged(object sender, EventArgs e)
        {
            accesorio = "gorra";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cargarCombo();
                
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            ///este es el 3
            LstBoxVendedor3.Items.Clear();
        }

        private void BtnBorrar2_Click(object sender, EventArgs e)
        {
            LstVendedor2.Items.Clear();
        }
        

        private void BtnBorar1_Click(object sender, EventArgs e)
        {
            LstVendedor1.Items.Clear();
        }
        #endregion
        #region.Metodos
        void carga()
        {
            switch (vendedor)

            {
                case 1:
                    LstVendedor1.Items.Add(prenda);
                    LstVendedor1.Items.Add(accesorio);
                    LstVendedor1.Items.Add(color);
                    break;
                case 2:
                    LstVendedor2.Items.Add(prenda);
                    LstVendedor2.Items.Add(accesorio);
                    LstVendedor2.Items.Add(color);
                    break;
                case 3:
                    LstBoxVendedor3.Items.Add(prenda);
                    LstBoxVendedor3.Items.Add(accesorio);
                    LstBoxVendedor3.Items.Add(color);
                    break;
            }
        }
        void cargarCombo()
        {
            switch (comboBox1.Text)
            {
                case "VENDEDOR-1":
                    vendedor = 1;
                    break;
                case "VENDEDOR-2":
                    vendedor = 2;
                    break;
                case "VENDEDOR-3":
                    vendedor = 3;
                    break;

            }
        }
        #endregion
    }
}
