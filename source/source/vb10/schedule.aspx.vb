Public Class schedule
    Inherits System.Web.UI.Page
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar

#Region " Web Form �����̳ʿ��� ������ �ڵ� "

    '�� ȣ���� Web Form �����̳ʿ� �ʿ��մϴ�.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: �� �޼��� ȣ���� Web Form �����̳ʿ� �ʿ��մϴ�.
        '�ڵ� �����⸦ ����Ͽ� �������� ���ʽÿ�.
        InitializeComponent()
    End Sub

#End Region

    Dim schedule(13, 32) As String  ' ������ �迭 ���� - Ŭ���� �� ��������

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '���⿡ ����� �ڵ带 ��ġ�Ͽ� �������� �ʱ�ȭ�մϴ�.

        schedule(1, 1) = "����"
        schedule(1, 10) = "���� ����"
        schedule(1, 20) = "ģ�� ��ȥ��"
        schedule(1, 26) = "��âȸ"
        schedule(2, 13) = "������"
        schedule(2, 18) = "���"
        schedule(2, 28) = "���� ������"
        schedule(3, 1) = "������"
        schedule(4, 2) = "���� ����"
        schedule(4, 5) = "�ĸ���"
        schedule(5, 5) = "��̳�"
        schedule(10, 3) = "��õ��"
        schedule(10, 20) = "noenemy ����"
        schedule(12, 25) = "ũ��������"
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
            If Memo <> "" Then ' �ش��Ͽ� �������� ������ ���
                c.Controls.Add(New LiteralControl("<br>" + Memo))
            End If
        End If
    End Sub
End Class
