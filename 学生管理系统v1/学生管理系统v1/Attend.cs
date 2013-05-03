/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/21
 * 时间: 8:46
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class Attend : WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public Attend()
		{
	
			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		
		void AttendLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("走读");
			comboBox1.Items.Add("全日制");
			comboBox1.Items.Add("函授");
			comboBox2.Items.Add("正常");
			comboBox2.Items.Add("迟到");
			comboBox2.Items.Add("早退");
			comboBox2.Items.Add("旷课");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and a.Sno="+textBox1.Text;
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and b.Cno="+textBox2.Text.Trim()+" and a.Sno="+textBox1.Text.Trim()+" and b.Ckind='"+comboBox1.Text.Trim()+"'and b.Ctime='"+dateTimePicker1.Text.Trim()+"' and b.Cture='"+comboBox2.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and b.Cno="+textBox2.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and b.Ckind='"+comboBox1.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and b.Ctime='"+dateTimePicker1.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno and b.Cture='"+comboBox2.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
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
		
		void Timer2Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox2.Text,Check.Checked.Int))
			{
				label7.Text="不通过";
				button2.Enabled=false;;
			}
			if(Check.Test(textBox2.Text,Check.Checked.Int))
			{
				label7.Text="通过";
				button2.Enabled=true;
				
			}
		}
		
		void TextBox2Enter(object sender, EventArgs e)
		{
			timer2.Start();
		}
		
		void TextBox2Leave(object sender, EventArgs e)
		{
			timer2.Stop();
			label7.Text="";
			Check.z=true;
		}
	}
}
