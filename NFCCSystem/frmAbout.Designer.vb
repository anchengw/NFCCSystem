<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblProgramVersion = New System.Windows.Forms.Label
        Me.lblClientSN = New System.Windows.Forms.Label
        Me.lblDesignerWebSite = New System.Windows.Forms.LinkLabel
        Me.PicFlag = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblProgramName = New System.Windows.Forms.Label
        Me.lblClientName = New System.Windows.Forms.Label
        Me.lblDesigner = New System.Windows.Forms.Label
        CType(Me.PicFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProgramVersion
        '
        Me.lblProgramVersion.Location = New System.Drawing.Point(180, 38)
        Me.lblProgramVersion.Name = "lblProgramVersion"
        Me.lblProgramVersion.Size = New System.Drawing.Size(248, 15)
        Me.lblProgramVersion.TabIndex = 33
        Me.lblProgramVersion.Text = "版本:1.0.0"
        '
        'lblClientSN
        '
        Me.lblClientSN.Location = New System.Drawing.Point(168, 85)
        Me.lblClientSN.Name = "lblClientSN"
        Me.lblClientSN.Size = New System.Drawing.Size(260, 16)
        Me.lblClientSN.TabIndex = 32
        Me.lblClientSN.Text = "序列号:"
        '
        'lblDesignerWebSite
        '
        Me.lblDesignerWebSite.Location = New System.Drawing.Point(196, 141)
        Me.lblDesignerWebSite.Name = "lblDesignerWebSite"
        Me.lblDesignerWebSite.Size = New System.Drawing.Size(227, 15)
        Me.lblDesignerWebSite.TabIndex = 31
        Me.lblDesignerWebSite.TabStop = True
        Me.lblDesignerWebSite.Text = "http://www.prajna.cn"
        '
        'PicFlag
        '
        Me.PicFlag.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PicFlag.Image = CType(resources.GetObject("PicFlag.Image"), System.Drawing.Image)
        Me.PicFlag.Location = New System.Drawing.Point(12, 18)
        Me.PicFlag.Name = "PicFlag"
        Me.PicFlag.Size = New System.Drawing.Size(91, 93)
        Me.PicFlag.TabIndex = 30
        Me.PicFlag.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 64)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "警告： 本计算机程序受版权法和国际条约的保护。如未经授权而擅自复制或传播本程序(或其中任何部分)，将受到严厉的刑事及民事制裁，并将在法律许可的范围内受到最大可能的" & _
            "起诉。"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(364, 213)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "关闭"
        '
        'lblProgramName
        '
        Me.lblProgramName.Location = New System.Drawing.Point(156, 13)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(272, 23)
        Me.lblProgramName.TabIndex = 25
        Me.lblProgramName.Text = "系统名称:"
        '
        'lblClientName
        '
        Me.lblClientName.Location = New System.Drawing.Point(156, 61)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(272, 23)
        Me.lblClientName.TabIndex = 26
        Me.lblClientName.Text = "使用单位:"
        '
        'lblDesigner
        '
        Me.lblDesigner.Location = New System.Drawing.Point(156, 109)
        Me.lblDesigner.Name = "lblDesigner"
        Me.lblDesigner.Size = New System.Drawing.Size(272, 23)
        Me.lblDesigner.TabIndex = 27
        Me.lblDesigner.Text = "设计单位:"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(458, 261)
        Me.Controls.Add(Me.lblProgramVersion)
        Me.Controls.Add(Me.lblClientSN)
        Me.Controls.Add(Me.lblDesignerWebSite)
        Me.Controls.Add(Me.PicFlag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblProgramName)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.lblDesigner)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "关于"
        CType(Me.PicFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProgramVersion As System.Windows.Forms.Label
    Friend WithEvents lblClientSN As System.Windows.Forms.Label
    Friend WithEvents lblDesignerWebSite As System.Windows.Forms.LinkLabel
    Friend WithEvents PicFlag As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblProgramName As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents lblDesigner As System.Windows.Forms.Label
End Class
