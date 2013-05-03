/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/26
 * 时间: 7:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class User : WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public User()
		{

			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Button6Click(object sender, EventArgs e)
		{
			string Sql="select * from Administrator union all select * from Guest ";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		
	}
}
