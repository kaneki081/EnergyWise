Imports Guna.UI2.WinForms


Public Class Appliances
    Dim newlabel1 As Integer = 1
    Dim newlabel2 As Integer = 1
    Dim newlabel3 As Integer = 1

    Dim appliances() As String = {
    "washing machine", "heater", "iron", "lamp",
    "blender", "refrigerator", "dvd", "television",
    "speaker", "aircon", "fan", "pc", "scanner",
    "rice cooker", "microwave", "water dispender",
    "dryer", "vacuum", "hair dryer"
}

    Dim powerRatings() As Integer = {
    280, 1500, 750, 20, 300,
    90, 380, 727, 50, 225,
    175, 12, 450, 1200, 550,
    1600, 400, 320
}

    Public Shared labelList1 As New List(Of Label)()
    Public Shared labelList2 As New List(Of Label)()
    Public Shared labelList3 As New List(Of Label)()

    Public Function CreateNewLabel1(PanelBox As Panel, textBox As Guna2TextBox) As Label
        If String.IsNullOrEmpty(textBox.Text) OrElse textBox.Text = "None" Then
            Return Nothing ' Don't create a label if the conditions are met
        End If

        For Each existingLabel As Label In labelList1
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        For Each existingLabel As Label In labelList2
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        For Each existingLabel As Label In labelList3
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        Dim input As String = textBox.Text
        Dim userInput As String = input.Replace(" ", "")

        For Each appliance As String In appliances
            Dim item As String = appliance
            Dim finalItem As String = item.Replace(" ", "")
            If String.Compare(userInput, finalItem, True) = 0 Then
                Dim labelIn As New Label()
                labelIn.Height = 30
                labelIn.Width = 250
                labelIn.TextAlign = 2
                labelIn.BackColor = Color.White
                labelIn.Top = newlabel1 * 35
                labelIn.Text = appliance
                labelIn.Font = New Font("Century SchoolBook", 12, FontStyle.Bold)
                newlabel1 = newlabel1 + 1

                ' Create a delete button next to the label
                Dim deleteButton As New Button()
                deleteButton.Text = "Delete"
                deleteButton.Tag = labelIn ' Store the corresponding label in the button's Tag property

                ' Set the event handler for the delete button's Click event
                AddHandler deleteButton.Click, AddressOf DeleteButton_Click1

                ' Create a panel to hold the label and delete button
                Dim panel As New Panel()
                panel.Height = 30
                panel.Controls.Add(labelIn)
                panel.Controls.Add(deleteButton)
                panel.AutoSize = True ' Adjust the panel's size to fit its contents

                ' Add the panel to the FlowLayoutPanel
                PanelBox.Controls.Add(panel)

                ' Add the label to the list for future reference
                labelList1.Add(labelIn)
                Return labelIn
            End If
        Next
        MessageBox.Show("The appliance is not found in the list.")
        Return Nothing
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If labelList1.Count < 9 Then
            CreateNewLabel1(Panel1, textbox1)
            textbox1.Text = ""
            If labelList1.Count >= 9 Then
                Guna2Button1.Enabled = False ' Disable the add button when labelList reaches 9
            Else
                Guna2Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click1(sender As Object, e As EventArgs)
        ' Check if there are any labels to delete
        If labelList1.Count > 0 Then
            ' Get the index of the last label in the list
            Dim lastIndex As Integer = labelList1.Count - 1

            ' Get the corresponding label from the list
            Dim labelToDelete As Label = labelList1(lastIndex)

            ' Remove the label from the list and from the FlowLayoutPanel
            labelList1.RemoveAt(lastIndex)
            Panel1.Controls.Remove(labelToDelete.Parent)

            SaveLabelLists()


            ' Rearrange the labels
            RearrangeLabels1()
        End If

        If labelList1.Count < 9 Then
            Guna2Button1.Enabled = True
        End If
    End Sub

    Private Sub RearrangeLabels1()
        ' Reset the label index
        newlabel1 = 1

        ' Rearrange the labels in the FlowLayoutPanel
        For Each labelIn As Label In labelList1
            labelIn.Top = newlabel1 * 35
            newlabel1 += 1
        Next
    End Sub



    Public Function CreateNewLabel2(PanelBox As Panel, textBox As Guna2TextBox) As Label
        If String.IsNullOrEmpty(textBox.Text) OrElse textBox.Text = "None" Then
            Return Nothing ' Don't create a label if the conditions are met
        End If

        ' Check if a label with the same text already exists
        For Each existingLabel As Label In labelList1
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        For Each existingLabel As Label In labelList2
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        For Each existingLabel As Label In labelList3
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next


        Dim labelIn As New Label()
        labelIn.Height = 30
        labelIn.Width = 250
        labelIn.TextAlign = 2
        labelIn.BackColor = Color.White
        labelIn.Top = newlabel2 * 35
        labelIn.Text = textBox.Text
        labelIn.Font = New Font("Century SchoolBook", 12, FontStyle.Bold)
        newlabel2 = newlabel2 + 1

        ' Create a delete button next to the label
        Dim deleteButton As New Button()
        deleteButton.Text = "Delete"
        deleteButton.Tag = labelIn ' Store the corresponding label in the button's Tag property

        ' Set the event handler for the delete button's Click event
        AddHandler deleteButton.Click, AddressOf DeleteButton_Click2

        ' Create a panel to hold the label and delete button
        Dim panel As New Panel()
        panel.Height = 30
        panel.Controls.Add(labelIn)
        panel.Controls.Add(deleteButton)
        panel.AutoSize = True ' Adjust the panel's size to fit its contents

        ' Add the panel to the FlowLayoutPanel
        PanelBox.Controls.Add(panel)

        ' Add the label to the list for future reference
        labelList2.Add(labelIn)

        Return labelIn
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If labelList2.Count < 9 Then
            CreateNewLabel2(Panel2, textbox2)
            textbox2.Text = ""
            If labelList2.Count >= 9 Then
                Guna2Button2.Enabled = False
            Else
                Guna2Button2.Enabled = True
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click2(sender As Object, e As EventArgs)
        ' Check if there are any labels to delete
        If labelList2.Count > 0 Then
            ' Get the index of the last label in the list
            Dim lastIndex As Integer = labelList2.Count - 1

            ' Get the corresponding label from the list
            Dim labelToDelete As Label = labelList2(lastIndex)

            ' Remove the label from the list and from the FlowLayoutPanel
            labelList2.RemoveAt(lastIndex)
            Panel2.Controls.Remove(labelToDelete.Parent)

            SaveLabelLists()


            ' Rearrange the labels
            RearrangeLabels2()
        End If

        If labelList2.Count < 9 Then
            Guna2Button2.Enabled = True
        End If
    End Sub

    Private Sub RearrangeLabels2()
        ' Reset the label index
        newlabel2 = 1

        ' Rearrange the labels in the FlowLayoutPanel
        For Each labelIn As Label In labelList2
            labelIn.Top = newlabel2 * 35
            newlabel2 += 1
        Next
    End Sub



    Public Function CreateNewLabel3(PanelBox As Panel, textBox As Guna2TextBox) As Label
        If String.IsNullOrEmpty(textBox.Text) OrElse textBox.Text = "None" Then
            Return Nothing ' Don't create a label if the conditions are met
        End If

        ' Check if a label with the same text already exists
        For Each existingLabel As Label In labelList1
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        For Each existingLabel As Label In labelList2
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next

        For Each existingLabel As Label In labelList3
            If existingLabel.Text = textBox.Text Then
                Return Nothing ' Don't create a label if the text already exists
            End If
        Next


        Dim labelIn As New Label()
        labelIn.Height = 30
        labelIn.Width = 250
        labelIn.TextAlign = 2
        labelIn.BackColor = Color.White
        labelIn.Top = newlabel3 * 35
        labelIn.Text = textBox.Text
        labelIn.Font = New Font("Century SchoolBook", 12, FontStyle.Bold)
        newlabel3 = newlabel3 + 1

        ' Create a delete button next to the label
        Dim deleteButton As New Button()
        deleteButton.Text = "Delete"
        deleteButton.Tag = labelIn ' Store the corresponding label in the button's Tag property

        ' Set the event handler for the delete button's Click event
        AddHandler deleteButton.Click, AddressOf DeleteButton_Click3

        ' Create a panel to hold the label and delete button
        Dim panel As New Panel()
        panel.Height = 30
        panel.Controls.Add(labelIn)
        panel.Controls.Add(deleteButton)
        panel.AutoSize = True ' Adjust the panel's size to fit its contents

        ' Add the panel to the FlowLayoutPanel
        PanelBox.Controls.Add(panel)

        ' Add the label to the list for future reference
        labelList3.Add(labelIn)

        Return labelIn
    End Function

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If labelList3.Count < 9 Then
            CreateNewLabel3(Panel3, textbox3)
            textbox3.Text = ""
            If labelList3.Count >= 9 Then
                Guna2Button3.Enabled = False
            Else
                Guna2Button3.Enabled = True
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click3(sender As Object, e As EventArgs)
        ' Check if there are any labels to delete
        If labelList3.Count > 0 Then
            ' Get the index of the last label in the list
            Dim lastIndex As Integer = labelList3.Count - 1

            ' Get the corresponding label from the list
            Dim labelToDelete As Label = labelList3(lastIndex)

            ' Remove the label from the list and from the FlowLayoutPanel
            labelList3.RemoveAt(lastIndex)
            Panel3.Controls.Remove(labelToDelete.Parent)

            SaveLabelLists()

            ' Rearrange the labels
            RearrangeLabels3()
        End If

        If labelList3.Count < 9 Then
            Guna2Button3.Enabled = True
        End If
    End Sub

    Private Sub RearrangeLabels3()
        ' Reset the label index
        newlabel3 = 1

        ' Rearrange the labels in the FlowLayoutPanel
        For Each labelIn As Label In labelList3
            labelIn.Top = newlabel3 * 35
            newlabel3 += 1
        Next
    End Sub


    Public Sub SaveLabelLists()
        ' Save the label lists to a file
        ' You can choose a suitable file format, such as JSON or XML, to store the data
        ' Here, we'll use a simple text file for demonstration purposes

        ' Save labelList1
        Dim labelList1Data As String = String.Join(",", labelList1.Select(Function(label) label.Text))
        My.Computer.FileSystem.WriteAllText("labelList1.txt", labelList1Data, False)

        ' Save labelList2
        Dim labelList2Data As String = String.Join(",", labelList2.Select(Function(label) label.Text))
        My.Computer.FileSystem.WriteAllText("labelList2.txt", labelList2Data, False)

        ' Save labelList3
        Dim labelList3Data As String = String.Join(",", labelList3.Select(Function(label) label.Text))
        My.Computer.FileSystem.WriteAllText("labelList3.txt", labelList3Data, False)
    End Sub

    Public Sub LoadLabelLists()
        ' Load the label lists from the file

        ' Load labelList1
        If My.Computer.FileSystem.FileExists("labelList1.txt") Then
            Dim labelList1Data As String = My.Computer.FileSystem.ReadAllText("labelList1.txt")
            labelList1.Clear()
            For Each labelText As String In labelList1Data.Split(","c)
                Dim label As New Label()
                label.Text = labelText
                labelList1.Add(label)
            Next
        End If

        ' Load labelList2
        If My.Computer.FileSystem.FileExists("labelList2.txt") Then
            Dim labelList2Data As String = My.Computer.FileSystem.ReadAllText("labelList2.txt")
            labelList2.Clear()
            For Each labelText As String In labelList2Data.Split(","c)
                Dim label As New Label()
                label.Text = labelText
                labelList2.Add(label)
            Next
        End If

        ' Load labelList3
        If My.Computer.FileSystem.FileExists("labelList3.txt") Then
            Dim labelList3Data As String = My.Computer.FileSystem.ReadAllText("labelList3.txt")
            labelList3.Clear()
            For Each labelText As String In labelList3Data.Split(","c)
                Dim label As New Label()
                label.Text = labelText
                labelList3.Add(label)
            Next
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim applianceForm As New ApplianceListForm()
        applianceForm.ShowDialog()
    End Sub
End Class
