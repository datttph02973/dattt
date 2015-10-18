Public Class frmKH
    Private _DBAccess As New DataBaseAccess
    Private _isEdit As Boolean = False
    Private Function InsertKH() As Boolean
        Dim sqlQuery As String = "INSERT INTO KhachHang (MaKH,TenKH,DiaChi,SDT,ClassID)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')", _
                                  txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtClassID.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    



    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaKH.Text) OrElse _
                String.IsNullOrEmpty(txtTenKH.Text) OrElse _
                String.IsNullOrEmpty(txtDiaChi.Text) OrElse _
                String.IsNullOrEmpty(txtSDT.Text) OrElse _
                String.IsNullOrEmpty(txtClassID.Text))
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then
            MessageBox.Show("nhap gia tri vao truoc khi ghi vao database", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateKH() Then
                    MessageBox.Show("sua du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi sua du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If

            Else
                If InsertKH() Then
                    MessageBox.Show("them du lieu thanh cong", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("loi them du lieu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
            
            Me.Close()
        End If
    End Sub
    Private Function UpdateKH() As Boolean
        Dim sqlQuery As String = String.Format("Update KhachHang SET TenKH ='{0}', DiaChi ='{1}', SDT ='{2}' WHERE MaKH = '{3}'", Me.txtTenKH.Text, Me.txtDiaChi.Text, Me.txtSDT.Text, Me.txtMaKH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub New(Optional IsEdit = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class