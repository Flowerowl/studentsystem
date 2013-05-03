/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/23
 * 时间: 22:08
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class AddGrade : Form
	{
		public AddGrade()
		{

			InitializeComponent();
			

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Fresh()
		{
			string Sql="select c.Cname,a.Sname,b.Bname,d.* from File a,Class b,Course c,SC d where a.Sno = d.Sno and d.Cno=c.Cno and b.Bno=a.Bno";
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||textBox8.Text==""||comboBox2.Text==""||comboBox3.Text==""||comboBox4.Text=="")
			{
				MessageBox.Show(this,"信息不完整，请重新填写","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				string Sql="insert into SC(Sno,Cno,Ctime,Credit,Teacher,Grade,Years,Semester,Other) values("+textBox1.Text.Trim()+","+textBox2.Text.Trim()+","+textBox3.Text.Trim()+",'"+comboBox2.Text.Trim()+"','"+textBox4.Text.Trim()+"',"+textBox8.Text.Trim()+",'"+comboBox3.Text.Trim()+"','"+comboBox4.Text.Trim()+"','"+textBox6.Text.Trim()+"')";
				DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Insert);
			}
		}
		
		void AddGradeLoad(object sender, EventArgs e)
		{
			
			for(int i=1;i<=5;i++)
			{
				comboBox2.Items.Add(i);
			}
			comboBox4.Items.Add("上");
			comboBox4.Items.Add("下");
			int m=2000 ;int j=2001;
			
			for(;m<2012;m++,j++)
			{
				
				comboBox3.Items.Add(m+"-"+j);
			}
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox1.Text,Check.Checked.Int))
			{
				label16.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox1.Text,Check.Checked.Int))
			{
				label16.Text="通过";
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
			label16.Text="";
			Check.z=true;
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox2.Text,Check.Checked.Int))
			{
				label17.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox2.Text,Check.Checked.Int))
			{
				label17.Text="通过";
				button1.Enabled=true;
				
			}
		}
		
		void TextBox2Enter(object sender, EventArgs e)
		{
			timer2.Start();
		}
		
		void TextBox2Leave(object sender, EventArgs e)
		{
			timer2.Stop();
			label17.Text="";
			Check.z=true;
		}
		
		void Timer3Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox3.Text,Check.Checked.Int))
			{
				label20.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox3.Text,Check.Checked.Int))
			{
				label20.Text="通过";
				button1.Enabled=true;
				
			}
		}
		
		
		void TextBox3Enter(object sender, EventArgs e)
		{
			timer3.Start();
		}
		
		void TextBox3Leave(object sender, EventArgs e)
		{
			timer3.Stop();
			label20.Text="";
			Check.z=true;
		}
		
		void Timer4Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox4.Text,Check.Checked.Word))
			{
				label18.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox4.Text,Check.Checked.Word))
			{
				label18.Text="通过";
				button1.Enabled=true;
				
			}
		}
		
		void TextBox4Enter(object sender, EventArgs e)
		{
			timer4.Start();
		}
		
		void TextBox4Leave(object sender, EventArgs e)
		{
			timer4.Stop();
			label18.Text="";
			Check.z=true;
		}
		
		void Timer5Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox8.Text,Check.Checked.Word))
			{
				label19.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox8.Text,Check.Checked.Word))
			{
				label19.Text="通过";
				button1.Enabled=true;
				
			}
		}
		
		void TextBox8Enter(object sender, EventArgs e)
		{
			timer5.Start();
		}
		
		void TextBox8Leave(object sender, EventArgs e)
		{
			timer5.Stop();
			label19.Text="";
			Check.z=true;
		}
	}
}
