using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        List<Imprumuturi> lista2;
        public Form3(List<Imprumuturi> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }


        double[] vect = new double[20];
        int nrElem = 0;

        bool vb = false;

        const int marg = 10;

        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        public Form3()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("varstaAdaugate.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                try
                {
                    vect[nrElem] = Convert.ToDouble(linie);
                    nrElem++;
                    vb = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Date incarcare!");
            panel1.Invalidate();
        }  //preluam valorile varstelor cititorilor din varstaAdaugate.txt
           

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            //Invalidate();
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            //Invalidate();
            panel1.Invalidate();
        }

        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }
        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save(this, "poza.bmp");
            save(panel1, "poza.bmp");
            MessageBox.Show("S-a salvat");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                //chart1.Parent = panel1;

                chart1.Titles.Add("Pie Chart");

                for (int i = 0; i < nrElem; i++)
                    chart1.Series["s1"].Points.AddXY(i+1, vect[i]);
               // chart1.drawString()

                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg,
                    panel1.ClientRectangle.Y + 2 * marg, panel1.ClientRectangle.Width - 30 * marg, panel1.ClientRectangle.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max() + 10; // maximul sa nu fie exact la partea de sus a dreptunghiului

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                       (int)latime,
                       (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);
                Pen pen1 = new Pen(Color.Green, 3);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen1, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));


               
            }
        }
        
        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {


                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 2 * marg, e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                       (int)latime,
                       (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), font, br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                g.FillRectangles(br, recs);
                Pen pen1 = new Pen(Color.Green, 3);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen1, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));

            }
        }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

       
    }
}
