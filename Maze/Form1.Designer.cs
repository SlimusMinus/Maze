namespace Maze
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            panel1=new Panel();
            label11=new Label();
            label10=new Label();
            label9=new Label();
            label8=new Label();
            label7=new Label();
            label6=new Label();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor=Color.FromArgb(255, 128, 255);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(776, 23);
            label1.TabIndex=0;
            label1.MouseEnter+=Label1_MouseEnter;
            // 
            // label2
            // 
            label2.BackColor=Color.FromArgb(255, 128, 255);
            label2.Location=new Point(12, 70);
            label2.Name="label2";
            label2.Size=new Size(654, 23);
            label2.TabIndex=1;
            label2.MouseEnter+=Label1_MouseEnter;
            // 
            // panel1
            // 
            panel1.BackColor=SystemColors.ActiveBorder;
            panel1.BorderStyle=BorderStyle.Fixed3D;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location=new Point(-4, -1);
            panel1.Name="panel1";
            panel1.Size=new Size(804, 456);
            panel1.TabIndex=2;
            // 
            // label11
            // 
            label11.BackColor=Color.Red;
            label11.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location=new Point(680, 350);
            label11.Name="label11";
            label11.Size=new Size(72, 67);
            label11.TabIndex=9;
            label11.Text="FINISH";
            label11.TextAlign=ContentAlignment.MiddleCenter;
            label11.MouseEnter+=Label11_MouseEnter;
            // 
            // label10
            // 
            label10.BackColor=Color.Red;
            label10.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location=new Point(14, 32);
            label10.Name="label10";
            label10.Size=new Size(100, 37);
            label10.TabIndex=8;
            label10.Text="START";
            label10.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor=Color.FromArgb(255, 128, 255);
            label9.Location=new Point(71, 350);
            label9.Name="label9";
            label9.Size=new Size(607, 23);
            label9.TabIndex=7;
            label9.Text="\r\n";
            label9.MouseEnter+=Label1_MouseEnter;
            // 
            // label8
            // 
            label8.BackColor=Color.FromArgb(255, 128, 255);
            label8.Location=new Point(14, 417);
            label8.Name="label8";
            label8.Size=new Size(776, 23);
            label8.TabIndex=3;
            label8.MouseEnter+=Label1_MouseEnter;
            // 
            // label7
            // 
            label7.BackColor=Color.FromArgb(255, 128, 255);
            label7.Location=new Point(108, 293);
            label7.Name="label7";
            label7.Size=new Size(613, 23);
            label7.TabIndex=6;
            label7.MouseEnter+=Label1_MouseEnter;
            // 
            // label6
            // 
            label6.BackColor=Color.FromArgb(255, 128, 255);
            label6.Location=new Point(108, 239);
            label6.Name="label6";
            label6.Size=new Size(654, 23);
            label6.TabIndex=5;
            label6.MouseEnter+=Label1_MouseEnter;
            // 
            // label5
            // 
            label5.BackColor=Color.FromArgb(255, 128, 255);
            label5.Location=new Point(14, 92);
            label5.Name="label5";
            label5.Size=new Size(32, 348);
            label5.TabIndex=4;
            label5.MouseEnter+=Label1_MouseEnter;
            // 
            // label4
            // 
            label4.BackColor=Color.FromArgb(255, 128, 255);
            label4.Location=new Point(108, 175);
            label4.Name="label4";
            label4.Size=new Size(654, 23);
            label4.TabIndex=3;
            label4.MouseEnter+=Label1_MouseEnter;
            // 
            // label3
            // 
            label3.BackColor=Color.FromArgb(255, 128, 255);
            label3.Location=new Point(758, 31);
            label3.Name="label3";
            label3.Size=new Size(32, 409);
            label3.TabIndex=3;
            label3.MouseEnter+=Label1_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}