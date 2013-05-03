/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/22
 * 时间: 3:49
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

	public partial class AddFile : Form
	{
		public AddFile()
		{

			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(textBox1.Text==""||textBox2.Text==""||textBox4.Text=="")
			{
				MessageBox.Show(this,"信息不完整，请重新填写","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			string Sql2="select Sno from File where Sno="+textBox1.Text.Trim();
			if(!Select(Sql2))
			{
				string Sql="insert into File(Sno,Sname,Ssex,Born,Bno,Tel,Address,Other) values("+"'"+textBox1.Text.Trim()+"','"+textBox2.Text.Trim()+"','"+comboBox1.SelectedItem+"','"+dateTimePicker1.Value.Date.ToShortDateString()+"','"+textBox4.Text.Trim()+"','"+textBox8.Text.Trim()+"','"+textBox7.Text.Trim()+"','"+textBox6.Text.Trim()+"'"+")";
				dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Insert);
				
			}
			else
			{
				MessageBox.Show(this,textBox1.Text+"已经存在","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
		}
		
		void AddFileLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("男");
			comboBox1.Items.Add("女");
		}
		
		bool Select (string sql)
		{
			dataGridView1.DataSource=DBHelper.ExecSql(sql,Str,DBHelper.OperateType.Select);
			int i=dataGridView1.Rows.Count;
			if(i>=2)
			{
				
				return true;
			}
			else
			{
				return false;
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
			
			if(!Check.Test(textBox2.Text,Check.Checked.Word))
			{
				label17.Text="不通过";
				button1.Enabled=false;
			}
			if(Check.Test(textBox2.Text,Check.Checked.Word))
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
			
			if(!Check.Test(textBox4.Text,Check.Checked.Int))
			{
				label18.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox4.Text,Check.Checked.Int))
			{
				label18.Text="通过";
				button1.Enabled=true;
				
			}
		}
		
		void TextBox4Enter(object sender, EventArgs e)
		{
			timer3.Start();
		}
		
		void TextBox4Leave(object sender, EventArgs e)
		{
			timer3.Stop();
			label18.Text="";
			Check.z=true;
		}
		
		void TextBox8Enter(object sender, EventArgs e)
		{
			timer4.Start();
		}
		
		void TextBox8Leave(object sender, EventArgs e)
		{
			timer4.Stop();
			label19.Text="";
			Check.z=true;
		}
		
		void Timer4Tick(object sender, EventArgs e)
		{
			Check.z=true;
			
			if(!Check.Test(textBox8.Text,Check.Checked.Int))
			{
				label19.Text="不通过";
				button1.Enabled=false;;
			}
			if(Check.Test(textBox8.Text,Check.Checked.Int))
			{
				label19.Text="通过";
				button1.Enabled=true;
				
			}
		}
	}
}
