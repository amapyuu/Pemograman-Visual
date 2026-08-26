<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        btnTampilkan = New Button()
        btnHapus = New Button()
        Label3 = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtKom = New TextBox()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nim"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(58, 241)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 2
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(204, 241)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 25)
        Label3.TabIndex = 4
        Label3.Text = "Kom"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(110, 31)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(110, 97)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 31)
        txtNim.TabIndex = 6
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(110, 164)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(150, 31)
        txtKom.TabIndex = 7
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(340, 241)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(txtKom)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnKeluar As Button

End Class
