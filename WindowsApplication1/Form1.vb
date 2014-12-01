

Public Class Form1

    Private mingFront As Image, mingBack As Image
    Public pimgCombine As Image





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.OpenFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.GIF|All files (*.*)|*.*"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            mingFront = Image.FromFile(OpenFileDialog1.FileName)

            If chkTitle.Checked Then    'It needs a label

                PictureBox1.Image = AddPicLabel(1)

            Else

                PictureBox1.Image = mingFront

            End If


            lblFrontPic.Text = PictureBox1.Image.Width & " x " & PictureBox1.Image.Height()

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.OpenFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.png;*.gif)|*.BMP;*.JPG;*.png;*.GIF|All files (*.*)|*.*"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            mingBack = Image.FromFile(OpenFileDialog1.FileName)

            If chkTitle.Checked Then    'It needs a label

                PictureBox2.Image = AddPicLabel(2)

            Else

                PictureBox2.Image = mingBack

            End If

            lblBackPic.Text = PictureBox2.Image.Width & " x " & PictureBox2.Image.Height()

        End If
    End Sub

    Private Sub btnCombine_Click(sender As Object, e As EventArgs) Handles btnCombine.Click

        Dim intAnswer As Integer

        Dim intOptJoinType As Integer, intOptAlign As Integer

        Dim imgCombine As Image

        Dim frm As New frmCombine

        If PictureBox1.Image.Tag = "Initial" Or PictureBox2.Image.Tag = "Initial" Then

            intAnswer = MsgBox("You really need to load two images.  Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Load Image Warning")

            If Not intAnswer = vbYes Then

                Exit Sub

            End If

        End If

        If optJoinType1.Checked Then    'Align Vertically

            intOptJoinType = 1

        Else

            intOptJoinType = 2  'Join side by side

        End If

        If optAlign1.Checked Then   'Align left/top

            intOptAlign = 1

        Else

            If optAlign2.Checked Then   'Align center/middle

                intOptAlign = 2

            Else    'Align right/bottom

                intOptAlign = 3

            End If


        End If

        imgCombine = JoinImage(PictureBox1.Image, PictureBox2.Image, intOptJoinType, intOptAlign)

        With frm

            .pbCombine.Image = imgCombine

            .pbCombine.SizeMode = PictureBoxSizeMode.Zoom

            .lblCombined.Text = imgCombine.Width & " x " & imgCombine.Height()

            .ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then

                Me.SaveFileDialog1.Filter = "JPEG Files(*.jpg|*.JPG"


                If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    pimgCombine.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)

                End If

            End If

        End With

    End Sub
    Private Function JoinImage(imgImage1 As Image, imgImage2 As Image, intJoinType As Integer, intAlign As Integer) As Image

        Dim intNewWidth As Integer, intNewHeight As Integer

        If intJoinType = 1 Then 'Join Vertically

            intNewWidth = Math.Max(imgImage1.Width, imgImage2.Width)
            intNewHeight = imgImage1.Height + imgImage2.Height

        Else    'Join side by side

            intNewWidth = imgImage1.Width + imgImage2.Width
            intNewHeight = Math.Max(imgImage1.Height, imgImage2.Height)

        End If

        Dim imgCombine As New Bitmap(intNewWidth, intNewHeight)

        Dim gCombined As Graphics = Graphics.FromImage(imgCombine)

        Dim grap As Drawing.Graphics = Drawing.Graphics.FromImage(imgCombine)

        grap.Clear(Drawing.Color.Transparent)

        gCombined.DrawImage(imgImage1, GetImageRetangle(1, imgImage1.Width, imgImage1.Height, imgImage2.Width, imgImage2.Height, intJoinType, intAlign))

        gCombined.DrawImage(imgImage2, GetImageRetangle(2, imgImage1.Width, imgImage1.Height, imgImage2.Width, imgImage2.Height, intJoinType, intAlign))

        gCombined.Dispose()

        gCombined = Nothing

        Return imgCombine

    End Function


    Private Function GetImageRetangle(intImg As Integer, intImg1Width As Integer, intImg1Height As Integer, intImg2Width As Integer, intImg2Height As Integer, intJoinType As Integer, intAlign As Integer) As Rectangle

        Dim intNewWidth As Integer, intNewHeight As Integer

        If intJoinType = 1 Then 'Align vertically

            intNewWidth = Math.Max(intImg1Width, intImg2Width)

            intNewHeight = intImg1Height + intImg2Height

        Else    'Side by side

            intNewWidth = intImg1Width + intImg2Width

            intNewHeight = Math.Max(intImg1Height, intImg2Height)

        End If

        Select Case intImg

            Case 1  'Rectange for picture1

                Select Case intJoinType

                    Case 1  'Join type vertical

                        Select Case intAlign

                            Case 1  'Align left

                                Return New Rectangle(0, 0, intImg1Width, intImg1Height)

                            Case 2  'align center

                                If intImg1Width < intNewWidth Then  'Picture 2 is wider

                                    Return New Rectangle((intNewWidth - intImg1Width) / 2, 0, intImg1Width, intImg1Height)

                                Else    'Picture 1 is the widest

                                    Return New Rectangle(0, 0, intImg1Width, intImg1Height)

                                End If

                            Case 3  'Align right

                                If intImg1Width < intNewWidth Then  'Picture 2 is wider

                                    Return New Rectangle(intNewWidth - intImg1Width, 0, intImg1Width, intImg1Height)

                                Else    'Picture 1 is the widest

                                    Return New Rectangle(0, 0, intImg1Width, intImg1Height)

                                End If

                        End Select

                    Case 2  'Join type side by side

                        Select Case intAlign

                            Case 1  'Align top

                                Return New Rectangle(0, 0, intImg1Width, intImg1Height)

                            Case 2  'align middle

                                If intImg1Height < intNewHeight Then  'Picture 2 is taller

                                    Return New Rectangle(0, (intNewHeight - intImg1Height) / 2, intImg1Width, intImg1Height)

                                Else    'Picture 1 is the tallest

                                    Return New Rectangle(0, 0, intImg1Width, intImg1Height)

                                End If

                            Case 3  'Align bottom

                                If intImg1Width < intNewWidth Then  'Picture 2 is taller

                                    Return New Rectangle(0, intNewHeight - intImg1Height, intImg1Width, intImg1Height)

                                Else    'Picture 1 is the widest

                                    Return New Rectangle(0, 0, intImg1Width, intImg1Height)

                                End If

                        End Select

                End Select

            Case 2  'Rectange for picture2

                Select Case intJoinType

                    Case 1  'Join type vertical

                        Select Case intAlign

                            Case 1  'Align left

                                Return New Rectangle(0, intImg1Height, intImg2Width, intImg2Height)

                            Case 2  'align center

                                If intImg2Width < intNewWidth Then  'Picture 1 is wider

                                    Return New Rectangle((intNewWidth - intImg2Width) / 2, intImg1Height, intImg2Width, intImg2Height)

                                Else    'Picture 2 is the widest

                                    Return New Rectangle(0, intImg1Height, intImg2Width, intImg2Height)

                                End If

                            Case 3  'Align right

                                If intImg2Width < intNewWidth Then  'Picture 1 is wider

                                    Return New Rectangle(intNewWidth - intImg2Width, intImg1Height, intImg2Width, intImg2Height)

                                Else    'Picture 2 is the widest

                                    Return New Rectangle(0, intImg1Height, intImg2Width, intImg2Height)

                                End If


                        End Select

                    Case 2  'Join type side by side

                        Select Case intAlign

                            Case 1  'Align top

                                Return New Rectangle(intImg1Width, 0, intImg2Width, intImg2Height)

                            Case 2  'align middle

                                If intImg2Height < intNewHeight Then  'Picture 1 is taller

                                    Return New Rectangle(intImg1Width, (intNewHeight - intImg2Height) / 2, intImg2Width, intImg2Height)

                                Else    'Picture 2 is the tallest

                                    Return New Rectangle(intImg1Width, 0, intImg2Width, intImg2Height)

                                End If

                            Case 3  'Align bottom

                                If intImg2Height < intNewHeight Then  'Picture 1 is taller

                                    Return New Rectangle(intImg1Width, intNewHeight - intImg2Height, intImg2Width, intImg2Height)

                                Else    'Picture 2 is the tallest

                                    Return New Rectangle(intImg1Width, 0, intImg2Width, intImg2Height)

                                End If


                        End Select

                End Select

        End Select

    End Function

    Private Sub optJoinType_CheckedChanged(sender As Object, e As EventArgs) Handles optJoinType1.CheckedChanged, optJoinType2.CheckedChanged

        If optJoinType1.Checked = True Then

            optAlign1.Text = "Align Left"
            optAlign2.Text = "Align Center"
            optAlign3.Text = "Align Right"

        Else    'It is side by side

            optAlign1.Text = "Align Top"
            optAlign2.Text = "Align Middle"
            optAlign3.Text = "Align Bottom"

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image.Tag = "Initial"
        PictureBox2.Image.Tag = "Initial"

        PictureBox1.AllowDrop = True
        PictureBox2.AllowDrop = True


    End Sub

    Private Sub chkTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkTitle.CheckedChanged

        If chkTitle.Checked Then    'Picture needs a label

            If Not PictureBox1.Image.Tag = "Initial" Then

                PictureBox1.Image = AddPicLabel(1)

            End If

            If Not PictureBox2.Image.Tag = "Initial" Then

                PictureBox2.Image = AddPicLabel(2)

            End If

        Else    'No labels

            If Not PictureBox1.Image.Tag = "Initial" Then

                PictureBox1.Image = mingFront

            End If

            If Not PictureBox2.Image.Tag = "Initial" Then

                PictureBox2.Image = mingBack

            End If

        End If

        lblFrontPic.Text = PictureBox1.Image.Width & " x " & PictureBox1.Image.Height()

    End Sub

    Private Function AddPicLabel(intImage As Integer) As Image

        Dim intNewWidth As Integer, intNewHeight As Integer

        Dim imgFrontLabel As Image, imgBackLabel As Image

        Dim decScaleFactor As Decimal

        If intImage = 1 Then    'Front image

            'Scale factor for the front label
            decScaleFactor = mingFront.Height / 500

            intNewWidth = My.Resources.FrontTitle.Width * decScaleFactor

            intNewHeight = My.Resources.FrontTitle.Height * (decScaleFactor)

            imgFrontLabel = New Bitmap(My.Resources.FrontTitle, intNewWidth, intNewHeight)

            Return JoinImage(imgFrontLabel, mingFront, 1, 1)

        Else

            'New scale factor for the back label
            decScaleFactor = mingBack.Height / 500

            intNewWidth = My.Resources.FrontTitle.Width * decScaleFactor

            intNewHeight = My.Resources.FrontTitle.Height * (decScaleFactor)

            imgBackLabel = New Bitmap(My.Resources.BackTitle, intNewWidth, intNewHeight)

            Return JoinImage(imgBackLabel, mingBack, 1, 1)

        End If

    End Function

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop

        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        Dim strExtension As String = IO.Path.GetExtension(files(0))

        If Not (strExtension = ".jpg" Or strExtension = ".bmp" Or strExtension = ".png" Or strExtension = ".gif") Then

            MsgBox("You file type may not be supported by this application.  Please select a jpg, bmp, png, or gif", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Select another file")

            Exit Sub

        End If

        mingFront = Image.FromFile(files(0))

        PictureBox1.Image = mingFront

        lblFrontPic.Text = PictureBox1.Image.Width & " x " & PictureBox1.Image.Height()

    End Sub


    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter

        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    Private Sub PictureBox2_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox2.DragDrop

        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        Dim strExtension As String = IO.Path.GetExtension(files(0))

        If Not (strExtension = ".jpg" Or strExtension = ".bmp" Or strExtension = ".png" Or strExtension = ".gif") Then

            MsgBox("You file type may not be supported by this application.  Please select a jpg, bmp, png, or gif", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Select another file")

            Exit Sub

        End If

        mingBack = Image.FromFile(files(0))

        PictureBox2.Image = mingBack

        lblBackPic.Text = PictureBox2.Image.Width & " x " & PictureBox2.Image.Height()

    End Sub



    Private Sub PictureBox2_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox2.DragEnter

        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub
End Class
