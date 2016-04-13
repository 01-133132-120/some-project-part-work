using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicTextbox_and_labels
{
    public partial class Form1 : Form
    {

        int x = 0;
        int y = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        TextBox[] mybox = new TextBox[5];
        Label [] mylabel = new Label[5];
        //int value;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
             
            for (int i = 0; i < 5; i++)
            {
                mybox[i] = new TextBox();
                mybox[i].Location = new Point(x, y);
                mybox[i].Width = 50;
                x = x + 50;
                panel1.Controls.Add(mybox[i]);
                mybox[i].Visible = true;
                
            }
            
           
            //single label created
            
                /*mylabel = new Label();
                mylabel.Width = 80;
                mylabel.Height = 80;
                mylabel.BackColor = Color.White;
                panel2.Controls.Add(mylabel);
                mylabel.Visible = true;*/
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           for (int i = 0; i < 5; i++)
            {
                mylabel[i] = new Label();
                mylabel[i].Location = new Point(a,b );
                mylabel[i].Text = mybox[i].Text;
                a= a + 100;
                mylabel[i].Width = 80;
                mylabel[i].Height = 80;
                mylabel[i].BackColor = Color.White;
                mylabel[i].TextAlign = ContentAlignment.MiddleCenter;
                panel2.Controls.Add(mylabel[i]);
               mylabel[i].Visible = true;
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val = 1;
            for (int i = 0; i < 5; i++)
            {
                mybox[i].Text = val.ToString();
                val++;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val1 = 5;
            for (int i = 0; i < 5; i++)
            {
                mybox[i].Text = val1.ToString();
                val1--;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                mybox[i].Text = ran.Next(0, 200).ToString();
            }

           
        }
    }
}
