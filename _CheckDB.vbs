' ************************************************************
' SQL Server�� MSDE�� ��ġ�Ǿ� �ִ����� Ȯ���Ѵ�.
' �Է¹޴� �α��� ���������� �ùٸ��� Ȯ���Ѵ�.
'
' Copyright 2002 by noenemy
' ************************************************************

Dim objShell
Dim strDB

Set objShell = WScript.CreateObject("WScript.Shell")

' DB �α��� ���� ���� ��������
Set objArgs = WScript.Arguments
Dim UID  ' ����
Dim PWD  ' ��й�ȣ
UID = objArgs(0)
If objArgs.Count > 1 Then ' password�� ���� ���
   PWD = objArgs(1)
Else ' blank password �� ���
   PWD = ""
End If

On Error Resume Next
Err=0 ' reset error 

' ������Ʈ�� Ű �б�
strDB = objShell.RegRead("HKLM\SOFTWARE\Microsoft\MSSQLServer\MSSQLServer\CurrentVersion\CurrentVersion")
If Err <> 0 Then
	WScript.Echo "SQL Server or MSDE not found." 
	Set objShell = Nothing
	WScript.Quit 1
else
	If strDB > "7" Then
		' SQL Server�� ã������
		Set objShell = Nothing
	
		' �α��� ���� Ȯ��
		Err = 0
		Dim objConn, strConnection
		strConnection = "Provider=SQLOLEDB;Server=(local);UID=" & UID & ";PWD=" & PWD
		
		' ADO�� Connection ��ü ����
		Set objConn = CreateObject("ADODB.Connection")
		objConn.Open (strConnection)

		If (Err <> 0) Then 	' DB �α��� ����
			objConn.Close
			Set objConn = Nothing
		        WScript.Quit 3
		Else
		   	objConn.Close
		   	Set objConn = Nothing
		   	WScript.Quit 0	' DB Check OK!!
		End If

	Else
		WScript.Echo "������ ���̽� ��ġ�� ���ؼ� SQL Server Ȥ�� MSDE version 7 �̻��� �䱸�˴ϴ�."
		Set objShell = Nothing
		WScript.Quit 2
	End If	
end if


