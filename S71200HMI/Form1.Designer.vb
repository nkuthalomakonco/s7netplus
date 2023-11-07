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
        RichTextBox1 = New RichTextBox()
        ButtonRead = New Button()
        ButtonWrite = New Button()
        GroupBox1 = New GroupBox()
        TextBoxBool = New TextBox()
        GroupBox2 = New GroupBox()
        TextBoxInteger = New TextBox()
        GroupBox3 = New GroupBox()
        TextBoxReal = New TextBox()
        GroupBox4 = New GroupBox()
        TextBoxString = New TextBox()
        ButtonConn = New Button()
        GroupBox5 = New GroupBox()
        Button1 = New Button()
        GroupBox6 = New GroupBox()
        GroupBox10 = New GroupBox()
        TextBox_String = New TextBox()
        ButtonR = New Button()
        ButtonW = New Button()
        GroupBox7 = New GroupBox()
        TextBox_Bool = New TextBox()
        GroupBox9 = New GroupBox()
        TextBox_Int = New TextBox()
        GroupBox8 = New GroupBox()
        TextBox_Real = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox10.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox9.SuspendLayout()
        GroupBox8.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Dock = DockStyle.Top
        RichTextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RichTextBox1.Location = New Point(0, 0)
        RichTextBox1.MaxLength = 21474836
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(722, 227)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' ButtonRead
        ' 
        ButtonRead.Location = New Point(6, 163)
        ButtonRead.Name = "ButtonRead"
        ButtonRead.Size = New Size(94, 29)
        ButtonRead.TabIndex = 1
        ButtonRead.Text = "Read"
        ButtonRead.UseVisualStyleBackColor = True
        ' 
        ' ButtonWrite
        ' 
        ButtonWrite.Location = New Point(106, 163)
        ButtonWrite.Name = "ButtonWrite"
        ButtonWrite.Size = New Size(94, 29)
        ButtonWrite.TabIndex = 2
        ButtonWrite.Text = "Write"
        ButtonWrite.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBoxBool)
        GroupBox1.Location = New Point(6, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(139, 65)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Bool"
        ' 
        ' TextBoxBool
        ' 
        TextBoxBool.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxBool.Location = New Point(6, 26)
        TextBoxBool.Name = "TextBoxBool"
        TextBoxBool.Size = New Size(125, 34)
        TextBoxBool.TabIndex = 4
        TextBoxBool.Text = "True"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBoxInteger)
        GroupBox2.Location = New Point(177, 26)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(141, 65)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Interger"
        ' 
        ' TextBoxInteger
        ' 
        TextBoxInteger.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxInteger.Location = New Point(6, 26)
        TextBoxInteger.Name = "TextBoxInteger"
        TextBoxInteger.Size = New Size(125, 34)
        TextBoxInteger.TabIndex = 4
        TextBoxInteger.Text = "50"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBoxReal)
        GroupBox3.Location = New Point(348, 26)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(141, 65)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Real"
        ' 
        ' TextBoxReal
        ' 
        TextBoxReal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxReal.Location = New Point(6, 26)
        TextBoxReal.Name = "TextBoxReal"
        TextBoxReal.Size = New Size(125, 34)
        TextBoxReal.TabIndex = 4
        TextBoxReal.Text = "1.0001"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(TextBoxString)
        GroupBox4.Location = New Point(6, 92)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(341, 65)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "String"
        ' 
        ' TextBoxString
        ' 
        TextBoxString.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxString.Location = New Point(6, 26)
        TextBoxString.Name = "TextBoxString"
        TextBoxString.Size = New Size(321, 34)
        TextBoxString.TabIndex = 4
        TextBoxString.Text = "Aaaaaaa"
        ' 
        ' ButtonConn
        ' 
        ButtonConn.Location = New Point(646, 233)
        ButtonConn.Name = "ButtonConn"
        ButtonConn.Size = New Size(61, 29)
        ButtonConn.TabIndex = 6
        ButtonConn.Text = "Conn"
        ButtonConn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Button1)
        GroupBox5.Controls.Add(ButtonRead)
        GroupBox5.Controls.Add(ButtonWrite)
        GroupBox5.Controls.Add(GroupBox4)
        GroupBox5.Controls.Add(GroupBox1)
        GroupBox5.Controls.Add(GroupBox3)
        GroupBox5.Controls.Add(GroupBox2)
        GroupBox5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox5.Location = New Point(12, 458)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(696, 198)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "ReadWriteStruct"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(627, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(53, 29)
        Button1.TabIndex = 12
        Button1.Text = "O"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(GroupBox10)
        GroupBox6.Controls.Add(ButtonR)
        GroupBox6.Controls.Add(ButtonW)
        GroupBox6.Controls.Add(GroupBox7)
        GroupBox6.Controls.Add(GroupBox9)
        GroupBox6.Controls.Add(GroupBox8)
        GroupBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox6.Location = New Point(12, 268)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(696, 184)
        GroupBox6.TabIndex = 7
        GroupBox6.TabStop = False
        GroupBox6.Text = "ReadWrite"
        ' 
        ' GroupBox10
        ' 
        GroupBox10.Controls.Add(TextBox_String)
        GroupBox10.Location = New Point(339, 104)
        GroupBox10.Name = "GroupBox10"
        GroupBox10.Size = New Size(341, 65)
        GroupBox10.TabIndex = 11
        GroupBox10.TabStop = False
        GroupBox10.Text = "String"
        ' 
        ' TextBox_String
        ' 
        TextBox_String.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_String.Location = New Point(6, 26)
        TextBox_String.Name = "TextBox_String"
        TextBox_String.Size = New Size(321, 34)
        TextBox_String.TabIndex = 4
        TextBox_String.Text = "Aaaaaaa"
        ' 
        ' ButtonR
        ' 
        ButtonR.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonR.Location = New Point(18, 149)
        ButtonR.Name = "ButtonR"
        ButtonR.Size = New Size(94, 29)
        ButtonR.TabIndex = 9
        ButtonR.Text = "Read"
        ButtonR.UseVisualStyleBackColor = True
        ' 
        ' ButtonW
        ' 
        ButtonW.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonW.Location = New Point(118, 149)
        ButtonW.Name = "ButtonW"
        ButtonW.Size = New Size(94, 29)
        ButtonW.TabIndex = 10
        ButtonW.Text = "Write"
        ButtonW.UseVisualStyleBackColor = True
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(TextBox_Bool)
        GroupBox7.Location = New Point(12, 33)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(139, 65)
        GroupBox7.TabIndex = 6
        GroupBox7.TabStop = False
        GroupBox7.Text = "Bool"
        ' 
        ' TextBox_Bool
        ' 
        TextBox_Bool.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Bool.Location = New Point(6, 26)
        TextBox_Bool.Name = "TextBox_Bool"
        TextBox_Bool.Size = New Size(125, 34)
        TextBox_Bool.TabIndex = 4
        TextBox_Bool.Text = "True"
        ' 
        ' GroupBox9
        ' 
        GroupBox9.Controls.Add(TextBox_Int)
        GroupBox9.Location = New Point(183, 33)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(141, 65)
        GroupBox9.TabIndex = 8
        GroupBox9.TabStop = False
        GroupBox9.Text = "Interger"
        ' 
        ' TextBox_Int
        ' 
        TextBox_Int.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Int.Location = New Point(6, 26)
        TextBox_Int.Name = "TextBox_Int"
        TextBox_Int.Size = New Size(125, 34)
        TextBox_Int.TabIndex = 4
        TextBox_Int.Text = "50"
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Controls.Add(TextBox_Real)
        GroupBox8.Location = New Point(354, 33)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(141, 65)
        GroupBox8.TabIndex = 7
        GroupBox8.TabStop = False
        GroupBox8.Text = "Real"
        ' 
        ' TextBox_Real
        ' 
        TextBox_Real.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Real.Location = New Point(6, 26)
        TextBox_Real.Name = "TextBox_Real"
        TextBox_Real.Size = New Size(125, 34)
        TextBox_Real.TabIndex = 4
        TextBox_Real.Text = "101"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(722, 679)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(ButtonConn)
        Controls.Add(RichTextBox1)
        Name = "Form1"
        Text = "S7.Net"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox10.ResumeLayout(False)
        GroupBox10.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox9.ResumeLayout(False)
        GroupBox9.PerformLayout()
        GroupBox8.ResumeLayout(False)
        GroupBox8.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonWrite As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxBool As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxInteger As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxReal As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBoxString As TextBox
    Friend WithEvents ButtonConn As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ButtonR As Button
    Friend WithEvents ButtonW As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBox_Bool As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TextBox_Int As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TextBox_Real As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents TextBox_String As TextBox
    Friend WithEvents Button1 As Button
End Class
