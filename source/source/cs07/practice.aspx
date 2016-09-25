<%@ Page language="c#" Codebehind="practice.aspx.cs" AutoEventWireup="false" Inherits="validation_cs.practice" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<script language="javascript">
function JuminCheck(source,args)
{
	var value = args.Value;
	var Jumin = value.split("-");
	var J1 = Jumin[0];	
	var J2 = Jumin[1];	
	
	if (J1 =="111111" || J2 =="1111118")
		return false;	
	else	
	{
		// �ֹε�Ϲ�ȣ 1 ~ 6 �ڸ������� ó��
		// �ֹε�Ϲ�ȣ�� ���ڰ� �ƴ� ���ڰ� ���� �� ó��		
		for (i=0;i<J1.length;i++)		
		{			
			if (J1.charAt(i) >= 0 || J1.charAt(i) <= 9)
			{
				// ���ڸ� ���� ���� ���Ѵ�.
				if(i == 0)
					SUM = (i+2) * J1.charAt(i);
				else
					SUM = SUM +(i+2) * J1.charAt(i);
			}
			else // ���ڰ� �ƴ� ���ڰ� ���� ���� ó��
				args.IsValid = false;
		}
		for (i=0;i<2;i++)		
		{			
			// �ֹε�Ϲ�ȣ 7 ~ 8 �ڸ������� ó��			
			if (J2.charAt(i) >= 0 || J2.charAt(i) <= 9) 
				SUM = SUM + (i+8) * J2.charAt(i);
			else	// ���ڰ� �ƴ� ���ڰ� ���� ���� ó��
				args.IsValid = false;
		}
		for (i=2;i<6;i++)
		{
			// �ֹε�Ϲ�ȣ 9 ~ 12 �ڸ������� ó��
			if (J2.charAt(i) >= 0 || J2.charAt(i) <= 9)
				SUM = SUM + (i) * J2.charAt(i);
			else // ���ڰ� �ƴ� ���ڰ� ���� ���� ó��
				args.IsValid = false;
		}
		// ������ ���ϱ�
		var checkSUM = SUM % 11;
		// �������� 0�̸� 10�� ����
		if (checkSUM == 0)
			var checkCODE = 10;
		else if (checkSUM == 1)  // �������� 1�̸� 11�� ����
			var checkCODE = 11;
		else
			var checkCODE = checkSUM;
		
		var check1 = 11 - checkCODE;	// �������� 11���� ����
		if (J2.charAt(6) >= 0 || J2.charAt(6) <= 9)
	 		var check2 = parseInt(J2.charAt(6))
	 	if (check1 != check2) // �ֹε�Ϲ�ȣ�� Ʋ�� ���� ó��	
	 		args.IsValid = false;		
	 	else // �ùٸ� �ֹε�� ��ȣ�� ���
	 		args.IsValid = true;
	}
}
		</script>
<HTML>
	<HEAD>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript (ECMAScript)">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="practice" method="post" runat="server">
			<P>
				<FONT face="����">ȸ������������</FONT>
			</P>
			<P>
				<FONT face="����">�����ID :
					<asp:TextBox id="txtID" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqID" runat="server" ErrorMessage="�����ID�� �Է��ϼ���." Display="Dynamic" ControlToValidate="txtID">*</asp:RequiredFieldValidator>
					<BR>
					��й�ȣ :
					<asp:TextBox id="txtPWD1" runat="server" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqPWD1" runat="server" ErrorMessage="��й�ȣ�� �Է��ϼ���." ControlToValidate="txtPWD1">*</asp:RequiredFieldValidator>
					<asp:CompareValidator id="ComPWD" runat="server" ErrorMessage="��й�ȣ�� ��ġ���� �ʽ��ϴ�." ControlToCompare="txtPWD1" ControlToValidate="txtPWD2">*</asp:CompareValidator>
					<BR>
					��й�ȣ :&nbsp;
					<asp:TextBox id="txtPWD2" runat="server" TextMode="Password"></asp:TextBox>
					&nbsp;
					<asp:RequiredFieldValidator id="ReqPWD2" runat="server" ErrorMessage="��й�ȣ(Ȯ��)�� �Է��ϼ���." Display="Dynamic" ControlToValidate="txtPWD2">*</asp:RequiredFieldValidator>
					(Ȯ��)
					<BR>
					�ֹε�Ϲ�ȣ :
					<asp:TextBox id="txtJumin" runat="server"></asp:TextBox>
					&nbsp;
					<asp:RequiredFieldValidator id="ReqJumin" runat="server" ErrorMessage="�ֹε�Ϲ�ȣ�� �Է��ϼ���." ControlToValidate="txtJumin" Width="8px" Height="16px">*</asp:RequiredFieldValidator>
					<asp:CustomValidator id="CusJumin" runat="server" ErrorMessage="�ֹε�Ϲ�ȣ�� �ùٸ��� �ʽ��ϴ�." Display="Dynamic" ControlToValidate="txtJumin" ClientValidationFunction="JuminCheck">*</asp:CustomValidator>
					��) 123456-1234567
					<BR>
					�޴��� :
					<asp:TextBox id="txtMobile" runat="server"></asp:TextBox>
					&nbsp;
					<asp:RegularExpressionValidator id="RegMobile" runat="server" ErrorMessage="�޴��� ��ȣ�� �ùٸ��� �ʽ��ϴ�." Display="Dynamic" ValidationExpression="01\d{1}-\d{3,4}-\d{4}" ControlToValidate="txtMobile">*</asp:RegularExpressionValidator>
					��) 011-1234-5678
					<BR>
					<BR>
					<asp:ValidationSummary id="Summary" runat="server"></asp:ValidationSummary>
				</FONT>
			</P>
			<P>
				<FONT face="����">
					<asp:Button id="btnOK" runat="server" Text="Button"></asp:Button>
			</P>
			</FONT>
		</form>
	</body>
</HTML>
