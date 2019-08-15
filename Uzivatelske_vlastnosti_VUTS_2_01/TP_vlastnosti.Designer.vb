<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TP_vlastnosti
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.B_kota = New System.Windows.Forms.Button()
        Me.B_obnovit = New System.Windows.Forms.Button()
        Me.B_ulozit = New System.Windows.Forms.Button()
        Me.CB_presnost = New System.Windows.Forms.ComboBox()
        Me.TB_stary = New System.Windows.Forms.TextBox()
        Me.L_stary = New System.Windows.Forms.Label()
        Me.L_presnost = New System.Windows.Forms.Label()
        Me.CB_pozn6 = New System.Windows.Forms.ComboBox()
        Me.CB_pozn5 = New System.Windows.Forms.ComboBox()
        Me.CB_pozn4 = New System.Windows.Forms.ComboBox()
        Me.CB_pozn3 = New System.Windows.Forms.ComboBox()
        Me.CB_pozn2 = New System.Windows.Forms.ComboBox()
        Me.L_poznamky = New System.Windows.Forms.Label()
        Me.CB_pozn1 = New System.Windows.Forms.ComboBox()
        Me.RB_vl = New System.Windows.Forms.RadioButton()
        Me.RB_zdb = New System.Windows.Forms.RadioButton()
        Me.TB_nazev = New System.Windows.Forms.TextBox()
        Me.L_nazev = New System.Windows.Forms.Label()
        Me.TB_rozm = New System.Windows.Forms.TextBox()
        Me.L_rozm = New System.Windows.Forms.Label()
        Me.L_dod = New System.Windows.Forms.Label()
        Me.TB_dod = New System.Windows.Forms.TextBox()
        Me.TB_nor = New System.Windows.Forms.TextBox()
        Me.TB_mat = New System.Windows.Forms.TextBox()
        Me.L_polot = New System.Windows.Forms.Label()
        Me.L_nor = New System.Windows.Forms.Label()
        Me.L_mat = New System.Windows.Forms.Label()
        Me.L_typpol = New System.Windows.Forms.Label()
        Me.CB_polot = New System.Windows.Forms.ComboBox()
        Me.CB_typpol = New System.Windows.Forms.ComboBox()
        Me.TB_rozm2 = New System.Windows.Forms.TextBox()
        Me.RB_tab = New System.Windows.Forms.RadioButton()
        Me.LV_tab = New System.Windows.Forms.ListView()
        Me.COL_ks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_nazev = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_polot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_rozm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_nor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_mat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_dod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COL_poz = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_hmotnost = New System.Windows.Forms.TextBox()
        Me.L_kg = New System.Windows.Forms.Label()
        Me.L_hmotnost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B_kota
        '
        Me.B_kota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_kota.Enabled = False
        Me.B_kota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.B_kota.Location = New System.Drawing.Point(356, 341)
        Me.B_kota.Name = "B_kota"
        Me.B_kota.Size = New System.Drawing.Size(62, 23)
        Me.B_kota.TabIndex = 169
        Me.B_kota.Text = "Kóta"
        Me.B_kota.UseVisualStyleBackColor = True
        '
        'B_obnovit
        '
        Me.B_obnovit.Enabled = False
        Me.B_obnovit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.B_obnovit.Location = New System.Drawing.Point(11, 741)
        Me.B_obnovit.Name = "B_obnovit"
        Me.B_obnovit.Size = New System.Drawing.Size(113, 23)
        Me.B_obnovit.TabIndex = 168
        Me.B_obnovit.Text = "Obnovit"
        Me.B_obnovit.UseVisualStyleBackColor = True
        '
        'B_ulozit
        '
        Me.B_ulozit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_ulozit.Enabled = False
        Me.B_ulozit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.B_ulozit.ForeColor = System.Drawing.Color.Red
        Me.B_ulozit.Location = New System.Drawing.Point(302, 741)
        Me.B_ulozit.Name = "B_ulozit"
        Me.B_ulozit.Size = New System.Drawing.Size(116, 23)
        Me.B_ulozit.TabIndex = 167
        Me.B_ulozit.Text = "Uložit"
        Me.B_ulozit.UseVisualStyleBackColor = True
        '
        'CB_presnost
        '
        Me.CB_presnost.Enabled = False
        Me.CB_presnost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_presnost.FormattingEnabled = True
        Me.CB_presnost.Items.AddRange(New Object() {"fH", "mK", "cL"})
        Me.CB_presnost.Location = New System.Drawing.Point(11, 698)
        Me.CB_presnost.Name = "CB_presnost"
        Me.CB_presnost.Size = New System.Drawing.Size(68, 21)
        Me.CB_presnost.TabIndex = 166
        '
        'TB_stary
        '
        Me.TB_stary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_stary.Enabled = False
        Me.TB_stary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_stary.Location = New System.Drawing.Point(188, 700)
        Me.TB_stary.Name = "TB_stary"
        Me.TB_stary.Size = New System.Drawing.Size(230, 20)
        Me.TB_stary.TabIndex = 165
        '
        'L_stary
        '
        Me.L_stary.AutoSize = True
        Me.L_stary.Enabled = False
        Me.L_stary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_stary.Location = New System.Drawing.Point(186, 679)
        Me.L_stary.Name = "L_stary"
        Me.L_stary.Size = New System.Drawing.Size(65, 13)
        Me.L_stary.TabIndex = 164
        Me.L_stary.Text = "Starý výkres"
        '
        'L_presnost
        '
        Me.L_presnost.AutoSize = True
        Me.L_presnost.Enabled = False
        Me.L_presnost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_presnost.Location = New System.Drawing.Point(8, 680)
        Me.L_presnost.Name = "L_presnost"
        Me.L_presnost.Size = New System.Drawing.Size(49, 13)
        Me.L_presnost.TabIndex = 163
        Me.L_presnost.Text = "Přesnost"
        '
        'CB_pozn6
        '
        Me.CB_pozn6.AllowDrop = True
        Me.CB_pozn6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_pozn6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_pozn6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_pozn6.Enabled = False
        Me.CB_pozn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_pozn6.FormattingEnabled = True
        Me.CB_pozn6.Location = New System.Drawing.Point(11, 646)
        Me.CB_pozn6.Name = "CB_pozn6"
        Me.CB_pozn6.Size = New System.Drawing.Size(407, 21)
        Me.CB_pozn6.TabIndex = 162
        '
        'CB_pozn5
        '
        Me.CB_pozn5.AllowDrop = True
        Me.CB_pozn5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_pozn5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_pozn5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_pozn5.Enabled = False
        Me.CB_pozn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_pozn5.FormattingEnabled = True
        Me.CB_pozn5.Location = New System.Drawing.Point(11, 612)
        Me.CB_pozn5.Name = "CB_pozn5"
        Me.CB_pozn5.Size = New System.Drawing.Size(407, 21)
        Me.CB_pozn5.TabIndex = 161
        '
        'CB_pozn4
        '
        Me.CB_pozn4.AllowDrop = True
        Me.CB_pozn4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_pozn4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_pozn4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_pozn4.Enabled = False
        Me.CB_pozn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_pozn4.FormattingEnabled = True
        Me.CB_pozn4.Location = New System.Drawing.Point(11, 578)
        Me.CB_pozn4.Name = "CB_pozn4"
        Me.CB_pozn4.Size = New System.Drawing.Size(407, 21)
        Me.CB_pozn4.TabIndex = 160
        '
        'CB_pozn3
        '
        Me.CB_pozn3.AllowDrop = True
        Me.CB_pozn3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_pozn3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_pozn3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_pozn3.Enabled = False
        Me.CB_pozn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_pozn3.FormattingEnabled = True
        Me.CB_pozn3.Location = New System.Drawing.Point(11, 544)
        Me.CB_pozn3.Name = "CB_pozn3"
        Me.CB_pozn3.Size = New System.Drawing.Size(407, 21)
        Me.CB_pozn3.TabIndex = 159
        '
        'CB_pozn2
        '
        Me.CB_pozn2.AllowDrop = True
        Me.CB_pozn2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_pozn2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_pozn2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_pozn2.Enabled = False
        Me.CB_pozn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_pozn2.FormattingEnabled = True
        Me.CB_pozn2.Location = New System.Drawing.Point(11, 510)
        Me.CB_pozn2.Name = "CB_pozn2"
        Me.CB_pozn2.Size = New System.Drawing.Size(407, 21)
        Me.CB_pozn2.TabIndex = 158
        '
        'L_poznamky
        '
        Me.L_poznamky.AutoSize = True
        Me.L_poznamky.Enabled = False
        Me.L_poznamky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_poznamky.Location = New System.Drawing.Point(8, 455)
        Me.L_poznamky.Name = "L_poznamky"
        Me.L_poznamky.Size = New System.Drawing.Size(56, 13)
        Me.L_poznamky.TabIndex = 157
        Me.L_poznamky.Text = "Poznámky"
        '
        'CB_pozn1
        '
        Me.CB_pozn1.AllowDrop = True
        Me.CB_pozn1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_pozn1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_pozn1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_pozn1.Enabled = False
        Me.CB_pozn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_pozn1.FormattingEnabled = True
        Me.CB_pozn1.Location = New System.Drawing.Point(11, 476)
        Me.CB_pozn1.Name = "CB_pozn1"
        Me.CB_pozn1.Size = New System.Drawing.Size(407, 21)
        Me.CB_pozn1.TabIndex = 156
        '
        'RB_vl
        '
        Me.RB_vl.AutoSize = True
        Me.RB_vl.Enabled = False
        Me.RB_vl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RB_vl.Location = New System.Drawing.Point(11, 32)
        Me.RB_vl.Name = "RB_vl"
        Me.RB_vl.Size = New System.Drawing.Size(99, 17)
        Me.RB_vl.TabIndex = 154
        Me.RB_vl.TabStop = True
        Me.RB_vl.Text = "Vlastní hodnoty"
        Me.RB_vl.UseVisualStyleBackColor = True
        '
        'RB_zdb
        '
        Me.RB_zdb.AutoSize = True
        Me.RB_zdb.Enabled = False
        Me.RB_zdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RB_zdb.Location = New System.Drawing.Point(11, 9)
        Me.RB_zdb.Name = "RB_zdb"
        Me.RB_zdb.Size = New System.Drawing.Size(125, 17)
        Me.RB_zdb.TabIndex = 153
        Me.RB_zdb.TabStop = True
        Me.RB_zdb.Text = "Polotovar z databáze"
        Me.RB_zdb.UseVisualStyleBackColor = True
        '
        'TB_nazev
        '
        Me.TB_nazev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_nazev.Enabled = False
        Me.TB_nazev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_nazev.Location = New System.Drawing.Point(11, 422)
        Me.TB_nazev.Name = "TB_nazev"
        Me.TB_nazev.Size = New System.Drawing.Size(407, 20)
        Me.TB_nazev.TabIndex = 152
        '
        'L_nazev
        '
        Me.L_nazev.AutoSize = True
        Me.L_nazev.Enabled = False
        Me.L_nazev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_nazev.Location = New System.Drawing.Point(8, 404)
        Me.L_nazev.Name = "L_nazev"
        Me.L_nazev.Size = New System.Drawing.Size(38, 13)
        Me.L_nazev.TabIndex = 151
        Me.L_nazev.Text = "Název"
        '
        'TB_rozm
        '
        Me.TB_rozm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_rozm.Enabled = False
        Me.TB_rozm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_rozm.Location = New System.Drawing.Point(11, 343)
        Me.TB_rozm.Name = "TB_rozm"
        Me.TB_rozm.Size = New System.Drawing.Size(339, 20)
        Me.TB_rozm.TabIndex = 150
        '
        'L_rozm
        '
        Me.L_rozm.AutoSize = True
        Me.L_rozm.Enabled = False
        Me.L_rozm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_rozm.Location = New System.Drawing.Point(8, 325)
        Me.L_rozm.Name = "L_rozm"
        Me.L_rozm.Size = New System.Drawing.Size(63, 13)
        Me.L_rozm.TabIndex = 149
        Me.L_rozm.Text = "Čistý rozměr"
        '
        'L_dod
        '
        Me.L_dod.AutoSize = True
        Me.L_dod.Enabled = False
        Me.L_dod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_dod.Location = New System.Drawing.Point(8, 222)
        Me.L_dod.Name = "L_dod"
        Me.L_dod.Size = New System.Drawing.Size(56, 13)
        Me.L_dod.TabIndex = 148
        Me.L_dod.Text = "Dodavatel"
        Me.L_dod.Visible = False
        '
        'TB_dod
        '
        Me.TB_dod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_dod.Enabled = False
        Me.TB_dod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_dod.Location = New System.Drawing.Point(11, 241)
        Me.TB_dod.Name = "TB_dod"
        Me.TB_dod.Size = New System.Drawing.Size(407, 20)
        Me.TB_dod.TabIndex = 147
        '
        'TB_nor
        '
        Me.TB_nor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_nor.Enabled = False
        Me.TB_nor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_nor.Location = New System.Drawing.Point(11, 193)
        Me.TB_nor.Name = "TB_nor"
        Me.TB_nor.Size = New System.Drawing.Size(407, 20)
        Me.TB_nor.TabIndex = 146
        '
        'TB_mat
        '
        Me.TB_mat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_mat.Enabled = False
        Me.TB_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TB_mat.Location = New System.Drawing.Point(11, 148)
        Me.TB_mat.Name = "TB_mat"
        Me.TB_mat.Size = New System.Drawing.Size(407, 20)
        Me.TB_mat.TabIndex = 145
        '
        'L_polot
        '
        Me.L_polot.AutoSize = True
        Me.L_polot.Enabled = False
        Me.L_polot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_polot.Location = New System.Drawing.Point(8, 271)
        Me.L_polot.Name = "L_polot"
        Me.L_polot.Size = New System.Drawing.Size(52, 13)
        Me.L_polot.TabIndex = 144
        Me.L_polot.Text = "Polotovar"
        Me.L_polot.Visible = False
        '
        'L_nor
        '
        Me.L_nor.AutoSize = True
        Me.L_nor.Enabled = False
        Me.L_nor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_nor.Location = New System.Drawing.Point(8, 176)
        Me.L_nor.Name = "L_nor"
        Me.L_nor.Size = New System.Drawing.Size(90, 13)
        Me.L_nor.TabIndex = 143
        Me.L_nor.Text = "Norma - obj. číslo"
        '
        'L_mat
        '
        Me.L_mat.AutoSize = True
        Me.L_mat.Enabled = False
        Me.L_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_mat.Location = New System.Drawing.Point(8, 130)
        Me.L_mat.Name = "L_mat"
        Me.L_mat.Size = New System.Drawing.Size(44, 13)
        Me.L_mat.TabIndex = 142
        Me.L_mat.Text = "Materiál"
        Me.L_mat.Visible = False
        '
        'L_typpol
        '
        Me.L_typpol.AutoSize = True
        Me.L_typpol.Enabled = False
        Me.L_typpol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_typpol.Location = New System.Drawing.Point(8, 80)
        Me.L_typpol.Name = "L_typpol"
        Me.L_typpol.Size = New System.Drawing.Size(78, 13)
        Me.L_typpol.TabIndex = 141
        Me.L_typpol.Text = "Typ polotovaru"
        '
        'CB_polot
        '
        Me.CB_polot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_polot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CB_polot.Enabled = False
        Me.CB_polot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_polot.FormattingEnabled = True
        Me.CB_polot.Location = New System.Drawing.Point(11, 289)
        Me.CB_polot.Name = "CB_polot"
        Me.CB_polot.Size = New System.Drawing.Size(407, 21)
        Me.CB_polot.TabIndex = 140
        '
        'CB_typpol
        '
        Me.CB_typpol.AllowDrop = True
        Me.CB_typpol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_typpol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_typpol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_typpol.Enabled = False
        Me.CB_typpol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CB_typpol.FormattingEnabled = True
        Me.CB_typpol.Location = New System.Drawing.Point(11, 98)
        Me.CB_typpol.Name = "CB_typpol"
        Me.CB_typpol.Size = New System.Drawing.Size(407, 21)
        Me.CB_typpol.TabIndex = 139
        '
        'TB_rozm2
        '
        Me.TB_rozm2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_rozm2.Location = New System.Drawing.Point(11, 367)
        Me.TB_rozm2.Name = "TB_rozm2"
        Me.TB_rozm2.ReadOnly = True
        Me.TB_rozm2.Size = New System.Drawing.Size(339, 20)
        Me.TB_rozm2.TabIndex = 170
        '
        'RB_tab
        '
        Me.RB_tab.AutoSize = True
        Me.RB_tab.Location = New System.Drawing.Point(11, 56)
        Me.RB_tab.Name = "RB_tab"
        Me.RB_tab.Size = New System.Drawing.Size(102, 17)
        Me.RB_tab.TabIndex = 171
        Me.RB_tab.TabStop = True
        Me.RB_tab.Text = "Tabulka přířezů"
        Me.RB_tab.UseVisualStyleBackColor = True
        '
        'LV_tab
        '
        Me.LV_tab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LV_tab.BackColor = System.Drawing.SystemColors.Window
        Me.LV_tab.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.COL_ks, Me.COL_nazev, Me.COL_polot, Me.COL_rozm, Me.COL_nor, Me.COL_mat, Me.COL_dod, Me.COL_poz})
        Me.LV_tab.FullRowSelect = True
        Me.LV_tab.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV_tab.HideSelection = False
        Me.LV_tab.Location = New System.Drawing.Point(8, 79)
        Me.LV_tab.Name = "LV_tab"
        Me.LV_tab.Size = New System.Drawing.Size(410, 322)
        Me.LV_tab.TabIndex = 172
        Me.LV_tab.UseCompatibleStateImageBehavior = False
        Me.LV_tab.View = System.Windows.Forms.View.Details
        '
        'COL_ks
        '
        Me.COL_ks.Text = "ks"
        Me.COL_ks.Width = 25
        '
        'COL_nazev
        '
        Me.COL_nazev.Text = "název"
        Me.COL_nazev.Width = 41
        '
        'COL_polot
        '
        Me.COL_polot.Text = "polotovar"
        Me.COL_polot.Width = 56
        '
        'COL_rozm
        '
        Me.COL_rozm.Text = "čistý rozměr"
        Me.COL_rozm.Width = 67
        '
        'COL_nor
        '
        Me.COL_nor.Text = "norma - obj. číslo"
        Me.COL_nor.Width = 93
        '
        'COL_mat
        '
        Me.COL_mat.Text = "materiál"
        Me.COL_mat.Width = 48
        '
        'COL_dod
        '
        Me.COL_dod.Text = "dodavatel"
        Me.COL_dod.Width = 59
        '
        'COL_poz
        '
        Me.COL_poz.Text = "poz."
        Me.COL_poz.Width = 32
        '
        'TB_hmotnost
        '
        Me.TB_hmotnost.Location = New System.Drawing.Point(102, 700)
        Me.TB_hmotnost.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_hmotnost.Name = "TB_hmotnost"
        Me.TB_hmotnost.ReadOnly = True
        Me.TB_hmotnost.Size = New System.Drawing.Size(57, 20)
        Me.TB_hmotnost.TabIndex = 174
        '
        'L_kg
        '
        Me.L_kg.AutoSize = True
        Me.L_kg.Location = New System.Drawing.Point(160, 702)
        Me.L_kg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_kg.Name = "L_kg"
        Me.L_kg.Size = New System.Drawing.Size(19, 13)
        Me.L_kg.TabIndex = 175
        Me.L_kg.Text = "kg"
        '
        'L_hmotnost
        '
        Me.L_hmotnost.Location = New System.Drawing.Point(100, 682)
        Me.L_hmotnost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_hmotnost.Name = "L_hmotnost"
        Me.L_hmotnost.Size = New System.Drawing.Size(54, 14)
        Me.L_hmotnost.TabIndex = 176
        Me.L_hmotnost.Text = "Hmotnost"
        '
        'TP_vlastnosti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.L_hmotnost)
        Me.Controls.Add(Me.L_kg)
        Me.Controls.Add(Me.TB_hmotnost)
        Me.Controls.Add(Me.RB_tab)
        Me.Controls.Add(Me.TB_rozm2)
        Me.Controls.Add(Me.B_kota)
        Me.Controls.Add(Me.B_obnovit)
        Me.Controls.Add(Me.B_ulozit)
        Me.Controls.Add(Me.CB_presnost)
        Me.Controls.Add(Me.TB_stary)
        Me.Controls.Add(Me.L_stary)
        Me.Controls.Add(Me.L_presnost)
        Me.Controls.Add(Me.CB_pozn6)
        Me.Controls.Add(Me.CB_pozn5)
        Me.Controls.Add(Me.CB_pozn4)
        Me.Controls.Add(Me.CB_pozn3)
        Me.Controls.Add(Me.CB_pozn2)
        Me.Controls.Add(Me.L_poznamky)
        Me.Controls.Add(Me.CB_pozn1)
        Me.Controls.Add(Me.RB_vl)
        Me.Controls.Add(Me.RB_zdb)
        Me.Controls.Add(Me.TB_nazev)
        Me.Controls.Add(Me.L_nazev)
        Me.Controls.Add(Me.TB_rozm)
        Me.Controls.Add(Me.L_rozm)
        Me.Controls.Add(Me.L_dod)
        Me.Controls.Add(Me.TB_dod)
        Me.Controls.Add(Me.TB_nor)
        Me.Controls.Add(Me.TB_mat)
        Me.Controls.Add(Me.L_polot)
        Me.Controls.Add(Me.L_nor)
        Me.Controls.Add(Me.L_mat)
        Me.Controls.Add(Me.L_typpol)
        Me.Controls.Add(Me.CB_polot)
        Me.Controls.Add(Me.CB_typpol)
        Me.Controls.Add(Me.LV_tab)
        Me.MinimumSize = New System.Drawing.Size(280, 0)
        Me.Name = "TP_vlastnosti"
        Me.Size = New System.Drawing.Size(430, 797)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_kota As System.Windows.Forms.Button
    Friend WithEvents B_obnovit As System.Windows.Forms.Button
    Friend WithEvents B_ulozit As System.Windows.Forms.Button
    Friend WithEvents CB_presnost As System.Windows.Forms.ComboBox
    Friend WithEvents TB_stary As System.Windows.Forms.TextBox
    Friend WithEvents L_stary As System.Windows.Forms.Label
    Friend WithEvents L_presnost As System.Windows.Forms.Label
    Friend WithEvents CB_pozn6 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_pozn5 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_pozn4 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_pozn3 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_pozn2 As System.Windows.Forms.ComboBox
    Friend WithEvents L_poznamky As System.Windows.Forms.Label
    Friend WithEvents CB_pozn1 As System.Windows.Forms.ComboBox
    Friend WithEvents RB_vl As System.Windows.Forms.RadioButton
    Friend WithEvents RB_zdb As System.Windows.Forms.RadioButton
    Friend WithEvents TB_nazev As System.Windows.Forms.TextBox
    Friend WithEvents L_nazev As System.Windows.Forms.Label
    Friend WithEvents TB_rozm As System.Windows.Forms.TextBox
    Friend WithEvents L_rozm As System.Windows.Forms.Label
    Friend WithEvents L_dod As System.Windows.Forms.Label
    Friend WithEvents TB_dod As System.Windows.Forms.TextBox
    Friend WithEvents TB_nor As System.Windows.Forms.TextBox
    Friend WithEvents TB_mat As System.Windows.Forms.TextBox
    Friend WithEvents L_polot As System.Windows.Forms.Label
    Friend WithEvents L_nor As System.Windows.Forms.Label
    Friend WithEvents L_mat As System.Windows.Forms.Label
    Friend WithEvents L_typpol As System.Windows.Forms.Label
    Friend WithEvents CB_polot As System.Windows.Forms.ComboBox
    Friend WithEvents CB_typpol As System.Windows.Forms.ComboBox
    Friend WithEvents TB_rozm2 As System.Windows.Forms.TextBox
    Friend WithEvents RB_tab As Windows.Forms.RadioButton
    Friend WithEvents LV_tab As Windows.Forms.ListView
    Friend WithEvents COL_ks As Windows.Forms.ColumnHeader
    Friend WithEvents COL_nazev As Windows.Forms.ColumnHeader
    Friend WithEvents COL_polot As Windows.Forms.ColumnHeader
    Friend WithEvents COL_rozm As Windows.Forms.ColumnHeader
    Friend WithEvents COL_nor As Windows.Forms.ColumnHeader
    Friend WithEvents COL_mat As Windows.Forms.ColumnHeader
    Friend WithEvents COL_dod As Windows.Forms.ColumnHeader
    Friend WithEvents COL_poz As Windows.Forms.ColumnHeader
    Friend WithEvents TB_hmotnost As Windows.Forms.TextBox
    Friend WithEvents L_kg As Windows.Forms.Label
    Friend WithEvents L_hmotnost As Windows.Forms.Label
End Class
