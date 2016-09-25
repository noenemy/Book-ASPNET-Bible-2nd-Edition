<%@ Control Language="vb" AutoEventWireup="false" Codebehind="menu.ascx.vb" Inherits="control.menu" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<FONT face="굴림">지역선택<BR>
	<asp:datalist id="DataList1" runat="server">
		<ItemTemplate>
			<asp:LinkButton id=LinkButton1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.region") %>' CommandName="select">
			</asp:LinkButton>
		</ItemTemplate>
	</asp:datalist></FONT>
