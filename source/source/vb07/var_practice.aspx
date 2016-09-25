<%@ Page Language="vb" AutoEventWireup="false" Codebehind="var_practice.aspx.vb" Inherits="validation_control.var_practice"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>

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
	
		<title>var_practice</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P><FONT face="����">ȸ�����</FONT></P>
			<P><FONT face="����">�����ID :
					<asp:TextBox id="txtID" runat="server" Width="100px"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqID" runat="server" ErrorMessage="����� ID�� �Է��ϼ���." Display="Dynamic" ControlToValidate="txtID">*</asp:RequiredFieldValidator><BR>
					��й�ȣ :
					<asp:TextBox id="txtPWD1" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqPWD1" runat="server" ErrorMessage="��й�ȣ�� �Է��ϼ���." Display="Dynamic" ControlToValidate="txtPWD1">*</asp:RequiredFieldValidator><BR>
					��й�ȣ :
					<asp:TextBox id="txtPWD2" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqPWD2" runat="server" ErrorMessage="��й�ȣ(Ȯ��)�� �Է��ϼ���." Display="Dynamic" ControlToValidate="txtPWD2">*</asp:RequiredFieldValidator>
					<asp:CompareValidator id="ComPWD" runat="server" ErrorMessage="��й�ȣ�� ��ġ���� �ʽ��ϴ�." Display="Dynamic" ControlToValidate="txtPWD2" ControlToCompare="txtPWD1">*</asp:CompareValidator>(Ȯ��)<BR>
					�ֹε�Ϲ�ȣ :
					<asp:TextBox id="txtJumin" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqJumin" runat="server" ErrorMessage="�ֹε�Ϲ�ȣ�� �Է��ϼ���." Display="Dynamic" ControlToValidate="txtJumin">*</asp:RequiredFieldValidator>
					<asp:CustomValidator id="CusJumin" runat="server" ErrorMessage="�ùٸ��� ���� �ֹε�Ϲ�ȣ�Դϴ�." Display="Dynamic" ControlToValidate="txtJumin" ClientValidationFunction="JuminCheck">*</asp:CustomValidator>&nbsp;��) 
					123456-1234567<BR>
					�޴��� :
					<asp:TextBox id="txtMobile" runat="server"></asp:TextBox>
					<asp:RegularExpressionValidator id="RegMobile" runat="server" ErrorMessage="�޴��� ��ȣ�� �ùٸ��� �ʽ��ϴ�." Display="Dynamic" ControlToValidate="txtMobile" ValidationExpression="01\d{1}-\d{3,4|-\d{4}">*</asp:RegularExpressionValidator>&nbsp;��) 
					011-1234-5678</FONT></P>
			<P><FONT face="����">
					<asp:ValidationSummary id="Summary" runat="server"></asp:ValidationSummary></P>
			</FONT>
			<P>
				<asp:Button id="btnOK" runat="server" Text="Ȯ��"></asp:Button></P>
		</form>
	</body>
</HTML>
