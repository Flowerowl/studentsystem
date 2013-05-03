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
using System.Data;
using System.Data.OleDb;
namespace 学生管理系统v1
{
	

	public partial class File : WeifenLuo.WinFormsUI.Docking.DockContent
		
	{		
		
		public File()
		{
			InitializeComponent();
			
		}
		
		void FileLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("男");
			comboBox1.Items.Add("女");

		}
		
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		
		void Button1Click(object sender, EventArgs e)
		{
			string Sql="select * from File where Sno="+textBox1.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}

		void Button2Click(object sender, EventArgs e)
		{
			string Sql="select * from File where Sname="+"'"+textBox2.Text.Trim()+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string Sql="select * from File where Ssex="+"'"+comboBox1.SelectedItem+"'";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string Sql="select * from File where Bno="+textBox4.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			string Sql="select * from File where Sno="+textBox1.Text.Trim()+"and Sname="+"'"+textBox2.Text+"'"+"and Ssex="+"'"+comboBox1.Text+"'"+"and Bno="+textBox4.Text.Trim();
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string Sql="select * from File";
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
		
		void TextBox4Enter(object sender, EventArgs e)
		{
			timer2.Start();
		}
		
		void TextBox4Leave(object sender, EventArgs e)
		{
			timer2.Stop();
			label6.Text="";
			Check.z=true;
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox4.Text,Check.Checked.Int))
			{
				label6.Text="不通过";
				button4.Enabled=false;;
			}
			if(Check.Test(textBox4.Text,Check.Checked.Int))
			{
				label6.Text="通过";
				button4.Enabled=true;
				
			}
		}
		
		void Timer3Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox2.Text,Check.Checked.Text))
			{
				label7.Text="不通过";
				button2.Enabled=false;;
			}
			if(Check.Test(textBox2.Text,Check.Checked.Text))
			{
				label7.Text="通过";
				button2.Enabled=true;
			}
		}
		
		void TextBox2Enter(object sender, EventArgs e)
		{
			timer3.Start();
		
		}
		
		void TextBox2Leave(object sender, EventArgs e)
		{
			
			timer3.Stop();
			label7.Text="";
			Check.z=true;
		}
	}
}
