Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R, D As Double

        If IsNumeric(RadioTxt.Text) = True Then
            R = Convert.ToDouble(RadioTxt.Text)
            If CDbl(RadioTxt.Text) > 0 And CDbl(RadioTxt.Text) < 100 Then
                D = 2 * R
                Diam.Text = (D).ToString
            Else
                MessageBox.Show("Error, rango excedido")
                RadioTxt.Clear()
            End If
        Else
            MessageBox.Show("Erro, ingrese solo numeros")
            RadioTxt.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim R, Cir, Pi As Double

        If IsNumeric(RadioTxt.Text) = True Then
            R = Convert.ToDouble(RadioTxt.Text)
            If CDbl(RadioTxt.Text) > 0 And CDbl(RadioTxt.Text) < 100 Then
                Pi = 3.14159265
                Cir = 2 * Pi * R
                Circun.Text = (Cir).ToString
            Else
                MessageBox.Show("Error, rango excedido")
                RadioTxt.Clear()
            End If
        Else
            MessageBox.Show("Error, debe ingresar numeros")
            RadioTxt.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim R, A, Pi As Double

        If IsNumeric(RadioTxt.Text) = True Then
            R = Convert.ToDouble(RadioTxt.Text)
            If CDbl(RadioTxt.Text) > 0 And CDbl(RadioTxt.Text) < 100 Then
                Pi = 3.14159265
                A = Pi * R ^ 2
                Area.Text = (A).ToString
            Else
                MessageBox.Show("Error, rango excedido")
                RadioTxt.Clear()
            End If
        Else
            MessageBox.Show("Error, debe ingresar numeros")
            RadioTxt.Clear()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RadioTxt.Clear()
        Diam.Text = ""
        Circun.Text = ""
        Area.Text = ""
    End Sub
End Class
