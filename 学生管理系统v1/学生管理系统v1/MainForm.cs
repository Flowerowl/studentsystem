/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/21
 * 时间: 8:43
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
namespace 学生管理系统v1
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		
		
       	
		void MainFormLoad(object sender, EventArgs e)
		{
			textBox2.PasswordChar ='*';
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text==""||textBox2.Text=="")
			{
				MessageBox.Show(this,"输入信息不完整，请重新输入","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else if(!radioButton1.Checked&&!radioButton2.Checked)
			{
				MessageBox.Show(this,"没有选择用户类型，请重新选择","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				string Path=Application.StartupPath+"\\System.accdb";
				//连接数据库的路径及数据库名
				string Str="Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+Path;
				//生成连接数据库字符串
				OleDbConnection Connect=new OleDbConnection(Str);
				//定义OleDbConnection对象实例并连接数据库
				Connect.Open();
				if(radioButton1.Checked)
				{
					string Sql="select * from Administrator where Account='"+textBox1.Text+"'and Key='"+textBox2.Text+"'";
					OleDbDataAdapter Data=new OleDbDataAdapter(Sql,Connect);
					DataTable Table=new DataTable();
					Data.Fill(Table);
					int i=Table.Rows.Count;
					if(i>=1)
					{
						this.Hide();
						Main MainDock=new Main();
						MainDock.UserName=textBox1.Text;
						MainDock.UserPower="超级权限";
						MainDock.ShowDialog();
						
						if(!CheckFormIsOpen("学生管理系统"))
							this.Close();
					}
					else
					{
						MessageBox.Show(this,"您输入的账号密码不对，请重新输入","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
				}
				
				else if(radioButton2.Checked)
				if(radioButton2.Checked)
				{
					string Sql="select * from Guest where Account='"+textBox1.Text+"'and Key='"+textBox2.Text+"'";
					OleDbDataAdapter Data=new OleDbDataAdapter(Sql,Connect);
					DataTable Table=new DataTable();
					Data.Fill(Table);
					int i=Table.Rows.Count;
					if(i>=1)
					{
						this.Hide();
						Main MainDock=new Main();
						MainDock.UserName=textBox1.Text;
						MainDock.UserPower="普通权限";
						
						MainDock.ShowDialog();
						
						if(!CheckFormIsOpen("学生管理系统"))
							this.Close();
					}
					else
					{
						MessageBox.Show(this,"您输入的账号密码不对，请重新输入","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
				}
		
			} 
		}
		private bool CheckFormIsOpen(string FormName)
        {
            bool Result = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == FormName)
                {
                    Result = true;
                    break;
                }
            }
            return Result;
        }
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}
	}
}
