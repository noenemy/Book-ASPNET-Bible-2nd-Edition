@ECHO OFF
rem -------------------------------------
REM INSTALL ASP.NET Bible Web Sites
REM Copyright 2002 noenemy, Youngjin.com
rem -------------------------------------
REM
REM %1 = Install (current) directory

rem *** title screen
echo .
echo ==========================================
echo  ASP.NET Bible �� ����Ʈ�� ��ġ�մϴ�.
echo ==========================================
echo .

rem *** set install folder
CD /D %1

rem *** Read Only unlock. CD ��ġ��
rem ATTRIB -R *.* /S /D

rem *** run script to publish the web folder
cscript _SetupWeb.vbs

if errorlevel 2 goto othererror
if errorlevel 1 goto nodefaultwebsite

Echo �� ����Ʈ ��ġ ����.

goto exitjob

rem *** error message
:nodefaultwebsite
echo �⺻ �� ����Ʈ�� ã�� �� �����ϴ�.
echo .
echo *** ��ġ�� ���ؼ��� IIS�� '�⺻ �� ����Ʈ' 
echo *** Ȥ�� 'Default Web Site'�� �����ؾ� �մϴ�.
echo .
echo *** ABORTING WEB SITES INSTALLATION
echo .
pause
exit -1


rem *** error message
:othererror
echo ������丮�� ���� Ȥ�� �����ϴ� ���߿� ������ �߻��߽��ϴ�.
echo .
echo *** ABORTING WEB SITES INSTALLATION
echo .
pause
exit -1



rem *** error message
:frameworkpatherror
echo ������Ʈ������ .NET Framework�� ���� ������ ���� �� �������ϴ�.
echo �ʿ��� ���� - HKLM\SOFTWARE\Microsoft\.NETFramework\InstallRoot
echo             - HKLM\SOFTWARE\Microsoft\.NETFramework\Version
echo .
echo *** ABORTING SHARED COMPONENT INSTALLATION
echo .
pause
exit -1



rem *** error message
:sdkpatherror
echo ������Ʈ������ .NET Framework SDK�� ���� ������ ���� �� �������ϴ�.
echo �ʿ��� ���� - HKLM\SOFTWARE\Microsoft\.NETFramework\sdkInstallRoot
echo .
echo *** ABORTING SHARED COMPONENT INSTALLATION
echo .
pause
exit -1

rem *** error message
:basealerterror
echo BaseAlert ���񽺸� ����ϴ� ���߿� ������ �߻��߽��ϴ�.
echo .
echo *** ABORTING BASEALERT NT SERVICE INSTALLATION
echo .
pause
exit -1

rem *** exit
:exitjob
echo .
echo *** JOB COMPLETED.
