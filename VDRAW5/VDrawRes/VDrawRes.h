// VDrawRes.h : main header file for the VDRAWRES DLL
//

#if !defined(AFX_VDRAWRES_H__888CC7C5_6C99_11D3_9784_FC95E09F1271__INCLUDED_)
#define AFX_VDRAWRES_H__888CC7C5_6C99_11D3_9784_FC95E09F1271__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CVDrawResApp
// See VDrawRes.cpp for the implementation of this class
//

class CVDrawResApp : public CWinApp
{
public:
	CVDrawResApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CVDrawResApp)
	//}}AFX_VIRTUAL

	//{{AFX_MSG(CVDrawResApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_VDRAWRES_H__888CC7C5_6C99_11D3_9784_FC95E09F1271__INCLUDED_)
