using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankCredit
{
    public partial class frmGrafic : Form
    {
        public frmGrafic()
        {
            InitializeComponent();
            penCrt = new Pen(Color.Black, 2);
            brCrt = new SolidBrush(Color.Blue);
            den = new string[] { "Leasing", "PrimaCasa", "PrimaMasina", "NevoiPersonale", "Ipotecar" };
            val = new float[100];
        }

        Pen penCrt; Pen[] vectPen;
        SolidBrush brCrt; SolidBrush[] vectBrush;
        string[] den;
        float[] val;
        int nrCulori;
        RectangleF r;


        private void panel1_PaintPie(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Raport produse", Font, brCrt, new Point(20, 20));
            r = panel1.ClientRectangle;

            float start, valU;
            float sum = 0;

            vectPen = new Pen[] {
                new Pen(Color.Coral),
                new Pen(Color.BurlyWood),
                new Pen(Color.Green),
                new Pen(Color.Red),
                new Pen(Color.Yellow),
                new Pen(Color.Violet),
            };
            vectBrush = new SolidBrush[]{
                new SolidBrush(Color.Coral),
                new SolidBrush(Color.BurlyWood),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.LightBlue),
                new SolidBrush(Color.MidnightBlue),
                new SolidBrush(Color.OrangeRed)
            };
            nrCulori = vectPen.Length;

            for (int i = 0; i < den.Length; i++)
            {
                sum += val[i];
            }

            start = 0;
            valU = 0;

            for (int i = 0; i < den.Length; i++)
            {
                valU = (val[i] * 360) / sum;
                penCrt = vectPen[i % nrCulori];
                brCrt = vectBrush[i % nrCulori];
                g.DrawPie(penCrt, r, start, valU);
                g.FillPie(brCrt, r.X, r.Y, r.Width, r.Height, start, valU);
                start += valU;

                g.DrawString(Convert.ToString(val[i]),Font,brCrt,0,valU = (val[i] * 360) / sum);

            }

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(op.FileName);
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    val[nrCulori] = (float)Convert.ToDouble(linie);
                    nrCulori++;
                }
            }

            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);

            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);
            panel1.Invalidate();
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Raport produse", Font, brCrt, new Point(20, 20));
            r = panel1.ClientRectangle;

            float start, valU;
            float sum = 0;

            vectPen = new Pen[] {
                new Pen(Color.Coral),
                new Pen(Color.BurlyWood),
                new Pen(Color.Green),
                new Pen(Color.Red),
                new Pen(Color.Yellow),
                new Pen(Color.Violet),
            };
            vectBrush = new SolidBrush[]{
                new SolidBrush(Color.Coral),
                new SolidBrush(Color.BurlyWood),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.LightBlue),
                new SolidBrush(Color.MidnightBlue),
                new SolidBrush(Color.OrangeRed)
            };
            nrCulori = vectPen.Length;

            for (int i = 0; i < den.Length; i++)
            {
                sum += val[i];
            }

            start = 0;
            valU = 0;

            for (int i = 0; i < den.Length; i++)
            {
                valU = (val[i] * 360) / sum;
                penCrt = vectPen[i % nrCulori];
                brCrt = vectBrush[i % nrCulori];
                g.DrawPie(penCrt, r, start, valU);
                g.FillPie(brCrt, r.X, r.Y, r.Width, r.Height, start, valU);
                start += valU;
            }
        }

        private void menuItem4_Click_1(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_print);
            PrintPreviewDialog pdlg = new PrintPreviewDialog();
            pdlg.Document = pd;
            pdlg.ShowDialog();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(op.FileName);
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    val[nrCulori] = (float)Convert.ToDouble(linie);
                    nrCulori++;
                }
            }

            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);

            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);
            panel1.Invalidate();
        }
    }
}
