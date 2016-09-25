using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace win_use_webservice_cs
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnInvoke;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnInvoke = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "textBox1";
			// 
			// btnInvoke
			// 
			this.btnInvoke.Location = new System.Drawing.Point(24, 56);
			this.btnInvoke.Name = "btnInvoke";
			this.btnInvoke.Size = new System.Drawing.Size(104, 23);
			this.btnInvoke.TabIndex = 1;
			this.btnInvoke.Text = "웹 서비스 호출";
			this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnInvoke,
																		  this.textBox1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnInvoke_Click(object sender, System.EventArgs e)
		{
			// 웹 서비스 호출하기
			localhost.hello ws = new localhost.hello();
			textBox1.Text = ws.HelloWorld();
		}
	}
}
