Public Class frmWareHouseInfo

    Private Sub Tbl_Inv_WareHouse_InfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Inv_WareHouse_InfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_Inv_WareHouse_InfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSWareHouse)

    End Sub

    Private Sub frmWareHouseInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSWareHouse.tbl_Inv_WareHouse_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_WareHouse_InfoTableAdapter.Fill(Me.DSWareHouse.tbl_Inv_WareHouse_Info)

    End Sub
End Class