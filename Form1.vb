Imports System.IO
Imports System.Net.Http
Imports System.Threading
Imports Microsoft.VisualBasic.Logging

Public Class Form1

    Public log_text1 = ""
    Private imagePath As String = ""
    Private d_times = 1
    Private delay_time = 6
    Private Download_Folder1 As String = ""
    Private api_path1 As String = "https://api.vvhan.com/api/girl"

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        api_path1 = Me.ComboBox1.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim se As DialogResult
        se = Me.FolderBrowserDialog1.ShowDialog()
        If se = DialogResult.OK Then
            Dim path1 = FolderBrowserDialog1.SelectedPath
            Me.TextBox1.Text = path1
            Me.Download_Folder1 = path1
        End If

    End Sub
    Private Sub add_log(log1)
        log_text1 = "log:" & log1 & vbCrLf & log_text1
        logbox.Text = log_text1
    End Sub
    Private Sub renew_log()
        logbox.Text = log_text1
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Me.NumericUpDown1.Value <= 0 Then
            Me.NumericUpDown1.Value = 1
        End If
        d_times = Me.NumericUpDown1.Value
        add_log("次数设为" & d_times)
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If Me.NumericUpDown2.Value <= 0 Then
            Me.NumericUpDown2.Value = 1
        End If
        delay_time = Me.NumericUpDown2.Value
        add_log("间隔秒设为" & delay_time)
        delay_time = delay_time * 1000
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Download_Folder1 = TextBox1.Text
    End Sub
    Public Sub GetImageUsingWebRequest(ByVal url As String)

        Dim client As New HttpClient
        Try
            Dim result = client.GetByteArrayAsync(api_path1).Result
            Dim imageBytes As Byte() = result

            Dim currentTime As DateTime = DateTime.Now
            Dim filename = currentTime.ToString.Replace(" ", "_").Replace("/", "_").Replace("\", "_").Replace(":", "_")
            Dim filepath = Download_Folder1 & "\pic_" & filename & ".jpg"
            Using fs As New FileStream(filepath, FileMode.Create)
                fs.Write(imageBytes, 0, imageBytes.Length)
            End Using
            Dim log1 = "图片已成功保存为" & filepath
            log_text1 = "log:" & log1 & vbCrLf & log_text1 'log
            imagePath = filepath '显示图片路径

            client.Dispose() '释放
        Catch e As Exception
            Dim log2 = "无法链接api网址"
            log_text1 = "log:" & log2 & vbCrLf & log_text1 'log
            Return
        End Try


    End Sub
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        If Not Directory.Exists(Download_Folder1) Then
            add_log("下载路径不存在")
            Return
        End If

        For i = 1 To d_times
            '异步执行
            add_log("开始下载...")
            Await Task.Run(Sub()
                               GetImageUsingWebRequest(api_path1)
                           End Sub)
            renew_log() '更新log

            If imagePath = "" Then
                Return
            End If
            PictureBox1.Image = Image.FromFile(imagePath) '显示图片
            '最后一次不等待
            If i < d_times Then
                '开始异步等待
                add_log("间隔时间开始，暂停下载")
                Await Task.Run(Sub()
                                   Dim random As New Random() '创建Random对象
                                   Thread.Sleep(random.Next(delay_time - 500, delay_time + 500)) '随机休息时间
                               End Sub)
                add_log("间隔时间结束")
            End If

        Next i
        add_log("执行完毕")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        add_log("间隔时间最短为1秒，时间过短可能会被api服务器封禁ip")
    End Sub
End Class
