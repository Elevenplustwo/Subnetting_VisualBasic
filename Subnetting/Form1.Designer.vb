<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.IPLabel = New System.Windows.Forms.Label()
        Me.SMLabel = New System.Windows.Forms.Label()
        Me.SMTextBox = New System.Windows.Forms.TextBox()
        Me.CidrTextBox = New System.Windows.Forms.TextBox()
        Me.CidrLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Generator_CidrMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Generator_CidrMin = New System.Windows.Forms.TextBox()
        Me.LJeff = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DRACHE = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Generator_SMMax = New System.Windows.Forms.TextBox()
        Me.Generator_SMMin = New System.Windows.Forms.TextBox()
        Me.Fred = New System.Windows.Forms.Label()
        Me.Tim = New System.Windows.Forms.Label()
        Me.CidrCheckBox = New System.Windows.Forms.CheckBox()
        Me.SMCheckBox = New System.Windows.Forms.CheckBox()
        Me.IPCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Auswerten = New System.Windows.Forms.Button()
        Me.Test_TextBoxASub = New System.Windows.Forms.TextBox()
        Me.Test_LabelASub = New System.Windows.Forms.Label()
        Me.Test_TextBoxHostsIns = New System.Windows.Forms.TextBox()
        Me.Test_LabelHostsIns = New System.Windows.Forms.Label()
        Me.Test_TextBoxAHosts = New System.Windows.Forms.TextBox()
        Me.Test_TextBoxBID = New System.Windows.Forms.TextBox()
        Me.Test_LabelSubNr = New System.Windows.Forms.Label()
        Me.Test_LabelBID = New System.Windows.Forms.Label()
        Me.Test_LabelAHosts = New System.Windows.Forms.Label()
        Me.Test_LabelNID = New System.Windows.Forms.Label()
        Me.Test_TextBoxSubNr = New System.Windows.Forms.TextBox()
        Me.Test_TextBoxNID = New System.Windows.Forms.TextBox()
        Me.Test_TextBoxAnteile = New System.Windows.Forms.TextBox()
        Me.Test_LabelAnteile = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Lösung_TextBoxASub = New System.Windows.Forms.TextBox()
        Me.Lösung_LabelAnzahlSubnetze = New System.Windows.Forms.Label()
        Me.Lösung_TextBoxHostsIns = New System.Windows.Forms.TextBox()
        Me.Lösung_LabelHostsInsgesamt = New System.Windows.Forms.Label()
        Me.Lösung_TextBoxAHosts = New System.Windows.Forms.TextBox()
        Me.Lösung_TextBoxBID = New System.Windows.Forms.TextBox()
        Me.Lösung_LabelSubnetznr = New System.Windows.Forms.Label()
        Me.Lösung_LabelBID = New System.Windows.Forms.Label()
        Me.Lösung_LabelAnzahlHosts = New System.Windows.Forms.Label()
        Me.Lösung_LabelNID = New System.Windows.Forms.Label()
        Me.Lösung_TextBoxSubnetznr = New System.Windows.Forms.TextBox()
        Me.Lösung_TextBoxNID = New System.Windows.Forms.TextBox()
        Me.Lösung_TextBoxAnteile = New System.Windows.Forms.TextBox()
        Me.Lösung_LabelAnteile = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IPTextBox
        '
        Me.IPTextBox.Location = New System.Drawing.Point(141, 6)
        Me.IPTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.PlaceholderText = "DDDD.DDDD.DDDD.DDDD"
        Me.IPTextBox.Size = New System.Drawing.Size(195, 23)
        Me.IPTextBox.TabIndex = 0
        '
        'IPLabel
        '
        Me.IPLabel.AutoSize = True
        Me.IPLabel.Location = New System.Drawing.Point(10, 7)
        Me.IPLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IPLabel.Name = "IPLabel"
        Me.IPLabel.Size = New System.Drawing.Size(114, 15)
        Me.IPLabel.TabIndex = 1
        Me.IPLabel.Text = "IP Adresse und CIDR"
        '
        'SMLabel
        '
        Me.SMLabel.AutoSize = True
        Me.SMLabel.Location = New System.Drawing.Point(10, 39)
        Me.SMLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SMLabel.Name = "SMLabel"
        Me.SMLabel.Size = New System.Drawing.Size(83, 15)
        Me.SMLabel.TabIndex = 2
        Me.SMLabel.Text = "Subnetzmaske"
        '
        'SMTextBox
        '
        Me.SMTextBox.Location = New System.Drawing.Point(141, 36)
        Me.SMTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SMTextBox.Name = "SMTextBox"
        Me.SMTextBox.PlaceholderText = "DDDD.DDDD.DDDD.DDDD"
        Me.SMTextBox.Size = New System.Drawing.Size(195, 23)
        Me.SMTextBox.TabIndex = 6
        '
        'CidrTextBox
        '
        Me.CidrTextBox.Location = New System.Drawing.Point(357, 6)
        Me.CidrTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CidrTextBox.Name = "CidrTextBox"
        Me.CidrTextBox.PlaceholderText = "DD"
        Me.CidrTextBox.Size = New System.Drawing.Size(28, 23)
        Me.CidrTextBox.TabIndex = 7
        '
        'CidrLabel
        '
        Me.CidrLabel.AutoSize = True
        Me.CidrLabel.Location = New System.Drawing.Point(342, 9)
        Me.CidrLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CidrLabel.Name = "CidrLabel"
        Me.CidrLabel.Size = New System.Drawing.Size(12, 15)
        Me.CidrLabel.TabIndex = 8
        Me.CidrLabel.Text = "/"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(11, 68)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 170)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Generator_CidrMax)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Generator_CidrMin)
        Me.TabPage1.Controls.Add(Me.LJeff)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DRACHE)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Generator_SMMax)
        Me.TabPage1.Controls.Add(Me.Generator_SMMin)
        Me.TabPage1.Controls.Add(Me.Fred)
        Me.TabPage1.Controls.Add(Me.Tim)
        Me.TabPage1.Controls.Add(Me.CidrCheckBox)
        Me.TabPage1.Controls.Add(Me.SMCheckBox)
        Me.TabPage1.Controls.Add(Me.IPCheckBox)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(440, 142)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generator"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Generator_CidrMax
        '
        Me.Generator_CidrMax.Location = New System.Drawing.Point(257, 74)
        Me.Generator_CidrMax.Name = "Generator_CidrMax"
        Me.Generator_CidrMax.PlaceholderText = "29"
        Me.Generator_CidrMax.Size = New System.Drawing.Size(100, 23)
        Me.Generator_CidrMax.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Von"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Von"
        '
        'Generator_CidrMin
        '
        Me.Generator_CidrMin.Location = New System.Drawing.Point(123, 74)
        Me.Generator_CidrMin.Name = "Generator_CidrMin"
        Me.Generator_CidrMin.PlaceholderText = "0"
        Me.Generator_CidrMin.Size = New System.Drawing.Size(100, 23)
        Me.Generator_CidrMin.TabIndex = 12
        '
        'LJeff
        '
        Me.LJeff.AutoSize = True
        Me.LJeff.Location = New System.Drawing.Point(5, 82)
        Me.LJeff.Name = "LJeff"
        Me.LJeff.Size = New System.Drawing.Size(36, 15)
        Me.LJeff.TabIndex = 11
        Me.LJeff.Text = "CIDR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Bis"
        '
        'DRACHE
        '
        Me.DRACHE.AutoSize = True
        Me.DRACHE.Location = New System.Drawing.Point(229, 49)
        Me.DRACHE.Name = "DRACHE"
        Me.DRACHE.Size = New System.Drawing.Size(22, 15)
        Me.DRACHE.TabIndex = 9
        Me.DRACHE.Text = "Bis"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Zufällig", "Klasse A", "Klasse B", "Klasse C", "Klasse D", "Klasse E"})
        Me.ComboBox1.Location = New System.Drawing.Point(102, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 8
        '
        'Generator_SMMax
        '
        Me.Generator_SMMax.Location = New System.Drawing.Point(257, 41)
        Me.Generator_SMMax.Name = "Generator_SMMax"
        Me.Generator_SMMax.PlaceholderText = "30"
        Me.Generator_SMMax.Size = New System.Drawing.Size(100, 23)
        Me.Generator_SMMax.TabIndex = 7
        '
        'Generator_SMMin
        '
        Me.Generator_SMMin.Location = New System.Drawing.Point(123, 41)
        Me.Generator_SMMin.Name = "Generator_SMMin"
        Me.Generator_SMMin.PlaceholderText = "0"
        Me.Generator_SMMin.Size = New System.Drawing.Size(100, 23)
        Me.Generator_SMMin.TabIndex = 6
        '
        'Fred
        '
        Me.Fred.AutoSize = True
        Me.Fred.Location = New System.Drawing.Point(5, 49)
        Me.Fred.Name = "Fred"
        Me.Fred.Size = New System.Drawing.Size(86, 15)
        Me.Fred.TabIndex = 5
        Me.Fred.Text = "Subnetzmaske:"
        '
        'Tim
        '
        Me.Tim.AutoSize = True
        Me.Tim.Location = New System.Drawing.Point(5, 9)
        Me.Tim.Name = "Tim"
        Me.Tim.Size = New System.Drawing.Size(92, 15)
        Me.Tim.TabIndex = 4
        Me.Tim.Text = "IP Adressklasse: "
        '
        'CidrCheckBox
        '
        Me.CidrCheckBox.AutoSize = True
        Me.CidrCheckBox.Location = New System.Drawing.Point(240, 114)
        Me.CidrCheckBox.Name = "CidrCheckBox"
        Me.CidrCheckBox.Size = New System.Drawing.Size(95, 19)
        Me.CidrCheckBox.TabIndex = 3
        Me.CidrCheckBox.Text = "CIDR merken"
        Me.CidrCheckBox.UseVisualStyleBackColor = True
        '
        'SMCheckBox
        '
        Me.SMCheckBox.AutoSize = True
        Me.SMCheckBox.Location = New System.Drawing.Point(90, 114)
        Me.SMCheckBox.Name = "SMCheckBox"
        Me.SMCheckBox.Size = New System.Drawing.Size(145, 19)
        Me.SMCheckBox.TabIndex = 2
        Me.SMCheckBox.Text = "Subnetzmaske merken"
        Me.SMCheckBox.UseVisualStyleBackColor = True
        '
        'IPCheckBox
        '
        Me.IPCheckBox.AutoSize = True
        Me.IPCheckBox.Location = New System.Drawing.Point(7, 114)
        Me.IPCheckBox.Name = "IPCheckBox"
        Me.IPCheckBox.Size = New System.Drawing.Size(79, 19)
        Me.IPCheckBox.TabIndex = 1
        Me.IPCheckBox.Text = "IP merken"
        Me.IPCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generieren"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Auswerten)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxASub)
        Me.TabPage2.Controls.Add(Me.Test_LabelASub)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxHostsIns)
        Me.TabPage2.Controls.Add(Me.Test_LabelHostsIns)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxAHosts)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxBID)
        Me.TabPage2.Controls.Add(Me.Test_LabelSubNr)
        Me.TabPage2.Controls.Add(Me.Test_LabelBID)
        Me.TabPage2.Controls.Add(Me.Test_LabelAHosts)
        Me.TabPage2.Controls.Add(Me.Test_LabelNID)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxSubNr)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxNID)
        Me.TabPage2.Controls.Add(Me.Test_TextBoxAnteile)
        Me.TabPage2.Controls.Add(Me.Test_LabelAnteile)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(440, 142)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Teste dich"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Auswerten
        '
        Me.Auswerten.Location = New System.Drawing.Point(346, 106)
        Me.Auswerten.Name = "Auswerten"
        Me.Auswerten.Size = New System.Drawing.Size(87, 23)
        Me.Auswerten.TabIndex = 32
        Me.Auswerten.Text = "Auswerten"
        Me.Auswerten.UseVisualStyleBackColor = True
        '
        'Test_TextBoxASub
        '
        Me.Test_TextBoxASub.Location = New System.Drawing.Point(210, 107)
        Me.Test_TextBoxASub.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxASub.Name = "Test_TextBoxASub"
        Me.Test_TextBoxASub.PlaceholderText = "DD"
        Me.Test_TextBoxASub.Size = New System.Drawing.Size(106, 23)
        Me.Test_TextBoxASub.TabIndex = 31
        '
        'Test_LabelASub
        '
        Me.Test_LabelASub.AutoSize = True
        Me.Test_LabelASub.Location = New System.Drawing.Point(210, 90)
        Me.Test_LabelASub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelASub.Name = "Test_LabelASub"
        Me.Test_LabelASub.Size = New System.Drawing.Size(94, 15)
        Me.Test_LabelASub.TabIndex = 30
        Me.Test_LabelASub.Text = "Anzahl Subnetze"
        '
        'Test_TextBoxHostsIns
        '
        Me.Test_TextBoxHostsIns.Location = New System.Drawing.Point(327, 65)
        Me.Test_TextBoxHostsIns.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxHostsIns.Name = "Test_TextBoxHostsIns"
        Me.Test_TextBoxHostsIns.PlaceholderText = "DD"
        Me.Test_TextBoxHostsIns.Size = New System.Drawing.Size(106, 23)
        Me.Test_TextBoxHostsIns.TabIndex = 29
        '
        'Test_LabelHostsIns
        '
        Me.Test_LabelHostsIns.AutoSize = True
        Me.Test_LabelHostsIns.Location = New System.Drawing.Point(327, 48)
        Me.Test_LabelHostsIns.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelHostsIns.Name = "Test_LabelHostsIns"
        Me.Test_LabelHostsIns.Size = New System.Drawing.Size(94, 15)
        Me.Test_LabelHostsIns.TabIndex = 28
        Me.Test_LabelHostsIns.Text = "Hosts insgesamt"
        '
        'Test_TextBoxAHosts
        '
        Me.Test_TextBoxAHosts.Location = New System.Drawing.Point(210, 65)
        Me.Test_TextBoxAHosts.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxAHosts.Name = "Test_TextBoxAHosts"
        Me.Test_TextBoxAHosts.PlaceholderText = "DD"
        Me.Test_TextBoxAHosts.Size = New System.Drawing.Size(106, 23)
        Me.Test_TextBoxAHosts.TabIndex = 27
        '
        'Test_TextBoxBID
        '
        Me.Test_TextBoxBID.Location = New System.Drawing.Point(5, 107)
        Me.Test_TextBoxBID.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxBID.Name = "Test_TextBoxBID"
        Me.Test_TextBoxBID.PlaceholderText = "DDDD.DDDD.DDDD.DDDD"
        Me.Test_TextBoxBID.Size = New System.Drawing.Size(195, 23)
        Me.Test_TextBoxBID.TabIndex = 26
        '
        'Test_LabelSubNr
        '
        Me.Test_LabelSubNr.AutoSize = True
        Me.Test_LabelSubNr.Location = New System.Drawing.Point(327, 6)
        Me.Test_LabelSubNr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelSubNr.Name = "Test_LabelSubNr"
        Me.Test_LabelSubNr.Size = New System.Drawing.Size(95, 15)
        Me.Test_LabelSubNr.TabIndex = 25
        Me.Test_LabelSubNr.Text = "Subnetznummer"
        '
        'Test_LabelBID
        '
        Me.Test_LabelBID.AutoSize = True
        Me.Test_LabelBID.Location = New System.Drawing.Point(5, 90)
        Me.Test_LabelBID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelBID.Name = "Test_LabelBID"
        Me.Test_LabelBID.Size = New System.Drawing.Size(73, 15)
        Me.Test_LabelBID.TabIndex = 24
        Me.Test_LabelBID.Text = "Broadcast ID"
        '
        'Test_LabelAHosts
        '
        Me.Test_LabelAHosts.AutoSize = True
        Me.Test_LabelAHosts.Location = New System.Drawing.Point(210, 48)
        Me.Test_LabelAHosts.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelAHosts.Name = "Test_LabelAHosts"
        Me.Test_LabelAHosts.Size = New System.Drawing.Size(76, 15)
        Me.Test_LabelAHosts.TabIndex = 23
        Me.Test_LabelAHosts.Text = "Anzahl Hosts"
        '
        'Test_LabelNID
        '
        Me.Test_LabelNID.AutoSize = True
        Me.Test_LabelNID.Location = New System.Drawing.Point(5, 48)
        Me.Test_LabelNID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelNID.Name = "Test_LabelNID"
        Me.Test_LabelNID.Size = New System.Drawing.Size(66, 15)
        Me.Test_LabelNID.TabIndex = 22
        Me.Test_LabelNID.Text = "Network ID"
        '
        'Test_TextBoxSubNr
        '
        Me.Test_TextBoxSubNr.Location = New System.Drawing.Point(327, 23)
        Me.Test_TextBoxSubNr.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxSubNr.Name = "Test_TextBoxSubNr"
        Me.Test_TextBoxSubNr.PlaceholderText = "DD"
        Me.Test_TextBoxSubNr.Size = New System.Drawing.Size(106, 23)
        Me.Test_TextBoxSubNr.TabIndex = 21
        '
        'Test_TextBoxNID
        '
        Me.Test_TextBoxNID.Location = New System.Drawing.Point(5, 65)
        Me.Test_TextBoxNID.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxNID.Name = "Test_TextBoxNID"
        Me.Test_TextBoxNID.PlaceholderText = "DDDD.DDDD.DDDD.DDDD"
        Me.Test_TextBoxNID.Size = New System.Drawing.Size(195, 23)
        Me.Test_TextBoxNID.TabIndex = 20
        '
        'Test_TextBoxAnteile
        '
        Me.Test_TextBoxAnteile.Location = New System.Drawing.Point(5, 23)
        Me.Test_TextBoxAnteile.Margin = New System.Windows.Forms.Padding(2)
        Me.Test_TextBoxAnteile.Name = "Test_TextBoxAnteile"
        Me.Test_TextBoxAnteile.PlaceholderText = "BBBBBBBB.B | BBBBBBB.BBBBBBBB.B | BBBBBBB"
        Me.Test_TextBoxAnteile.Size = New System.Drawing.Size(311, 23)
        Me.Test_TextBoxAnteile.TabIndex = 19
        '
        'Test_LabelAnteile
        '
        Me.Test_LabelAnteile.AutoSize = True
        Me.Test_LabelAnteile.Location = New System.Drawing.Point(5, 6)
        Me.Test_LabelAnteile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Test_LabelAnteile.Name = "Test_LabelAnteile"
        Me.Test_LabelAnteile.Size = New System.Drawing.Size(189, 15)
        Me.Test_LabelAnteile.TabIndex = 18
        Me.Test_LabelAnteile.Text = "Netzwerkteil | Subnetzteil | Hostteil"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxASub)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelAnzahlSubnetze)
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxHostsIns)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelHostsInsgesamt)
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxAHosts)
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxBID)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelSubnetznr)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelBID)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelAnzahlHosts)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelNID)
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxSubnetznr)
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxNID)
        Me.TabPage3.Controls.Add(Me.Lösung_TextBoxAnteile)
        Me.TabPage3.Controls.Add(Me.Lösung_LabelAnteile)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(440, 142)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Lösungen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Lösung_TextBoxASub
        '
        Me.Lösung_TextBoxASub.Location = New System.Drawing.Point(210, 107)
        Me.Lösung_TextBoxASub.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxASub.Name = "Lösung_TextBoxASub"
        Me.Lösung_TextBoxASub.ReadOnly = True
        Me.Lösung_TextBoxASub.Size = New System.Drawing.Size(106, 23)
        Me.Lösung_TextBoxASub.TabIndex = 17
        '
        'Lösung_LabelAnzahlSubnetze
        '
        Me.Lösung_LabelAnzahlSubnetze.AutoSize = True
        Me.Lösung_LabelAnzahlSubnetze.Location = New System.Drawing.Point(210, 90)
        Me.Lösung_LabelAnzahlSubnetze.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelAnzahlSubnetze.Name = "Lösung_LabelAnzahlSubnetze"
        Me.Lösung_LabelAnzahlSubnetze.Size = New System.Drawing.Size(94, 15)
        Me.Lösung_LabelAnzahlSubnetze.TabIndex = 16
        Me.Lösung_LabelAnzahlSubnetze.Text = "Anzahl Subnetze"
        '
        'Lösung_TextBoxHostsIns
        '
        Me.Lösung_TextBoxHostsIns.Location = New System.Drawing.Point(327, 65)
        Me.Lösung_TextBoxHostsIns.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxHostsIns.Name = "Lösung_TextBoxHostsIns"
        Me.Lösung_TextBoxHostsIns.ReadOnly = True
        Me.Lösung_TextBoxHostsIns.Size = New System.Drawing.Size(106, 23)
        Me.Lösung_TextBoxHostsIns.TabIndex = 15
        '
        'Lösung_LabelHostsInsgesamt
        '
        Me.Lösung_LabelHostsInsgesamt.AutoSize = True
        Me.Lösung_LabelHostsInsgesamt.Location = New System.Drawing.Point(327, 48)
        Me.Lösung_LabelHostsInsgesamt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelHostsInsgesamt.Name = "Lösung_LabelHostsInsgesamt"
        Me.Lösung_LabelHostsInsgesamt.Size = New System.Drawing.Size(94, 15)
        Me.Lösung_LabelHostsInsgesamt.TabIndex = 14
        Me.Lösung_LabelHostsInsgesamt.Text = "Hosts insgesamt"
        '
        'Lösung_TextBoxAHosts
        '
        Me.Lösung_TextBoxAHosts.Location = New System.Drawing.Point(210, 65)
        Me.Lösung_TextBoxAHosts.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxAHosts.Name = "Lösung_TextBoxAHosts"
        Me.Lösung_TextBoxAHosts.ReadOnly = True
        Me.Lösung_TextBoxAHosts.Size = New System.Drawing.Size(106, 23)
        Me.Lösung_TextBoxAHosts.TabIndex = 13
        '
        'Lösung_TextBoxBID
        '
        Me.Lösung_TextBoxBID.Location = New System.Drawing.Point(5, 107)
        Me.Lösung_TextBoxBID.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxBID.Name = "Lösung_TextBoxBID"
        Me.Lösung_TextBoxBID.ReadOnly = True
        Me.Lösung_TextBoxBID.Size = New System.Drawing.Size(195, 23)
        Me.Lösung_TextBoxBID.TabIndex = 12
        '
        'Lösung_LabelSubnetznr
        '
        Me.Lösung_LabelSubnetznr.AutoSize = True
        Me.Lösung_LabelSubnetznr.Location = New System.Drawing.Point(327, 6)
        Me.Lösung_LabelSubnetznr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelSubnetznr.Name = "Lösung_LabelSubnetznr"
        Me.Lösung_LabelSubnetznr.Size = New System.Drawing.Size(95, 15)
        Me.Lösung_LabelSubnetznr.TabIndex = 11
        Me.Lösung_LabelSubnetznr.Text = "Subnetznummer"
        '
        'Lösung_LabelBID
        '
        Me.Lösung_LabelBID.AutoSize = True
        Me.Lösung_LabelBID.Location = New System.Drawing.Point(5, 90)
        Me.Lösung_LabelBID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelBID.Name = "Lösung_LabelBID"
        Me.Lösung_LabelBID.Size = New System.Drawing.Size(73, 15)
        Me.Lösung_LabelBID.TabIndex = 10
        Me.Lösung_LabelBID.Text = "Broadcast ID"
        '
        'Lösung_LabelAnzahlHosts
        '
        Me.Lösung_LabelAnzahlHosts.AutoSize = True
        Me.Lösung_LabelAnzahlHosts.Location = New System.Drawing.Point(210, 48)
        Me.Lösung_LabelAnzahlHosts.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelAnzahlHosts.Name = "Lösung_LabelAnzahlHosts"
        Me.Lösung_LabelAnzahlHosts.Size = New System.Drawing.Size(76, 15)
        Me.Lösung_LabelAnzahlHosts.TabIndex = 9
        Me.Lösung_LabelAnzahlHosts.Text = "Anzahl Hosts"
        '
        'Lösung_LabelNID
        '
        Me.Lösung_LabelNID.AutoSize = True
        Me.Lösung_LabelNID.Location = New System.Drawing.Point(5, 48)
        Me.Lösung_LabelNID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelNID.Name = "Lösung_LabelNID"
        Me.Lösung_LabelNID.Size = New System.Drawing.Size(66, 15)
        Me.Lösung_LabelNID.TabIndex = 8
        Me.Lösung_LabelNID.Text = "Network ID"
        '
        'Lösung_TextBoxSubnetznr
        '
        Me.Lösung_TextBoxSubnetznr.Location = New System.Drawing.Point(327, 23)
        Me.Lösung_TextBoxSubnetznr.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxSubnetznr.Name = "Lösung_TextBoxSubnetznr"
        Me.Lösung_TextBoxSubnetznr.ReadOnly = True
        Me.Lösung_TextBoxSubnetznr.Size = New System.Drawing.Size(106, 23)
        Me.Lösung_TextBoxSubnetznr.TabIndex = 7
        '
        'Lösung_TextBoxNID
        '
        Me.Lösung_TextBoxNID.Location = New System.Drawing.Point(5, 65)
        Me.Lösung_TextBoxNID.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxNID.Name = "Lösung_TextBoxNID"
        Me.Lösung_TextBoxNID.ReadOnly = True
        Me.Lösung_TextBoxNID.Size = New System.Drawing.Size(195, 23)
        Me.Lösung_TextBoxNID.TabIndex = 6
        '
        'Lösung_TextBoxAnteile
        '
        Me.Lösung_TextBoxAnteile.Location = New System.Drawing.Point(5, 23)
        Me.Lösung_TextBoxAnteile.Margin = New System.Windows.Forms.Padding(2)
        Me.Lösung_TextBoxAnteile.Name = "Lösung_TextBoxAnteile"
        Me.Lösung_TextBoxAnteile.ReadOnly = True
        Me.Lösung_TextBoxAnteile.Size = New System.Drawing.Size(311, 23)
        Me.Lösung_TextBoxAnteile.TabIndex = 3
        '
        'Lösung_LabelAnteile
        '
        Me.Lösung_LabelAnteile.AutoSize = True
        Me.Lösung_LabelAnteile.Location = New System.Drawing.Point(5, 6)
        Me.Lösung_LabelAnteile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lösung_LabelAnteile.Name = "Lösung_LabelAnteile"
        Me.Lösung_LabelAnteile.Size = New System.Drawing.Size(189, 15)
        Me.Lösung_LabelAnteile.TabIndex = 0
        Me.Lösung_LabelAnteile.Text = "Netzwerkteil | Subnetzteil | Hostteil"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 243)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CidrLabel)
        Me.Controls.Add(Me.CidrTextBox)
        Me.Controls.Add(Me.SMTextBox)
        Me.Controls.Add(Me.SMLabel)
        Me.Controls.Add(Me.IPLabel)
        Me.Controls.Add(Me.IPTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Subnetting Tool"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents IPTextBox As TextBox
    Friend WithEvents IPLabel As Label
    Friend WithEvents SMLabel As Label
    Friend WithEvents SMTextBox As TextBox
    Friend WithEvents CidrTextBox As TextBox
    Friend WithEvents CidrLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Lösung_TextBoxASub As TextBox
    Friend WithEvents Lösung_LabelAnzahlSubnetze As Label
    Friend WithEvents Lösung_TextBoxHostsIns As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Lösung_TextBoxAHosts As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lösung_LabelNID As Label
    Friend WithEvents Lösung_TextBoxSubnetznr As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Lösung_TextBoxAnteile As TextBox
    Friend WithEvents Lösung_LabelAnteile As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Test_TextBoxASub As TextBox
    Friend WithEvents Test_LabelASub As Label
    Friend WithEvents Test_TextBoxHostsIns As TextBox
    Friend WithEvents Test_LabelHostsIns As Label
    Friend WithEvents Test_TextBoxAHosts As TextBox
    Friend WithEvents Test_TextBoxBID As TextBox
    Friend WithEvents Test_LabelSubNr As Label
    Friend WithEvents Test_LabelBID As Label
    Friend WithEvents Test_LabelAHosts As Label
    Friend WithEvents Test_LabelNID As Label
    Friend WithEvents Test_TextBoxSubNr As TextBox
    Friend WithEvents Test_TextBoxNID As TextBox
    Friend WithEvents Test_TextBoxAnteile As TextBox
    Friend WithEvents Test_Label As Label
    Friend WithEvents Test_LabelAnteile As Label
    Friend WithEvents Lösung_LabelBID As Label
    Friend WithEvents Lösung_LabelAnzahlHosts As Label
    Friend WithEvents Lösung_LabelSubnetznr As Label
    Friend WithEvents Lösung_LabelHostsInsgesamt As Label
    Friend WithEvents Lösung_TextBoxNID As TextBox
    Friend WithEvents Lösung_TextBoxBID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DRACHE As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents Generator_SMMin As TextBox
    Friend WithEvents Fred As Label
    Friend WithEvents Tim As Label
    Friend WithEvents CidrCheckBox As CheckBox
    Friend WithEvents SMCheckBox As CheckBox
    Friend WithEvents IPCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LJeff As Label
    Friend WithEvents Generator_CidrMin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Generator_SMMax As TextBox
    Friend WithEvents Generator_CidrMax As TextBox
    Friend WithEvents pC As CheckBox
    Friend WithEvents Auswerten As Button
End Class
