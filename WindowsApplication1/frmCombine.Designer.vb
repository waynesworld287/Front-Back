<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombine
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
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCombined = New System.Windows.Forms.Label()
        Me.pbCombine = New System.Windows.Forms.PictureBox()
        CType(Me.pbCombine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(93, 510)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(135, 39)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save Combined Image"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(480, 510)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(135, 39)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Size of Image:"
        '
        'lblCombined
        '
        Me.lblCombined.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCombined.Location = New System.Drawing.Point(113, 19)
        Me.lblCombined.Name = "lblCombined"
        Me.lblCombined.Size = New System.Drawing.Size(102, 27)
        Me.lblCombined.TabIndex = 12
        '
        'pbCombine
        '
        Me.pbCombine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCombine.Location = New System.Drawing.Point(33, 63)
        Me.pbCombine.Name = "pbCombine"
        Me.pbCombine.Size = New System.Drawing.Size(655, 421)
        Me.pbCombine.TabIndex = 0
        Me.pbCombine.TabStop = False
        '
        'frmCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 578)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCombined)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.pbCombine)
        Me.MaximizeBox = False
        Me.Name = "frmCombine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preview Combined Images"
        CType(Me.pbCombine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCombine As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCombined As System.Windows.Forms.Label
End Class
