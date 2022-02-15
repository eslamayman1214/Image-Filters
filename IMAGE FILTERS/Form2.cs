using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAGE_FILTERS
{
    public partial class Form2 : Form
    {
        public byte[,] ImageMatrix;
        public Form2()
        {
            InitializeComponent();

            ZedGraph_Medain.GraphPane.Title.Text = "adaptive median filter";
            ZedGraph_Medain.GraphPane.XAxis.Title.Text = "Execution Time";
            ZedGraph_Medain.GraphPane.YAxis.Title.Text = "Windows Size";

            ZedGraph_Alpha.GraphPane.Title.Text = "Alpha trim filter";
            ZedGraph_Alpha.GraphPane.XAxis.Title.Text = "Execution Time";
            ZedGraph_Alpha.GraphPane.YAxis.Title.Text = "Windows Size";

        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(textBox1.Text, out result))
            {
                MessageBox.Show("Please Enter Odd Max Windows Size!");
                return;
            }
            else if (result % 2 == 0 && result < 3)
            {
                MessageBox.Show("Please Enter Odd Max Windows Size!");
                return;
            }
            int Max1 = result;

            if (!int.TryParse(textBox2.Text, out result))
            {
                MessageBox.Show("Please Enter Odd Max Windows Size!");
                return;
            }
            else if (result % 2 == 0 && result < 3)
            {
                MessageBox.Show("Please Enter Odd Max Windows Size!");
                return;
            }
            int Max2 = result;

            Max1 = 2+ (Max1 - 3)/(2);
            Max2 = 2+ (Max2 - 3)/(2);

            double[] AlphaX = new double [Max1];
            double[] AlphaY = new double[Max1];

            double[] MedainX = new double[Max2];
            double[] MedainY = new double[Max2];

            AlphaX[0] = 0;
            AlphaY[0] = 0;

            int Win = 3;
            for (int i = 1; i < AlphaX.Length; i++)
            {   
                AlphaX[i] = ImageOperations.CalculateTime(ImageMatrix, Win, 1);
                AlphaY[i] = Win;
                Win += 2;
            }

            ZedGraph_Alpha.GraphPane.AddCurve("MaxWin" + Win + "With Counting sort", AlphaX, AlphaY, Color.Red, ZedGraph.SymbolType.Circle);
            ZedGraph_Alpha.AxisChange();
            ZedGraph_Alpha.Hide();
            ZedGraph_Alpha.Show();

            MedainX[0] = 0;
            MedainY[0] = 0;

            Win = 3;
            for (int i = 1; i < MedainX.Length; i++)
            {

                MedainX[i] = ImageOperations.CalculateTime(ImageMatrix, Win, 0);
                MedainY[i] = Win;
                Win += 2;
            }

            ZedGraph_Medain.GraphPane.AddCurve("MaxWin" + Win + "With Counting sort", MedainX, MedainY, Color.Blue, ZedGraph.SymbolType.Circle);
            ZedGraph_Medain.AxisChange();
            ZedGraph_Medain.Hide();
            ZedGraph_Medain.Show();
        }
    }
}
