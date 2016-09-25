Imports System.Web.UI.WebControls

Public Class FlatTextBox
    Inherits TextBox

    Public Sub New()    ' 생성자
        ' TextBox 스타일 설정하기
        Me.Style.Item("border") = "solid 1px black"
        Me.Font.Name = "verdana"
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Font.Size = FontUnit.XSmall
        Me.BackColor = System.Drawing.Color.DeepPink
    End Sub


End Class
