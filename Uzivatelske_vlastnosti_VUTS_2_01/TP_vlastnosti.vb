Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports SolidWorks.Interop.swdocumentmgr


<ComVisible(True)>
<ProgId("Uzivatelske_vlastnosti_VUTS_2_01")>
Public Class TP_vlastnosti

    Enum EDocType
        NoActive = 0
        Part = 1
        Assembly = 2
        Drawing = 3
    End Enum

    Dim swApp As SldWorks
    Dim swModel As ModelDoc2
    Dim DocType As EDocType
    Dim cestaMat As String
    Dim cestaPozn As String
    Dim CutList_atr As String
    Dim ActiveDocChangeHandler As New DSldWorksEvents_ActiveDocChangeNotifyEventHandler(AddressOf SldWorks_ActiveDocChange)
    Dim DestroyPartHandler As New DPartDocEvents_DestroyNotify2EventHandler(AddressOf SldWorks_DestroyModel)
    Dim RegenPartHandler As New DPartDocEvents_RegenPostNotify2EventHandler(AddressOf SldWorks_RegenModel)
    Dim SavePartHandler As New DPartDocEvents_FileSaveNotifyEventHandler(AddressOf SldWorks_SaveModel)
    Dim SaveAsPartHandler As New DPartDocEvents_FileSaveAsNotifyEventHandler(AddressOf SldWorks_SaveModel)
    Dim CutListUpdateHandler As New DPartDocEvents_WeldmentCutListUpdatePostNotifyEventHandler(AddressOf SldWorks_CutListUpdate)
    Dim DestroyAsmHandler As New DAssemblyDocEvents_DestroyNotify2EventHandler(AddressOf SldWorks_DestroyModel)
    Dim RegenAsmHandler As New DAssemblyDocEvents_RegenPostNotify2EventHandler(AddressOf SldWorks_RegenModel)
    Dim SaveAsmHandler As New DAssemblyDocEvents_FileSaveNotifyEventHandler(AddressOf SldWorks_SaveModel)
    Dim SaveAsAsmHandler As New DAssemblyDocEvents_FileSaveAsNotifyEventHandler(AddressOf SldWorks_SaveModel)

    Friend Sub getSwApp(ByRef swAppIn As SldWorks)

        swApp = swAppIn

        Try
            AddHandler swApp.ActiveDocChangeNotify, ActiveDocChangeHandler
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try

        LoadCBItems()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ClearValues()
        SetDefaultSettings()
    End Sub

    Private Sub LoadCBItems()
        Dim cestaGet As String
        Dim cesta As String

        cestaGet = swApp.GetUserPreferenceStringValue(swUserPreferenceStringValue_e.swFileLocationsCustomPropertyFile)
        cesta = cestaGet.Replace("\", "/")
        cestaMat = cesta & "/Mat_karty"
        cestaPozn = cesta & "/poznamky.txt"

        Dim a As Integer = cestaMat.Length
        Dim cestaMatInfo As New IO.DirectoryInfo(cestaMat)
        If cestaMatInfo.Exists Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(cestaMat)
                Dim b As Integer = foundFile.Length
                Dim listitem As String = foundFile.Substring(a + 1, b - a - 5)
                CB_typpol.Items.Add(listitem)
            Next
        End If

        Dim cestaPoznInfo As New IO.FileInfo(cestaPozn)

        If cestaPoznInfo.Exists Then

            Dim soub1 As New IO.StreamReader(cestaPozn)
            While Not soub1.EndOfStream
                Dim pozn1_read As String = soub1.ReadLine()
                CB_pozn1.Items.Add("1. " & pozn1_read)
            End While
            soub1.Close()

            Dim soub2 As New IO.StreamReader(cestaPozn)
            While Not soub2.EndOfStream
                Dim pozn2_read As String = soub2.ReadLine()
                CB_pozn2.Items.Add("2. " & pozn2_read)
            End While
            soub2.Close()

            Dim soub3 As New IO.StreamReader(cestaPozn)
            While Not soub3.EndOfStream
                Dim pozn3_read As String = soub3.ReadLine()
                CB_pozn3.Items.Add("3. " & pozn3_read)
            End While
            soub3.Close()

            Dim soub4 As New IO.StreamReader(cestaPozn)
            While Not soub4.EndOfStream
                Dim pozn4_read As String = soub4.ReadLine()
                CB_pozn4.Items.Add("4. " & pozn4_read)
            End While
            soub4.Close()

            Dim soub5 As New IO.StreamReader(cestaPozn)
            While Not soub5.EndOfStream
                Dim pozn5_read As String = soub5.ReadLine()
                CB_pozn5.Items.Add("5. " & pozn5_read)
            End While
            soub5.Close()

            Dim soub6 As New IO.StreamReader(cestaPozn)
            While Not soub6.EndOfStream
                Dim pozn6_read As String = soub6.ReadLine()
                CB_pozn6.Items.Add("6. " & pozn6_read)
            End While
            soub6.Close()

        End If
    End Sub

    Private Function SldWorks_ActiveDocChange() As Integer
        swModel = swApp.ActiveDoc
        DocType = swModel.GetType

        Select Case DocType
            Case 1
                Dim swPartDoc As PartDoc = CType(swModel, PartDoc) ' Convert swModel to part model type
                Try

                    RemoveHandler swPartDoc.DestroyNotify2, DestroyPartHandler
                    RemoveHandler swPartDoc.RegenPostNotify2, RegenPartHandler
                    RemoveHandler swPartDoc.FileSaveNotify, SavePartHandler
                    RemoveHandler swPartDoc.FileSaveAsNotify, SaveAsPartHandler
                    RemoveHandler swPartDoc.WeldmentCutListUpdatePostNotify, CutListUpdateHandler

                    AddHandler swPartDoc.DestroyNotify2, DestroyPartHandler
                    AddHandler swPartDoc.RegenPostNotify2, RegenPartHandler
                    AddHandler swPartDoc.FileSaveNotify, SavePartHandler
                    AddHandler swPartDoc.FileSaveAsNotify, SaveAsPartHandler
                    AddHandler swPartDoc.WeldmentCutListUpdatePostNotify, CutListUpdateHandler
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            Case 2
                Dim swAsmDoc As AssemblyDoc = CType(swModel, AssemblyDoc) ' Convert swModel to assembly model type
                Try

                    RemoveHandler swAsmDoc.DestroyNotify2, DestroyAsmHandler
                    RemoveHandler swAsmDoc.RegenPostNotify2, RegenAsmHandler
                    RemoveHandler swAsmDoc.FileSaveNotify, SaveAsmHandler
                    RemoveHandler swAsmDoc.FileSaveAsNotify, SaveAsAsmHandler

                    AddHandler swAsmDoc.DestroyNotify2, DestroyAsmHandler
                    AddHandler swAsmDoc.RegenPostNotify2, RegenAsmHandler
                    AddHandler swAsmDoc.FileSaveNotify, SaveAsmHandler
                    AddHandler swAsmDoc.FileSaveAsNotify, SaveAsAsmHandler
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            Case 3

        End Select

        RefreshTP()

        If CB_polot.Text = "TABULKA PŘÍŘEZŮ" Then
            LoadCutlist()
        End If

    End Function

    Private Function SldWorks_DestroyModel() As Integer
        If swApp.GetDocumentCount() = 1 Then
            ClearValues()
            SetDefaultSettings()
        End If

        Select Case DocType
            Case 1
                Dim swPartDoc As PartDoc = CType(swModel, PartDoc) ' Convert swModel to part model type
                Try
                    RemoveHandler swPartDoc.DestroyNotify2, DestroyPartHandler
                    RemoveHandler swPartDoc.RegenPostNotify2, RegenPartHandler
                    RemoveHandler swPartDoc.FileSaveNotify, SavePartHandler
                    RemoveHandler swPartDoc.FileSaveAsNotify, SaveAsPartHandler
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            Case 2
                Dim swAsmDoc As AssemblyDoc = CType(swModel, AssemblyDoc) ' Convert swModel to assembly model type
                Try
                    RemoveHandler swAsmDoc.DestroyNotify2, DestroyAsmHandler
                    RemoveHandler swAsmDoc.RegenPostNotify2, RegenAsmHandler
                    RemoveHandler swAsmDoc.FileSaveNotify, SaveAsmHandler
                    RemoveHandler swAsmDoc.FileSaveAsNotify, SaveAsAsmHandler
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            Case 3

        End Select

    End Function

    Private Function SldWorks_RegenModel() As Integer
        MsgBox("regen")
        'RefreshTP()
    End Function

    Private Function SldWorks_SaveModel() As Integer
        RefreshTP()
    End Function

    Private Function SldWorks_CutListUpdate() As Integer
        MsgBox("cutlistupdate")
        'LoadCutlist()
    End Function

    Private Sub RefreshTP()
        Select Case DocType
            Case 1
                LoadValues()

            Case 2
                LoadValues()

            Case 3
                ClearValues()
                SetDefaultSettings()
        End Select
    End Sub

    Private Sub SetDefaultSettings()

        RB_zdb.Visible = True
        RB_zdb.Enabled = False
        RB_zdb.Checked = False

        RB_vl.Visible = True
        RB_vl.Enabled = False
        RB_vl.Checked = False

        RB_tab.Visible = True
        RB_tab.Enabled = False
        RB_tab.Checked = False

        L_typpol.Visible = True
        L_typpol.Enabled = False

        CB_typpol.Visible = True
        CB_typpol.Enabled = False
        CB_typpol.DropDownStyle = ComboBoxStyle.Simple
        CB_typpol.DroppedDown = False

        L_mat.Visible = True
        L_mat.Enabled = False

        TB_mat.Visible = True
        TB_mat.Enabled = False

        L_nor.Visible = True
        L_nor.Enabled = False

        TB_nor.Visible = True
        TB_nor.Enabled = False

        L_dod.Visible = True
        L_dod.Enabled = False

        TB_dod.Visible = True
        TB_dod.Enabled = False

        L_polot.Visible = True
        L_polot.Enabled = False

        CB_polot.Visible = True
        CB_polot.Enabled = False
        CB_polot.DropDownStyle = ComboBoxStyle.Simple
        CB_polot.Items.Clear()

        L_rozm.Visible = True
        L_rozm.Enabled = False

        TB_rozm.Visible = True
        TB_rozm.Enabled = False

        B_kota.Visible = True
        B_kota.Enabled = False

        TB_rozm2.Visible = True
        TB_rozm2.Enabled = False

        LV_tab.Visible = False
        LV_tab.BackColor = Drawing.Color.WhiteSmoke
        LV_tab.Items.Clear()

        L_nazev.Enabled = False

        TB_nazev.Enabled = False

        L_poznamky.Enabled = False

        CB_pozn1.Enabled = False

        CB_pozn2.Enabled = False

        CB_pozn3.Enabled = False

        CB_pozn4.Enabled = False

        CB_pozn5.Enabled = False

        CB_pozn6.Enabled = False

        CB_presnost.Enabled = False

        TB_stary.Enabled = False

        B_obnovit.Enabled = False

        B_ulozit.Enabled = False

    End Sub

    Private Sub SetPartTabSetings()

        RB_zdb.Visible = True
        RB_zdb.Enabled = True
        RB_zdb.Checked = False

        RB_vl.Visible = True
        RB_vl.Enabled = True
        RB_vl.Checked = False

        RB_tab.Visible = True
        RB_tab.Enabled = True
        RB_tab.Checked = False

        L_typpol.Visible = False
        L_typpol.Enabled = False

        CB_typpol.Visible = False
        CB_typpol.Enabled = False
        CB_typpol.DropDownStyle = ComboBoxStyle.Simple

        L_mat.Visible = False
        L_mat.Enabled = False

        TB_mat.Visible = False
        TB_mat.Enabled = False

        L_nor.Visible = False
        L_nor.Enabled = False

        TB_nor.Visible = False
        TB_nor.Enabled = False

        L_dod.Visible = False
        L_dod.Enabled = False

        TB_dod.Visible = False
        TB_dod.Enabled = False

        L_polot.Visible = False
        L_polot.Enabled = False

        CB_polot.Visible = False
        CB_polot.Enabled = False
        CB_polot.DropDownStyle = ComboBoxStyle.Simple
        CB_polot.Items.Clear()

        L_rozm.Visible = False
        L_rozm.Enabled = False

        TB_rozm.Visible = False
        TB_rozm.Enabled = False

        B_kota.Visible = False
        B_kota.Enabled = False

        TB_rozm2.Visible = False
        TB_rozm2.Enabled = False

        LV_tab.Visible = True
        LV_tab.BackColor = Drawing.Color.WhiteSmoke

        L_nazev.Enabled = True

        TB_nazev.Enabled = True

        L_poznamky.Enabled = True

        CB_pozn1.Enabled = True

        CB_pozn2.Enabled = True

        CB_pozn3.Enabled = True

        CB_pozn4.Enabled = True

        CB_pozn5.Enabled = True

        CB_pozn6.Enabled = True

        CB_presnost.Enabled = True

        TB_stary.Enabled = True

        B_obnovit.Enabled = False

        B_ulozit.Enabled = False

    End Sub

    Private Sub SetPartWOTabSettings()

        RB_zdb.Visible = True
        RB_zdb.Enabled = True
        RB_zdb.Checked = False

        RB_vl.Visible = True
        RB_vl.Enabled = True
        RB_vl.Checked = False

        RB_tab.Visible = True
        RB_tab.Enabled = True
        RB_tab.Checked = False

        L_typpol.Visible = True
        L_typpol.Enabled = False

        CB_typpol.Visible = True
        CB_typpol.Enabled = False
        CB_typpol.DropDownStyle = ComboBoxStyle.Simple
        CB_typpol.Text = ""
        CB_typpol.DroppedDown = False

        L_mat.Visible = True
        L_mat.Enabled = False

        TB_mat.Visible = True
        TB_mat.Enabled = False

        L_nor.Visible = True
        L_nor.Enabled = False

        TB_nor.Visible = True
        TB_nor.Enabled = False

        L_dod.Visible = True
        L_dod.Enabled = False

        TB_dod.Visible = True
        TB_dod.Enabled = False

        L_polot.Visible = True
        L_polot.Enabled = False

        CB_polot.Visible = True
        CB_polot.Enabled = False
        CB_polot.DropDownStyle = ComboBoxStyle.Simple
        CB_polot.Items.Clear()

        L_rozm.Visible = True
        L_rozm.Enabled = False

        TB_rozm.Visible = True
        TB_rozm.Enabled = False

        B_kota.Visible = True
        B_kota.Enabled = False

        TB_rozm2.Visible = True
        TB_rozm2.Enabled = False

        LV_tab.Visible = False
        LV_tab.BackColor = Drawing.Color.WhiteSmoke
        LV_tab.Items.Clear()

        L_nazev.Enabled = True

        TB_nazev.Enabled = True

        L_poznamky.Enabled = True

        CB_pozn1.Enabled = True

        CB_pozn2.Enabled = True

        CB_pozn3.Enabled = True

        CB_pozn4.Enabled = True

        CB_pozn5.Enabled = True

        CB_pozn6.Enabled = True

        CB_presnost.Enabled = True

        TB_stary.Enabled = True

        B_obnovit.Enabled = False

        B_ulozit.Enabled = False

    End Sub

    Private Sub SetAssemblySettings()

        RB_zdb.Visible = True
        RB_zdb.Enabled = False
        RB_zdb.Checked = False

        RB_vl.Visible = True
        RB_vl.Enabled = False
        RB_vl.Checked = False

        RB_tab.Visible = True
        RB_tab.Enabled = False
        RB_tab.Checked = False

        L_typpol.Visible = True
        L_typpol.Enabled = False

        CB_typpol.Visible = True
        CB_typpol.Enabled = False
        CB_typpol.DropDownStyle = ComboBoxStyle.Simple
        CB_typpol.DroppedDown = False

        L_mat.Visible = True
        L_mat.Enabled = True

        TB_mat.Visible = True
        TB_mat.Enabled = True

        L_nor.Visible = True
        L_nor.Enabled = True

        TB_nor.Visible = True
        TB_nor.Enabled = True

        L_dod.Visible = True
        L_dod.Enabled = True

        TB_dod.Visible = True
        TB_dod.Enabled = True

        L_polot.Visible = True
        L_polot.Enabled = True

        CB_polot.Visible = True
        CB_polot.Enabled = True
        CB_polot.DropDownStyle = ComboBoxStyle.Simple
        CB_polot.Items.Clear()

        L_rozm.Visible = True
        L_rozm.Enabled = False

        TB_rozm.Visible = True
        TB_rozm.Enabled = False

        B_kota.Visible = True
        B_kota.Enabled = False

        TB_rozm2.Visible = True
        TB_rozm2.Enabled = False

        LV_tab.Visible = False
        LV_tab.BackColor = Drawing.Color.WhiteSmoke
        LV_tab.Items.Clear()

        L_nazev.Enabled = True

        TB_nazev.Enabled = True

        L_poznamky.Enabled = True

        CB_pozn1.Enabled = True

        CB_pozn2.Enabled = True

        CB_pozn3.Enabled = True

        CB_pozn4.Enabled = True

        CB_pozn5.Enabled = True

        CB_pozn6.Enabled = True

        CB_presnost.Enabled = True

        TB_stary.Enabled = True

        B_obnovit.Enabled = False

        B_ulozit.Enabled = False

        TB_mat.ReadOnly = False
        TB_nor.ReadOnly = False
        TB_dod.ReadOnly = False

    End Sub

    Private Sub LoadValues()

        Dim swModelDocExt As ModelDocExtension
        Dim swCustProp As CustomPropertyManager
        Dim val As String = ""
        Dim valout As String = ""
        Dim bool As Boolean

        swModelDocExt = swModel.Extension
        swCustProp = swModelDocExt.CustomPropertyManager("")

        CB_typpol.Text = ""
        CB_typpol.DropDownStyle = ComboBoxStyle.Simple
        CB_polot.DropDownStyle = ComboBoxStyle.Simple

        bool = swCustProp.Get4("Materiál", False, val, valout) : TB_mat.Text = val
        bool = swCustProp.Get4("Norma - obj. číslo", False, val, valout) : TB_nor.Text = val
        bool = swCustProp.Get4("Dodavatel", False, val, valout) : TB_dod.Text = val
        bool = swCustProp.Get4("Polotovar", False, val, valout) : CB_polot.Text = val
        bool = swCustProp.Get4("Čistý rozměr", False, val, valout) : TB_rozm.Text = val
        bool = swCustProp.Get4("Čistý rozměr", False, val, valout) : TB_rozm2.Text = valout
        bool = swCustProp.Get4("Název", False, val, valout) : TB_nazev.Text = val
        bool = swCustProp.Get4("Poznámka 1.", False, val, valout) : CB_pozn1.Text = val
        bool = swCustProp.Get4("Poznámka 2.", False, val, valout) : CB_pozn2.Text = val
        bool = swCustProp.Get4("Poznámka 3.", False, val, valout) : CB_pozn3.Text = val
        bool = swCustProp.Get4("Poznámka 4.", False, val, valout) : CB_pozn4.Text = val
        bool = swCustProp.Get4("Poznámka 5.", False, val, valout) : CB_pozn5.Text = val
        bool = swCustProp.Get4("Poznámka 6.", False, val, valout) : CB_pozn6.Text = val
        bool = swCustProp.Get4("Přesnost", False, val, valout) : CB_presnost.Text = val
        bool = swCustProp.Get4("Starý výkres", False, val, valout) : TB_stary.Text = val

        Select Case DocType
            Case 1
                If CB_polot.Text = "TABULKA PŘÍŘEZŮ" Then
                    SetPartTabSetings()

                Else
                    SetPartWOTabSettings()
                End If

            Case 2
                SetAssemblySettings()
            Case 3
                SetDefaultSettings()
        End Select

    End Sub

    Private Sub ClearValues()
        CB_typpol.Text = ""
        TB_mat.Text = ""
        TB_nor.Text = ""
        TB_dod.Text = ""
        CB_polot.Text = ""
        CB_polot.Items.Clear()
        TB_rozm.Text = ""
        TB_rozm2.Text = ""
        TB_nazev.Text = ""
        CB_pozn1.Text = ""
        CB_pozn2.Text = ""
        CB_pozn3.Text = ""
        CB_pozn4.Text = ""
        CB_pozn5.Text = ""
        CB_pozn6.Text = ""
        CB_presnost.Text = ""
        TB_stary.Text = ""
        CutList_atr = ""
        LV_tab.Items.Clear()
    End Sub

    Private Sub SaveValues()

        Dim swModelDocExt As ModelDocExtension
        Dim swCustProp As CustomPropertyManager

        swModelDocExt = swModel.Extension
        swCustProp = swModelDocExt.CustomPropertyManager("")

        swCustProp.Add3("Materiál", 30, TB_mat.Text, 1)
        swCustProp.Add3("Norma - obj. číslo", 30, TB_nor.Text, 1)
        swCustProp.Add3("Dodavatel", 30, TB_dod.Text, 1)
        swCustProp.Add3("Polotovar", 30, CB_polot.Text, 1)
        swCustProp.Add3("Čistý rozměr", 30, TB_rozm.Text, 1)
        swCustProp.Add3("Název", 30, TB_nazev.Text, 1)
        swCustProp.Add3("Poznámka 1.", 30, CB_pozn1.Text, 1)
        swCustProp.Add3("Poznámka 2.", 30, CB_pozn2.Text, 1)
        swCustProp.Add3("Poznámka 3.", 30, CB_pozn3.Text, 1)
        swCustProp.Add3("Poznámka 4.", 30, CB_pozn4.Text, 1)
        swCustProp.Add3("Poznámka 5.", 30, CB_pozn5.Text, 1)
        swCustProp.Add3("Poznámka 6.", 30, CB_pozn6.Text, 1)
        swCustProp.Add3("Přesnost", 30, CB_presnost.Text, 1)
        swCustProp.Add3("Starý výkres", 30, TB_stary.Text, 1)
        swCustProp.Add3("Tabulka_prirezu", 30, CutList_atr, 1)

        CB_typpol.DropDownStyle = ComboBoxStyle.Simple
        CB_typpol.Text = ""

    End Sub

    Private Sub LoadCutlist()

        Dim swModelDocExt As ModelDocExtension
        Dim swCustProp As CustomPropertyManager
        Dim swFeature As Feature
        Dim poz As Integer
        swModelDocExt = swModel.Extension
        swCustProp = swModelDocExt.CustomPropertyManager("")
        swFeature = swModel.FirstFeature

        CutList_atr = ""
        LV_tab.Items.Clear()
        poz = 0

        Do While Not swFeature Is Nothing
            If swFeature.GetTypeName = "CutListFolder" Then

                Dim CustomPropMgr As CustomPropertyManager = swFeature.CustomPropertyManager
                Dim CustomPropVal As String = ""
                Dim CustomPropResolvedVal As String = ""

                CustomPropMgr.Get2("LENGTH", CustomPropVal, CustomPropResolvedVal)
                If Not CustomPropResolvedVal.Contains("@") Then

                    poz = poz + 1

                    CustomPropMgr.Get2("QUANTITY", CustomPropVal, CustomPropResolvedVal)
                    Dim p1 As String = CStr(CustomPropResolvedVal)

                    CustomPropMgr.Get2("Název", CustomPropVal, CustomPropResolvedVal)
                    Dim p2 As String = CustomPropResolvedVal

                    CustomPropMgr.Get2("Polotovar", CustomPropVal, CustomPropResolvedVal)
                    Dim p3 As String = CustomPropResolvedVal

                    CustomPropMgr.Get2("LENGTH", CustomPropVal, CustomPropResolvedVal)
                    Dim p4 As String = CStr(CustomPropResolvedVal)

                    CustomPropMgr.Get2("Norma - obj. číslo", CustomPropVal, CustomPropResolvedVal)
                    Dim p5 As String = CustomPropResolvedVal

                    CustomPropMgr.Get2("Materiál", CustomPropVal, CustomPropResolvedVal)
                    Dim p6 As String = CustomPropResolvedVal

                    CustomPropMgr.Get2("Dodavatel", CustomPropVal, CustomPropResolvedVal)
                    Dim p7 As String = CustomPropResolvedVal

                    Dim p8 As String = CStr(poz)

                    Dim polozka As New ListViewItem

                    polozka.Text = p1
                    polozka.SubItems.Add(p2)
                    polozka.SubItems.Add(p3)
                    polozka.SubItems.Add(p4)
                    polozka.SubItems.Add(p5)
                    polozka.SubItems.Add(p6)
                    polozka.SubItems.Add(p7)
                    polozka.SubItems.Add(p8)
                    LV_tab.Items.Add(polozka)

                    For m As Integer = 0 To LV_tab.Columns.Count - 1 'For each column
                        Dim a As Integer = 0
                        Dim b As Integer = 0
                        LV_tab.Columns(m).Width = -1
                        a = LV_tab.Columns(m).Width
                        LV_tab.Columns(m).Width = -2
                        b = LV_tab.Columns(m).Width
                        If a > b Then
                            LV_tab.Columns(m).Width = -1
                        Else
                            LV_tab.Columns(m).Width = -2
                        End If
                    Next m
                    LV_tab.EndUpdate()

                    CutList_atr = CutList_atr & p1 & "|" & p2 & "|" & p3 & "|" & p4 & "|" & p5 & "|" & p6 & "|" & p7 & "|" & p8 & ";"

                End If

            End If
            swFeature = swFeature.GetNextFeature
        Loop

        If poz = 0 Then
            MsgBox("Díl nemá tabulku přířezů")
            swCustProp.Add3("Polotovar", 30, "", 1)
            RefreshTP()

        End If

        swCustProp.Add3("Tabulka_prirezu", 30, CutList_atr, 1)

    End Sub

    Private Sub RB_zdb_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RB_zdb.CheckedChanged
        If RB_zdb.Checked = True Then

            CB_typpol.DropDownStyle = ComboBoxStyle.DropDown
            CB_polot.DropDownStyle = ComboBoxStyle.DropDownList

            CB_typpol.Text = ""
            TB_mat.Text = ""
            TB_nor.Text = ""
            TB_dod.Text = ""
            CB_polot.Text = ""
            CutList_atr = ""

            L_typpol.Visible = True
            CB_typpol.Visible = True
            L_mat.Visible = True
            TB_mat.Visible = True
            L_nor.Visible = True
            TB_nor.Visible = True
            L_dod.Visible = True
            TB_dod.Visible = True
            L_polot.Visible = True
            CB_polot.Visible = True
            L_rozm.Visible = True
            TB_rozm.Visible = True
            B_kota.Visible = True
            TB_rozm2.Visible = True
            LV_tab.Visible = False

            L_typpol.Enabled = True
            CB_typpol.Enabled = True
            L_mat.Enabled = True
            TB_mat.Enabled = True
            L_nor.Enabled = True
            TB_nor.Enabled = True
            L_dod.Enabled = True
            TB_dod.Enabled = True
            L_polot.Enabled = True
            CB_polot.Enabled = True
            L_rozm.Enabled = True
            TB_rozm.Enabled = True
            B_kota.Enabled = True
            B_ulozit.Enabled = True
            B_obnovit.Enabled = True

            TB_mat.ReadOnly = True
            TB_nor.ReadOnly = True
            TB_dod.ReadOnly = True

        End If
    End Sub

    Private Sub RB_vl_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RB_vl.CheckedChanged
        If RB_vl.Checked = True Then

            CB_typpol.DropDownStyle = ComboBoxStyle.Simple
            CB_polot.DropDownStyle = ComboBoxStyle.Simple

            CB_typpol.Text = ""
            CutList_atr = ""
            If CB_polot.Text = "TABULKA PŘÍŘEZŮ" Then
                CB_polot.Text = ""
            End If

            CB_polot.Items.Clear()

            L_typpol.Visible = True
            CB_typpol.Visible = True
            L_mat.Visible = True
            TB_mat.Visible = True
            L_nor.Visible = True
            TB_nor.Visible = True
            L_dod.Visible = True
            TB_dod.Visible = True
            L_polot.Visible = True
            CB_polot.Visible = True
            L_rozm.Visible = True
            TB_rozm.Visible = True
            B_kota.Visible = True
            TB_rozm2.Visible = True
            LV_tab.Visible = False

            L_typpol.Enabled = False
            CB_typpol.Enabled = False
            L_mat.Enabled = True
            TB_mat.Enabled = True
            L_nor.Enabled = True
            TB_nor.Enabled = True
            L_dod.Enabled = True
            TB_dod.Enabled = True
            L_polot.Enabled = True
            CB_polot.Enabled = True
            L_rozm.Enabled = True
            TB_rozm.Enabled = True
            B_kota.Enabled = True
            B_ulozit.Enabled = True
            B_obnovit.Enabled = True

            TB_mat.ReadOnly = False
            TB_nor.ReadOnly = False
            TB_dod.ReadOnly = False

        End If
    End Sub

    Private Sub RB_tab_CheckedChanged(sender As Object, e As EventArgs) Handles RB_tab.CheckedChanged
        If RB_tab.Checked = True Then

            CB_typpol.Text = ""
            TB_mat.Text = ""
            TB_nor.Text = ""
            TB_dod.Text = ""
            CB_polot.Text = "TABULKA PŘÍŘEZŮ"
            TB_rozm.Text = ""
            TB_rozm2.Text = ""
            CB_polot.Items.Clear()

            L_typpol.Visible = False
            CB_typpol.Visible = False
            L_mat.Visible = False
            TB_mat.Visible = False
            L_nor.Visible = False
            TB_nor.Visible = False
            L_dod.Visible = False
            TB_dod.Visible = False
            L_polot.Visible = False
            CB_polot.Visible = False
            L_rozm.Visible = False
            TB_rozm.Visible = False
            B_kota.Visible = False
            TB_rozm2.Visible = False
            LV_tab.Visible = True
            LV_tab.BackColor = Drawing.Color.White

            B_ulozit.Enabled = True
            B_obnovit.Enabled = True

            LoadCutlist()
        End If

    End Sub

    Private Sub CB_typpol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_typpol.SelectedIndexChanged
        If Not CB_typpol.SelectedIndex = -1 Then
            CB_polot.Items.Clear()
            Dim cestasoub As String = cestaMat & "/" & CB_typpol.Text & ".txt"
            Dim soub As New IO.StreamReader(cestasoub)
            TB_mat.Text = soub.ReadLine()
            TB_nor.Text = soub.ReadLine()
            TB_dod.Text = soub.ReadLine()
            While Not soub.EndOfStream
                CB_polot.Items.Add(soub.ReadLine())
            End While
            soub.Close()
        End If
    End Sub

    Private Sub TB_mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_mat.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub TB_nor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_nor.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub TB_rozm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_rozm.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_polot_TextChanged(sender As Object, e As EventArgs) Handles CB_polot.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub TB_dod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_dod.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub TB_nazev_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_nazev.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_pozn1.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_pozn1.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_pozn2.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_pozn2.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_pozn3.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_pozn3.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_pozn4.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_pozn4.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_pozn5.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_pozn5.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_pozn6.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_pozn6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_pozn6.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_presnost_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_presnost.SelectedIndexChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub CB_presnost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_presnost.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub TB_stary_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_stary.TextChanged
        B_ulozit.Enabled = True
        B_obnovit.Enabled = True
    End Sub

    Private Sub B_kota_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_kota.Click

        Dim AktivDoc As String
        Dim swSelMgr As SelectionMgr
        Dim selected As DisplayDimension
        Dim selType As Integer
        Dim SelDimName As String

        AktivDoc = swModel.GetTitle
        swSelMgr = swModel.SelectionManager
        selType = swSelMgr.GetSelectedObjectType3(1, 0)

        If selType = 14 Then
            selected = swSelMgr.GetSelectedObject6(1, 0)
            SelDimName = selected.GetNameForSelection
            TB_rozm.Text = TB_rozm.Text & Chr(34) & SelDimName & "@" & AktivDoc & ".SLDPRT" & Chr(34)
        Else
            MsgBox("Není vybrána kóta")
        End If

    End Sub

    Private Sub B_obnovit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_obnovit.Click

        RefreshTP()

    End Sub

    Private Sub B_ulozit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles B_ulozit.Click

        SaveValues()
        swModel.SetSaveFlag()
        RefreshTP()

    End Sub

End Class
