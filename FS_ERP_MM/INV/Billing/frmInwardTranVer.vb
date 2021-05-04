Public Class frmInwardTranVer

    Private Sub Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Sec_Vehicle_HeadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSMisSec)

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Tbl_Sec_Vehicle_HeadTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Head, New System.Nullable(Of Date)(CType(VehicleDateToolStripTextBox.Text, Date)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub frmInwardTranVer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_OutRegNo' table. You can move, or remove it, as needed.
        'Me.Tbl_Sec_OutRegNoTableAdapter.Fill(Me.DSMisSec.tbl_Sec_OutRegNo)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Vehicle' table. You can move, or remove it, as needed.
        'Me.Tbl_Sec_VehicleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Maker' table. You can move, or remove it, as needed.
        'Me.Tbl_Sec_MakerTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Maker)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Pur_UnitOfMeasurement' table. You can move, or remove it, as needed.
        'Me.Tbl_Pur_UnitOfMeasurementTableAdapter.Fill(Me.DSMisSec.tbl_Pur_UnitOfMeasurement)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Dept' table. You can move, or remove it, as needed.
        'Me.Tbl_Sec_DeptTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Dept)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Driver' table. You can move, or remove it, as needed.
        'Me.Tbl_Sec_DriverTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Driver)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Middle' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_Vehicle_HeadTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Head, Now.Date.AddDays(-90))
        Me.Tbl_Sec_Vehicle_HeadBindingSource.MoveLast()
        Try
            Me.Tbl_Sec_MiddleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Middle)
            Me.Tbl_Sec_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Enteries, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
        'Timer1.Start()
        Me.Tbl_Sec_MiddleBindingSource.MoveLast()

    End Sub

    'Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Tbl_Sec_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Enteries, CType(VehicleHeadToolStripTextBox.Text, Integer))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Sec_EnteriesBindingSource.EndEdit()
            Me.Tbl_Sec_EnteriesTableAdapter.Update(Me.DSMisSec.tbl_Sec_Enteries)
            Try
                Me.Tbl_Sec_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Enteries, Me.DayNoLabel1.Text)
                'Me.Tbl_Sec_MiddleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Middle, Me.DayNoLabel1.Text)
            Catch ex As Exception
            End Try
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tbl_Sec_VehicleBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Sec_VehicleBindingSource.PositionChanged
        Try
            'Me.Tbl_Sec_MiddleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Middle, Me.DayNoLabel1.Text)
            Me.Tbl_Sec_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Enteries, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Sec_Vehicle_HeadBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Sec_Vehicle_HeadBindingSource.PositionChanged
        Try
            'Me.Tbl_Sec_MiddleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Middle, Me.DayNoLabel1.Text)
            Me.Tbl_Sec_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Enteries, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Sec_EnteriesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_EnteriesDataGridView.CellContentClick
        If e.ColumnIndex = 8 Then
            If Tbl_Sec_EnteriesDataGridView.Item(8, e.RowIndex) Is DBNull.Value Then
                Me.Tbl_Sec_EnteriesDataGridView.Item(8, e.RowIndex).Value = True
                Me.Tbl_Sec_EnteriesDataGridView.Item(9, e.RowIndex).Value = Now.Date
            Else
                If Tbl_Sec_EnteriesDataGridView.Item(8, e.RowIndex).Value = False Then
                    Tbl_Sec_EnteriesDataGridView.Item(8, e.RowIndex).Value = True
                    Tbl_Sec_EnteriesDataGridView.Item(9, e.RowIndex).Value = Now.Date
                Else
                    Tbl_Sec_EnteriesDataGridView.Item(8, e.RowIndex).Value = False
                    Tbl_Sec_EnteriesDataGridView.Item(9, e.RowIndex).Value = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Sec_EnteriesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Sec_EnteriesDataGridView.DataError

    End Sub
End Class