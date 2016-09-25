Imports System.Data.SqlClient

Public Class crystal_rpt
    Inherits System.Web.UI.Page
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '여기에 사용자 코드를 배치하여 페이지를 초기화합니다.

        ' 데이터베이스 연결 설정
        Dim conn As New SqlConnection("Server=(local);Database=Northwind;uid=sa;pwd=;")
        Dim comm As New SqlCommand("SELECT * FROM categories", conn)
        Dim adapter As New SqlDataAdapter(comm)
        Dim ds As New dsCategories()

        ' DataSet 채우기 (report 생성시 사용한 테이블 이름을 지정해야한다.)
        adapter.Fill(ds, "categories")
        ' Report 객체 생성 
        Dim rpt As New rptCategory()
        ' 리포트 출력하기        rpt.SetDataSource(ds) 
        CrystalReportViewer1.ReportSource = rpt
    End Sub

End Class
