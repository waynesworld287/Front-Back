<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFrontPic = New System.Windows.Forms.Label()
        Me.lblBackPic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCombine = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.optJoinType2 = New System.Windows.Forms.RadioButton()
        Me.optJoinType1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optAlign3 = New System.Windows.Forms.RadioButton()
        Me.optAlign2 = New System.Windows.Forms.RadioButton()
        Me.optAlign1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkTitle = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Load Front Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(659, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Load Back Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFrontPic
        '
        Me.lblFrontPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFrontPic.Location = New System.Drawing.Point(324, 73)
        Me.lblFrontPic.Name = "lblFrontPic"
        Me.lblFrontPic.Size = New System.Drawing.Size(102, 27)
        Me.lblFrontPic.TabIndex = 4
        '
        'lblBackPic
        '
        Me.lblBackPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBackPic.Location = New System.Drawing.Point(804, 73)
        Me.lblBackPic.Name = "lblBackPic"
        Me.lblBackPic.Size = New System.Drawing.Size(102, 27)
        Me.lblBackPic.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(724, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Size of Image:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Size of Image:"
        '
        'btnCombine
        '
        Me.btnCombine.Location = New System.Drawing.Point(1089, 502)
        Me.btnCombine.Name = "btnCombine"
        Me.btnCombine.Size = New System.Drawing.Size(167, 37)
        Me.btnCombine.TabIndex = 8
        Me.btnCombine.Text = "Combine Both Images"
        Me.btnCombine.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.optJoinType2)
        Me.GroupBox1.Controls.Add(Me.optJoinType1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(998, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 286)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose How To Join Images"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.SideBySide
        Me.PictureBox4.Location = New System.Drawing.Point(170, 163)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(135, 107)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'optJoinType2
        '
        Me.optJoinType2.AutoSize = True
        Me.optJoinType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optJoinType2.Location = New System.Drawing.Point(25, 196)
        Me.optJoinType2.Name = "optJoinType2"
        Me.optJoinType2.Size = New System.Drawing.Size(117, 24)
        Me.optJoinType2.TabIndex = 12
        Me.optJoinType2.Text = "Side By Side"
        Me.optJoinType2.UseVisualStyleBackColor = True
        '
        'optJoinType1
        '
        Me.optJoinType1.AutoSize = True
        Me.optJoinType1.Checked = True
        Me.optJoinType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optJoinType1.Location = New System.Drawing.Point(25, 70)
        Me.optJoinType1.Name = "optJoinType1"
        Me.optJoinType1.Size = New System.Drawing.Size(135, 24)
        Me.optJoinType1.TabIndex = 11
        Me.optJoinType1.TabStop = True
        Me.optJoinType1.Text = "Stack Vertically"
        Me.optJoinType1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.StackVertical
        Me.PictureBox3.Location = New System.Drawing.Point(168, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(138, 124)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox2.Controls.Add(Me.optAlign3)
        Me.GroupBox2.Controls.Add(Me.optAlign2)
        Me.GroupBox2.Controls.Add(Me.optAlign1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(998, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 118)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose How To Align Images"
        '
        'optAlign3
        '
        Me.optAlign3.AutoSize = True
        Me.optAlign3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAlign3.Location = New System.Drawing.Point(236, 39)
        Me.optAlign3.Name = "optAlign3"
        Me.optAlign3.Size = New System.Drawing.Size(90, 20)
        Me.optAlign3.TabIndex = 2
        Me.optAlign3.Text = "Align Right"
        Me.optAlign3.UseVisualStyleBackColor = True
        '
        'optAlign2
        '
        Me.optAlign2.AutoSize = True
        Me.optAlign2.Checked = True
        Me.optAlign2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAlign2.Location = New System.Drawing.Point(125, 39)
        Me.optAlign2.Name = "optAlign2"
        Me.optAlign2.Size = New System.Drawing.Size(98, 20)
        Me.optAlign2.TabIndex = 1
        Me.optAlign2.TabStop = True
        Me.optAlign2.Text = "Align Center"
        Me.optAlign2.UseVisualStyleBackColor = True
        '
        'optAlign1
        '
        Me.optAlign1.AutoSize = True
        Me.optAlign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAlign1.Location = New System.Drawing.Point(20, 39)
        Me.optAlign1.Name = "optAlign1"
        Me.optAlign1.Size = New System.Drawing.Size(80, 20)
        Me.optAlign1.TabIndex = 0
        Me.optAlign1.Text = "Align Left"
        Me.optAlign1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.LoadBack
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(523, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(432, 377)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LoadFront
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(49, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 377)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'chkTitle
        '
        Me.chkTitle.AutoSize = True
        Me.chkTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTitle.Location = New System.Drawing.Point(428, 22)
        Me.chkTitle.Name = "chkTitle"
        Me.chkTitle.Size = New System.Drawing.Size(180, 24)
        Me.chkTitle.TabIndex = 12
        Me.chkTitle.Text = "Include Image Labels"
        Me.chkTitle.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Front Image"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Back Image"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1387, 579)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkTitle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCombine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBackPic)
        Me.Controls.Add(Me.lblFrontPic)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "This Application Will Join Two Images Into One"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblFrontPic As System.Windows.Forms.Label
    Friend WithEvents lblBackPic As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCombine As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optJoinType2 As System.Windows.Forms.RadioButton
    Friend WithEvents optJoinType1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optAlign3 As System.Windows.Forms.RadioButton
    Friend WithEvents optAlign2 As System.Windows.Forms.RadioButton
    Friend WithEvents optAlign1 As System.Windows.Forms.RadioButton
    Friend WithEvents chkTitle As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
