Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Imports System.Environment
Imports System.Data.OleDb
Imports System.Globalization
Imports System.Threading

Public Class frmEight

    Dim ini As New IniFile(Application.StartupPath & "\Settings.ini")
    Private Sub frmFTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tssMessage.Text = "準備OK"

    End Sub

    Delegate Sub IncrementProgressDelegate(ByVal aThreadName As String, ByVal aProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal ThreadStatus As String)
    Public Sub IncrementProgress(ByVal aThreadName As String, ByVal aProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal ThreadStatus As String)
        Select Case ThreadStatus
            Case "INC"
                aProgressBar.Increment(1)
            Case "FINISHED"

            Case Else

        End Select
    End Sub
    Private Function FormatStrData(ByVal StrData As String) As String
        StrData = Replace(StrData, """", "")
        FormatStrData = StrData
    End Function
    Private Function IsAddressUsed(ByVal CompanyName As String, ByVal NamePerson As String, ByVal EMailId As String, ByVal Telephone As String) As String
        Dim ContactsGUID As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        Query = "SELECT ContactsGUID FROM tbl_SNContacts WHERE (Company='" & CompanyName & "' AND LastName='" & NamePerson & "' AND (EMail='" & EMailId & "' OR Telephone='" & Telephone & "')) OR "
        Query = Query & "(Company='" & CompanyName & "' AND LastName='" & NamePerson & "' AND EMail='')"
        cmd.CommandText = Query
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            ContactsGUID = db_reader.Item("ContactsGUID").ToString
        Loop
        cmd = Nothing
        connUsers.Close()
        IsAddressUsed = ContactsGUID
    End Function
    Private Function GetISO(ByVal Prefecture As String)
        Dim IsoCode As String = ""
        Select Case Prefecture
            Case UCase("愛知県")
                IsoCode = "JP-23"
            Case UCase("秋田県")
                IsoCode = "JP-05"
            Case UCase("青森県")
                IsoCode = "JP-02"
            Case UCase("愛媛県")
                IsoCode = "JP-38"
            Case UCase("岐阜県")
                IsoCode = "JP-21"
            Case UCase("群馬県")
                IsoCode = "JP-10"
            Case UCase("広島県")
                IsoCode = "JP-34"
            Case UCase("北海道")
                IsoCode = "JP-01"
            Case UCase("福井県")
                IsoCode = "JP-18"
            Case UCase("福岡県")
                IsoCode = "JP-40"
            Case UCase("福島県")
                IsoCode = "JP-07"
            Case UCase("兵庫県")
                IsoCode = "JP-08"
            Case UCase("茨城県")
                IsoCode = "JP-23"
            Case UCase("石川県")
                IsoCode = "JP-17"
            Case UCase("岩手県")
                IsoCode = "JP-03"
            Case UCase("香川県")
                IsoCode = "JP-37"
            Case UCase("鹿児島県")
                IsoCode = "JP-46"
            Case UCase("神奈川県")
                IsoCode = "JP-14"
            Case UCase("高知県")
                IsoCode = "JP-39"
            Case UCase("熊本県")
                IsoCode = "JP-43"
            Case UCase("京都府")
                IsoCode = "JP-26"
            Case UCase("三重県")
                IsoCode = "JP-24"
            Case UCase("宮城県")
                IsoCode = "JP-04"
            Case UCase("宮崎県")
                IsoCode = "JP-45"
            Case UCase("長野県")
                IsoCode = "JP-20"
            Case UCase("長崎県")
                IsoCode = "JP-42"
            Case UCase("奈良県")
                IsoCode = "JP-29"
            Case UCase("新潟県")
                IsoCode = "JP-15"
            Case UCase("新潟県")
                IsoCode = "JP-15"
            Case UCase("大分県")
                IsoCode = "JP-44"
            Case UCase("岡山県")
                IsoCode = "JP-33"
            Case UCase("沖縄県")
                IsoCode = "JP-47"
            Case UCase("大阪府")
                IsoCode = "JP-27"
            Case UCase("佐賀県")
                IsoCode = "JP-41"
            Case UCase("埼玉県")
                IsoCode = "JP-11"
            Case UCase("滋賀県")
                IsoCode = "JP-25"
            Case UCase("島根県")
                IsoCode = "JP-32"
            Case UCase("静岡県")
                IsoCode = "JP-22"
            Case UCase("千葉県")
                IsoCode = "JP-12"
            Case UCase("栃木県")
                IsoCode = "JP-09"
            Case UCase("徳島県")
                IsoCode = "JP-36"
            Case UCase("東京都")
                IsoCode = "JP-13"
            Case UCase("鳥取県")
                IsoCode = "JP-31"
            Case UCase("富山県")
                IsoCode = "JP-16"
            Case UCase("和歌山県")
                IsoCode = "JP-30"
            Case UCase("山形県")
                IsoCode = "JP-06"
            Case UCase("山口県")
                IsoCode = "JP-35"
            Case UCase("山梨県")
                IsoCode = "JP-19"
            Case ""

            Case Else
                MsgBox(Prefecture)
        End Select
        GetISO = IsoCode
    End Function
    Private Function IsDoubleByte(ByVal checkStr As String)
        Dim word As String = checkStr.Trim()
        Dim containUnicode As Boolean = False
        For x As Integer = 0 To word.Length - 1
            If Char.GetUnicodeCategory(word(x)) = UnicodeCategory.OtherLetter Then
                containUnicode = True
                Exit For
            End If
        Next
        If containUnicode Then
            IsDoubleByte = True
        Else
            IsDoubleByte = False
        End If
    End Function
    Private Function ConvertCountry(ByVal CountryStr As String)
        Dim CountryLatin As String = ""
        Select Case CountryStr
            Case "日本"
                CountryLatin = "Japan"
            Case "アメリカ"
                CountryLatin = "USA"
            Case "インド"
                CountryLatin = "India"
            Case "インドネシア"
                CountryLatin = "Indonesia"
            Case "シンガポール"
                CountryLatin = "Singapore"
            Case "タイ"
                CountryLatin = "Thailand"
            Case "ドイツ"
                CountryLatin = "Germany"
            Case "ニュージーランド"
                CountryLatin = "New Zealand"
            Case "フィリピン"
                CountryLatin = "Philippines"
            Case "ブラジル"
                CountryLatin = "Brazil"
            Case "ベルギー"
                CountryLatin = "Belgium"
            Case "ロシア"
                CountryLatin = "Russia"
            Case "韓国"
                CountryLatin = "Korea"
            Case "台湾"
                CountryLatin = "Taiwan"
            Case "中国"
                CountryLatin = "China"
            Case "南アフリカ"
                CountryLatin = "South Africa"
            Case Else
                CountryLatin = "Japan"
        End Select
        ConvertCountry = CountryLatin
    End Function
    Private Function FormatAddress(ByVal FullAddr As String, ByVal City As String, ByVal State As String, ByVal Town As String)
        Dim NewAddr As String
        NewAddr = Replace(FullAddr, City, "")
        NewAddr = Replace(NewAddr, State, "")
        ' NewAddr = Replace(NewAddr, Town, "")
        FormatAddress = NewAddr
    End Function
    Private Sub GetAddress(ByVal FullAddress As String, ByRef ZipCode As String, ByRef StreetAddress As String, ByRef StreetAddress2 As String, ByRef City As String, ByRef State As String, ByRef Country As String, ByRef PrefIso As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim db_reader As OleDbDataReader
        Dim Prefecture As String = ""
        Dim Town As String = ""
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim postalcode As String = Replace(ZipCode, "-", "")
        Try
            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = SSDBString
            connUsers.Open()
            cmd.Connection = connUsers
            cmd.CommandText = "SELECT Prefecture, City, Town, PrefectureKana, CityKana, TownKana FROM tbl_PostalCodes WHERE PostalCode='" & postalcode & "'"
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)
            Do While db_reader.Read
                Prefecture = db_reader.Item("Prefecture")
                City = db_reader.Item("City")
                Town = db_reader.Item("Town")
            Loop
            cmd = Nothing
            connUsers.Close()
            ZipCode = postalcode
            City = City
            State = Prefecture
            Country = ConvertCountry(Country)
            PrefIso = GetISO(Prefecture)
            StreetAddress = FormatAddress(FullAddress, City, State, Town)
            StreetAddress2 = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub ProcessEightData(ByVal TmpArr() As String)
        Dim success As Boolean = False
        Dim UniqueID As String = Guid.NewGuid().ToString()
        Dim ExistingContactsGUID As String = ""
        Dim CompanyName, Department, Title, EMail, Zip, AddressStr, Phone, DirectoryPhone, StraightPhone, Fax, MobileNo, Website As String
        Dim UpdateDate As Date
        Dim Country, CardPath1, CardPath2, Remarks, Relationship, InfoUser, CompanyLink As String
        Dim NativeCompany, FirstName, LastName, StreetAddress, StreetAddress2, City, State, PrefIso As String
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers
        connUsers.Open()
        Try
            CompanyName = FormatStrData(TmpArr(0))
            If CompanyName = "会社名" Then Exit Sub
            NativeCompany = ""
            Department = FormatStrData(TmpArr(1))
            Title = FormatStrData(TmpArr(2))
            FirstName = ""
            LastName = FormatStrData(TmpArr(3))
            EMail = FormatStrData(TmpArr(4))
            Zip = FormatStrData(TmpArr(5))
            AddressStr = FormatStrData(TmpArr(6))
            Phone = FormatStrData(TmpArr(7))
            DirectoryPhone = FormatStrData(TmpArr(8))
            StraightPhone = FormatStrData(TmpArr(9))
            Fax = FormatStrData(TmpArr(10))
            MobileNo = FormatStrData(TmpArr(11))
            Website = FormatStrData(TmpArr(12))
            UpdateDate = FormatStrData(TmpArr(13))
            Country = "Japan"
            StreetAddress = ""
            StreetAddress2 = ""
            City = ""
            State = ""
            PrefIso = ""
            CardPath1 = ""
            CardPath2 = ""
            Relationship = "EIGHT"
            InfoUser = ""
            CompanyLink = ""
            ExistingContactsGUID = IsAddressUsed(CompanyName, LastName, EMail, Phone)
            GetAddress(AddressStr, Zip, StreetAddress, StreetAddress2, City, State, Country, PrefIso)
            Remarks = ""
            If ExistingContactsGUID = "" Then
                Query = "INSERT INTO tbl_SNContacts "
                Query = Query & "(ContactsGUID,ListID,Company,NativeCompany,Relationship,FirstName,LastName,EMail,"
                Query = Query & "Zip,Address,Country,State,City,Address1,Telephone,Fax,Website,Title,Department,"
                Query = Query & "CardPath1,CardPath2,UserName,Remarks,UpdateDate,CompanyLink) "
                Query = Query & "VALUES ('"
                Query = Query & UniqueID & "','" & ListID & "','" & CompanyName & "','" & NativeCompany & "','"
                Query = Query & Relationship & "','" & FirstName & "','" & LastName & "','" & EMail & "','"
                Query = Query & Zip & "','" & AddressStr & "','" & Country & "','" & State & "','" & City & "','"
                Query = Query & StreetAddress & "','" & Phone & "','" & Fax & "','" & Website & "','" & Title & "','"
                Query = Query & Department & "','" & CardPath1 & "','" & CardPath2 & "','" & UserName & "','"
                Query = Query & Remarks & "','" & UpdateDate & "','" & CompanyLink & "') "

            Else
                Query = "UPDATE tbl_SNContacts SET "
                Query = Query & "ListID='" & ListID & "', Company='" & CompanyName & "', NativeCompany='" & NativeCompany & "', "
                Query = Query & "Relationship='" & Relationship & "', FirstName='" & FirstName & "', LastName='" & LastName & "', "
                Query = Query & "EMail='" & EMail & "', Zip='" & Zip & "', Address='" & AddressStr & "', "
                Query = Query & "Country='" & Country & "', State='" & State & "', City='" & City & "', "
                Query = Query & "Address1='" & StreetAddress & "', Telephone='" & Phone & "', Fax='" & Fax & "', "
                Query = Query & "Website='" & Website & "', Title='" & Title & "', Department='" & Department & "', "
                Query = Query & "CardPath1='" & CardPath1 & "', CardPath2='" & CardPath2 & "', UserName='" & UserName & "', "
                Query = Query & "Remarks='" & Remarks & "', UpdateDate='" & UpdateDate & "' "
                Query = Query & "WHERE ContactsGUID='" & ExistingContactsGUID & "' "
            End If
            cmd.Connection = connUsers
            cmd.CommandText = Query
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Query)
            MessageBox.Show(ex.Message)
        Finally
            cmd = Nothing
            connUsers.Close()
        End Try
    End Sub
    Private Sub ProcessFiles(ByVal EightPath As String)
        Dim EightFile As String = ""
        Dim LineItem As String = ""
        Dim CurrentRecord As String()
        If Directory.Exists(EightPath) Then
            Dim di As New System.IO.DirectoryInfo(EightPath)
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".CSV" Then
                    EightFile = dra.FullName
                    Exit For
                End If
            Next
            If File.Exists(EightFile) Then
                Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(EightFile, System.Text.Encoding.GetEncoding(GblEncoding))
                afile.TextFieldType = FileIO.FieldType.Delimited
                afile.Delimiters = New String() {","}
                afile.HasFieldsEnclosedInQuotes = True
                Do While Not afile.EndOfData
                    CurrentRecord = afile.ReadFields
                    If CurrentRecord.Count > 10 Then
                        ProcessEightData(CurrentRecord)
                    End If
                Loop
                afile.Close()
                File.Delete(EightFile)
            End If
        End If
    End Sub
    Private Sub picDrop_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picDrop.DragDrop
        'copy file(s) to destination folder
        Dim destinationPath As String = appData & "\"
        'check if this is an outlook message. The outlook messages, all contain a FileContents attribute. If not, exit.
        Dim formats() As String = e.Data.GetFormats()

        'If formats.Contains("FileContents") = False Then Exit Sub

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim draggedFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each fileName As String In draggedFiles
                Dim Ethrd As System.Threading.Thread
                Ethrd = New System.Threading.Thread(DirectCast(Sub() ProcessFiles(fileName), ThreadStart))
                Ethrd.Start()
                Exit For
            Next
        End If
    End Sub
    Private Sub picDrop_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles picDrop.DragEnter
        ' for this program, we allow a file to be dropped from Explorer
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            '    or none of the above
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picDrop_DoubleClick(sender As Object, e As EventArgs) Handles picDrop.DoubleClick
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "ファイルを開く"
        fd.InitialDirectory = "C:\"
        fd.Filter = "全てのファイル (*.*)|*.*|全てのファイル (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim Ethrd As System.Threading.Thread
            Ethrd = New System.Threading.Thread(DirectCast(Sub() ProcessFiles(strFileName), ThreadStart))
            Ethrd.Start()
        End If
    End Sub
End Class