/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/23
 * 时间: 19:51
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生管理系统v1
{

	public partial class AttendManager : WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public AttendManager()
		{

			InitializeComponent();

		}
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Fresh()
		{
			string Sql="select a.Sname,a.Ssex,a.Bno,c.Cname,b.* from File a,Attend b,Course c where a.Sno=b.Sno and b.Cno=c.Cno";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}

		
		void AttendManagerLoad(object sender, EventArgs e)
		{
			Fresh();
			comboBox1.Items.Add("走读");
			comboBox1.Items.Add("全日制");
			comboBox1.Items.Add("函授");
			comboBox2.Items.Add("正常");
			comboBox2.Items.Add("迟到");
			comboBox2.Items.Add("早退");
			comboBox2.Items.Add("旷课");
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			
			Fresh();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			AddAttend z=new AddAttend();
			z.ShowDialog();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string Sql="delete from Attend where Sno=where Sno="+textBox1.Text+" and Cno="+textBox3.Text+" and Ckind='"+comboBox1.Text.Trim()+"' and Ctime='"+dateTimePicker1.Text.Trim()+"' and Cture='"+comboBox2.Text+"' and Other='"+textBox2.Text+"'" ;
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Delete);
			Fresh();
		}
		
		void DataGridView1Click(object sender, EventArgs e)
		{
			try{
		 	textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();		
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Value=Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();         
            textBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           
			}catch{}

		}
		
		void Button1Click(object sender, EventArgs e)
		{ 
			string Sql="update Attend set Attend.Ckind= '"+comboBox1.Text+"',Attend.Ctime='"+dateTimePicker1.Text.Trim()+"',Attend.Cture='"+comboBox2.Text+"',Attend.Other='"+textBox2.Text+"' where Attend.Sno="+textBox1.Text+" and Attend.Cno= "+textBox3.Text;
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Update);
			Fresh();
		}
	}
}
