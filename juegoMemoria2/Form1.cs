using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoMemoria2
{
    public partial class Form1 : Form
    {
        PictureBox carta1 = null;
        PictureBox carta2 = null;
        

        public Form1()
        {
            InitializeComponent();
    
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
       {

            if (carta1 == null)
            {
                pictureBox5.Image = new Bitmap("c3.png");
                carta1 = pictureBox5;
                return;
            }
            if (carta2 == null)
            {
                pictureBox5.Image = new Bitmap("c3.png");
                carta2 = pictureBox5;

                if (carta2.Name.Equals("pictureBox5") && carta1.Name.Equals("pictureBox25")) //verifica si son iguales
                {//son iguales
                    
                    carta1 = null;
                    carta2 = null;
                    
                }
                else
                {// no son iguales

                    timer1.Start();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            timer1.Stop();
            carta1.Image = new Bitmap("front.png");
            carta2.Image = new Bitmap("front.png");
            carta1 = null;
            carta2 = null;

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
        
            if (carta1 == null)
            {
                pictureBox25.Image = new Bitmap("c3.png");
                carta1 = pictureBox25;
                return;
            }
            if (carta2 == null)
            {
                pictureBox25.Image = new Bitmap("c3.png");
                carta2 = pictureBox25;

                if (carta2.Name.Equals("pictureBox25") && carta1.Name.Equals("pictureBox5")) //verifica si son iguales
                {//son iguales

                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox6.Image = new Bitmap("hj.png");
                carta1 = pictureBox6;
                return;
            }
            if (carta2 == null)
            {
                pictureBox6.Image = new Bitmap("hj.png");
                carta2 = pictureBox6;

                if (carta2.Name.Equals("pictureBox6") && carta1.Name.Equals("pictureBox18")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox18.Image = new Bitmap("hj.png");
                carta1 = pictureBox18;
                return;
            }
            if (carta2 == null)
            {
                pictureBox18.Image = new Bitmap("hj.png");
                carta2 = pictureBox18;

                if (carta2.Name.Equals("pictureBox18") && carta1.Name.Equals("pictureBox6")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox8.Image = new Bitmap("h9.png");
                carta1 = pictureBox8;
                return;
            }
            if (carta2 == null)
            {
                pictureBox8.Image = new Bitmap("h9.png");
                carta2 = pictureBox8;

                if (carta2.Name.Equals("pictureBox8") && carta1.Name.Equals("pictureBox14")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox14.Image = new Bitmap("h9.png");
                carta1 = pictureBox14;
                return;
            }
            if (carta2 == null)
            {
                pictureBox14.Image = new Bitmap("h9.png");
                carta2 = pictureBox14;

                if (carta2.Name.Equals("pictureBox14") && carta1.Name.Equals("pictureBox8")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");

                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox11.Image = new Bitmap("ca.png");
                carta1 = pictureBox11;
                return;
            }
            if (carta2 == null)
            {
                pictureBox11.Image = new Bitmap("ca.png");
                carta2 = pictureBox11;

                if (carta2.Name.Equals("pictureBox11") && carta1.Name.Equals("pictureBox20")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }


        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox20.Image = new Bitmap("ca.png");
                carta1 = pictureBox20;
                return;
            }
            if (carta2 == null)
            {
                pictureBox20.Image = new Bitmap("ca.png");
                carta2 = pictureBox20;

                if (carta2.Name.Equals("pictureBox20") && carta1.Name.Equals("pictureBox11")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox16.Image = new Bitmap("s8.png");
                carta1 = pictureBox16;
                return;
            }
            if (carta2 == null)
            {
                pictureBox16.Image = new Bitmap("s8.png");
                carta2 = pictureBox16;

                if (carta2.Name.Equals("pictureBox16") && carta1.Name.Equals("pictureBox4")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox4.Image = new Bitmap("s8.png");
                carta1 = pictureBox4;
                return;
            }
            if (carta2 == null)
            {
                pictureBox4.Image = new Bitmap("s8.png");
                carta2 = pictureBox4;

                if (carta2.Name.Equals("pictureBox4") && carta1.Name.Equals("pictureBox16")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox13.Image = new Bitmap("ha.png");
                carta1 = pictureBox13;
                return;
            }
            if (carta2 == null)
            {
                pictureBox13.Image = new Bitmap("ha.png");
                carta2 = pictureBox13;

                if (carta2.Name.Equals("pictureBox13") && carta1.Name.Equals("pictureBox22")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox22.Image = new Bitmap("ha.png");
                carta1 = pictureBox22;
                return;
            }
            if (carta2 == null)
            {
                pictureBox22.Image = new Bitmap("ha.png");
                carta2 = pictureBox22;

                if (carta2.Name.Equals("pictureBox22") && carta1.Name.Equals("pictureBox13")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox17.Image = new Bitmap("sq.png");
                carta1 = pictureBox17;
                return;
            }
            if (carta2 == null)
            {
                pictureBox17.Image = new Bitmap("sq.png");
                carta2 = pictureBox17;

                if (carta2.Name.Equals("pictureBox17") && carta1.Name.Equals("pictureBox15")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox15.Image = new Bitmap("sq.png"); //vuelta a la carta
                carta1 = pictureBox15;
                return; //sale del methodo
            }
            if (carta2 == null)
            {
                pictureBox15.Image = new Bitmap("sq.png");
                carta2 = pictureBox15;

                if (carta2.Name.Equals("pictureBox15") && carta1.Name.Equals("pictureBox17")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox2.Image = new Bitmap("hk.png");
                carta1 = pictureBox2;
                return;
            }
            if (carta2 == null)
            {
                pictureBox2.Image = new Bitmap("hk.png");
                carta2 = pictureBox2;

                if (carta2.Name.Equals("pictureBox2") && carta1.Name.Equals("pictureBox3")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox3.Image = new Bitmap("hk.png");
                carta1 = pictureBox3;
                return;
            }
            if (carta2 == null)
            {
                pictureBox3.Image = new Bitmap("hk.png");
                carta2 = pictureBox3;

                if (carta2.Name.Equals("pictureBox3") && carta1.Name.Equals("pictureBox2")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox23.Image = new Bitmap("d4.png");
                carta1 = pictureBox23;
                return;
            }
            if (carta2 == null)
            {
                pictureBox23.Image = new Bitmap("d4.png");
                carta2 = pictureBox23;

                if (carta2.Name.Equals("pictureBox23") && carta1.Name.Equals("pictureBox30")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox30.Image = new Bitmap("d4.png");
                carta1 = pictureBox30;
                return;
            }
            if (carta2 == null)
            {
                pictureBox30.Image = new Bitmap("d4.png");
                carta2 = pictureBox30;

                if (carta2.Name.Equals("pictureBox30") && carta1.Name.Equals("pictureBox23")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox7.Image = new Bitmap("h10.png");
                carta1 = pictureBox7;
                return;
            }
            if (carta2 == null)
            {
                pictureBox7.Image = new Bitmap("h10.png");
                carta2 = pictureBox7;

                if (carta2.Name.Equals("pictureBox7") && carta1.Name.Equals("pictureBox21")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox21.Image = new Bitmap("h10.png");
                carta1 = pictureBox21;
                return;
            }
            if (carta2 == null)
            {
                pictureBox21.Image = new Bitmap("h10.png");
                carta2 = pictureBox21;

                if (carta2.Name.Equals("pictureBox21") && carta1.Name.Equals("pictureBox7")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox12.Image = new Bitmap("s6.png");
                carta1 = pictureBox12;
                return;
            }
            if (carta2 == null)
            {
                pictureBox12.Image = new Bitmap("s6.png");
                carta2 = pictureBox12;

                if (carta2.Name.Equals("pictureBox12") && carta1.Name.Equals("pictureBox19")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox19.Image = new Bitmap("s6.png");
                carta1 = pictureBox19;
                return;
            }
            if (carta2 == null)
            {
                pictureBox19.Image = new Bitmap("s6.png");
                carta2 = pictureBox19;

                if (carta2.Name.Equals("pictureBox19") && carta1.Name.Equals("pictureBox12")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox24.Image = new Bitmap("s5.png");
                carta1 = pictureBox24;
                return;
            }
            if (carta2 == null)
            {
                pictureBox24.Image = new Bitmap("s5.png");
                carta2 = pictureBox24;

                if (carta2.Name.Equals("pictureBox24") && carta1.Name.Equals("pictureBox10")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                   
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox10.Image = new Bitmap("s5.png");
                carta1 = pictureBox10;
                return;
            }
            if (carta2 == null)
            {
                pictureBox10.Image = new Bitmap("s5.png");
                carta2 = pictureBox10;

                if (carta2.Name.Equals("pictureBox10") && carta1.Name.Equals("pictureBox24")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (carta1 == null)
            {
                pictureBox9.Image = new Bitmap("c10.png");
                carta1 = pictureBox9;
                return;
            }
            if (carta2 == null)
            {
                pictureBox9.Image = new Bitmap("c10.png");
                carta2 = pictureBox9;

                if (carta2.Name.Equals("pictureBox10") && carta1.Name.Equals("pictureBox00")) //verifica si son iguales
                {//son iguales
                    carta1 = null;
                    carta2 = null;
                    MessageBox.Show("Son iguales");
                }
                else
                {// no son iguales
                    timer1.Start();

                }
            }
        }
    }
}