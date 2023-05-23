Imports System.Windows.Forms

Public Class ApplianceListForm
    Inherits Form

    Private appliances() As String = {
        "washing machine", "heater", "iron", "lamp",
        "blender", "refrigerator", "dvd", "television",
        "speaker", "aircon", "fan", "pc", "scanner",
        "rice cooker", "microwave", "water dispenser",
        "dryer", "vacuum", "hair dryer"
    }

    Public Sub New()
        InitializeComponent()
        PopulateAppliances()
    End Sub

    Private Sub PopulateAppliances()
        For Each appliance In appliances
            ListBox1.Items.Add(appliance)
        Next
    End Sub
End Class
