/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 30/04/2024
 * Time: 19:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace manipulação_de_strings
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			String s = textBox1.Text;
			String t = textBox2.Text;
			String k = t + s;
			
			for(int i = 0; i < k.Length; i++)
			{
				if(i < s.Length)
				{
					listBox1.Items.Add(s[i]);
				}
				if(i < t.Length)
				{
					listBox1.Items.Add(t[i]);
				}
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
