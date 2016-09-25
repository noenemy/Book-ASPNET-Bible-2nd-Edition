<%@ Control Language="c#" AutoEventWireup="false" Codebehind="menu.ascx.cs" Inherits="control_cs.menu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<FONT face="굴림">지역선택<BR>
	<asp:DataList id="DataList1" runat="server">
		<ItemTemplate>
			<asp:LinkButton id=LinkButton1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.region") %>' CommandName="select">
			</asp:LinkButton>
		</ItemTemplate>
	</asp:DataList></FONT>
