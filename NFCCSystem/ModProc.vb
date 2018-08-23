Imports System.Data.SqlClient
Module ModProc
    Public Sub Active()
    End Sub
    Dim WithEvents BillEvent As Easy.Win.EasyBill.EventHandler = EasyBill.EventHandler
    Dim WithEvents ReportEvent As Easy.Win.EasyReport.EventHandler = EasyReport.EventHandler
    Dim WithEvents UserEvent As Easy.Win.EasyUser.EventHandler = EasyUser.EventHandler
    Dim WithEvents BaseEvent As Easy.Win.EasyBase.EventHandler = EasyBase.EventHandler
    Dim WithEvents MenuEvent As Easy.Win.MainMenu.EventHandler = EasyMenu.EventHandler
    Dim WithEvents PrintEvent As Easy.Win.EasyPrint.EventHandler = EasyPrint.EventHandler
    Private Sub BaseEvent_OnAboutClick(ByVal sender As Object, ByVal e As Easy.Win.EasyBase.EventHandler.CommandClickEventArgs) Handles BaseEvent.OnAboutClick
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
        frmAbout = Nothing
        e.UnDoDefault = True
    End Sub
    Private Sub BillEvent_AfterSave(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.AfterSaveEventArgs) Handles BillEvent.AfterSave
        ''EasyBill.Check1Bill(e.TemplateID, e.BillID)'这行最好用下面一句替代
        'EasyBill.CheckBill(sender, 1)'最好用这个代替上面一行的语句.自动审核.
        'e.DataWindow.RefreshData()

    End Sub

    Private Sub BillEvent_BaseItemValueChanged(sender As Object, e As Easy.Win.EasyBill.EventHandler.BaseItemValueChangedEventArgs) Handles BillEvent.BaseItemValueChanged
        Select Case e.TemplateID
            Case "MountingToU8"
                Select Case e.Name
                    Case "FCientCode"
                        e.DataWindow.Grid.Rows.Clear()
                        EasyBill.FillGrid(e.DataWindow.Grid, "MountingRecordForU8", Easy.Win.EasyWhere.QueryTypeEnum.CustomQuery, , "FClientCode='" & e.DataWindow.BaseItemValue("FCientCode") & "'")
                End Select
            Case "ContractAR"

                Dim dtPeriod As DataTable = Cnn.GetDataTable("SELECT * FROM [CC_AR_辅助账] WHERE FClientCode IN (SELECT FCode FROM base_contract)" & _
                                                                                 "AND iyear=" & Year(e.DataWindow.BaseItemValue("FDate")) & _
                                                                                 "AND iperiod=" & Month(e.DataWindow.BaseItemValue("FDate")))
                e.DataWindow.Grid.Cols.Item("FClientCode").Unique = True
                EasyBill.FillGrid(e.DataWindow.Grid, dtPeriod, , , True, True)
                dtPeriod.Dispose()
                dtPeriod = Nothing
        End Select
    End Sub


    Private Sub BillEvent_BeforeCheck1(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.CancelEventArgs) Handles BillEvent.BeforeCheck1
        If Not e.DataWindow.BaseItemEditor("FPeriod") Is Nothing AndAlso e.DataWindow.BaseItemValue("FPeriod") <> "000000" Then
            MsgBox("当前数据已经月结，不能审核！", MsgBoxStyle.Exclamation, "提示")
            e.Cancel = True
            Exit Sub
        End If
        Select Case e.TemplateID
            Case "PayDetails"
                If e.DataWindow.Grid.Rows.Count > 20 Then
                    If MsgBox("亲，行数较多，可能会很慢！" & Chr(13) & Chr(10) & "友情建议去倒杯茶，抽袋烟再来……", MsgBoxStyle.OkCancel, "提示") = vbCancel Then
                        e.Cancel = True
                        Exit Select
                    End If
                End If

                With e.DataWindow.Grid
                    For r As Integer = 0 To .Rows.Count - 1
                        If .Item(r, "FAllowApplyNumber") = 0 And .Item(r, "FKeyRow") <> "" Then

                            Dim n As Decimal = Cnn.GetSingleValue("SELECT FApplyNumber   FROM  vAllowApplyNumber WHERE KeyRow='" & .Item(r, "FKeyRow") & "'" & _
                                                                  "AND FClientCode='" & e.DataWindow.BaseItemValue("FClientCode") & "'")

                            If .Item(r, "FApplyNumber") > n Then
                                MsgBox("已超过允许本次申请数量的最大值。位于第" & r + 1 & "行" & Chr(13) & Chr(10) & "提交失败！", MsgBoxStyle.Exclamation, "警告")
                                e.Cancel = True
                                Exit Select
                            End If
                        End If
                    Next

                End With
        End Select
    End Sub


    Private Sub BillEvent_BeforeUnCheck1(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.BeforeUnCheckEventArgs) Handles BillEvent.BeforeUnCheck1
        If Not e.DataWindow.BaseItemEditor("FPeriod") Is Nothing AndAlso e.DataWindow.BaseItemValue("FPeriod") <> "000000" Then
            MsgBox("当前数据已经月结，不能反审核！", MsgBoxStyle.Exclamation, "提示")
            e.Cancel = True
            Exit Sub
        End If
        Select Case e.TemplateID
            Case "Service"
                Cnn.Execute("update bill_service_Base set FOpinion='' where FBillID=" & e.BillID)
            Case "Quotation", "CheckBill"
                e.ManualCheckRelationData = True '手动检测关联性（默认：自动检测约束是在弃审和删除时）
        End Select
    End Sub

    Private Sub BillEvent_BeginAddNew(sender As Object, e As Easy.Win.EasyBill.EventHandler.BeginAddNewEventArgs) Handles BillEvent.BeginAddNew
        Select Case e.TemplateID
            Case "ContractAR"
                Dim dtHt As DataTable = Cnn.GetDataTable("SELECT FCode AS FClientCode ,FName as FProjectName,FArea,FMoney AS FContractMoney,FDATE AS FContractDate FROM base_contract")
                EasyBill.FillGrid(e.DataWindow.Grid, dtHt, , , , , False)
                dtHt.Dispose()
                dtHt = Nothing
                Dim dtKp As DataTable = Cnn.GetDataTable("SELECT * FROM [CC_AR_工程开票] WHERE FClientCode IN (SELECT FCode FROM Base_Contract)")
                e.DataWindow.Grid.Cols.Item("FClientCode").Unique = True
                EasyBill.FillGrid(e.DataWindow.Grid, dtKp, , , True, True)
                dtKp.Dispose()
                dtKp = Nothing
                Dim dtShift As DataTable = Cnn.GetDataTable("SELECT * FROM [CC_AR_订单结转工程] WHERE FClientCode IN (SELECT FCode FROM Base_Contract)")
                e.DataWindow.Grid.Cols.Item("FClientCode").Unique = True
                EasyBill.FillGrid(e.DataWindow.Grid, dtShift, , , True, True)
                dtShift.Dispose()
                dtShift = Nothing
                Dim dtPre As DataTable = Cnn.GetDataTable("SELECT * FROM [CC_AR_预销售开票] WHERE FClientCode IN (SELECT FCode FROM Base_Contract)")
                e.DataWindow.Grid.Cols.Item("FClientCode").Unique = True
                EasyBill.FillGrid(e.DataWindow.Grid, dtPre, , , True, True)
                dtPre.Dispose()
                dtPre = Nothing
                Dim dtSk As DataTable = Cnn.GetDataTable("SELECT * FROM [CC_AR_收款金额] WHERE FClientCode IN (SELECT FCode FROM Base_Contract)")
                e.DataWindow.Grid.Cols.Item("FClientCode").Unique = True
                EasyBill.FillGrid(e.DataWindow.Grid, dtSk, , , True, True)
                dtSk.Dispose()
                dtSk = Nothing
                Dim dtPeriod As DataTable = Cnn.GetDataTable("SELECT * FROM [CC_AR_辅助账] WHERE FClientCode IN (SELECT FCode FROM Base_Contract)" & _
                                                                                         "AND iyear=" & Year(e.DataWindow.BaseItemValue("FDate")) & _
                                                                                         "AND iperiod=" & Month(e.DataWindow.BaseItemValue("FDate")))
                e.DataWindow.Grid.Cols.Item("FClientCode").Unique = True
                EasyBill.FillGrid(e.DataWindow.Grid, dtPeriod, , , True, True)
                dtPeriod.Dispose()
                dtPeriod = Nothing
        End Select
    End Sub


    Private Sub BillEvent_CommandClick(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.CommandClickEventArgs) Handles BillEvent.CommandClick
        Select Case e.CommandName
            Case "cmdCheck1", "cmdCheck2", "cmdUnCheck1", "cmdUnCheck2"
                EasyBill.CommandPrompt(sender) = False
            Case "EXCELSHOW"
                Dim dt As DataTable = New DataTable
                dt = EasyBill.SelCustomData("WorkSiteFormat")
                If Not dt Is Nothing Then
                    dt.Dispose()
                    dt = Nothing
                End If
                Exit Sub
        End Select

        Select Case e.TemplateID
            Case "MountingPayCollect"
                Select Case e.CommandName
                    Case "SelDetail"
                        If e.DataWindow.BaseItemValue("FSettleCorp") = Nothing Then
                            MsgBox("请首先选择结算单位", MsgBoxStyle.Information, "提示")
                            e.UnDoDefault = True
                            Exit Select
                        End If
                End Select
            Case "Calculate"
                Select Case e.CommandName
                    Case "Start"
                        Dim qty As Integer = 0
                        Dim wholeLength As Integer = e.DataWindow.BaseItemValue("FWholeLength")
                        Dim dt As DataTable = New DataTable()
                        dt.Columns.Add("FUserFrameWidth", System.Type.GetType("System.Int32"))
                        dt.Columns.Add("FUserTopLineQty", System.Type.GetType("System.Int32"))
                        With e.DataWindow.Grid("Bill_Calculate_Detail")
                            For r As Integer = 0 To .Rows.Count - 1
                                dt.Rows.Add(.Item(r, "FUserFrameWidth"), .Item(r, "FUserTopLineQty"))
                            Next
                        End With
                        dt.DefaultView.Sort = "FUserFrameWidth DESC"
                        dt = dt.DefaultView.ToTable
                        e.DataWindow.Grid("Bill_Calculate_Detail").Rows.Clear()
                        EasyBill.FillGrid(e.DataWindow.Grid("Bill_Calculate_Detail"), dt)
                        Dim dtNotWhole As DataTable = New DataTable
                        dtNotWhole.Columns.Add("length", System.Type.GetType("System.Int32"))
                        dtNotWhole.Columns.Add("lengthQty", System.Type.GetType("System.Int32"))
                        dtNotWhole.Rows.Add(0, 0)
                        With e.DataWindow.Grid("Bill_Calculate_Detail")
                            For r As Integer = 0 To .Rows.Count - 1
                                Dim userQty As Integer = .Item(r, "FUserTopLineQty")
                                If userQty = 0 Then
                                    Continue For
                                End If
                                For dnr As Integer = 0 To dtNotWhole.Rows.Count - 1
                                    If userQty = 0 Then
                                        Exit For
                                    End If
                                    If .Item(r, "FUserFrameWidth") <= dtNotWhole.Rows(dnr)("length") Then
                                        Dim m As Integer = Math.Floor(dtNotWhole.Rows(dnr)("length") / .Item(r, "FUserFrameWidth"))
                                        Dim mm As Integer = IIf(m < 1, 1, m)
                                        Select Case userQty
                                            Case Is <= dtNotWhole.Rows(dnr)("lengthQty") * mm
                                                If mm = 1 Then
                                                    'For Update Original RowValue
                                                    dtNotWhole.Rows(dnr)("lengthQty") = dtNotWhole.Rows(dnr)("lengthQty") - userQty
                                                    'Check NewRow IsExist to Add or Update  row to dtNotWhole and sort
                                                    Dim newLength1 As Integer = dtNotWhole.Rows(dnr)("length") - .Item(r, "FUserFrameWidth")
                                                    Dim newLengthQty1 As Integer = userQty
                                                    Dim containFlag As Boolean = dtNotWhole.Select("length=" & newLength1).Length() > 0
                                                    If containFlag Then
                                                        Dim dr As DataRow = dtNotWhole.Select("length=" & newLength1)(0)
                                                        Dim targetRow As Integer = dtNotWhole.Rows.IndexOf(dr)
                                                        dtNotWhole.Rows(targetRow).Item("lengthQty") += userQty
                                                    Else
                                                        dtNotWhole.Rows.Add(newLength1, newLengthQty1)
                                                    End If
                                                    dtNotWhole.DefaultView.Sort = "length DESC"
                                                    dtNotWhole = dtNotWhole.DefaultView.ToTable
                                                    userQty = 0
                                                    Exit For
                                                Else '>1
                                                    dtNotWhole.Rows(dnr)("lengthQty") = dtNotWhole.Rows(dnr)("lengthQty") - Math.Ceiling(userQty / mm)
                                                    Dim newLength1 As Integer = dtNotWhole.Rows(dnr)("length") - .Item(r, "FUserFrameWidth") * mm
                                                    Dim newLengthQty1 As Integer = Math.Floor(userQty / mm)
                                                    Dim containFlag As Boolean = dtNotWhole.Select("length=" & newLength1).Length() > 0
                                                    If containFlag Then
                                                        Dim dr As DataRow = dtNotWhole.Select("length=" & newLength1)(0)
                                                        Dim targetRow As Integer = dtNotWhole.Rows.IndexOf(dr)
                                                        dtNotWhole.Rows(targetRow).Item("lengthQty") += newLengthQty1
                                                    Else
                                                        dtNotWhole.Rows.Add(newLength1, newLengthQty1)
                                                    End If
                                                    dtNotWhole.DefaultView.Sort = "length DESC"
                                                    dtNotWhole = dtNotWhole.DefaultView.ToTable
                                                    userQty = 0
                                                    Exit For
                                                End If
                                            Case Is > dtNotWhole.Rows(dnr)("lengthQty") * mm
                                                If mm = 1 Then
                                                    Dim newLength1 As Integer = dtNotWhole.Rows(dnr)("length") - .Item(r, "FUserFrameWidth")
                                                    Dim newLengthQty1 As Integer = dtNotWhole.Rows(dnr)("lengthQty")
                                                    Dim containFlag As Boolean = dtNotWhole.Select("length=" & newLength1).Length() > 0
                                                    If containFlag Then
                                                        Dim dr As DataRow = dtNotWhole.Select("length=" & newLength1)(0)
                                                        Dim targetRow As Integer = dtNotWhole.Rows.IndexOf(dr)
                                                        dtNotWhole.Rows(targetRow).Item("lengthQty") += newLengthQty1
                                                    Else
                                                        dtNotWhole.Rows.Add(newLength1, newLengthQty1)
                                                    End If
                                                    userQty = userQty - dtNotWhole.Rows(dnr)("lengthQty")

                                                    Dim drx As DataRow = dtNotWhole.Select("length=" & dtNotWhole.Rows(dnr)("length"))(0)
                                                    Dim targetRowx As Integer = dtNotWhole.Rows.IndexOf(drx)
                                                    dtNotWhole.Rows.RemoveAt(targetRowx)
                                                    dtNotWhole.DefaultView.Sort = "length DESC"
                                                    dtNotWhole = dtNotWhole.DefaultView.ToTable
                                                    dnr = -1
                                                    Continue For
                                                Else
                                                    Dim newLength1 As Integer = dtNotWhole.Rows(dnr)("length") - .Item(r, "FUserFrameWidth") * mm
                                                    Dim newLengthQty1 As Integer = dtNotWhole.Rows(dnr)("lengthQty")
                                                    Dim containFlag As Boolean = dtNotWhole.Select("length=" & newLength1).Length() > 0
                                                    If containFlag Then
                                                        Dim dr As DataRow = dtNotWhole.Select("length=" & newLength1)(0)
                                                        Dim targetRow As Integer = dtNotWhole.Rows.IndexOf(dr)
                                                        dtNotWhole.Rows(targetRow).Item("lengthQty") += newLengthQty1
                                                    Else
                                                        dtNotWhole.Rows.Add(newLength1, newLengthQty1) '应该是不改变已有行的索引
                                                    End If
                                                    userQty = userQty - dtNotWhole.Rows(dnr)("lengthQty") * mm

                                                    Dim drx As DataRow = dtNotWhole.Select("length=" & dtNotWhole.Rows(dnr)("length"))(0) '(接上)所以这里应该还是当前行
                                                    Dim targetRowx As Integer = dtNotWhole.Rows.IndexOf(drx)
                                                    dtNotWhole.Rows.RemoveAt(targetRowx)
                                                    dtNotWhole.DefaultView.Sort = "length DESC"
                                                    dtNotWhole = dtNotWhole.DefaultView.ToTable
                                                    dnr = -1
                                                    Continue For
                                                End If
                                        End Select
                                    Else '//直取整
                                        Dim m As Integer = Math.Floor(wholeLength / .Item(r, "FUserFrameWidth"))
                                        Dim mm As Integer = IIf(m < 1, 1, m)
                                        If mm = 1 Then
                                            Dim newLength1 As Integer = wholeLength - .Item(r, "FUserFrameWidth")
                                            Dim newLengthQty1 As Integer = userQty
                                            Dim containFlag As Boolean = dtNotWhole.Select("length=" & newLength1).Length() > 0
                                            If containFlag Then
                                                Dim dr As DataRow = dtNotWhole.Select("length=" & newLength1)(0)
                                                Dim targetRow As Integer = dtNotWhole.Rows.IndexOf(dr)
                                                dtNotWhole.Rows.Item(targetRow).Item("lengthQty") += newLengthQty1
                                            Else
                                                dtNotWhole.Rows.Add(newLength1, newLengthQty1)
                                                dtNotWhole.DefaultView.Sort = "length DESC"
                                                dtNotWhole = dtNotWhole.DefaultView.ToTable
                                            End If
                                            qty = qty + userQty
                                        Else '>1
                                            Dim newLength1 As Integer = Math.Floor(wholeLength * (1 - (userQty / mm - Math.Truncate(userQty / mm))))
                                            'Dim newLength1 As Integer = wholeLength - .Item(r, "FUserFrameWidth") * mm
                                            Dim newLengthQty1 As Integer = 1
                                            Dim containFlag As Boolean = dtNotWhole.Select("length=" & newLength1).Length() > 0
                                            If containFlag Then
                                                Dim dr As DataRow = dtNotWhole.Select("length=" & newLength1)(0)
                                                Dim targetRow As Integer = dtNotWhole.Rows.IndexOf(dr)
                                                dtNotWhole.Rows.Item(targetRow).Item("lengthQty") += newLengthQty1
                                            Else
                                                dtNotWhole.Rows.Add(newLength1, newLengthQty1)
                                                dtNotWhole.DefaultView.Sort = "length DESC"
                                                dtNotWhole = dtNotWhole.DefaultView.ToTable
                                            End If
                                            qty = qty + Math.Ceiling(userQty / mm)
                                        End If
                                        Exit For
                                    End If
                                Next
                            Next
                        End With
                        dt.Dispose()
                        dt = Nothing
                        dtNotWhole.Dispose()
                        dtNotWhole = Nothing
                        MsgBox(qty)
                End Select


            Case "MountingToU8"
                Select Case e.CommandName
                    Case "InsertU8"
                        Dim val As Object = e.DataWindow.BaseItemValue("FSOCode")
                        Dim strPara(0) As SqlParameter
                        strPara(0) = New SqlParameter("@cSoCode", val)
                        If Cnn.GetSingleValue("SELECT count(*) FROM cvSOAll where cSOCode='" & val & "'") > 0 Then
                            MsgBox("订单号重复，请重新填写", MsgBoxStyle.Exclamation, "警告")
                            Exit Sub
                        End If
                        Cnn.ExecuteProcedure("CCMountingInsertU8", strPara)
                        MsgBox("应该是导过去了……去看看吧。" & Chr(13) & Chr(10) & _
                               "注意：导过去的订单，请不要在U8里对安装费编码进行增、删、改。", MsgBoxStyle.Information, "结果预计")
                        e.DataWindow.RefreshData()
                End Select

            Case "MountingCostRecord"
                Select Case e.CommandName
                    Case "ImportData"
                        EasyBill.ImportData(e.TemplateID, "Bill_MountingCostRecord_Detail")
                End Select
            Case "Settle"
                Select Case e.CommandName
                    Case "SltFirstRegister"
                        If e.DataWindow.BaseItemValue("FProviderID") = 0 Then
                            If MsgBox("请先选择供应商", MsgBoxStyle.Exclamation, "提示") = MsgBoxResult.Ok Then
                                Exit Select
                            End If
                        Else
                            Dim dt As DataTable
                            dt = EasyBill.SelCustomData("NotSettleFirstRegister", "a.FProviderID=" & e.DataWindow.BaseItemValue("FProviderID"), , , , True)
                            If Not dt Is Nothing Then
                                EasyBill.FillGrid(e.DataWindow, e.DataWindow.Grid, dt)
                                dt.Dispose()
                                dt = Nothing
                            End If
                        End If
                    Case "SltGrindInput"
                        If e.DataWindow.BaseItemValue("FProviderID") = 0 Then
                            If MsgBox("请先选择供应商", MsgBoxStyle.Exclamation, "提示") = MsgBoxResult.Ok Then
                                Exit Select
                            End If
                        Else
                            Dim dt As DataTable
                            dt = EasyBill.SelCustomData("NotSettleGrindInput", "a.FProviderID=" & e.DataWindow.BaseItemValue("FProviderID"), , , , True)


                            If Not dt Is Nothing Then
                                EasyBill.FillGrid(e.DataWindow, e.DataWindow.Grid, dt)

                                dt.Dispose()
                                dt = Nothing
                            End If
                        End If
                End Select
        End Select


    End Sub

    Private Sub BillEvent_ConfirmEditableForState(sender As Object, e As Easy.Win.EasyBill.EventHandler.ConfirmEditableForStateEventArgs) Handles BillEvent.ConfirmEditableForState

    End Sub

    Private Sub BillEvent_GridItemBeforeEdit(sender As Object, e As Easy.Win.EasyBill.EventHandler.GridItemBeforeEditEventArgs) Handles BillEvent.GridItemBeforeEdit
        'Select Case e.TemplateID
        '    Case "MountingToU8"
        '        Select Case e.Col
        '            Case e.DataWindow.Grid.Cols.IndexOf("FForSOCode")
        '                If e.DataWindow.Grid.Item(e.Row, "FForSOCode") = Nothing Then
        '                    'If e.KeyCode = Keys.F2 Then
        '                    'e.Handled = True
        '                    'End If
        '                    Dim dt As DataTable = EasyBill.SelCustomData("ProductInSO", "cCusCode='" & e.DataWindow.BaseItemValue("FCientCode") & "'", , , , True)
        '                    If Not dt Is Nothing Then
        '                        Dim dr As DataRow = dt.Rows(0)
        '                        Dim s As String = dr("cSOCode")
        '                        Dim d As Double = 0
        '                        For Each dr In dt.Rows
        '                            If s.IndexOf(Right(dr("cSOCode").ToString, 3)) = -1 Then
        '                                s = s & "/" & Right(dr("cSOCode").ToString, 3)
        '                            End If
        '                            d = d + CDbl(dr("iQuantity"))
        '                        Next
        '                        dt.Dispose()
        '                        dt = Nothing
        '                        With e.DataWindow.Grid
        '                            .Item(e.Row, "FNumber") = d
        '                            .Item(e.Row, "FForSOCode") = s
        '                        End With
        '                    End If
        '                End If
        '        End Select
        'End Select
    End Sub

    Private Sub BillEvent_GridItemChanged(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.GridItemChangedEventArgs) Handles BillEvent.GridItemChanged
        Dim c As Integer = e.Grid.Cols.IndexOf("FDescription", False)
        If e.Col = c Then
            e.Grid.FlexGrid.AutoSizeRow(e.Grid.FlexGrid.Rows.Fixed + e.Row)
        End If

        Select Case e.TemplateID
            Case "ContractAR"

            Case "GrindInput"
                Select Case e.Name
                    Case "Bill_GrindInput_Detail"
                        Select Case e.Col
                            Case e.DataWindow.Grid.Cols.IndexOf("FCutterProductID")
                                If e.DataWindow.Grid.Item(e.Row, "FProcessWay") = "研磨" Then
                                    e.DataWindow.Grid.Item(e.Row, "FiMoney") = Cnn.GetSingleValue("select FGrindPrice from Base_CutterProduct where FID=" & e.DataWindow.Grid.Item(e.Row, "FCutterProductID"))
                                ElseIf e.DataWindow.Grid.Item(e.Row, "FProcessWay") = "换齿" Then
                                    e.DataWindow.Grid.Item(e.Row, "FiMoney") = Cnn.GetSingleValue("select FChangePrice from Base_CutterProduct where FID=" & e.DataWindow.Grid.Item(e.Row, "FCutterProductID"))
                                End If
                        End Select
                End Select

                '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Case "Contract"
                        Select Case e.Name
                            Case "Bill_Contract_Detail"
                                Select Case e.Col '//计算铰链的配数
                                    Case e.DataWindow.Grid.Cols.IndexOf("FHingeSCode", False), e.DataWindow.Grid.Cols.IndexOf("FHingeZCode", False), e.DataWindow.Grid.Cols.IndexOf("FHingeXCode", False)
                                        With e.DataWindow.Grid
                                            Dim number As Integer = 0
                                            Dim iArr(2) As Integer
                                            iArr = {.Cols.IndexOf("FHingeSCode", False), .Cols.IndexOf("FHingeZCode", False), .Cols.IndexOf("FHingeXCode", False)}
                                            For Each i As Integer In iArr
                                                If .Item(e.Row, i) <> Nothing Then
                                                    number = number + 1
                                                End If
                                            Next
                                            .Item(e.Row, "FHingeNumber") = number
                                        End With
                                End Select
                        End Select
                End Select
    End Sub


    Private Sub BillEvent_Load(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.LoadEventArgs) Handles BillEvent.Load
        For Each grid As Easy.Win.EasyGrid In e.DataWindow.Grids
            grid.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both
        Next
        Select Case e.TemplateID
            Case "MountingCostRecord", "PayDetails", "MountingPayCollect"
                e.DataWindow.FixedAttachFilter = "FMaker IN (SELECT FName FROM t_Employee WHERE dbo.OperateAllow(FViewableUsers," & UserID & ")=1)"

        End Select

    End Sub
    Private Sub BillEvent_OnAboutClick(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.CommandClickEventArgs) Handles BillEvent.OnAboutClick
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
        frmAbout = Nothing
        e.UnDoDefault = True
    End Sub

    Private Sub BillEvent_RecordChanged(ByVal sender As Object, ByVal e As Easy.Win.EasyBill.EventHandler.RecordChangedEventArgs) Handles BillEvent.RecordChanged
        For Each grid As Easy.Win.EasyGrid In e.DataWindow.Grids
            grid.FlexGrid.AutoSizeRows()
        Next
        Select e.TemplateID
            Case "MountingToU8"
                If Cnn.GetSingleValue("SELECT count(*) FROM cvSOAll WHERE cSOCode='" & e.DataWindow.BaseItemValue("FSOCode") & "'") > 0 Then
                    e.DataWindow.BaseItemLabel("IsImport").Visible = True
                End If
        End Select
    End Sub

    Private Sub MenuEvent_AfterLoadMenu(ByVal sender As Object, ByVal e As Easy.Win.MainMenu.EventHandler.AfterLoadMenuEventArgs) Handles MenuEvent.AfterLoadMenu

        If e.TreeView.Nodes.Count > 5 Then
            e.TreeView.Nodes(4).Remove()
            e.TreeView.Nodes(3).Text = "管理单据"
            'e.TreeView.Nodes(5).Text = "批量处理"
            e.TreeView.Nodes(4).Text = "报表查询"
        End If
    End Sub

    Private Sub ReportEvent_AfterLoad(ByVal sender As Object, ByVal e As Easy.Win.EasyReport.EventHandler.LoadEventArgs) Handles ReportEvent.AfterLoad
        Select Case e.ReportID
            Case "NeedContact", "ContactListForBoss"
                EasyReport.RefreshData(sender)
        End Select
    End Sub
    Private Sub ReportEvent_OnAboutClick(ByVal sender As Object, ByVal e As Easy.Win.EasyReport.EventHandler.CommandClickEventArgs) Handles ReportEvent.OnAboutClick
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
        frmAbout = Nothing
        e.UnDoDefault = True
    End Sub


    Private Sub UserEvent_OnAboutClick(ByVal sender As Object, ByVal e As Easy.Win.EasyUser.EventHandler.CommandClickEventArgs) Handles UserEvent.OnAboutClick
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
        frmAbout = Nothing
        e.UnDoDefault = True
    End Sub



End Module
