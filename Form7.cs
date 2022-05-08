using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form7 : Form
    {
        List<Imprumuturi> lista2;
        public Form7(List<Imprumuturi> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        double[] Values = new double[20];
        int nrElem = 0;

        bool vb = false;

        private Brush[] SliceBrushes =
       {
            Brushes.Red,
            Brushes.LightGreen,
            Brushes.Blue,
            Brushes.LightBlue,
            Brushes.Green,
            Brushes.Lime,
            Brushes.Orange,
            Brushes.Fuchsia,
            Brushes.Yellow,
            Brushes.Cyan,
        };

        // Pens used to outline pie slices.
        private Pen[] SlicePens = { Pens.Black };

        private static void DrawLabeledPieChart(Graphics gr, Rectangle rect, float initial_angle, Brush[] brushes, Pen[] pens, double[] values, string label_format, Font label_font, Brush label_brush)
        {
            // Get the total of all angles.
            double total = values.Sum();

            // Draw the slices.
            float start_angle = initial_angle;
            for (int i = 0; i < values.Length; i++)
            {
                float sweep_angle = (float)(values[i] * 360f / total);

                // Fill and outline the pie slice.
                gr.FillPie(brushes[i % brushes.Length], rect, start_angle, sweep_angle);
                gr.DrawPie(pens[i % pens.Length], rect, start_angle, sweep_angle);

                start_angle += sweep_angle;
            }

            // Label the slices.
            // We label the slices after drawing them all so one
            // slice doesn't cover the label on another very thin slice.
            using (StringFormat string_format = new StringFormat())
            {
                // Center text.
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;

                // Find the center of the rectangle.
                float cx = (rect.Left + rect.Right) / 2f;
                float cy = (rect.Top + rect.Bottom) / 2f;

                // Place the label about 2/3 of the way out to the edge.
                float radius = (rect.Width + rect.Height) / 2f * 0.33f;



                start_angle = initial_angle;
                for (int i = 0; i < values.Length; i++)
                {
                    float sweep_angle = (float)(values[i] * 360f / total);

                    // Label the slice.
                    double label_angle = Math.PI * (start_angle + sweep_angle / 2f) / 180f;
                    float x = cx + (float)(radius * Math.Cos(label_angle));
                    float y = cy + (float)(radius * Math.Sin(label_angle));
                    gr.DrawString(values[i].ToString(label_format),
                        label_font, label_brush, x, y, string_format);

                    start_angle += sweep_angle;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            if ((ClientSize.Width < 20) || (ClientSize.Height < 20)) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(
                10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            DrawLabeledPieChart(e.Graphics, rect, -90, SliceBrushes, SlicePens, Values, "0.0", Font, Brushes.Black);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("varstaAdaugate.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    Values[nrElem] = Convert.ToDouble(linie);
                    nrElem++;
                    vb = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}





