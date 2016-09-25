' ************************************************************
' ASP.NET Bible
' 프로젝트별로 가상디렉토리 등록한다.
'
' Copyright 2002 by Noenemy
' ************************************************************

Option Explicit
dim vPath, scriptPath, i, arrvPath, arrvName
dim vName(47,1)

vName(0,0) = "cs03"
vName(0,1) = "source\cs03"
vName(1,0) = "cs04"
vName(1,1) = "source\cs04"
vName(2,0) = "cs05"
vName(2,1) = "source\cs05"
vName(3,0) = "cs06"
vName(3,1) = "source\cs06"
vName(4,0) = "cs07"
vName(4,1) = "source\cs07"
vName(5,0) = "cs08"
vName(5,1) = "source\cs08"
vName(6,0) = "cs09"
vName(6,1) = "source\cs09"
vName(7,0) = "cs10"
vName(7,1) = "source\cs10"
vName(8,0) = "cs11"
vName(8,1) = "source\cs11"
vName(9,0) = "cs12"
vName(9,1) = "source\cs12"
vName(10,0) = "cs14"
vName(10,1) = "source\cs14"
vName(11,0) = "cs17"
vName(11,1) = "source\cs17"
vName(12,0) = "cs18"
vName(12,1) = "source\cs18"
vName(13,0) = "cs17"
vName(13,1) = "source\cs17"
vName(14,0) = "cs19"
vName(14,1) = "source\cs19"
vName(15,0) = "cs20"
vName(15,1) = "source\cs20"
vName(16,0) = "cs21"
vName(16,1) = "source\cs21"
vName(17,0) = "cs22"
vName(17,1) = "source\cs22"
vName(18,0) = "cs23"
vName(18,1) = "source\cs23"
vName(19,0) = "cs24"
vName(19,1) = "source\cs24"
vName(20,0) = "cs25"
vName(20,1) = "source\cs25"
vName(21,0) = "cs26"
vName(21,1) = "source\cs26"
vName(22,0) = "vb03"
vName(22,1) = "source\vb03"
vName(23,0) = "vb04"
vName(23,1) = "source\vb04"
vName(24,0) = "vb05"
vName(24,1) = "source\vb05"
vName(25,0) = "vb06"
vName(25,1) = "source\vb06"
vName(26,0) = "vb07"
vName(26,1) = "source\vb07"
vName(27,0) = "vb08"
vName(27,1) = "source\vb08"
vName(28,0) = "vb09"
vName(28,1) = "source\vb09"
vName(29,0) = "vb10"
vName(29,1) = "source\vb10"
vName(30,0) = "vb11"
vName(30,1) = "source\vb11"
vName(31,0) = "vb12"
vName(31,1) = "source\vb12"
vName(32,0) = "vb14"
vName(32,1) = "source\vb14"
vName(33,0) = "vb15"
vName(33,1) = "source\vb15"
vName(34,0) = "vb17"
vName(34,1) = "source\vb17"
vName(35,0) = "vb18"
vName(35,1) = "source\vb18"
vName(36,0) = "vb19"
vName(36,1) = "source\vb19"
vName(37,0) = "vb20"
vName(37,1) = "source\vb20"
vName(38,0) = "vb21"
vName(38,1) = "source\vb21"
vName(39,0) = "vb22"
vName(39,1) = "source\vb22"
vName(40,0) = "vb23"
vName(40,1) = "source\vb23"
vName(41,0) = "vb24"
vName(41,1) = "source\vb24"
vName(42,0) = "vb25"
vName(42,1) = "source\vb25"
vName(43,0) = "vb26"
vName(43,1) = "source\vb26"
vName(44,0) = "cs20_2"
vName(44,1) = "source\cs20\use_webservice_cs"
vName(45,0) = "vb20_2"
vName(45,1) = "source\vb20\use_webservice"
vName(46,0) = "cs21_2"
vName(46,1) = "source\cs21\wa_pratice_cs"
vName(47,0) = "vb21_2"
vName(47,1) = "source\vb21\wa_practice"


scriptPath = left(Wscript.ScriptFullName,len(Wscript.ScriptFullName ) -len(Wscript.ScriptName))

For i = LBound(vName,1) to UBound(vName,1)
	arrvPath = scriptPath & "source\" & vName(i,1)
	arrvName = vName(i,0)
	CreateVDir arrvPath,arrvName
Next

Sub CreateVDir(vPath,vName)

    Dim vRoot,vDir,webSite, webSite_eng, webSite_kor
    On Error Resume Next

    Set webSite_eng = findWeb("localhost", "Default Web Site")
    Set webSite_kor = findweb("localhost", "기본 웹 사이트")


    if (IsObject(webSite_eng)=False) and (IsObject(website_kor)=False) then
        ' 기본 웹 사이트를 찾을 수 없는 경우
        WScript.quit 1
    else
	if IsObject(webSite_eng) Then
		Set webSite = webSite_eng
	else
		Set webSite = webSite_kor
	End if
    end if
    Err = 0

    set vRoot = webSite.GetObject("IIsWebVirtualDir", "Root")

    If (Err <> 0) Then
	Display webSite.ADsPath & "에서 root 에 엑세스 할 수 없습니다. " 
        Exit sub
    else
        'display vRoot.name
    End IF

    vRoot.Delete "IIsWebVirtualDir",vName
    vRoot.SetInfo
    Err=0 ' reset error 

    ' create the new web
    Set vDir = vRoot.Create("IIsWebVirtualDir",vName)
    If (Err <> 0) Then
        Display vRoot.ADsPath & "/" & vName & "." &"을 생성할 수 없습니다."
        WScript.Quit 2
    else
        'display vdir.name
    end if

    ' set properties on the new web 
    vDir.AccessRead = true
    vDir.Path = vPath
    vDir.Accessflags = 529
        VDir.AppCreate False
    If (Err <> 0) Then
        Display "Unable to bind path " & vPath & " to " & vRoot.Name & "/" & vName & ". Path may be invalid."
        WScript.Quit 3
    end If

    vDir.SetInfo
    If (Err <> 0) Then
        Display  vRoot.Name & "/" & vName & "의 변경사항을 저장 할 수 없습니다 "
        WScript.Quit 4
    end if
    
    WScript.Echo Now & " " & vName & " 가상디렉토리 : " & vRoot.Name & "/" & vname & " 생성... Success!"
End Sub

Function findWeb(computer, webname)
    On Error Resume Next

    Dim websvc, site
    dim webinfo
    Dim aBinding, binding

    set websvc = GetObject("IIS://"&computer&"/W3svc")
    if (Err <> 0) then
        exit function
    end if

    set site = websvc.GetObject("IIsWebServer", webname)
    if (Err = 0) and (not isNull(site)) then
        if (site.class = "IIsWebServer") then
            set findWeb = site
            exit function
        end if
    end if
    err.clear
    for each site in websvc
        if site.class = "IIsWebServer" then
            If site.ServerComment = webname Then
                set findWeb = site
                exit function
            End If
            aBinding=site.ServerBindings
            if (IsArray(aBinding)) then
                if aBinding(0) = "" then
                    binding = Null
                else
                    binding = getBinding(aBinding(0))
                end if
            else 
                if aBinding = "" then
                    binding = Null
                else
                    binding = getBinding(aBinding)
                end if
            end if
            if IsArray(binding) then
                if (binding(2) = webname) or (binding(0) = webname) then
                    set findWeb = site
                    exit function
                End If
            end if 
        end if
    next
End Function

function getBinding(bindstr)
    Dim one, two, ia, ip, hn
    one=Instr(bindstr,":")
    two=Instr((one+1),bindstr,":")
    ia=Mid(bindstr,1,(one-1))
    ip=Mid(bindstr,(one+1),((two-one)-1))
    hn=Mid(bindstr,(two+1))
    getBinding=Array(ia,ip,hn)
end function

Sub Display(Msg)
    WScript.Echo Now & ". Error Code: " & Hex(Err) & " - " & Msg
End Sub

Sub Trace(Msg)
    WScript.Echo Now & " : " & Msg  
End Sub

Sub DeleteWeb(WebServer, WebName)
    On Error Resume Next
    Dim vDir
    display "deleting " & WebName

    WebServer.Delete "IISWebVirtualDir",WebName
    WebServer.SetInfo
    If Err=0 Then
        DISPLAY "WEB " & WebName & " 이 삭제되었습니다.."
    else
        display webname & "을 찾을 수 없습니다." 
    End If
    
End Sub