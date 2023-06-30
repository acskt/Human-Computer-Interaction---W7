Imports FontAwesome.Sharp

Public Class Form1

    Private currentBtn As IconButton
    Private leftBordersBtn As Panel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBordersBtn = New Panel()
        leftBordersBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBordersBtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBordersBtn.BackColor = customColor
            leftBordersBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBordersBtn.Visible = True
            leftBordersBtn.BringToFront()
            'Current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(75, 101, 132)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, Color.FromArgb(202, 211, 200))
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        ActivateButton(sender, Color.FromArgb(88, 177, 159))
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ActivateButton(sender, Color.FromArgb(214, 162, 232))
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, Color.FromArgb(196, 69, 105))
    End Sub

    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnMarketing.Click
        ActivateButton(sender, Color.FromArgb(189, 197, 129))
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        ActivateButton(sender, Color.FromArgb(249, 127, 81))
    End Sub

End Class
