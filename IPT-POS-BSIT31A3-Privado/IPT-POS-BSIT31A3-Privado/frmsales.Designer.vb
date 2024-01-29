<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsales
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
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label3)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(135, 3)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(761, 59)
        Me.GunaElipsePanel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(261, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 44)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "SALES REPORT"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.lblgrandtotal)
        Me.GunaElipsePanel2.Controls.Add(Me.Label1)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(653, 599)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 20
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(441, 72)
        Me.GunaElipsePanel2.TabIndex = 13
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrandtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblgrandtotal.Location = New System.Drawing.Point(302, 19)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(67, 33)
        Me.lblgrandtotal.TabIndex = 14
        Me.lblgrandtotal.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(86, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Total Amount:"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(1, 68)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1101, 525)
        Me.ListView1.TabIndex = 49
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Transaction Num"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = " Date"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time"
        Me.ColumnHeader4.Width = 69
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Amount"
        Me.ColumnHeader5.Width = 84
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "VAT"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Vatable Sale"
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Discount"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Discount Type"
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Amount Paid"
        Me.ColumnHeader10.Width = 85
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Amount Change"
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "MOP"
        Me.ColumnHeader12.Width = 70
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Reference No"
        Me.ColumnHeader13.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Cashier Name"
        Me.ColumnHeader14.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(12, 635)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Radius = 15
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 50
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmsales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1106, 679)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmsales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsales"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblgrandtotal As Label
    Friend WithEvents Label1 As Label
End Class
