Public Class MainForm
    Private PanelH As Boolean = True
    Private PanelM As Boolean = False
    Private PanelC As Boolean = False
    Private PanelA As Boolean = False

    Private PosH1 As Integer = 0
    Private PosM1 As Integer = 0
    Private PosC1 As Integer = 0
    Private PosA1 As Integer = 0

    Private Total As Integer = 0


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PanelH = True
        BtnH.ForeColor = Color.SteelBlue
        BtnM.ForeColor = Color.Black
        BtnC.ForeColor = Color.Black
        BtnA.ForeColor = Color.Black
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        PB1.Image = ILHS.Images.Item(0)
        PB2.Image = ILHS.Images.Item(1)
        PB3.Image = ILHS.Images.Item(2)
        PB4.Image = ILHS.Images.Item(3)
        PBPRINCIPAL.Image = ILHN.Images.Item(0)
        lblPrecio.Text = "95"
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
            PBPRINCIPAL.Image = ILHN.Images.Item(0)
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = ILMN.Images.Item(0)
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = ILCN.Images.Item(0)
                End If
                If PanelA = True Then
                    PBPRINCIPAL.Image = ILAN.Images.Item(0)
                End If
            End If
        End If

    End Sub

    Private Sub PB2_Click(sender As Object, e As EventArgs) Handles PB2.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = ILHN.Images.Item(1)
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = ILMN.Images.Item(1)
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = ILCN.Images.Item(1)
                End If
                If PanelA = True Then
                    PBPRINCIPAL.Image = ILAN.Images.Item(1)
                End If
            End If
        End If
    End Sub

    Private Sub PB3_Click(sender As Object, e As EventArgs) Handles PB3.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = ILHN.Images.Item(2)
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = ILMN.Images.Item(2)
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = ILCN.Images.Item(2)
                End If
                If PanelA = True Then
                    PBPRINCIPAL.Image = ILAN.Images.Item(0)
                End If
            End If
        End If
    End Sub

    Private Sub PB4_Click(sender As Object, e As EventArgs) Handles PB4.Click
        If PanelH = True Then
            PBPRINCIPAL.Image = ILHN.Images.Item(3)
        Else
            If PanelM = True Then
                PBPRINCIPAL.Image = ILMN.Images.Item(3)
            Else
                If PanelC = True Then
                    PBPRINCIPAL.Image = ILCN.Images.Item(3)
                End If
            End If
        End If
    End Sub

    Private Sub BtnH_Click(sender As Object, e As EventArgs) Handles BtnH.Click
        PanelH = True
        PanelM = False
        PanelC = False
        PanelA = False
        PosH1 = 0
        PB1.Image = ILHS.Images.Item(0)
        PB2.Image = ILHS.Images.Item(1)
        PB3.Image = ILHS.Images.Item(2)
        PB4.Image = ILHS.Images.Item(3)
        PBPRINCIPAL.Image = ILHN.Images.Item(0)
        BtnH.ForeColor = Color.SteelBlue
        BtnM.ForeColor = Color.Black
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
        lblPrecio.Text = "95"


    End Sub

    Private Sub BtnM_Click(sender As Object, e As EventArgs) Handles BtnM.Click
        PanelH = False
        PanelM = True
        PanelC = False
        PanelA = False
        PB1.Image = ILMS.Images.Item(0)
        PB2.Image = ILMS.Images.Item(1)
        PB3.Image = ILMS.Images.Item(2)
        PB4.Image = ILMS.Images.Item(3)
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
        lblPrecio.Text = "85"
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        PanelH = False
        PanelM = False
        PanelC = True
        PanelA = False
        PB1.Image = ILCS.Images.Item(0)
        PB2.Image = ILCS.Images.Item(1)
        PB3.Image = ILCS.Images.Item(2)
        PB4.Image = ILCS.Images.Item(3)
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
        PanelH = False
        PanelM = False
        PanelC = False
        PanelA = True
        PB1.Image = ILAS.Images.Item(0)
        PB2.Image = ILAS.Images.Item(1)
        PB3.Image = ILAS.Images.Item(2)
        PB4.Image = ILAS.Images.Item(2)
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
            End If
        End If
        If PanelM = True Then
            If PosM1 = 0 Then
                Beep()
            Else
                PosM1 = PosM1 - 1
            End If
        End If
        If PanelM = True Then
            If PosC1 = 0 Then
                Beep()
            Else
                PosC1 = PosC1 - 1
            End If
        End If
        If PanelA = True Then
            If PosA1 = 0 Then
                Beep()
            Else
                PosA1 = PosA1 - 1
            End If
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If PanelH = True Then
            If PosH1 = 4 Then
                Beep()
            Else
                PosH1 = PosH1 + 1
            End If
        End If
        If PanelM = True Then
            If PosM1 = 4 Then
                Beep()
            Else
                PosM1 = PosM1 + 1
            End If
        End If
        If PanelM = True Then
            If PosC1 = 4 Then
                Beep()
            Else
                PosC1 = PosC1 + 1
            End If
        End If
        If PanelA = True Then
            If PosA1 = 2 Then
                Beep()
            Else
                PosA1 = PosA1 + 1
            End If
        End If
    End Sub
End Class