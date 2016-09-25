using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace list1_cs
{
	/// <summary>
	/// Summary description for listbox.
	/// </summary>
	public class listbox : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtItem;
		protected System.Web.UI.WebControls.Button btnAdd;
		protected System.Web.UI.WebControls.ListBox lstSong;
		protected System.Web.UI.WebControls.Button btnOK;
		protected System.Web.UI.WebControls.Label lblSelection;
	
		public listbox()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Page_Init(object sender, EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			// ListItem 객체 생성
			ListItem Item = new ListItem();
			Item.Value = txtItem.Text;
			Item.Text = txtItem.Text;
			// 아이템 컬렉션에 추가
			lstSong.Items.Add(Item);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (lstSong.SelectedIndex > -1) // 선택한 값이 있으면(다중선택)
			{
				lblSelection.Text = "선택한 곡 : ";

				foreach (ListItem Item in lstSong.Items) // 아이템 수만큼 반복
				{
					if (Item.Selected == true)
						lblSelection.Text += Item.Text + ",";
				}																	}
			}
		}
	}

