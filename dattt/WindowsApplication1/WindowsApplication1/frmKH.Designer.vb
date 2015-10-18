<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKH
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MaKH"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(80, 68)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(191, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TenKH"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(80, 103)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(191, 20)
        Me.txtTenKH.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DiaChi"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(80, 138)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(191, 20)
        Me.txtDiaChi.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SDT"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(80, 173)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(191, 20)
        Me.txtSDT.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ClassID"
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(80, 32)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.ReadOnly = True
        Me.txtClassID.Size = New System.Drawing.Size(191, 20)
        Me.txtClassID.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(63, 220)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(182, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 318)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmKH"
        Me.Text = "Khach Hang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClassID As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
