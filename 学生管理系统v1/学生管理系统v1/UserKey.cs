/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/22
 * 时间: 20:37
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class UserKey : Form
	{
		public UserKey()
		{

			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		private string name;
		private string power;
		public string UserPower
		{
			get{return power;}
			set{power=value;}
		}
        public string UserName
        {
            get { return name; }
            set { name = value; }
        }
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text=="")
			{
				MessageBox.Show(this,"密码不能为空，请重新输入","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else if(textBox1.Text!=textBox2.Text)
			{
				MessageBox.Show(this,"两次密码不相同，请重新输入","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
			}
			else
			{	
				if(label4.Text=="超级权限")
				{
					string Sql="update Administrator set Administrator.Key= '"+textBox1.Text+"'where Administrator.Account='"+label3.Text+"'";
					DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Update);
					
					MessageBox.Show(this,"修改成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					string Sql="update Guest set Guest.Key= '"+textBox1.Text+"'where Guest.Account='"+label3.Text+"'";
					DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Update);
					
				}
			}
			
		}
		
		void UserKeyLoad(object sender, EventArgs e)
		{
			label3.Text=name;
			label4.Text=power;
		}
	}
}
