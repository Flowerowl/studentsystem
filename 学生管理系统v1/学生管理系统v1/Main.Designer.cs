/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/12/21
 * 时间: 8:45
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 学生管理系统v1
{
	partial class Main
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.打开全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关闭全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关闭此项以外ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageuser = new System.Windows.Forms.ToolStripMenuItem();
			this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
			this.FindUser = new System.Windows.Forms.ToolStripMenuItem();
			this.学籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.managefile = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFile = new System.Windows.Forms.ToolStripMenuItem();
			this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.manageattend = new System.Windows.Forms.ToolStripMenuItem();
			this.AddAttend = new System.Windows.Forms.ToolStripMenuItem();
			this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查询ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.managegrade = new System.Windows.Forms.ToolStripMenuItem();
			this.AddGrade = new System.Windows.Forms.ToolStripMenuItem();
			this.课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddCourse = new System.Windows.Forms.ToolStripMenuItem();
			this.查询ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.控制ToolStripMenuItem,
									this.系统管理ToolStripMenuItem,
									this.学籍管理ToolStripMenuItem,
									this.考勤管理ToolStripMenuItem,
									this.成绩管理ToolStripMenuItem,
									this.课程ToolStripMenuItem,
									this.关于ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(604, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 控制ToolStripMenuItem
			// 
			this.控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.打开全部ToolStripMenuItem,
									this.关闭全部ToolStripMenuItem,
									this.关闭此项以外ToolStripMenuItem,
									this.退出ToolStripMenuItem});
			this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
			this.控制ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.控制ToolStripMenuItem.Text = "控制";
			// 
			// 打开全部ToolStripMenuItem
			// 
			this.打开全部ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开全部ToolStripMenuItem.Image")));
			this.打开全部ToolStripMenuItem.Name = "打开全部ToolStripMenuItem";
			this.打开全部ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.打开全部ToolStripMenuItem.Text = "打开全部";
			this.打开全部ToolStripMenuItem.Click += new System.EventHandler(this.打开全部ToolStripMenuItemClick);
			// 
			// 关闭全部ToolStripMenuItem
			// 
			this.关闭全部ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关闭全部ToolStripMenuItem.Image")));
			this.关闭全部ToolStripMenuItem.Name = "关闭全部ToolStripMenuItem";
			this.关闭全部ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.关闭全部ToolStripMenuItem.Text = "关闭全部";
			this.关闭全部ToolStripMenuItem.Click += new System.EventHandler(this.关闭全部ToolStripMenuItemClick);
			// 
			// 关闭此项以外ToolStripMenuItem
			// 
			this.关闭此项以外ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关闭此项以外ToolStripMenuItem.Image")));
			this.关闭此项以外ToolStripMenuItem.Name = "关闭此项以外ToolStripMenuItem";
			this.关闭此项以外ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.关闭此项以外ToolStripMenuItem.Text = "关闭此项以外";
			this.关闭此项以外ToolStripMenuItem.Click += new System.EventHandler(this.关闭此项以外ToolStripMenuItemClick);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItemClick);
			// 
			// 系统管理ToolStripMenuItem
			// 
			this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.manageuser,
									this.修改密码ToolStripMenuItem,
									this.AddUser,
									this.FindUser});
			this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
			this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.系统管理ToolStripMenuItem.Text = "系统";
			// 
			// manageuser
			// 
			this.manageuser.Image = ((System.Drawing.Image)(resources.GetObject("manageuser.Image")));
			this.manageuser.Name = "manageuser";
			this.manageuser.Size = new System.Drawing.Size(152, 22);
			this.manageuser.Text = "管理用户";
			this.manageuser.Click += new System.EventHandler(this.ManageuserClick);
			// 
			// 修改密码ToolStripMenuItem
			// 
			this.修改密码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改密码ToolStripMenuItem.Image")));
			this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
			this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.修改密码ToolStripMenuItem.Text = "修改密码";
			this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItemClick);
			// 
			// AddUser
			// 
			this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
			this.AddUser.Name = "AddUser";
			this.AddUser.Size = new System.Drawing.Size(152, 22);
			this.AddUser.Text = "添加用户";
			this.AddUser.Click += new System.EventHandler(this.添加用户ToolStripMenuItemClick);
			// 
			// FindUser
			// 
			this.FindUser.Image = ((System.Drawing.Image)(resources.GetObject("FindUser.Image")));
			this.FindUser.Name = "FindUser";
			this.FindUser.Size = new System.Drawing.Size(152, 22);
			this.FindUser.Text = "查询";
			this.FindUser.Click += new System.EventHandler(this.查询ToolStripMenuItem4Click);
			// 
			// 学籍管理ToolStripMenuItem
			// 
			this.学籍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.查询ToolStripMenuItem,
									this.managefile,
									this.AddFile});
			this.学籍管理ToolStripMenuItem.Name = "学籍管理ToolStripMenuItem";
			this.学籍管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.学籍管理ToolStripMenuItem.Text = "学籍";
			// 
			// 查询ToolStripMenuItem
			// 
			this.查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripMenuItem.Image")));
			this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
			this.查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.查询ToolStripMenuItem.Text = "查询";
			this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItemClick);
			// 
			// managefile
			// 
			this.managefile.Image = ((System.Drawing.Image)(resources.GetObject("managefile.Image")));
			this.managefile.Name = "managefile";
			this.managefile.Size = new System.Drawing.Size(152, 22);
			this.managefile.Text = "管理";
			this.managefile.Click += new System.EventHandler(this.ManagefileClick);
			// 
			// AddFile
			// 
			this.AddFile.Image = ((System.Drawing.Image)(resources.GetObject("AddFile.Image")));
			this.AddFile.Name = "AddFile";
			this.AddFile.Size = new System.Drawing.Size(152, 22);
			this.AddFile.Text = "添加";
			this.AddFile.Click += new System.EventHandler(this.添加ToolStripMenuItemClick);
			// 
			// 考勤管理ToolStripMenuItem
			// 
			this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.查询ToolStripMenuItem1,
									this.manageattend,
									this.AddAttend});
			this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
			this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.考勤管理ToolStripMenuItem.Text = "考勤";
			// 
			// 查询ToolStripMenuItem1
			// 
			this.查询ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripMenuItem1.Image")));
			this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
			this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.查询ToolStripMenuItem1.Text = "查询";
			this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1Click);
			// 
			// manageattend
			// 
			this.manageattend.Image = ((System.Drawing.Image)(resources.GetObject("manageattend.Image")));
			this.manageattend.Name = "manageattend";
			this.manageattend.Size = new System.Drawing.Size(152, 22);
			this.manageattend.Text = "管理";
			this.manageattend.Click += new System.EventHandler(this.ManageattendClick);
			// 
			// AddAttend
			// 
			this.AddAttend.Image = ((System.Drawing.Image)(resources.GetObject("AddAttend.Image")));
			this.AddAttend.Name = "AddAttend";
			this.AddAttend.Size = new System.Drawing.Size(152, 22);
			this.AddAttend.Text = "添加";
			this.AddAttend.Click += new System.EventHandler(this.AddAttendClick);
			// 
			// 成绩管理ToolStripMenuItem
			// 
			this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.查询ToolStripMenuItem2,
									this.managegrade,
									this.AddGrade});
			this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
			this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.成绩管理ToolStripMenuItem.Text = "成绩";
			// 
			// 查询ToolStripMenuItem2
			// 
			this.查询ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripMenuItem2.Image")));
			this.查询ToolStripMenuItem2.Name = "查询ToolStripMenuItem2";
			this.查询ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.查询ToolStripMenuItem2.Text = "查询";
			this.查询ToolStripMenuItem2.Click += new System.EventHandler(this.查询ToolStripMenuItem2Click);
			// 
			// managegrade
			// 
			this.managegrade.Image = ((System.Drawing.Image)(resources.GetObject("managegrade.Image")));
			this.managegrade.Name = "managegrade";
			this.managegrade.Size = new System.Drawing.Size(152, 22);
			this.managegrade.Text = "管理";
			this.managegrade.Click += new System.EventHandler(this.ManagegradeClick);
			// 
			// AddGrade
			// 
			this.AddGrade.Image = ((System.Drawing.Image)(resources.GetObject("AddGrade.Image")));
			this.AddGrade.Name = "AddGrade";
			this.AddGrade.Size = new System.Drawing.Size(152, 22);
			this.AddGrade.Text = "添加";
			this.AddGrade.Click += new System.EventHandler(this.AddGradeClick);
			// 
			// 课程ToolStripMenuItem
			// 
			this.课程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.查询ToolStripMenuItem3,
									this.AddCourse});
			this.课程ToolStripMenuItem.Name = "课程ToolStripMenuItem";
			this.课程ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.课程ToolStripMenuItem.Text = "课程";
			// 
			// AddCourse
			// 
			this.AddCourse.Image = ((System.Drawing.Image)(resources.GetObject("AddCourse.Image")));
			this.AddCourse.Name = "AddCourse";
			this.AddCourse.Size = new System.Drawing.Size(152, 22);
			this.AddCourse.Text = "添加";
			this.AddCourse.Click += new System.EventHandler(this.管理ToolStripMenuItemClick);
			// 
			// 查询ToolStripMenuItem3
			// 
			this.查询ToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripMenuItem3.Image")));
			this.查询ToolStripMenuItem3.Name = "查询ToolStripMenuItem3";
			this.查询ToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.查询ToolStripMenuItem3.Text = "查询";
			this.查询ToolStripMenuItem3.Click += new System.EventHandler(this.查询ToolStripMenuItem3Click);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.关于ToolStripMenuItem.Text = "关于";
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripStatusLabel2,
									this.toolStripStatusLabel3,
									this.toolStripStatusLabel4,
									this.toolStripStatusLabel6});
			this.statusStrip1.Location = new System.Drawing.Point(0, 281);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(604, 26);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 21);
			this.toolStripStatusLabel1.Text = "当前用户：";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(36, 21);
			this.toolStripStatusLabel2.Text = "默认";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(48, 21);
			this.toolStripStatusLabel3.Text = "权限：";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.Red;
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(36, 21);
			this.toolStripStatusLabel4.Text = "默认";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.Blue;
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(397, 21);
			this.toolStripStatusLabel6.Spring = true;
			this.toolStripStatusLabel6.Text = "默认";
			// 
			// dockPanel1
			// 
			this.dockPanel1.ActiveAutoHideContent = null;
			this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dockPanel1.Location = new System.Drawing.Point(0, 25);
			this.dockPanel1.Name = "dockPanel1";
			this.dockPanel1.Size = new System.Drawing.Size(604, 256);
			this.dockPanel1.TabIndex = 4;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 307);
			this.Controls.Add(this.dockPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "学生管理系统";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
	}
		private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 打开全部ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关闭全部ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关闭此项以外ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 学籍管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripMenuItem manageuser;
		private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem managefile;
		private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem manageattend;
		private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem managegrade;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		private System.Windows.Forms.ToolStripMenuItem AddFile;
		private System.Windows.Forms.ToolStripMenuItem AddAttend;
		private System.Windows.Forms.ToolStripMenuItem AddGrade;
		private System.Windows.Forms.ToolStripMenuItem 课程ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddCourse;
		private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem AddUser;
		private System.Windows.Forms.ToolStripMenuItem FindUser;
}
}
