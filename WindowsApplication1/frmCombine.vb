Public Class frmCombine

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Form1.pimgCombine = pbCombine.Image

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class