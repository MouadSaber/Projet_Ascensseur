using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location == new Point(37, 334))
            {

                TransitionPictureBox1(pictureBox3, new Point(69, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 231))
            {
                TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
                

                TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 137))
            {
                TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 46))
            {
                TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 437))
            {
                TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
            }

        }
        private void TransitionPictureBox(PictureBox pictureBox, Point startLocation, Point targetLocation, TimeSpan duration)
        {
            int steps = 100;
            int delay = (int)(duration.TotalMilliseconds / steps);

            for (int i = 0; i <= steps; i++)
            {
                float percentage = (float)i / steps;
                int x = (int)(startLocation.X + percentage * (targetLocation.X - startLocation.X));
                int y = (int)(startLocation.Y + percentage * (targetLocation.Y - startLocation.Y));
                pictureBox.Location = new Point(x, y);
                Thread.Sleep(delay);
                Application.DoEvents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location == new Point(37, 437))
            {
                TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));

            }
            else if (pictureBox1.Location == new Point(37, 231))
            {
                TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 137))
            {
                TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 46))
            {
                TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 46))
            {
                TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location == new Point(37, 437))
            {
                TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));

            }
            else if (pictureBox1.Location == new Point(37, 334))
            {
                TransitionPictureBox1(pictureBox3, new Point(69, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));
            }


            else if (pictureBox1.Location == new Point(37, 137))
            {
                TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 46))
            {
                TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 231))
            {
                TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location == new Point(37 ,437))
            {
                TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
                
                TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37 ,137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 231))
            {
                TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 137))
            {
                TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 46))
            {
                TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 137))
            {
                TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location == new Point(37, 437))
            {
                TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 231))
            {
                TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 137))
            {
                TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 334))
            {
                TransitionPictureBox1(pictureBox3, new Point(69, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox2, new Point(37, 334), TimeSpan.FromSeconds(2));
                TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
            }
            else if (pictureBox1.Location == new Point(37, 46))
            {
                TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
                TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
            }
        }
        private void TransitionPictureBox1(PictureBox pictureBox, Point targetLocation, TimeSpan duration)
        {
            Point startLocation = pictureBox.Location;
            int steps = 100;
            int delay = (int)(duration.TotalMilliseconds / steps);

            for (int i = 0; i <= steps; i++)
            {
                float percentage = (float)i / steps;
                int x = (int)(startLocation.X + percentage * (targetLocation.X - startLocation.X));
                int y = (int)(startLocation.Y + percentage * (targetLocation.Y - startLocation.Y));
                pictureBox.Location = new Point(x, y);
                Thread.Sleep(delay);
                Application.DoEvents();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location == new Point(37, 437))
            {
                TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 334), TimeSpan.FromSeconds(2));
            }  

        }

        private void button30_Click(object sender, EventArgs e)
        {
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 231), TimeSpan.FromSeconds(2));
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 137), TimeSpan.FromSeconds(2));
            

        }

        private void button32_Click(object sender, EventArgs e)
        {
  
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 46), TimeSpan.FromSeconds(2));
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 437), TimeSpan.FromSeconds(2));
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));

        }

        private void button28_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox3, new Point(69, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));

        }

        private void button20_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox3, new Point(69, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));

        }

        private void button11_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));

        }

        private void button26_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));


        }

        private void button14_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 141), new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));

        }

        private void button21_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));

        }

        private void button23_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));


        }

        private void button16_Click(object sender, EventArgs e)
        {
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 437), TimeSpan.FromSeconds(2));
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 334), TimeSpan.FromSeconds(2));
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 231), TimeSpan.FromSeconds(2));
        
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 137), TimeSpan.FromSeconds(2));
     
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 231), new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox3, new Point(69, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 334), new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox7, new Point(69, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 137), new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));

        }

        private void button24_Click(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox5, new Point(69, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(37, 231), TimeSpan.FromSeconds(2));
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox9, new Point(94, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(12, 437), TimeSpan.FromSeconds(2));
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox3, new Point(97, 334), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox2, new Point(12, 334), TimeSpan.FromSeconds(2));
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox5, new Point(95, 231), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox4, new Point(12, 231), TimeSpan.FromSeconds(2));
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox11, new Point(69, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 46), new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox7, new Point(95, 137), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox6, new Point(15, 137), TimeSpan.FromSeconds(2));
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            TransitionPictureBox1(pictureBox9, new Point(69, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox8, new Point(37, 437), TimeSpan.FromSeconds(2));
            TransitionPictureBox(pictureBox1, new Point(37, 437), new Point(37, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox11, new Point(95, 46), TimeSpan.FromSeconds(2));
            TransitionPictureBox1(pictureBox10, new Point(12, 46), TimeSpan.FromSeconds(2));
        }
    }
}
