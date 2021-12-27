# Microsoft Developer Studio Project File - Name="VDrawRes" - Package Owner=<4>
# Microsoft Developer Studio Generated Build File, Format Version 6.00
# ** DO NOT EDIT **

# TARGTYPE "Win32 (x86) Dynamic-Link Library" 0x0102

CFG=VDrawRes - Win32 Debug
!MESSAGE This is not a valid makefile. To build this project using NMAKE,
!MESSAGE use the Export Makefile command and run
!MESSAGE 
!MESSAGE NMAKE /f "VDrawRes.mak".
!MESSAGE 
!MESSAGE You can specify a configuration when running NMAKE
!MESSAGE by defining the macro CFG on the command line. For example:
!MESSAGE 
!MESSAGE NMAKE /f "VDrawRes.mak" CFG="VDrawRes - Win32 Debug"
!MESSAGE 
!MESSAGE Possible choices for configuration are:
!MESSAGE 
!MESSAGE "VDrawRes - Win32 Release" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "VDrawRes - Win32 Debug" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE 

# Begin Project
# PROP AllowPerConfigDependencies 0
# PROP Scc_ProjName ""
# PROP Scc_LocalPath ""
CPP=cl.exe
MTL=midl.exe
RSC=rc.exe

!IF  "$(CFG)" == "VDrawRes - Win32 Release"

# PROP BASE Use_MFC 6
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "Release"
# PROP BASE Intermediate_Dir "Release"
# PROP BASE Target_Dir ""
# PROP Use_MFC 6
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "Release"
# PROP Intermediate_Dir "Release"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /Yu"stdafx.h" /FD /c
# ADD CPP /nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Yu"stdafx.h" /FD /c
# ADD BASE MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x408 /d "NDEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /machine:I386
# ADD LINK32 /nologo /subsystem:windows /dll /machine:I386

!ELSEIF  "$(CFG)" == "VDrawRes - Win32 Debug"

# PROP BASE Use_MFC 6
# PROP BASE Use_Debug_Libraries 1
# PROP BASE Output_Dir "Debug"
# PROP BASE Intermediate_Dir "Debug"
# PROP BASE Target_Dir ""
# PROP Use_MFC 6
# PROP Use_Debug_Libraries 1
# PROP Output_Dir "Debug"
# PROP Intermediate_Dir "Debug"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /Yu"stdafx.h" /FD /GZ /c
# ADD CPP /nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Yu"stdafx.h" /FD /GZ /c
# ADD BASE MTL /nologo /D "_DEBUG" /mktyplib203 /win32
# ADD MTL /nologo /D "_DEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x408 /d "_DEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "_DEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /debug /machine:I386 /pdbtype:sept
# ADD LINK32 /nologo /subsystem:windows /dll /debug /machine:I386 /out:"Release/VDraw5VN.dll" /pdbtype:sept

!ENDIF 

# Begin Target

# Name "VDrawRes - Win32 Release"
# Name "VDrawRes - Win32 Debug"
# Begin Group "Source Files"

# PROP Default_Filter "cpp;c;cxx;rc;def;r;odl;idl;hpj;bat"
# Begin Source File

SOURCE=.\StdAfx.cpp
# ADD CPP /Yc"stdafx.h"
# End Source File
# Begin Source File

SOURCE=.\VDrawRes.cpp
# End Source File
# Begin Source File

SOURCE=.\VDrawRes.def
# End Source File
# Begin Source File

SOURCE=.\VDrawRes.rc
# End Source File
# End Group
# Begin Group "Header Files"

# PROP Default_Filter "h;hpp;hxx;hm;inl"
# Begin Source File

SOURCE=.\Resource.h
# End Source File
# Begin Source File

SOURCE=.\StdAfx.h
# End Source File
# Begin Source File

SOURCE=.\VDrawRes.h
# End Source File
# End Group
# Begin Group "Resource Files"

# PROP Default_Filter "ico;cur;bmp;dlg;rc2;rct;bin;rgs;gif;jpg;jpeg;jpe"
# Begin Source File

SOURCE=.\ClipPaste.bmp
# End Source File
# Begin Source File

SOURCE=.\cursor1.cur
# End Source File
# Begin Source File

SOURCE=.\cursor3d.cur
# End Source File
# Begin Source File

SOURCE=.\H_POINT.CUR
# End Source File
# Begin Source File

SOURCE=.\hatch1.bmp
# End Source File
# Begin Source File

SOURCE=.\hatch2.bmp
# End Source File
# Begin Source File

SOURCE=.\hatch3.bmp
# End Source File
# Begin Source File

SOURCE=.\hide.bmp
# End Source File
# Begin Source File

SOURCE=.\layfreez.bmp
# End Source File
# Begin Source File

SOURCE=.\laylock.bmp
# End Source File
# Begin Source File

SOURCE=.\layouts.bmp
# End Source File
# Begin Source File

SOURCE=.\laythaw.bmp
# End Source File
# Begin Source File

SOURCE=.\layunloc.bmp
# End Source File
# Begin Source File

SOURCE=.\planw.bmp
# End Source File
# Begin Source File

SOURCE=.\shade.bmp
# End Source File
# Begin Source File

SOURCE=.\shadeon.bmp
# End Source File
# Begin Source File

SOURCE=.\staCopy.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_cli.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_lay.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_ope.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_pan.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_pri.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_red.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_ren.bmp
# End Source File
# Begin Source File

SOURCE=.\stat_vto.bmp
# End Source File
# Begin Source File

SOURCE=.\vbot.bmp
# End Source File
# Begin Source File

SOURCE=.\res\VDrawRes.rc2
# End Source File
# Begin Source File

SOURCE=.\vdynamic.bmp
# End Source File
# Begin Source File

SOURCE=.\vfront.bmp
# End Source File
# Begin Source File

SOURCE=.\viewback.bmp
# End Source File
# Begin Source File

SOURCE=.\vleft.bmp
# End Source File
# Begin Source File

SOURCE=.\vne.bmp
# End Source File
# Begin Source File

SOURCE=.\vnw.bmp
# End Source File
# Begin Source File

SOURCE=.\vright.bmp
# End Source File
# Begin Source File

SOURCE=.\vrot.bmp
# End Source File
# Begin Source File

SOURCE=.\vse.bmp
# End Source File
# Begin Source File

SOURCE=.\vsw.bmp
# End Source File
# Begin Source File

SOURCE=.\wire.bmp
# End Source File
# Begin Source File

SOURCE=.\zall.bmp
# End Source File
# Begin Source File

SOURCE=.\ze.bmp
# End Source File
# Begin Source File

SOURCE=.\zoom_w.bmp
# End Source File
# Begin Source File

SOURCE=.\zoomin.bmp
# End Source File
# Begin Source File

SOURCE=.\zoomp.bmp
# End Source File
# Begin Source File

SOURCE=.\zout.bmp
# End Source File
# End Group
# Begin Source File

SOURCE=.\ReadMe.txt
# End Source File
# End Target
# End Project
