Public Class frmMain
    Inherits System.Windows.Forms.Form
    Public CModID As Integer
    Public CDomID As Integer
    Public CUserID As Integer
    Public CloginStatus As Boolean = False
    Public CExitStatus As Boolean = False
    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If CloginStatus = True And CExitStatus = False Then
            If (Me.Tbl_User_LogTableAdapter.GetUserStatus(CModID, CDomID, CUserID) > 0) Then
                Me.Tbl_User_LogTableAdapter.UserLogOut(Now, CModID, CDomID, CUserID)
            End If
        ElseIf CloginStatus = False And CExitStatus = False Then
            MsgBox("You are exiting with out log In.")
        ElseIf CExitStatus = True Then
            MsgBox("Thank you for Using FS_ERP_MM" & vbCrLf & "Have a Nice Day.")
        End If
    End Sub

    Private Sub frmInvMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ChildWindowOpen("frmLoginVer") = False Then     'For MainMenu
            Dim loginVer As New frmLoginVer
            loginVer.MdiParent = Me
            loginVer.Show()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem1.Click
        If ChildWindowOpen("frmLoginVer") = False Then
            Dim login As New frmLoginVer
            login.MdiParent = Me
            login.Show()
            login.txtPswd.Focus()
        End If
    End Sub
    Sub MaterialCode()
        If ChildWindowOpen("frmCode") = False Then
            Dim Code As New frmCode
            Code.MdiParent = Me
            Code.WindowState = FormWindowState.Maximized
            Code.Show()
        End If
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        logout()
        If ChildWindowOpen("frmLoginVer") = False Then     'For MainMenu
            Dim loginVer As New frmLoginVer
            loginVer.MdiParent = Me
            loginVer.Show()
        End If
    End Sub
    Sub logout()
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Me.MenuStripAccounts.Hide()
        Me.MenuStripMMITAdmin.Hide()
        Me.MenuStripAudit.Hide()
        Me.MenuStripDispatch.Hide()
        Me.MenuStripInventory.Hide()
        Me.MenuStripF7.Hide()
        Me.Export.Hide()
        Me.MenuStripInventoryAdmin.Hide()
        Me.MenuStripMMNonAdidas.Hide()
        Me.MenuStripMatDemand.Hide()
        Me.MenuStripMaterialVerification.Hide()
        Me.MenuStripMatPurchase.Hide()
        Me.MenuStripRawMaterial.Hide()
        Me.MenuStripVerification.Hide()
        Me.ProcurementReport.Hide()
        Me.MenuStripAcc.Hide()
        Me.GP.Hide()
        Me.MenuStripInventoryReports.Hide()
        Me.MainMenu.Show()
        Me.EDM.Hide()
        Me.DMMS.Hide()
        MenuSecrity.Hide()
        If (Me.Tbl_User_LogTableAdapter.GetUserStatus(CModID, CDomID, CUserID) > 0) Then
            Me.Tbl_User_LogTableAdapter.UserLogOut(Now, CModID, CDomID, CUserID)
        End If
        CExitStatus = True
    End Sub
    Private Sub AdminInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminInToolStripMenuItem.Click
        If ChildWindowOpen("frmTranin") = False Then
            Dim objTranin As New frmTranIn
            objTranin.MdiParent = Me
            objTranin.Show()
        End If
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In Me.MdiChildren
            If f.Name = childWindow Then
                f.Focus()
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub AdminOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminOutToolStripMenuItem.Click
        If ChildWindowOpen("frmOut") = False Then
            Dim objOut As New frmOut
            objOut.MdiParent = Me
            objOut.Show()
        End If
    End Sub
    Sub TranIn()
        If ChildWindowOpen("NewTRIn") = False Then
            Dim objNewTranIn As New NewTRIn

            objNewTranIn.MdiParent = Me
            objNewTranIn.Show()
        End If
    End Sub
    Private Sub InToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InToolStripMenuItem.Click
        TranIn()
    End Sub
    Sub TranOut()
        If ChildWindowOpen("frmNewTranOut") = False Then
            Dim objNewTranOut As New frmNewTranOut
            objNewTranOut.MdiParent = Me
            objNewTranOut.Show()
        End If
    End Sub
    Private Sub OutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutToolStripMenuItem.Click
        TranOut()
    End Sub
    Private Sub DateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateToolStripMenuItem.Click
        If ChildWindowOpen("frmTranYear") = False Then
            Dim objYear As New frmTranYear
            objYear.MdiParent = Me
            objYear.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        logout()
    End Sub
    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        TranIn()
    End Sub
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        TranOut()
    End Sub
    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        If ChildWindowOpen("frmTranYear") = False Then
            Dim objYear As New frmTranYear
            objYear.MdiParent = Me
            objYear.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        MaterialCode()
    End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
       logout()
    End Sub
    Private Sub DispatchInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchInToolStripMenuItem.Click
        If ChildWindowOpen("frmDispatchPOsReceive") = False Then
            Dim objPackIn As New frmDispatchPOsReceive
            objPackIn.MdiParent = Me
            objPackIn.Show()
        End If
    End Sub
    Private Sub DispatchOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchOutToolStripMenuItem.Click
        If ChildWindowOpen("frmPackOut") = False Then
            Dim objPackOut As New frmPackOut
            objPackOut.MdiParent = Me
            objPackOut.Show()
        End If
    End Sub

    Private Sub MIRNToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIRNToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.Show()
        End If
    End Sub
    Sub MatReq()
        If ChildWindowOpen("frmMatReq") = False Then
            Dim objfrmMatReq As New frmMatReq
            objfrmMatReq.MdiParent = Me
            objfrmMatReq.Show()
        End If
    End Sub
    Private Sub MaterialRequisitionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialRequisitionToolStripMenuItem1.Click
        MatReq()
    End Sub
    Sub POIn()
        If ChildWindowOpen("frmPOIn") = False Then
            Dim objPOs As New frmPOIn
            objPOs.MdiParent = Me
            objPOs.Show()
        End If
    End Sub
    Private Sub POsInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POsInToolStripMenuItem.Click
        POIn()
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.WindowState = FormWindowState.Maximized
            objRptCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance1
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        If ChildWindowOpen("frmRptReq") = False Then
            Dim objRptReq As New frmRptMRP
            objRptReq.MdiParent = Me
            objRptReq.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        MatReq()
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        POIn()
    End Sub

    Private Sub MaterialCodeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialCodeToolStripMenuItem2.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.Show()
        End If
    End Sub

    Private Sub DailyTransactionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyTransactionToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub MaterialBalanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialBalanceReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal1 As New frmRptFilterBalance
            objRptMatBal1.WindowState = FormWindowState.Maximized
            objRptMatBal1.MdiParent = Me
            objRptMatBal1.Show()
        End If
    End Sub

    Private Sub MaterialRequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialRequisitionToolStripMenuItem.Click
        If ChildWindowOpen("frmRptReq") = False Then
            Dim objRptReq As New frmRptMRP
            objRptReq.MdiParent = Me
            objRptReq.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub UOMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UOMToolStripMenuItem.Click
        If ChildWindowOpen("frmUOM") = False Then
            Dim objUOM As New frmUOM
            objUOM.MdiParent = Me
            objUOM.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        If ChildWindowOpen("frmUOM") = False Then
            Dim objUOM As New frmUOM
            objUOM.MdiParent = Me
            objUOM.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        TranIn()
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        TranOut()
    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        If ChildWindowOpen("frmTranYear") = False Then
            Dim objYear As New frmTranYear
            objYear.MdiParent = Me
            objYear.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        MatReq()
    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        POIn()
    End Sub

    Private Sub ToolStripMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem40.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem41.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem44.Click
        If ChildWindowOpen("frmRptReq") = False Then
            Dim objRptReq As New frmRptMRP
            objRptReq.MdiParent = Me
            objRptReq.Show()
        End If
    End Sub
    Sub RptMRIN()
        If ChildWindowOpen("frmrptMIRN") = False Then
            Dim objTranin As New frmRptMIRN
            objTranin.MdiParent = Me
            objTranin.Show()
        End If
    End Sub
    Private Sub MIRNReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIRNReportsToolStripMenuItem1.Click
        RptMRIN()
    End Sub

    Private Sub MIRNReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIRNReportsToolStripMenuItem2.Click
        RptMRIN()
    End Sub

    Private Sub MIRNReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIRNReportsToolStripMenuItem.Click
        RptMRIN()
    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem.Click
        If ChildWindowOpen("frmLocalCust") = False Then
            Dim objLocalCust As New frmLocalCust
            objLocalCust.MdiParent = Me
            objLocalCust.WindowState = FormWindowState.Maximized
            objLocalCust.Show()
        End If
    End Sub

    Private Sub GroupCompaniesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupCompaniesToolStripMenuItem.Click
        If ChildWindowOpen("FrmGroupComp") = False Then
            Dim objGroupCom As New FrmGroupComp
            objGroupCom.MdiParent = Me
            objGroupCom.WindowState = FormWindowState.Maximized
            objGroupCom.Show()
        End If
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersToolStripMenuItem.Click
        If ChildWindowOpen("frmExtCust") = False Then
            Dim objExtCust As New frmExtCust
            objExtCust.MdiParent = Me
            objExtCust.WindowState = FormWindowState.Maximized
            objExtCust.Show()
        End If
    End Sub

    Private Sub PswdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PswdToolStripMenuItem.Click
        ChngePswd()
    End Sub

    Private Sub PswdToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PswdToolStripMenuItem1.Click
        ChngePswd()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChngePswd()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem54.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem55.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem56.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem57.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem58.Click
        If ChildWindowOpen("frmRptReq") = False Then
            Dim objRptReq As New frmRptMRP
            objRptReq.MdiParent = Me
            objRptReq.Show()
        End If
    End Sub
    Sub ChngePswd()
        If ChildWindowOpen("frmChngPswd") = False Then
            Dim objChngPswd As New frmChngPswd
            objChngPswd.MdiParent = Me
            objChngPswd.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem47.Click
        ChngePswd()
    End Sub
    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        logout()
    End Sub

    Private Sub GenerateDemandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateDemandToolStripMenuItem.Click
        If ChildWindowOpen("frmAddDemands") = False Then
            Dim objAddDemand As New frmAddDemands
            objAddDemand.MdiParent = Me
            objAddDemand.Show()
        End If
    End Sub

    Private Sub SetCompletionStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCompletionStatusToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandCompletion") = False Then
            Dim objDemandComp As New frmDemandCompletion
            objDemandComp.MdiParent = Me
            objDemandComp.Show()
        End If
    End Sub

    Private Sub UndoDemandReceivingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoDemandReceivingsToolStripMenuItem.Click
        If ChildWindowOpen("frmUndoChanges") = False Then
            Dim objUndoChng As New frmUndoChanges
            objUndoChng.MdiParent = Me
            objUndoChng.Show()
        End If
    End Sub

    Private Sub MaterialCodesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialCodesToolStripMenuItem2.Click
        If ChildWindowOpen("frmCodeProc") = False Then
            Dim objCod As New frmCodeProc
            objCod.MdiParent = Me
            objCod.Show()
        End If
    End Sub

    Private Sub AddNewUOMToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUOMToolStripMenuItem1.Click
        If ChildWindowOpen("frmUOM") = False Then
            Dim objUOM As New frmUOM
            objUOM.MdiParent = Me
            objUOM.Show()
        End If
    End Sub

    Private Sub DemandsForApprovalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandsForApprovalToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandReports4Ver") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub VerificationReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificationReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandReports4Acc") = False Then
            Dim objDmdReport4Acc As New frmDemandReports4Acc
            objDmdReport4Acc.MdiParent = Me
            objDmdReport4Acc.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem65.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem66.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem60.Click
        If ChildWindowOpen("frmSupItems") = False Then
            Dim objSupItems As New frmSupItems
            objSupItems.MdiParent = Me
            objSupItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem63.Click
        If ChildWindowOpen("frmRptPO") = False Then
            Dim objRptPO As New frmRptPO
            objRptPO.MdiParent = Me
            objRptPO.Show()
        End If
    End Sub

    Private Sub POLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POLedgerToolStripMenuItem.Click
        If ChildWindowOpen("frmRptPOLedger") = False Then
            Dim objRptPOLedger As New frmRptPOLedger
            objRptPOLedger.MdiParent = Me
            objRptPOLedger.Show()
        End If
    End Sub

    Private Sub DemandReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandReports") = False Then
            Dim objDemandReports As New frmDemandReports11
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub MiscReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmMiscReports4Purchase") = False Then
            Dim objMiscReport As New frmMiscReports4Purchase
            objMiscReport.MdiParent = Me
            objMiscReport.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem59.Click
        If ChildWindowOpen("frmSuppliers") = False Then
            Dim objSuppliers As New frmSuppliers
            objSuppliers.MdiParent = Me
            objSuppliers.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem68.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem71.Click
        logout()
    End Sub

    Private Sub MaterialCodesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialCodesToolStripMenuItem1.Click
        MaterialCode()
    End Sub
    Private Sub ToolStripMenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem91.Click
        If ChildWindowOpen("frmRptPO") = False Then
            Dim objRptPO As New frmRptPO
            objRptPO.MdiParent = Me
            objRptPO.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem92.Click
        If ChildWindowOpen("frmRptPOLedger") = False Then
            Dim objRptPOLedger As New frmRptPOLedger
            objRptPOLedger.MdiParent = Me
            objRptPOLedger.Show()
        End If
    End Sub

    Private Sub POToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POToolStripMenuItem.Click
        If ChildWindowOpen("frmPurOrders") = False Then
            Dim objPurOrders As New frmPurOrders
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem109.Click
        If ChildWindowOpen("frmSuppliers") = False Then
            Dim objSuppliers As New frmSuppliers
            objSuppliers.MdiParent = Me
            objSuppliers.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem110.Click
        If ChildWindowOpen("frmSupItems") = False Then
            Dim objSupItems As New frmSupItems
            objSupItems.MdiParent = Me
            objSupItems.Show()
        End If
    End Sub

    Private Sub GeneratePOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePOToolStripMenuItem.Click
        If ChildWindowOpen("frmProcDemandExceptPO") = False Then
            Dim objProcDemandExceptPO As New frmProcDemandExceptPO
            objProcDemandExceptPO.MdiParent = Me
            objProcDemandExceptPO.Show()
        End If
    End Sub

    Private Sub SetDemandsBookingStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDemandsBookingStatusToolStripMenuItem.Click
        If ChildWindowOpen("frmBookingStatus") = False Then
            Dim objBookingStatus As New frmBookingStatus
            objBookingStatus.MdiParent = Me
            objBookingStatus.Show()
        End If
    End Sub

    Private Sub SetDemandsPurchaseStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDemandsPurchaseStatusToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandPurchased") = False Then
            Dim objDemandPurchased As New frmDemandPurchased
            objDemandPurchased.MdiParent = Me
            objDemandPurchased.Show()
        End If
    End Sub

    Private Sub ProcessNonPODemandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessNonPODemandsToolStripMenuItem.Click
        If ChildWindowOpen("frmProcessDemand") = False Then
            Dim objProcessDemand As New frmProcessDemand
            objProcessDemand.MdiParent = Me
            objProcessDemand.Show()
        End If
    End Sub

    Private Sub SetDemandsPurchaseAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDemandsPurchaseAmountToolStripMenuItem.Click
        If ChildWindowOpen("frmSetPurchaseAmtTemp") = False Then
            Dim objSetPurchaseAmt As New frmSetPurchaseAmtTemp
            objSetPurchaseAmt.WindowState = FormWindowState.Maximized
            objSetPurchaseAmt.MdiParent = Me
            objSetPurchaseAmt.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem89_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem89.Click
        If ChildWindowOpen("frmProcDemandExceptPO") = False Then
            Dim objProcDemandExceptPO As New frmProcDemandExceptPO
            objProcDemandExceptPO.MdiParent = Me
            objProcDemandExceptPO.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem93.Click
        If ChildWindowOpen("frmBookingStatus") = False Then
            Dim objBookingStatus As New frmBookingStatus
            objBookingStatus.MdiParent = Me
            objBookingStatus.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem94.Click
        If ChildWindowOpen("frmDemandPurchased") = False Then
            Dim objDemandPurchased As New frmDemandPurchased
            objDemandPurchased.MdiParent = Me
            objDemandPurchased.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem95.Click
        If ChildWindowOpen("frmProcessDemand") = False Then
            Dim objProcessDemand As New frmProcessDemand
            objProcessDemand.MdiParent = Me
            objProcessDemand.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem96.Click
        If ChildWindowOpen("frmSetPurchaseAmtTemp") = False Then
            Dim objSetPurchaseAmt As New frmSetPurchaseAmtTemp
            objSetPurchaseAmt.MdiParent = Me
            objSetPurchaseAmt.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem98.Click
        If ChildWindowOpen("frmAddDemands") = False Then
            Dim objAddDemands As New frmAddDemands
            objAddDemands.MdiParent = Me
            objAddDemands.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem99.Click
        If ChildWindowOpen("frmDemandCompletion") = False Then
            Dim objDemandCompletion As New frmDemandCompletion
            objDemandCompletion.MdiParent = Me
            objDemandCompletion.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem100.Click
        If ChildWindowOpen("frmUndoChanges") = False Then
            Dim objUndoChanges As New frmUndoChanges
            objUndoChanges.MdiParent = Me
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem101.Click
        If ChildWindowOpen("frmVerifyAfterComp") = False Then
            Dim objVerifyAfterComp As New frmVerifyAfterComp
            objVerifyAfterComp.MdiParent = Me
            objVerifyAfterComp.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem85_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem85.Click
        If ChildWindowOpen("frmPurOrders") = False Then
            Dim objPurOrders As New frmPurOrders
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem103.Click
        If ChildWindowOpen("frmRptPO") = False Then
            Dim objRptPO As New frmRptPO
            objRptPO.MdiParent = Me
            objRptPO.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem104.Click
        If ChildWindowOpen("frmRptPOLedger") = False Then
            Dim objRptPOLedger As New frmRptPOLedger
            objRptPOLedger.MdiParent = Me
            objRptPOLedger.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem105.Click
        If ChildWindowOpen("NewDemandreports") = False Then
            Dim objDemandReports As New NewDemandreports
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem106.Click
        If ChildWindowOpen("frmMiscReports4Purchase") = False Then
            Dim objMiscReport As New frmMiscReports4Purchase
            objMiscReport.MdiParent = Me
            objMiscReport.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem107.Click
        If ChildWindowOpen("NewDemandsreportsAcc1") = False Then
            Dim objDmdReport4ver As New NewDemandsreportsAcc1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem108.Click
        If ChildWindowOpen("frmDemandReports4Acc") = False Then
            Dim objDmdReport4Acc As New frmDemandReports4Acc
            objDmdReport4Acc.MdiParent = Me
            objDmdReport4Acc.Show()
        End If
    End Sub

    Private Sub VerifyDemandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyDemandsToolStripMenuItem.Click
        If ChildWindowOpen("frmVerifyDemand") = False Then
            Dim objVerifyDemand As New frmVerifyDemand
            objVerifyDemand.MdiParent = Me
            objVerifyDemand.WindowState = FormWindowState.Maximized
            objVerifyDemand.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem97.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem102.Click
        logout()
    End Sub
    Private Sub RawMaterialToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RawMaterialToolStripMenuItem1.Click
        MaterialCode()
    End Sub

    Private Sub AccessoriesMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesMaterialToolStripMenuItem.Click
        If ChildWindowOpen("frmCodeProc") = False Then
            Dim objCodeProc As New frmCodeProc
            objCodeProc.MdiParent = Me
            objCodeProc.WindowState = FormWindowState.Maximized
            objCodeProc.Show()
        End If
    End Sub
    Sub POBalance()
        If ChildWindowOpen("frmPOBalance") = False Then
            Dim objCodeProc As New frmPOBalance
            objCodeProc.MdiParent = Me
            objCodeProc.Show()
        End If
    End Sub
    Private Sub POBalanceReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POBalanceReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandReports4Ver1") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub
    Private Sub POBalanceReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POBalanceReportsToolStripMenuItem1.Click
        POBalance()
    End Sub
    Private Sub ToolStripMenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem112.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem113.Click
        logout()
    End Sub

    Private Sub UndoDemandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoDemandsToolStripMenuItem.Click
        If ChildWindowOpen("frmUndoChanges") = False Then
            Dim objUndoChanges As New frmUndoChanges
            objUndoChanges.MdiParent = Me
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub VerifyDemandsAfterPurchaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyDemandsAfterPurchaseToolStripMenuItem1.Click
        If ChildWindowOpen("frmVerifyAfterComp") = False Then
            Dim objVerifyAfterComp As New frmVerifyAfterComp
            objVerifyAfterComp.MdiParent = Me
            objVerifyAfterComp.Show()
        End If
    End Sub

    Private Sub VerificationReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificationReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmDemandReports4Acc") = False Then
            Dim objDemandReports4Acc As New frmDemandReports4Acc
            objDemandReports4Acc.MdiParent = Me
            objDemandReports4Acc.Show()
        End If
    End Sub

    Private Sub POBalanceReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POBalanceReportsToolStripMenuItem2.Click
        POBalance()
    End Sub

    Private Sub POBalanceReportsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POBalanceReportsToolStripMenuItem3.Click
        POBalance()
    End Sub
    Private Sub SupAndMatReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupAndMatReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptMaterialReceiving") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub MaterialReceivingReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialReceivingReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptMatAndSup") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub MaterialReceivingReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialReceivingReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptMatAndSup") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub MaterialReceivingReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialReceivingReportsToolStripMenuItem2.Click
        If ChildWindowOpen("frmRptMaterialReceiving") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub MaterialReceivingReportsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialReceivingReportsToolStripMenuItem3.Click
        If ChildWindowOpen("frmRptMaterialReceiving") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub PurchaseReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem.Click
        If ChildWindowOpen("frmPurchaseReturn") = False Then
            Dim objPurchaseReturn As New frmPurchaseReturn
            objPurchaseReturn.MdiParent = Me
            objPurchaseReturn.Show()
        End If
    End Sub
    Private Sub CustomerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListToolStripMenuItem.Click
        If ChildWindowOpen("frmCustomer") = False Then
            Dim objCustomer As New frmCustomer
            objCustomer.MdiParent = Me
            objCustomer.WindowState = FormWindowState.Maximized
            objCustomer.Show()
        End If
    End Sub

    Private Sub CustomerItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerItemsToolStripMenuItem.Click
        If ChildWindowOpen("frmCustItems") = False Then
            Dim objCustItems As New frmCustItems
            objCustItems.MdiParent = Me
            objCustItems.WindowState = FormWindowState.Maximized
            objCustItems.Show()
        End If
    End Sub

    Private Sub SaleInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoiceToolStripMenuItem.Click
        If ChildWindowOpen("frmSaleInvoice") = False Then
            Dim objSaleInvoice As New frmSaleInvoice
            objSaleInvoice.MdiParent = Me
            objSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem115.Click
        If ChildWindowOpen("frmCustomer") = False Then
            Dim objCustomer As New frmCustomer
            objCustomer.MdiParent = Me
            objCustomer.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem116.Click
        If ChildWindowOpen("frmCustItems") = False Then
            Dim objCustItems As New frmCustItems
            objCustItems.MdiParent = Me
            objCustItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem117.Click
        If ChildWindowOpen("frmSaleInvoice") = False Then
            Dim objSaleInvoice As New frmSaleInvoice
            objSaleInvoice.MdiParent = Me
            objSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem119.Click
        If ChildWindowOpen("frmCustomer") = False Then
            Dim objCustomer As New frmCustomer
            objCustomer.MdiParent = Me
            objCustomer.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem120.Click
        If ChildWindowOpen("frmCustItems") = False Then
            Dim objCustItems As New frmCustItems
            objCustItems.MdiParent = Me
            objCustItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem121.Click
        If ChildWindowOpen("frmSaleInvoice") = False Then
            Dim objSaleInvoice As New frmSaleInvoice
            objSaleInvoice.MdiParent = Me
            objSaleInvoice.Show()
        End If
    End Sub

    Private Sub MaterilaSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChildWindowOpen("frmMaterialSale") = False Then
            Dim objMaterialSale As New frmMaterialSale
            objMaterialSale.MdiParent = Me
            objMaterialSale.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem131.Click
        If ChildWindowOpen("frmMaterialSale") = False Then
            Dim objMaterialSale As New frmMaterialSale
            objMaterialSale.MdiParent = Me
            objMaterialSale.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChildWindowOpen("frmMaterialSale") = False Then
            Dim objMaterialSale As New frmMaterialSale
            objMaterialSale.MdiParent = Me
            objMaterialSale.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem122.Click
        If ChildWindowOpen("frmSuppliers") = False Then
            Dim objSuppliers As New frmSuppliers
            objSuppliers.MdiParent = Me
            objSuppliers.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem123.Click
        If ChildWindowOpen("frmSupItems") = False Then
            Dim objSupItems As New frmSupItems
            objSupItems.MdiParent = Me
            objSupItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem83.Click
        If ChildWindowOpen("frmSuppliers") = False Then
            Dim objSuppliers As New frmSuppliers
            objSuppliers.MdiParent = Me
            objSuppliers.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem124.Click
        If ChildWindowOpen("frmSupItems") = False Then
            Dim objSupItems As New frmSupItems
            objSupItems.MdiParent = Me
            objSupItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem125.Click
        If ChildWindowOpen("frmPurOrders") = False Then
            Dim objPurOrders As New frmPurOrders
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub SaleInvoiceReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoiceReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem128.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem132.Click
        If ChildWindowOpen("frmMat_Lended") = False Then
            Dim objMat_Lended As New frmLendedMatRec
            objMat_Lended.MdiParent = Me
            objMat_Lended.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem133.Click
        If ChildWindowOpen("frmMatBrowedIssued") = False Then
            Dim objMatBrowedIssued As New frmMatBorrowedIssued
            objMatBrowedIssued.MdiParent = Me
            objMatBrowedIssued.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem134.Click
        If ChildWindowOpen("frmMat_Lended") = False Then
            Dim objMat_Lended As New frmLendedMatRec
            objMat_Lended.MdiParent = Me
            objMat_Lended.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem135.Click
        If ChildWindowOpen("frmMatBrowedIssued") = False Then
            Dim objMatBrowedIssued As New frmMatBorrowedIssued
            objMatBrowedIssued.MdiParent = Me
            objMatBrowedIssued.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem129.Click
        If ChildWindowOpen("frmVerifyDemand") = False Then
            Dim objVerifyDemand As New frmVerifyDemand
            objVerifyDemand.MdiParent = Me
            objVerifyDemand.WindowState = FormWindowState.Maximized
            objVerifyDemand.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem159.Click
        If ChildWindowOpen("frmSaleAccounts") = False Then
            Dim objSaleAccounts As New frmSalesBill
            objSaleAccounts.MdiParent = Me
            objSaleAccounts.Show()
        End If
    End Sub

    Private Sub SaleInvoiceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoiceReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem136.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem137.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem138.Click
        If ChildWindowOpen("frmSaleAccounts") = False Then
            Dim objSaleAccounts As New frmSaleAccounts
            objSaleAccounts.MdiParent = Me
            objSaleAccounts.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem140.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem142.Click
        If ChildWindowOpen("frmRptPO") = False Then
            Dim objRptPO As New frmRptPO
            objRptPO.MdiParent = Me
            objRptPO.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem143.Click
        POBalance()
    End Sub

    Private Sub ToolStripMenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem144.Click
        If ChildWindowOpen("frmRptPOLedger") = False Then
            Dim objRptPOLedger As New frmRptPOLedger
            objRptPOLedger.MdiParent = Me
            objRptPOLedger.Show()
        End If
    End Sub


    Private Sub ToolStripMenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem146.Click
        If ChildWindowOpen("frmDispatchPOsReceive") = False Then
            Dim objPackIn As New frmDispatchPOsReceive
            objPackIn.MdiParent = Me
            objPackIn.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem147.Click
        If ChildWindowOpen("frmPackOut") = False Then
            Dim objPackOut As New frmPackOut
            objPackOut.MdiParent = Me
            objPackOut.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem149.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub PuchaseReturnReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuchaseReturnReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptPurchaseReturn") = False Then
            Dim objRptSaleInvoice As New frmRptPurchaseReturn
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.WindowState = FormWindowState.Maximized
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem150.Click
        If ChildWindowOpen("frmRptPurchaseReturn") = False Then
            Dim objRptSaleInvoice As New frmRptPurchaseReturn
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem151.Click
        If ChildWindowOpen("frmRptPurchaseReturn") = False Then
            Dim objRptSaleInvoice As New frmRptPurchaseReturn
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem152.Click
        If ChildWindowOpen("frmTMBalances") = False Then
            Dim objRptSaleInvoice As New frmTMBalances
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub TMMaterialBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMMaterialBalanceToolStripMenuItem.Click
        If ChildWindowOpen("frmTMBalances") = False Then
            Dim objRptSaleInvoice As New frmTMBalances
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub MaterialToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem1.Click
        If ChildWindowOpen("frmMaterial") = False Then
            Dim objRptSaleInvoice As New frmInspectionMaterial
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub MaterialInsepToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialInsepToolStripMenuItem.Click
        If ChildWindowOpen("frmMaterial") = False Then
            Dim objRptSaleInvoice As New frmInspectionMaterial
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub DemandIntoSleepProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandIntoSleepProcessToolStripMenuItem.Click
        If ChildWindowOpen("frmProcDemandSleep") = False Then
            Dim objRptSaleInvoice As New frmProcDemandSleep
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub SleepDemandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SleepDemandsToolStripMenuItem.Click
        If ChildWindowOpen("frmProcDemandSleep") = False Then
            Dim objRptSaleInvoice As New frmProcDemandSleep
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem153.Click
        If ChildWindowOpen("frmRptFilterBalance1") = False Then
            Dim objRptSaleInvoice As New frmRptFilterBalance1
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem154.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptFilterBalance
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub
    Private Sub MaterialAgingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialAgingToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptMaterialAging
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub
    Private Sub MaterialBalanceReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialBalanceReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptFilterBalance
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub MaterialGatePassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialGatePassesToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptGatePasses
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub MaterialGatePassReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialGatePassReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptGatePasses") = False Then
            Dim objfrmRptGatePasses As New frmRptGatePasses
            objfrmRptGatePasses.MdiParent = Me
            objfrmRptGatePasses.Show()
        End If
    End Sub

    Private Sub BillingSaleAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingSaleAccountToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmSalesBill
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub
    Private Sub POMaterialRequisitionReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POMaterialRequisitionReportsToolStripMenuItem1.Click
        If ChildWindowOpen("FrmRptMatRequisition") = False Then
            Dim objFrmRptMatRequisition As New FrmRptMRPD
            objFrmRptMatRequisition.MdiParent = Me
            objFrmRptMatRequisition.Show()
        End If
    End Sub

    Private Sub SaleBillReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleBillReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptSaleBill
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub SaleBillReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleBillReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptSaleBill
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem161.Click
        If ChildWindowOpen("frmCustItems") = False Then
            Dim objCustItems As New frmCustItems
            objCustItems.MdiParent = Me
            objCustItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem156.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem157.Click
        logout()
    End Sub

    Private Sub MaterialAgingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialAgingToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptMaterialAging") = False Then
            Dim objRptMaterialAging As New frmRptMaterialAging
            objRptMaterialAging.MdiParent = Me
            objRptMaterialAging.Show()
        End If
    End Sub

    Private Sub MaterialAgingReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialAgingReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptMaterialAging") = False Then
            Dim objRptMaterialAging As New frmRptMaterialAging
            objRptMaterialAging.MdiParent = Me
            objRptMaterialAging.Show()
        End If
    End Sub
    Private Sub MaterialBalanceReportToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialBalanceReportToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub
    Private Sub AdjustmentEntryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjustmentEntryToolStripMenuItem2.Click
        'If ChildWindowOpen("frmInvAdjReceive") = False Then
        '    Dim objInvAdjReceive As New frmInvAdjReceive
        '    objInvAdjReceive.MdiParent = Me
        '    objInvAdjReceive.Show()
        'End If
    End Sub

    Private Sub MaterialAdjustmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialAdjustmentToolStripMenuItem.Click
        If ChildWindowOpen("frmMatAdjustment") = False Then
            Dim objInvAdjReceive As New frmMatAdjustment
            objInvAdjReceive.MdiParent = Me
            objInvAdjReceive.Show()
        End If
    End Sub
    Private Sub MaterialAdjustmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialAdjustmentToolStripMenuItem1.Click
        If ChildWindowOpen("frmMatAdjustment") = False Then
            Dim objInvAdjReceive As New frmMatAdjustment
            objInvAdjReceive.MdiParent = Me
            objInvAdjReceive.Show()
        End If
    End Sub

    Private Sub UsersManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmUserMgt") = False Then
            Dim objUserMgt As New frmUserMgt
            objUserMgt.MdiParent = Me
            objUserMgt.Show()
        End If
    End Sub

    Private Sub UsersLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersLoginToolStripMenuItem.Click
        If ChildWindowOpen("frmUL") = False Then
            Dim objUL As New frmUL
            objUL.MdiParent = Me
            objUL.Show()
        End If
    End Sub

    Private Sub DomainManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmModuleMgt") = False Then
            Dim objDomainMgt As New frmModuleMgt
            objDomainMgt.MdiParent = Me
            objDomainMgt.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem167.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem169.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem168.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem171.Click
        If ChildWindowOpen("frmRptMRP") = False Then
            Dim objRptReq As New frmRptMRP
            objRptReq.MdiParent = Me
            objRptReq.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem172.Click
        If ChildWindowOpen("frmRptMaterialReceiving") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem173.Click
        If ChildWindowOpen("frmRptMaterialAging") = False Then
            Dim objRptMaterialAging As New frmRptMaterialAging
            objRptMaterialAging.MdiParent = Me
            objRptMaterialAging.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem170.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem163.Click
        ChngePswd()
    End Sub

    Private Sub ToolStripMenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem164.Click
        logout()
    End Sub

    Private Sub POMaterialRequisionReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POMaterialRequisionReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptPORequisition") = False Then
            Dim objRptPOReq As New FrmRptMRPD
            objRptPOReq.MdiParent = Me
            objRptPOReq.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem176.Click
        If ChildWindowOpen("frmDemandCompletion") = False Then
            Dim objDemandComp As New frmDemandCompletion
            objDemandComp.MdiParent = Me
            objDemandComp.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem177.Click
        If ChildWindowOpen("frmUndoChanges") = False Then
            Dim objUndoChng As New frmUndoChanges
            objUndoChng.MdiParent = Me
            objUndoChng.Show()
        End If
    End Sub

    Private Sub VerificationReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificationReportsToolStripMenuItem2.Click
        If ChildWindowOpen("frmDemandReports4Acc") = False Then
            Dim objDmdReport4Acc As New frmDemandReports4Acc
            objDmdReport4Acc.MdiParent = Me
            objDmdReport4Acc.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem181.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem186.Click
        If ChildWindowOpen("frmRptMaterialReceiving") = False Then
            Dim objRptMatAndSup As New frmRptMaterialReceiving
            objRptMatAndSup.MdiParent = Me
            objRptMatAndSup.Show()
        End If
    End Sub

    Private Sub LockedUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockedUsersToolStripMenuItem.Click
        LockedUsers()
    End Sub
    Sub LockedUsers()
        If ChildWindowOpen("frmLockedUsers") = False Then
            Dim objLockedUsers As New frmLockedUsers
            objLockedUsers.MdiParent = Me
            objLockedUsers.Show()
        End If
    End Sub
    Private Sub LockedUsersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockedUsersToolStripMenuItem1.Click
        LockedUsers()
    End Sub

    Private Sub MiscReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmMiscReports4Purchase") = False Then
            Dim objMiscReports4Purchase As New frmMiscReports4Purchase
            objMiscReports4Purchase.MdiParent = Me
            objMiscReports4Purchase.Show()
        End If
    End Sub

    Private Sub DailyTransactionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyTransactionReportToolStripMenuItem.Click
        'If ChildWindowOpen("frmRptFilterTran") = False Then
        '    Dim objRptTran As New frmRptFilterTran
        '    objRptTran.MdiParent = Me
        '    objRptTran.Show()
        'End If
        ToolStripMenuItem16_Click(Nothing, Nothing)
    End Sub

    Private Sub MRPDispatchReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRPDispatchReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptPORequisition") = False Then
            Dim objRptPOReq As New FrmRptMRPD
            objRptPOReq.MdiParent = Me
            objRptPOReq.Show()
        End If
    End Sub

    Private Sub RackInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RackInfoToolStripMenuItem.Click
        If ChildWindowOpen("frmLinesRacksInfo") = False Then
            Dim objRptPOReq1 As New frmLinesRacksInfo
            objRptPOReq1.MdiParent = Me
            objRptPOReq1.WindowState = FormWindowState.Maximized
            objRptPOReq1.Show()
        End If
    End Sub

    Private Sub RackInfloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RackInfloToolStripMenuItem.Click
        If ChildWindowOpen("frmLinesRacksInfo") = False Then
            Dim objRptPOReq1 As New frmLinesRacksInfo
            objRptPOReq1.MdiParent = Me
            objRptPOReq1.WindowState = FormWindowState.Maximized
            objRptPOReq1.Show()
        End If
    End Sub

    Private Sub DiapatchMaterialReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiapatchMaterialReportToolStripMenuItem.Click
        If ChildWindowOpen("frmDispMat") = False Then
            Dim objRptPOReq11 As New frmDispMat
            objRptPOReq11.MdiParent = Me
            objRptPOReq11.WindowState = FormWindowState.Maximized
            objRptPOReq11.Show()
        End If
    End Sub

    Private Sub BEReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmBERec") = False Then
            Dim objSF As New frmBERec
            objSF.MdiParent = Me
            objSF.WindowState = FormWindowState.Maximized
            objSF.Show()
        End If
    End Sub
    Private Sub MaterialTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptDailyTran") = False Then
            Dim objSF1 As New frmRptDailyTran
            objSF1.MdiParent = Me
            objSF1.WindowState = FormWindowState.Maximized
            objSF1.Show()
        End If
    End Sub
    Private Sub BEIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmBEMatIssuance") = False Then
            Dim objSF As New frmNewBEMatIssued
            objSF.MdiParent = Me
            objSF.WindowState = FormWindowState.Maximized
            objSF.Show()
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        logout()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem2.Click
        ChangePasswordToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem179.Click
        If ChildWindowOpen("frmBEMatIssuance") = False Then
            Dim objSF As New frmNewBEMatIssued
            objSF.MdiParent = Me
            objSF.WindowState = FormWindowState.Maximized
            objSF.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem180.Click
        If ChildWindowOpen("frmRptDailyTran") = False Then
            Dim objSF1 As New frmRptDailyTran
            objSF1.MdiParent = Me
            objSF1.WindowState = FormWindowState.Maximized
            objSF1.Show()
        End If
    End Sub

    Private Sub GeneratePOsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePOsToolStripMenuItem.Click
        If ChildWindowOpen("frmPurOrders") = False Then
            Dim objPurOrders As New frmPurOrders
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub AutoPOReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoPOReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmAutoPOIN") = False Then
            Dim objSF111 As New frmAutoPOIN
            objSF111.MdiParent = Me
            objSF111.WindowState = FormWindowState.Maximized
            objSF111.Show()
        End If
    End Sub

    Private Sub AutoPOReceivingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoPOReceivingToolStripMenuItem1.Click
        If ChildWindowOpen("frmAutoPOIN") = False Then
            Dim objSF111 As New frmAutoPOIN
            objSF111.MdiParent = Me
            objSF111.WindowState = FormWindowState.Maximized
            objSF111.Show()
        End If
    End Sub

    Private Sub AccessoriesMaterialToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesMaterialToolStripMenuItem1.Click
        AccessoriesMaterialToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub RepairBladderRecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepairBladderRecToolStripMenuItem.Click
        If ChildWindowOpen("frmBladerRepRec") = False Then
            Dim objSF1111 As New frmBladerRepRec
            objSF1111.MdiParent = Me
            objSF1111.WindowState = FormWindowState.Maximized
            objSF1111.Show()
        End If
    End Sub

    Private Sub RepairBladderProcessesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepairBladderProcessesToolStripMenuItem.Click
        If ChildWindowOpen("frmBladderProcesses") = False Then
            Dim objSF11111 As New frmBladderProcesses
            objSF11111.MdiParent = Me
            objSF11111.WindowState = FormWindowState.Maximized
            objSF11111.Show()
        End If
    End Sub

    Private Sub PassBladdersRecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassBladdersRecToolStripMenuItem.Click
        If ChildWindowOpen("frmPassBaladerRec") = False Then
            Dim objSF111111 As New frmPassBaladerRec
            objSF111111.MdiParent = Me
            objSF111111.WindowState = FormWindowState.Maximized
            objSF111111.Show()
        End If
    End Sub

    Private Sub PurchaseReturnReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmPRRN") = False Then
            Dim objPRRN As New frmPRRN
            objPRRN.MdiParent = Me
            objPRRN.WindowState = FormWindowState.Maximized
            objPRRN.Show()
        End If
    End Sub

    Private Sub AccessoriesMaterialToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesMaterialToolStripMenuItem2.Click
        AccessoriesMaterialToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ScrapSaleTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapSaleTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmScrapSale") = False Then
            Dim objPRRN2 As New FrmScrapSale
            objPRRN2.MdiParent = Me
            objPRRN2.WindowState = FormWindowState.Maximized
            objPRRN2.Show()
        End If
    End Sub

    Private Sub VendorInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorInformationToolStripMenuItem.Click
        If ChildWindowOpen("frmVendorInfo") = False Then
            Dim objPRRN1 As New frmVendorInfo
            objPRRN1.MdiParent = Me
            objPRRN1.WindowState = FormWindowState.Maximized
            objPRRN1.Show()
        End If
    End Sub

    Private Sub VendorInformationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorInformationToolStripMenuItem1.Click
        VendorInformationToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ScrapSaleTransactionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapSaleTransactionsToolStripMenuItem1.Click
        ScrapSaleTransactionsToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ScrapeSaleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapeSaleReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptScrapeSale") = False Then
            Dim objPRRN11 As New frmRptScrapeSale
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ScrapeSaleReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapeSaleReportToolStripMenuItem1.Click
        ScrapeSaleReportToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub DemandIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandIssuance") = False Then
            Dim objPRRN11 As New frmDemandIssuance
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub DemandIssuanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandIssuanceToolStripMenuItem1.Click
        If ChildWindowOpen("frmDemandIssuance") = False Then
            Dim objPRRN11 As New frmDemandIssuance
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub DemandReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DemandReportToolStripMenuItem.Click
        ToolStripMenuItem107_Click(Nothing, Nothing)
    End Sub

    Private Sub PartialDemandIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialDemandIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmPartialRecDemands") = False Then
            Dim objPRRN111 As New frmPartialRecDemands
            objPRRN111.MdiParent = Me
            objPRRN111.WindowState = FormWindowState.Maximized
            objPRRN111.Show()
        End If
    End Sub

    Private Sub BillingTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmbillingMatTran") = False Then
            Dim objDmdReport4ver1 As New frmbillingMatTran
            objDmdReport4ver1.MdiParent = Me
            objDmdReport4ver1.WindowState = FormWindowState.Maximized
            objDmdReport4ver1.Show()
        End If
    End Sub

    Private Sub BillingPartyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingPartyToolStripMenuItem.Click
        If ChildWindowOpen("frmBillingParty") = False Then
            Dim objPRRN11111 As New frmBillingParty
            objPRRN11111.MdiParent = Me
            objPRRN11111.WindowState = FormWindowState.Maximized
            objPRRN11111.Show()
        End If
    End Sub


    Private Sub BillingPaymentTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingPaymentTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmBillingTranNewUndoVerifying") = False Then
            Dim objPRRN2111111 As New frmBillingTranNewUndoVerifying
            objPRRN2111111.MdiParent = Me
            objPRRN2111111.WindowState = FormWindowState.Maximized
            objPRRN2111111.Show()
        End If
    End Sub

    Private Sub VerifyBillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyBillingToolStripMenuItem.Click
        If ChildWindowOpen("frmBillingTranNewVerifying") = False Then
            Dim objPRRN211111 As New frmBillingTranNewVerifying
            objPRRN211111.MdiParent = Me
            objPRRN211111.WindowState = FormWindowState.Maximized
            objPRRN211111.Show()
        End If
    End Sub

    Private Sub BillingTransactionsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingTransactionsReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptBillingTran") = False Then
            Dim objRptBillingTran As New frmRptBillingTran
            objRptBillingTran.MdiParent = Me
            objRptBillingTran.WindowState = FormWindowState.Maximized
            objRptBillingTran.Show()
        End If
    End Sub

    Private Sub VerifyBillingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyBillingToolStripMenuItem1.Click
        VerifyBillingToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub AutoSaleIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSaleIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmAutoSaleIssuance") = False Then
            Dim objRptAutoSaleIssuance As New frmAutoSaleIssuance
            objRptAutoSaleIssuance.MdiParent = Me
            objRptAutoSaleIssuance.WindowState = FormWindowState.Maximized
            objRptAutoSaleIssuance.Show()
        End If
    End Sub

    Private Sub AutoSaleIssuanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSaleIssuanceToolStripMenuItem1.Click
        AutoSaleIssuanceToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub RepairIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepairIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmRepairIssuance") = False Then
            Dim objRepairIssuance As New frmRepairIssuance
            objRepairIssuance.MdiParent = Me
            objRepairIssuance.WindowState = FormWindowState.Maximized
            objRepairIssuance.Show()
        End If
    End Sub

    Private Sub WindedBladderEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindedBladderEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmWindedBladderProcess") = False Then
            Dim objWindedBladderProcess As New frmWindedBladderProcess
            objWindedBladderProcess.MdiParent = Me
            objWindedBladderProcess.WindowState = FormWindowState.Maximized
            objWindedBladderProcess.Show()
        End If
    End Sub

    Private Sub BladderRepairIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BladderRepairIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmBladderRepairIssuance") = False Then
            Dim objWindedBladderProcess1 As New frmBladderRepairIssuance
            objWindedBladderProcess1.MdiParent = Me
            objWindedBladderProcess1.WindowState = FormWindowState.Maximized
            objWindedBladderProcess1.Show()
        End If
    End Sub

    Private Sub RepairedBladderReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepairedBladderReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmRepairedBladderRec") = False Then
            Dim objWindedBladderProcess11 As New frmRepairedBladderRec
            objWindedBladderProcess11.MdiParent = Me
            objWindedBladderProcess11.WindowState = FormWindowState.Maximized
            objWindedBladderProcess11.Show()
        End If
    End Sub

    Private Sub ExecuterNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuterNameToolStripMenuItem.Click
        If ChildWindowOpen("frmWindedExect") = False Then
            Dim objWindedExect As New frmWindedExect
            objWindedExect.MdiParent = Me
            objWindedExect.WindowState = FormWindowState.Maximized
            objWindedExect.Show()
        End If
    End Sub

    Private Sub RepairableBladderRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepairableBladderRToolStripMenuItem.Click
        If ChildWindowOpen("FrmRepaireBladderRec") = False Then
            Dim objWindedExect11 As New FrmRepaireBladderRec
            objWindedExect11.MdiParent = Me
            objWindedExect11.WindowState = FormWindowState.Maximized
            objWindedExect11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem183.Click
        If ChildWindowOpen("FrmRepaireBladderRec") = False Then
            Dim objWindedExect1 As New FrmRepaireBladderRec
            objWindedExect1.MdiParent = Me
            objWindedExect1.WindowState = FormWindowState.Maximized
            objWindedExect1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem184.Click
        If ChildWindowOpen("frmWindedBladderProcess") = False Then
            Dim objWindedBladderProcess As New frmWindedBladderProcess
            objWindedBladderProcess.MdiParent = Me
            objWindedBladderProcess.WindowState = FormWindowState.Maximized
            objWindedBladderProcess.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem185.Click
        If ChildWindowOpen("frmBladderRepairIssuance") = False Then
            Dim objWindedBladderProcess1 As New frmBladderRepairIssuance
            objWindedBladderProcess1.MdiParent = Me
            objWindedBladderProcess1.WindowState = FormWindowState.Maximized
            objWindedBladderProcess1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem187.Click
        If ChildWindowOpen("frmRepairedBladderRec") = False Then
            Dim objWindedBladderProcess11 As New frmRepairedBladderRec
            objWindedBladderProcess11.MdiParent = Me
            objWindedBladderProcess11.WindowState = FormWindowState.Maximized
            objWindedBladderProcess11.Show()
        End If
    End Sub

    Private Sub DepartmentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentsToolStripMenuItem1.Click
        DepartmentsToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem189.Click
        DepartmentsToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem190.Click
        GroupCompaniesToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem191.Click
        CustomersToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub CustomerListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListToolStripMenuItem1.Click
        CustomerListToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub BladderBillTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BladderBillTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmBladerBillingTran") = False Then
            Dim objWindedBladderProcess111 As New frmBladerBillingTran
            objWindedBladderProcess111.MdiParent = Me
            objWindedBladderProcess111.WindowState = FormWindowState.Maximized
            objWindedBladderProcess111.Show()
        End If
    End Sub

    Private Sub BladderBillingTransactionReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BladderBillingTransactionReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptBillingTransactions") = False Then
            Dim objWindedBladderProcess1111 As New frmRptBillingTransactions
            objWindedBladderProcess1111.MdiParent = Me
            objWindedBladderProcess1111.WindowState = FormWindowState.Maximized
            objWindedBladderProcess1111.Show()
        End If
    End Sub

    Private Sub RepairBladderGatePassReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepairBladderGatePassReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptRepairedBladders") = False Then
            Dim objWindedBladderProcess11111 As New frmRptRepairedBladders
            objWindedBladderProcess11111.MdiParent = Me
            objWindedBladderProcess11111.WindowState = FormWindowState.Maximized
            objWindedBladderProcess11111.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem192.Click
        If ChildWindowOpen("frmBladerBillingTran") = False Then
            Dim objWindedBladderProcess111 As New frmBladerBillingTran
            objWindedBladderProcess111.MdiParent = Me
            objWindedBladderProcess111.WindowState = FormWindowState.Maximized
            objWindedBladderProcess111.Show()
        End If
    End Sub

    Private Sub BladderBillingTransactionReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BladderBillingTransactionReportsToolStripMenuItem1.Click
        BladderBillingTransactionReportsToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ExecuterNameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuterNameToolStripMenuItem1.Click
        ExecuterNameToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub VendorsInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorsInfoToolStripMenuItem.Click
        If ChildWindowOpen("frmPurVendorInfo") = False Then
            Dim objWindedBladderProcess1111 As New frmPurVendorInfo
            objWindedBladderProcess1111.MdiParent = Me
            objWindedBladderProcess1111.WindowState = FormWindowState.Maximized
            objWindedBladderProcess1111.Show()
        End If
    End Sub

    Private Sub BladderFormulaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BladderFormulaToolStripMenuItem.Click
        If ChildWindowOpen("frmCustBladderFormula") = False Then
            Dim objCustBladderFormula As New frmCustBladderFormula
            objCustBladderFormula.MdiParent = Me
            objCustBladderFormula.WindowState = FormWindowState.Maximized
            objCustBladderFormula.Show()
        End If
    End Sub

    Private Sub BladderFormulaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BladderFormulaToolStripMenuItem1.Click
        If ChildWindowOpen("frmCustBladderFormula") = False Then
            Dim objCustBladderFormula As New frmCustBladderFormula
            objCustBladderFormula.MdiParent = Me
            objCustBladderFormula.WindowState = FormWindowState.Maximized
            objCustBladderFormula.Show()
        End If
    End Sub

    Private Sub MIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIRToolStripMenuItem.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.Show()
        End If
    End Sub

    Private Sub WareHouseInfoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareHouseInfoToolStripMenuItem1.Click
        If ChildWindowOpen("frmWareHouseInfo") = False Then
            Dim objCustBladderFormula1 As New frmWareHouseInfo
            objCustBladderFormula1.MdiParent = Me
            objCustBladderFormula1.WindowState = FormWindowState.Maximized
            objCustBladderFormula1.Show()
        End If
    End Sub

    Private Sub WareHouseMaterialIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareHouseMaterialIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmWareHouseIssuance") = False Then
            Dim objCustBladderFormula12 As New frmWareHouseIssuance
            objCustBladderFormula12.MdiParent = Me
            objCustBladderFormula12.WindowState = FormWindowState.Maximized
            objCustBladderFormula12.Show()
        End If
    End Sub

    Private Sub WareHouseMaterialReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareHouseMaterialReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmWareHouseRec") = False Then
            Dim objCustBladderFormula2 As New frmWareHouseRec
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem2.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem3.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem4.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem5.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub SupplierLedgerReportToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierLedgerReportToolStripMenuItem6.Click
        If ChildWindowOpen("frmRptSupplierLedger") = False Then
            Dim objCustBladderFormula2 As New frmRptSupplierLedger
            objCustBladderFormula2.MdiParent = Me
            objCustBladderFormula2.WindowState = FormWindowState.Maximized
            objCustBladderFormula2.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem193.Click
        MaterialCode()
    End Sub

    Private Sub ToolStripMenuItem194_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem194.Click
        AccessoriesMaterialToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub POGateEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POGateEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmPOAtGate") = False Then
            Dim objCustBladderFormula21 As New frmPOAtGate
            objCustBladderFormula21.MdiParent = Me
            objCustBladderFormula21.WindowState = FormWindowState.Maximized
            objCustBladderFormula21.Show()
        End If
    End Sub

    Private Sub DailyJalaEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyJalaEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmDailyJALAEntry") = False Then
            Dim objCustBladderFormula121 As New frmDailyJALAEntry
            objCustBladderFormula121.MdiParent = Me
            objCustBladderFormula121.WindowState = FormWindowState.Maximized
            objCustBladderFormula121.Show()
        End If
    End Sub

    Private Sub PurchaseBillNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseBillNoToolStripMenuItem.Click
        If ChildWindowOpen("frmSetPurchaseAmtBilling") = False Then
            Dim objCustBladderFormula121 As New frmSetPurchaseAmtBilling
            objCustBladderFormula121.MdiParent = Me
            objCustBladderFormula121.WindowState = FormWindowState.Maximized
            objCustBladderFormula121.Show()
        End If
    End Sub

    Private Sub PurchaseBillNoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseBillNoToolStripMenuItem1.Click
        If ChildWindowOpen("frmSetPurchaseAmtBilling") = False Then
            Dim objCustBladderFormula121 As New frmSetPurchaseAmtBilling
            objCustBladderFormula121.MdiParent = Me
            objCustBladderFormula121.WindowState = FormWindowState.Maximized
            objCustBladderFormula121.Show()
        End If
    End Sub

    Private Sub UnWindedBladderEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnWindedBladderEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmWindedBladderProcess4Winding") = False Then
            Dim objCustBladderFormula121 As New frmWindedBladderProcess4Winding
            objCustBladderFormula121.MdiParent = Me
            objCustBladderFormula121.WindowState = FormWindowState.Maximized
            objCustBladderFormula121.Show()
        End If
    End Sub

    Private Sub UnWindedBillTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnWindedBillTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmBladerBillingTran4Winding") = False Then
            Dim objCustBladderFormula1211 As New frmBladerBillingTran4Winding
            objCustBladderFormula1211.MdiParent = Me
            objCustBladderFormula1211.WindowState = FormWindowState.Maximized
            objCustBladderFormula1211.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem195_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem195.Click
        If ChildWindowOpen("frmWindedBladderProcess4Winding") = False Then
            Dim objCustBladderFormula121 As New frmWindedBladderProcess4Winding
            objCustBladderFormula121.MdiParent = Me
            objCustBladderFormula121.WindowState = FormWindowState.Maximized
            objCustBladderFormula121.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem196.Click
        If ChildWindowOpen("frmBladerBillingTran4Winding") = False Then
            Dim objCustBladderFormula1211 As New frmBladerBillingTran4Winding
            objCustBladderFormula1211.MdiParent = Me
            objCustBladderFormula1211.WindowState = FormWindowState.Maximized
            objCustBladderFormula1211.Show()
        End If
    End Sub

    Private Sub SupplierReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptSupList") = False Then
            Dim objCustBladderFormula1211 As New frmRptSupList
            objCustBladderFormula1211.MdiParent = Me
            objCustBladderFormula1211.WindowState = FormWindowState.Maximized
            objCustBladderFormula1211.Show()
        End If
    End Sub

    Private Sub SupplierReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptSupList") = False Then
            Dim objCustBladderFormula1211 As New frmRptSupList
            objCustBladderFormula1211.MdiParent = Me
            objCustBladderFormula1211.WindowState = FormWindowState.Maximized
            objCustBladderFormula1211.Show()
        End If
    End Sub

    Private Sub SupplierReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReportsToolStripMenuItem2.Click
        If ChildWindowOpen("frmRptSupList") = False Then
            Dim objCustBladderFormula1211 As New frmRptSupList
            objCustBladderFormula1211.MdiParent = Me
            objCustBladderFormula1211.WindowState = FormWindowState.Maximized
            objCustBladderFormula1211.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem198.Click
        If ChildWindowOpen("frmVerifyAfterComp") = False Then
            Dim objVerifyAfterComp As New frmVerifyAfterComp
            objVerifyAfterComp.MdiParent = Me
            objVerifyAfterComp.WindowState = FormWindowState.Maximized
            objVerifyAfterComp.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem199.Click
        If ChildWindowOpen("frmNewUndoChanges") = False Then
            Dim objUndoChanges As New frmNewUndoChanges
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem200.Click
        If ChildWindowOpen("frmBillingTranNewVerifying") = False Then
            Dim objPRRN211111 As New frmBillingTranNewVerifying
            objPRRN211111.MdiParent = Me
            objPRRN211111.WindowState = FormWindowState.Maximized
            objPRRN211111.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem204.Click
        If ChildWindowOpen("frmDemandReports4Acc") = False Then
            Dim objDemandReports4Acc As New frmDemandReports4Acc
            objDemandReports4Acc.MdiParent = Me
            objDemandReports4Acc.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem205.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptMatBal As New frmRptFilterBalance
            objRptMatBal.MdiParent = Me
            objRptMatBal.Show()
        End If
    End Sub

    Private Sub PurchaseReturnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem1.Click
        If ChildWindowOpen("frmPurchaseReturn") = False Then
            Dim objPurchaseReturn As New frmPurchaseReturn
            objPurchaseReturn.MdiParent = Me
            objPurchaseReturn.WindowState = FormWindowState.Maximized
            objPurchaseReturn.Show()
        End If
    End Sub

    Private Sub UOMConversionEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UOMConversionEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmUOMD") = False Then
            Dim objPurchaseReturn1 As New frmUOMD
            objPurchaseReturn1.MdiParent = Me
            objPurchaseReturn1.WindowState = FormWindowState.Maximized
            objPurchaseReturn1.Show()
        End If
    End Sub

    Private Sub UOMConversionEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UOMConversionEntryToolStripMenuItem1.Click
        If ChildWindowOpen("frmUOMD") = False Then
            Dim objPurchaseReturn1 As New frmUOMD
            objPurchaseReturn1.MdiParent = Me
            objPurchaseReturn1.WindowState = FormWindowState.Maximized
            objPurchaseReturn1.Show()
        End If
    End Sub

    Private Sub UOMConversionEntryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UOMConversionEntryToolStripMenuItem2.Click
        If ChildWindowOpen("frmUOMD") = False Then
            Dim objPurchaseReturn1 As New frmUOMD
            objPurchaseReturn1.MdiParent = Me
            objPurchaseReturn1.WindowState = FormWindowState.Maximized
            objPurchaseReturn1.Show()
        End If
    End Sub

    Private Sub SaleMaterialReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleMaterialReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmSaleReturn") = False Then
            Dim objPurchaseReturn11 As New frmSaleReturn
            objPurchaseReturn11.MdiParent = Me
            objPurchaseReturn11.WindowState = FormWindowState.Maximized
            objPurchaseReturn11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem201.Click
        If ChildWindowOpen("frmSaleReturn") = False Then
            Dim objPurchaseReturn11 As New frmSaleReturn
            objPurchaseReturn11.MdiParent = Me
            objPurchaseReturn11.WindowState = FormWindowState.Maximized
            objPurchaseReturn11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem202.Click
        If ChildWindowOpen("frmRptPurchaseReturn") = False Then
            Dim objRptSaleInvoice As New frmRptPurchaseReturn
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.WindowState = FormWindowState.Maximized
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub SaleInvoiceReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoiceReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem203.Click
        POBalance()
    End Sub

    Private Sub ToolStripMenuItem206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem206.Click
        RptMRIN()
    End Sub

    Private Sub LOMRecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOMRecToolStripMenuItem.Click
        If ChildWindowOpen("frmLOMRec") = False Then
            Dim objRptSaleInvoice1 As New frmLOMRec
            objRptSaleInvoice1.MdiParent = Me
            objRptSaleInvoice1.WindowState = FormWindowState.Maximized
            objRptSaleInvoice1.Show()
        End If
    End Sub

    Private Sub MaterialBalanceWithValueReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialBalanceWithValueReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFilterBalance1") = False Then
            Dim objRptMatBal As New frmRptFilterBalance1
            objRptMatBal.MdiParent = Me
            objRptMatBal.WindowState = FormWindowState.Maximized
            objRptMatBal.Show()
        End If
    End Sub


    Private Sub WrongMaterialAdjustmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrongMaterialAdjustmentToolStripMenuItem.Click
        If ChildWindowOpen("frmMatWrongAdjustment") = False Then
            Dim objRptMatBal1 As New frmMatWrongAdjustment
            objRptMatBal1.MdiParent = Me
            objRptMatBal1.WindowState = FormWindowState.Maximized
            objRptMatBal1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem207.Click
        If ChildWindowOpen("frmMatWrongAdjustment") = False Then
            Dim objRptMatBal1 As New frmMatWrongAdjustment
            objRptMatBal1.MdiParent = Me
            objRptMatBal1.WindowState = FormWindowState.Maximized
            objRptMatBal1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem232.Click
        If ChildWindowOpen("frmDemandReports4Ver") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem230.Click
        If ChildWindowOpen("frmDemandReports") = False Then
            Dim objDemandReports As New frmDemandReports11
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem209_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem209.Click
        ChangePasswordToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem210.Click
        logout()
    End Sub

    Private Sub ImportMaterialTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportMaterialTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmPOImportTrans") = False Then
            Dim objDemandReports1 As New frmPOImportTrans
            objDemandReports1.WindowState = FormWindowState.Maximized
            objDemandReports1.MdiParent = Me
            objDemandReports1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem211.Click
        If ChildWindowOpen("frmPOImportTrans") = False Then
            Dim objDemandReports1 As New frmPOImportTrans
            objDemandReports1.WindowState = FormWindowState.Maximized
            objDemandReports1.MdiParent = Me
            objDemandReports1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem212.Click
        If ChildWindowOpen("frmDemandReports4Ver") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem213.Click
        If ChildWindowOpen("frmPOImpShipmentTrans") = False Then
            Dim objDemandReports11 As New frmPOImpShipmentTrans
            objDemandReports11.WindowState = FormWindowState.Maximized
            objDemandReports11.MdiParent = Me
            objDemandReports11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem214_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem214.Click
        If ChildWindowOpen("frmPOImpShipmentTrans") = False Then
            Dim objDemandReports11 As New frmPOImpShipmentTrans
            objDemandReports11.WindowState = FormWindowState.Maximized
            objDemandReports11.MdiParent = Me
            objDemandReports11.Show()
        End If
    End Sub

    Private Sub ForeTechMaterialReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForeTechMaterialReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptFortechTran") = False Then
            Dim objDemandReports111 As New frmRptFortechTran
            objDemandReports111.WindowState = FormWindowState.Maximized
            objDemandReports111.MdiParent = Me
            objDemandReports111.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem215.Click
        If ChildWindowOpen("frmRptFortechTran") = False Then
            Dim objDemandReports111 As New frmRptFortechTran
            objDemandReports111.WindowState = FormWindowState.Maximized
            objDemandReports111.MdiParent = Me
            objDemandReports111.Show()
        End If
    End Sub

    Private Sub CurrencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyToolStripMenuItem.Click
        If ChildWindowOpen("frmCurrency") = False Then
            Dim objDemandReports1111 As New frmCurrency
            objDemandReports1111.WindowState = FormWindowState.Maximized
            objDemandReports1111.MdiParent = Me
            objDemandReports1111.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem216.Click
        If ChildWindowOpen("frmCurrency") = False Then
            Dim objDemandReports1111 As New frmCurrency
            objDemandReports1111.WindowState = FormWindowState.Maximized
            objDemandReports1111.MdiParent = Me
            objDemandReports1111.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem218.Click
        If ChildWindowOpen("frmAddDemands") = False Then
            Dim objAddDemands As New frmAddDemands
            objAddDemands.MdiParent = Me
            objAddDemands.WindowState = FormWindowState.Maximized
            objAddDemands.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem226.Click
        If ChildWindowOpen("frmVerifyDemand") = False Then
            Dim objVerifyDemand As New frmVerifyDemand
            objVerifyDemand.MdiParent = Me
            objVerifyDemand.WindowState = FormWindowState.Maximized
            objVerifyDemand.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem222.Click
        If ChildWindowOpen("frmNewDemandCompletion") = False Then
            Dim objDemandCompletion As New frmNewDemandCompletion
            objDemandCompletion.MdiParent = Me
            objDemandCompletion.WindowState = FormWindowState.Maximized
            objDemandCompletion.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem219.Click
        If ChildWindowOpen("frmNewUndoChanges") = False Then
            Dim objUndoChanges As New frmNewUndoChanges
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem224.Click
        If ChildWindowOpen("frmDemandIssuance") = False Then
            Dim objPRRN11 As New frmDemandIssuance
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem223.Click
        If ChildWindowOpen("frmNewSetPurchaseAmt") = False Then
            Dim objSetPurchaseAmt As New frmNewSetPurchaseAmt
            objSetPurchaseAmt.MdiParent = Me
            objSetPurchaseAmt.WindowState = FormWindowState.Maximized
            objSetPurchaseAmt.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem225_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem225.Click
        If ChildWindowOpen("frmVerifyAfterComp") = False Then
            Dim objVerifyAfterComp As New frmVerifyAfterComp
            objVerifyAfterComp.MdiParent = Me
            objVerifyAfterComp.WindowState = FormWindowState.Maximized
            objVerifyAfterComp.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem221.Click
        If ChildWindowOpen("frmNewDemandCompletion") = False Then
            Dim objDemandCompletion As New frmNewDemandCompletion
            objDemandCompletion.MdiParent = Me
            objDemandCompletion.WindowState = FormWindowState.Maximized
            objDemandCompletion.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem227.Click
        If ChildWindowOpen("frmNewUndoChanges") = False Then
            Dim objUndoChanges As New frmNewUndoChanges
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub GateInwardVerificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GateInwardVerificationToolStripMenuItem.Click
        If ChildWindowOpen("frmInwardTranVer") = False Then
            Dim objUndoChanges1 As New frmInwardTranVer
            objUndoChanges1.MdiParent = Me
            objUndoChanges1.WindowState = FormWindowState.Maximized
            objUndoChanges1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem231.Click
        ChangePasswordToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem233_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem233.Click
        logout()
    End Sub

    Private Sub AccountsVerificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsVerificationToolStripMenuItem.Click
        If ChildWindowOpen("frmNewVerifyAfterComp") = False Then
            Dim objUndoChanges As New frmNewVerifyAfterComp
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem235_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem235.Click
        If ChildWindowOpen("frmDemandReports4Ver") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem236.Click
        If ChildWindowOpen("frmDemandReports") = False Then
            Dim objDemandReports As New frmDemandReports11
            objDemandReports.MdiParent = Me
            objDemandReports.WindowState = FormWindowState.Maximized
            objDemandReports.Show()
        End If
    End Sub

    Private Sub AccountsVerificationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsVerificationToolStripMenuItem1.Click
        If ChildWindowOpen("frmNewVerifyAfterComp") = False Then
            Dim objUndoChanges As New frmNewVerifyAfterComp
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub MaterialRecEntriersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialRecEntriersToolStripMenuItem.Click
        If ChildWindowOpen("frmDailyTranIn") = False Then
            Dim objUndoChanges As New frmDailyTranInscrab
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem237.Click
        If ChildWindowOpen("frmDailyTranIn") = False Then
            Dim objUndoChanges As New frmDailyTranInscrab
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub SaleInvoiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoiceToolStripMenuItem1.Click
        If ChildWindowOpen("frmSaleInvoice") = False Then
            Dim objUndoChanges1 As New frmSaleInvoice
            objUndoChanges1.MdiParent = Me
            objUndoChanges1.WindowState = FormWindowState.Maximized
            objUndoChanges1.Show()
        End If
    End Sub

    Private Sub SaleMaterialIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleMaterialIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmAutoSaleIssuance") = False Then
            Dim objUndoChanges11 As New frmAutoSaleIssuance
            objUndoChanges11.MdiParent = Me
            objUndoChanges11.WindowState = FormWindowState.Maximized
            objUndoChanges11.Show()
        End If
    End Sub

    Private Sub CustomerInfoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerInfoToolStripMenuItem1.Click
        If ChildWindowOpen("frmCustomer") = False Then
            Dim objCustomer As New frmCustomer
            objCustomer.MdiParent = Me
            objCustomer.WindowState = FormWindowState.Maximized
            objCustomer.Show()
        End If
    End Sub

    Private Sub CustomerItemsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerItemsToolStripMenuItem1.Click
        If ChildWindowOpen("frmCustItems") = False Then
            Dim objCustItems As New frmCustItems
            objCustItems.MdiParent = Me
            objCustItems.WindowState = FormWindowState.Maximized
            objCustItems.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem238_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem238.Click
        If ChildWindowOpen("frmRptSaleInvoice") = False Then
            Dim objRptSaleInvoice As New frmRptSaleInvoice
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem239_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem239.Click
        If ChildWindowOpen("frmUndoVerifyAfterComp") = False Then
            Dim objRptSaleInvoice1 As New frmUndoVerifyAfterComp
            objRptSaleInvoice1.MdiParent = Me
            objRptSaleInvoice1.WindowState = FormWindowState.Maximized
            objRptSaleInvoice1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem240_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem240.Click
        If ChildWindowOpen("frmUndoVerifyAfterComp") = False Then
            Dim objRptSaleInvoice1 As New frmUndoVerifyAfterComp
            objRptSaleInvoice1.MdiParent = Me
            objRptSaleInvoice1.WindowState = FormWindowState.Maximized
            objRptSaleInvoice1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem241_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem241.Click
        If ChildWindowOpen("frmCustomer") = False Then
            Dim objCustomer As New frmCustomer
            objCustomer.MdiParent = Me
            objCustomer.WindowState = FormWindowState.Maximized
            objCustomer.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem242_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem242.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptGatePasses
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem243_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem243.Click
        If ChildWindowOpen("frmLocalSale") = False Then
            Dim objRptSaleInvoice As New frmLocalSale
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.WindowState = FormWindowState.Maximized
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem244_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem244.Click
        If ChildWindowOpen("frmLocalSale") = False Then
            Dim objRptSaleInvoice As New frmLocalSale
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.WindowState = FormWindowState.Maximized
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem278_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem278.Click
        If ChildWindowOpen("frmDailyTranIn") = False Then
            Dim objUndoChanges As New frmDailyTranInscrab
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem283_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem283.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem285_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem285.Click
        If ChildWindowOpen("frmRptFilterTran") = False Then
            Dim objRptTran As New frmRptFilterTran
            objRptTran.MdiParent = Me
            objRptTran.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem286_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem286.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptFilterBalance
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem291_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem291.Click

    End Sub

    Private Sub ToolStripMenuItem246_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem246.Click
        ChangePasswordToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem247_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem247.Click
        logout()
    End Sub

    Private Sub MaterialEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialEntryToolStripMenuItem.Click
        AccessoriesMaterialToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem249_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem249.Click
        If ChildWindowOpen("frmDemandReports4Acc") = False Then
            Dim objDemandReports4Acc As New frmDemandReports4Acc
            objDemandReports4Acc.MdiParent = Me
            objDemandReports4Acc.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem250_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem250.Click
        If ChildWindowOpen("frmRptFilterBalance") = False Then
            Dim objRptSaleInvoice As New frmRptFilterBalance
            objRptSaleInvoice.MdiParent = Me
            objRptSaleInvoice.WindowState = FormWindowState.Maximized
            objRptSaleInvoice.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem252_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem252.Click
        If ChildWindowOpen("frmMiscReports4Purchase") = False Then
            Dim objMiscReport As New frmMiscReports4Purchase
            objMiscReport.MdiParent = Me
            objMiscReport.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem251_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem251.Click
        If ChildWindowOpen("frmDemandReports") = False Then
            Dim objDemandReports As New frmDemandReports11
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem253_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem253.Click
        If ChildWindowOpen("frmDemandReports4Ver") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver1
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub MaterialBillVerificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChildWindowOpen("frmbillingMatTran") = False Then
            Dim objDmdReport4ver1 As New frmbillingMatTran
            objDmdReport4ver1.MdiParent = Me
            objDmdReport4ver1.WindowState = FormWindowState.Maximized
            objDmdReport4ver1.Show()
        End If
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        If ChildWindowOpen("frmBillingTranNew") = False Then
            Dim objDmdReport14ver1 As New frmBillingTranNew
            objDmdReport14ver1.MdiParent = Me
            objDmdReport14ver1.WindowState = FormWindowState.Maximized
            objDmdReport14ver1.Show()
        End If
    End Sub

    Private Sub BillingPartyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem254_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem254.Click
        If ChildWindowOpen("frmRptBillingTranNew") = False Then
            Dim objDmdReport14ver1 As New frmRptBillingTranNew
            objDmdReport14ver1.MdiParent = Me
            objDmdReport14ver1.WindowState = FormWindowState.Maximized
            objDmdReport14ver1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem255_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem255.Click
        If ChildWindowOpen("frmRptFilterCode") = False Then
            Dim objRptCode As New frmRptFilterCode
            objRptCode.MdiParent = Me
            objRptCode.WindowState = FormWindowState.Maximized
            objRptCode.Show()
        End If
    End Sub

    Private Sub GatePassToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GatePassToolStripMenuItem1.Click
        GatePass()
    End Sub
    Private Sub GatePass()
        If ChildWindowOpen("frmGP") = False Then
            Dim objRptCode As New frmGP
            objRptCode.MdiParent = Me
            objRptCode.WindowState = FormWindowState.Maximized
            objRptCode.Show()
        End If
    End Sub
    Private Sub GatePassReport()
        If ChildWindowOpen("frmGPReports") = False Then
            Dim objRptCode1 As New frmGPReports
            objRptCode1.MdiParent = Me
            objRptCode1.WindowState = FormWindowState.Maximized
            objRptCode1.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem257_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem257.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem259_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem259.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem260_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem260.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem262_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem262.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem263_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem263.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem265_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem265.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem266_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem266.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem268_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem268.Click
        GatePass()

    End Sub

    Private Sub ToolStripMenuItem269_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem269.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem271_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem271.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem272_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem272.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem274_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem274.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem275_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem275.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem277_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem277.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem279_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem279.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem281_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem281.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem284_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem284.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem288_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem288.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem289_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem289.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem292_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem292.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem293_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem293.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem295_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem295.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem296_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem296.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem298_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem298.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem299_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem299.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem301_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem301.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem302_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem302.Click
        GatePassReport()
    End Sub

    Private Sub MaterialIssuanceArticleWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialIssuanceArticleWiseToolStripMenuItem.Click
        If ChildWindowOpen("frmRptArticle") = False Then
            Dim objfrmRptArticle As New frmRptArticle
            objfrmRptArticle.MdiParent = Me
            objfrmRptArticle.WindowState = FormWindowState.Maximized
            objfrmRptArticle.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem303_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem303.Click
        If ChildWindowOpen("frmRptArticle") = False Then
            Dim objfrmRptArticle As New frmRptArticle
            objfrmRptArticle.MdiParent = Me
            objfrmRptArticle.WindowState = FormWindowState.Maximized
            objfrmRptArticle.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem304_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem304.Click
        If ChildWindowOpen("frmRptArticle") = False Then
            Dim objfrmRptArticle As New frmRptArticle
            objfrmRptArticle.MdiParent = Me
            objfrmRptArticle.WindowState = FormWindowState.Maximized
            objfrmRptArticle.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem305_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem305.Click
        If ChildWindowOpen("frmRptArticle") = False Then
            Dim objfrmRptArticle As New frmRptArticle
            objfrmRptArticle.MdiParent = Me
            objfrmRptArticle.WindowState = FormWindowState.Maximized
            objfrmRptArticle.Show()
        End If
    End Sub
    'frmMaterialSale
    Private Sub ManualSaleIssuanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualSaleIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmSaleUndo") = False Then
            Dim objfrmRptArticle1 As New frmSaleUndo
            objfrmRptArticle1.MdiParent = Me
            objfrmRptArticle1.WindowState = FormWindowState.Maximized
            objfrmRptArticle1.Show()
        End If
    End Sub

    Private Sub MaterialDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmItemsData") = False Then
            Dim objfrmRptArticle11 As New frmItemsData
            objfrmRptArticle11.MdiParent = Me
            objfrmRptArticle11.WindowState = FormWindowState.Maximized
            objfrmRptArticle11.Show()
        End If
    End Sub

    Private Sub MaterialDataToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MaterialDataToolStripMenuItem.Click
        If ChildWindowOpen("frmItemsData") = False Then
            Dim objfrmRptArticle11 As New frmItemsData
            objfrmRptArticle11.MdiParent = Me
            objfrmRptArticle11.WindowState = FormWindowState.Maximized
            objfrmRptArticle11.Show()
        End If
    End Sub

    Private Sub MIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MIRToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptDeptWiseOut") = False Then
            Dim objRptDept As New frmRptDeptWiseOut
            objRptDept.MdiParent = Me
            objRptDept.WindowState = FormWindowState.Maximized
            objRptDept.Show()
        End If
    End Sub

    Private Sub BillingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingReportToolStripMenuItem.Click
        If ChildWindowOpen("frmRptBillingTranNew") = False Then
            Dim objDmdReport14ver1 As New frmRptBillingTranNew
            objDmdReport14ver1.MdiParent = Me
            objDmdReport14ver1.WindowState = FormWindowState.Maximized
            objDmdReport14ver1.Show()
        End If
    End Sub

    Private Sub GeneralDemandIssuanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralDemandIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmGDemandIssue") = False Then
            Dim objDmdReport14ver1 As New frmGDemandIssue
            objDmdReport14ver1.MdiParent = Me
            objDmdReport14ver1.WindowState = FormWindowState.Maximized
            objDmdReport14ver1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem306_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem306.Click
        If ChildWindowOpen("frmGDemandIssue") = False Then
            Dim objDmdReport14ver1 As New frmGDemandIssue
            objDmdReport14ver1.MdiParent = Me
            objDmdReport14ver1.WindowState = FormWindowState.Maximized
            objDmdReport14ver1.Show()
        End If
    End Sub

    Private Sub MRPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MRPToolStripMenuItem.Click
        If ChildWindowOpen("frmRptReq") = False Then
            Dim objRptReq As New frmRptMRP
            objRptReq.MdiParent = Me
            objRptReq.Show()
        End If
    End Sub

    Private Sub DailyMaterialTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyMaterialTransactionsToolStripMenuItem.Click
        If ChildWindowOpen("frmDailyTranAudit") = False Then
            Dim objRptReq As New frmDailyTranAudit
            objRptReq.MdiParent = Me
            objRptReq.WindowState = FormWindowState.Maximized
            objRptReq.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem308_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem308.Click
        If ChildWindowOpen("frmDailyTranAudit") = False Then
            Dim objRptReq As New frmDailyTranAudit
            objRptReq.MdiParent = Me
            objRptReq.WindowState = FormWindowState.Maximized
            objRptReq.Show()
        End If
    End Sub

    Private Sub MakerBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakerBillToolStripMenuItem.Click
        If ChildWindowOpen("frmRptMaker") = False Then
            Dim objRptReq1 As New frmRptMaker
            objRptReq1.MdiParent = Me
            objRptReq1.WindowState = FormWindowState.Maximized
            objRptReq1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem309_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem309.Click
        If ChildWindowOpen("frmDailyTranIn") = False Then
            Dim objUndoChanges As New frmDailyTranInscrab
            objUndoChanges.MdiParent = Me
            objUndoChanges.WindowState = FormWindowState.Maximized
            objUndoChanges.Show()
        End If
    End Sub

    Private Sub MakerBillToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MakerBillToolStripMenuItem1.Click
        If ChildWindowOpen("frmRptMaker") = False Then
            Dim objRptReq1 As New frmRptMaker
            objRptReq1.MdiParent = Me
            objRptReq1.WindowState = FormWindowState.Maximized
            objRptReq1.Show()
        End If
    End Sub

    Private Sub MakerNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakerNameToolStripMenuItem.Click
        If ChildWindowOpen("frmPrintTranIn") = False Then
            Dim objRptReq11 As New frmPrintTranIn
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem310_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem310.Click
        If ChildWindowOpen("frmPrintTranIn") = False Then
            Dim objRptReq11 As New frmPrintTranIn
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem312_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem312.Click
        If ChildWindowOpen("frmMatAdjustment") = False Then
            Dim objRptReq11 As New frmMatAdjustment
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem314_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem314.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem315_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem315.Click
        GatePassReport()

    End Sub

    Private Sub UndoCancelledMaterialRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoCancelledMaterialRequisitionToolStripMenuItem.Click
        If ChildWindowOpen("frmCancelledReq") = False Then
            Dim objRptReq11 As New frmCancelledReq
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem316_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem316.Click
        If ChildWindowOpen("frmCancelledReq") = False Then
            Dim objRptReq11 As New frmCancelledReq
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem317_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem317.Click
        If ChildWindowOpen("frmCancelledReq") = False Then
            Dim objRptReq11 As New frmCancelledReq
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem332_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem332.Click
        GatePass()
    End Sub

    Private Sub ToolStripMenuItem333_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem333.Click
        GatePassReport()
    End Sub

    Private Sub ToolStripMenuItem319_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem319.Click
        ChangePasswordToolStripMenuItem1_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem320_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem320.Click
        logout()
    End Sub



    Private Sub CreditAndDebitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreditAndDebitToolStripMenuItem2.Click
        If ChildWindowOpen("FrmCreditNew") = False Then
            Dim objRptReq11 As New FrmCreditNew
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ReturnMaterialReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnMaterialReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmNewTranIn") = False Then
            Dim objRptReq11 As New frmNewTranIn
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ReturnMaterialReceivingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReturnMaterialReceivingToolStripMenuItem1.Click
        If ChildWindowOpen("frmNewTranIn") = False Then
            Dim objRptReq11 As New frmNewTranIn
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub CatagoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatagoriesToolStripMenuItem.Click
        If ChildWindowOpen("FrmDMMSCat") = False Then
            Dim objRptReq11 As New FrmDMMSCat
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub DepartmentsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem2.Click
        If ChildWindowOpen("FrmDMMS_Dept") = False Then
            Dim objRptReq11 As New FrmDMMS_Dept
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub MachinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MachinesToolStripMenuItem.Click
        If ChildWindowOpen("Machines") = False Then
            Dim objRptReq11 As New Machines
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem322_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem322.Click
        If ChildWindowOpen("frmChngPswd") = False Then
            Dim objRptReq11 As New frmChngPswd
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem323_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem323.Click
        logout()
    End Sub

    Private Sub MachinesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MachinesToolStripMenuItem1.Click
        If ChildWindowOpen("Machines") = False Then
            Dim objRptReq11 As New Machines
            objRptReq11.MdiParent = Me

            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem326_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem326.Click
        If ChildWindowOpen("FrmDMMS_Dept") = False Then
            Dim objRptReq11 As New FrmDMMS_Dept
            objRptReq11.MdiParent = Me

            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem325_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem325.Click
        If ChildWindowOpen("FrmDMMSCat") = False Then
            Dim objRptReq11 As New FrmDMMSCat
            objRptReq11.MdiParent = Me

            objRptReq11.Show()
        End If
    End Sub

    Private Sub BatchNoEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatchNoEntryToolStripMenuItem.Click
        If ChildWindowOpen("batchIN") = False Then
            Dim objRptReq11 As New batchIN
            objRptReq11.MdiParent = Me

            objRptReq11.Show()
        End If
    End Sub

    Private Sub DemandProcessReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemandProcessReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandReports") = False Then
            Dim objDemandReports As New frmDemandReports11
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem324_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem324.Click

    End Sub

    Private Sub MachinePartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MachinePartsToolStripMenuItem.Click
        If ChildWindowOpen("FrmMachineparts") = False Then
            Dim objDemandReports As New FrmMachineparts
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub BGradeWestageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BGradeWestageToolStripMenuItem.Click
        If ChildWindowOpen("FrmArticleWiseWestage") = False Then
            Dim objDemandReports As New FrmArticleWiseWestage
            objDemandReports.MdiParent = Me
            objDemandReports.Show()
        End If
    End Sub

    Private Sub SalesMaterialIssuanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesMaterialIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("frmAutoSaleIssuance") = False Then
            Dim objUndoChanges11 As New frmAutoSaleIssuance
            objUndoChanges11.MdiParent = Me
            objUndoChanges11.WindowState = FormWindowState.Maximized
            objUndoChanges11.Show()
        End If
    End Sub

    Private Sub GateInwardAndOutWardReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GateInwardAndOutWardReportsToolStripMenuItem.Click
        If ChildWindowOpen("Reports") = False Then
            Dim objUndoChanges11 As New Reports
            objUndoChanges11.MdiParent = Me
            objUndoChanges11.WindowState = FormWindowState.Maximized
            objUndoChanges11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem329_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem329.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem328_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem328.Click
        If ChildWindowOpen("frmChngPswd") = False Then
            Dim objRptReq11 As New frmChngPswd
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub MaterialToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MaterialToolStripMenuItem2.Click
        If ChildWindowOpen("FrmmatReports") = False Then
            Dim objRptReq11 As New FrmmatReports
            objRptReq11.MdiParent = Me
            objRptReq11.WindowState = FormWindowState.Maximized
            objRptReq11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem330_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem330.Click
        If ChildWindowOpen("frmRptScrapeSale") = False Then
            Dim objPRRN11 As New frmRptScrapeSale
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ChamicalMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChamicalMaterialToolStripMenuItem.Click
        If ChildWindowOpen("newFrmMpMat") = False Then
            Dim objPRRN11 As New newFrmMpMat
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ManualRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualRequisitionToolStripMenuItem.Click
        If ChildWindowOpen("newFrmMpMat") = False Then
            Dim objPRRN11 As New newFrmMpMat
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub BatchNoEntryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BatchNoEntryToolStripMenuItem1.Click
        If ChildWindowOpen("batchIN") = False Then
            Dim objPRRN11 As New batchIN
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem334_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem334.Click
        If ChildWindowOpen("batchIN") = False Then
            Dim objPRRN11 As New batchIN
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub MaterialInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialInformationToolStripMenuItem.Click
        If ChildWindowOpen("FrmMaterialType") = False Then
            Dim objPRRN11 As New FrmMaterialType
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub TestCatalogsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Frmtestcatalog") = False Then
            Dim objPRRN11 As New Frmtestcatalog
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub DailyMaterialReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyMaterialReceivedToolStripMenuItem.Click
        If ChildWindowOpen("FrmDailyIN") = False Then
            Dim objPRRN11 As New FrmDailyIN
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub MaterialWiseTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialWiseTestToolStripMenuItem.Click
        If ChildWindowOpen("FrmVendors") = False Then
            Dim objPRRN11 As New FrmVendors
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem336_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem336.Click
        If ChildWindowOpen("FrmMaterialType") = False Then
            Dim objPRRN11 As New FrmMaterialType
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem337_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem337.Click
        If ChildWindowOpen("Frmtestcatalog") = False Then
            Dim objPRRN11 As New Frmtestcatalog
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem338_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem338.Click
        If ChildWindowOpen("FrmSupplipers") = False Then
            Dim objPRRN11 As New FrmSupplipers
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem339_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem339.Click
        If ChildWindowOpen("FrmFITMATIN") = False Then
            Dim objPRRN11 As New FrmFITMATIN
            objPRRN11.MdiParent = Me
            objPRRN11.WindowState = FormWindowState.Maximized
            objPRRN11.Show()
        End If
    End Sub

    Private Sub MRPDispatchReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MRPDispatchReportsToolStripMenuItem1.Click
        If ChildWindowOpen("FrmRptMRPD") = False Then
            Dim objRptPOReq As New FrmRptMRPD
            objRptPOReq.MdiParent = Me
            objRptPOReq.Show()
        End If
    End Sub

    Private Sub INWardVerficationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INWardVerficationToolStripMenuItem.Click
        If ChildWindowOpen("Form1") = False Then
            Dim objRptPOReq As New Form1
            objRptPOReq.MdiParent = Me
            objRptPOReq.WindowState = FormWindowState.Maximized
            objRptPOReq.Show()
        End If
    End Sub

    Private Sub InWardVerficationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InWardVerficationToolStripMenuItem1.Click
        If ChildWindowOpen("FrmBillingGMVerfication") = False Then
            Dim objRptPOReq As New FrmBillingGMVerfication
            objRptPOReq.MdiParent = Me
            objRptPOReq.WindowState = FormWindowState.Maximized
            objRptPOReq.Show()
        End If
    End Sub

    Private Sub DailyMaterialIssuanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyMaterialIssuanceToolStripMenuItem.Click
        If ChildWindowOpen("FrmmaterialIssuance") = False Then
            Dim objRptPOReq As New FrmmaterialIssuance
            objRptPOReq.MdiParent = Me
            objRptPOReq.WindowState = FormWindowState.Maximized
            objRptPOReq.Show()
        End If
    End Sub

    Private Sub DemandReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DemandReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmDemandReports4Ver") = False Then
            Dim objDmdReport4ver As New frmDemandReports4Ver
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub DailyMaterialIssuanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DailyMaterialIssuanceToolStripMenuItem1.Click
        If ChildWindowOpen("FrmMPNoWise") = False Then
            Dim objDmdReport4ver As New FrmMPNoWise
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub DailyMaterialIssuanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyMaterialIssuanceReportToolStripMenuItem.Click
        If ChildWindowOpen("FrmMPNoWise") = False Then
            Dim objDmdReport4ver As New FrmMPNoWise
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    Private Sub DailyMaterialIssuanceReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DailyMaterialIssuanceReportToolStripMenuItem1.Click
        If ChildWindowOpen("FrmMPNoWise") = False Then
            Dim objDmdReport4ver As New FrmMPNoWise
            objDmdReport4ver.MdiParent = Me
            objDmdReport4ver.WindowState = FormWindowState.Maximized
            objDmdReport4ver.Show()
        End If
    End Sub

    'Private Sub CustomerItemsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CustomerItemsToolStripMenuItem2.Click
    '    If ChildWindowOpen("frmCustItems") = False Then
    '        Dim objCustItems As New frmCustItems
    '        objCustItems.MdiParent = Me
    '        objCustItems.WindowState = FormWindowState.Maximized
    '        objCustItems.Show()
    '    End If
    'End Sub

    'Private Sub CustomerItemsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CustomerItemsToolStripMenuItem3.Click
    '    If ChildWindowOpen("frmCustItems") = False Then
    '        Dim objCustItems As New frmCustItems
    '        objCustItems.MdiParent = Me
    '        objCustItems.WindowState = FormWindowState.Maximized
    '        objCustItems.Show()
    '    End If
    'End Sub

    Private Sub CustomerItemsToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CustomerItemsToolStripMenuItem4.Click
        If ChildWindowOpen("frmCustItems") = False Then
            Dim objCustItems As New frmCustItems
            objCustItems.MdiParent = Me
            objCustItems.WindowState = FormWindowState.Maximized
            objCustItems.Show()
        End If
    End Sub

    Private Sub DailyAGradeMaterialInwardEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyAGradeMaterialInwardEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmDailyTranIn") = False Then
            Dim objCustItems As New frmDailyTranIn
            objCustItems.MdiParent = Me
            objCustItems.WindowState = FormWindowState.Maximized
            objCustItems.Show()
        End If
    End Sub

    Private Sub GatePassCancelationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GatePassCancelationToolStripMenuItem.Click
        If ChildWindowOpen("CancelationGP") = False Then
            Dim objQRCut As New CancelationGP
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub DailyGatepassForWeightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyGatepassForWeightToolStripMenuItem.Click
        If ChildWindowOpen("FrmNewScrab") = False Then
            Dim objQRCut As New FrmNewScrab
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub DemandIssuanceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DemandIssuanceToolStripMenuItem2.Click
        If ChildWindowOpen("frmDemandApproval") = False Then
            Dim objQRCut As New frmDemandApproval
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GeneralStockEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralStockEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmNewTranIn") = False Then
            Dim objQRCut As New frmNewTranIn
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub UserAndDepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAndDepartmentsToolStripMenuItem.Click
        If ChildWindowOpen("FrmuserDept") = False Then
            Dim objQRCut As New FrmuserDept
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GMApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GMApprovalToolStripMenuItem.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GMAprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GMAprovalToolStripMenuItem.Click
        If ChildWindowOpen("FrmGM") = False Then
            Dim objQRCut As New FrmGM
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub HODApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HODApprovalToolStripMenuItem.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GMApprovalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GMApprovalToolStripMenuItem1.Click
        If ChildWindowOpen("FrmGM") = False Then
            Dim objQRCut As New FrmGM
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GPApprovalToolStripMenuItem.Click
        If ChildWindowOpen("frmGPVerify") = False Then
            Dim objQRCut As New frmGPVerify
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GMOfficialApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GMOfficialApprovalToolStripMenuItem.Click
        If ChildWindowOpen("FrmGM") = False Then
            Dim objQRCut As New FrmGM
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem1.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem2.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem3.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem4.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem5.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem13.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem12.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    'Private Sub GPVerificationByHODToolStripMenuItem11_Click(sender As Object, e As EventArgs)
    '    If ChildWindowOpen("FrmHOD") = False Then
    '        Dim objQRCut As New FrmHOD
    '        objQRCut.MdiParent = Me
    '        objQRCut.WindowState = FormWindowState.Maximized
    '        objQRCut.Show()
    '    End If
    'End Sub

    Private Sub GPVerificationByHODToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem10.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem294_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem294.Click

    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem8.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem7.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GPVerificationByHODToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles GPVerificationByHODToolStripMenuItem6.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub HODApprovalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HODApprovalToolStripMenuItem1.Click
        If ChildWindowOpen("FrmHOD") = False Then
            Dim objQRCut As New FrmHOD
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub GMOfficialApprovalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GMOfficialApprovalToolStripMenuItem1.Click
        If ChildWindowOpen("FrmGM") = False Then
            Dim objQRCut As New FrmGM
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub DemandItemsUpdationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemandItemsUpdationToolStripMenuItem.Click
        If ChildWindowOpen("FrmDemandsupdatation") = False Then
            Dim objQRCut As New FrmDemandsupdatation
            objQRCut.MdiParent = Me
            objQRCut.WindowState = FormWindowState.Maximized
            objQRCut.Show()
        End If
    End Sub

    Private Sub DemandToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DemandToolStripMenuItem1.Click
        If ChildWindowOpen("frmDemandRec") = False Then
            Dim objDemand As New frmDemandRecPurchase
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandAuditVerficationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemandAuditVerficationToolStripMenuItem.Click
        If ChildWindowOpen("frmAuditVerficationDemand") = False Then
            Dim objDemand As New frmAuditVerficationDemand
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandIssuanceToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DemandIssuanceToolStripMenuItem3.Click
        If ChildWindowOpen("FrmNewIssuance") = False Then
            Dim objDemand As New FrmNewIssuance
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemandReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandRecPurchase") = False Then
            Dim objDemand As New frmDemandRecPurchase
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandVerficationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemandVerficationToolStripMenuItem.Click
        If ChildWindowOpen("frmAuditVerficationDemand") = False Then
            Dim objDemand As New frmAuditVerficationDemand
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandIssuanceToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DemandIssuanceToolStripMenuItem4.Click
        If ChildWindowOpen("FrmNewIssuance") = False Then
            Dim objDemand As New FrmNewIssuance
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandProcessingReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemandProcessingReportsToolStripMenuItem.Click
        If ChildWindowOpen("NewDemandreports") = False Then
            Dim objDemand As New NewDemandreports
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandReportsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DemandReportsToolStripMenuItem2.Click

        If ChildWindowOpen("NewDemandsreportsAcc1") = False Then
            Dim objDemand As New NewDemandsreportsAcc1
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub IDMSSubDeptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDMSSubDeptToolStripMenuItem.Click
        If ChildWindowOpen("IDMS_User_Dept") = False Then
            Dim objDemand As New IDMS_User_Dept
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem6.Click

    End Sub

    Private Sub DemandReceivingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DemandReceivingToolStripMenuItem1.Click
        If ChildWindowOpen("frmDemandRecPurchase") = False Then
            Dim objDemand As New frmDemandRecPurchase
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub DemandIssuanceToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles DemandIssuanceToolStripMenuItem5.Click
        If ChildWindowOpen("FrmNewIssuance") = False Then
            Dim objDemand As New FrmNewIssuance
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub AssertsTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssertsTypeToolStripMenuItem.Click
        If ChildWindowOpen("Frm_Asserts_type") = False Then
            Dim objDemand As New Frm_Asserts_type
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub OriginalLifeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OriginalLifeToolStripMenuItem.Click
        If ChildWindowOpen("FrmORG_Life") = False Then
            Dim objDemand As New FrmORG_Life
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub AddAssertsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssertsToolStripMenuItem.Click
        If ChildWindowOpen("FrmAsserts") = False Then
            Dim objDemand As New FrmAsserts
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub NewDemandReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDemandReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmNewDemandCompletion") = False Then
            Dim objDemand As New frmNewDemandCompletion
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub ArticleNetWeightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticleNetWeightToolStripMenuItem.Click
        If ChildWindowOpen("FrmMatArticle") = False Then
            Dim objDemand As New FrmMatArticle
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem341_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem341.Click
        If ChildWindowOpen("frmChngPswd") = False Then
            Dim objDemand As New frmChngPswd
            objDemand.MdiParent = Me
            objDemand.WindowState = FormWindowState.Maximized
            objDemand.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem342_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem342.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem344_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem344.Click
        If ChildWindowOpen("FrmEDM") = False Then
            Dim objPurOrders As New FrmEDM
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub GeneratePOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GeneratePOToolStripMenuItem1.Click
        If ChildWindowOpen("FrmEDM") = False Then
            Dim objPurOrders As New FrmEDM
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        If ChildWindowOpen("frmSuppliers") = False Then
            Dim objSuppliers As New frmSuppliers
            objSuppliers.MdiParent = Me
            objSuppliers.Show()
        End If
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        If ChildWindowOpen("frmSupItems") = False Then
            Dim objSupItems As New frmSupItems
            objSupItems.MdiParent = Me
            objSupItems.Show()
        End If
    End Sub

    Private Sub OLDDemandReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OLDDemandReceivingToolStripMenuItem.Click
        If ChildWindowOpen("frmNewDemandCompletion") = False Then
            Dim objDemandCompletion As New frmNewDemandCompletion
            objDemandCompletion.MdiParent = Me
            objDemandCompletion.WindowState = FormWindowState.Maximized
            objDemandCompletion.Show()
        End If
    End Sub

    Private Sub OLDDemandProcessingReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OLDDemandProcessingReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmDemandReports11") = False Then
            Dim objDemandCompletion As New frmDemandReports11
            objDemandCompletion.MdiParent = Me
            objDemandCompletion.WindowState = FormWindowState.Maximized
            objDemandCompletion.Show()
        End If
    End Sub

    Private Sub MaterialCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialCodeToolStripMenuItem.Click
        If ChildWindowOpen("frmCode") = False Then
            Dim Code As New frmCode
            Code.MdiParent = Me
            Code.WindowState = FormWindowState.Maximized
            Code.Show()
        End If
    End Sub

    Private Sub VendorInfomationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorInfomationToolStripMenuItem.Click
        If ChildWindowOpen("frmPurVendorInfo") = False Then
            Dim objWindedBladderProcess1111 As New frmPurVendorInfo
            objWindedBladderProcess1111.MdiParent = Me
            objWindedBladderProcess1111.WindowState = FormWindowState.Maximized
            objWindedBladderProcess1111.Show()
        End If
    End Sub

    Private Sub GeneratePOsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GeneratePOsToolStripMenuItem1.Click
        If ChildWindowOpen("frmPurOrders") = False Then
            Dim objPurOrders As New frmPurOrders
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub CompanyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyProfileToolStripMenuItem.Click
        If ChildWindowOpen("FrmCompany") = False Then
            Dim objPurOrders As New FrmCompany
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub

    Private Sub GPVerifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GPVerifyToolStripMenuItem.Click
        If ChildWindowOpen("frmGPVerify") = False Then
            Dim objPurOrders As New frmGPVerify
            objPurOrders.MdiParent = Me
            objPurOrders.WindowState = FormWindowState.Maximized
            objPurOrders.Show()
        End If
    End Sub
End Class