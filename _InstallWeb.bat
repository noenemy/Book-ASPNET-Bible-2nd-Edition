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
echo  ASP.NET Bible 웹 사이트를 설치합니다.
echo ==========================================
echo .

rem *** set install folder
CD /D %1

rem *** Read Only unlock. CD 설치용
rem ATTRIB -R *.* /S /D

rem *** run script to publish the web folder
cscript _SetupWeb.vbs

if errorlevel 2 goto othererror
if errorlevel 1 goto nodefaultwebsite

Echo 웹 사이트 설치 성공.

goto exitjob

rem *** error message
:nodefaultwebsite
echo 기본 웹 사이트를 찾을 수 없습니다.
echo .
echo *** 설치를 위해서는 IIS에 '기본 웹 사이트' 
echo *** 혹은 'Default Web Site'가 존재해야 합니다.
echo .
echo *** ABORTING WEB SITES INSTALLATION
echo .
pause
exit -1


rem *** error message
:othererror
echo 가상디렉토리를 생성 혹은 변경하는 도중에 에러가 발생했습니다.
echo .
echo *** ABORTING WEB SITES INSTALLATION
echo .
pause
exit -1



rem *** error message
:frameworkpatherror
echo 레지스트리에서 .NET Framework에 대한 정보를 얻을 수 없었습니다.
echo 필요한 정보 - HKLM\SOFTWARE\Microsoft\.NETFramework\InstallRoot
echo             - HKLM\SOFTWARE\Microsoft\.NETFramework\Version
echo .
echo *** ABORTING SHARED COMPONENT INSTALLATION
echo .
pause
exit -1



rem *** error message
:sdkpatherror
echo 레지스트리에서 .NET Framework SDK에 대한 정보를 얻을 수 없었습니다.
echo 필요한 정보 - HKLM\SOFTWARE\Microsoft\.NETFramework\sdkInstallRoot
echo .
echo *** ABORTING SHARED COMPONENT INSTALLATION
echo .
pause
exit -1

rem *** error message
:basealerterror
echo BaseAlert 서비스를 등록하는 도중에 에러가 발생했습니다.
echo .
echo *** ABORTING BASEALERT NT SERVICE INSTALLATION
echo .
pause
exit -1

rem *** exit
:exitjob
echo .
echo *** JOB COMPLETED.
