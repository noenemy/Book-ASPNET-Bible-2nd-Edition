Imports System.Web.UI.WebControls

Public Class FlatTextBox
    Inherits TextBox

    Public Sub New()    ' ������
        ' TextBox ��Ÿ�� �����ϱ�
        Me.Style.Item("border") = "solid 1px black"
        Me.Font.Name = "verdana"
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Font.Size = FontUnit.XSmall
        Me.BackColor = System.Drawing.Color.DeepPink
    End Sub


End Class
