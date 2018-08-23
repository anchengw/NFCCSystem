Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EasyUser.ClientSN = "" Then
            Me.Text = Me.Text & "(未注册)"
        End If
        If IO.File.Exists(Application.StartupPath & "\Logo.ico") Then
            Me.PicFlag.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Logo.ico")
        ElseIf IO.File.Exists(Application.StartupPath & "\Logo.jpg") Then
            Me.PicFlag.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Logo.jpg")
        ElseIf IO.File.Exists(Application.StartupPath & "\Logo.bmp") Then
            Me.PicFlag.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Logo.bmp")
        End If
        Me.lblProgramVersion.Visible = False
        Me.lblDesignerWebSite.Visible = False
        Me.lblClientName.Visible = False
        Me.lblProgramName.Text = "系统名称:" & EasyUser.ProgramName
        Me.lblProgramVersion.Text = "版本:" & EasyUser.ProgramVersion
        'Me.lblClientName.Text = "使用单位:" & EasyUser.ClientName
        Me.lblClientSN.Text = "序列号:" & EasyUser.ClientSN
        Me.lblDesigner.Text = "开发单位:" & EasyUser.Designer
        'Me.lblDesignerWebSite.Text = "http://www.prajna.cn"

    End Sub

    'Private Sub lblDesignerWebSite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblDesignerWebSite.LinkClicked
    '    Try
    '        Me.lblDesignerWebSite.LinkVisited = False
    '        System.Diagnostics.Process.Start(Me.lblDesignerWebSite.Text)
    '    Catch ex As Exception
    '        ' The error message
    '        MessageBox.Show("不能打开这个连接！")
    '    End Try
    'End Sub
End Class