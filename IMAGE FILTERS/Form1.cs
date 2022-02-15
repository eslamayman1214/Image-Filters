using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace IMAGE_FILTERS
{
    public partial class Form1 : Form
    {
        byte[,] ImageMatrix;
        string OpenedFilePath;

        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Open_Image_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, Picture_Original);
                Picture_Filter.Image = null;
            }
        }

        private void Button_Adaptive_Median_Filter_Click(object sender, EventArgs e)
        {
            if (OpenedFilePath == null)
            {
                MessageBox.Show("Please Load Image First!");
                return;
            }
            int result;
            if (!int.TryParse(Text_Max_Windows_Size.Text, out result))
            {
                MessageBox.Show("Please Enter Odd Max Windows Size!");
                return;
            }
            else if (result % 2 == 0 && result < 3)
            {
                MessageBox.Show("Please Enter Odd Max Windows Size!");
                return;
            }
            if (ComboBox_Median_sort_Method.Text.Length == 0)
            {
                MessageBox.Show("Please Select Sort Method !");
                return;
            }
            label3.Text = "";
            ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);


            int Max_Size = int.Parse(Text_Max_Windows_Size.Text);
            int Sort;
            if (ComboBox_Alpha_sort_Method.Text == "1) Counting Sort")
            {
                Sort = 1;
            }
            else
            {
                Sort = 2;
            }
            int Start = System.Environment.TickCount;
            ImageOperations.Adaptive_median(ImageMatrix, Max_Size, Sort);
            int End = System.Environment.TickCount;
            ImageOperations.DisplayImage(ImageMatrix, Picture_Filter);
            double Time = End - Start;
            Time /= 1000;
            label3.Text = (Time).ToString();
            label3.Text += " s";
        }

        private void Button_Alpha_Term_Filter_Click(object sender, EventArgs e)
        {
            if (OpenedFilePath == null)
            {
                MessageBox.Show("Please Load Image First!");
                return; 
            }
            int result;
            if (!int.TryParse(Text_Window_Size.Text ,out result)) 
            {
                MessageBox.Show("Please Enter Odd Windows Size!");
                return;
            }
            else if (result % 2 == 0 && result < 3)
            {
                MessageBox.Show("Please Enter Odd Windows Size!");
                return;
            }
            if (!int.TryParse(Text_Trim_Value.Text, out result))
            {
                MessageBox.Show("Please Enter Odd Trim Value!");
                return;
            }
            else if (result % 2 == 0 && result < 3)
            {
                MessageBox.Show("Please Enter Odd Trim Value!");
                return;
            }
            if (ComboBox_Alpha_sort_Method.Text.Length == 0)
            {
                MessageBox.Show("Please Select Sort Method !");
                return;
            }
            label3.Text = "";
            ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);


            int win_Size = int.Parse(Text_Window_Size.Text);
            int Trim_Value = int.Parse(Text_Trim_Value.Text);
            int Sort;
            if (ComboBox_Alpha_sort_Method.Text == "1) Counting Sort")
            {
                Sort = 1;
            }
            else
            {
                Sort = 2;
            }
            
            int Start = System.Environment.TickCount;
            ImageOperations.Alpha_trim(ImageMatrix, win_Size, Sort, Trim_Value);
            int End = System.Environment.TickCount;
            ImageOperations.DisplayImage(ImageMatrix, Picture_Filter);
            double Time = End - Start;
            Time /= 1000;
            label3.Text = (Time).ToString();
            label3.Text += " s";
        }

        private void button_Open_Graph_Click(object sender, EventArgs e)
        {
            if (OpenedFilePath == null)
            {
                MessageBox.Show("Please Load Image First!");
                return;
            }
            Form2 x = new Form2();
            x.ImageMatrix = ImageMatrix;
            x.Show();
        }
    }
}
