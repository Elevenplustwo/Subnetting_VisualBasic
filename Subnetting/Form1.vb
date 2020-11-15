Imports System.Math
Public Class Form1
    Private firstTimeinLösungen As Boolean = True
    Private firstclick As Boolean = True

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        If firstTimeinLösungen Then
            Dim temp = MsgBox("Bist du sicher das du die Lösungen ansehen willst?", 4, "Subnetting")
            If temp = vbNo Then
                TabControl1.SelectedTab = TabPage2
            Else
                firstTimeinLösungen = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'initialisiere den randomnumbergenerator nur beim ersten methodenaufruf
        If firstclick Then
            Randomize()
            firstclick = False
        End If
        'eingaben prüfen
        'bei leeren eingaben setzen wir die standardwerte
        If Generator_SMMin.Text = "" Then
            Generator_SMMin.Text = 0
        End If

        If Generator_SMMax.Text = "" Then
            Generator_SMMax.Text = 30
        End If

        If Generator_CidrMin.Text = "" Then
            Generator_CidrMin.Text = 0
        End If

        If Generator_CidrMax.Text = "" Then
            Generator_CidrMax.Text = 29
        End If

        'nur integer zwischen min und max werden akzeptiert sonst -> standardwert
        'liegt ein integer vor aber nicht im gewünschten bereich -> standardwert
        Dim test As Integer
        If Not Integer.TryParse(Generator_SMMin.Text, test) Then
            Generator_SMMin.Text = 0
        ElseIf (Generator_SMMin.Text < 0) Or (Generator_SMMin.Text > 30) Then
            Generator_SMMin.Text = 0
        End If

        If Not Integer.TryParse(Generator_SMMax.Text, test) Then
            Generator_SMMax.Text = 30
        ElseIf (Generator_SMMax.Text < 0) Or (Generator_SMMax.Text > 30) Then
            Generator_SMMax.Text = 30
        End If

        If Not Integer.TryParse(Generator_CidrMin.Text, test) Then
            Generator_CidrMin.Text = 0
        ElseIf (Generator_CidrMin.Text < 0) Or (Generator_CidrMin.Text > 29) Then
            Generator_CidrMin.Text = 0
        End If

        If Not Integer.TryParse(Generator_CidrMax.Text, test) Then
            Generator_CidrMax.Text = 29
        ElseIf (Generator_CidrMax.Text < 0) Or (Generator_CidrMax.Text > 29) Then
            Generator_CidrMax.Text = 29
        End If

        Dim cidr As Integer
        'wenn cidr merken markiert ist aber in cidr quatsch steht geht der haken raus
        If CidrCheckBox.Checked Then
            If (Not Integer.TryParse(CidrTextBox.Text, cidr)) Then
                CidrCheckBox.Checked = False
            ElseIf (CidrTextBox.Text < 0 Or CidrTextBox.Text > 29) Then
                CidrCheckBox.Checked = False
            End If
        End If

        'wenn ip merken markiert ist aber in ip quatsch steht geht der haken raus
        If IPCheckBox.Checked Then
            If Not IsIp(IPTextBox.Text) Then
                IPCheckBox.Checked = False
            End If
        End If

        'wenn sm merken markiert ist aber in sm quatsch steht geht der haken raus
        If SMCheckBox.Checked Then
            If Not IsIp(SMTextBox.Text) Then
                SMCheckBox.Checked = False
            End If
        End If

        'wenn wenigstens einer der drei werte neu generiert wird dann wird die lösungsflag wieder zurückgesetzt
        If Not IPCheckBox.Checked Or Not SMCheckBox.Checked Or Not CidrCheckBox.Checked Then
            firstTimeinLösungen = True
        End If


        'werte werden neu generiert, checkboxen werden ignoriert solange die textboxen leer sind
        If Not IPCheckBox.Checked Then
            IPTextBox.Text = RndIp()
        End If
        If Not SMCheckBox.Checked Then
            SMTextBox.Text = RndSM()
        End If

        If Not CidrCheckBox.Checked Then
            CidrTextBox.Text = RndCidr()
        End If

        'Lösungstab wird befüllt

        'Anteile bestimmen
        Dim ip As String
        ip = IPTextBox.Text
        ip = Ip2bin(ip)

        'Netzanteil
        Dim NetIp As String
        cidr = CidrTextBox.Text
        'cidr wird um die anzahl der punkte im netzanteil erhöht
        If cidr > 24 Then
            cidr += 3
        ElseIf cidr > 16 Then
            cidr += 2
        ElseIf cidr > 8 Then
            cidr += 1
        End If
        NetIp = ip.Substring(0, cidr)

        'Subnetzanteil
        Dim SmIp As String
        Dim subnetzmaske As String
        Dim smlength
        subnetzmaske = SMTextBox.Text
        subnetzmaske = Ip2bin(subnetzmaske)
        subnetzmaske = subnetzmaske.Replace(".", "").Replace("0", "")
        smlength = subnetzmaske.Length
        If smlength > 24 Then
            smlength += 3
        ElseIf smlength > 16 Then
            smlength += 2
        ElseIf smlength > 8 Then
            smlength += 1
        End If
        SmIp = ip.Substring(cidr, Abs(smlength - cidr))

        'Hostteil
        Dim HostIp As String
        HostIp = ip.Substring(smlength, 35 - smlength)

        'textboxanteile kriegt die anteile getrennt von | 
        Lösung_TextBoxAnteile.Text = NetIp + " | " + SmIp + " | " + HostIp

        'networkid und broadcastid werden generiert indem der hostteil angepasst wird
        'und die zusammengesetzte ip zu dezimalzahlen umgewandelt wird
        Lösung_TextBoxNID.Text = Ip2dec(NetIp + SmIp + HostIp.Replace("1", "0"))
        Lösung_TextBoxBID.Text = Ip2dec(NetIp + SmIp + HostIp.Replace("0", "1"))

        'anzahl subnetze ist 2 zur potenz der länge des subnezteils 
        Dim sm = SmIp.Replace(".", "")
        Lösung_TextBoxASub.Text = 2 ^ (sm.Length)
        'subnetznummer ist dezimal der adresse + 1
        Lösung_TextBoxSubnetznr.Text = Bin2dec(sm) + 1

        'anzahl hosts ist 2 zur potenz der länge des hostteils -2 für broadcastid und netid
        Dim hosts = HostIp.Replace(".", "")
        Lösung_TextBoxAHosts.Text = 2 ^ hosts.Length - 2

        'hosts insgesamt ist anzahl hosts * anzahl subnetze
        Lösung_TextBoxHostsIns.Text = Lösung_TextBoxASub.Text * Lösung_TextBoxAHosts.Text

        'testbereich leeren

        Test_TextBoxAnteile.BackColor = Color.White
        Test_TextBoxAnteile.Text = ""

        Test_TextBoxNID.BackColor = Color.White
        Test_TextBoxNID.Text = ""

        Test_TextBoxBID.BackColor = Color.White
        Test_TextBoxBID.Text = ""

        Test_TextBoxAHosts.BackColor = Color.White
        Test_TextBoxAHosts.Text = ""

        Test_TextBoxASub.BackColor = Color.White
        Test_TextBoxASub.Text = ""

        Test_TextBoxSubNr.BackColor = Color.White
        Test_TextBoxSubNr.Text = ""

        Test_TextBoxHostsIns.BackColor = Color.White
        Test_TextBoxHostsIns.Text = ""

    End Sub

    Private Function RndIp()
        Dim combocase As String = ComboBox1.SelectedItem
        Dim ip1 As Integer
        Select Case combocase
            Case "Klasse A"
                ip1 = Int((128) * Rnd())
            Case "Klasse B"
                ip1 = Int((64) * Rnd() + 128)
            Case "Klasse C"
                ip1 = Int((32) * Rnd() + 192)
            Case "Klasse D"
                ip1 = Int((16) * Rnd() + 224)
            Case "Klasse E"
                ip1 = Int((16) * Rnd() + 240)
            Case Else
                ip1 = Int((256) * Rnd())
        End Select
        Dim ip2 As Integer = Int((256) * Rnd())
        Dim ip3 As Integer = Int((256) * Rnd())
        Dim ip4 As Integer = Int((256) * Rnd())
        Dim ip As String = ip1.ToString + "." + ip2.ToString + "." + ip3.ToString + "." + ip4.ToString

        Return ip
    End Function

    Private Function RndSM()

        'Dim smin As Integer
        'If Integer.TryParse(Generator_SMMin.Text, smin) Then
        '    smin = Generator_SMMin.Text
        'Else smin = 0
        'End If

        'Dim smax As Integer
        'If Integer.TryParse(Generator_SMMax.Text, smax) Then
        '    smax = Generator_SMMax.Text
        'Else smax = 30
        'End If

        'bei klicken auf generieren wird überprüft ob die werte integer im korrekten wertebereich sind
        'spare ich mir hier also
        Dim smin As Integer = Generator_SMMin.Text
        Dim smax As Integer = Generator_SMMax.Text


        'wenn wir uns den cidr merken ist cidr das untere limit für die subnetzlänge
        If CidrCheckBox.Checked And Not CidrTextBox.Text = "" Then
            If CidrTextBox.Text > smin Then
                smin = CidrTextBox.Text
            End If
        End If

        'generieren der zufallslänge
        Dim smlength As Integer
        smlength = Int((31 - smin - (30 - smax)) * Rnd() + smin)
        Dim sm As String = ""

        'soviele einsen wie die subnetzmaske lang sein soll
        While sm.Length < smlength
            sm += "1"
        End While

        'rest nullen
        While sm.Length < 32
            sm += "0"
        End While

        'einfügen der "." an den richtigen stellen
        'umrechnung der subnetzmaske in dezimal
        sm = sm.Substring(0, 8) + "." + sm.Substring(8, 8) + "." + sm.Substring(16, 8) + "." + sm.Substring(24, 8)
        sm = Ip2dec(sm)

        Return sm

    End Function

    Private Function RndCidr()

        'If Integer.TryParse(Generator_CidrMin.Text, cmin) Then
        '    cmin = Generator_CidrMin.Text
        'Else cmin = 0
        'End If


        'If Integer.TryParse(Generator_CidrMax.Text, cmax) Then
        '    cmax = Generator_CidrMax.Text
        'Else cmax = 30
        'End If


        'If Integer.TryParse(Generator_SMMax.Text, smax) Then
        '    smax = Generator_SMMax.Text
        'Else smax = 30
        'End If

        Dim cidr As Integer
        Dim cmin As Integer = Generator_CidrMin.Text
        Dim cmax As Integer = Generator_CidrMax.Text

        'cidr darf nicht länger als die subnetzmaske sein also wird
        'cmax auf die länge der subnetzmaske reduziert falls diese kleiner ist

        Dim smlength As Integer
        Dim subnetzmaske
        subnetzmaske = SMTextBox.Text
        subnetzmaske = Ip2bin(subnetzmaske)
        subnetzmaske = subnetzmaske.Replace(".", "").Replace("0", "")
        smlength = subnetzmaske.Length
        If cmax > smlength Then
            cmax = smlength
        End If
        cidr = Int((31 - cmin - (30 - cmax)) * Rnd() + cmin)
        Return cidr
    End Function

    Private Shared Function Ip2bin(ip As String)
        Dim ipparts As String() = ip.Split(".")
        Dim res As String = ""
        Dim temp As String
        For Each elem In ipparts
            temp = Dec2bin(elem)
            res += "." + temp
        Next
        res = res.Substring(1, res.Length - 1)
        Return res
    End Function

    Private Shared Function Ip2dec(ip As String)
        Dim ipparts As String() = ip.Split(".")
        Dim res As String = ""
        Dim temp As String
        For Each elem In ipparts
            temp = Bin2dec(elem)
            res += "." + temp
        Next
        res = res.Substring(1, res.Length - 1)
        Return res
    End Function

    Private Shared Function Dec2bin(elem As String)
        Dim ip As Integer
        Integer.TryParse(elem, ip)
        Dim bin As Integer
        Dim output As String = ""
        While ip > 0
            bin = ip Mod 2
            ip \= 2
            output = bin.ToString + output
        End While
        While output.Length < 8
            output = "0" + output
        End While
        Return output
    End Function

    Private Shared Function Bin2dec(elem As String)
        Dim count As Integer = 0
        Dim output As Integer = 0
        elem = StrReverse(elem)
        Dim temp As Integer = 0
        For Each ch In elem
            temp = Convert.ToInt32(ch) - 48 'der char 0 hat den asci wert 48, 1 ist 49
            output += temp * 2 ^ count
            count += 1
        Next
        Return output
    End Function

    Private Sub Auswerten_Click(sender As Object, e As EventArgs) Handles Auswerten.Click

        firstTimeinLösungen = False

        If Test_TextBoxAnteile.Text = Lösung_TextBoxAnteile.Text Then
            Test_TextBoxAnteile.BackColor = Color.Green
        Else
            Test_TextBoxAnteile.BackColor = Color.Red
        End If

        If Test_TextBoxNID.Text = Lösung_TextBoxNID.Text Then
            Test_TextBoxNID.BackColor = Color.Green
        Else
            Test_TextBoxNID.BackColor = Color.Red
        End If

        If Test_TextBoxBID.Text = Lösung_TextBoxBID.Text Then
            Test_TextBoxBID.BackColor = Color.Green
        Else
            Test_TextBoxBID.BackColor = Color.Red
        End If

        If Test_TextBoxAHosts.Text = Lösung_TextBoxAHosts.Text Then
            Test_TextBoxAHosts.BackColor = Color.Green
        Else
            Test_TextBoxAHosts.BackColor = Color.Red
        End If

        If Test_TextBoxASub.Text = Lösung_TextBoxASub.Text Then
            Test_TextBoxASub.BackColor = Color.Green
        Else
            Test_TextBoxASub.BackColor = Color.Red
        End If

        If Test_TextBoxSubNr.Text = Lösung_TextBoxSubnetznr.Text Then
            Test_TextBoxSubNr.BackColor = Color.Green
        Else
            Test_TextBoxSubNr.BackColor = Color.Red
        End If

        If Test_TextBoxHostsIns.Text = Lösung_TextBoxHostsIns.Text Then
            Test_TextBoxHostsIns.BackColor = Color.Green
        Else
            Test_TextBoxHostsIns.BackColor = Color.Red
        End If
    End Sub

    Private Function IsIp(ip As String)
        'um eine gültige ip zu sein müssen vier teile vorliegen die durch einen punkt getrennt sind
        'jeder teil muss eine zahl zwischen 0 und 255 sein
        Dim ipparts() As String = ip.Split(".")
        If Not ipparts.Length = 4 Then
            Return False
        End If
        Dim check As Integer
        If Not Integer.TryParse(ipparts(0), check) Then
            Return False
        End If
        If Not Integer.TryParse(ipparts(1), check) Then
            Return False
        End If
        If Not Integer.TryParse(ipparts(2), check) Then
            Return False
        End If
        If Not Integer.TryParse(ipparts(3), check) Then
            Return False
        End If
        If Not (ipparts(0) >= 0 And ipparts(0) <= 255) Then
            Return False
        End If
        If Not (ipparts(1) >= 0 And ipparts(1) <= 255) Then
            Return False
        End If
        If Not (ipparts(2) >= 0 And ipparts(2) <= 255) Then
            Return False
        End If
        If Not (ipparts(3) >= 0 And ipparts(3) <= 255) Then
            Return False
        End If
        Return True
    End Function
End Class
