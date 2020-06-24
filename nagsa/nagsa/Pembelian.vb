Imports MySql.Data.MySqlClient
Public Class Formpembelian
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim autogenerate As String
    Dim ds As New DataSet

    Private Sub Formpembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tb_totalharga.Font = New Font(tb_totalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        Label3.Font = New Font(Label3.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 15)
        Label5.Font = New Font(Label5.Font.FontFamily, 15)
        tb_nonota.Font = New Font(tb_nonota.Font.FontFamily, 15)
        dtptanggal.Font = New Font(dtptanggal.Font.FontFamily, 15)
        tb_kodesupplier.Font = New Font(tb_kodesupplier.Font.FontFamily, 15)
        dtp_jt.Font = New Font(dtp_jt.Font.FontFamily, 15)

        dtptanggal.Value = DateTime.Now
        dtp_jt.Value = DateTime.Now

        tb_totalharga.Enabled = False
        tb_nonota.Enabled = False
        tbnamabarang.Enabled = False

        Try
            autogenerate = ""
            dt = New DataTable
            query = "select no_nota_pembelian from pembelian"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "000000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "00000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "0000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "00" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000000 Then
                autogenerate = autogenerate + "0" + (dt.Rows.Count + 1).ToString
            End If
            tb_nonota.Text = autogenerate
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        Isi_Supplier.ShowDialog()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            dt = New DataTable
            query = "insert into pembelian values('" + tb_nonota.Text + "','" + dtptanggal.Text + "','" + tb_kodesupplier.Text + "','" + dtp_jt.Text + "','" + tb_totalharga.Text + "')"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Masuk")

            autogenerate = ""
            dt = New DataTable
            query = "select no_nota_pembelian from pembelian"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "000000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "00000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "0000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "00" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000000 Then
                autogenerate = autogenerate + "0" + (dt.Rows.Count + 1).ToString
            End If
            tb_nonota.Text = autogenerate
            tb_totalharga.Text = "0"
            tb_nonota.Text = " "
            tb_kodesupplier.Text = " "
            dtp_jt.Value = DateTime.Now
            dtptanggal.Value = DateTime.Now
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_koreksi_Click(sender As Object, e As EventArgs) Handles btn_koreksi.Click
        tb_nonota.Enabled = True
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Try
            dt = New DataTable
            query = "insert into detail_pembelian values('" + tbkodebarang.Text + "','" + tb_nonota.Text + "','" + tbbatch.Text + "','" + tb_ed.Text + "','" + cb_satuan.Text + "','" + tb_hargabeli.Text + "','" + tb_jumlah.Text + "','" + tbdisc.Text + "','" + tb_harga.Text + "','" + tbnamabarang.Text + "')"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()

            tbkodebarang.Text = " "
            tbnamabarang.Text = " "
            tbbatch.Text = " "
            tb_ed.Text = " "
            cb_satuan.Text = " "
            tb_hargabeli.Text = "0"
            tb_jumlah.Text = "0"
            tbdisc.Text = "0"
            tb_harga.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "'"
            connect.Open()
            adapter = New MySqlDataAdapter(query, connect)
            ds = New DataSet
            ds.Clear()
            adapter.Fill(ds)
            connect.Close()
            dgv_barangbeli.DataSource = ds
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub
End Class