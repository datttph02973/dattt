<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmproduct
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
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.TextSDT = New System.Windows.Forms.TextBox()
        Me.lblClassID = New System.Windows.Forms.Label()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(28, 66)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(37, 13)
        Me.lblMaKH.TabIndex = 0
        Me.lblMaKH.Text = "MaKH"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(90, 63)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(164, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Location = New System.Drawing.Point(28, 107)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(41, 13)
        Me.lblTenKH.TabIndex = 0
        Me.lblTenKH.Text = "TenKH"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(90, 104)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(164, 20)
        Me.txtTenKH.TabIndex = 1
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(28, 147)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(38, 13)
        Me.lblDiaChi.TabIndex = 0
        Me.lblDiaChi.Text = "DiaChi"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(90, 144)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(164, 20)
        Me.txtDiaChi.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(59, 234)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(159, 234)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(28, 184)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(29, 13)
        Me.lblSDT.TabIndex = 0
        Me.lblSDT.Text = "SDT"
        '
        'TextSDT
        '
        Me.TextSDT.Location = New System.Drawing.Point(90, 181)
        Me.TextSDT.Name = "TextSDT"
        Me.TextSDT.Size = New System.Drawing.Size(164, 20)
        Me.TextSDT.TabIndex = 1
        '
        'lblClassID
        '
        Me.lblClassID.AutoSize = True
        Me.lblClassID.Location = New System.Drawing.Point(28, 25)
        Me.lblClassID.Name = "lblClassID"
        Me.lblClassID.Size = New System.Drawing.Size(43, 13)
        Me.lblClassID.TabIndex = 0
        Me.lblClassID.Text = "ClassID"
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(90, 22)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.ReadOnly = True
        Me.txtClassID.Size = New System.Drawing.Size(164, 20)
        Me.txtClassID.TabIndex = 1
        '
        'Frmproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 289)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.TextSDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lblSDT)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.lblClassID)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Name = "Frmproduct"
        Me.Text = "KhachHang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMaKH As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents lblTenKH As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents lblDiaChi As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSDT As Label
    Friend WithEvents TextSDT As TextBox
    Friend WithEvents lblClassID As Label
    Friend WithEvents txtClassID As TextBox
End Class
