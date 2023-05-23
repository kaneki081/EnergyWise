Partial Public Class Form1
    Inherits Form

    Dim isPredict As Boolean = False

    Public Sub New()
        InitializeComponent()
        Dim home As New Home()
        addUserControl(home)

        Guna2Button4.Enabled = isPredict
    End Sub

    Private Sub addUserControl(ByVal userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        PanelContainer.Controls.Clear()
        PanelContainer.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim home As New Home()
        addUserControl(home)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim appliance As New Appliances()
        addUserControl(appliance)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim usage As New Usage(isPredict)
        addUserControl(usage)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim prediction As New Predictions()
        addUserControl(prediction)
    End Sub
End Class
