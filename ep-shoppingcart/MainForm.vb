Public Class MainForm
    Private PanelH As Boolean = True
    Private PanelM As Boolean = False
    Private PanelC As Boolean = False
    Private PanelA As Boolean = False

    Private PosH1 As Integer = 0
    Private PosM1 As Integer = 0
    Private PosC1 As Integer = 0
    Private PosA1 As Integer = 0

    Private AlmH1 As Integer = 0
    Private AlmH2 As Integer = 0
    Private AlmH3 As Integer = 0

    Private AlmM1 As Integer = 0
    Private AlmM2 As Integer = 0
    Private AlmM3 As Integer = 0

    Private AlmC1 As Integer = 0
    Private AlmC2 As Integer = 0
    Private AlmC3 As Integer = 0

    Private AlmA1 As Integer = 0
    Private AlmA2 As Integer = 0


    Private Total As Integer = 0





    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtCantidad.Text = "0"
        PanelH = True
        BtnH.ForeColor = Color.SteelBlue
        BtnM.ForeColor = Color.Black
        BtnC.ForeColor = Color.Black
        BtnA.ForeColor = Color.Black
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        PB1.Image = ILHN.Images.Item(0)
        PB2.Image = ILHN.Images.Item(1)
        PB3.Image = ILHN.Images.Item(2)
        PB4.Image = ILHN.Images.Item(3)
        PBPRINCIPAL.Image = ILHN.Images.Item(0)
        lblPrecio.Text = "85"
        LblT1.Text = "XS"
        LblT1.ForeColor = Color.Gray
        LblT2.Text = "S"
        LblT2.ForeColor = Color.Black
        LblT3.Text = "M"
        LblT3.ForeColor = Color.Black
        LblT4.Text = "L"
        LblT4.ForeColor = Color.Black
        LblT5.Text = "XL"
        LblT5.ForeColor = Color.Gray
    End Sub


    Private Sub PB1_Click(sender As Object, e As EventArgs) Handles PB1.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = PB1.Image
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = PB1.Image
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = PB1.Image
                End If
                If PanelA = True Then
                    PBPRINCIPAL.Image = PB1.Image
                End If
            End If
        End If

    End Sub

    Private Sub PB2_Click(sender As Object, e As EventArgs) Handles PB2.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = PB2.Image
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = PB2.Image
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = PB2.Image
                End If
                If PanelA = True Then
                    PBPRINCIPAL.Image = PB2.Image
                End If
            End If
        End If
    End Sub

    Private Sub PB3_Click(sender As Object, e As EventArgs) Handles PB3.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = PB3.Image
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = PB3.Image
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = PB3.Image
                End If


            End If
        End If
    End Sub

    Private Sub PB4_Click(sender As Object, e As EventArgs) Handles PB4.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = PB4.Image
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = PB4.Image
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = PB4.Image
                End If
            End If
        End If
    End Sub

    Private Sub BtnH_Click(sender As Object, e As EventArgs) Handles BtnH.Click
        txtCantidad.Text = AlmH1
        PanelH = True
        PanelM = False
        PanelC = False
        PanelA = False
        PosH1 = 0
        PB2.Show()
        PB3.Show()
        PB4.Show()
        PB1.Image = ILHN.Images.Item(0)
        PB2.Image = ILHN.Images.Item(1)
        PB3.Image = ILHN.Images.Item(2)
        PB4.Image = ILHN.Images.Item(3)
        PBPRINCIPAL.Image = ILHN.Images.Item(0)
        BtnH.ForeColor = Color.SteelBlue
        BtnM.ForeColor = Color.Black
        BtnC.ForeColor = Color.Black
        BtnA.ForeColor = Color.Black
        lblTitulo.Text = "Eng Poplin Shirt"
        LblT1.Text = "XS"
        LblT1.ForeColor = Color.Gray
        LblT2.Text = "S"
        LblT2.ForeColor = Color.Black
        LblT3.Text = "M"
        LblT3.ForeColor = Color.Black
        LblT4.Text = "L"
        LblT4.ForeColor = Color.Black
        LblT5.Text = "XL"
        LblT5.ForeColor = Color.Gray
        lblPrecio.Text = "85"


    End Sub

    Private Sub BtnM_Click(sender As Object, e As EventArgs) Handles BtnM.Click
        txtCantidad.Text = AlmM1

        PanelH = False
        PanelM = True
        PanelC = False
        PanelA = False
        PosM1 = 0
        PB2.Show()
        PB3.Show()
        PB4.Show()
        PB1.Image = ILMN.Images.Item(0)
        PB2.Image = ILMN.Images.Item(1)
        PB3.Image = ILMN.Images.Item(2)
        PB4.Image = ILMN.Images.Item(3)
        PBPRINCIPAL.Image = ILMN.Images.Item(0)
        BtnH.ForeColor = Color.Black
        BtnM.ForeColor = Color.SteelBlue
        BtnC.ForeColor = Color.Black
        BtnA.ForeColor = Color.Black
        LblT1.Text = "XS"
        LblT1.ForeColor = Color.Gray
        LblT2.Text = "S"
        LblT2.ForeColor = Color.Black
        LblT3.Text = "M"
        LblT3.ForeColor = Color.Black
        LblT4.Text = "L"
        LblT4.ForeColor = Color.Black
        LblT5.Text = "XL"
        LblT5.ForeColor = Color.Gray
        lblPrecio.Text = "120"
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        txtCantidad.Text = AlmC1
        PanelH = False
        PanelM = False
        PanelC = True
        PanelA = False
        PosC1 = 0
        PB2.Show()
        PB3.Show()
        PB4.Show()
        PB1.Image = ILCN.Images.Item(0)
        PB2.Image = ILCN.Images.Item(1)
        PB3.Image = ILCN.Images.Item(2)
        PB4.Image = ILCN.Images.Item(3)
        PBPRINCIPAL.Image = ILCN.Images.Item(0)
        BtnH.ForeColor = Color.Black
        BtnM.ForeColor = Color.Black
        BtnC.ForeColor = Color.SteelBlue
        BtnA.ForeColor = Color.Black
        LblT1.Text = "37"
        LblT1.ForeColor = Color.Gray
        LblT2.Text = "38"
        LblT2.ForeColor = Color.Black
        LblT3.Text = "39"
        LblT3.ForeColor = Color.Black
        LblT4.Text = "40"
        LblT4.ForeColor = Color.Black
        LblT5.Text = "41"
        LblT5.ForeColor = Color.Gray
        lblPrecio.Text = "55"
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles BtnA.Click
        txtCantidad.Text = AlmA1
        PanelH = False
        PanelM = False
        PanelC = False
        PanelA = True
        PosA1 = 0
        PB1.Image = ILAN.Images.Item(0)
        PB2.Hide()
        PB3.Hide()
        PB4.Hide()
        PBPRINCIPAL.Image = ILAN.Images.Item(0)
        BtnH.ForeColor = Color.Black
        BtnM.ForeColor = Color.Black
        BtnC.ForeColor = Color.Black
        BtnA.ForeColor = Color.SteelBlue


        LblT1.ForeColor = Color.Gray
        LblT2.ForeColor = Color.Gray
        LblT3.ForeColor = Color.Gray
        LblT4.ForeColor = Color.Gray
        LblT5.ForeColor = Color.Gray
        lblPrecio.Text = "175"
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        If PanelH = True Then
            If PosH1 = 0 Then
                Beep()
            Else
                PosH1 = PosH1 - 1
                Select Case PosH1
                    Case 0
                        txtCantidad.Text = AlmH1
                        PB1.Image = ILHN.Images.Item(0)
                        PB2.Image = ILHN.Images.Item(1)
                        PB3.Image = ILHN.Images.Item(2)
                        PB4.Image = ILHN.Images.Item(3)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Eng Poplin Shirt"
                        lblPrecio.Text = "85"
                        AlmH1 = txtCantidad.Text

                    Case 1
                        txtCantidad.Text = AlmH2
                        PB1.Image = ILHN.Images.Item(4)
                        PB2.Image = ILHN.Images.Item(5)
                        PB3.Image = ILHN.Images.Item(6)
                        PB4.Image = ILHN.Images.Item(7)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                        lblPrecio.Text = "110"
                        AlmH2 = txtCantidad.Text

                    Case 2
                        txtCantidad.Text = AlmH3
                        PB1.Image = ILHN.Images.Item(8)
                        PB2.Image = ILHN.Images.Item(9)
                        PB3.Image = ILHN.Images.Item(10)
                        PB4.Image = ILHN.Images.Item(11)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
                        lblPrecio.Text = "95"
                        AlmH3 = txtCantidad.Text

                End Select
            End If
        End If
        If PanelM = True Then
            If PosM1 = 0 Then
                Beep()
            Else
                PosM1 = PosM1 - 1
                Select Case PosM1
                    Case 0
                        txtCantidad.Text = AlmM1
                        PB3.Show()
                        PB4.Show()
                        PB1.Image = ILMN.Images.Item(0)
                        PB2.Image = ILMN.Images.Item(1)
                        PB3.Image = ILMN.Images.Item(2)
                        PB4.Image = ILMN.Images.Item(3)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Nicola Blouse"
                        lblPrecio.Text = "120"
                        AlmM1 = txtCantidad.Text
                    Case 1
                        txtCantidad.Text = AlmM2
                        PB3.Show()
                        PB4.Show()
                        PB1.Image = ILMN.Images.Item(4)
                        PB2.Image = ILMN.Images.Item(5)
                        PB3.Image = ILMN.Images.Item(6)
                        PB4.Image = ILMN.Images.Item(7)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Jemma Blazer"
                        lblPrecio.Text = "190"
                        AlmM2 = txtCantidad.Text
                    Case 2
                        txtCantidad.Text = AlmM3
                        PB3.Show()
                        PB4.Show()
                        PB1.Image = ILHN.Images.Item(8)
                        PB2.Image = ILHN.Images.Item(9)
                        PB3.Image = ILHN.Images.Item(10)
                        PB4.Image = ILHN.Images.Item(11)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Neige Dress"
                        lblPrecio.Text = "125"
                        AlmM3 = txtCantidad.Text

                End Select
            End If
        End If
        If PanelC = True Then
            If PosC1 = 0 Then
                Beep()
            Else
                PosC1 = PosC1 - 1
                Select Case PosC1
                    Case 0
                        txtCantidad.Text = AlmC1
                        PB1.Image = ILCN.Images.Item(0)
                        PB2.Image = ILCN.Images.Item(1)
                        PB3.Image = ILCN.Images.Item(2)
                        PB4.Image = ILCN.Images.Item(3)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Philip 1d Trainers"
                        lblPrecio.Text = "55"
                        AlmC1 = txtCantidad.Text
                    Case 1
                        txtCantidad.Text = AlmC2
                        PB1.Image = ILCN.Images.Item(4)
                        PB2.Image = ILCN.Images.Item(5)
                        PB3.Image = ILCN.Images.Item(6)
                        PB4.Image = ILCN.Images.Item(7)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Deck 4d Mixed"
                        lblPrecio.Text = "80"
                        AlmC2 = txtCantidad.Text
                    Case 2
                        txtCantidad.Text = AlmC3
                        PB1.Image = ILCN.Images.Item(8)
                        PB2.Image = ILCN.Images.Item(9)
                        PB3.Image = ILCN.Images.Item(10)
                        PB4.Image = ILCN.Images.Item(11)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Parson 8n"
                        lblPrecio.Text = "155"
                        AlmC3 = txtCantidad.Text

                End Select
            End If
        End If
        If PanelA = True Then
            If PosA1 = 0 Then
                Beep()
            Else
                PosA1 = PosA1 - 1
                Select Case PosA1
                    Case 0
                        txtCantidad.Text = AlmA1
                        PB1.Image = ILAN.Images.Item(0)
                        PB2.Hide()
                        PB3.Hide()
                        PB4.Hide()
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Strap Watch 1791"
                        lblPrecio.Text = "175"
                        AlmA1 = txtCantidad.Text
                    Case 1
                        txtCantidad.Text = AlmA2
                        PB1.Image = ILAN.Images.Item(1)
                        PB2.Hide()
                        PB3.Hide()
                        PB4.Hide()
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Classic Logo Red Cap"
                        lblPrecio.Text = "25"
                        AlmA2 = txtCantidad.Text

                End Select
            End If
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If PanelH = True Then
            If PosH1 = 2 Then
                Beep()
            Else
                PosH1 = PosH1 + 1
                Select Case PosH1
                    Case 0
                        txtCantidad.Text = AlmH1
                        PB1.Image = ILHN.Images.Item(0)
                        PB2.Image = ILHN.Images.Item(1)
                        PB3.Image = ILHN.Images.Item(2)
                        PB4.Image = ILHN.Images.Item(3)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Eng Poplin Shirt"
                        lblPrecio.Text = "85"
                        AlmH1 = txtCantidad.Text

                    Case 1
                        txtCantidad.Text = AlmH2
                        PB1.Image = ILHN.Images.Item(4)
                        PB2.Image = ILHN.Images.Item(5)
                        PB3.Image = ILHN.Images.Item(6)
                        PB4.Image = ILHN.Images.Item(7)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                        lblPrecio.Text = "110"
                        AlmH2 = txtCantidad.Text
                    Case 2
                        txtCantidad.Text = AlmH3
                        PB1.Image = ILHN.Images.Item(8)
                        PB2.Image = ILHN.Images.Item(9)
                        PB3.Image = ILHN.Images.Item(10)
                        PB4.Image = ILHN.Images.Item(11)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
                        lblPrecio.Text = "95"
                        AlmH3 = txtCantidad.Text
                End Select

            End If
        End If
        If PanelM = True Then
            If PosM1 = 2 Then
                Beep()
            Else
                PosM1 = PosM1 + 1
                Select Case PosM1
                    Case 0
                        txtCantidad.Text = AlmM1
                        PB3.Show()
                        PB4.Show()
                        PB1.Image = ILMN.Images.Item(0)
                        PB2.Image = ILMN.Images.Item(1)
                        PB3.Image = ILMN.Images.Item(2)
                        PB4.Image = ILMN.Images.Item(3)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Nicola Blouse"
                        lblPrecio.Text = "120"
                        AlmM1 = txtCantidad.Text
                    Case 1
                        txtCantidad.Text = AlmM2
                        PB3.Show()
                        PB4.Show()
                        PB1.Image = ILMN.Images.Item(4)
                        PB2.Image = ILMN.Images.Item(5)
                        PB3.Image = ILMN.Images.Item(6)
                        PB4.Image = ILMN.Images.Item(7)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Jemma Blazer"
                        lblPrecio.Text = "190"
                        AlmM2 = txtCantidad.Text
                    Case 2
                        txtCantidad.Text = AlmM3
                        PB1.Image = ILMN.Images.Item(8)
                        PB2.Image = ILMN.Images.Item(9)
                        PB3.Hide()
                        PB4.Hide()
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Neige Dress"
                        lblPrecio.Text = "125"
                        AlmM3 = txtCantidad.Text

                End Select
            End If
        End If
        If PanelC = True Then
            If PosC1 = 2 Then
                Beep()
            Else
                PosC1 = PosC1 + 1
                Select Case PosC1
                    Case 0
                        txtCantidad.Text = AlmC1
                        PB1.Image = ILCN.Images.Item(0)
                        PB2.Image = ILCN.Images.Item(1)
                        PB3.Image = ILCN.Images.Item(2)
                        PB4.Image = ILCN.Images.Item(3)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Philip 1d Trainers"
                        lblPrecio.Text = "55"
                        AlmC1 = txtCantidad.Text
                    Case 1
                        txtCantidad.Text = AlmC2
                        PB1.Image = ILCN.Images.Item(4)
                        PB2.Image = ILCN.Images.Item(5)
                        PB3.Image = ILCN.Images.Item(6)
                        PB4.Image = ILCN.Images.Item(7)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Deck 4d Mixed"
                        lblPrecio.Text = "80"
                        AlmC2 = txtCantidad.Text
                    Case 2
                        txtCantidad.Text = AlmC3
                        PB1.Image = ILCN.Images.Item(8)
                        PB2.Image = ILCN.Images.Item(9)
                        PB3.Image = ILCN.Images.Item(10)
                        PB4.Image = ILCN.Images.Item(11)
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Parson 8n Mid Heel"
                        lblPrecio.Text = "155"
                        AlmC3 = txtCantidad.Text
                End Select
            End If
        End If
        If PanelA = True Then
            If PosA1 = 1 Then
                Beep()
            Else
                PosA1 = PosA1 + 1
                Select Case PosA1
                    Case 0
                        txtCantidad.Text = AlmA1
                        PB1.Image = ILAN.Images.Item(0)
                        PB2.Hide()
                        PB3.Hide()
                        PB4.Hide()
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Strap Watch 1791"
                        lblPrecio.Text = "175"
                        AlmA1 = txtCantidad.Text
                    Case 1
                        txtCantidad.Text = AlmA2
                        PB1.Image = ILAN.Images.Item(1)
                        PB2.Hide()
                        PB3.Hide()
                        PB4.Hide()
                        PBPRINCIPAL.Image = PB1.Image
                        lblTitulo.Text = "Classic Logo Red Cap"
                        lblPrecio.Text = "25"
                        txtCantidad.Text = AlmA2
                End Select
            End If
        End If

    End Sub

    Private Sub tblNavigation_Paint(sender As Object, e As PaintEventArgs) Handles tblNavigation.Paint

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If PanelH = True Then
            Select Case PosH1
                Case 0
                    AlmH1 = txtCantidad.Text
                    Total = Total + (AlmH1 * 85)
                    lblTotal.Text = Total
                Case 1
                    AlmH2 = txtCantidad.Text
                    Total = Total + (AlmH2 * 110)
                    lblTotal.Text = Total
                Case 2
                    AlmH3 = txtCantidad.Text
                    Total = Total + (AlmH3 * 95)
                    lblTotal.Text = Total
            End Select
        End If
        If PanelM = True Then
            Select Case PosM1
                Case 0
                    AlmM1 = txtCantidad.Text
                    Total = Total + (AlmM1 * 120)
                    lblTotal.Text = Total
                Case 1
                    AlmM2 = txtCantidad.Text
                    Total = Total + (AlmM2 * 190)
                    lblTotal.Text = Total
                Case 2
                    AlmM3 = txtCantidad.Text
                    Total = Total + (AlmM3 * 125)
                    lblTotal.Text = Total
            End Select
        End If

        If PanelC = True Then

            Select Case PosC1
                Case 0
                    AlmC1 = txtCantidad.Text
                    Total = Total + (AlmC1 * 55)
                    lblTotal.Text = Total
                Case 1
                    AlmC2 = txtCantidad.Text
                    Total = Total + (AlmC2 * 80)
                    lblTotal.Text = Total
                Case 2
                    AlmC3 = txtCantidad.Text
                    Total = Total + (AlmC3 * 155)
                    lblTotal.Text = Total
            End Select
        End If
        If PanelA = True Then
            Select Case PosA1
                Case 0
                    AlmA1 = txtCantidad.Text
                    Total = Total + (AlmA1 * 175)
                    lblTotal.Text = Total
                Case 1
                    AlmA2 = txtCantidad.Text
                    Total = Total + (AlmA2 * 25)
                    lblTotal.Text = Total

            End Select
        End If
    End Sub

    Private Sub tblMenu_Paint(sender As Object, e As PaintEventArgs) Handles tblMenu.Paint

    End Sub

    Private Sub MainForm_BackgroundImageChanged(sender As Object, e As EventArgs) Handles Me.BackgroundImageChanged

    End Sub
End Class