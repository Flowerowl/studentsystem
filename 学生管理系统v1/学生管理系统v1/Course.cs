/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/24
 * 时间: 21:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class Course :WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public Course()
		{


			InitializeComponent();
			

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Button6Click(object sender, EventArgs e)
		{
			string Sql="select * from Course";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void CourseLoad(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox1.Text,Check.Checked.Int))
			{
				label5.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox1.Text,Check.Checked.Int))
			{
				label5.Text="通过";
				button1.Enabled=true;
				
			}
		}
		
		void TextBox1Enter(object sender, EventArgs e)
		{
			timer1.Start();
		}
		
		void TextBox1Leave(object sender, EventArgs e)
		{
			timer1.Stop();
			label5.Text="";
			Check.z=true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string Sql="select * from Course where Cno="+textBox1.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string Sql="select a.Sno,b.Teacher,c.* from File a,SC b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and a.Sno="+textBox2.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string Sql="select * from Course ";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox2.Text,Check.Checked.Int))
			{
				label2.Text="不通过";
				button3.Enabled=false;;
			}
			if(Check.Test(textBox2.Text,Check.Checked.Int))
			{
				label2.Text="通过";
				button3.Enabled=true;
				
			}
		}
		
		void TextBox2Enter(object sender, EventArgs e)
		{
			timer2.Start();
		}
		
		void TextBox2Leave(object sender, EventArgs e)
		{
			
			timer2.Stop();
			label2.Text="";
			Check.z=true;
		}
	}
}
