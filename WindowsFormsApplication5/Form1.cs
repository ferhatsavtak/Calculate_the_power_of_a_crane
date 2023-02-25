using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    
        
    
    {
        double   x1,x2, yaricapa=100d, aradakimesafe=250d;  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, 
            true); this.SetStyle(ControlStyles.OptimizedDoubleBuffer, 
            true); yaricapaScrollBar.Value = Convert.ToInt32(yaricapa); 
            hScrollBar2.Value = Convert.ToInt32(aradakimesafe); 
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            yaricapa = Convert.ToDouble(yaricapaScrollBar.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            aradakimesafe = Convert.ToDouble(hScrollBar2.Value); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label2.Text = Convert.ToString(yaricapaScrollBar.Value*2);
            label3.Text = Convert.ToString(hScrollBar2.Value);
            label4.Text = Convert.ToString(yaricapcScrollBar.Value*2);
            label5.Text = Convert.ToString(yaricapbScrollBar.Value*2);
            
            
            Invalidate();
        }
            private float c(double a)
        { 
            
            
         return Convert.ToSingle(a);
        
        }  
    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           ///int c(double( x))
           
            
            Pen p = new Pen(Color.Coral, 5);  
            e.Graphics.TranslateTransform(30,30);  
            //teta += 0.105; // x = L * Math.Cos(teta)*0;  
           // y = L * Math.Sin(teta)*0;  
            //e.Graphics.DrawLine(p,0,0,c(x),c(y));              
            x1 =  Math.Sqrt(aradakimesafe*aradakimesafe);
            //x2 =  Math.Sqrt(aradakimesafe * aradakimesafe);
            e.Graphics.DrawLine(p, yaricapaScrollBar.Value/2, 0, c(x1), 0);
            e.Graphics.DrawLine(p, yaricapaScrollBar.Value / 2, yaricapaScrollBar.Value, c(x1), yaricapbScrollBar.Value);
            e.Graphics.DrawEllipse(p, 0, 0, yaricapaScrollBar.Value, yaricapaScrollBar.Value);
            e.Graphics.DrawEllipse(p, c(x1 -yaricapbScrollBar.Value/2), 0, yaricapbScrollBar.Value, yaricapbScrollBar.Value);
            e.Graphics.DrawEllipse(p, c(x1 - yaricapcScrollBar.Value / 2), yaricapbScrollBar.Value / 2 - yaricapcScrollBar.Value / 2, yaricapcScrollBar.Value, yaricapcScrollBar.Value);
            e.Graphics.DrawLine(p, c(x1) + yaricapcScrollBar.Value / 2, yaricapbScrollBar.Value / 2, c(x1) + yaricapcScrollBar.Value / 2, 200);
            e.Graphics.DrawRectangle(p, c(x1) + yaricapcScrollBar.Value / 2-15, 200, 30, 30);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            double g= 9.81;
            double hizz=Convert.ToDouble(hiz.Text);
            double yukk = Convert.ToDouble(yuk.Text);
            double hh = Convert.ToDouble(h.Text);
            double rc = Convert.ToDouble(label4.Text);
            double rb = Convert.ToDouble(label5.Text);
            double ra=Convert.ToDouble(label2.Text);


            double a = (hizz*hizz) / (2 * hh);
            double Fc = yukk * (g + a);
            double Mc = Fc * (rc/1000);
            double Mb = Mc;
            double Fb = Mb/(rb/1000);
            double Fa=Fb;
            double Ma=Fa*(ra/1000);
            double Wc = ((hizz) / (rc / 1000));
            double Wb = Wc;
            double vb = (Wb * (rb / 1000));
            double va = vb;
            double Wa = (va / (ra / 1000));
            double n = (Wa * 30) / 3.14159265358979323846;
            double P = Ma * Wa;
            double sonP = P * 1.25;

            double kayisboyu = 2 * (2 * ra + 2 * rb) + (3.14159265358979323846 / 2) * (2 * ra + 2 * rb) + (2 * rb - 2 * ra) * (2 * rb - 2 * ra) / 4 * (2 * ra + 2 * rb);
            
            label6.Text = Convert.ToString(sonP);
            label7.Text = Convert.ToString(kayisboyu);

            double yukemniyet = yukk * 5;

            if (yukemniyet < 1990)
                label8.Text = "6 mm";
            else if (yukemniyet < 3540)
                label8.Text = "8 mm";
            else if (yukemniyet < 5350)
                label8.Text = "10 mm";
            else if (yukemniyet < 7970)
                label8.Text = "12 mm";
            else if (yukemniyet < 9350)
                label8.Text = "13 mm";
            else if (yukemniyet < 10800)
                label8.Text = "14 mm";
            else if (yukemniyet < 14200)
                label8.Text = "16 mm";
            else if (yukemniyet < 17900)
                label8.Text = "18 mm";
            else if (yukemniyet < 19950)
                label8.Text = "19 mm";
            else if (yukemniyet < 22100)
                label8.Text = "20 mm";
            else if (yukemniyet < 26800)
                label8.Text = "22 mm";











        }

       
        
    }
}
