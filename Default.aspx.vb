Partial Class _Default

Inherits System.Web.UI.Page

Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

Handles Button1.Click

Dim wsConvert As New localhost.Service()

TextBox3.Text = wsConvert.CF(TextBox1.Text)

End Sub

Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)

Handles Button2.Click

Dim wsConvert As New localhost.Service()

TextBox4.Text = wsConvert.FC(TextBox2.Text)

End Sub

End Class
