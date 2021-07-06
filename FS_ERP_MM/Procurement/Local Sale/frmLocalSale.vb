Public Class frmLocalSale

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSLocalSale)

    End Sub

    Private Sub frmLocalSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_Mat_SaleH_NEW' table. You can move, or remove it, as needed.
        Me.Tbl_Mat_SaleH_NEWTableAdapter.Fill(Me.DSLocalSale.tbl_Mat_SaleH_NEW)
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_PUR_Vendor_Info' table. You can move, or remove it, as needed.
        Me.Tbl_PUR_Vendor_InfoTableAdapter.Fill(Me.DSLocalSale.tbl_PUR_Vendor_Info)
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_Inv_L4' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_L4TableAdapter.Fill(Me.DSLocalSale.tbl_Inv_L4)
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_Inv_Tran_Out' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSLocalSale.tbl_Inv_Tran_Out)
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_Mat_SaleH' table. You can move, or remove it, as needed.
        Me.Tbl_Mat_SaleHTableAdapter.Fill(Me.DSLocalSale.tbl_Mat_SaleH)
        'TODO: This line of code loads data into the 'DSLocalSale.tbl_Inv_Tran_Date' table. You can move, or remove it, as needed.
        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSLocalSale.tbl_Inv_Tran_Date, Now.Date.AddDays(-3650))
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()

    End Sub
    Private Sub txtfilterMatName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfilterMatName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Mat_SaleH_NEWBindingSource.Filter = "SaleID = " & Val(txtfilterMatName.Text) & ""
            Me.Tbl_Inv_Tran_DateBindingSource.Filter = "DayNo = " & Val(Me.DayIDLabel.Text) & ""
            Me.Tbl_Mat_SaleHBindingSource.Filter = "SaleID = " & Val(Me.SaleIDLabel3.Text) & ""
            Me.txtfilterMatName.Clear()
            Me.CMSItemName.Hide()
        End If
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Tbl_Mat_SaleHBindingSource.RemoveFilter()
        Me.Tbl_Mat_SaleH_NEWBindingSource.RemoveFilter()
        Me.Tbl_Inv_Tran_DateBindingSource.RemoveFilter()
    End Sub
    Private Sub Tbl_Inv_Tran_OutDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Inv_Tran_OutDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.DataError

    End Sub

    Private Sub Tbl_Inv_Tran_OutDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Inv_Tran_OutDataGridView.EditingControlShowing


        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Mat_SaleHBindingSource.EndEdit()
            Me.Tbl_Mat_SaleHTableAdapter.Update(Me.DSLocalSale.tbl_Mat_SaleH)
            Me.Tbl_Mat_SaleHTableAdapter.Fill(Me.DSLocalSale.tbl_Mat_SaleH)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Inv_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Inv_Tran_OutTableAdapter.Update(Me.DSLocalSale.tbl_Inv_Tran_Out)
            Me.Tbl_Inv_Tran_OutTableAdapter.Fill(Me.DSLocalSale.tbl_Inv_Tran_Out)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New Class_Utility
        Dim Path As String = ""
        If RadioButton2.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptMatOutwardSaleGatePassScrap.rpt"

            obj.LoadReports(Path, "{View_Mat_Sale.SaleID}= " & SaleIDLabel1.Text & "", "")
        ElseIf RadioButton1.Checked Then
            Path = "" & frmLoginVer.Reportpath & "\RptSaleScrap.rpt"

            obj.LoadReports(Path, "{View_Mat_Sale.SaleID}= " & SaleIDLabel1.Text & "", "")

        End If
    End Sub

    Private Sub txtfilterMatName_Click(sender As Object, e As EventArgs) Handles txtfilterMatName.Click

    End Sub
End Class