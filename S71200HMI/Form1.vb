Imports S7.Net
Imports S7.Net.Types
Imports System.Diagnostics
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Public Class Form1
#Region ""
    Const DBno As UInt16 = 6
    Const Ip As String = "10.3.1.86" 'connect to my pc ip. my ip is link to psim via Nettoplcsim-S7.
    Private plc As Plc = New Plc(CpuType.S71200, Ip, 0, 1)
#End Region
    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Assert.IsTrue(plc.IsConnected, "Before executing this test.")
        If plc.IsConnected Then
            ButtonConn.BackColor = Color.GreenYellow
        End If
        If Not ErrorCode.NoError Then

        End If
        Try
            'Values that are read from a struct are stored in a new struct, returned by the funcion ReadStruct
            Dim DBvalues As TestStruct = CType(plc.ReadStruct(GetType(TestStruct), DBno), TestStruct)
            Dim val As String = $"{Now.ToString("G")}:[vBool: {DBvalues.BitVariable00}][vInteger: {DBvalues.DIntVariable}][vReal: {DBvalues.RealVariable}][vString: {DBvalues.StringVariable}]{vbLf}"
            RichTextBox1.AppendText(val)
        Catch ex As Exception
            RichTextBox1.AppendText(ex.Message & vbLf)
        End Try

    End Sub

    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Assert.IsTrue(plc.IsConnected, "Before executing this test.")
        If Not plc.IsConnected Then
            ButtonConn.BackColor = Color.GreenYellow
            Return
        End If
        Dim DBvalues As TestStruct
        DBvalues.BitVariable00 = True
        DBvalues.DIntVariable = Date.Now.Second
        DBvalues.RealVariable = Date.Now.Second * 1.55
        DBvalues.StringVariable = TextBoxString.Text

        plc.WriteStruct(DBvalues, DBno)

    End Sub

    Private Sub ButtonConn_Click(sender As Object, e As EventArgs) Handles ButtonConn.Click
        Try
            plc.Open()
            Assert.IsTrue(plc.IsConnected, "Before executing this test, the plc must be connected. Check constructor.")
            If Not ErrorCode.NoError Then
                ButtonConn.BackColor = Color.OrangeRed
            End If
            If plc.IsConnected Then
                ButtonConn.BackColor = Color.GreenYellow
            End If
        Catch ex As Exception
            ButtonConn.BackColor = Color.Red
            RichTextBox1.AppendText("Not connected." & vbLf)
            RichTextBox1.AppendText(ex.Message & vbLf)
        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub
#Region "DB ADDRESS"
    'DB ADDRESS 
    'int DB1.DBW2
    'real DB1.DBD4
    'bool DB1.DBX0.0
    'String DB1.DBX8.0
#End Region
    Private Async Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click
        Assert.IsTrue(plc.IsConnected, "Before executing this test, the plc must be connected.")
        Try
            Dim resultInteger As Integer = CInt(Await plc.ReadAsync("DB1.DBW2"))
            RichTextBox1.AppendText($"{Now.ToString("G")}: [Integer]DB1.DBW2: {resultInteger}" & vbLf)
            Dim result_float As Single = (CUInt(Await plc.ReadAsync("DB1.DBD4"))).ConvertToFloat()
            RichTextBox1.AppendText($"{Now.ToString("G")}: [Single]DB1.DBD4: {result_float}" & vbLf)
            Dim resultBool As Boolean = CBool(Await plc.ReadAsync("DB1.DBX0.0"))
            RichTextBox1.AppendText($"{Now.ToString("G")}: [Boolean]DB1.DBX0.0: {resultBool}" & vbLf)
            ' Dim resultString As String = CStr(Await plc.ReadAsync("DB1.DBX8.0"))
            'RichTextBox1.AppendText($"{Now.ToString("G")}: [String]DB1.DBX8.0: {resultString}" & vbLf)
        Catch ex As Exception
            RichTextBox1.AppendText(ex.Message & vbLf)
            RichTextBox1.AppendText(ErrorToString() & vbLf)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Async Sub ButtonW_Click(sender As Object, e As EventArgs) Handles ButtonW.Click
        Assert.IsTrue(plc.IsConnected, "Before executing this test, the plc must be connected.")
        Try
            Await plc.WriteAsync("DB1.DBW2", CInt(TextBox_Int.Text)) 'int
            Await plc.WriteAsync("DB1.DBD4", CDbl(TextBox_Real.Text)) 'real
            Await plc.WriteAsync("DB1.DBX0.0", True) 'bool
        Catch ex As Exception
            RichTextBox1.AppendText(ex.Message & vbLf)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub Outs(vals As TestStruct)
        Dim val = $"{Now.ToString("G")}:[vBool: {vals.BitVariable00}]
                [vInteger: {vals.DIntVariable}][vReal: {vals.RealVariable}]
                [vString: {vals.StringVariable}]{vbLf}"

        RichTextBox1.AppendText(val & vbLf)
    End Sub

    Private Sub TextBoxString_TextChanged(sender As Object, e As EventArgs) Handles TextBoxString.TextChanged
        If TextBoxString.TextLength > 10 Then
            TextBoxString.Text = "check size"
        End If
    End Sub

    Public Structure TestStruct
        Public BitVariable00 As Boolean
        Public BitVariable10 As Boolean
        Public DIntVariable As Integer
        Public IntVariable As Short
        Public RealVariable As Single
        Public DWordVariable As UShort
        <S7String(S7StringType.S7String, 10)>
        Public StringVariable As String
    End Structure

End Class
