Public Class FrmQL
    Private _DBAccess As New DataBaseAccess

    Private _isLoading As Boolean = False
    Private Sub LoadDataOncomBoBox()
        Dim sqlQuery As String = "SELECT ClassID,ClassName FROM dbo.Class"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbClass.DataSource = dTable
        Me.cmbClass.ValueMember = "ClassID"
        Me.cmbClass.DisplayMember = "ClassName"
    End Sub
    Private Sub LoadDataOnGridView(ClassID As String)
        Dim sqlQuery As String = String.Format("SELECT MaKH,TenKH,DiaChi,SDT FROM dbo.KhachHang WHERE ClassID='{0}'", ClassID)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvQL.DataSource = dTable
        With Me.dgvQL
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "DiaChi"
            .Columns(3).HeaderText = "SDT"
        End With

    End Sub

    Private Sub FrmQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True

        LoadDataOncomBoBox()
        LoadDataOnGridView(Me.cmbClass.SelectedValue)

        _isLoading = False
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClass.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOnGridView(Me.cmbClass.SelectedValue)
        End If
    End Sub
    Private Sub SearchKH(ClassID As String, value As String)
        Dim sqlQuery As String = String.Format("SELECT MaKH,TenKH,DiaChi,SDT FROM dbo.KhachHang WHERE ClassID='{0}'", ClassID)
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format("AND MaKH LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format("AND TenKH LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvQL.DataSource = dTable
        With Me.dgvQL
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "DiaChi"
            .Columns(3).HeaderText = "SDT"
        End With

    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchKH(Me.cmbClass.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmKH(False)
        frm.txtClassID.Text = Me.cmbClass.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbClass.SelectedValue)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frmKH(True)
        frm.txtClassID.Text = Me.cmbClass.SelectedValue
        frm.txtMaKH.ReadOnly = True
        With Me.dgvQL
            frm.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            frm.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
            frm.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            frm.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbClass.SelectedValue)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim MaKH As String = Me.dgvQL.Rows(Me.dgvQL.CurrentCell.RowIndex).Cells("MaKH").Value
        Dim sqlQuery As String = String.Format("DELETE KhachHang WHERE MaKH='{0}'", MaKH)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xoa du lieu thanh cong")
            LoadDataOnGridView(Me.cmbClass.SelectedValue)
        Else
            MessageBox.Show("Loi xoa du lieu")
        End If
    End Sub
End Class
