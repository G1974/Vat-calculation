Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Net ➜ with TAX")
        ComboBox1.Items.Add("With Tax ➜ Net")
        ComboBox1.SelectedIndex = 0

        ComboBox2.Items.Add("24%")
        ComboBox2.Items.Add("13%")
        ComboBox2.Items.Add("6%")
        ComboBox2.Items.Add("Other...")
        ComboBox2.SelectedIndex = 0
        TextBox2.Visible = False
        Label4.Text = "Result:"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label2.Text = "Net amount (€)"
        Else
            Label2.Text = "Amount with Tax (€)"
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.ToString() = "Other..." Then
            TextBox2.Visible = True
        Else
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ποσό As Decimal
        Dim φπα As Decimal
        Dim ποσο_φπα As Decimal

        If Not Decimal.TryParse(TextBox1.Text, ποσό) OrElse ποσό < 0 Then
            MessageBox.Show("Please provide a valid amount.", "Failed")
            Exit Sub
        End If
        If ComboBox2.SelectedItem.ToString() = "Other..." Then
            If Not Decimal.TryParse(TextBox2.Text, φπα) OrElse φπα < 0 Or φπα > 100 Then
                MessageBox.Show("Please provide a valid VAT rate(0-100).", "Failed")
                Exit Sub
            End If
        Else
            φπα = Decimal.Parse(ComboBox2.SelectedItem.ToString().Replace("%", ""))
        End If
        Dim αποτέλεσμα As Decimal

        If ComboBox1.SelectedIndex = 0 Then
            αποτέλεσμα = ποσό * (1 + (φπα / 100))
            ποσο_φπα = αποτέλεσμα - ποσό
            Label4.Text = "Final amount with VAT: " & αποτέλεσμα.ToString("N2") & " €" &
                  vbCrLf & "TAX: " & ποσο_φπα.ToString("N2") & " €"
        Else
            αποτέλεσμα = ποσό / (1 + (φπα / 100))
            ποσο_φπα = ποσό - αποτέλεσμα
            Label4.Text = "Net amount without VAT: " & αποτέλεσμα.ToString("N2") & " €" &
                  vbCrLf & "TAX: " & ποσο_φπα.ToString("N2") & " €"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        TextBox2.Visible = False
        Label4.Text = "Result:"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

