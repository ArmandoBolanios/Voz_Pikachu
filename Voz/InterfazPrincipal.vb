﻿Imports System.Speech.Recognition

Public Class InterfazPrincipal
    Dim GRABA As New SpeechRecognitionEngine
    Dim PALABRA As String
    Dim cadenaEntrada As String
    Dim cadenaSalida As String

    Private Sub InterfazPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VOCABULARIO As New GrammarBuilder
        VOCABULARIO.Append(New Choices("hola", "duerme", "te quiero", "cosita", "no me agradas", "te odio",
                                       "retroceder", "avanzar", "izquierda", "derecha", "apagar"))
        GRABA.LoadGrammar(New Grammar(VOCABULARIO))

        GRABA.SetInputToDefaultAudioDevice()
        GRABA.RecognizeAsync(RecognizeMode.Multiple)
        AddHandler GRABA.SpeechRecognized, AddressOf RECONOCE

        cadenaEntrada = ""
        cadenaSalida = ""
        btConectar.Enabled = False
        btEnviar.Enabled = False
        Timer1.Enabled = False

    End Sub

    Public Sub RECONOCE(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Dim RESULTADO As RecognitionResult
        RESULTADO = e.Result
        PALABRA = RESULTADO.Text
        txTextoRec.Text = RESULTADO.Text
        If btEnviar.Enabled = True Then
            If PALABRA = "duerme" Then
                cadenaSalida = "r"
                USBConex.Write(cadenaSalida)
                'My.Computer.Audio.Play(My.Resources.TaeYeon_Bye, AudioPlayMode.BackgroundLoop)
                'cadenaSalida = "u"
                'USBConex.Write(cadenaSalida)
                'PlayBackgroundSoundFile()
            End If
            If PALABRA = "te quiero" Then
                cadenaSalida = "a"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "cosita" Then
                cadenaSalida = "b"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "no me agradas" Then
                cadenaSalida = "s"
                USBConex.Write(cadenaSalida)
            End If

            If PALABRA = "te odio" Then
                cadenaSalida = "d"
                USBConex.Write(cadenaSalida)
            End If

            If PALABRA = "retroceder" Then
                cadenaSalida = "y"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "avanzar" Then
                cadenaSalida = "z"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "izquierda" Then
                cadenaSalida = "x"
                USBConex.Write(cadenaSalida)
            End If
            If PALABRA = "derecha" Then
                cadenaSalida = "m"
                USBConex.Write(cadenaSalida)
            End If

            If PALABRA = "apagar" Then
                cadenaSalida = "k"
                USBConex.Write(cadenaSalida)
            End If

        End If


    End Sub

    Private Sub btDeterminar_Click(sender As Object, e As EventArgs) Handles btDeterminar.Click
        cbPuertos.Items.Clear()  'Limpia todo lo que tenga el combo
        For Each puertoDisponible As String In My.Computer.Ports.SerialPortNames 'Se declara la variable que almacenará los puertos
            cbPuertos.Items.Add(puertoDisponible)
        Next

        If cbPuertos.Items.Count > 0 Then
            cbPuertos.Text = cbPuertos.Items(0)
            MessageBox.Show("Seleccione el puerto a utilizar")
            btConectar.Enabled = True 'En caso de encontrar puerto se activa el botón
        Else
            MessageBox.Show("Ningún puerto Encontrado (T_T)")
            btConectar.Enabled = False
            btEnviar.Enabled = False
            cbPuertos.Items.Clear()
            cbPuertos.Text = ""

        End If
    End Sub

    Private Sub btConectar_Click(sender As Object, e As EventArgs) Handles btConectar.Click
        If btConectar.Text = "Conectar" Then
            USBConex.PortName = cbPuertos.Text
            btConectar.Text = "Desconectar"
            btEnviar.Enabled = True
            Timer1.Enabled = True
            USBConex.Open()
        Else
            btConectar.Text = "Conectar"
            btEnviar.Enabled = False
            Timer1.Enabled = False
            USBConex.Close()
        End If
    End Sub

    Sub enviar()
        USBConex.DiscardInBuffer()
        cadenaSalida = txTextoRec.Text
        USBConex.Write(cadenaSalida)

    End Sub

    Private Sub btEnviar_Click(sender As Object, e As EventArgs) Handles btEnviar.Click
        enviar()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cadenaEntrada = USBConex.ReadExisting
        If cadenaEntrada <> "" Then
            txRecibe.Text = txRecibe.Text + cadenaEntrada
            cadenaEntrada = ""
            USBConex.DiscardInBuffer()
        End If

    End Sub

    Private Sub txRecibe_TextChanged(sender As Object, e As EventArgs) Handles txRecibe.TextChanged

    End Sub

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play(My.Resources.TaeYeon_Bye, AudioPlayMode.BackgroundLoop)
        'My.Computer.Audio.Play(My.Resources.Pikachu_triste, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Hola_Click(sender As Object, e As EventArgs) Handles Hola.Click
        PlayBackgroundSoundFile()
    End Sub
End Class