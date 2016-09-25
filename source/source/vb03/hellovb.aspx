<script language=VB runat=server>
Public Sub btnOK_Click(sender As Object, e As System.EventArgs)
	txtMessage.Text = "Hello, VB.NET!"
End Sub
</script>

<html>
<body>
<form method=post runat=server>
<asp:TextBox id=txtMessage runat=server></asp:TextBox>
<asp:Button id=btnOK runat=server Text="È®ÀÎ" onclick="btnOK_Click"></asp:Button>
</form>
</body>
</html>