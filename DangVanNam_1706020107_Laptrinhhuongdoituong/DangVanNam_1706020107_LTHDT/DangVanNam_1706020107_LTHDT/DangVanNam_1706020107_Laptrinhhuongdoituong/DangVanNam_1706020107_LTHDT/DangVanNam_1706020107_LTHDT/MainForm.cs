/*
 * Created by SharpDevelop.
 * User: Dang Van Nam
 * Date: 1/8/2019
 * Time: 8:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DangVanNam_1706020107_LTHDT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        clsDiem D1 = new clsDiem();
        clsDiem D2 = new clsDiem();
        bool isDrawing = false;
        List<clsHinh> lsHinh = new List<clsHinh>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tsbDuongThang.Checked == true)
            {
                isDrawing = true;
                D1.X = e.X;
                D1.Y = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                if (tsbDuongThang.Checked ==true)
                
                {
					Graphics g = PbDraw.CreateGraphics();
					g.DrawLine(new Pen(Color.White),D1.X,D1.Y,D2.X,D2.Y);
					D2.X = e.X;
					D2.Y = e.Y;
					foreach (var element in lsHinh)
                    {
                        element.Draw(g, new Pen(Color.Black));
                    }
                    g.DrawLine(new Pen(Color.Black), D1.X, D1.Y, D2.X, D2.Y);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tsbDuongThang.Checked == true)
            
             {
				D2.X = e.X;
				D2.Y = e.Y;
				g = PbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				isDrawing = false;
				
//				clsLine l = new clsLine();
//				l.D1 = D1;
//				l.D2 = D2;
				clsLine l = new clsLine(D1,D2);
				lsHinh.Add(l);
				foreach (var element in lsHinh)
                {
                    element.Draw(g, new Pen(Color.Black));
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
           
        }
    }
}
	
	