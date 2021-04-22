Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.text = TextBox1.Text 'My.Settings'deki text veri alanımıza textbox1.text'i kayıt ediyoruz.
        My.Settings.Save() 'My.Settings'i Kayıt Ediyoruz.
        TextBox1.Clear() ' Textbox1.'i Temizliyoruz.
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = My.Settings.text ' Textbox1.text'e My.Settings'deki text veri alanımızı çekiyoruz.
    End Sub

    'XML veritabanı vb.net'in bize sağladığı basit bir veri depolama yeridir.
    'My.Settings'e yukarıdaki menüden Porject>"Program Adı" Properties>Settings yoluyla ulaşabilirsiniz.
End Class
