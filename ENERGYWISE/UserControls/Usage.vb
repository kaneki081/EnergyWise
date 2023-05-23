Imports Guna.UI2.WinForms

Public Class Usage

    Inherits UserControl

    Private isPredict As Boolean
    Public Sub New(ByVal isPredict As Boolean)
        InitializeComponent()
        Me.isPredict = isPredict
    End Sub

    Public Function CreateNewLabel2() As Label
        ' Clear the existing labels in Panel1

        If Appliances.labelList1.Count = 0 AndAlso Appliances.labelList2.Count = 0 AndAlso Appliances.labelList3.Count = 0 Then
            Return Nothing
        End If

        Dim newlabel1 As Integer = 0
        Dim newlabel2 As Integer = 0
        Dim newlabel3 As Integer = 0

        For Each labelIn As Label In Appliances.labelList1
            Dim newlabel As New Label()
            newlabel.Height = 30
            newlabel.Width = 147
            newlabel.AutoSize = False
            newlabel.TextAlign = ContentAlignment.MiddleCenter
            newlabel.BackColor = Color.White
            newlabel.Text = labelIn.Text
            newlabel.Font = New Font("Century SchoolBook", 10, FontStyle.Bold)
            newlabel1 = newlabel1 + 1

            Dim newTextBox As New TextBox()
            newTextBox.BackColor = Color.White
            newTextBox.Height = 30
            newTextBox.Width = 109
            newTextBox.TextAlign = HorizontalAlignment.Center

            If newlabel1 <= 9 Then
                newlabel.Top = newlabel1 * 35
                newTextBox.Top = newlabel1 * 35
                Panel1.Controls.Add(newlabel)
                Panel2.Controls.Add(newTextBox)
            ElseIf newlabel1 <= 18 Then
                newlabel2 = newlabel2 + 1
                newlabel.Top = (newlabel1 - 9) * 35
                newTextBox.Top = (newlabel1 - 9) * 35
                Panel3.Controls.Add(newlabel)
                Panel4.Controls.Add(newTextBox)
            Else
                newlabel3 = newlabel3 + 1
                newlabel.Top = (newlabel1 - 18) * 35
                newTextBox.Top = (newlabel1 - 18) * 35
                Panel5.Controls.Add(newlabel)
                Panel6.Controls.Add(newTextBox)
            End If
        Next

        For Each labelIn As Label In Appliances.labelList2
            Dim newlabel As New Label()
            newlabel.Height = 30
            newlabel.Width = 147
            newlabel.AutoSize = False
            newlabel.TextAlign = ContentAlignment.MiddleCenter
            newlabel.BackColor = Color.White
            newlabel.Text = labelIn.Text
            newlabel.Font = New Font("Century SchoolBook", 10, FontStyle.Bold)
            newlabel1 = newlabel1 + 1

            Dim newTextBox As New TextBox()
            newTextBox.BackColor = Color.White
            newTextBox.Height = 30
            newTextBox.Width = 109
            newTextBox.TextAlign = HorizontalAlignment.Center

            If newlabel1 <= 9 Then
                newlabel.Top = newlabel1 * 35
                newTextBox.Top = newlabel1 * 35
                Panel1.Controls.Add(newlabel)
                Panel2.Controls.Add(newTextBox)
            ElseIf newlabel1 <= 18 Then
                newlabel2 = newlabel2 + 1
                newlabel.Top = (newlabel1 - 9) * 35
                newTextBox.Top = (newlabel1 - 9) * 35
                Panel3.Controls.Add(newlabel)
                Panel4.Controls.Add(newTextBox)
            Else
                newlabel3 = newlabel3 + 1
                newlabel.Top = (newlabel1 - 18) * 35
                newTextBox.Top = (newlabel1 - 18) * 35
                Panel5.Controls.Add(newlabel)
                Panel6.Controls.Add(newTextBox)
            End If
        Next

        For Each labelIn As Label In Appliances.labelList3
            Dim newlabel As New Label()
            newlabel.Height = 30
            newlabel.Width = 147
            newlabel.AutoSize = False
            newlabel.TextAlign = ContentAlignment.MiddleCenter
            newlabel.BackColor = Color.White
            newlabel.Text = labelIn.Text
            newlabel.Font = New Font("Century SchoolBook", 10, FontStyle.Bold)
            newlabel1 = newlabel1 + 1

            Dim newTextBox As New TextBox()
            newTextBox.BackColor = Color.White
            newTextBox.Height = 30
            newTextBox.Width = 109
            newTextBox.TextAlign = HorizontalAlignment.Center

            If newlabel1 <= 9 Then
                newlabel.Top = newlabel1 * 35
                newTextBox.Top = newlabel1 * 35
                Panel1.Controls.Add(newlabel)
                Panel2.Controls.Add(newTextBox)
            ElseIf newlabel1 <= 18 Then
                newlabel2 = newlabel2 + 1
                newlabel.Top = (newlabel1 - 9) * 35
                newTextBox.Top = (newlabel1 - 9) * 35
                Panel3.Controls.Add(newlabel)
                Panel4.Controls.Add(newTextBox)
            Else
                newlabel3 = newlabel3 + 1
                newlabel.Top = (newlabel1 - 18) * 35
                newTextBox.Top = (newlabel1 - 18) * 35
                Panel5.Controls.Add(newlabel)
                Panel6.Controls.Add(newTextBox)
            End If
        Next

        Return Nothing
    End Function


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim appliances As New Appliances() ' Create an instance of the Appliances class
        CreateNewLabel2()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Disable the button in Form1
        Dim form1 As Form1 = TryCast(Me.ParentForm, Form1)
        If form1 IsNot Nothing Then
            form1.Guna2Button4.Enabled = True
        End If
    End Sub

End Class
