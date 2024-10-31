/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 10/10/2024
 * Time: 11:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alfombras_de_luz
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.BTNDesarrolloBack = new System.Windows.Forms.Button();
			this.BTNDesarrolloNext = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LBLintro1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LBLintro2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BTNDesarrolloBack
			// 
			this.BTNDesarrolloBack.Location = new System.Drawing.Point(11, 427);
			this.BTNDesarrolloBack.Margin = new System.Windows.Forms.Padding(2);
			this.BTNDesarrolloBack.Name = "BTNDesarrolloBack";
			this.BTNDesarrolloBack.Size = new System.Drawing.Size(23, 28);
			this.BTNDesarrolloBack.TabIndex = 0;
			this.BTNDesarrolloBack.Text = "<";
			this.BTNDesarrolloBack.UseVisualStyleBackColor = true;
			this.BTNDesarrolloBack.Click += new System.EventHandler(this.BTNDesarrolloBackClick);
			// 
			// BTNDesarrolloNext
			// 
			this.BTNDesarrolloNext.Location = new System.Drawing.Point(340, 427);
			this.BTNDesarrolloNext.Margin = new System.Windows.Forms.Padding(2);
			this.BTNDesarrolloNext.Name = "BTNDesarrolloNext";
			this.BTNDesarrolloNext.Size = new System.Drawing.Size(23, 28);
			this.BTNDesarrolloNext.TabIndex = 1;
			this.BTNDesarrolloNext.Text = ">";
			this.BTNDesarrolloNext.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Crimson;
			this.label1.Location = new System.Drawing.Point(59, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 50);
			this.label1.TabIndex = 2;
			this.label1.Text = "INTRODUCCION";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Objetivo: ";
			// 
			// LBLintro1
			// 
			this.LBLintro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLintro1.Location = new System.Drawing.Point(23, 80);
			this.LBLintro1.Name = "LBLintro1";
			this.LBLintro1.Size = new System.Drawing.Size(327, 132);
			this.LBLintro1.TabIndex = 4;
			this.LBLintro1.Text = resources.GetString("LBLintro1.Text");
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(114, 204);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// LBLintro2
			// 
			this.LBLintro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLintro2.Location = new System.Drawing.Point(23, 305);
			this.LBLintro2.Name = "LBLintro2";
			this.LBLintro2.Size = new System.Drawing.Size(327, 109);
			this.LBLintro2.TabIndex = 6;
			this.LBLintro2.Text = resources.GetString("LBLintro2.Text");
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 466);
			this.Controls.Add(this.LBLintro2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.LBLintro1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BTNDesarrolloNext);
			this.Controls.Add(this.BTNDesarrolloBack);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Label LBLintro2;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label LBLintro1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BTNDesarrolloNext;
		private System.Windows.Forms.Button BTNDesarrolloBack;
	}
}
