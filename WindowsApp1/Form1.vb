Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        dropdown.Items.Add("Addition")
        dropdown.Items.Add("Subtraction")
        dropdown.Items.Add("Multiplication")
        dropdown.Items.Add("Division")
    End Sub

    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles num0.Click, num1.Click, num2.Click, num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click, equal.Click, decpoint.Click, clear.Click, del.Click, plusminus.Click, memclear.Click, memminus.Click, memplus.Click, memrecall.Click, memstore.Click, insert.Click

        Dim button As Button = CType(sender, Button)
        If button.Name = "num0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If

        If button.Name = "num1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If

        If button.Name = "num2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If

        If button.Name = "num3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If

        If button.Name = "num4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If

        If button.Name = "num5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If

        If button.Name = "num6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If

        If button.Name = "num7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If

        If button.Name = "num8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If

        If button.Name = "num9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If

        If button.Name = "decpoint" Then
            TextBox1.Text = TextBox1.Text + ""
        End If

        If button.Name = "add" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If

        If button.Name = "subtract" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If

        If button.Name = "divide" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If

        If button.Name = "multiply" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If

        If button.Name = "clear" Then
            TextBox1.Text = ""
        End If

        If button.Name = "decpoint" Then
            TextBox1.Text = TextBox1.Text + "."
        End If

        If button.Name = "equal" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result

        End If

        If button.Name = "insert" Then
            If dropdown.Text = "Addition" Then
                TextBox1.Text = TextBox1.Text + "+"
            ElseIf dropdown.Text = "Subtraction" Then
                TextBox1.Text = TextBox1.Text + "-"
            ElseIf dropdown.Text = "Multiplication" Then
                TextBox1.Text = TextBox1.Text + "*"
            ElseIf dropdown.Text = "Division" Then
                TextBox1.Text = TextBox1.Text + "/"
            End If
        End If

        If button.Name = "plusminus" Then
            TextBox1.Text = "-" + TextBox1.Text
        End If

        If button.Name = "memstore" Then
            Label1.Text = TextBox1.Text
        End If

        If button.Name = "memrecall" Then
            TextBox1.Text = Label1.Text
        End If

        If button.Name = "memplus" Then
            TextBox1.Text = TextBox1.Text + "+" + Label1.Text
        End If

        If button.Name = "memminus" Then
            TextBox1.Text = TextBox1.Text + "-" + Label1.Text

        End If


        If button.Name = "del" Then
            If TextBox1.Text.Length > 0 Then
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
            End If
        End If

    End Sub

    Private Sub dropdown_SelectedItemChanged(sender As Object, e As EventArgs) Handles dropdown.SelectedItemChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
