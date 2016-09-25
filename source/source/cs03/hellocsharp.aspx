<script language=c# runat=server>
public void btnOK_Click(object sender, System.EventArgs e)
{
	txtMessage.Text = "Hello, C#!";
}
</script>

<html>
<body>
<form method=post runat=server>
<asp:TextBox id=txtMessage runat=server></asp:TextBox>
<asp:Button id=btnOK runat=server Text="È®ÀÎ" onclick="btnOK_Click"></asp:Button>
</form>
</body>
</html>