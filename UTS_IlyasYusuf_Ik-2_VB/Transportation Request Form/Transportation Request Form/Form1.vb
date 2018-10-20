Imports System.Data.SqlClient

Public Class Form1
    Dim transport As String
    Dim tanggal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")
    Dim cmd_gl As SqlCommand    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub ListView()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVrequest.View = View.Details
        LVrequest.Columns.Add("RequestId", 50)
        LVrequest.Columns.Add("NameRequestor", 150)
        LVrequest.Columns.Add("RequestorId", 100)
        LVrequest.Columns.Add("Unit", 150)
        LVrequest.Columns.Add("DateIssue", 100)
        LVrequest.Columns.Add("UnitDestination", 200)
        LVrequest.Columns.Add("acRegis", 100)
        LVrequest.Columns.Add("Transportation", 100)
        LVrequest.Columns.Add("Phone", 100)
        LVrequest.Columns.Add("Instruction", 300)


        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from RequestForm"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                LVrequest.Items.Add(dr("RequestId"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("RequestorId"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Unit"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("acRegis"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Transportation"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Phone"))
                LVrequest.Items(LVrequest.Items.Count - 1).SubItems.Add(dr("Instruction"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSend.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(RequestId)+1 AS MXID from RequestForm"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "insert into RequestForm(RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) values(" & uid & ",'" & TBName.Text & "','" & TBReqId.Text & "','" & TBUnit.Text & "','" & tanggal & "','" & TbUniDestination.Text & "','" & TbAcREGIS.Text & "', '" & transport & "','" & TbPhone.Text & "','" & TbInstruction.Text & "')"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            MsgBox("Selamat '" + TBName.Text + "' permintaan anda terkabul")
            dr.Close()
            bersih()
            LVrequest.Clear()
            ListView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        Call ListView()
        tid.Visible = True

        CBTransportation.Items.Add("Pick Up")
        CBTransportation.Items.Add("Box")
        CBTransportation.Items.Add("Blind")
        CBTransportation.Items.Add("Van")
        CBTransportation.Items.Add("Truck")
        CBTransportation.Items.Add("BTT")
        CBTransportation.Items.Add("Forklift")
        CBTransportation.Items.Add("Other")

        TBTransport.Visible = False
        tid.Visible = False
        btupdate.Visible = False
    End Sub

    Private Sub CBTransportation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTransportation.SelectedIndexChanged
        transport = CBTransportation.Text
        If CBTransportation.Text = "Other" Then
            TBTransport.Visible = True

        Else
            TBTransport.Visible = False
        End If
    End Sub

    Private Sub TBTransport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTransport.TextChanged
        transport = TBTransport.Text
    End Sub
    Private Sub bersih()
        TBName.Text = ""
        TBReqId.Text = ""
        TBUnit.Text = ""
        tanggal = ""
        TbUniDestination.Text = ""
        TbAcREGIS.Text = ""
        CBTransportation.Text = ""
        TbPhone.Text = ""
        TbInstruction.Text = ""
        BtSend.Text = "save"

        TBTransport.Visible = False
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Apakah Kamu Yakin Ingin Hapus?", vbYesNo) = MsgBoxResult.Yes Then
            Try
                id = LVrequest.SelectedItems(0).Text
                Call OpenKoneksi()
                Dim query As String = "Delete from RequestForm Where RequestId='" + id + "'"

                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader

                dr.Close()
                Call CloseKoneksi()

                LVrequest.Clear()
                ListView()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        btupdate.Visible = True
        BtSend.Visible = False
        Try
            id = LVrequest.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "Select * from RequestForm Where RequestId='" + id + "'"


            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            TBName.Text = dr("NameRequestor")
            TBReqId.Text = dr("RequestorId")
            TBUnit.Text = dr("Unit")
            DateTimePicker1.Value = dr("DateIssue")
            TbUniDestination.Text = dr("UnitDestination")
            TbAcREGIS.Text = dr("acRegis")
            CBTransportation.Text = dr("Transportation")
            TbPhone.Text = dr("Phone")
            TbInstruction.Text = dr("Instruction")
            tid.Text = dr("RequestId")
            dr.Close()
            Call CloseKoneksi()

            
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        BtSend.Visible = True
        btupdate.Visible = False
        TBTransport.Visible = True
        Try

            Call OpenKoneksi()
            query_gl = "UPDATE RequestForm SET " & _
                "NameRequestor = '" & TBName.Text & "'," & _
                "RequestorId ='" & TBReqId.Text & "'," & _
                "Unit = '" & TBUnit.Text & "', " & _
                "DateIssue = '" & tanggal & "'," & _
                "UnitDestination = '" & TbUniDestination.Text & "', " & _
                "acRegis = '" & TbAcREGIS.Text & "', " & _
                "Transportation = '" & transport & "', " & _
                "Phone = '" & TbPhone.Text & "', " & _
                "Instruction = '" & TbInstruction.Text & "' " & _
                "WHERE RequestId = '" & tid.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            bersih()
            LVrequest.Clear()
            ListView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
