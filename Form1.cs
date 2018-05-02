using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace SelectRun
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;

		private System.Windows.Forms.Label label1;

		string name1url;
		string name2url;
		string name3url;
		string name4url;
		string name5url;
		string name6url;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Button button7;


		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(184, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(328, 48);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 40);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(40, 112);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(104, 40);
			this.button4.TabIndex = 4;
			this.button4.Text = "button4";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(184, 112);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(104, 40);
			this.button5.TabIndex = 5;
			this.button5.Text = "button5";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(328, 112);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(104, 40);
			this.button6.TabIndex = 6;
			this.button6.Text = "button6";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(160, 168);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(152, 48);
			this.button7.TabIndex = 7;
			this.button7.Text = "退出";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(464, 273);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "直接点击对应的按钮运行相关的程序";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}



		private void Form1_Load(object sender, System.EventArgs e)
		{a:
			try
			{
				string check;
				FileStream input=new FileStream(Directory.GetCurrentDirectory()+"\\"+"cfg.ini",FileMode.Open,FileAccess.Read);
				System.Text.Encoding en=System.Text.Encoding.Default;
//				System.Text.Encoding en=System.Text.Encoding.GetEncoding("gb2312");
				StreamReader sr=new StreamReader(input,en);
				check=sr.ReadToEnd();
				int count=check.IndexOf ("count=",0);
				int name1=check.IndexOf ("name1=",0);
				int name2=check.IndexOf ("name2=",0);
				int name3=check.IndexOf ("name3=",0);
				int name4=check.IndexOf ("name4=",0);
				int name5=check.IndexOf ("name5=",0);
				int name6=check.IndexOf ("name6=",0);
				int path1=check.IndexOf ("path1=",0);
				int path2=check.IndexOf ("path2=",0);
				int path3=check.IndexOf ("path3=",0);
				int path4=check.IndexOf ("path4=",0);
				int path5=check.IndexOf ("path5=",0);
				int path6=check.IndexOf ("path6=",0);
                
				try
				{
					if(check.Substring(name1+6,check.IndexOf(";",name1)-(name1+6)).Length<1){this.button1.Text="无目标程序";this.button1.Enabled=false;}
					else{this.button1.Text=check.Substring(name1+6,check.IndexOf(";",name1)-(name1+6));name1url=check.Substring(path1+6,check.IndexOf(";",path1)-(path1+6));}
				}
				catch{this.button1.Text="无目标程序";this.button1.Enabled=false;}//無目標程式
				try
				{
					if(check.Substring(name2+6,check.IndexOf(";",name2)-(name2+6)).Length<1){this.button2.Text="无目标程序";this.button2.Enabled=false;}
					else{this.button2.Text=check.Substring(name2+6,check.IndexOf(";",name2)-(name2+6));name2url=check.Substring(path2+6,check.IndexOf(";",path2)-(path2+6));}
				}
				catch{this.button2.Text="无目标程序";this.button2.Enabled=false;}
				try
				{
					if(check.Substring(name3+6,check.IndexOf(";",name3)-(name3+6)).Length<1){this.button3.Text="无目标程序";this.button3.Enabled=false;}
					else{this.button3.Text=check.Substring(name3+6,check.IndexOf(";",name3)-(name3+6));name3url=check.Substring(path3+6,check.IndexOf(";",path3)-(path3+6));}
				}
				catch{this.button3.Text="无目标程序";this.button3.Enabled=false;}
				try
				{
					if(check.Substring(name4+6,check.IndexOf(";",name4)-(name4+6)).Length<1){this.button4.Text="无目标程序";this.button4.Enabled=false;}
					else{this.button4.Text=check.Substring(name4+6,check.IndexOf(";",name4)-(name4+6));name4url=check.Substring(path4+6,check.IndexOf(";",path4)-(path4+6));}
				}
				catch{this.button4.Text="无目标程序";this.button4.Enabled=false;}
				try
				{
					if(check.Substring(name5+6,check.IndexOf(";",name5)-(name5+6)).Length<1){this.button5.Text="无目标程序";this.button5.Enabled=false;}
					else{this.button5.Text=check.Substring(name5+6,check.IndexOf(";",name5)-(name5+6));name5url=check.Substring(path5+6,check.IndexOf(";",path5)-(path5+6));}
				}
				catch{this.button5.Text="无目标程序";this.button5.Enabled=false;}
				try
				{
					if(check.Substring(name6+6,check.IndexOf(";",name6)-(name6+6)).Length<1){this.button6.Text="无目标程序";this.button6.Enabled=false;}
					else{this.button6.Text=check.Substring(name6+6,check.IndexOf(";",name6)-(name6+6));name6url=check.Substring(path6+6,check.IndexOf(";",path6)-(path6+6));}
				}
				catch{this.button6.Text="无目标程序";this.button6.Enabled=false;}


				//				int uric=check.IndexOf("uri=",0);
				//				int userc=check.IndexOf("user=",0);
				//				int passc=check.IndexOf("pass=",0);
				//				uri =new Uri(check.Substring(uric+4,check.IndexOf(";",uric)-(uric+4)));
				//				if(check.Substring(userc+5,check.IndexOf(";",userc)-(userc+5))=="[null]")user="";
				//				else{user=check.Substring(userc+5,check.IndexOf(";",userc)-(userc+5));}
				//				if(check.Substring(passc+5,check.IndexOf(";",passc)-(passc+5))=="[null]")pass="";
				//				else{pass=check.Substring(passc+5,check.IndexOf(";",passc)-(passc+5));}
//								sr.Close();
				sr.Close();
			}
			catch
			{
				MessageBox.Show("无法打开连接，确认是否执行文件目录中含有cfg.ini；确认是否该连接有效（打开cfg.ini查看是否有效）","无效操作");//MessageBox.Show("無法打開連接，確認是否執行檔目錄中含有cfg.ini；確認是否該連接有效（打開cfg.ini查看是否有效）","無效操作");

//				MessageBox.Show("无法打开连接，确认是否执行文件目录中含有cfg.ini；确认是否该连接有效（打开cfg.ini查看是否有效）","无效操作");
//				try
//				{
//					string message = "是否需要重新生成cfg.ini檔，並恢復預設值？";
//					string caption = "恢復確認";
				    string message = "是否需要重新生成cfg.ini文件，并恢复默认值？";
				    string caption = "恢复确认";

					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result;			
					result = MessageBox.Show(this, message, caption, buttons,
						MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 
						);

					if(result == DialogResult.Yes)
					{
						FileStream input1=new FileStream(Directory.GetCurrentDirectory()+"\\"+"cfg.ini",FileMode.OpenOrCreate,FileAccess.Write);
					

						System.Text.Encoding en1=System.Text.Encoding.Default;

						StreamWriter sw=new StreamWriter(input1,en1);
			
						sw.Write("name1=OUT LOOK;\r\npath1=C:\\Program Files\\Outlook Express\\MSIMN.EXE;\r\nname2=IE浏览器;\r\npath2=C:\\Program Files\\Internet Explorer\\IEXPLORE.EXE;\r\nname3=;\r\npath3=;\r\nname4=;\r\npath4=;\r\nname5=;\r\npath5=;\r\nname6=;\r\npath6=;\r\n");
						sw.Close();
						goto a;
					}
//				}
//				catch
//				{}
			}
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{			
			Process ps=new Process();
				ps.StartInfo.FileName=this.name1url;
				this.label1.Text =this.name1url;
				
				ps.Start();

				//ps.StartInfo.UseShellExecute=true;
				
			}
			catch
			{
				this.label1.Text =this.name1url;
			}

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{			
				Process ps=new Process();
				ps.StartInfo.FileName=this.name2url;
				this.label1.Text =this.name2url;
				ps.Start();
			}
			catch
			{
				this.label1.Text =this.name1url;
			}		
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{			
				Process ps=new Process();
				ps.StartInfo.FileName=this.name3url;
				this.label1.Text =this.name3url;
				ps.Start();
			}
			catch
			{
				this.label1.Text =this.name1url;
			}	
		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			try
			{			
				Process ps=new Process();
				ps.StartInfo.FileName=this.name4url;
				this.label1.Text =this.name4url;
				ps.Start();
			}
			catch
			{
				this.label1.Text =this.name1url;
			}	
		
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			try
			{			
				Process ps=new Process();
				ps.StartInfo.FileName=this.name5url;
				this.label1.Text =this.name5url;
				ps.Start();
			}
			catch
			{
				this.label1.Text =this.name1url;
			}	
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			try
			{			
				Process ps=new Process();
				ps.StartInfo.FileName=this.name6url;
				this.label1.Text =this.name6url;
				ps.Start();
			}
			catch
			{
				this.label1.Text =this.name1url;
			}	
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
