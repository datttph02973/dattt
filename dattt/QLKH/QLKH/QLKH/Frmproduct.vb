Public Class Frmproduct
    Private _DBAccess As New DataBaseAccess
    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Function InsertProduct()
        Dim sqlQuery As String = "INSERT INTO KhachHang (MaKH,TenKH,DiaChi,SDT,ClassID)"
        sqlQuery += String.Format("VALUES('{0}','{1}','{2}','{3}','{4}')",
                            txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, TextSDT.Text, txtClassID.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function UpdateProduct() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE Product SET TenKH='{0}',DiaChi='{1}',SDT='{2}' WHERE MaKH='{3}'", Me.txtTenKH.Text, Me.txtDiaChi.Text, Me.TextSDT.Text, Me.txtMaKH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaKH.Text) OrElse String.IsNullOrEmpty(txtTenKH.Text) OrElse
            String.IsNullOrEmpty(txtDiaChi.Text) OrElse String.IsNullOrEmpty(TextSDT.Text) OrElse
            String.IsNullOrEmpty(txtClassID.Text))

    End Function

    Private Sub Frmproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEmpty() Then
            MessageBox.Show("Nhap gia tri vao truoc khi ghi vao database", "ERROR", MessageBoxButtons.OK)
        Else
            If InsertProduct() Then
                MessageBox.Show("them du lieu thanh cong", "Thong bao", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Loi them du lieu", "ERROR", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then
            MessageBox.Show("Nhap gia tri vao truoc khi ghi vao database", "ERROR", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateProduct() Then
                    MessageBox.Show("sua du lieu thanh cong!", "Information", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi sua du lieu", "ERROR", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertProduct() Then
                    MessageBox.Show("them du lieu thanh cong", "Thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi them du lieu", "ERROR", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
            Me.Close()

            End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class