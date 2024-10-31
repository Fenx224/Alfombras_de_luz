/*
 * Created by SharpDevelop.
 * User: CC1_PC20
 * Date: 31/10/2024
 * Time: 11:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alfombras_de_luz
{
	partial class virgen_res
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(virgen_res));
			this.BTNnext = new System.Windows.Forms.Button();
			this.BTNback = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblm1 = new System.Windows.Forms.Label();
			this.lblm2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// BTNnext
			// 
			this.BTNnext.Location = new System.Drawing.Point(291, 388);
			this.BTNnext.Name = "BTNnext";
			this.BTNnext.Size = new System.Drawing.Size(27, 30);
			this.BTNnext.TabIndex = 0;
			this.BTNnext.Text = ">";
			this.BTNnext.UseVisualStyleBackColor = true;
			// 
			// BTNback
			// 
			this.BTNback.Location = new System.Drawing.Point(18, 388);
			this.BTNback.Name = "BTNback";
			this.BTNback.Size = new System.Drawing.Size(27, 30);
			this.BTNback.TabIndex = 1;
			this.BTNback.Text = "<";
			this.BTNback.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(126, 165);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(15, 178);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(126, 165);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// lblm1
			// 
			this.lblm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblm1.Location = new System.Drawing.Point(153, 9);
			this.lblm1.Name = "lblm1";
			this.lblm1.Size = new System.Drawing.Size(146, 162);
			this.lblm1.TabIndex = 4;
			this.lblm1.Text = resources.GetString("lblm1.Text");
			// 
			// lblm2
			// 
			this.lblm2.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblm2.Location = new System.Drawing.Point(154, 178);
			this.lblm2.Name = "lblm2";
			this.lblm2.Size = new System.Drawing.Size(146, 162);
			this.lblm2.TabIndex = 5;
			this.lblm2.Text = resources.GetString("lblm2.Text");
			this.lblm2.Click += new System.EventHandler(this.Lblm2Click);
			// 
			// virgen_res
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 423);
			this.Controls.Add(this.lblm2);
			this.Controls.Add(this.lblm1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BTNback);
			this.Controls.Add(this.BTNnext);
			this.Name = "virgen_res";
			this.Text = "virgen_res";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblm2;
		private System.Windows.Forms.Label lblm1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Button BTNback;
		public System.Windows.Forms.Button BTNnext;
	}
}
