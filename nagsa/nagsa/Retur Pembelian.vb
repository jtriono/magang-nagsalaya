Imports MySql.Data.MySqlClient
Public Class Retur_Pembelian
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim autogenerate As String
    Dim harga As String
    Dim harga2 As Integer = 0
    Dim harga3 As Integer = 0
    Dim dt3 As New DataTable
    Dim numtakenout As String
    Dim pilih As String
    Dim masuk As String

    Private Sub Retur_Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tbtotalharga.Font = New Font(tbtotalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        tbno_nota.Font = New Font(tbno_nota.Font.FontFamily, 15)
        Label3.Font = New Font(Label2.Font.FontFamily, 15)
        dtppilihtanggal.Font = New Font(dtppilihtanggal.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 15)
        tbnopembelian.Font = New Font(tbnopembelian.Font.FontFamily, 15)
        Label5.Font = New Font(Label5.Font.FontFamily, 15)
        tbkode_supplier.Font = New Font(tbkode_supplier.Font.FontFamily, 15)

        tbtotalharga.Enabled = False
        tbno_nota.Enabled = False

        tbnopembelian.Text = " "
        tbkode_supplier.Text = " "
        tbtotalharga.Text = "0"

        Try
            autogenerate = ""
            dt = New DataTable
            query = "select no_retur_pembelian from retur_pembelian"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "0000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "00" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "0" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnkoreksi_Click(sender As Object, e As EventArgs) Handles btnkoreksi.Click
        tbno_nota.Enabled = True
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Try
            dt = New DataTable
            query = "insert into detail_retur_beli where kode_barang = '" + masuk + "'"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        dt = New DataTable
        query = "update detail_pembelian set `delete` = 1 where kode_barang_pembelian = '" + masuk + "'"
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian ='" + tbnopembelian.Text + "' and `delete` = 0 and retur = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            dt = New DataTable
            query = "insert into retur_pembelian values('" + tbno_nota.Text + "','" + dtppilihtanggal.Value.ToString("yyyy-MM-dd") + "','" + tbkode_supplier.Text + "','" + tbtotalharga.Text + "',0,'" + tbnopembelian.Text + "')"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Masuk")

            autogenerate = ""
            dt = New DataTable
            query = "select no_retur_pembelian from retur_pembelian"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "0000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "00" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "0" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
            dtppilihtanggal.Value = DateTime.Now
            tbkode_supplier.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbno_nota_TextChanged(sender As Object, e As EventArgs) Handles tbno_nota.TextChanged
        Try
            dt2 = New DataTable
            query = "select no_retur_pembelian, tanggal_retur_pembelian, kode_supplier, totalharga_retur_pembelian,no_nota_pembelian from retur_pembelian where no_retur_pembelian = '" + tbno_nota.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            dtppilihtanggal.Value = dt2.Rows(0).Item("tanggal_retur_pembelian").ToString
            tbnopembelian.Text = dt2.Rows(0).Item("no_nota_pembelian")
            tbkode_supplier.Text = dt2.Rows(0).Item("kode_supplier")
            tbtotalharga.Text = dt2.Rows(0).Item("totalharga_retur_pembelian").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian ='" + tbnopembelian.Text + "' and `delete` = 0 and retur = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvdetailbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetailbarang.CellContentClick
        masuk = dgvdetailbarang.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        dt = New DataTable
        query = "update detail_retur_beli set `delete` = 1 where kode_barang = '" + pilih + "'"
        If MessageBox.Show("Yakin akan melakukan delete?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Dihapus")
        End If


        dt.Clear()
        harga = "select sum(total_harga) from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
        command = New MySqlCommand(harga, connect)
        adapter = New MySqlDataAdapter(command)
        adapter.Fill(dt)
        tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")


        dt3.Clear()
        query = "select * from detail_retur_beli where no_nota_pembelian = '" + tbnopembelian.Text + "' and `delete` = 0"
        command = New MySqlCommand(query, connect)
        adapter = New MySqlDataAdapter(command)
        adapter.Fill(dt3)
        dgvreturbeli.DataSource = dt3

    End Sub

    Private Sub dgvreturbeli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreturbeli.CellContentClick
        pilih = dgvreturbeli.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian ='" + tbnopembelian.Text + "' and `delete` = 0 and retur = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class