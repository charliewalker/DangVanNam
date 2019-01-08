/*
 * Created by SharpDevelop.
 * User: Dang Van Nam
 * Date: 1/8/2019
 * Time: 9:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;

namespace DangVanNam_1706020107_LTHDT
{
	/// <summary>
	/// Description of clsDiem.
	/// </summary>
	public class clsDiem
	{
		int ix, iy;
		public int X
		{
			get
			{
				return ix;
			}
			set
			{
				ix = value;
			}
		}
		public int Y
		{
			get
			{
				return iy;
			}
			set
			{
				iy = value;
			}
		}
		public clsDiem()
		{
			X=0;
			Y=0;
		}
		public clsDiem(int a, int b)
		{
			X = a;
			Y = b;
		}
	}
}
