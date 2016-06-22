Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class frmAddressCard
    Public ContactsGUID As String = ""
    Public Edit As Boolean = False
    Public Add As Boolean = False
    Public CardPath1 As String = ""
    Public CardPath2 As String = ""
    Public InfoChange1 As Boolean = False
    Public InfoChange2 As Boolean = False
    Dim FirstLoad As Boolean = True
    Private Sub frmAddressCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            picCard1.AllowDrop = True
            picCard2.AllowDrop = True
            LoadTypeComboBox()
            LoadUserComboBox()
            LoadCompanyComboBox()
            LoadCountryComboBox()
            'Register the skins with the application
            Dim BCardPath As String = SigmanestDataPath & "RAKUCADATA\BusinessCards\"
            Try
                If CardPath1 <> "" Then
                    Dim image1 As Bitmap = CType(Image.FromFile(BCardPath & CardPath1, True), Bitmap)
                    picCard1.SizeMode = PictureBoxSizeMode.StretchImage
                    picCard1.Image = image1
                End If
                If CardPath2 <> "" Then
                    Dim image2 As Bitmap = CType(Image.FromFile(BCardPath & CardPath2, True), Bitmap)
                    picCard2.SizeMode = PictureBoxSizeMode.Normal
                    picCard2.BackgroundImage = image2
                End If
            Catch ex As Exception

            End Try
            FirstLoad = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmAddressCard_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'DeleteCards()
    End Sub
    Private Sub LoadTypeComboBox()
        Dim Relationship As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        cmd.CommandText = "SELECT DISTINCT(Relationship) AS Relationship FROM tbl_SNContacts"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            Relationship = db_reader.Item("Relationship").ToString
            cmbType.Properties.Items.Add(Relationship)
        Loop
        cmd = Nothing
        connUsers.Close()
    End Sub
    Private Sub LoadCompanyComboBox()
        Dim Company As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        cmd.CommandText = "SELECT DISTINCT(Company) AS Company FROM tbl_SNContacts"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            Company = db_reader.Item("Company").ToString
            cmbCompany.Properties.Items.Add(Company)
        Loop
        cmd = Nothing
        connUsers.Close()
    End Sub
    Private Sub LoadUserComboBox()
        Dim UserName As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        cmd.CommandText = "SELECT DISTINCT(UserName) AS UserName FROM tbl_SNContacts"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            UserName = db_reader.Item("UserName").ToString
            cmbUser.Properties.Items.Add(UserName)
        Loop
        cmd = Nothing
        connUsers.Close()
    End Sub
    Private Sub LoadCountryComboBox()
        Dim Country As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        cmd.CommandText = "SELECT DISTINCT(Country) AS Country FROM tbl_SNContacts"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            Country = db_reader.Item("Country").ToString
            cmbCountry.Properties.Items.Add(Country)
        Loop
        cmd = Nothing
        connUsers.Close()
    End Sub
    Private Sub RExecuteNonQuery(Query As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim connUsers As System.Data.OleDb.OleDbConnection
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers
        Try
            connUsers.Open()
            cmd.CommandText = Query
            cmd.Connection = connUsers
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            connUsers.Close()
        Finally
            connUsers.Close()
        End Try
    End Sub
    Private Function IsEMailAvail(ByVal EMailId As String) As String
        Dim ContactsGUID As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        cmd.CommandText = "Select ContactsGUID from tbl_SNContacts where EMail='" & EMailId & "'"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            ContactsGUID = db_reader.Item("ContactsGUID").ToString
        Loop
        cmd = Nothing
        connUsers.Close()
        IsEMailAvail = ContactsGUID
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim sql As String
            Dim success As Boolean = False
            Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
            Dim emailAddressMatch As Match = Regex.Match(txtEMail.Text, pattern)
            Dim UniqueID As String = Guid.NewGuid().ToString()

            If Add = True Then
                ContactsGUID = IsEMailAvail(txtEMail.Text.Replace("'", "''").Trim())
                If ContactsGUID = "" Or txtEMail.Text = "" Then
                    sql = String.Format("INSERT INTO tbl_SNContacts (EMail,Relationship,UserName,LastName,Company,Address,Zip,City,State,Country,Telephone,Fax,Website,Title,Department,Remarks,issubscribe,CardPath1,CardPath2,UpdateDate,ContactsGUID,ListID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}','{18}','{19}','{20}','{21}')" _
                        , txtEMail.Text.Replace("'", "''").Trim(), cmbType.Text.Replace("'", "''").Trim(), cmbUser.Text.Replace("'", "''").Trim(), txtName.Text.Replace("'", "''").Trim(), cmbCompany.Text.Replace("'", "''").Trim(), txtAddress.Text.Replace("'", "''").Trim(), txtZip.Text.Replace("'", "''").Trim(), txtCity.Text.Replace("'", "''").Trim(), txtState.Text.Replace("'", "''").Trim(),
                        cmbCountry.Text.Replace("'", "''").Trim(), txtTelephone.Text.Replace("'", "''").Trim(), txtFax.Text.Replace("'", "''").Trim(),
                        txtWebsite.Text.Replace("'", "''").Trim(), txtJob.Text.Replace("'", "''").Trim(), txtBusiness.Text.Replace("'", "''").Trim(), txtNote.Text.Replace("'", "''").Trim(), 0, CardPath1, CardPath2, Date.Now, UniqueID, ListID)
                Else
                    If (MessageBox.Show("メールアドレスが存在します。上書きしますか？", "RakucaSOFT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes) Then
                        sql = String.Format("Update tbl_SNContacts set EMail='{0}',Relationship='{1}',UserName='{2}',LastName='{3}',Company='{4}',Address='{5}',Zip='{6}',City='{7}',State='{8}',Country='{9}',Telephone='{10}',Fax='{11}',Website='{12}',Department='{13}',Title='{14}',Remarks='{15}',CardPath1='{16}',CardPath2='{17}',UpdateDate='{18}' where ContactsGUID='" & ContactsGUID & "' " _
                            , txtEMail.Text.Replace("'", "''").Trim(), cmbType.Text.Replace("'", "''").Trim(), cmbUser.Text.Replace("'", "''").Trim(), txtName.Text.Replace("'", "''").Trim(), cmbCompany.Text.Replace("'", "''").Trim(), txtAddress.Text.Replace("'", "''").Trim(),
                            txtZip.Text.Replace("'", "''").Trim(), txtCity.Text.Replace("'", "''").Trim(), txtState.Text.Replace("'", "''").Trim(), cmbCountry.Text.Replace("'", "''").Trim(), txtTelephone.Text.Replace("'", "''").Trim(), txtFax.Text.Replace("'", "''").Trim(),
                            txtWebsite.Text.Replace("'", "''").Trim(), txtBusiness.Text.Replace("'", "''").Trim(), txtJob.Text.Replace("'", "''").Trim(), txtNote.Text.Replace("'", "''").Trim(), CardPath1, CardPath2, Date.Now)
                    Else
                        sql = String.Format("INSERT INTO tbl_SNContacts (EMail,Relationship,UserName,LastName,Company,Address,Zip,City,State,Country,Telephone,Fax,Website,Title,Department,Remarks,issubscribe,CardPath1,CardPath2,UpdateDate,ContactsGUID,ListID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}','{18}','{19}','{20}','{21}')" _
                            , txtEMail.Text.Replace("'", "''").Trim(), cmbType.Text.Replace("'", "''").Trim(), cmbUser.Text.Replace("'", "''").Trim(), txtName.Text.Replace("'", "''").Trim(), cmbCompany.Text.Replace("'", "''").Trim(), txtAddress.Text.Replace("'", "''").Trim(), txtZip.Text.Replace("'", "''").Trim(), txtCity.Text.Replace("'", "''").Trim(), txtState.Text.Replace("'", "''").Trim(),
                            cmbCountry.Text.Replace("'", "''").Trim(), txtTelephone.Text.Replace("'", "''").Trim(), txtFax.Text.Replace("'", "''").Trim(),
                            txtWebsite.Text.Replace("'", "''").Trim(), txtJob.Text.Replace("'", "''").Trim(), txtBusiness.Text.Replace("'", "''").Trim(), txtNote.Text.Replace("'", "''").Trim(), 0, CardPath1, CardPath2, Date.Now, UniqueID, ListID)
                    End If
                End If
                RExecuteNonQuery(sql)
            ElseIf Edit = True Then
                sql = String.Format("Update tbl_SNContacts set EMail='{0}',Relationship='{1}',UserName='{2}',LastName='{3}',Company='{4}',Address='{5}',Zip='{6}',City='{7}',State='{8}',Country='{9}',Telephone='{10}',Fax='{11}',Website='{12}',Department='{13}',Title='{14}',Remarks='{15}',CardPath1='{16}',CardPath2='{17}',UpdateDate='{18}' where ContactsGUID='" & ContactsGUID & "' " _
                    , txtEMail.Text.Replace("'", "''").Trim(), cmbType.Text.Replace("'", "''").Trim(), cmbUser.Text.Replace("'", "''").Trim(), txtName.Text.Replace("'", "''").Trim(), cmbCompany.Text.Replace("'", "''").Trim(), txtAddress.Text.Replace("'", "''").Trim(),
                    txtZip.Text.Replace("'", "''").Trim(), txtCity.Text.Replace("'", "''").Trim(), txtState.Text.Replace("'", "''").Trim(), cmbCountry.Text.Replace("'", "''").Trim(), txtTelephone.Text.Replace("'", "''").Trim(), txtFax.Text.Replace("'", "''").Trim(),
                    txtWebsite.Text.Replace("'", "''").Trim(), txtBusiness.Text.Replace("'", "''").Trim(), txtJob.Text.Replace("'", "''").Trim(), txtNote.Text.Replace("'", "''").Trim(), CardPath1, CardPath2, Date.Now)
                RExecuteNonQuery(sql)
            Else
                sql = String.Format("INSERT INTO tbl_SNContacts (EMail,Relationship,UserName,LastName,Company,Address,Zip,City,State,Country,Telephone,Fax,Website,Title,Department,Remarks,issubscribe,CardPath1,CardPath2,UpdateDate,ContactsGUID,ListID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}','{18}','{19}','{20}','{21}')" _
                    , txtEMail.Text.Replace("'", "''").Trim(), cmbType.Text.Replace("'", "''").Trim(), cmbUser.Text.Replace("'", "''").Trim(), txtName.Text.Replace("'", "''").Trim(), cmbCompany.Text.Replace("'", "''").Trim(), txtAddress.Text.Replace("'", "''").Trim(), txtZip.Text.Replace("'", "''").Trim(), txtCity.Text.Replace("'", "''").Trim(), txtState.Text.Replace("'", "''").Trim(),
                    cmbCountry.Text.Replace("'", "''").Trim(), txtTelephone.Text.Replace("'", "''").Trim(), txtFax.Text.Replace("'", "''").Trim(),
                    txtWebsite.Text.Replace("'", "''").Trim(), txtJob.Text.Replace("'", "''").Trim(), txtBusiness.Text.Replace("'", "''").Trim(), txtNote.Text.Replace("'", "''").Trim(), 0, CardPath1, CardPath2, Date.Now, UniqueID, ListID)
                RExecuteNonQuery(sql)
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        Edit = False
        Add = True
    End Sub
    Private Sub SearchPostalCode()
        Dim cmd As New OleDb.OleDbCommand
        Dim db_reader As OleDbDataReader
        Dim Prefecture As String = ""
        Dim City As String = ""
        Dim Town As String = ""
        Dim PrefectureKana As String = ""
        Dim CityKana As String = ""
        Dim TownKana As String = ""
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim postalcode As String = Replace(txtZip.Text, "-", "")


        Try
            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = SSDBString
            cmd.Connection = connUsers
            connUsers.Open()
            cmd.Connection = connUsers
            cmd.CommandText = "SELECT Prefecture, City, Town, PrefectureKana, CityKana, TownKana FROM tbl_PostalCodes WHERE PostalCode='" & postalcode & "'"
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)
            Do While db_reader.Read
                Prefecture = db_reader.Item("Prefecture")
                City = db_reader.Item("City")
                Town = db_reader.Item("Town")
                PrefectureKana = db_reader.Item("PrefectureKana")
                CityKana = db_reader.Item("CityKana")
                TownKana = db_reader.Item("TownKana")
            Loop
            cmd = Nothing
            connUsers.Close()
        Catch ex As Exception
            MsgBox("接続タイムアウト。")
        Finally
            txtAddress.Text = Prefecture & City & Town
            txtCity.Text = Town
            txtState.Text = Prefecture
            cmbCountry.Text = "Japan"
            txtZip.Text = Microsoft.VisualBasic.Left(postalcode, 3) & "-" & Microsoft.VisualBasic.Right(postalcode, 4)
        End Try

    End Sub
    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        'DeleteCards()
        Me.Close()
    End Sub
    Private Sub txtZip_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZip.KeyUp
        If (txtZip.Text <> "" And Len(txtZip.Text) = 7 And InStr(1, txtZip.Text, "-", CompareMethod.Text) <= 0) Or (txtZip.Text <> "" And Len(txtZip.Text) = 8 And InStr(1, txtZip.Text, "-", CompareMethod.Text) > 0) Then
            SearchPostalCode()
        End If

        If e.KeyValue = 13 Then
            txtCity.Focus()
        End If
    End Sub
    Private Sub picCard1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles picCard1.DoubleClick
        Dim frmCamera As New frmCamera
        frmCamera.ShowDialog()
        CardPath1 = frmCamera.BCardName
        Try
            Dim BCardPath As String = SigmanestDataPath & "RAKUCADATA\BusinessCards\"

            Dim image1 As Bitmap = CType(Image.FromFile(BCardPath & CardPath1, True), Bitmap)
            picCard1.SizeMode = PictureBoxSizeMode.StretchImage
            picCard1.Image = image1
        Catch ex As Exception

        End Try
        InfoChange1 = True
    End Sub
    Private Sub picCard2_DoubleClick(sender As System.Object, e As System.EventArgs) Handles picCard2.DoubleClick
        Dim frmCamera As New frmCamera
        frmCamera.ShowDialog()
        CardPath2 = frmCamera.BCardName
        Try
            Dim BCardPath As String = SigmanestDataPath & "RAKUCADATA\BusinessCards\"
            Dim image2 As Bitmap = CType(Image.FromFile(BCardPath & CardPath2, True), Bitmap)
            picCard2.SizeMode = PictureBoxSizeMode.StretchImage
            picCard2.Image = image2
        Catch ex As Exception

        End Try
        InfoChange2 = True
    End Sub
    Private Sub CopyAndLoadImage(ByVal CardFilePath As String, ByVal FrontSide As Boolean)
        Dim BCardPath As String = SigmanestDataPath & "RAKUCADATA\BusinessCards\"
        Dim NewPath As String = ""
        Try
            NewPath = BCardPath & Path.GetFileName(CardFilePath)
            File.Copy(CardFilePath, NewPath, True)
            If FrontSide = True Then
                Dim image1 As Bitmap = CType(Image.FromFile(NewPath, True), Bitmap)
                picCard1.SizeMode = PictureBoxSizeMode.StretchImage
                picCard1.Image = image1
                CardPath1 = Path.GetFileName(CardFilePath)
            Else
                Dim image2 As Bitmap = CType(Image.FromFile(NewPath, True), Bitmap)
                picCard2.SizeMode = PictureBoxSizeMode.Normal
                picCard2.BackgroundImage = image2
                CardPath2 = Path.GetFileName(CardFilePath)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub picCard1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picCard1.DragDrop

        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files
                CopyAndLoadImage(path, True)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub picCard2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picCard2.DragDrop

        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files
                CopyAndLoadImage(path, False)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub picCard1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picCard1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub picCard2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picCard2.DragEnter
          If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub cmbCompany_Leave(sender As Object, e As EventArgs) Handles cmbCompany.Leave
        If FirstLoad = False And cmbCompany.Text <> "" Then
            Try
                Dim db_reader As OleDbDataReader
                Dim connUsers As System.Data.OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                connUsers = New System.Data.OleDb.OleDbConnection
                connUsers.ConnectionString = SSDBString
                cmd.Connection = connUsers

                connUsers.Open()
                cmd.Connection = connUsers
                cmd.CommandText = "SELECT * FROM tbl_SNContacts WHERE Company='" & cmbCompany.Text & "'"
                db_reader = cmd.ExecuteReader(CommandBehavior.Default)
                Do While db_reader.Read
                    txtZip.Text = db_reader.Item("Zip").ToString
                    txtAddress.Text = db_reader.Item("Address").ToString
                    cmbType.Text = db_reader.Item("Type").ToString
                    cmbCountry.Text = db_reader.Item("Country").ToString
                    txtTelephone.Text = db_reader.Item("Telephone").ToString
                    txtFax.Text = db_reader.Item("Fax").ToString
                    txtWebsite.Text = db_reader.Item("Website").ToString
                    txtCity.Text = db_reader.Item("City").ToString
                    txtState.Text = db_reader.Item("State").ToString

                Loop
                cmd = Nothing
                connUsers.Close()
            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtZip.Text = ""
        txtAddress.Text = ""
        cmbType.Text = ""
        cmbCountry.Text = ""
        txtTelephone.Text = ""
        txtFax.Text = ""
        txtWebsite.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
    End Sub
#Region "OCR"
    Structure st_scWord
        Dim text As String
        Dim left As Integer
        Dim right As Integer
        Dim top As Integer
        Dim bottom As Integer
    End Structure
    Dim scWords As New List(Of st_scWord)
    Dim ScNums As New List(Of st_scWord)
    Dim ScSchrs As New List(Of st_scWord)
    Dim NScNums As New List(Of st_scWord)
    Function GetOCRtext(ByVal FileName As String) As String
        'Dim myDoc As MODI.Document
        'Dim myImage As MODI.Image
        'Dim myLayout As MODI.ILayout
        'Dim myWords As MODI.IWords
        'Dim myWord As MODI.IWord
        'Dim myRects As MODI.MiRects
        'Dim myRect As MODI.MiRect
        Dim mystr As String = ""
        'Dim i As Integer
        'Dim scWord As st_scWord
        'myDoc = New MODI.Document
        'Try
        '    myDoc.Create(FileName)

        '    myDoc.OCR(MODI.MiLANGUAGES.miLANG_JAPANESE, False, False)
        '    myImage = myDoc.Images(0)
        '    myLayout = myImage.Layout
        '    myWords = myLayout.Words

        '    For i = 0 To myWords.Count - 1
        '        myWord = myWords(i)
        '        scWord.text = myWord.Text
        '        myRects = myWord.Rects
        '        myRect = myRects(0)
        '        scWord.left = myRect.Left
        '        scWord.right = myRect.Right
        '        scWord.top = myRect.Top
        '        scWord.bottom = myRect.Bottom
        '        scWords.Add(scWord)
        '        mystr = mystr & scWord.text
        '    Next
        'Catch ex As Exception

        'End Try

        GetOCRtext = mystr
    End Function
    Private Function minScWLeft() As Integer
        Dim i As Integer
        Dim dum As Integer
        dum = scWords(0).left
        For i = 0 To scWords.Count - 1
            If dum > scWords(i).left Then dum = scWords(i).left
        Next
        Return dum
    End Function
    Private Function maxScWRight() As Integer
        Dim i As Integer
        Dim dum As Integer
        dum = scWords(0).right
        For i = 0 To scWords.Count - 1
            If dum < scWords(i).right Then dum = scWords(i).right
        Next
        Return dum
    End Function
    Private Function minScWTop() As Integer
        Dim i As Integer
        Dim dum As Integer
        dum = scWords(0).top
        For i = 0 To scWords.Count - 1
            If dum > scWords(i).top Then dum = scWords(i).top
        Next
        Return dum
    End Function
    Private Function maxScWBottom() As Integer
        Dim i As Integer
        Dim dum As Integer
        dum = scWords(0).bottom
        For i = 0 To scWords.Count - 1
            If dum < scWords(i).bottom Then dum = scWords(i).bottom
        Next
        Return dum
    End Function
    Private Function ScwWidth() As Integer
        Dim dum As Integer
        dum = maxScWRight() - minScWLeft()
        Return dum
    End Function
    Private Function ScwHeight() As Integer
        Dim dum As Integer
        dum = maxScWBottom() - minScWTop()
        Return dum
    End Function
    Private Function ScwScale(ByVal Obj As PictureBox) As Single
        Dim dum As Single
        dum = Obj.Width / ScwWidth()
        Return dum
    End Function
#End Region
#Region "Image Cropping"
    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Public cropPen As Pen
    Public cropPenSize As Integer = 2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Red

    Private Sub picCard1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCard1.MouseDown
        Try

            If e.Button = Windows.Forms.MouseButtons.Left Then

                cropX = e.X
                cropY = e.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            picCard1.Refresh()
        Catch exc As Exception
        End Try
    End Sub
    Dim tmppoint As Point
    Private Sub picCard1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCard1.MouseMove
        Try

            If picCard1.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left Then

                picCard1.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY
                picCard1.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            End If
            ' GC.Collect()

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try

    End Sub

    Private Sub picCard1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCard1.MouseUp
        Try
            Cursor = Cursors.Default
            Try
                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Dim bit As Bitmap = New Bitmap(picCard1.Image, picCard1.Width, picCard1.Height)

                cropBitmap = New Bitmap(cropWidth, cropHeight)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                'picCard2.BackgroundImage = cropBitmap
                Me.cms1.Show(picCard1, New Point(e.X, e.Y))
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
#End Region

    Private Sub ttsName_Click(sender As System.Object, e As System.EventArgs) Handles ttsName.Click

        Dim mytext As String = ""
        cropBitmap.Save("ocr.jpg")
        mytext = GetOCRtext("ocr.jpg")
        txtName.Text = mytext
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub


    
  
End Class
