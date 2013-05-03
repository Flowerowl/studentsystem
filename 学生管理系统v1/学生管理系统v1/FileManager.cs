/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/23
 * 时间: 14:16
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

	public partial class FileManager : WeifenLuo.WinFormsUI.Docking.DockContent
	{
		public FileManager()
		{

			InitializeComponent();

		}
		static string z="";
		static string Path=Application.StartupPath+"\\System.accdb";
		static string Str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Path;
		void Fresh()
		{
			string Sql="select * from File";
			dataGridView1.DataSource=DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Select);
		}
		void FileManagerLoad(object sender, EventArgs e)
		{		
			Fresh();
			comboBox1.Items.Add("男");
			comboBox1.Items.Add("女");
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(z!=textBox1.Text)
			{
				string Sql2="update File set File.Sno="+textBox1.Text;
				DBHelper.ExecSql(Sql2,Str,DBHelper.OperateType.Update);
			}
			string Sql="update File set File.Sname= '"+textBox2.Text+"',File.Ssex='"+comboBox1.Text+"',File.Born='"+dateTimePicker1.Text+"',File.Bno="+textBox5.Text+",File.Tel="+textBox6.Text+",File.Address='"+textBox7.Text+"',File.Other='"+textBox4.Text+"' where File.Sno="+textBox1.Text;
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Update);
			Fresh();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string Sql="delete from File where Sno="+textBox1.Text;
			DBHelper.ExecSql(Sql,Str,DBHelper.OperateType.Delete);
			Fresh();
		}

		void DataGridView1Click(object sender, EventArgs e)
		{
			try{
			z=dataGridView1.CurrentRow.Cells[0].Value.ToString();
		 	textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            dateTimePicker1.Value=Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
           
            textBox5.Text =dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }catch{}

		}
		
		void Button3Click(object sender, EventArgs e)
		{
			AddFile AddFileDock=new AddFile();
			AddFileDock.ShowDialog();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Fresh();
		}
	}
}
