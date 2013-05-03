/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/21
 * 时间: 8:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{

			InitializeComponent();
			

		}
		
		void AboutLoad(object sender, EventArgs e)
		{
			
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			 System.Diagnostics .Process.Start("http://lazynight.me");
		}
	}
}
