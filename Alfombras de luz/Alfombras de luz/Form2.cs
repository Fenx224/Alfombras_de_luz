/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 10/10/2024
 * Time: 11:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfombras_de_luz
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BTNDesarrolloBackClick(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Close();
		}
		
	
	}
}
