﻿Public Class WinFormControlsForm


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        ExamplePictureBox.BackgroundImage = My.Resources.kitty12
        ExamplePictureBox.BackgroundImageLayout = ImageLayout.Zoom
        'If ExamplePictureBox.Visible = False Then
        '    ExamplePictureBox.Show()
        '    ExitButton.Enabled = False
        'Else
        '    ExamplePictureBox.Hide()
        '    ExitButton.Enabled = True
        'End If

        'If RadioButton4.Checked = True Then
        '    ExamplePictureBox.BackColor = System.Drawing.SystemColors.Desktop
        'Else
        '    ExamplePictureBox.BackColor = System.Drawing.SystemColors.Control
        'End If

    End Sub


End Class