# Microsoft Developer Studio Generated NMAKE File, Based on VDrawRes.dsp
!IF "$(CFG)" == ""
CFG=VDrawRes - Win32 Debug
!MESSAGE No configuration specified. Defaulting to VDrawRes - Win32 Debug.
!ENDIF 

!IF "$(CFG)" != "VDrawRes - Win32 Release" && "$(CFG)" != "VDrawRes - Win32 Debug"
!MESSAGE Invalid configuration "$(CFG)" specified.
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
!ERROR An invalid configuration is specified.
!ENDIF 

!IF "$(OS)" == "Windows_NT"
NULL=
!ELSE 
NULL=nul
!ENDIF 

CPP=cl.exe
MTL=midl.exe
RSC=rc.exe

!IF  "$(CFG)" == "VDrawRes - Win32 Release"

OUTDIR=.\Release
INTDIR=.\Release
# Begin Custom Macros
OutDir=.\Release
# End Custom Macros

ALL : "$(OUTDIR)\VDrawRes.dll"


CLEAN :
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\vc60.idb"
	-@erase "$(INTDIR)\VDrawRes.obj"
	-@erase "$(INTDIR)\VDrawRes.pch"
	-@erase "$(INTDIR)\VDrawRes.res"
	-@erase "$(OUTDIR)\VDrawRes.dll"
	-@erase "$(OUTDIR)\VDrawRes.exp"
	-@erase "$(OUTDIR)\VDrawRes.lib"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=/nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Fp"$(INTDIR)\VDrawRes.pch" /Yu"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /c 
MTL_PROJ=/nologo /D "NDEBUG" /mktyplib203 /win32 
RSC_PROJ=/l 0x409 /fo"$(INTDIR)\VDrawRes.res" /d "NDEBUG" /d "_AFXDLL" 
BSC32=bscmake.exe
BSC32_FLAGS=/nologo /o"$(OUTDIR)\VDrawRes.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
LINK32_FLAGS=/nologo /subsystem:windows /dll /incremental:no /pdb:"$(OUTDIR)\VDrawRes.pdb" /machine:I386 /def:".\VDrawRes.def" /out:"$(OUTDIR)\VDrawRes.dll" /implib:"$(OUTDIR)\VDrawRes.lib" 
DEF_FILE= \
	".\VDrawRes.def"
LINK32_OBJS= \
	"$(INTDIR)\StdAfx.obj" \
	"$(INTDIR)\VDrawRes.obj" \
	"$(INTDIR)\VDrawRes.res"

"$(OUTDIR)\VDrawRes.dll" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

ProjDir=.
SOURCE="$(InputPath)"
DS_POSTBUILD_DEP=$(INTDIR)\postbld.dep

ALL : $(DS_POSTBUILD_DEP)

# Begin Custom Macros
OutDir=.\Release
# End Custom Macros

$(DS_POSTBUILD_DEP) : "$(OUTDIR)\VDrawRes.dll"
   del /q "C:\VECTORDRAW_CD\ALL\International Resources\*.*"
	del /q "C:\VECTORDRAW_CD\ALL\International Resources\res\*.*"
	copy ".\*.*" "C:\VECTORDRAW_CD\ALL\International Resources"
	copy ".\res\*.*" "C:\VECTORDRAW_CD\ALL\International Resources\res"
	echo Helper for Post-build step > "$(DS_POSTBUILD_DEP)"

!ELSEIF  "$(CFG)" == "VDrawRes - Win32 Debug"

OUTDIR=.\Debug
INTDIR=.\Debug
# Begin Custom Macros
OutDir=.\Debug
# End Custom Macros

ALL : "$(OUTDIR)\VDrawRes.dll"


CLEAN :
	-@erase "$(INTDIR)\StdAfx.obj"
	-@erase "$(INTDIR)\vc60.idb"
	-@erase "$(INTDIR)\vc60.pdb"
	-@erase "$(INTDIR)\VDrawRes.obj"
	-@erase "$(INTDIR)\VDrawRes.pch"
	-@erase "$(INTDIR)\VDrawRes.res"
	-@erase "$(OUTDIR)\VDrawRes.dll"
	-@erase "$(OUTDIR)\VDrawRes.exp"
	-@erase "$(OUTDIR)\VDrawRes.ilk"
	-@erase "$(OUTDIR)\VDrawRes.lib"
	-@erase "$(OUTDIR)\VDrawRes.pdb"

"$(OUTDIR)" :
    if not exist "$(OUTDIR)/$(NULL)" mkdir "$(OUTDIR)"

CPP_PROJ=/nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Fp"$(INTDIR)\VDrawRes.pch" /Yu"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /GZ /c 
MTL_PROJ=/nologo /D "_DEBUG" /mktyplib203 /win32 
RSC_PROJ=/l 0x409 /fo"$(INTDIR)\VDrawRes.res" /d "_DEBUG" /d "_AFXDLL" 
BSC32=bscmake.exe
BSC32_FLAGS=/nologo /o"$(OUTDIR)\VDrawRes.bsc" 
BSC32_SBRS= \
	
LINK32=link.exe
LINK32_FLAGS=/nologo /subsystem:windows /dll /incremental:yes /pdb:"$(OUTDIR)\VDrawRes.pdb" /debug /machine:I386 /def:".\VDrawRes.def" /out:"$(OUTDIR)\VDrawRes.dll" /implib:"$(OUTDIR)\VDrawRes.lib" /pdbtype:sept 
DEF_FILE= \
	".\VDrawRes.def"
LINK32_OBJS= \
	"$(INTDIR)\StdAfx.obj" \
	"$(INTDIR)\VDrawRes.obj" \
	"$(INTDIR)\VDrawRes.res"

"$(OUTDIR)\VDrawRes.dll" : "$(OUTDIR)" $(DEF_FILE) $(LINK32_OBJS)
    $(LINK32) @<<
  $(LINK32_FLAGS) $(LINK32_OBJS)
<<

!ENDIF 

.c{$(INTDIR)}.obj::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cpp{$(INTDIR)}.obj::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cxx{$(INTDIR)}.obj::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.c{$(INTDIR)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cpp{$(INTDIR)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<

.cxx{$(INTDIR)}.sbr::
   $(CPP) @<<
   $(CPP_PROJ) $< 
<<


!IF "$(NO_EXTERNAL_DEPS)" != "1"
!IF EXISTS("VDrawRes.dep")
!INCLUDE "VDrawRes.dep"
!ELSE 
!MESSAGE Warning: cannot find "VDrawRes.dep"
!ENDIF 
!ENDIF 


!IF "$(CFG)" == "VDrawRes - Win32 Release" || "$(CFG)" == "VDrawRes - Win32 Debug"
SOURCE=.\StdAfx.cpp

!IF  "$(CFG)" == "VDrawRes - Win32 Release"

CPP_SWITCHES=/nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Fp"$(INTDIR)\VDrawRes.pch" /Yc"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /c 

"$(INTDIR)\StdAfx.obj"	"$(INTDIR)\VDrawRes.pch" : $(SOURCE) "$(INTDIR)"
	$(CPP) @<<
  $(CPP_SWITCHES) $(SOURCE)
<<


!ELSEIF  "$(CFG)" == "VDrawRes - Win32 Debug"

CPP_SWITCHES=/nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Fp"$(INTDIR)\VDrawRes.pch" /Yc"stdafx.h" /Fo"$(INTDIR)\\" /Fd"$(INTDIR)\\" /FD /GZ /c 

"$(INTDIR)\StdAfx.obj"	"$(INTDIR)\VDrawRes.pch" : $(SOURCE) "$(INTDIR)"
	$(CPP) @<<
  $(CPP_SWITCHES) $(SOURCE)
<<


!ENDIF 

SOURCE=.\VDrawRes.cpp

"$(INTDIR)\VDrawRes.obj" : $(SOURCE) "$(INTDIR)" "$(INTDIR)\VDrawRes.pch"


SOURCE=.\VDrawRes.rc

"$(INTDIR)\VDrawRes.res" : $(SOURCE) "$(INTDIR)"
	$(RSC) $(RSC_PROJ) $(SOURCE)



!ENDIF 

