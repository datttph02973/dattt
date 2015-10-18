<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmqlbh
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
        Me.dgvbanhang = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        CType(Me.dgvbanhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvbanhang
        '
        Me.dgvbanhang.AllowUserToAddRows = False
        Me.dgvbanhang.AllowUserToDeleteRows = False
        Me.dgvbanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbanhang.Location = New System.Drawing.Point(24, 61)
        Me.dgvbanhang.MultiSelect = False
        Me.dgvbanhang.Name = "dgvbanhang"
        Me.dgvbanhang.ReadOnly = True
        Me.dgvbanhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbanhang.Size = New System.Drawing.Size(410, 253)
        Me.dgvbanhang.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(68, 35)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 20)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(21, 38)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Search"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(460, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(460, 144)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(460, 102)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(122, 23)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbClass)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(460, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 69)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Class"
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(6, 32)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(116, 21)
        Me.cmbClass.TabIndex = 0
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"MaKH", "TenKH"})
        Me.cmbSearch.Location = New System.Drawing.Point(313, 35)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearch.TabIndex = 8
        '
        'Frmqlbh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 343)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvbanhang)
        Me.Name = "Frmqlbh"
        Me.Text = "QuanLyBanHang"
        CType(Me.dgvbanhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvbanhang As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents cmbSearch As ComboBox
End Class
