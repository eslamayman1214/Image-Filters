namespace IMAGE_FILTERS
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.ZedGraph_Alpha = new ZedGraph.ZedGraphControl();
            this.ZedGraph_Medain = new ZedGraph.ZedGraphControl();
            this.button_Draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZedGraph_Alpha
            // 
            this.ZedGraph_Alpha.Location = new System.Drawing.Point(12, 12);
            this.ZedGraph_Alpha.Name = "ZedGraph_Alpha";
            this.ZedGraph_Alpha.ScrollGrace = 0D;
            this.ZedGraph_Alpha.ScrollMaxX = 0D;
            this.ZedGraph_Alpha.ScrollMaxY = 0D;
            this.ZedGraph_Alpha.ScrollMaxY2 = 0D;
            this.ZedGraph_Alpha.ScrollMinX = 0D;
            this.ZedGraph_Alpha.ScrollMinY = 0D;
            this.ZedGraph_Alpha.ScrollMinY2 = 0D;
            this.ZedGraph_Alpha.Size = new System.Drawing.Size(363, 320);
            this.ZedGraph_Alpha.TabIndex = 0;
            this.ZedGraph_Alpha.UseExtendedPrintDialog = true;
            // 
            // ZedGraph_Medain
            // 
            this.ZedGraph_Medain.Location = new System.Drawing.Point(425, 12);
            this.ZedGraph_Medain.Name = "ZedGraph_Medain";
            this.ZedGraph_Medain.ScrollGrace = 0D;
            this.ZedGraph_Medain.ScrollMaxX = 0D;
            this.ZedGraph_Medain.ScrollMaxY = 0D;
            this.ZedGraph_Medain.ScrollMaxY2 = 0D;
            this.ZedGraph_Medain.ScrollMinX = 0D;
            this.ZedGraph_Medain.ScrollMinY = 0D;
            this.ZedGraph_Medain.ScrollMinY2 = 0D;
            this.ZedGraph_Medain.Size = new System.Drawing.Size(363, 320);
            this.ZedGraph_Medain.TabIndex = 1;
            this.ZedGraph_Medain.UseExtendedPrintDialog = true;
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(331, 380);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(138, 45);
            this.button_Draw.TabIndex = 2;
            this.button_Draw.Text = "Draw";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Size Windows for Alpha-trim";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(493, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Size Windows for Median";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Draw);
            this.Controls.Add(this.ZedGraph_Medain);
            this.Controls.Add(this.ZedGraph_Alpha);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl ZedGraph_Alpha;
        private ZedGraph.ZedGraphControl ZedGraph_Medain;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}