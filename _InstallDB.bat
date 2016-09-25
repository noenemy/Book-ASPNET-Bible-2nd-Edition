@echo off
rem ------------------------------------
rem INSTALL ASP.NET Bible Database
rem Copyright 2001 noenemy, Youngjin.com
rem ------------------------------------
rem *** input params
rem %1 = current folder
rem %2 = sql user
rem %3 = sql password

rem *** title screen
echo .
echo ===================================
echo  ASP.NET Bible DB�� ��ġ�մϴ�.
echo ===================================
echo .

rem *** check for helpmsg
if x%1==x goto helpmsg
if x%1==x? goto helpmsg
if x%1==xhelp goto helpmsg
if x%1==xHELP goto helpmsg

rem *** SQL Server�� ��ġ�Ǿ� �ִ°�? �α��� ������ �´°�?
wscript _CheckDB.vbs %2 %3
if errorlevel 3 goto loginerror
if errorlevel 2 goto baddbversion
if errorlevel 1 goto nodatabase


rem *** ���������� ����
set DBFolder=Data

if x%2==x goto SetDefault
set sqluser=%2
set sqlpw=%3
rem goto StartJob
goto PGJob

:SetDefault
set sqluser=sa
set sqlpw=%3

:PGJob

rem *** set directory 
CD /D %1
OSQL -U%sqluser% -P%sqlpw% -Q"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Airline') DROP DATABASE [Airline]" -n
OSQL -U%sqluser% -P%sqlpw% -Q"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Bankdotnet') DROP DATABASE [Bankdotnet]" -n
OSQL -U%sqluser% -P%sqlpw% -Q"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'InsuranceDB') DROP DATABASE [InsuranceDB]" -n
OSQL -U%sqluser% -P%sqlpw% -Q"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Shopping') DROP DATABASE [Shopping]" -n

IF EXIST %CD%\source\%DBFolder%\ASPNETBible_data.MDF (DEL /Q %CD%\source\%DBFolder%\ASPNETBible_data.MDF)
IF EXIST %CD%\source\%DBFolder%\ASPNETBible_log.LDF (DEL /Q %CD%\source\%DBFolder%\ASPNETBible_log.LDF)
IF EXIST %CD%\source\%DBFolder%\pdashop_data.MDF (DEL /Q %CD%\source\%DBFolder%\pdashop_data.MDF)
IF EXIST %CD%\source\%DBFolder%\pdashop_log.LDF (DEL /Q %CD%\source\%DBFolder%\pdashop_log.LDF)


Copy %CD%\source\dbMaster\*.*  %CD%\source\%DBFolder%\
rem *** Read Only unlock. CD ��ġ��
rem ATTRIB -R *.* /S /D


OSQL -U%sqluser% -P%sqlpw% -i AttachDB.sql 
OSQL -U%sqluser% -P%sqlpw% -Q"EXEC DB_ASPNETBible_Attach N'%CD%\source\%DBFolder%'" 
OSQL -U%sqluser% -P%sqlpw% -Q"EXEC DB_pdashop_Attach N'%CD%\source\%DBFolder%'" 
Echo ����.
goto exitjob


rem *** error message
:nodatabase
echo SQL Server�� ã�� ���߽��ϴ�.
echo .
echo *** ��ġ�� ���ؼ��� of SQL Server Ȥ�� MSDE version 7 �̻��� �ʿ��մϴ�
echo *** ABORTING DATABASE INSTALLATION
echo .
pause
exit -1

rem *** error message
:baddbversion
echo Incorrect version of SQL Server found!
echo .
echo *** ��ġ�� ���ؼ��� of SQL Server Ȥ�� MSDE version 7 �̻��� �ʿ��մϴ�
echo *** ABORTING DATABASE INSTALLATION
echo .
pause
exit -1


rem *** error message
:loginerror
echo SQL Server�� �α��� �ϴµ� �����߽��ϴ�.
echo .
echo *** SQL Server�� �����ϱ����� ������ ��й�ȣ�� �ùٸ��� Ȯ���ϼ���.
echo *** ABORTING DATABASE INSTALLATION
echo .
pause
exit -1

rem *** help message
:helpmsg
echo Missing parameters
echo .
echo INSTALLDB [sqluser] [sqlpassword]
echo .
echo sqluser = �ش� ����� ������ �����ͺ��̽��� ������ų �� �־�� �մϴ�. (default=sa)
echo sqlpassword = �ش� ������� �н����� (default={blank})
pause 



rem *** exit
:exitjob

echo .
echo *** JOB COMPLETED.

rem *** clear settings
set sqluser=
set sqlpw=

rem *** eof
:eof
