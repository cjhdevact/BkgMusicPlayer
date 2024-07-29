<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BkgMusic
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BkgMusic))
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(-1, -1)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(34, 33)
        Me.Player.TabIndex = 0
        '
        'BkgMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(44, 42)
        Me.ControlBox = False
        Me.Controls.Add(Me.Player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BkgMusic"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "BkgMusic"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
End Class
