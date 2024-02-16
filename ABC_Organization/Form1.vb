Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstbShowDetails.Items.Add("Name :" & txtSName.Text)
        lstbShowDetails.Items.Add("Index No :" & txtINo.Text)
        Dim OGpa As Double = 0
        Dim a As String
        OGpa = Val(txtTGpa.Text) * 0.3 + Val(txtSGpa.Text) * 0.3 + Val(txtTGpa.Text) * 0.4
        lstbShowDetails.Items.Add("Overall GPA :" & OGpa)

        If OGpa <= 0.0 And OGpa < 3.0 Then
            lstbShowDetails.Items.Add("Class :" & "General Pass ")

        ElseIf OGpa <= 3.0 And OGpa < 3.3 Then
            lstbShowDetails.Items.Add("Class :" & "Secound Class Lower  Division ")
        ElseIf OGpa <= 3.3 And OGpa < 3.6 Then

            lstbShowDetails.Items.Add("Class :" & "Secound Class Upper  Division ")


        ElseIf OGpa <= 3.6 And OGpa >= 4.0 Then
            lstbShowDetails.Items.Add("Class :" & "First Class")



        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFGpa.Clear()
        txtINo.Clear()
        txtSGpa.Clear()
        txtSName.Clear()
        txtTGpa.Clear()
        'RadioButtonFStudent = ""
        'RadioButtonLStudent = ""
        lstbShowDetails.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
