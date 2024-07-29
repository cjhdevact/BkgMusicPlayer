Public Class BkgMusic
    'Public mstime As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Player.uiMode = "none"
        Dim a As System.Drawing.Point
        a.X = -2
        a.Y = -2
        Me.Location = a

        '命令行加载音乐
        If Command() <> "" Then
            cmdfile = Command()
        End If

        If cmdfile = "" Then
            MsgBox("后台音乐播放命令参数帮助" & vbCrLf _
                  & "版权所有 (C) 2023 CJH。保留所有权利。" & vbCrLf & vbCrLf _
                  & "使用方法：" & vbCrLf _
                  & "bkgmusic [命令参数]" & vbCrLf & vbCrLf _
                  & "命令参数为以下其中一项：" & vbCrLf _
                  & "/?         获取本帮助信息。" & vbCrLf _
                  & "%1         音乐文件的路径。" _
                  , MsgBoxStyle.Information, "帮助")
            End
        End If
        If cmdfile <> "" Then


            cmdfilew = cmdfile

            If cmdfile = "/?" Then
                MsgBox("后台音乐播放命令参数帮助" & vbCrLf _
                     & "版权所有 (C) 2023 CJH。保留所有权利。" & vbCrLf & vbCrLf _
                     & "使用方法：" & vbCrLf _
                     & "bkgmusic [命令参数]" & vbCrLf & vbCrLf _
                     & "命令参数为以下其中一项：" & vbCrLf _
                     & "/?         获取本帮助信息。" & vbCrLf _
                     & "%1         音乐文件的路径。" _
                     , MsgBoxStyle.Information, "帮助")
                End
            ElseIf cmdfile <> Nothing Then

                Dim spstr As Boolean
                spstr = InStr(cmdfile, " ")
                'If spstr = False Then
                'Dim ttstr As Boolean
                'ttstr = InStr(cmdfile, Chr(34))
                'If ttstr = True Then
                cmdfile = cmdfile.Replace("""", "").Trim()
                'End If
                If System.IO.File.Exists(cmdfile) = True Then
                    Try
                        'My.Computer.Audio.Play(cmdfile, AudioPlayMode.WaitToComplete)
                        'My.Computer.Audio.Play(cmdfile, AudioPlayMode.Background)
                        Player.settings.volume = 100
                        '将选择文件一个一个加入播放器播放列表
                        Player.currentPlaylist.appendItem(Player.newMedia(cmdfile))
                        Player.URL = cmdfile

                        'mstime = Player.currentMedia.duration
                        'mstime = Int(mstime)
                        'Timer1.Interval = mstime * 1000
                        'If mstime = 0 Then
                        'If cmdfile <> "" Then
                        'MsgBox("尝试打开文件 " & Chr(34) & " " & cmdfile & " " & Chr(34) & " 出错。", MsgBoxStyle.Critical, "错误")
                        'End
                        'End If
                        'Else
                        Player.Ctlcontrols.play()
                'Timer1.Enabled = True
                        'End If

                    Catch ex As Exception
                        'MsgBox("参数错误！请检查参数内容。", MsgBoxStyle.Critical, "错误")
                        'cmdfile = ""
                        'cmdfilew = ""
                        'End
                    End Try
                Else
                    If cmdfile <> "" Then
                        MsgBox("尝试打开文件 " & Chr(34) & " " & cmdfile & " " & Chr(34) & " 出错。", MsgBoxStyle.Critical, "错误")
                        End
                    End If
                    cmdfilew = ""
                    cmdfile = ""
                End If

            End If
            cmdfile = ""
            cmdfilew = ""
        End If
    End Sub
    Private Sub Player_openStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_OpenStateChangeEvent) Handles Player.OpenStateChange
        If e.newState = 13 Then
            '开始播放
            Me.Hide()
            'Timer1.Enabled = True
            Player.Ctlcontrols.play()
        End If
    End Sub
    Private Sub Player_PlayStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles Player.PlayStateChange
        'If e.newState = 3 Then
        '   Timer1.Enabled = True
        'End If
        If e.newState = 1 Then
            End
        End If
    End Sub
End Class