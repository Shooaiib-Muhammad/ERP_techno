Imports System.Net
Imports System.IO
Public Class frmLoginVer
    Dim ModID As Integer = 1
    Dim DomID As Integer
    Public Shared DeptID As Integer
    Public Shared UserID As Integer
    Public Shared LoginName As String = Nothing
    Public Shared SysIP As String = Nothing
    'Dim HostName As String = Dns.GetHostName
    'Dim ipEntry As IPHostEntry = Dns.GetHostEntry(HostName)
    'Dim IpAddr As IPAddress() = ipEntry.AddressList
    Dim Counter As Integer = 0
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Tbl_User_LoginsTableAdapter.Fill(Me.DSUM.tbl_User_Logins)
        Me.View_User_AccountsTableAdapter.Fill(Me.DSUM.View_User_Accounts)
        Me.Tbl_User_DomainTableAdapter.FillBy(Me.DSUM.tbl_User_Domain, ModID)
        'Me.Tbl_User_LogTableAdapter.Fill(Me.DSUM.tbl_User_Log)
        frmMain.CModID = ModID
        Dim MyIP As String = Nothing
        Dim UserStatus As String = Nothing
        MyIP = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        UserStatus = Me.Tbl_User_LoginsTableAdapter.GetUserStatus(MyIP)
        If UserStatus Is Nothing Then
            DeptID = 63
            UserID = 190
            Me.DepartmentIDComboBox.SelectedValue = DeptID
            Me.UserIDComboBox.SelectedValue = UserID
        ElseIf Not UserStatus Is Nothing Then
            If Me.Tbl_User_LoginsTableAdapter.GetUserStatus(MyIP) = True Then
                UserID = Me.Tbl_User_LoginsTableAdapter.GetUserID(MyIP)
                DeptID = Me.View_User_AccountsTableAdapter.GetUserDeptID(UserID, 2)
                Me.txtPswd.Select()
                Me.DepartmentIDComboBox.SelectedValue = DeptID
                Me.UserIDComboBox.SelectedValue = UserID
            Else
                MsgBox("User Account is Disabled." & vbCrLf & "Contact to ERP Administrator for More Detail", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Sub MenueSecurity(ByVal Value As Boolean)
        frmMain.MenuStripMMITAdmin.Enabled = Value
        frmMain.MenuStripAudit.Enabled = Value
        frmMain.MenuStripF7.Enabled = Value
        frmMain.MenuStripDispatch.Enabled = Value
        frmMain.MenuStripInventory.Enabled = Value
        frmMain.MenuStripInventoryAdmin.Enabled = Value
        frmMain.MenuStripMMNonAdidas.Enabled = Value
        frmMain.MenuStripMatDemand.Enabled = Value
        frmMain.MenuStripMaterialVerification.Enabled = Value
        frmMain.MenuStripMatPurchase.Enabled = Value
        frmMain.MenuStripRawMaterial.Enabled = Value
        frmMain.MenuStripVerification.Enabled = Value
        frmMain.MenuStripAccounts.Enabled = Value
        frmMain.MenuStripInventoryReports.Enabled = Value
        frmMain.Export.Enabled = Value
        frmMain.ProcurementReport.Enabled = Value
        frmMain.MenuStripAcc.Enabled = Value
        frmMain.GP.Enabled = Value
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
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim DBPswd As String
        Dim PSWDate As Date
        Dim DateDiff1 As Integer
        Dim dgResult As DialogResult
        Dim SysIpAdd As String = Nothing
        Dim HODStatus As Boolean
        Dim SPrStatus As Boolean
        Dim GPVerifyStatus As Boolean
        Dim DBIpAdd As String = Nothing
        Dim SPStatus As String = Nothing
        Dim LogStatus As Integer
        DomID = Me.DepartmentIDComboBox.SelectedValue
        UserID = Me.UserIDComboBox.SelectedValue
        frmMain.CDomID = DomID
        frmMain.CUserID = UserID
        DBIpAdd = Me.Tbl_User_LoginsTableAdapter.GetUserIP(UserID)
        'SysIpAdd = IpAddr(0).ToString
        SysIpAdd = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        'SPStatus = IIf(Me.Tbl_User_LoginsTableAdapter.GetUserSpStatus(UserID).HasValue = True, Me.Tbl_User_LoginsTableAdapter.GetUserSpStatus(UserID), False)
        Try
            SPStatus = Me.Tbl_User_LoginsTableAdapter.GetUserSpStatus(UserID)
            If SPStatus = Nothing Then
                SPStatus = False
            End If
        Catch ex As Exception
            SPStatus = False
        End Try
        If DBIpAdd = SysIpAdd Or SPStatus = True Then
            DBPswd = Me.Tbl_User_LoginsTableAdapter.GetUserPswd(UserID)
            PSWDate = Me.Tbl_User_LoginsTableAdapter.PSWDate(UserID)
            If String.Compare(DBPswd, txtPswd.Text) = 0 Then
                'LogStatus = IIf(Me.Tbl_User_LogTableAdapter.GetUserStatus(ModID, DomID, UserID).HasValue = False, 0, Me.Tbl_User_LogTableAdapter.GetUserStatus(ModID, DomID, UserID))
                Try
                    LogStatus = Me.Tbl_User_LogTableAdapter.GetUserStatus(ModID, DomID, UserID)
                Catch ex As Exception
                    LogStatus = 1
                End Try
                'Check here
                If UserID = 1 Or UserID = 3 Or UserID = 310 Then
                    LogStatus = 0
                End If
                DateDiff1 = DateDiff(DateInterval.Day, PSWDate, Now.Date)
                If DateDiff1 >= 120 Then
                    LogStatus = 2
                    MsgBox("Your ERP Password has been Expired" & vbCrLf & " Please Change Your ERP Password")
                    Me.Close()
                    If ChildWindowOpen("frmChngPswd") = False Then
                        Dim objChngPswd As New frmChngPswd
                        'objChngPswd.MdiParent = Me
                        objChngPswd.Show()
                    End If
                ElseIf DateDiff1 >= 110 Then
                    Dim BtnMsg As DialogResult = MessageBox.Show("Your ERP Password will be Expired After " & 120 - DateDiff1 & " days. Please Change Your ERP Password " & vbCrLf & "Are You Sure Want To Change ERP Password Now ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    If BtnMsg = Windows.Forms.DialogResult.Yes Then
                        LogStatus = 2
                        Me.Close()
                        If ChildWindowOpen("frmChngPswd") = False Then
                            Dim objChngPswd As New frmChngPswd
                            'objChngPswd.MdiParent = Me
                            objChngPswd.Show()
                        End If
                    End If
                End If

                If LogStatus = 0 Then
                    SysIP = SysIpAdd
                    LoginName = Me.UserIDComboBox.Text
                    Me.Tbl_User_LoginsTableAdapter.FillBy(Me.DSUM.tbl_User_Logins, UserIDComboBox.SelectedValue)
                    HODStatus = Me.DSUM.tbl_User_Logins(0).Item("HODStatus")
                    SPrStatus = Me.DSUM.tbl_User_Logins(0).Item("SprStatus")
                    GPVerifyStatus = Me.DSUM.tbl_User_Logins(0).Item("GPVerifyStatus")
                    dgResult = MessageBox.Show("Welcome " & Me.DSUM.tbl_User_Logins(0).Item(1) & " " & Me.DSUM.tbl_User_Logins(0).Item(2) & vbCrLf & "You have been Successfully Logged-In." & vbCrLf & "Press OK to continue", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    MenueSecurity(True)
                    If dgResult = Windows.Forms.DialogResult.OK Then
                        If Me.DepartmentIDComboBox.SelectedValue = 2 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripMMITAdmin
                            frmMain.MenuStripMMITAdmin.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            'frmMain.ToolStripMenuItem88.ShowDropDown()
                            'frmMain.SaleToolStripMenuItem.ShowDropDown()
                            'frmMain.InventryToolStripMenuItem.ShowDropDown()
                            'frmMain.LOMToolStripMenuItem.ShowDropDown()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 20 Then
                            If UserID = 139 Or UserID = 281 Or UserID = 338 Then
                                DeptID = Me.DepartmentIDComboBox.SelectedValue
                                frmMain.MainMenuStrip = frmMain.MenuStripF7
                                If HODStatus = True Then '' HOD Approval
                                    frmMain.GPVerificationByHODToolStripMenuItem13.Visible = True
                                Else
                                    frmMain.GPVerificationByHODToolStripMenuItem13.Visible = False
                                    If UserID = 338 Then
                                        frmMain.MaterialEntryToolStripMenuItem.Visible = False
                                        frmMain.ToolStripMenuItem278.Visible = True
                                        frmMain.DailyAGradeMaterialInwardEntryToolStripMenuItem.Visible = False
                                        frmMain.MakerNameToolStripMenuItem.Visible = False
                                        frmMain.ToolStripMenuItem282.Visible = True
                                        frmMain.BGradeWestageToolStripMenuItem.Visible = False
                                        frmMain.SalesMaterialIssuanceToolStripMenuItem.Visible = False
                                        frmMain.ToolStripMenuItem283.Visible = False
                                        frmMain.ToolStripMenuItem285.Visible = False
                                        frmMain.ToolStripMenuItem286.Visible = True
                                        frmMain.ToolStripMenuItem291.Visible = False
                                        frmMain.MakerBillToolStripMenuItem.Visible = False
                                    Else
                                        frmMain.MaterialEntryToolStripMenuItem.Visible = True
                                        frmMain.ToolStripMenuItem278.Visible = True
                                        frmMain.DailyAGradeMaterialInwardEntryToolStripMenuItem.Visible = True
                                        frmMain.MakerNameToolStripMenuItem.Visible = True
                                        frmMain.ToolStripMenuItem282.Visible = True
                                        frmMain.BGradeWestageToolStripMenuItem.Visible = True
                                        frmMain.SalesMaterialIssuanceToolStripMenuItem.Visible = True
                                        frmMain.ToolStripMenuItem283.Visible = True
                                        frmMain.ToolStripMenuItem285.Visible = True
                                        frmMain.ToolStripMenuItem286.Visible = True
                                        frmMain.ToolStripMenuItem291.Visible = True
                                        frmMain.MakerBillToolStripMenuItem.Visible = True
                                    End If
                                End If

                                frmMain.MenuStripF7.Show()
                                frmMain.Show()
                                frmMain.MainMenu.Hide()
                                Me.Hide()
                                txtPswd.Clear()
                            Else

                                DeptID = Me.DepartmentIDComboBox.SelectedValue
                                frmMain.MainMenuStrip = frmMain.MenuStripInventory
                                If HODStatus = True Then
                                    frmMain.GPVerificationByHODToolStripMenuItem.Visible = True
                                Else
                                    frmMain.GPVerificationByHODToolStripMenuItem.Visible = False

                                End If
                                frmMain.MenuStripInventory.Show()
                                frmMain.Show()
                                frmMain.MainMenu.Hide()
                                Me.Hide()
                                txtPswd.Clear()
                            End If

                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 7 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripInventoryAdmin
                            If UserID = 59 Or UserID = 91 Or UserID = 8 Then
                                frmMain.ToolStripMenuItem12.Visible = True
                                frmMain.AccessoriesMaterialToolStripMenuItem1.Visible = True
                            Else
                                frmMain.ToolStripMenuItem12.Visible = False
                                frmMain.AccessoriesMaterialToolStripMenuItem1.Visible = False
                            End If
                            If HODStatus = True Then
                                frmMain.GPVerificationByHODToolStripMenuItem1.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem1.Visible = False
                            End If
                            If UserID = 9 Or UserID = 106 Or UserID = 8 Then
                                frmMain.ToolStripMenuItem192.Visible = True
                                frmMain.BladderBillingTransactionReportsToolStripMenuItem1.Visible = True
                                frmMain.ToolStripMenuItem195.Visible = True
                                frmMain.ToolStripMenuItem196.Visible = True
                            Else
                                frmMain.ToolStripMenuItem192.Visible = False
                                frmMain.ToolStripMenuItem195.Visible = False
                                frmMain.ToolStripMenuItem196.Visible = False
                                frmMain.BladderBillingTransactionReportsToolStripMenuItem1.Visible = False
                            End If
                            If UserID = 8 Then
                                frmMain.UOMConversionEntryToolStripMenuItem2.Visible = True
                            Else
                                frmMain.UOMConversionEntryToolStripMenuItem2.Visible = False
                            End If
                            frmMain.MenuStripInventoryAdmin.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 90 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.Export
                            frmMain.Export.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 8 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripDispatch
                            If HODStatus = True Then

                                frmMain.GPVerificationByHODToolStripMenuItem2.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem2.Visible = False


                            End If
                            frmMain.MenuStripDispatch.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 107 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripAcc
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem12.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem12.Visible = False
                            End If
                            frmMain.MenuStripAcc.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 122 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.GP
                            If HODStatus = True Then '' HOD Approval
                                frmMain.HODApprovalToolStripMenuItem.Visible = True
                            Else
                                frmMain.HODApprovalToolStripMenuItem.Visible = False
                            End If
                            If SPrStatus = True Then ' GM Approval
                                frmMain.GMApprovalToolStripMenuItem1.Visible = True
                            Else
                                frmMain.GMApprovalToolStripMenuItem1.Visible = False
                            End If
                            If GPVerifyStatus = True Then ' GP Working
                                frmMain.GPApprovalToolStripMenuItem.Visible = True
                            Else
                                frmMain.GPApprovalToolStripMenuItem.Visible = False
                            End If
                            If UserID = 88 Or UserID = 2 Then ' Article Wise Working
                                frmMain.ArticleNetWeightToolStripMenuItem.Visible = True
                            Else
                                frmMain.ArticleNetWeightToolStripMenuItem.Visible = False
                            End If
                            frmMain.GP.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 21 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripInventoryReports
                            If HODStatus = True Then '' HOD Approval
                                frmMain.HODApprovalToolStripMenuItem1.Visible = True
                            Else
                                frmMain.HODApprovalToolStripMenuItem1.Visible = False
                            End If
                            If SPrStatus = True Then '' GM / official Approval
                                frmMain.GMOfficialApprovalToolStripMenuItem1.Visible = True
                            Else
                                frmMain.GMOfficialApprovalToolStripMenuItem1.Visible = False
                            End If
                            frmMain.MenuStripInventoryReports.Show()
                            If UserID = 10 Or UserID = 9 Then
                                ShowStrip(False)
                            Else
                                ShowStrip(True)
                            End If
                            If UserID = 184 Or UserID = 69 Then
                                frmMain.ToolStripMenuItem311.Visible = True

                            Else
                                frmMain.ToolStripMenuItem311.Visible = False
                            End If
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 69 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripAudit
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem8.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem8.Visible = False
                            End If
                            If UserID = 90 Then
                                frmMain.MaterialAdjustmentToolStripMenuItem1.Visible = False
                            Else
                                frmMain.MaterialAdjustmentToolStripMenuItem1.Visible = True
                            End If
                            If UserID = 74 Then
                                frmMain.BillingPaymentTransactionsToolStripMenuItem.Visible = True
                            Else
                                frmMain.BillingPaymentTransactionsToolStripMenuItem.Visible = True
                            End If
                            frmMain.ToolStripMenuItem240.Visible = True
                            'frmBillingTranNewUndoVerifying
                            frmMain.MenuStripAudit.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 22 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripMatDemand
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem7.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem7.Visible = False
                            End If
                            frmMain.MenuStripMatDemand.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 24 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripMatPurchase
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem6.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem6.Visible = False
                            End If
                            frmMain.MenuStripMatPurchase.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 25 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripRawMaterial
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem3.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem3.Visible = False
                            End If
                            frmMain.MenuStripRawMaterial.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 26 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripMaterialVerification
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem5.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem5.Visible = False
                            End If
                            frmMain.MenuStripMaterialVerification.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 27 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripInventory
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem4.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem4.Visible = False
                            End If
                            frmMain.MenuStripVerification.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 29 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripAccounts
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem9.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem9.Visible = False
                            End If
                            frmMain.MenuStripAccounts.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 105 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.ProcurementReport
                            frmMain.ProcurementReport.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 72 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuStripMMNonAdidas
                            If HODStatus = True Then '' HOD Approval
                                frmMain.GPVerificationByHODToolStripMenuItem10.Visible = True
                            Else
                                frmMain.GPVerificationByHODToolStripMenuItem10.Visible = False
                            End If
                            frmMain.MenuStripMMNonAdidas.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 125 Then
                            frmMain.MainMenuStrip = frmMain.MenuStripMMNonAdidas
                            frmMain.DMMS.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 126 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.MenuSecrity
                            frmMain.MenuSecrity.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        ElseIf Me.DepartmentIDComboBox.SelectedValue = 129 Then
                            DeptID = Me.DepartmentIDComboBox.SelectedValue
                            frmMain.MainMenuStrip = frmMain.EDM
                            frmMain.EDM.Show()
                            frmMain.Show()
                            frmMain.MainMenu.Hide()
                            Me.Hide()
                            txtPswd.Clear()
                        End If
                        frmMain.CloginStatus = True
                        'If DomID = 1 Or DomID = 7 Or DomID = 26 Or UserID = 30 Or UserID = 51 Then
                        'Else
                        Me.Tbl_User_LogTableAdapter.Insert(ModID, DomID, UserID, Now, Nothing)
                        'End If
                        Me.Close()
                    Else
                        txtPswd.Clear()
                        Me.Tbl_User_LoginsTableAdapter.Fill(Me.DSUM.tbl_User_Logins)
                    End If
                ElseIf LogStatus > 2 Then
                    MsgBox("Your Account has been Locked due to Improper Shutdown Software." & vbCrLf & "Please contact ERP administrator to unlock.")
                    txtPswd.Clear()
                End If
            Else
                MsgBox("Domain OR User Name OR Password is Incorrect", MsgBoxStyle.Exclamation)
                txtPswd.Clear()
                txtPswd.Focus()
            End If
        Else
            MsgBox("User Authentication failed.", MsgBoxStyle.Critical)
        End If
      
    End Sub
    Sub ShowStrip(ByVal Show As Boolean)
        frmMain.ToolStripMenuItem167.Visible = Show
        frmMain.ToolStripMenuItem168.Visible = Show
        frmMain.ToolStripMenuItem169.Visible = Show
        frmMain.ToolStripMenuItem170.Visible = True
        frmMain.ToolStripMenuItem171.Visible = Show
        frmMain.ToolStripMenuItem172.Visible = Show
        frmMain.ToolStripMenuItem173.Visible = Show
    End Sub
    Public Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        MenueSecurity(False)
    End Sub
End Class