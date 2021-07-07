Public Class frmRptFilterTran
    Private Sub btnNewRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRpt.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim objRptViewer As New Class_Utility
        Dim Param As String = ""
        If RadioButton9.Checked Then
            Path = "\\server\MyReports$\FSERPPC\Security\InwardEntries.rpt"
            Filter = "{tbl_Sec_Vehicle_Head.VehicleDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {tbl_Sec_Middle.INOUT} = 'Normal'"
        End If
        Dim L4 As String
        If Me.ComboBox2.Text = "General" Or Me.ComboBox1.Text = "General" Then
            L4 = "{tbl_Inv_L4.Layer1ID} > '1'"
        Else
            L4 = "{tbl_Inv_L4.Layer1ID} = '1'"
        End If
        If Me.RBInward.Checked = True Then

            'Path = "\\server\myreports$\FSERPMM\Inventory\New\RptInvIn11.rpt"
            Path = "" & frmLoginVer.Reportpath & "\New\RptInvIn.rpt"
            If RadioButton14.Checked = True Then
                If Me.ComboBox1.Text = "ALL" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MRI" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MRI' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MTP" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MTP' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MAE" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MAE' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MRET" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MRET' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MREP" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MREP' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MBRN" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MBRN' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "MLRN" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'MLRN' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "RBR" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'RBR' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "BGrade" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'BGrade' and " & L4 & ""
                ElseIf Me.ComboBox1.Text = "General" Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = 'General' and " & L4 & ""

                Else
                    Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_In.TranType} = '" & Me.ComboBox1.Text & "' and " & L4 & ""
                End If
            ElseIf RadioButton24.Checked = True Then
                Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND  {tbl_Inv_L4.L4Name} = '" & Me.L4NameComboBox.Text & "' and " & L4 & " "
            ElseIf RadioButton26.Checked = True Then

                Path = "" & frmLoginVer.Reportpath & "\New\RptInvInL3.rpt"
                Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And  {tbl_Inv_L3.L3Name} = '" & ComboBox8.Text & "'"


            End If
        ElseIf Me.RadioButton8.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\New\RptInvLedgerMonthly.rpt"
            Filter = "{View_Inv_Tran_Main.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
        ElseIf Me.RadioButton13.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\New\RptPrintIn.rpt"
            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
        ElseIf Me.RadioButton17.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutGeneralAudit.rpt"
            If ComboBox2.Text = "ALL" Then
                If RadioButton14.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & ""

                ElseIf RadioButton15.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "'"
                ElseIf RadioButton21.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox5.Text & "'"
                End If
            ElseIf ComboBox2.Text = "Manual Issuance" Then
                If RadioButton14.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & "And isnull({tbl_Inv_Tran_Out.ReqID})"

                ElseIf RadioButton15.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "' And isnull({tbl_Inv_Tran_Out.ReqID})"
                ElseIf RadioButton21.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox5.Text & "' And isnull({tbl_Inv_Tran_Out.ReqID})"
                End If
            ElseIf ComboBox2.Text = "Planning Issuance" Then
                If RadioButton14.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {tbl_Inv_Tran_Out.ReqID} > 0"

                ElseIf RadioButton15.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "' And {tbl_Inv_Tran_Out.ReqID} > 0"
                ElseIf RadioButton21.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox5.Text & "' And {tbl_Inv_Tran_Out.ReqID} > 0"

                End If
            Else
                If RadioButton14.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' And " & L4 & ""

                ElseIf RadioButton15.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "'"
                ElseIf RadioButton21.Checked = True Then
                    Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox5.Text & "' And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "'"

                End If

            End If



        ElseIf Me.RBOutward.Checked = True Then

            If RadioButton14.Checked = True Then

                If Me.ComboBox2.Text = "General" Then

                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutGeneral.rpt"
                    If RadioButton14.Checked = True Then

                        Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' and " & L4 & ""

                    ElseIf RadioButton15.Checked = True Then
                        Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' and " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "'"

                    End If

                Else
                    'RptInvOutGeneral.rpt
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOut.rpt"
                    If ComboBox2.Text = "ALL" Then
                        If RadioButton14.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & ""

                        ElseIf RadioButton15.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "'"

                        End If
                    ElseIf ComboBox2.Text = "Manual Issuance" Then
                        If RadioButton14.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & "And isnull({tbl_Inv_Tran_Out.ReqID})"

                        ElseIf RadioButton15.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "' And isnull({tbl_Inv_Tran_Out.ReqID})"

                        End If
                    ElseIf ComboBox2.Text = "Planning Issuance" Then
                        If RadioButton14.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {tbl_Inv_Tran_Out.ReqID} > 0"

                        ElseIf RadioButton15.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #  And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "' And {tbl_Inv_Tran_Out.ReqID} > 0"

                        End If
                    Else
                        If RadioButton14.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' And " & L4 & ""

                        ElseIf RadioButton15.Checked = True Then
                            Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' And " & L4 & " And {@Company} = '" & Me.ComboBox3.Text & "'"

                        End If

                    End If
                End If
            ElseIf RadioButton24.Checked = True Then
                If Me.ComboBox2.Text = "General" Then
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutGeneral.rpt"
                Else
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOut.rpt"

                End If
                Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_L4.L4Name} ='" & Me.L4NameComboBox.Text & "' and " & L4 & " "
            ElseIf RadioButton25.Checked = True Then
                If Me.ComboBox2.Text = "General" Then
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutGeneral.rpt"
                Else
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOut.rpt"

                End If
                Filter = "{tbl_Inv_Tran_Out.TranType} = '" & Me.ComboBox2.Text & "' And  {tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {tbl_Inv_L4.L4Name} ='" & Me.L4NameComboBox.Text & "' and " & L4 & " "


            ElseIf RadioButton26.Checked = True Then

                Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutL3.rpt"
                Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And  {tbl_Inv_L3.L3Name} = '" & ComboBox8.Text & "'"

            ElseIf RadioButton15.Checked = True Then
                If Me.ComboBox2.Text = "General" Then
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutGeneral.rpt"
                Else
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOut.rpt"

                End If
                Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {@Company} = '" & Me.ComboBox3.Text & " ' "
            ElseIf RadioButton21.Checked = True Then
                If Me.ComboBox2.Text = "General" Then
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutGeneral.rpt"
                Else
                    Path = "" & frmLoginVer.Reportpath & "\New\RptInvOut.rpt"

                End If
                Filter = "{tbl_Inv_Tran_Date.DateName} In # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# To # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # AND {@Company} = '" & Me.ComboBox5.Text & " ' "



            End If
        ElseIf Me.RadioButton1.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Path = "" & frmLoginVer.Reportpath & "\New\RptInvOutSummary.rpt"
        ElseIf Me.RadioButton2.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Path = "" & frmLoginVer.Reportpath & "\New\RptRepairBaladerRec.rpt"
        ElseIf Me.RadioButton3.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Path = "" & frmLoginVer.Reportpath & "\New\RptRepairBaladerProcess.rpt"
        ElseIf Me.RadioButton4.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Path = "" & frmLoginVer.Reportpath & "\New\RptProcessedBladderRec.rpt"
        ElseIf Me.RadioButton7.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Path = "" & frmLoginVer.Reportpath & "\RptInvIssuance.rpt"
        ElseIf Me.RadioButton6.Checked Then
            Filter = "{tbl_Inv_Tran_Date.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Path = "" & frmLoginVer.Reportpath & "\RptInvReceiving.rpt"
        ElseIf Me.RadioButton10.Checked Then
            Filter = "{View_Bladder_Billing_Transaction.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "" & frmLoginVer.Reportpath & "\Billing\RptBillMaker.rpt"
        ElseIf Me.RadioButton11.Checked Then
            Filter = "{View_Bladder_Billing_Transaction.DateName} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "\\server\myreports$\FSERPMM\Billing\RptBillMakerAccount.rpt"
        ElseIf Me.RadioButton12.Checked Then
            If RadioButton14.Checked Then

                Filter = "{View_Rpt_Mat_Requisition_Cancel.ODate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            ElseIf RadioButton15.Checked Then
                Filter = "{View_Rpt_Mat_Requisition_Cancel.ODate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {View_Rpt_Mat_Requisition_Cancel.PrdLineName} =  '" & Me.ComboBox3.Text & "'"
            ElseIf RadioButton16.Checked Then
                Filter = "{View_Rpt_Mat_Requisition_Cancel.ODate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {View_Rpt_Mat_Requisition_Cancel.FactoryCode} =  '" & Me.ComboBox4.Text & "'"

            End If

            '{View_Rpt_Mat_Requisition_Cancel.PrdLineName} = "MLP"
            'Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "" & frmLoginVer.Reportpath & "\Material\MatReqCancel.rpt"
        ElseIf Me.RadioButton19.Checked Then
            If RadioButton14.Checked Then

                Filter = "{View_Rpt_Mat_Requisition_Cancel.AdjQty} > 0.00 And {View_Rpt_Mat_Requisition_Cancel.ODate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            ElseIf RadioButton15.Checked Then
                Filter = "{View_Rpt_Mat_Requisition_Cancel.AdjQty} > 0.00 And {View_Rpt_Mat_Requisition_Cancel.ODate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {View_Rpt_Mat_Requisition_Cancel.PrdLineName} =  '" & Me.ComboBox3.Text & "'"
            ElseIf RadioButton16.Checked Then
                Filter = "{View_Rpt_Mat_Requisition_Cancel.AdjQty} > 0.00 And  {View_Rpt_Mat_Requisition_Cancel.ODate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " # And {View_Rpt_Mat_Requisition_Cancel.FactoryCode} =  '" & Me.ComboBox4.Text & "'"

            End If

            '{View_Rpt_Mat_Requisition_Cancel.PrdLineName} = "MLP"
            'Param = "FromDate = " & Format(Me.DTPicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DTPicker2.Value, "dd/MM/yyyy") & ""
            Path = "" & frmLoginVer.Reportpath & "\MatReqCancelAudit.rpt"
            '
        ElseIf Me.RadioButton18.Checked Then


            Filter = "{View_PUR_Audit.CompDate} in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"

            Path = "" & frmLoginVer.Reportpath & "\Procurement\RptGeneralRec.rpt"
        ElseIf Me.RadioButton20.Checked Then
            If RadioButton14.Checked = True Then
                Filter = "{View_Demand_Issuance.DateName}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            ElseIf RadioButton15.Checked = True Then
                Filter = "{View_Demand_Issuance.DeptName} = '" & Me.ComboBox3.Text & "'  and {View_Demand_Issuance.DateName}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            End If

            Path = "" & frmLoginVer.Reportpath & "\RptDailyDemadIssuance.rpt"
        ElseIf Me.RadioButton22.Checked Then
            If RadioButton14.Checked = True Then
                Filter = "{View_Issuance_By_GDR.DateName}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            ElseIf RadioButton15.Checked = True Then
                Filter = "{View_Issuance_By_GDR.DeptName} = '" & Me.ComboBox3.Text & "'  and {View_Issuance_By_GDR.DateName}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            End If

            Path = "" & frmLoginVer.Reportpath & "\Rpt_Demand_issuance.rpt"
        ElseIf Me.RadioButton23.Checked Then
            If RadioButton14.Checked = True Then
                Filter = "{View_Inv_Trans_Stock.DateName}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            ElseIf RadioButton15.Checked = True Then
                Filter = "{View_Inv_Trans_Stock.CustName} = '" & Me.ComboBox3.Text & "'  and {View_Inv_Trans_Stock.DateName}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            End If

            Path = "" & frmLoginVer.Reportpath & "\Rpt_Stock.rpt"
        ElseIf RadioButton27.Checked = True Then
            Path = "" & frmLoginVer.Reportpath & "\internaldemands.rpt"
            If RadioButton14.Checked = True Then
                Filter = "{VIew_internal_Demands_Status.ExpireStatus} And {VIew_internal_Demands_Status.PDDate}  in # " & Format(Me.DTPicker1.Value, "MM/dd/yyyy") & "# to # " & Format(Me.DTPicker2.Value, "MM/dd/yyyy") & " #"
            End If
        End If
        objRptViewer.LoadReports(Path, Filter, Param)
    End Sub
    Private Sub RBInward_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBInward.CheckedChanged, RadioButton6.CheckedChanged, RadioButton13.CheckedChanged
        Me.Label2.Visible = True
        Me.Label3.Visible = False
        Me.ComboBox1.Visible = True
        Me.ComboBox2.Visible = False

        GroupBox1.Visible = True
        Me.ComboBox1.ResetText()
        Me.ComboBox1.SelectedText = "ALL"

    End Sub




    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton8.CheckedChanged, RadioButton12.CheckedChanged
        Me.Label2.Visible = False
        Me.Label3.Visible = False

        Me.ComboBox1.Visible = False
        Me.ComboBox2.Visible = False
        If RadioButton12.Checked Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub


    Private Sub frmRptFilterTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRptL4Code.tbl_Inv_L3' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L3TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L3)
        'TODO: This line of code loads data into the 'DSRptL4Code.tbl_Inv_L2' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L2TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L2)
        'TODO: This line of code loads data into the 'DSRptL4Code.tbl_Inv_L1' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L1TableAdapter.Fill(Me.DSRptL4Code.tbl_Inv_L1)
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_L4)
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_PIR_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_DeptTableAdapter.Fill(Me.DSNewTranIn.tbl_PIR_Dept)
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_Inv_LocalCust' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_LocalCustTableAdapter.Fill(Me.DSNewTranIn.tbl_Inv_LocalCust)
        'TODO: This line of code loads data into the 'DSNewTranIn.tbl_Makers' table. You can move, or remove it, as needed.


        If frmLoginVer.UserID = 139 Then
            RadioButton10.Visible = False
        Else
            RadioButton10.Visible = False
        End If
        If frmLoginVer.UserID = 69 Or frmLoginVer.UserID = 2 Then
            RadioButton17.Visible = True
            RadioButton18.Visible = True
        Else
            RadioButton17.Visible = False
            RadioButton18.Visible = False
        End If

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Tbl_MakersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_MakersBindingSource.EndEdit()
        Me.Tbl_MakersTableAdapter.Update(Me.DSNewTranIn.tbl_Makers)

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        'Me.MakerComboBox.Visible = True
        'Me.Label4.Visible = True
    End Sub

    Private Sub RBOutward_CheckedChanged(sender As Object, e As EventArgs) Handles RBOutward.CheckedChanged
        Me.Label2.Visible = False
        Me.Label3.Visible = True

        Me.ComboBox1.Visible = False
        Me.ComboBox2.Visible = True
        Me.ComboBox2.ResetText()
        Me.ComboBox2.SelectedText = "ALL"
        If RBOutward.Checked = True Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False


        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            ComboBox3.Enabled = True
        Else
            ComboBox3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False

        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        Me.Label2.Visible = False
        Me.Label3.Visible = True

        Me.ComboBox1.Visible = False
        Me.ComboBox2.Visible = True
        Me.ComboBox2.ResetText()
        Me.ComboBox2.SelectedText = "ALL"
        If RadioButton17.Checked = True Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False


        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        Me.Label2.Visible = False
        Me.Label3.Visible = False

        Me.ComboBox1.Visible = False
        Me.ComboBox2.Visible = False
        If RadioButton19.Checked Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            RadioButton14.Checked = True
            GroupBox1.Visible = True
            RadioButton16.Enabled = False
        Else
            GroupBox1.Visible = False
            RadioButton16.Enabled = True
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked = True Then
            ComboBox5.Enabled = True
        Else
            ComboBox5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked = True Then
            RadioButton14.Checked = True
            GroupBox1.Visible = True
            RadioButton16.Enabled = False
        Else
            GroupBox1.Visible = False
            RadioButton16.Enabled = True
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked = True Then
            RadioButton14.Checked = True
            GroupBox1.Visible = True
            RadioButton16.Enabled = False
            RadioButton21.Enabled = False
        Else
            GroupBox1.Visible = False
            RadioButton16.Enabled = True
            RadioButton21.Enabled = True
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            L4NameComboBox.Enabled = True
        Else
            L4NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked = True Then
            L4NameComboBox.Enabled = True
            ComboBox2.Enabled = True
        Else
            L4NameComboBox.Enabled = False
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked = True Then
            ComboBox6.Enabled = True
            ComboBox7.Enabled = True
            ComboBox8.Enabled = True
        Else
            ComboBox6.Enabled = False
            ComboBox7.Enabled = False
            ComboBox8.Enabled = False
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged

    End Sub
End Class