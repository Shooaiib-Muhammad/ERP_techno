Public Class frmRptMRP
    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Dim ClienStatus As String
        Dim Filter As String = Nothing
        Dim Path As String
        Dim objRptViewer As New Class_Utility
        If Adidas.Checked = True Then
            ClienStatus = "{tbl_Pro_Client.ClientID} = 1"
            Path = "\\server\MyReports$\ERPPPS\Material\MatReq.rpt"
        ElseIf Nonadidas.Checked = True Then
            ClienStatus = "{tbl_Pro_Client.ClientID} > 1"
            Path = "\\server\MyReports$\ERPPPS\Material\MatReqNonAdidas.rpt"
        End If


        If Me.RadioButton1.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            End If

        ElseIf RadioButton2.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And{View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
            End If

        ElseIf RadioButton19.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "'"
            Else
                Filter = ClienStatus & " And{View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' "
            End If

        ElseIf RadioButton22.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' And {View_Rpt_Mat_Requisition.OStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' And {View_Rpt_Mat_Requisition.OStatus} "
            End If

        ElseIf RadioButton23.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            Else
                Filter = ClienStatus & " And{View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false) "
            End If



        ElseIf RadioButton13.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "'And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "'"
            End If

        ElseIf RadioButton14.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' and {View_Rpt_Mat_Requisition.ArtSize} = '" & Me.ArtSizeComboBox.Text & "' And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' and {View_Rpt_Mat_Requisition.ArtSize} = '" & Me.ArtSizeComboBox.Text & "' "
            End If



        ElseIf RadioButton16.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' And {View_Rpt_Mat_Requisition.OStatus} And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' And {View_Rpt_Mat_Requisition.OStatus} "
            End If


        ElseIf RadioButton15.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' And {View_Rpt_Mat_Requisition.ArtSize} = '" & Me.ArtSizeComboBox.Text & "' And {View_Rpt_Mat_Requisition.OStatus} And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' And {View_Rpt_Mat_Requisition.ArtSize} = '" & Me.ArtSizeComboBox.Text & "' And {View_Rpt_Mat_Requisition.OStatus} "
            End If


        ElseIf RadioButton18.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "'And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "'And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            End If

        ElseIf RadioButton17.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' and {View_Rpt_Mat_Requisition.ArtSize} = '" & Me.ArtSizeComboBox.Text & "'And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Mat_Requisition.ArtCode} = '" & Me.ArtCodeComboBox.Text & "' and {View_Rpt_Mat_Requisition.ArtSize} = '" & Me.ArtSizeComboBox.Text & "'And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            End If


        ElseIf RadioButton3.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine}= " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.OStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine}= " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.OStatus}"
            End If

        ElseIf RadioButton11.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine}= " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.OStatus} And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine}= " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.OStatus} And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
            End If

        ElseIf RadioButton4.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.OStatus} And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.OStatus} "
            End If

        ElseIf RadioButton5.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.MPID} in " & Me.MPIDComboBox.SelectedValue & " to " & Me.MPIDComboBox1.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.OStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.MPID} in " & Me.MPIDComboBox.SelectedValue & " to " & Me.MPIDComboBox1.SelectedValue & " And {View_Rpt_Mat_Requisition.OStatus}"
            End If

        ElseIf RadioButton6.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & "  And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            End If

        ElseIf RadioButton12.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false) "
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false) "
            End If

        ElseIf RadioButton7.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#  And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"

            End If

        ElseIf RadioButton8.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.MPID} in " & Me.MPIDComboBox.SelectedValue & " to " & Me.MPIDComboBox1.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.MPID} in " & Me.MPIDComboBox.SelectedValue & " to " & Me.MPIDComboBox1.SelectedValue & " And (isnull({View_Rpt_Mat_Requisition.OStatus}) oR {View_Rpt_Mat_Requisition.OStatus} =false)"
            End If

        ElseIf RadioButton9.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.MPID} in " & Me.MPIDComboBox.SelectedValue & " to " & Me.MPIDComboBox1.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus}"
            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.MPID} in " & Me.MPIDComboBox.SelectedValue & " to " & Me.MPIDComboBox1.SelectedValue & " "
            End If

        ElseIf RadioButton20.Checked = True Then
            Path = "\\server\MyReports$\ERPPPS\Material\RptReqCancel.rpt"
            Filter = ClienStatus & " And {View_Requisition_PendingDays.CancelDays} > 0"
        ElseIf RadioButton21.Checked = True Then
            Path = "\\server\MyReports$\ERPPPS\Material\MatReqBalanceNew.rpt"
            Filter = ClienStatus & " And {View_Pending_Req_Balance.RemainDays} > 0"

        ElseIf RadioButton10.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
                'Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RepStatus} And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And  {View_Pending_Req_Balance.NewPrdLine} <> 8"

            Else
                Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "'"
                'Filter = ClienStatus & " And {View_Rpt_Mat_Requisition.PrdLine} = " & Me.PrdLineNameComboBox.SelectedValue & " And {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.Code} = '" & Me.L4NameComboBox.SelectedValue & "' And {View_Pending_Req_Balance.NewPrdLine} <> 8"

            End If
        ElseIf RadioButton24.Checked = True Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Filter = ClienStatus & " And  {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Mat_Requisition.RepStatus} and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' And {View_Rpt_Mat_Requisition.OStatus}"
            Else
                Filter = ClienStatus & " And  {View_Rpt_Mat_Requisition.RequiredDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# to #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# and {View_Rpt_Mat_Requisition.FactoryCode} = '" & Me.ComboBox1.Text & "' And {View_Rpt_Mat_Requisition.OStatus} "
            End If
        End If
        Dim Param As String = "UserName=" & frmLoginVer.LoginName & "&IPAddress=" & frmLoginVer.SysIP & "&SysName=" & ComputerName & ""
        'Param = "Vehicle=" & Me.VehicleTextBox1.Text & "&Driver=" & Me.DriverNameTextBox2.Text & ""
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
    Private Sub frmRptReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSArticle.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
        Me.Tbl_Pro_Article_DTableAdapter.Fill(Me.DSArticle.tbl_Pro_Article_D)
        'TODO: This line of code loads data into the 'DSArticle.tbl_Pro_Article' table. You can move, or remove it, as needed.
        Me.Tbl_Pro_ArticleTableAdapter.Fill(Me.DSArticle.tbl_Pro_Article)
        'TODO: This line of code loads data into the 'DSRpt.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSRpt.tbl_Inv_L4)
        Me.Tbl_Prd_LinesTableAdapter.Fill(Me.DSRpt.tbl_Prd_Lines)
        Me.Tbl_Pro_Plan2TableAdapter.Fill(Me.DSRpt.tbl_Pro_Plan2)
        Me.Tbl_Pro_Plan1TableAdapter.Fill(Me.DSRpt.tbl_Pro_Plan1)
        Me.Tbl_Prd_LinesTableAdapter.Fill(Me.DSRpt.tbl_Prd_Lines)
        Me.L4NameComboBox.Enabled = False
    End Sub
    Sub EnableContents(ByVal dt As Boolean, ByVal Prdline As Boolean, ByVal MP As Boolean)
        Me.DateTimePicker2.Enabled = dt
        Me.DateTimePicker1.Enabled = dt
        Me.PrdLineNameComboBox.Enabled = Prdline
        Me.MPIDComboBox.Enabled = MP
        Me.MPIDComboBox1.Enabled = MP
        Me.ArtCodeComboBox.Enabled = False
        Me.ArtSizeComboBox.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.GroupBox2.Enabled = True
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged, RadioButton19.CheckedChanged, RadioButton22.CheckedChanged, RadioButton23.CheckedChanged
        EnableContents(True, False, False)
        If RadioButton19.Checked Or RadioButton22.Checked Or RadioButton23.Checked Then
            Me.ComboBox1.Enabled = True
        End If
        If RadioButton22.Checked Then
            Me.PrdLineNameComboBox.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        EnableContents(True, True, False)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        EnableContents(True, True, False)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        EnableContents(True, False, False)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        EnableContents(False, False, True)
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        EnableContents(True, True, False)
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        EnableContents(True, False, False)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        EnableContents(False, False, True)
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        EnableContents(False, False, True)
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged, RadioButton11.CheckedChanged, RadioButton12.CheckedChanged
        EnableContents(True, True, False)
        Me.L4NameComboBox.Enabled = True
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged, RadioButton16.CheckedChanged, RadioButton18.CheckedChanged
        EnableContents(True, False, False)
        Me.ArtCodeComboBox.Enabled = True

    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged, RadioButton15.CheckedChanged, RadioButton17.CheckedChanged
        EnableContents(True, False, False)
        Me.ArtCodeComboBox.Enabled = True
        Me.ArtSizeComboBox.Enabled = True
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged, RadioButton21.CheckedChanged
        Me.GroupBox2.Enabled = False
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            ComboBox1.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            ComboBox1.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If
    End Sub
End Class