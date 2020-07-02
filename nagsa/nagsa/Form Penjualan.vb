Imports MySql.Data.MySqlClient
Public Class Formpenjualan
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



    Private Sub Formpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tbtotalharga.Font = New Font(tbtotalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        Label3.Font = New Font(Label3.Font.FontFamily, 15)
        tbno_nota.Font = New Font(tbno_nota.Font.FontFamily, 15)
        tbno_pajak.Font = New Font(tbno_pajak.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 11)
        dtppilihtanggal.Font = New Font(dtppilihtanggal.Font.FontFamily, 11)
        Label5.Font = New Font(Label5.Font.FontFamily, 11)
        tbkode_cust.Font = New Font(tbkode_cust.Font.FontFamily, 11)
        Label6.Font = New Font(Label6.Font.FontFamily, 11)
        dtpjatuh_tempo.Font = New Font(dtpjatuh_tempo.Font.FontFamily, 11)


        dtpjatuh_tempo.Value = DateTime.Now
        dtppilihtanggal.Value = DateTime.Now

        tbnamabarang.Enabled = False
        tbtotalrp.Enabled = False
        tbno_nota.Enabled = False
        tbtotalharga.Enabled = False

        tbno_pajak.Text = ""
        tbkode_cust.Text = ""
        tbtotalharga.Text = "0"


        Try
            autogenerate = ""
            dt = New DataTable
            query = "select no_nota_penjualan from penjualan"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "81700000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "8170000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "817000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "81700" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "8170" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000000 Then
                autogenerate = autogenerate + "817" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnkoreksi_Click(sender As Object, e As EventArgs) Handles btnkoreksi.Click
        tbno_nota.Enabled = True
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Try
            dt = New DataTable
            query = "insert into detail_penjualan values('" + tbkodebarang.Text + "','" + tbno_nota.Text + "','" + tbbatch.Text + "','" + tb_ed.Text + "','" + cbsatuan.Text + "','" + tbhargajual.Text + "','" + tbjumlah.Text + "','" + tbdisc.Text + "','" + tbtotalrp.Text + "','" + tbnamabarang.Text + "', 0)"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            tbkodebarang.Text = " "
            tbnamabarang.Text = " "
            tbbatch.Text = " "
            tb_ed.Text = " "
            tbtotalrp.Text = "0"
            cbsatuan.Text = " "
            tbhargajual.Text = "0"
            tbjumlah.Text = "0"
            tbdisc.Text = "0"
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
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
            query = "insert into penjualan values('" + tbno_nota.Text + "','" + tbno_pajak.Text + "','" + dtppilihtanggal.Value.ToString("yyyy-MM-dd") + "','" + tbkode_cust.Text + "','" + dtpjatuh_tempo.Value.ToString("yyyy-MM-dd").ToString + "','" + tbtotalharga.Text + "',0)"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Masuk")

            autogenerate = ""
            dt = New DataTable
            query = "select no_pajak from penjualan"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "81700000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "8170000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "817000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "81700" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "8170" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000000 Then
                autogenerate = autogenerate + "817" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
            tbtotalharga.Text = "0"
            tbno_pajak.Text = " "
            tbkode_cust.Text = " "
            dtpjatuh_tempo.Value = DateTime.Now
            dtppilihtanggal.Value = DateTime.Now
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbdisc_TextChanged(sender As Object, e As EventArgs) Handles tbdisc.TextChanged
        Try
            harga3 = 0
            If tbtotalrp.Text = harga2 Then
                harga3 = (CInt(tbtotalrp.Text) * (CInt(tbdisc.Text) / 100))
            ElseIf tbtotalrp.Text <> harga2 Then
                harga3 = 0
                tbtotalrp.Text = harga2
                harga3 = (CInt(tbtotalrp.Text) * (CInt(tbdisc.Text) / 100))
            End If
            tbhargadisc.Text = harga3
            harga3 = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            dt = New DataTable
            query = "update detail_penjualan set `delete` = 1 where kode_barang = '" + dgvdetailbarang.SelectedRows.ToString + "'"
            If MessageBox.Show("Yakin akan melakukan delete?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Data Berhasil Dihapus")
            End If
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Formbarang.pilihbarang = True
        Formbarang.ShowDialog()
        tbkodebarang.Text = Formbarang.itemtest
        Try
            dt2 = New DataTable
            query = "select itemid, nama, hargajual, nobatch, expiredate, satuan from barang where itemid = '" + tbkodebarang.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            tbnamabarang.Text = dt2.Rows(0).Item("nama")
            tbhargajual.Text = dt2.Rows(0).Item("hargajual")
            tbbatch.Text = dt2.Rows(0).Item("nobatch")
            tb_ed.Text = dt2.Rows(0).Item("expiredate")
            cbsatuan.Text = dt2.Rows(0).Item("satuan")
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub tbno_nota_TextChanged(sender As Object, e As EventArgs) Handles tbno_nota.TextChanged
        Try
            dt2 = New DataTable
            query = "select no_nota_penjualan, no_pajak, tanggal_penjualan, kode_customer, tanggal_jt_penjualan, total_harga_penjualan from penjualan where no_nota_penjualan = '" + tbno_nota.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            tbno_pajak.Text = dt2.Rows(0).Item("no_pajak")
            dtppilihtanggal.Value = dt2.Rows(0).Item("tanggal_penjualan").ToString
            tbkode_cust.Text = dt2.Rows(0).Item("kode_customer")
            dtpjatuh_tempo.Value = dt2.Rows(0).Item("tanggal_jt_penjualan").ToString
            tbtotalharga.Text = dt2.Rows(0).Item("total_harga_penjualan").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        'Try
        '    query = "select * from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "'"
        '    connect.Open()
        '    adapter = New MySqlDataAdapter(query, connect)
        '    dt3 = New DataTable
        '    dt3.Clear()
        '    adapter.Fill(dt3)
        '    connect.Close()
        '    dgvdetailbarang.DataSource = dt3
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvdetailbarang.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_penjualan where no_nota_penjualan = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbjumlah_TextChanged(sender As Object, e As EventArgs) Handles tbjumlah.TextChanged
        Try
            harga2 = 0
            If harga2 = 0 Then
                harga2 = CInt(tbhargajual.Text) * CInt(tbjumlah.Text)
            Else
                harga2 = 0
                harga2 = CInt(tbhargajual.Text) * CInt(tbjumlah.Text)
            End If
            tbtotalrp.Text = harga2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbhargadisc_TextChanged(sender As Object, e As EventArgs) Handles tbhargadisc.TextChanged
        tbtotalrp.Text = CInt(tbtotalrp.Text) - CInt(tbhargadisc.Text)
    End Sub
End Class