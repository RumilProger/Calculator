Imports System.Math


Public Class Form1
    Private C As Double
    Private A As Double
    Private B As Double

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Buttin1_Click()
        C = (Val(TextBox1.Text) + Val(TextBox2))
        PictureBox1.Print(C)
    End Sub
    Private Sub Buttin10_Click()
        C = ((Log(Val(TextBox1.Text))) / (Math.Log(Val(TextBox2))))
        PictureBox1.Print(C)
    End Sub
    Private Sub Buttin11_Click()
        PictureBox1.Print(Log(Val(TextBox1.Text)))
    End Sub
    Private Sub Buttin12_Click()
        PictureBox1.Prin(Log(Val(TextBox2)))
    End Sub
    Private Sub Button13_Click()
        PictureBox1.Print(Abs(Val(TextBox1.Text)))
    End Sub
    Private Sub Button14_Click()
        PictureBox1.Print(Abs(Val(TextBox2)))
    End Sub


    Private Sub Button15_Click()
        PictureBox1.Print(Sqrt(Val(TextBox1.Text)))
    End Sub
    Private Sub Button16_Click()
        PictureBox1.Print(Sqrt(Val(TextBox2)))
    End Sub
    Private Sub Button17_Click()
        PictureBox1.Print(Atan(Val(TextBox1.Text)))
    End Sub
    Private Sub Button18_Click()

    End Sub
    Private Sub Button19_Click()
        TextBox1.Text = ""
        TextBox2.Text = ""
        PictureBox1.Cls
    End Sub
    Private Sub Button2_Click()

        PictureBox1.Print(Val(TextBox1.Text) - Val(TextBox2))
    End Sub
    Private Sub Button20_Click()
        TextBox1.Text = TextBox1.Text & "1"
    End Sub
    Private Sub Button21_Click()
        TextBox1.Text = TextBox1.Text & "2"
    End Sub
    Private Sub Button22_Click()
        TextBox1.Text = TextBox1.Text & "3"
    End Sub
    Private Sub Button24_Click()
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button25_Click()
        TextBox1.Text = TextBox1.Text & "5"
    End Sub
    Private Sub Button26_Click()
        TextBox1.Text = TextBox1.Text & "6"
    End Sub
    Private Sub Button27_Click()
        TextBox1.Text = TextBox1.Text & "7"
    End Sub
    Private Sub Button28_Click()
        TextBox1.Text = TextBox1.Text & "8"
    End Sub
    Private Sub Button29_Click()
        TextBox1.Text = TextBox1.Text & "9"
    End Sub
    Private Sub Button3_Click()
        A = Val(TextBox1)
        B = Val(TextBox2)
        PictureBox.Print(Val(TextBox1) * Val(TextBox2))
    End Sub
    Private Sub Button30_Click()
        TextBox1.Text = TextBox1.Text & "0"
    End Sub
    Private Sub Button31_Click()
        TextBox2.Text = TextBox2.Text & "1"
    End Sub
    Private Sub Button32_Click()
        TextBox2.Text = TextBox2.Text & "2"
    End Sub
    Private Sub Button33_Click()
        TextBox2.Text = TextBox2.Text & "3"
    End Sub

    Private Sub Button34_Click()
        TextBox2.Text = TextBox2.Text & "4"
    End Sub
    Private Sub Button35_Click()
        TextBox2.Text = TextBox2.Text & "5"
    End Sub
    Private Sub Button36_Click()
        TextBox2.Text = TextBox2.Text & "6"
    End Sub
    Private Sub Button37_Click()
        TextBox2.Text = TextBox2.Text & "7"
    End Sub
    Private Sub Button38_Click()
        TextBox2.Text = TextBox2.Text & "8"
    End Sub
    Private Sub Button39_Click()
        TextBox2.Text = TextBox2.Text & "9"
    End Sub
    Private Sub Button4_Click()
        If B = 0 Then
            PictureBox1.Print("на ноль делить нельзя")
        Else
            PictureBox1.Print(Val(TextBox1) / Val(TextBox2))
        End If
    End Sub
    Private Sub Button40_Click()
        TextBox2.Text = TextBox2.Text & "0"
    End Sub
    Private Sub Button5_Click()
        PictureBox1.Print(Sin(Val(TextBox1)))
    End Sub
    Private Sub Button6_Click()
        PictureBox1.Print(Cos(Val(TextBox1)))
    End Sub

    Private Sub Buttin7_Click()
        PictureBox1.Print(Tan(Val(TextBox1)))
    End Sub
    Private Sub Buttin8_Click()
        PictureBox1.Print(Cos(Val(TextBox1)) / Sin(Val(TextBox1)))
    End Sub
    Private Sub Buttin9_Click()
        PictureBox1.Print(Val(TextBox1) ^ Val(TextBox2))
    End Sub
End Class
