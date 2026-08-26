Public Class Form1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Guten Morgen" & vbCrLf &
                    "Nama  :" & txtNama.Text & vbCrLf &
                    "NIM  :" & txtNim.Text & vbCrLf &
                    "KOM  :" & txtKom.Text
     )
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNim.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtKom.Clear()
        txtNama.Clear()
        txtNim.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
