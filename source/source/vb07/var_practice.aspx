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
		// 주민등록번호 1 ~ 6 자리까지의 처리		
		// 주민등록번호에 숫자가 아닌 문자가 있을 때 처리
		for (i=0;i<J1.length;i++)				
		{						
			if (J1.charAt(i) >= 0 || J1.charAt(i) <= 9)			
			{				
				// 숫자면 값을 곱해 더한다.				
				if(i == 0)					
					SUM = (i+2) * J1.charAt(i);				
				else					
					SUM = SUM +(i+2) * J1.charAt(i);			
			}			
			else // 숫자가 아닌 문자가 있을 때의 처리	
				args.IsValid = false;		
		}		
		for (i=0;i<2;i++)				
		{						
			// 주민등록번호 7 ~ 8 자리까지의 처리	
			if (J2.charAt(i) >= 0 || J2.charAt(i) <= 9)
				SUM = SUM + (i+8) * J2.charAt(i);			
			else	// 숫자가 아닌 문자가 있을 때의 처리
				args.IsValid = false;		
		}		
		for (i=2;i<6;i++)		
		{			
			// 주민등록번호 9 ~ 12 자리까지의 처리			
			if (J2.charAt(i) >= 0 || J2.charAt(i) <= 9)				
				SUM = SUM + (i) * J2.charAt(i);			
			else // 숫자가 아닌 문자가 있을 때의 처리				
				args.IsValid = false;		
		}		
		// 나머지 구하기		
		var checkSUM = SUM % 11;		
		// 나머지가 0이면 10을 설정		
		if (checkSUM == 0)			
			var checkCODE = 10;		
		else if (checkSUM == 1)  // 나머지가 1이면 11을 설정
			var checkCODE = 11;		
		else			
			var checkCODE = checkSUM;				
		
		var check1 = 11 - checkCODE;	// 나머지를 11에서 뺀다		
		if (J2.charAt(6) >= 0 || J2.charAt(6) <= 9)	 		
			var check2 = parseInt(J2.charAt(6))	 	
		if (check1 != check2) // 주민등록번호가 틀릴 때의 처리
			args.IsValid = false;
		else // 올바른 주민등록 번호일 경우	 		
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
			<P><FONT face="굴림">회원등록</FONT></P>
			<P><FONT face="굴림">사용자ID :
					<asp:TextBox id="txtID" runat="server" Width="100px"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqID" runat="server" ErrorMessage="사용자 ID를 입력하세요." Display="Dynamic" ControlToValidate="txtID">*</asp:RequiredFieldValidator><BR>
					비밀번호 :
					<asp:TextBox id="txtPWD1" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqPWD1" runat="server" ErrorMessage="비밀번호를 입력하세요." Display="Dynamic" ControlToValidate="txtPWD1">*</asp:RequiredFieldValidator><BR>
					비밀번호 :
					<asp:TextBox id="txtPWD2" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqPWD2" runat="server" ErrorMessage="비밀번호(확인)를 입력하세요." Display="Dynamic" ControlToValidate="txtPWD2">*</asp:RequiredFieldValidator>
					<asp:CompareValidator id="ComPWD" runat="server" ErrorMessage="비밀번호가 일치하지 않습니다." Display="Dynamic" ControlToValidate="txtPWD2" ControlToCompare="txtPWD1">*</asp:CompareValidator>(확인)<BR>
					주민등록번호 :
					<asp:TextBox id="txtJumin" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator id="ReqJumin" runat="server" ErrorMessage="주민등록번호를 입력하세요." Display="Dynamic" ControlToValidate="txtJumin">*</asp:RequiredFieldValidator>
					<asp:CustomValidator id="CusJumin" runat="server" ErrorMessage="올바르지 않은 주민등록번호입니다." Display="Dynamic" ControlToValidate="txtJumin" ClientValidationFunction="JuminCheck">*</asp:CustomValidator>&nbsp;예) 
					123456-1234567<BR>
					휴대폰 :
					<asp:TextBox id="txtMobile" runat="server"></asp:TextBox>
					<asp:RegularExpressionValidator id="RegMobile" runat="server" ErrorMessage="휴대폰 번호가 올바르지 않습니다." Display="Dynamic" ControlToValidate="txtMobile" ValidationExpression="01\d{1}-\d{3,4|-\d{4}">*</asp:RegularExpressionValidator>&nbsp;예) 
					011-1234-5678</FONT></P>
			<P><FONT face="굴림">
					<asp:ValidationSummary id="Summary" runat="server"></asp:ValidationSummary></P>
			</FONT>
			<P>
				<asp:Button id="btnOK" runat="server" Text="확인"></asp:Button></P>
		</form>
	</body>
</HTML>
