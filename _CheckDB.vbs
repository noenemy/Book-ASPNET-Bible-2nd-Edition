' ************************************************************
' SQL Server나 MSDE가 설치되어 있는지를 확인한다.
' 입력받는 로그인 계정정보가 올바른지 확인한다.
'
' Copyright 2002 by noenemy
' ************************************************************

Dim objShell
Dim strDB

Set objShell = WScript.CreateObject("WScript.Shell")

' DB 로그인 계정 정보 가져오기
Set objArgs = WScript.Arguments
Dim UID  ' 계정
Dim PWD  ' 비밀번호
UID = objArgs(0)
If objArgs.Count > 1 Then ' password가 있을 경우
   PWD = objArgs(1)
Else ' blank password 일 경우
   PWD = ""
End If

On Error Resume Next
Err=0 ' reset error 

' 레지스트리 키 읽기
strDB = objShell.RegRead("HKLM\SOFTWARE\Microsoft\MSSQLServer\MSSQLServer\CurrentVersion\CurrentVersion")
If Err <> 0 Then
	WScript.Echo "SQL Server or MSDE not found." 
	Set objShell = Nothing
	WScript.Quit 1
else
	If strDB > "7" Then
		' SQL Server를 찾았으면
		Set objShell = Nothing
	
		' 로그인 정보 확인
		Err = 0
		Dim objConn, strConnection
		strConnection = "Provider=SQLOLEDB;Server=(local);UID=" & UID & ";PWD=" & PWD
		
		' ADO의 Connection 객체 생성
		Set objConn = CreateObject("ADODB.Connection")
		objConn.Open (strConnection)

		If (Err <> 0) Then 	' DB 로그인 에러
			objConn.Close
			Set objConn = Nothing
		        WScript.Quit 3
		Else
		   	objConn.Close
		   	Set objConn = Nothing
		   	WScript.Quit 0	' DB Check OK!!
		End If

	Else
		WScript.Echo "데이터 베이스 설치를 위해선 SQL Server 혹은 MSDE version 7 이상이 요구됩니다."
		Set objShell = Nothing
		WScript.Quit 2
	End If	
end if


