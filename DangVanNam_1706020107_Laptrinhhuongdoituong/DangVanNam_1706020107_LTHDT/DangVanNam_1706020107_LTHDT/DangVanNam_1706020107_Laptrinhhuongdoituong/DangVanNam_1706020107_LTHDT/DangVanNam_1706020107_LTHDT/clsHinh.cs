/*
 * Created by SharpDevelop.
 * User: Dang Van Nam
 * Date: 1/8/2019
 * Time: 9:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;


namespace DangVanNam_1706020107_LTHDT
{
	/// <summary>
	/// Description of clsHinh.
	/// </summary>
	public class clsHinh
	{
		clsDiem d1, d2;
		public clsDiem D1
		{
			get
			{
				return d1;
			}
			set
			{
				d1.X = value.X;
				d1.Y = value.Y;
			}
		}
		public clsDiem D2
		{
			get
			{
				return d2;
			}
			set
			{
				d2.X = value.X;
				d2.Y = value.Y;
			}
		}
		public clsHinh()
		{
			d1 = new clsDiem();
			d2 = new clsDiem();
		}
		public virtual void Draw(Graphics g, Pen p)
		{
		}
		
	}
}