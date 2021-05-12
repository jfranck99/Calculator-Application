Imports System.Math
Public Class Form1
    Dim FN(100) As Decimal 'First number
    Dim SN(100) As Decimal 'Second number 
    Dim RN As Decimal 'Result number
    Dim Mem As Decimal = 0 'Memory
    Dim POPR(100) As String 'Previous operator
    Dim index As Integer 'index of arrays

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Disp.Text = "0"
    End Sub
    Private Sub Bttn_Click(sender As Object, e As EventArgs) Handles Bttn0.Click, Bttn1.Click, Bttn2.Click, Bttn3.Click, Bttn4.Click, Bttn5.Click, Bttn6.Click, Bttn7.Click, Bttn8.Click, Bttn9.Click

        If Disp.Text = "0" Then Disp.Text = ""

        Disp.Text += sender.text

    End Sub

    Private Sub BttnClear_Click(sender As Object, e As EventArgs) Handles BttnClearExpression.Click
        Disp.Text = "0"

        FN(index) = 0
        SN(index) = 0
        RN = 0
    End Sub

    Private Sub BttnClear_Click_1(sender As Object, e As EventArgs) Handles BttnClear.Click
        Disp.Text = "0"
    End Sub

    Private Sub BttnMemSave_Click(sender As Object, e As EventArgs) Handles BttnMemSave.Click
        Mem = Disp.Text
        BttnMemClear.Enabled = True
        BttnMemRestore.Enabled = True
    End Sub

    Private Sub BttnMemRestore_Click(sender As Object, e As EventArgs) Handles BttnMemRestore.Click
        Disp.Text = Mem
    End Sub

    Private Sub BttnMemPlus_Click(sender As Object, e As EventArgs) Handles BttnMemPlus.Click
        BttnEquals.PerformClick()

        FN(index) = Disp.Text
        Disp.Text = FN(index) + Mem
        BttnEquals.PerformClick()

    End Sub
    Private Sub BttnMemMinus_Click(sender As Object, e As EventArgs) Handles BttnMemMinus.Click
        BttnEquals.PerformClick()

        FN(index) = Disp.Text
        Disp.Text = FN(index) - Mem
        BttnEquals.PerformClick()

    End Sub

    Private Sub BttnDecimal_Click(sender As Object, e As EventArgs) Handles BttnDecimal.Click

        If Disp.Text.IndexOf(BttnDecimal.Text) < 0 Then Disp.Text += sender.text

    End Sub

    Private Sub BttnMemClear_Click(sender As Object, e As EventArgs) Handles BttnMemClear.Click
        Mem = 0
        BttnMemClear.Enabled = False
        BttnMemRestore.Enabled = False
    End Sub

    Private Sub BttnPlusMinus_Click(sender As Object, e As EventArgs) Handles BttnPlusMinus.Click
        Disp.Text = 0 - Disp.Text

    End Sub
    Private Sub ButtPlus_Click(sender As Object, e As EventArgs) Handles BttnPlus.Click, BttnMinus.Click, BttnMultiply.Click, BttnDivide.Click

        If POPR(index) <> "" Then
            BttnEquals.PerformClick()
        End If

        POPR(index) = sender.text

        FN(index) = Disp.Text

        Disp.Text = "0"

    End Sub

    Private Sub BttnEquals_Click(sender As Object, e As EventArgs) Handles BttnEquals.Click

        SN(index) = Disp.Text

        Disp.Text = "0"

        Select Case POPR(index)
            Case "+"
                RN = FN(index) + SN(index)
            Case "-"
                RN = FN(index) - SN(index)
            Case "*"
                RN = FN(index) * SN(index)
            Case "/"
                RN = FN(index) / SN(index)
            Case "M+"
                RN = FN(index) + Mem

        End Select

        Disp.Text = RN.ToString

        POPR(index) = ""
    End Sub

    Private Sub Bttn_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.D0
                Bttn0.PerformClick()

            Case Keys.NumPad0
                Bttn0.PerformClick()

            Case Keys.D1
                Bttn1.PerformClick()
            Case Keys.NumPad1
                Bttn1.PerformClick()

            Case Keys.D2
                Bttn2.PerformClick()
            Case Keys.NumPad2
                Bttn2.PerformClick()

            Case Keys.D3
                Bttn3.PerformClick()
            Case Keys.NumPad3
                Bttn3.PerformClick()

            Case Keys.D4
                Bttn4.PerformClick()
            Case Keys.NumPad4
                Bttn4.PerformClick()

            Case Keys.D5
                Bttn5.PerformClick()
            Case Keys.NumPad5
                Bttn5.PerformClick()

            Case Keys.D6
                Bttn6.PerformClick()
            Case Keys.NumPad6
                Bttn6.PerformClick()

            Case Keys.D7
                Bttn7.PerformClick()
            Case Keys.NumPad7
                Bttn7.PerformClick()

            Case Keys.D8
                Bttn8.PerformClick()
            Case Keys.NumPad8
                Bttn8.PerformClick()

            Case Keys.D9
                Bttn9.PerformClick()
            Case Keys.NumPad9
                Bttn9.PerformClick()

            Case Keys.Add
                BttnPlus.PerformClick()
            Case Keys.Oemplus
                BttnPlus.PerformClick()

            Case Keys.Subtract
                BttnMinus.PerformClick()
            Case Keys.OemMinus
                BttnMinus.PerformClick()

            Case Keys.Multiply
                BttnMultiply.PerformClick()

            Case Keys.Divide
                BttnDivide.PerformClick()
            Case Keys.OemBackslash
                BttnDivide.PerformClick()

            Case Keys.Decimal
                BttnDecimal.PerformClick()

            Case Keys.Enter
                BttnEquals.PerformClick()

        End Select
    End Sub

    Private Sub BttnOpenP_Click(sender As Object, e As EventArgs) Handles BttnOpenP.Click
        index += 1
    End Sub

    Private Sub BttnCloseP_Click(sender As Object, e As EventArgs) Handles BttnCloseP.Click
        BttnEquals.PerformClick()
        index -= 1
    End Sub

    Private Sub BttnSqr_Click(sender As Object, e As EventArgs) Handles BttnSqr.Click
        Disp.Text = Convert.ToDecimal(Disp.Text) * Convert.ToDecimal(Disp.Text)
    End Sub

    Private Sub BttnFraction_Click(sender As Object, e As EventArgs) Handles BttnFraction.Click
        Disp.Text = 1 / Convert.ToDecimal(Disp.Text)
    End Sub

    Private Sub BttnSin_Click(sender As Object, e As EventArgs) Handles BttnSin.Click
        'Dim x = Convert.ToDecimal(Disp.Text)
        'Dim count As Integer

        'Dim T As Decimal 'Terms
        'Dim TT As Decimal = 0 'Total Terms (the answer)

        'While x > 180 'Converts number to smallest supplemental angle in radians
        '    x -= 180
        '    count += 1
        'End While
        'x = x * (-1 * count) * (PI / 180)

        'Dim n As Integer = 1
        'T = x


        'While Abs(T) > 0.001 'Finds sine of x
        '    TT = TT + T
        '    n = n + 2
        '    T = (T * x * x) / n * (n - 1)
        'End While

        'Disp.Text = TT

        Disp.Text = Math.Sin(Convert.ToDecimal(Disp.Text) * (PI / 180)) 'multiply by pi/180 to convert to radians

    End Sub

    Private Sub BttnCos_Click(sender As Object, e As EventArgs) Handles BttnCos.Click

        Disp.Text = Math.Cos(Convert.ToDecimal(Disp.Text) * (PI / 180)) 'multiply by pi/180 to convert to radians

    End Sub

    Private Sub BttnTan_Click(sender As Object, e As EventArgs) Handles BttnTan.Click

        Disp.Text = Math.Tan(Convert.ToDecimal(Disp.Text) * (PI / 180)) 'multiply by pi/180 to convert to radians

    End Sub

    Private Sub BttnPi_Click(sender As Object, e As EventArgs) Handles BttnPi.Click
        BttnEquals.PerformClick()

        Disp.Text = Math.PI

    End Sub

    Private Sub BttnBinary_Click(sender As Object, e As EventArgs) Handles BttnBinary.Click

        BttnBinary.Enabled = False

        If BttnDec.Enabled = False Then

            Dim dec As Integer = Convert.ToInt32(Disp.Text)
            Dim bin As Integer
            Dim output As String = ""
            While dec <> 0
                If dec Mod 2 > 0 Then
                    bin = 1
                Else
                    bin = 0
                End If
                dec = dec \ 2
                output = Convert.ToString(bin) & output
            End While
            Disp.Text = output

            BttnDec.Enabled = True

        ElseIf BttnOctary.Enabled = False Then
            BttnDec.PerformClick()
            BttnOctary.PerformClick()

        Else 'Hexadecimal

            BttnDec.PerformClick()
            BttnHexa.PerformClick()
            BttnHexa.Enabled = False

        End If
    End Sub

    Private Sub BttnDec_Click(sender As Object, e As EventArgs) Handles BttnDec.Click

        BttnDec.Enabled = False

        If BttnBinary.Enabled = False Then
            Disp.Text = Convert.ToInt32(Disp.Text, 2)
            BttnBinary.Enabled = True
        ElseIf BttnOctary.Enabled = False Then
            Disp.Text = Convert.ToInt32(Disp.Text, 8)
            BttnOctary.Enabled = True

        Else 'Hexadecimal
            BttnHexa.Enabled = True

            'hexadecimal to decimal
        End If
    End Sub

    Private Sub BttnOctary_Click(sender As Object, e As EventArgs) Handles BttnOctary.Click

        BttnOctary.Enabled = False

        If BttnDec.Enabled = False Then

            Dim dec As Integer = Convert.ToInt32(Disp.Text)
            Dim oct As Integer
            Dim output As String = ""
            While dec <> 0
                If dec Mod 8 > 0 Then
                    oct = dec Mod 8
                Else
                    oct = 0
                End If
                dec = dec \ 8
                output = Convert.ToString(oct) & output
            End While
            Disp.Text = output
            BttnDec.Enabled = True

        ElseIf BttnBinary.Enabled = False Then
            BttnDec.PerformClick()
            BttnBinary.PerformClick()

        Else 'Hexadecimal
            BttnDec.PerformClick()
            BttnHexa.PerformClick()

        End If
    End Sub

    Private Sub BttnHexa_Click(sender As Object, e As EventArgs) Handles BttnHexa.Click
        BttnHexa.Enabled = False

        If BttnDec.Enabled = False Then
            'Decimal to Hexadecimal

        ElseIf BttnBinary.Enabled = False Then
            BttnDec.PerformClick()
            BttnBinary.PerformClick()

        Else 'Octary
            BttnDec.PerformClick()
            BttnOctary.PerformClick()
            
        End If
    End Sub

    Private Sub Disp_TextChanged(sender As Object, e As EventArgs) Handles Disp.TextChanged

    End Sub
End Class
