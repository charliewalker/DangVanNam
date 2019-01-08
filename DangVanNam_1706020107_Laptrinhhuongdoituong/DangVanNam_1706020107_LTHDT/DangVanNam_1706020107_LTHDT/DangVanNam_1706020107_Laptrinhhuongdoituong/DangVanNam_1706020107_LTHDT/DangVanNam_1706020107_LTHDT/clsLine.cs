/*
 * Created by SharpDevelop.
 * User: Dang Van Nam
 * Date: 1/8/2019
 * Time: 9:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;


namespace DangVanNam_1706020107_LTHDT
{
	/// <summary>
	/// Description of clsLine.
	/// </summary>
	public class clsLine : clsHinh
	{
		public clsLine()
		{
		}
		public clsLine(clsDiem d1, clsDiem d2)
		{
			D1 = d1;
			D2 = d2;
		}
		public override void Draw(Graphics g, Pen p)
		{
			g.DrawLine(p,D1.X,D1.Y,D2.X,D2.Y);
		}
	}
	
}
