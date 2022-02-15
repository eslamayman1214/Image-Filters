namespace IMAGE_FILTERS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Open_Graph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Picture_Filter = new System.Windows.Forms.PictureBox();
            this.Picture_Original = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Median_Sort_Method = new System.Windows.Forms.Label();
            this.Text_Max_Windows_Size = new System.Windows.Forms.TextBox();
            this.ComboBox_Median_sort_Method = new System.Windows.Forms.ComboBox();
            this.Button_Adaptive_Median_Filter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_Trim_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_Alpha_sort_Method = new System.Windows.Forms.ComboBox();
            this.Text_Window_Size = new System.Windows.Forms.TextBox();
            this.Button_Alpha_Term_Filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Open_Image = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Filter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Original)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Open_Graph);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Picture_Filter);
            this.groupBox1.Controls.Add(this.Picture_Original);
            this.groupBox1.Location = new System.Drawing.Point(17, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Box";
            // 
            // button_Open_Graph
            // 
            this.button_Open_Graph.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Open_Graph.Location = new System.Drawing.Point(1116, 370);
            this.button_Open_Graph.Name = "button_Open_Graph";
            this.button_Open_Graph.Size = new System.Drawing.Size(99, 54);
            this.button_Open_Graph.TabIndex = 19;
            this.button_Open_Graph.Text = "Open Graph";
            this.button_Open_Graph.UseVisualStyleBackColor = true;
            this.button_Open_Graph.Click += new System.EventHandler(this.button_Open_Graph_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1131, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1131, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // Picture_Filter
            // 
            this.Picture_Filter.Location = new System.Drawing.Point(570, 18);
            this.Picture_Filter.Name = "Picture_Filter";
            this.Picture_Filter.Size = new System.Drawing.Size(540, 406);
            this.Picture_Filter.TabIndex = 1;
            this.Picture_Filter.TabStop = false;
            // 
            // Picture_Original
            // 
            this.Picture_Original.Location = new System.Drawing.Point(22, 18);
            this.Picture_Original.Name = "Picture_Original";
            this.Picture_Original.Size = new System.Drawing.Size(540, 406);
            this.Picture_Original.TabIndex = 0;
            this.Picture_Original.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Median_Sort_Method);
            this.groupBox2.Controls.Add(this.Text_Max_Windows_Size);
            this.groupBox2.Controls.Add(this.ComboBox_Median_sort_Method);
            this.groupBox2.Controls.Add(this.Button_Adaptive_Median_Filter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Text_Trim_Value);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ComboBox_Alpha_sort_Method);
            this.groupBox2.Controls.Add(this.Text_Window_Size);
            this.groupBox2.Controls.Add(this.Button_Alpha_Term_Filter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Button_Open_Image);
            this.groupBox2.Location = new System.Drawing.Point(17, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1221, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Box";
            // 
            // Median_Sort_Method
            // 
            this.Median_Sort_Method.AutoSize = true;
            this.Median_Sort_Method.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Median_Sort_Method.Location = new System.Drawing.Point(979, 22);
            this.Median_Sort_Method.Name = "Median_Sort_Method";
            this.Median_Sort_Method.Size = new System.Drawing.Size(99, 18);
            this.Median_Sort_Method.TabIndex = 18;
            this.Median_Sort_Method.Text = "Sort Method";
            // 
            // Text_Max_Windows_Size
            // 
            this.Text_Max_Windows_Size.Location = new System.Drawing.Point(776, 48);
            this.Text_Max_Windows_Size.Name = "Text_Max_Windows_Size";
            this.Text_Max_Windows_Size.Size = new System.Drawing.Size(197, 20);
            this.Text_Max_Windows_Size.TabIndex = 17;
            // 
            // ComboBox_Median_sort_Method
            // 
            this.ComboBox_Median_sort_Method.FormattingEnabled = true;
            this.ComboBox_Median_sort_Method.Items.AddRange(new object[] {
            "1) Counting Sort",
            "2) Quick Sort"});
            this.ComboBox_Median_sort_Method.Location = new System.Drawing.Point(979, 48);
            this.ComboBox_Median_sort_Method.Name = "ComboBox_Median_sort_Method";
            this.ComboBox_Median_sort_Method.Size = new System.Drawing.Size(99, 21);
            this.ComboBox_Median_sort_Method.TabIndex = 15;
            // 
            // Button_Adaptive_Median_Filter
            // 
            this.Button_Adaptive_Median_Filter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Adaptive_Median_Filter.Location = new System.Drawing.Point(570, 15);
            this.Button_Adaptive_Median_Filter.Name = "Button_Adaptive_Median_Filter";
            this.Button_Adaptive_Median_Filter.Size = new System.Drawing.Size(200, 54);
            this.Button_Adaptive_Median_Filter.TabIndex = 12;
            this.Button_Adaptive_Median_Filter.Text = "Adaptive median Filter";
            this.Button_Adaptive_Median_Filter.UseVisualStyleBackColor = true;
            this.Button_Adaptive_Median_Filter.Click += new System.EventHandler(this.Button_Adaptive_Median_Filter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(773, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max Window size :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sort Method";
            // 
            // Text_Trim_Value
            // 
            this.Text_Trim_Value.Location = new System.Drawing.Point(342, 48);
            this.Text_Trim_Value.Name = "Text_Trim_Value";
            this.Text_Trim_Value.Size = new System.Drawing.Size(83, 20);
            this.Text_Trim_Value.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trim value :";
            // 
            // ComboBox_Alpha_sort_Method
            // 
            this.ComboBox_Alpha_sort_Method.FormattingEnabled = true;
            this.ComboBox_Alpha_sort_Method.Items.AddRange(new object[] {
            "1) Counting Sort",
            "2) Selection Sort"});
            this.ComboBox_Alpha_sort_Method.Location = new System.Drawing.Point(431, 48);
            this.ComboBox_Alpha_sort_Method.Name = "ComboBox_Alpha_sort_Method";
            this.ComboBox_Alpha_sort_Method.Size = new System.Drawing.Size(99, 21);
            this.ComboBox_Alpha_sort_Method.TabIndex = 6;
            // 
            // Text_Window_Size
            // 
            this.Text_Window_Size.Location = new System.Drawing.Point(342, 23);
            this.Text_Window_Size.Name = "Text_Window_Size";
            this.Text_Window_Size.Size = new System.Drawing.Size(83, 20);
            this.Text_Window_Size.TabIndex = 4;
            // 
            // Button_Alpha_Term_Filter
            // 
            this.Button_Alpha_Term_Filter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Alpha_Term_Filter.Location = new System.Drawing.Point(22, 15);
            this.Button_Alpha_Term_Filter.Name = "Button_Alpha_Term_Filter";
            this.Button_Alpha_Term_Filter.Size = new System.Drawing.Size(200, 54);
            this.Button_Alpha_Term_Filter.TabIndex = 1;
            this.Button_Alpha_Term_Filter.Text = "Alpha Tirm Filter";
            this.Button_Alpha_Term_Filter.UseVisualStyleBackColor = true;
            this.Button_Alpha_Term_Filter.Click += new System.EventHandler(this.Button_Alpha_Term_Filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Window size :";
            // 
            // Button_Open_Image
            // 
            this.Button_Open_Image.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Open_Image.Location = new System.Drawing.Point(1116, 19);
            this.Button_Open_Image.Name = "Button_Open_Image";
            this.Button_Open_Image.Size = new System.Drawing.Size(99, 54);
            this.Button_Open_Image.TabIndex = 0;
            this.Button_Open_Image.Text = "Open Image";
            this.Button_Open_Image.UseVisualStyleBackColor = true;
            this.Button_Open_Image.Click += new System.EventHandler(this.Button_Open_Image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Image Filters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Filter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Original)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Picture_Filter;
        private System.Windows.Forms.PictureBox Picture_Original;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Text_Window_Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Alpha_Term_Filter;
        private System.Windows.Forms.Button Button_Open_Image;
        private System.Windows.Forms.ComboBox ComboBox_Alpha_sort_Method;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Median_Sort_Method;
        private System.Windows.Forms.TextBox Text_Max_Windows_Size;
        private System.Windows.Forms.ComboBox ComboBox_Median_sort_Method;
        private System.Windows.Forms.Button Button_Adaptive_Median_Filter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Trim_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Open_Graph;
    }
}

