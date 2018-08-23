Imports System.IO
Imports System.Text

Public Class Mine
    Public Shared Function MyDataTableTxt(dt As DataTable, strSeparater As Char) As Boolean
        Dim svFileDlg As New SaveFileDialog
        Dim fileName As String
        Dim myStream As Stream
        svFileDlg.Filter = "txt(*.txt)|*.txt"
        svFileDlg.Title = "导出txt文件到 "
        svFileDlg.OverwritePrompt = True
        If svFileDlg.ShowDialog = DialogResult.OK Then
            myStream = svFileDlg.OpenFile()
            Dim sw As New StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"))
            Dim str As [String] = ""
            If svFileDlg.FileName.Trim().Length > 0 Then
                fileName = svFileDlg.FileName.Trim()
                ''写标题
                'For i As Integer = 0 To dv.Table.Columns.Count - 1
                '    If i > 0 Then
                '        str += vbTab & " "
                '    End If

                '    str += dv.Table.Columns(i).ColumnName
                'Next
                'sw.WriteLine(str)

                ''写内容
                For rowNo As Integer = 0 To dt.Rows.Count - 1
                    Dim tempStr As [String] = ""
                    For columnNo As Integer = 0 To dt.Columns.Count - 1
                        If columnNo = dt.Columns.Count - 1 Then
                            tempStr += dt.Rows(rowNo)(columnNo).ToString()
                        Else
                            tempStr += dt.Rows(rowNo)(columnNo).ToString() & strSeparater
                        End If
                    Next
                    sw.WriteLine(tempStr)
                Next
                sw.Close()
                myStream.Close()
                MessageBox.Show("导出文件成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("请输入保存文件名称！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Function
    Public Shared Function DataViewToTxt(dv As DataView, strFileName As String, strSplit As Char) As Boolean
        If dv Is Nothing OrElse dv.ToTable.Rows.Count = 0 Then
            Return False
        End If

        Dim fileStream As New FileStream(strFileName, FileMode.OpenOrCreate)
        Dim streamWriter As New StreamWriter(fileStream, System.Text.Encoding.Unicode)

        Dim strBuilder As New StringBuilder()
        Try
            For i As Integer = 0 To dv.ToTable.Rows.Count - 1
                strBuilder = New StringBuilder()
                For j As Integer = 0 To dv.ToTable.Columns.Count - 1
                    strBuilder.Append(dv.ToTable.Rows(i)(j).Value.ToString() + strSplit)
                Next
                strBuilder.Remove(strBuilder.Length - 1, 1)
                streamWriter.WriteLine(strBuilder.ToString())
            Next
        Catch ex As Exception
            Dim strErrorMessage As String = ex.Message
            Return False
        Finally
            streamWriter.Close()
            fileStream.Close()
        End Try
        Return True
    End Function
End Class
