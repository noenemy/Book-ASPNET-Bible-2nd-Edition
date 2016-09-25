Public Class schedule
    Inherits System.Web.UI.Page
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar

#Region " Web Form 디자이너에서 생성한 코드 "

    '이 호출은 Web Form 디자이너에 필요합니다.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 이 메서드 호출은 Web Form 디자이너에 필요합니다.
        '코드 편집기를 사용하여 수정하지 마십시오.
        InitializeComponent()
    End Sub

#End Region

    Dim schedule(13, 32) As String  ' 스케쥴 배열 선언 - 클래스 내 전역변수

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '여기에 사용자 코드를 배치하여 페이지를 초기화합니다.

        schedule(1, 1) = "신정"
        schedule(1, 10) = "강모 모임"
        schedule(1, 20) = "친구 결혼식"
        schedule(1, 26) = "동창회"
        schedule(2, 13) = "졸업식"
        schedule(2, 18) = "우수"
        schedule(2, 28) = "원고 마감일"
        schedule(3, 1) = "삼일절"
        schedule(4, 2) = "혜미 생일"
        schedule(4, 5) = "식목일"
        schedule(5, 5) = "어린이날"
        schedule(10, 3) = "개천절"
        schedule(10, 20) = "noenemy 생일"
        schedule(12, 25) = "크리스마스"
    End Sub

    Private Sub Calendar1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles Calendar1.DayRender
        Dim d As CalendarDay
        Dim c As TableCell
        d = e.Day
        c = e.Cell

        If d.IsOtherMonth Then
            c.Controls.Clear()
        Else
            Dim Memo As String = schedule(d.Date.Month, d.Date.Day)
            If Memo <> "" Then ' 해당일에 스케줄이 있으면 출력
                c.Controls.Add(New LiteralControl("<br>" + Memo))
            End If
        End If
    End Sub
End Class
