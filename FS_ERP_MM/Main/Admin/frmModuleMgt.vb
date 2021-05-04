Public Class frmModuleMgt
    Private Sub Tbl_User_ERP_ModBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_User_ERP_ModBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_User_ERP_ModBindingSource.EndEdit()
        Me.Tbl_User_ERP_ModTableAdapter.Update(Me.DSUM.tbl_User_ERP_Mod)
        Me.Tbl_User_ERP_ModTableAdapter.Fill(Me.DSUM.tbl_User_ERP_Mod)
        MsgBox("Record Saved Successfully")
    End Sub
    Private Sub frmDomainMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_User_DomainTableAdapter.Fill(Me.DSUM.tbl_User_Domain)
        Me.Tbl_User_ERP_ModTableAdapter.Fill(Me.DSUM.tbl_User_ERP_Mod)
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.Tbl_User_DomainBindingSource.EndEdit()
        Me.Tbl_User_DomainTableAdapter.Update(Me.DSUM.tbl_User_Domain)
        MsgBox("Record Saved Successfully")
    End Sub
End Class