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

	public partial class Grade : WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public Grade()
		{

			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Fresh()
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno  ";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		void GradeLoad(object sender, EventArgs e)
		{
			Fresh();
			for(int i=1;i<=5;i++)
			{
				comboBox3.Items.Add(i);
			}
			comboBox4.Items.Add("上");
			comboBox4.Items.Add("下");
			int m=2000 ;int j=2001;
			
			for(;m<2012;m++,j++)
			{
				
				comboBox2.Items.Add(m+"-"+j);
			}
			
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and a.Sno="+textBox1.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and c.Cno="+textBox2.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and d.Ctime="+textBox4.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and d.Credit="+comboBox3.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and d.Teacher='"+textBox6.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and d.Years='"+comboBox2.Text.Trim()+"' and d.Semester='"+comboBox4.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno and a.Bno="+textBox3.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno";
			
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno";
			
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
		
		void Timer3Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox4.Text,Check.Checked.Int))
			{
				label9.Text="不通过";
				button3.Enabled=false;;
			}
			if(Check.Test(textBox4.Text,Check.Checked.Int))
			{
				label9.Text="通过";
				button3.Enabled=true;
				
			}
		}
		
		void TextBox4Enter(object sender, EventArgs e)
		{
			timer3.Start();
		}
		
		void TextBox4Leave(object sender, EventArgs e)
		{
			timer3.Stop();
			label9.Text="";
			Check.z=true;
		}
		
		void Timer4Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox6.Text,Check.Checked.Word))
			{
				label9.Text="不通过";
				button10.Enabled=false;;
			}
			if(Check.Test(textBox6.Text,Check.Checked.Word))
			{
				label10.Text="通过";
				button10.Enabled=true;
				
			}
		}
		
		void TextBox6Enter(object sender, EventArgs e)
		{
			timer4.Start();
		}
		
		void TextBox6Leave(object sender, EventArgs e)
		{
			timer4.Stop();
			label10.Text="";
			Check.z=true;
		}
		
		void Timer5Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox3.Text,Check.Checked.Int))
			{
				label6.Text="不通过";
				button7.Enabled=false;;
			}
			if(Check.Test(textBox3.Text,Check.Checked.Int))
			{
				label6.Text="通过";
				button7.Enabled=true;
				
			}
		}
		
		void TextBox3Enter(object sender, EventArgs e)
		{
			timer5.Start();
		}
		
		void TextBox3Leave(object sender, EventArgs e)
		{
			timer5.Stop();
			label6.Text="";
			Check.z=true;
		}
	}
}
