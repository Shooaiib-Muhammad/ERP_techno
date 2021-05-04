Public Class frmSaleUndo

    Private Sub Tbl_Inv_Tran_DateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Inv_Tran_DateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSSaleReturn)

    End Sub

    Private Sub frmSaleReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSSaleReturn.tbl_Inv_Tran_In' table. You can move, or remove it, as needed.
        'Me.Tbl_Inv_Tran_InTableAdapter.Fill(Me.DSSaleReturn.tbl_Inv_Tran_In)
        'TODO: This line of code loads data into the 'DSSaleReturn.View_Sale_Data' table. You can move, or remove it, as needed.
        'Me.View_Sale_DataTableAdapter.Fill(Me.DSSaleReturn.View_Sale_Data)
        Me.Tbl_MM_CustomerTableAdapter.FillBy(Me.DSSaleReturn.tbl_MM_Customer)
        'Me.View_Inv_Tran_InTableAdapter.Fill(Me.DSSaleReturn.View_Inv_Tran_In)

        Me.Tbl_Inv_Tran_DateTableAdapter.FillBy(Me.DSSaleReturn.tbl_Inv_Tran_Date, Now.Date.AddDays(-30))
        Me.Tbl_Inv_Tran_DateBindingSource.MoveLast()
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Me.View_Sale_DataTableAdapter.FillBy(Me.DSSaleReturn.View_Sale_Data, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try

        'Me.View_Inv_Tran_InTableAdapter.Fill(Me.DSSaleReturn.View_Inv_Tran_In)
    End Sub
    Private Sub View_Sale_DataDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Sale_DataDataGridView.CellContentClick
        'Dim btnMsg As DialogResult
        'Dim RecQty, BalQty As Double
        'If e.ColumnIndex = 13 Then
        '    btnMsg = MessageBox.Show("Are You Sure Want To Receive Selected Material?   ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        '    If btnMsg = Windows.Forms.DialogResult.Yes Then
        '        RecQty = Me.View_Sale_DataDataGridView(11, e.RowIndex).Value
        '        If RecQty <= CDbl(Me.View_Sale_DataDataGridView(10, e.RowIndex).Value) Then
        '            BalQty = RecQty
        '        Else
        '            BalQty = CDbl(Me.View_Sale_DataDataGridView(10, e.RowIndex).Value)
        '        End If
        '        Me.Tbl_Inv_Tran_InTableAdapter.Insert(Me.DayNoLabel1.Text, "SMR", Me.CompanyNameComboBox.SelectedValue, Me.View_Sale_DataDataGridView(6, e.RowIndex).Value, BalQty, Me.View_Sale_DataDataGridView(1, e.RowIndex).Value, Me.View_Sale_DataDataGridView(2, e.RowIndex).Value, Me.View_Sale_DataDataGridView(3, e.RowIndex).Value, Me.View_Sale_DataDataGridView(12, e.RowIndex).Value)
        '        LoadData()
        '    End If
        'End If
        If e.ColumnIndex = 12 Then
            Dim btnMsg As DialogResult = MessageBox.Show("Are You Sure Want To Undo Material Transaction? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If btnMsg = Windows.Forms.DialogResult.Yes Then
                Me.View_Sale_DataTableAdapter.DeleteQuery(Me.View_Sale_DataDataGridView(1, e.RowIndex).Value)
                LoadData()
            End If
        End If
    End Sub

    'Private Sub View_Inv_Tran_InDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Inv_Tran_InDataGridView.CellContentClick
    '    If e.ColumnIndex = 11 Then
    '        Dim btnMsg As DialogResult = MessageBox.Show("Are You Sure Want To Undo Material Transaction? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    '        If btnMsg = Windows.Forms.DialogResult.Yes Then
    '            Me.View_Inv_Tran_InTableAdapter.DeleteQuery(Me.View_Inv_Tran_InDataGridView(1, e.RowIndex).Value)
    '            LoadData()
    '        End If
    '    End If
    'End Sub

    Private Sub Tbl_Inv_Tran_DateBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Inv_Tran_DateBindingSource.PositionChanged
        LoadData()
    End Sub
End Class