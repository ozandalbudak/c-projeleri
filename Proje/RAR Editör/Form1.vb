Imports RARNET
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Title = "Çıkartılacak RAR Arşivi"
        dlg.CheckFileExists = True
        dlg.DefaultExt = "RAR"
        dlg.Filter = "RAR dosyaları (*.rar)|*.rar"
        Dim res As DialogResult = dlg.ShowDialog()
        If res = DialogResult.OK Then
            TextBox1.Text = dlg.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.TextLength < 1 Then Exit Sub
            If TextBox2.TextLength < 1 Then Exit Sub
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Dim d As New Decompressor(TextBox1.Text)
            AddHandler d.OnUnpack, AddressOf Unpacked
            AddHandler d.Unpacking, AddressOf InProgress
            d.UnPackAll(TextBox2.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Unpacked(ByVal r As Decompressor.RAREntry)
        Label4.Visible = True
        Label4.Text = "Çıkartıldı: " & r.FileName
        ' If u want to shorten the text and add "..."
        If Label4.Text.Length > 38 Then
            Label4.Text = Label4.Text.Substring(0, 38) + "..."
        End If
    End Sub

    Public Sub InProgress(ByVal fTotalFileSize As Long, ByVal fUnpacked As Long, ByRef Disposition As RARNET.Decompressor.RarDisposition)
        Dim d As New Decompressor(TextBox1.Text)
        If fTotalFileSize = 0 Then Exit Sub
        Label3.Text = Format(fUnpacked / fTotalFileSize, "percent")
        ProgressBar1.Value = CInt(CDbl(Format(fUnpacked / fTotalFileSize)) * 100)
        Me.Refresh()
    End Sub

    Public Sub GetPath()
        Dim dlg2 As FolderBrowserDialog = New FolderBrowserDialog()
        Dim res2 As DialogResult = dlg2.ShowDialog()
        If res2 = DialogResult.OK Then
            TextBox2.Text = dlg2.SelectedPath
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not System.IO.File.Exists(Application.StartupPath & "\unrar.dll") Then
            MsgBox("Program dosyaları eksik!", MsgBoxStyle.Critical)
            Application.Exit()
        End If
        Label4.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GetPath()
    End Sub
End Class
