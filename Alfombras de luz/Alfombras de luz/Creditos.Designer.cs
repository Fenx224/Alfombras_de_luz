/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 31/10/2024
 * Time: 12:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alfombras_de_luz
{
	partial class Creditos
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
			this.LBLcredits = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BTNrein = new System.Windows.Forms.Button();
			this.BTNbackcreditos = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LBLcredits
			// 
			this.LBLcredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLcredits.Location = new System.Drawing.Point(136, 9);
			this.LBLcredits.Name = "LBLcredits";
			this.LBLcredits.Size = new System.Drawing.Size(140, 37);
			this.LBLcredits.TabIndex = 0;
			this.LBLcredits.Text = "Creditos";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(365, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Jose de Jesus Zavala Garcia: Menu de inicio y Creditos.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Hugo Antonio Martinez Guzman: Pagina 3 y 4.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(365, 31);
			this.label3.TabIndex = 3;
			this.label3.Text = "Dana Camila Orozco Nieto: Pagina 5 y 6.";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(27, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(365, 31);
			this.label4.TabIndex = 4;
			this.label4.Text = "Miguel Alejandro Perez Mendez: Pagina 7 y traduccion.";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(27, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(365, 31);
			this.label5.TabIndex = 5;
			this.label5.Text = "Alan Alexis Gonzales Basquez: Introduccion.";
			// 
			// BTNrein
			// 
			this.BTNrein.Location = new System.Drawing.Point(162, 453);
			this.BTNrein.Name = "BTNrein";
			this.BTNrein.Size = new System.Drawing.Size(102, 47);
			this.BTNrein.TabIndex = 6;
			this.BTNrein.Text = "Regresar al inicio";
			this.BTNrein.UseVisualStyleBackColor = true;
			// 
			// BTNbackcreditos
			// 
			this.BTNbackcreditos.Location = new System.Drawing.Point(13, 459);
			this.BTNbackcreditos.Name = "BTNbackcreditos";
			this.BTNbackcreditos.Size = new System.Drawing.Size(34, 34);
			this.BTNbackcreditos.TabIndex = 7;
			this.BTNbackcreditos.Text = "<";
			this.BTNbackcreditos.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(117, 309);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(178, 36);
			this.label6.TabIndex = 8;
			this.label6.Text = "¿Que tan satisfecho estas con esta revista?";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(174, 348);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 9;
			this.button2.Text = "Encuesta";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Creditos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 505);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.BTNbackcreditos);
			this.Controls.Add(this.BTNrein);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LBLcredits);
			this.Name = "Creditos";
			this.Text = "Creditos";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BTNbackcreditos;
		private System.Windows.Forms.Button BTNrein;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LBLcredits;
	}
}
