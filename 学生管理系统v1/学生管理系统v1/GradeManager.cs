/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/23
 * 时间: 23:04
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

	public partial class GradeManager : WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public GradeManager()
		{

			InitializeComponent();
			

		}
		static string z;
		static string x;
		
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Fresh()
		{
			string Sql="select * from SC";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		void Button4Click(object sender, EventArgs e)
		{
			Fresh();
		}
		
		void GradeManagerLoad(object sender, EventArgs e)
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
		
		void DataGridView1Click(object sender, EventArgs e)
		{
			try{
				z=dataGridView1.CurrentRow.Cells[0].Value.ToString();
				x=dataGridView1.CurrentRow.Cells[1].Value.ToString();
		 	textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            comboBox3.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
            comboBox2.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString(); 
            comboBox4.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString(); 
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }catch{}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			AddGrade z=new AddGrade();
			z.ShowDialog();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string Sql="delete from SC where Sno="+textBox1.Text+" and Cno="+textBox3.Text;
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Delete);
			Fresh();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(z!=textBox1.Text||x!=textBox3.Text)
			{MessageBox.Show(this,x,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
				string Sql2="update SC set SC.Sno="+textBox1.Text+",SC.Cno="+textBox3.Text+" where SC.Sno="+z+" and SC.Cno="+x;
				DBHelper.ExecSql(Sql2,Str,DBHelper.OperateType.Update);
			}
			string Sql="update SC set SC.Ctime= '"+textBox6.Text+"',SC.Credit='"+comboBox3.Text+"',SC.Teacher='"+textBox2.Text+"',SC.Grade="+textBox4.Text+",SC.Years='"+comboBox2.Text+"',SC.Semester='"+comboBox4.Text+"',SC.Other='"+textBox5.Text+"'where SC.Sno="+textBox1.Text+" and SC.Cno="+textBox3.Text;
			
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Update);
			Fresh();
		}
	}
}
