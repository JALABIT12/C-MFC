
// MFCApp11View.cpp: CMFCApp11View 클래스의 구현
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS는 미리 보기, 축소판 그림 및 검색 필터 처리기를 구현하는 ATL 프로젝트에서 정의할 수 있으며
// 해당 프로젝트와 문서 코드를 공유하도록 해 줍니다.
#ifndef SHARED_HANDLERS
#include "MFCApp11.h"
#endif

#include "MFCApp11Doc.h"
#include "MFCApp11View.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMFCApp11View

IMPLEMENT_DYNCREATE(CMFCApp11View, CEditView)

BEGIN_MESSAGE_MAP(CMFCApp11View, CEditView)
	// 표준 인쇄 명령입니다.
	ON_COMMAND(ID_FILE_PRINT, &CEditView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CEditView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CMFCApp11View::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
	ON_COMMAND(ID_ZOOMIN, &CMFCApp11View::OnZoomin)
	ON_COMMAND(ID_ZOOMOUT, &CMFCApp11View::OnZoomout)
END_MESSAGE_MAP()

// CMFCApp11View 생성/소멸

CMFCApp11View::CMFCApp11View() noexcept
{
	// TODO: 여기에 생성 코드를 추가합니다.

}

CMFCApp11View::~CMFCApp11View()
{
}

BOOL CMFCApp11View::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: CREATESTRUCT cs를 수정하여 여기에서
	//  Window 클래스 또는 스타일을 수정합니다.

	BOOL bPreCreated = CEditView::PreCreateWindow(cs);
	cs.style &= ~(ES_AUTOHSCROLL|WS_HSCROLL);	// 자동 래핑을 사용합니다.

	return bPreCreated;
}


// CMFCApp11View 인쇄


void CMFCApp11View::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CMFCApp11View::OnPreparePrinting(CPrintInfo* pInfo)
{
	// 기본적인 CEditView 준비
	return CEditView::OnPreparePrinting(pInfo);
}

void CMFCApp11View::OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo)
{
	// 기본 CEditView 시작 인쇄
	CEditView::OnBeginPrinting(pDC, pInfo);
}

void CMFCApp11View::OnEndPrinting(CDC* pDC, CPrintInfo* pInfo)
{
	// 기본 CEditView 종료 인쇄
	CEditView::OnEndPrinting(pDC, pInfo);
}

void CMFCApp11View::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CMFCApp11View::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CMFCApp11View 진단

#ifdef _DEBUG
void CMFCApp11View::AssertValid() const
{
	CEditView::AssertValid();
}

void CMFCApp11View::Dump(CDumpContext& dc) const
{
	CEditView::Dump(dc);
}

CMFCApp11Doc* CMFCApp11View::GetDocument() const // 디버그되지 않은 버전은 인라인으로 지정됩니다.
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMFCApp11Doc)));
	return (CMFCApp11Doc*)m_pDocument;
}
#endif //_DEBUG


// CMFCApp11View 메시지 처리기

static int fSize = 30;
CFont tf;
void CMFCApp11View::OnZoomin()
{
	// TODO: 여기에 명령 처리기 코드를 추가합니다.
	// Client 영역의 문자 크기를 확대
	LOGFONT lf;
	//ZeroMemory(&lf, sizeof(lf));
	//lf.lfHeight = fSize ++ ;
	if (GetFont() == NULL)
	{
		CFont* pFont = CFont::FromHandle((HFONT)GetStockObject(DEFAULT_GUI_FONT));
		pFont->GetLogFont(&lf);
	}
	else GetFont()->GetLogFont(&lf);
	if (lf.lfHeight < 0) lf.lfHeight = abs(lf.lfHeight);
	lf.lfHeight++;
	//CFont* cf = new CFont; 메모리 문제
	//cf->CreateFontIndirect(&lf);
	tf.DeleteObject();
	tf.CreateFontIndirect(&lf);
	SetFont(&tf);
}


void CMFCApp11View::OnZoomout()
{
	// TODO: 여기에 명령 처리기 코드를 추가합니다.
	// Client 영역의 문자 크기를 축소
	LOGFONT lf;
	if (GetFont() == NULL)
	{
		CFont* pFont = CFont::FromHandle((HFONT)GetStockObject(DEFAULT_GUI_FONT));
		pFont->GetLogFont(&lf);
	}
	else GetFont()->GetLogFont(&lf);
	if (lf.lfHeight > 0) lf.lfHeight = abs(lf.lfHeight);
	lf.lfHeight--;
	tf.DeleteObject();
	tf.CreateFontIndirect(&lf);
	SetFont(&tf);
}





//BOOL CMFCApp11View::PreTranslateMessage(MSG* pMsg)
//{
//	// TODO: 여기에 특수화된 코드를 추가 및/또는 기본 클래스를 호출합니다.
//	switch (pMsg->message)
//	{
//	case WM_KEYDOWN:
//		
//		switch (pMsg->wParam) //'F1' Key가 눌렸는가? 
//		{
//		case VK_CONTROL:
//
//		case 107: //	'+'
//		case 187:
//			//CMainFrame * p = (CMainFrame*)AfxGetMainWnd(); //(CMainFrame*)AfxGetMainWnd(); 캐스팅해줌
//			//CMFCApp11View*p1=(CMFCApp11View*)p->GetActiveView(); 
//			OnZoomin(); return -1;
//		case 109: //	'-'
//		case 189:
//			OnZoomout(); return -1;
//		//case VK_F1:
//		//{
//		//	CAboutDlg dlg;
//		//	dlg.DoModal();
//		//	return 0;
//		//}
//		default: break;
//		}
//		break;
//	}
//	return CEditView::PreTranslateMessage(pMsg);
//}
