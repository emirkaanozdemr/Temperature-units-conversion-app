Module UntitledModule
    Dim buttonw, Kullanımkılavuzu, button1, button2, button4, button9, button13, button15, button16, button17, button18, button19, button20, button21, lastbutton, calculate, textbox1, textbox1i, calculate2, textbox2, textbox1i2, calculate4, textbox3, textbox1i4, calculate9, textbox5, textbox1i9, calculate13, textbox6, textbox1i13, calculate15, textbox7, textbox1i15, calculate16, textbox8, textbox1i16, calculate17, textbox9, textbox1i17, calculate18, textbox10, textbox1i18, calculate19, textbox11, textbox1i19, textbox1i20, calculate20, textbox12, calculate21, textbox13, textbox1i21 As Primitive
    Sub Main()
        GraphicsWindow.DrawText(100, 100, "Please, read user guide.")
        buttonw = Controls.AddButton("Settings", 1100, 50)
        'Celsius
        Kullanımkılavuzu = Controls.AddButton("User Guide", 1165, 50)
        button1 = Controls.AddButton("Celsius To Fahrenheit", 525, 300)
        button2 = Controls.AddButton("Celsius To Kelvin", 385, 300)
        button4 = Controls.AddButton("Celsius To Rømer", 250, 300)

        'Fahrenheit
        button9 = Controls.AddButton("Fahrenheit To Celsius", 405, 350)
        button13 = Controls.AddButton("Fahrenheit To Kelvin", 560, 350)
        button15 = Controls.AddButton("Fahrenheit To Rømer", 250, 350)
        'Kelvin
        button16 = Controls.AddButton("Kelvin To Celsius", 405, 400)
        button17 = Controls.AddButton("Kelvin To Fahrenheit", 560, 400)
        button18 = Controls.AddButton("Kelvin To Rømer", 250, 400)
        'Rømer
        button19 = Controls.AddButton("Rømer To Celsius", 405, 450)
        button20 = Controls.AddButton("Rømer To Fahrenheit", 560, 450)
        button21 = Controls.AddButton("Rømer To Kelvin", 250, 450)


        AddHandler Controls.ButtonClicked, AddressOf bc

    End Sub
    Sub bc()
        lastbutton = Controls.LastClickedButton
        If lastbutton = Kullanımkılavuzu Then
            GraphicsWindow.ShowMessage("1-Select which one want to translate.2-Write your value on textbox. 3-Click the Calculate button.", "User Guide")
        End If
        'Celsius
        If lastbutton = button1 Then
            calculate = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox1, "Celsius Degree(Firstly Delete All Sentence)")
            textbox1 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate Then
            textbox1i = Controls.GetTextBoxText(textbox1)
            GraphicsWindow.ShowMessage((textbox1i * 1.8) + 32 + " Fahrenheit", "Measurement")
        End If

        If lastbutton = button2 Then
            calculate2 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox2, "Celsius Degree(Firstly Delete All Sentence)")
            textbox2 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate2 Then
            textbox1i2 = Controls.GetTextBoxText(textbox2)
            GraphicsWindow.ShowMessage((textbox1i2 * 1) + 273.15 + " Kelvin", "Measurement")
        End If
        If lastbutton = button4 Then
            calculate4 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox3, "Celsius Degree(Firstly Delete All Sentence)")
            textbox3 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate4 Then
            textbox1i4 = Controls.GetTextBoxText(textbox3)
            GraphicsWindow.ShowMessage((textbox1i4 * (21 / 40)) + 7.5 + " Rømer", "Measurement")
        End If




        'Fahrenheit
        If lastbutton = button9 Then
            calculate9 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox5, "Fahrenheit Degree(Firstly Delete All Sentence)")
            textbox5 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate9 Then
            textbox1i9 = Controls.GetTextBoxText(textbox5)
            GraphicsWindow.ShowMessage(((textbox1i9 - 32) * 5 / 9) + " Celsius", "Measurement")
        End If

        If lastbutton = button13 Then
            calculate13 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox5, "Fahrenheit Degree(Firstly Delete All Sentence)")
            textbox6 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate13 Then
            textbox1i13 = Controls.GetTextBoxText(textbox6)
            GraphicsWindow.ShowMessage(((textbox1i13 - 32) * 5 / 9) + 273.15 + " Kelvin", "Measurement")
        End If
        If lastbutton = button15 Then
            calculate15 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox7, "Fahrenheit Degree(Firstly Delete All Sentence)")
            textbox7 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate15 Then
            textbox1i15 = Controls.GetTextBoxText(textbox7)
            GraphicsWindow.ShowMessage(((textbox1i15 - 32) * 7 / 24) + 7.5 + " Rømer", "Measurement")
        End If







        'Kelvin
        If lastbutton = button16 Then
            calculate16 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox8, "Kelvin Degree(Firstly Delete All Sentence)")
            textbox8 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate16 Then
            textbox1i16 = Controls.GetTextBoxText(textbox8)
            GraphicsWindow.ShowMessage(textbox1i16 - 273.15 + " Celsius", "Measurement")
        End If

        If lastbutton = button17 Then
            calculate17 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox9, "Kelvin Degree(Firstly Delete All Sentence)")
            textbox9 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate17 Then
            textbox1i17 = Controls.GetTextBoxText(textbox9)
            GraphicsWindow.ShowMessage((1.8 * (textbox1i17 - 273)) + 32 + " Fahrenheit", "Measurement")
        End If
        If lastbutton = button18 Then
            calculate18 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox10, "Kelvin Degree(Firstly Delete All Sentence)")
            textbox10 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate18 Then
            textbox1i18 = Controls.GetTextBoxText(textbox10)
            GraphicsWindow.ShowMessage(((textbox1i18 - 273.15) * 21 / 40) + 7.5 + " Rømer", "Measurement")
        End If







        'Rømer
        If lastbutton = button19 Then
            calculate19 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox11, "Rømer Degree(Firstly Delete All Sentence)")
            textbox11 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate19 Then
            textbox1i19 = Controls.GetTextBoxText(textbox11)
            GraphicsWindow.ShowMessage(((textbox1i20 - 7.5) * 21 / 40) + " Celsius", "Measurement")
        End If

        If lastbutton = button20 Then
            calculate20 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox12, "Rømer Degree(Firstly Delete All Sentence)")
            textbox12 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate20 Then
            textbox1i20 = Controls.GetTextBoxText(textbox12)
            GraphicsWindow.ShowMessage(((textbox1i20 - 7.5) * 24 / 7) + 32 + " Fahrenheit", "Measurement")
        End If
        If lastbutton = button21 Then
            calculate21 = Controls.AddButton("Calculate", 50, 10)
            Controls.SetTextBoxText(textbox13, "Rømer Degree(Firstly Delete All Sentence)")
            textbox13 = Controls.AddMultiLineTextBox(595, 50)
        End If
        If lastbutton = calculate21 Then
            textbox1i21 = Controls.GetTextBoxText(textbox13)
            GraphicsWindow.ShowMessage(((textbox1i21 - 7.5) * 40 / 21) + 273.15 + " Kelvin", "Measurement")
        End If
    End Sub
End Module
