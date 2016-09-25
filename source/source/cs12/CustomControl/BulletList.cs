using System;
using System.Web.UI.WebControls;

namespace CustomControl
{
	/// <summary>
	/// Summary description for BulletList.
	/// </summary>
	public class BulletList : ListControl
	{
		public BulletList()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		protected override void Render(System.Web.UI.HtmlTextWriter writer)
		{
			// 아이템 출력하기
			foreach (ListItem Item in Items)
			{
				writer.Write("<li>" + Item.Text.ToString());
			}

		}
	}
}
