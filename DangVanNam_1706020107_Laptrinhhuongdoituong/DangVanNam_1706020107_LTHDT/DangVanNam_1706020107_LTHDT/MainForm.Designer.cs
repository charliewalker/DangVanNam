/*
 * Created by SharpDevelop.
 * User: Dang Van Nam
 * Date: 1/8/2019
 * Time: 8:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DangVanNam_1706020107_LTHDT
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox PbDraw;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbTamgiac;
		private System.Windows.Forms.ToolStripButton tsbHinhthoi;
		private System.Windows.Forms.ToolStripButton tsbSave;
		private System.Windows.Forms.ToolStripButton tsbLoad;
		private System.Windows.Forms.ToolStripButton tsbDuongThang;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbDuongThang = new System.Windows.Forms.ToolStripButton();
			this.tsbTamgiac = new System.Windows.Forms.ToolStripButton();
			this.tsbHinhthoi = new System.Windows.Forms.ToolStripButton();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.tsbLoad = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.PbDraw)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PbDraw
			// 
			this.PbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PbDraw.Location = new System.Drawing.Point(0, 28);
			this.PbDraw.Name = "PbDraw";
			this.PbDraw.Size = new System.Drawing.Size(446, 235);
			this.PbDraw.TabIndex = 1;
			this.PbDraw.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsbDuongThang,
			this.tsbTamgiac,
			this.tsbHinhthoi,
			this.tsbSave,
			this.tsbLoad});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(446, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbDuongThang
			// 
			this.tsbDuongThang.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuongThang.Image")));
			this.tsbDuongThang.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDuongThang.Name = "tsbDuongThang";
			this.tsbDuongThang.Size = new System.Drawing.Size(100, 22);
			this.tsbDuongThang.Text = "Đường Thẳng";
			// 
			// tsbTamgiac
			// 
			this.tsbTamgiac.Image = ((System.Drawing.Image)(resources.GetObject("tsbTamgiac.Image")));
			this.tsbTamgiac.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTamgiac.Name = "tsbTamgiac";
			this.tsbTamgiac.Size = new System.Drawing.Size(75, 22);
			this.tsbTamgiac.Text = "Tam giác";
			// 
			// tsbHinhthoi
			// 
			this.tsbHinhthoi.Image = ((System.Drawing.Image)(resources.GetObject("tsbHinhthoi.Image")));
			this.tsbHinhthoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHinhthoi.Name = "tsbHinhthoi";
			this.tsbHinhthoi.Size = new System.Drawing.Size(77, 22);
			this.tsbHinhthoi.Text = "Hình thoi";
			// 
			// tsbSave
			// 
			this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(35, 22);
			this.tsbSave.Text = "Save";
			// 
			// tsbLoad
			// 
			this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
			this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLoad.Name = "tsbLoad";
			this.tsbLoad.Size = new System.Drawing.Size(37, 22);
			this.tsbLoad.Text = "Load";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 307);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.PbDraw);
			this.Name = "MainForm";
			this.Text = "DangVanNam_1706020107_LTHDT";
		
			((System.ComponentModel.ISupportInitialize)(this.PbDraw)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
