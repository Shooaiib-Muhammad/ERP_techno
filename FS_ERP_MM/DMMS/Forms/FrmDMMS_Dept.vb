Public Class FrmDMMS_Dept


    Private Sub FrmDMMS_Dept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMMS.max_HoldeID' table. You can move, or remove it, as needed.
        Me.Max_HoldeIDTableAdapter.Fill(Me.DMMS.max_HoldeID)
        'TODO: This line of code loads data into the 'DMMS.tbl_PIR_Users' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_UsersTableAdapter.Fill(Me.DMMS.tbl_PIR_Users)
        'TODO: This line of code loads data into the 'DMMS.tbl_DMMS_Holders' table. You can move, or remove it, as needed.
        Me.Tbl_DMMS_HoldersTableAdapter.Fill(Me.DMMS.tbl_DMMS_Holders)
        'TODO: This line of code loads data into the 'DMMS.tbl_PIR_Section' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_SectionTableAdapter.Fill(Me.DMMS.tbl_PIR_Section)
        'TODO: This line of code loads data into the 'DMMS.tbl_PIR_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_PIR_DeptTableAdapter.Fill(Me.DMMS.tbl_PIR_Dept)
        load()
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim maxHolderID As Int64 = HolderIDLabel1.Text + 1

            Tbl_DMMS_HoldersTableAdapter.Insert(Val(DeptNameComboBox.SelectedValue), Val(SectionNameComboBox.SelectedValue), TextBox1.Text, TextBox2.Text, TextBox3.Text, Nothing, Now.Date, TextBox4.Text, maxHolderID, Nothing)
            Tbl_PIR_UsersTableAdapter.Insert(TextBox1.Text, "Forward@123", Val(DeptNameComboBox.SelectedValue), Val(SectionNameComboBox.SelectedValue), 1, TextBox2.Text, TextBox3.Text, Now, Nothing, True, Nothing, Nothing, Nothing, True, maxHolderID)
            load()
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub
    Private Sub load()
        Try
            Me.View_DMMS_MachinesTableAdapter.Fill(Me.DMMS.View_DMMS_Machines, Val(DeptNameComboBox.SelectedValue), Val(SectionNameComboBox.SelectedValue))
            Me.Max_HoldeIDTableAdapter.Fill(Me.DMMS.max_HoldeID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Try
                View_DMMS_MachinesBindingSource.EndEdit()
                View_DMMS_MachinesTableAdapter.Update(Me.DMMS.View_DMMS_Machines)
                load()
                MsgBox("Data Saved")


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

    End Sub

    Private Sub Tbl_PIR_DeptBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_PIR_DeptBindingSource.PositionChanged
        load()

    End Sub

    Private Sub Tbl_PIR_SectionBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_PIR_SectionBindingSource.PositionChanged
        load()
    End Sub


End Class