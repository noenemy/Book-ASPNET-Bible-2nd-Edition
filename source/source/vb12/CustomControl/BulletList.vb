Imports System.Web.UI.WebControls

Public Class BulletList
    Inherits ListControl

    Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
        ' ������ ����ϱ�
        Dim Item As ListItem
        For Each Item In Items
            writer.Write("<li>" & Item.Text)
        Next
    End Sub
End Class
