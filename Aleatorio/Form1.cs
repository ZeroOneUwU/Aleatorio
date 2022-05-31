using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleatorio
{
 
   public partial class Form1 : Form
    {
        //Declaracion de variables globales
        int varaleatorio = 0;
        int varaleatorio2 = 0;
        int varaleatorio3 = 0;

        int i=0, j=0, k=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureFruta_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;

            Random aleat = new Random();
            Random aleat2 = new Random();
            Random aleat3 = new Random();//declaramos el objecto randoms
            varaleatorio = aleat.Next(15)+1;
            varaleatorio2 = aleat2.Next(15)-3;
            varaleatorio3 = aleat3.Next(15)+5;//asignamos el valor de un rango de 0-2

            timer1.Start();
            timer2.Start();
            timer3.Start();

            switch (i)
            {
                case 0:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Arandono;
                   

                    break;
                case 1:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Bar;
                   

                    break;
                case 2:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Bar2;
                    
                    break;

                case 4:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Bar3;
                    

                    break;
                case 5:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Campana;
                    

                    break;
                case 6:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Cereza;
                   
                    break;
                case 7:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Diamante;
                   

                    break;
                case 8:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Dinero;

                    break;


                case 9:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Herradura;


                    break;
                case 10:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Limon;


                    break;
                case 11:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Naranja;

                    break;

                case 12:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Sandia;


                    break;
                case 13:
                    picture1.Image =
                        Aleatorio.Properties.Resources.siete;


                    break;
                case 14:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Toronja;

                    break;
                case 15:
                    picture1.Image =
                        Aleatorio.Properties.Resources.Trevol;
                 break;
 
            }

            switch (j)
            {
                case 0:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Arandono;


                    break;
                case 1:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Bar;


                    break;
                case 2:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Bar2;

                    break;

                case 4:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Bar3;


                    break;
                case 5:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Campana;


                    break;
                case 6:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Cereza;

                    break;
                case 7:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Diamante;


                    break;
                case 8:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Dinero;

                    break;


                case 9:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Herradura;


                    break;
                case 10:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Limon;


                    break;
                case 11:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Naranja;

                    break;

                case 12:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Sandia;


                    break;
                case 13:
                    picture2.Image =
                        Aleatorio.Properties.Resources.siete;


                    break;
                case 14:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Toronja;

                    break;
                case 15:
                    picture2.Image =
                        Aleatorio.Properties.Resources.Trevol;
                    break;

            }

            switch (k)
            {
                case 0:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Arandono;


                    break;
                case 1:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Bar;


                    break;
                case 2:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Bar2;

                    break;

                case 4:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Bar3;


                    break;
                case 5:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Campana;


                    break;
                case 6:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Cereza;

                    break;
                case 7:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Diamante;


                    break;
                case 8:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Dinero;

                    break;


                case 9:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Herradura;


                    break;
                case 10:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Limon;


                    break;
                case 11:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Naranja;

                    break;

                case 12:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Sandia;


                    break;
                case 13:
                    picture3.Image =
                        Aleatorio.Properties.Resources.siete;


                    break;
                case 14:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Toronja;

                    break;
                case 15:
                    picture3.Image =
                        Aleatorio.Properties.Resources.Trevol;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             
           
           
            if (j <= varaleatorio2)
                j++;
            else
                j = 0;
            if (j == varaleatorio2)
                timer2.Stop();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (k <= varaleatorio3)
                k++;
            else
                k = 0;
            if (k == varaleatorio3)
                timer3.Stop();
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= varaleatorio)
                i++;
            else
                i = 0;
            if(i== varaleatorio)
                timer1.Stop();


            //genera otro nuevo nmero aleatoriotextBox1.Text=textBox1.Text
            //+i.ToString() + Environment.NewLine;
            //pero para que fruta desea mostrar

        }
    }
}
