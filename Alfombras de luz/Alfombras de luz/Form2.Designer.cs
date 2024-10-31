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
			this.BTNDesarrolloBack = new System.Windows.Forms.Button();
			this.BTNDesarrolloNext = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BTNDesarrolloBack
			// 
			this.BTNDesarrolloBack.Location = new System.Drawing.Point(9, 389);
			this.BTNDesarrolloBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BTNDesarrolloBack.Name = "BTNDesarrolloBack";
			this.BTNDesarrolloBack.Size = new System.Drawing.Size(23, 28);
			this.BTNDesarrolloBack.TabIndex = 0;
			this.BTNDesarrolloBack.Text = "<";
			this.BTNDesarrolloBack.UseVisualStyleBackColor = true;
			this.BTNDesarrolloBack.Click += new System.EventHandler(this.BTNDesarrolloBackClick);
			// 
			// BTNDesarrolloNext
			// 
			this.BTNDesarrolloNext.Location = new System.Drawing.Point(267, 389);
			this.BTNDesarrolloNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BTNDesarrolloNext.Name = "BTNDesarrolloNext";
			this.BTNDesarrolloNext.Size = new System.Drawing.Size(23, 28);
			this.BTNDesarrolloNext.TabIndex = 1;
			this.BTNDesarrolloNext.Text = ">";
			this.BTNDesarrolloNext.UseVisualStyleBackColor = true;
			this.BTNDesarrolloNext.Click += new System.EventHandler(this.BTNDesarrolloNextClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 427);
			this.Controls.Add(this.BTNDesarrolloNext);
			this.Controls.Add(this.BTNDesarrolloBack);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button BTNDesarrolloNext;
		private System.Windows.Forms.Button BTNDesarrolloBack;
	}
}
