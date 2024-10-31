/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 10/10/2024
 * Time: 11:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alfombras_de_luz
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BTNmenusig = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LBLtitulo1menu = new System.Windows.Forms.Label();
			this.Titulo2menu = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BTNmenusig
			// 
			this.BTNmenusig.Location = new System.Drawing.Point(292, 387);
			this.BTNmenusig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BTNmenusig.Name = "BTNmenusig";
			this.BTNmenusig.Size = new System.Drawing.Size(27, 30);
			this.BTNmenusig.TabIndex = 0;
			this.BTNmenusig.Text = ">";
			this.BTNmenusig.UseVisualStyleBackColor = true;
			this.BTNmenusig.Click += new System.EventHandler(this.BTNmenusigClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(58, 122);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(214, 202);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// LBLtitulo1menu
			// 
			this.LBLtitulo1menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLtitulo1menu.Location = new System.Drawing.Point(69, 20);
			this.LBLtitulo1menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LBLtitulo1menu.Name = "LBLtitulo1menu";
			this.LBLtitulo1menu.Size = new System.Drawing.Size(189, 32);
			this.LBLtitulo1menu.TabIndex = 2;
			this.LBLtitulo1menu.Text = "Alfombras de luz:";
			// 
			// Titulo2menu
			// 
			this.Titulo2menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo2menu.Location = new System.Drawing.Point(76, 47);
			this.Titulo2menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Titulo2menu.Name = "Titulo2menu";
			this.Titulo2menu.Size = new System.Drawing.Size(182, 23);
			this.Titulo2menu.TabIndex = 3;
			this.Titulo2menu.Text = "La magia de Uriangato";
			this.Titulo2menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(328, 427);
			this.Controls.Add(this.Titulo2menu);
			this.Controls.Add(this.LBLtitulo1menu);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BTNmenusig);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "Alfombras de luz";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label Titulo2menu;
		private System.Windows.Forms.Label LBLtitulo1menu;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BTNmenusig;
	}
}
