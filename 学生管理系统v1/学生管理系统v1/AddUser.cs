/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/26
 * 时间: 7:08
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class AddUser : Form
	{
		public AddUser()
		{

			InitializeComponent();
			

		}
		
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		static string Sql2="";
		void AddUserLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("超级权限");
			comboBox1.Items.Add("普通权限");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text==""||textBox2.Text==""||comboBox1.Text=="")
			{
				MessageBox.Show(this,"信息不完整，请重新填写","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			if(comboBox1.Text=="超级权限")
			{
				Sql2="select Account from Administrator where Account='"+textBox1.Text.Trim()+"'";
				if(!Select(Sql2))
				{
					string Sql="insert into Administrator(Account,Key,Other) values('"+textBox1.Text.Trim()+"','"+textBox2.Text.Trim()+"','"+comboBox1.Text+"')";
					dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Insert);
				}
				else
				{
					MessageBox.Show(this,textBox1.Text+"已经存在","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			else if(comboBox1.Text=="普通权限")
			{
				Sql2="select Account from Guest where Account='"+textBox1.Text.Trim()+"'";
				if(!Select(Sql2))
				{
					string Sql="insert into Guest(Account,Key,Other) values('"+textBox1.Text.Trim()+"','"+textBox2.Text.Trim()+"','"+comboBox1.Text+"')";
					dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Insert);
				}
				else
				{
					MessageBox.Show(this,textBox1.Text+"已经存在","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			
			
			
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
	}
}
