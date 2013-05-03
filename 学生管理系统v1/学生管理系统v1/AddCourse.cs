/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/24
 * 时间: 20:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class AddCourse : Form
	{
		public AddCourse()
		{

			InitializeComponent();
			

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text==""||textBox2.Text=="")
			{
				MessageBox.Show(this,"信息不完整，请重新填写","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
			string Sql2="select Cno from Course where Cno="+textBox1.Text.Trim();
			if(!Select(Sql2))
			{
				MessageBox.Show(this,"","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				string Sql="insert into Course(Cno,Cname) values("+textBox1.Text.Trim()+",'"+textBox2.Text.Trim()+"')";
				dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Insert);
				
			}
			else
			{
				MessageBox.Show(this,textBox1.Text+"已经存在","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
