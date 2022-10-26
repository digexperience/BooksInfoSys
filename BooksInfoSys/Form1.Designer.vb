<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbookno = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcopyright = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txteditnum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnumpage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumcop = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnamelib = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book No.:"
        '
        'txtbookno
        '
        Me.txtbookno.Enabled = False
        Me.txtbookno.Location = New System.Drawing.Point(124, 29)
        Me.txtbookno.Name = "txtbookno"
        Me.txtbookno.Size = New System.Drawing.Size(192, 20)
        Me.txtbookno.TabIndex = 1
        '
        'txttitle
        '
        Me.txttitle.Enabled = False
        Me.txttitle.Location = New System.Drawing.Point(124, 55)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(192, 20)
        Me.txttitle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Title"
        '
        'txtauthor
        '
        Me.txtauthor.Enabled = False
        Me.txtauthor.Location = New System.Drawing.Point(124, 81)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(192, 20)
        Me.txtauthor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Author"
        '
        'txtpublisher
        '
        Me.txtpublisher.Enabled = False
        Me.txtpublisher.Location = New System.Drawing.Point(124, 107)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(192, 20)
        Me.txtpublisher.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Publisher"
        '
        'txtcopyright
        '
        Me.txtcopyright.Enabled = False
        Me.txtcopyright.Location = New System.Drawing.Point(124, 133)
        Me.txtcopyright.Name = "txtcopyright"
        Me.txtcopyright.Size = New System.Drawing.Size(192, 20)
        Me.txtcopyright.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Copyright of the book:"
        '
        'txteditnum
        '
        Me.txteditnum.Enabled = False
        Me.txteditnum.Location = New System.Drawing.Point(124, 159)
        Me.txteditnum.Name = "txteditnum"
        Me.txteditnum.Size = New System.Drawing.Size(192, 20)
        Me.txteditnum.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Edition number:"
        '
        'txtnumpage
        '
        Me.txtnumpage.Enabled = False
        Me.txtnumpage.Location = New System.Drawing.Point(124, 185)
        Me.txtnumpage.Name = "txtnumpage"
        Me.txtnumpage.Size = New System.Drawing.Size(192, 20)
        Me.txtnumpage.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Number of Pages:"
        '
        'txtnumcop
        '
        Me.txtnumcop.Enabled = False
        Me.txtnumcop.Location = New System.Drawing.Point(124, 211)
        Me.txtnumcop.Name = "txtnumcop"
        Me.txtnumcop.Size = New System.Drawing.Size(192, 20)
        Me.txtnumcop.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Number of Copies"
        '
        'txtnamelib
        '
        Me.txtnamelib.Enabled = False
        Me.txtnamelib.Location = New System.Drawing.Point(124, 237)
        Me.txtnamelib.Name = "txtnamelib"
        Me.txtnamelib.Size = New System.Drawing.Size(192, 20)
        Me.txtnamelib.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Name of Library"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(322, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(378, 228)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(322, 263)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(90, 23)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Enabled = False
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(418, 263)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(90, 23)
        Me.btnupdate.TabIndex = 20
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Enabled = False
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.Red
        Me.btndel.Location = New System.Drawing.Point(514, 263)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(90, 23)
        Me.btndel.TabIndex = 21
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(610, 263)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(90, 23)
        Me.btnclose.TabIndex = 22
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 295)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtnamelib)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnumcop)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnumpage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txteditnum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcopyright)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpublisher)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbookno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Books Information System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbookno As TextBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtauthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpublisher As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcopyright As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txteditnum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnumpage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnumcop As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnamelib As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnclose As Button
End Class
