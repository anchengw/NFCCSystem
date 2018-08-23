Module ModMain
    Public Cnn, CnnAccount As Easy.Win.EasyDBConnection
    Public EasyUser As New Easy.Win.EasyUser.EasyUser
    Public EasyBase As New Easy.Win.EasyBase.EasyBase
    Public EasyBill As New Easy.Win.EasyBill.EasyBill
    Public EasyWhere As New Easy.Win.EasyWhere.EasyWhere
    Public EasyReport As New Easy.Win.EasyReport.EasyReport
    Public EasyPrint As New Easy.Win.EasyPrint.EasyPrint

    Public UserID As Integer
    Public EasyFc As New Easy.Win.EasyFC
    Public EasyMenu As New Easy.Win.MainMenu.EasyMenu


    Public frmMain As frmMain


    Sub Main()
        EasyUser.ProgramName = "Management Information System"
        EasyUser.LoginFormText = "Management Information System"
        'EasyUser.AccountAction = True
        EasyUser.ClientNameShow = False
        EasyUser.TryDays = 800
        EasyUser.TryAdvancePromptDays = 800
        EasyUser.RegisterDateShow = True
        EasyUser.DBName = "CCSystem"
        'EasyUser.Register("UNIK STUDIO", "華湧淨化設備有限公司", "783E8BDF0CBE36A09E6E0FE7715F33D9FEA93947")
        EasyUser.Register("UNIK STUDIO", "日門公司", "AD133B9A1ACE41A3B4DA70F25AF418B11A610E7B")
        EasyUser.LogoImage = Image.FromStream(Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream("CCSystem.LOGO.JPG"))


        '在注册的那个小窗口上显示的内容。（也可通过配置文件来改变）
        EasyUser.Designer2 = "Oneness Association"
        EasyUser.DesignerEMail = "am.amy@qq.com"
        EasyUser.DesignerFax = ""
        EasyUser.DesignerQQ = "646052820"
        EasyUser.DesignerWebSit = "http://www.nfnf.cn/"
        EasyUser.DesignerTel = "15370751357"


        EasyUser.HiddenNotAbleData = False '隐藏没权限查看的菜单

        If EasyUser.Login(True) = True Then
            Cnn = EasyUser.Connection
            CnnAccount = EasyUser.ConnectionAccount
            UserID = EasyUser.LoginUserID
            EasyBase.ConnectionMain = Cnn
            EasyBase.ConnectionAccount = CnnAccount


            EasyBill.ConnectionMain = Cnn
            EasyBill.ConnectionAccount = CnnAccount
            EasyBill.UserID = UserID

            EasyWhere.ConnectionMain = Cnn
            EasyWhere.ConnectionAccount = CnnAccount
            EasyWhere.UserID = UserID

            EasyReport.ConnectionMain = Cnn
            EasyReport.ConnectionAccount = CnnAccount
            EasyReport.UserID = UserID

            EasyPrint.ConnectionMain = Cnn
            EasyPrint.UserID = UserID

            EasyMenu.UserID = UserID
            EasyMenu.Connection = Cnn

            frmMain = New frmMain
            frmMain.ShowDialog()
        End If
        EasyUser = Nothing

    End Sub

End Module
