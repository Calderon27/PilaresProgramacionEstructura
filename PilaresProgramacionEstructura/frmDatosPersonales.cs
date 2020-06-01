using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgramacionEstructura
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //estructuras secuenciales
            string saludo = ""; //cadendas 
            saludo = this.txtNombres.Text + " " + this.txtApellido.Text;
            MessageBox.Show("Hola: " + saludo);

            //estructuras repetitivas
            string aux = "";

            for (int i = 0; i <= 10; i++)
            {
                aux = aux + saludo + System.Environment.NewLine;
            }
            this.txtResultado.Text = aux;

            //estructuras selectivas (condicional)
            int a = 100, b = 20;
            if (a > b)
            {
                aux = aux + "a mayor b";
            }
            else
                aux = aux + "b mayor que a";

            this.txtResultado.Text = aux;
            this.getSaludos(saludo);//llamada a la funcion
            this.lblNombres.Text = this.lblNombres.Text + "-->" + this.getCalcular(a, b).ToString();
        }


            //procedimiento - funciones
            //las funciones devuelven  valores.
            //el procedimiento es una funcion que no devuelve valor.
            void getSaludos(string nombres)
            {
                this.lblNombres.Text = "Uso de Funcion que no devuelve valor (" + nombres + ")";
            }

        //funcion que devuelva valor
        double getCalcular(int a, int b)
        {
            double resul = 0;
            resul = (a * 10) / (b * 2.5);

            return resul;
        }
      
    
    //paso de parametro por valor 

        void ejemploPasoValor(int x)
        {
            x = x + 100;
            MessageBox.Show("El nuevo valor de x: " + x.ToString());
        }
        void ejemploPasoReferencia(ref int a)
        {
            //la funcion recibe la variable original (direccion de memoria)
            //cualquier cambio en esta variable se refleja en la oriinal
            a = a + 100;
            MessageBox.Show("El nuevo valor de x: " + a.ToString());
        }

        private void btnPasoValor_Click(object sender, EventArgs e)
        {
            int x = 5; int y = 200;
            //erjemplo Paso Valor (x)
            this.ejemploParametrosopcionale(x, y);
            this.txtValor.Text = x.ToString();

        }

        //paso de parametros opcionales
        void ejemploParametrosopcionale(int x, int y=10)
        {
            x = x + y;
            MessageBox.Show("Parametro opcional: " + y.ToString());
            MessageBox.Show("El nuevo valor de x: " + x.ToString());
        }
    }
}
