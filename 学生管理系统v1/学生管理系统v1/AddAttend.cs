/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/23
 * 时间: 16:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class AddAttend : Form
	{
		public AddAttend()
		{

			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text==""||textBox2.Text==""||comboBox1.Text==""||comboBox2.Text==""||dateTimePicker1.Value.ToString()=="")
			{
				MessageBox.Show(this,"信息不完整，请重新填写","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				string Sql="insert into Attend(Sno,Cno,Ckind,Ctime,Cture,Other) values("+textBox1.Text.Trim()+","+textBox2.Text.Trim()+",'"+comboBox1.Text.Trim()+"','"+dateTimePicker1.Text.Trim()+"','"+comboBox2.Text.Trim()+"','"+textBox8.Text.Trim()+"')";
				dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Insert);
			}
		}
		
		
		void AddAttendLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("走读");
			comboBox1.Items.Add("全日制");
			comboBox1.Items.Add("函授");
			comboBox2.Items.Add("正常");
			comboBox2.Items.Add("迟到");
			comboBox2.Items.Add("早退");
			comboBox2.Items.Add("旷课");
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
	}
}
