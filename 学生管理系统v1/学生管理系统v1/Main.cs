/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/21
 * 时间: 8:45
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace 学生管理系统v1
{

	public partial class Main : Form
	{
		private string name;
		private string power;
		public string UserName
        {
            get { return name; }
            set { name = value; }
        }
		public string UserPower
		{
			get	{return power;}
			set	{power=value;}
		}
		public Main()
		{
			
			InitializeComponent();
	
		}
		
		void 退出ToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
			
		}
		
		void 关于ToolStripMenuItemClick(object sender, EventArgs e)
		{
			About AboutDock=new About();
			AboutDock.Show();
		}
		
		void MainLoad(object sender, EventArgs e)
		{
			File FileDock=new File();
			Attend AttendDock=new Attend();
			Grade GradeDock=new Grade();
			FileDock.Show(this.dockPanel1);
			AttendDock.Show(this.dockPanel1);
			GradeDock.Show(this.dockPanel1);
			this.toolStripStatusLabel2.Text = name;
			this.toolStripStatusLabel4.Text = power;
 			this.timer1.Start();
 			if(toolStripStatusLabel4.Text=="普通权限")
 			{
 				this.managefile.Visible=false;
 				this.manageuser.Visible=false;
 				this.managegrade.Visible=false;
 				this.manageattend.Visible=false;
 				this.AddAttend.Visible=false;
 				this.AddFile.Visible=false;
 				this.AddGrade.Visible=false;
 				this.AddUser.Visible=false;
 				this.FindUser.Visible=false;
 				this.AddCourse.Visible=false;
 				
 			
 				
 			}
		}
		

		void CloseAllDocuments()
        {
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                for (int index = dockPanel1.Contents.Count - 1; index >= 0; index--)
                {
                    if (dockPanel1.Contents[index] is IDockContent)
                    {
                        IDockContent content = (IDockContent)dockPanel1.Contents[index];
                        content.DockHandler.Close();
                    }
                }
            }
        }
		void 关闭全部ToolStripMenuItemClick(object sender, EventArgs e)
		{
			CloseAllDocuments();
		}
		
		void 打开全部ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(FindDocument("学籍查询")==null)
			{
				File FileDock=new File();
				FileDock.Show(this.dockPanel1);
			}
			if(FindDocument("考勤查询")==null)
			{
				Attend AttendDock=new Attend();
				AttendDock.Show(this.dockPanel1);
			}
			if(FindDocument("成绩查询")==null)
			{
				Grade GradeDock=new Grade();
				GradeDock.Show(this.dockPanel1);
			}
			if(FindDocument("课程查询")==null)
			{
				Course z=new Course();
				z.Show(this.dockPanel1);
			}
			
			
		}
		
		void 关闭此项以外ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                Form activeMdi = ActiveMdiChild;
                foreach (Form form in MdiChildren)
                {
                    if (form != activeMdi)
                        form.Close();
                }
            }
            else
            {
                foreach (IDockContent document in dockPanel1.DocumentsToArray())
                {
                    if (!document.DockHandler.IsActivated)
                        document.DockHandler.Close();
                }
            }
		}
		
	

		void Timer1Tick(object sender, EventArgs e)
		{
 			DateTime now = System.DateTime.Now;
          	this.toolStripStatusLabel6.Text= now.ToString("yyyy-MM-dd hh:mm:ss");  
		}
		
		void 添加ToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddFile AddFileDock=new AddFile();
			AddFileDock.ShowDialog();
		}
		
		void 查询ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(FindDocument("学籍查询")==null)
			{
				File FileDock=new File();
				FileDock.Show(this.dockPanel1);
			    
			}
		
		}
		
		void 查询ToolStripMenuItem1Click(object sender, EventArgs e)
		{
				if(FindDocument("考勤查询")==null)
			{
				Attend AttendDock=new Attend();
				AttendDock.Show(this.dockPanel1);
				
			}
			
		}
		
		void 查询ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			if(FindDocument("成绩查询")==null)
			{
				Grade GradeDock=new Grade();
				GradeDock.Show(this.dockPanel1);
				
			}
			
		}
		 private IDockContent FindDocument(string text)
　　　　　　　 {
　　　　　　　　　　　 if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
　　　　　　　　　　　 {
　　　　　　　　　　　　　　　 foreach (Form form in MdiChildren)
　　　　　　　　　　　　　　　　　　　 if (form.Text == text)
　　　　　　　　　　　　　　　　　　　　　　　 return form as IDockContent;

　　　　　　　　　　　　　　　 return null;
　　　　　　　　　　　 }
　　　　　　　　　　　 else
　　　　　　　　　　　 {
　　　　　　　　　　　　　　　 foreach (IDockContent content in dockPanel1.Documents)
　　　　　　　　　　　　　　　　　　　 if (content.DockHandler.TabText == text)
　　　　　　　　　　　　　　　　　　　　　　　 return content;

　　　　　　　　　　　　　　　 return null;
　　　　　　　　　　　 }
　　　　　　　 }
		
		void 修改密码ToolStripMenuItemClick(object sender, EventArgs e)
		{
			UserKey z= new UserKey();
            z.UserName = toolStripStatusLabel2.Text;
            z.UserPower=toolStripStatusLabel4.Text;
           	z.ShowDialog();
		}
		
		void ManagefileClick(object sender, EventArgs e)
		{
			if(FindDocument("学籍管理")==null)
			{
				FileManager z=new FileManager();
				z.Show(this.dockPanel1);
				
			}
		}
		

		
		void AddAttendClick(object sender, EventArgs e)
		{
			AddAttend AddAttendDock=new AddAttend();
			AddAttendDock.ShowDialog();
		}
		
		void ManageattendClick(object sender, EventArgs e)
		{
			if(FindDocument("考勤管理")==null)
			{
				AttendManager z=new AttendManager();
				z.Show(this.dockPanel1);
				
			}
		}
		
		void AddGradeClick(object sender, EventArgs e)
		{
			AddGrade z=new AddGrade();
			z.ShowDialog();
		}
		
		void ManagegradeClick(object sender, EventArgs e)
		{
			if(FindDocument("成绩管理")==null)
			{
				GradeManager z=new GradeManager();
				z.Show(this.dockPanel1);
				
			}
		}
		
		void 管理ToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddCourse z=new AddCourse();
			z.ShowDialog();
		}
		
		void 查询ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			Course z=new Course();
			z.Show(this.dockPanel1);
		}
		
		void ManageuserClick(object sender, EventArgs e)
		{
			
		}
		
		void 添加用户ToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddUser z=new AddUser();
			z.ShowDialog();
		}
		
		void 查询ToolStripMenuItem4Click(object sender, EventArgs e)
		{
			User z=new User();
			z.Show(this.dockPanel1);
		}
	}
}
