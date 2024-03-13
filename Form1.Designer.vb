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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        TextBox1 = New TextBox()
        Button1 = New Button()
        NumericUpDown1 = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        logbox = New TextBox()
        PictureBox1 = New PictureBox()
        NumericUpDown2 = New NumericUpDown()
        Label4 = New Label()
        Button3 = New Button()
        version_text = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 0
        Label1.Text = "下载到"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(65, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(311, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(384, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 27)
        Button1.TabIndex = 2
        Button1.Text = "查找"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(65, 54)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(83, 23)
        NumericUpDown1.TabIndex = 3
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 17)
        Label2.TabIndex = 4
        Label2.Text = "次数"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 17)
        Label3.TabIndex = 5
        Label3.Text = "api"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"https://api.vvhan.com/api/girl", "https://www.dmoe.cc/random.php", "https://api.vvhan.com/api/acgimg", "https://api.dujin.org/pic/yuanshen/"})
        ComboBox1.Location = New Point(65, 90)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(311, 25)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "https://api.vvhan.com/api/girl"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(384, 88)
        Button2.Name = "Button2"
        Button2.Size = New Size(54, 27)
        Button2.TabIndex = 7
        Button2.Text = "下载"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' logbox
        ' 
        logbox.BorderStyle = BorderStyle.FixedSingle
        logbox.Location = New Point(15, 132)
        logbox.Multiline = True
        logbox.Name = "logbox"
        logbox.ReadOnly = True
        logbox.Size = New Size(209, 255)
        logbox.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(229, 132)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(205, 255)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(229, 54)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(83, 23)
        NumericUpDown2.TabIndex = 10
        NumericUpDown2.Value = New Decimal(New Integer() {6, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(180, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 17)
        Label4.TabIndex = 11
        Label4.Text = "间隔秒"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Cursor = Cursors.Help
        Button3.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Button3.Location = New Point(318, 53)
        Button3.Name = "Button3"
        Button3.RightToLeft = RightToLeft.No
        Button3.Size = New Size(22, 22)
        Button3.TabIndex = 12
        Button3.Text = "?"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' version_text
        ' 
        version_text.AutoSize = True
        version_text.Location = New Point(363, 56)
        version_text.Name = "version_text"
        version_text.Size = New Size(61, 17)
        version_text.TabIndex = 13
        version_text.Text = "版本-0.01"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 399)
        Controls.Add(version_text)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(NumericUpDown2)
        Controls.Add(PictureBox1)
        Controls.Add(logbox)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NumericUpDown1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "自动下载二次元图片 --by Nua努努"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents logbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents version_text As Label

End Class
