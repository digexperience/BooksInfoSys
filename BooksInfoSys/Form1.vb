Imports System.Data.OleDb
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.ComponentModel

Public Class Form1
    Dim lv As ListViewItem
    Dim selected As String


    Private Sub PopListView()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("Book No.", 60)
            .Columns.Add("Title", 130)
            .Columns.Add("Author", 110)
            .Columns.Add("Publisher", 110)
        End With

        openCon()
        sql = "Select * from tbl_bookinfo order by bookno"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            lv = New ListViewItem(dr("bookno").ToString)
            lv.SubItems.Add(dr("booktitle"))
            lv.SubItems.Add(dr("bookauthor"))
            lv.SubItems.Add(dr("bookpublisher"))
            ListView1.Items.Add(lv)
        Loop
        dr.Close()
        cn.Close()
    End Sub

    Private Sub resetForm()
        txtbookno.Text = Nothing
        txttitle.Text = Nothing
        txtauthor.Text = Nothing
        txtpublisher.Text = Nothing
        txtcopyright.Text = Nothing
        txteditnum.Text = Nothing
        txtnumpage.Text = Nothing
        txtnumcop.Text = Nothing
        txtnamelib.Text = Nothing

        Me.txttitle.Enabled = False
        Me.txtauthor.Enabled = False
        Me.txtpublisher.Enabled = False
        Me.txtcopyright.Enabled = False
        Me.txteditnum.Enabled = False
        Me.txtnumpage.Enabled = False
        Me.txtnumcop.Enabled = False
        Me.txtnamelib.Enabled = False

        btnadd.Text = "Add New"
        btnadd.Enabled = True
        btnclose.Text = "Close"
        btnupdate.Text = "Update"
        btnupdate.Enabled = False
        btndel.Text = "Delete"
        btndel.ForeColor = Color.Red

        ListView1.Enabled = True
        ListView1.HideSelection = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListView()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ListView1.Enabled = False

        If btnadd.Text = "Edit" Then
            btnupdate.Text = "Update"
            btnadd.Enabled = False
        Else
            ListView1.HideSelection = True
            btnupdate.Text = "Save"
            txtbookno.Text = ListView1.Items.Count + 1
        End If

        Me.txttitle.Enabled = True
        Me.txtauthor.Enabled = True
        Me.txtpublisher.Enabled = True
        Me.txtcopyright.Enabled = True
        Me.txteditnum.Enabled = True
        Me.txtnumpage.Enabled = True
        Me.txtnumcop.Enabled = True
        Me.txtnamelib.Enabled = True
        Me.btnclose.Text = "Cancel"
        Me.btndel.Text = "Clear"
        Me.btndel.ForeColor = Color.Black
        btnadd.Enabled = False
        btnupdate.Enabled = True

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtbookno.Text = "" Or txttitle.Text = "" Or txtauthor.Text = "" Or txtpublisher.Text = "" Or txtcopyright.Text = "" Or txteditnum.Text = "" Or txtnumpage.Text = "" Or txtnumcop.Text = "" Or txtnamelib.Text = "" Then
            MsgBox("Please complete all data before saving it.", vbExclamation, Me.Text)

        Else
            If btnupdate.Text = "Save" Then
                If MsgBox("Are you sure to save this record?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                    openCon()
                    sql = "INSERT INTO tbl_bookinfo (bookno, booktitle, bookauthor, bookpublisher, bookcopyright, bookeditnum, booknumpages, booknumcop, booknamelib) VALUES ('" & Me.txtbookno.Text & "','" & Me.txttitle.Text & "','" & Me.txtauthor.Text & "','" & Me.txtpublisher.Text & "','" & Me.txtcopyright.Text & "','" & Me.txteditnum.Text & "','" & Me.txtnumcop.Text & "','" & Me.txtnumpage.Text & "','" & Me.txtnamelib.Text & "')"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record Saved!", 64, Me.Text)
                    PopListView()
                    resetForm()
                End If
            Else
                If MsgBox("Are you sure to save this record?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                    openCon()
                    sql = "UPDATE tbl_bookinfo SET booktitle = '" & txttitle.Text & "', bookauthor = '" & txtauthor.Text & "', bookpublisher = '" & txtpublisher.Text & "', bookcopyright = '" & txtcopyright.Text & "', bookeditnum = '" & txteditnum.Text & "', booknumpages = '" & txtnumpage.Text & "', booknumcop = '" & txtnumcop.Text & "', booknamelib = '" & txtnamelib.Text & "' where bookno = '" & selected & "'"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record Updated!", 64, Me.Text)

                    PopListView()
                    resetForm()
                End If
            End If
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If Me.btnclose.Text = "Cancel" Then
            resetForm()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        resetForm()
        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1

            selected = ListView1.SelectedItems(i).Text
            openCon()
            sql = "Select * from tbl_bookinfo where bookno = " & selected
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()

            dr.Read()

            txtbookno.Text = dr("bookno")
            txttitle.Text = dr("booktitle")
            txtauthor.Text = dr("bookauthor")
            txtpublisher.Text = dr("bookpublisher")
            txtcopyright.Text = dr("bookcopyright")
            txteditnum.Text = dr("bookeditnum")
            txtnumpage.Text = dr("booknumpages")
            txtnumcop.Text = dr("booknumcop")
            txtnamelib.Text = dr("booknamelib")

            dr.Close()
            cn.Close()
        Next

        btnClose.Text = "Cancel"
        btnAdd.Text = "Edit"
        btnAdd.Enabled = True
        btnupdate.Enabled = False
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click

        If btndel.Text = "Delete" Then
            If MsgBox("Are you sure to delete this record?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                openCon()
                sql = "Delete from tbl_bookinfo where bookno = '" & selected & "'"
                cmd = New OleDbCommand(sql, cn)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record Deleted!", 64, Me.Text)
                PopListView()
                resetForm()
            End If
        Else
            txttitle.Text = Nothing
            txtauthor.Text = Nothing
            txtpublisher.Text = Nothing
            txtcopyright.Text = Nothing
            txteditnum.Text = Nothing
            txtnumcop.Text = Nothing
            txtnumpage.Text = Nothing
            txtnamelib.Text = Nothing
        End If

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txttitle.TextChanged, txtauthor.TextChanged, txtpublisher.TextChanged, txtcopyright.TextChanged, txteditnum.TextChanged, txtnumcop.TextChanged, txtnumpage.TextChanged, txtnamelib.TextChanged
        If txttitle.Text = "" And txtauthor.Text = "" And txtpublisher.Text = "" And txtcopyright.Text = "" And txteditnum.Text = "" And txtnumpage.Text = "" And txtnumcop.Text = "" And txtnamelib.Text = "" Then
            btndel.Enabled = False
        Else
            btndel.Enabled = True
        End If

    End Sub
End Class