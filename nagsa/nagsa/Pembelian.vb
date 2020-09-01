Imports MySql.Data.MySqlClient
Public Class Formpembelian
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
    Dim simpanjumlahstok As String

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

        tb_kodesupplier.Text = ""

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

        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv_barangbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and  `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tb_totalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        Formsupplier.pilihsupplier = True
        Formsupplier.ShowDialog()
        tb_kodesupplier.Text = Formsupplier.suppliertest
        Try
            dt2 = New DataTable
            query = "select supplierid from supplier where supplierid = '" + tb_kodesupplier.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            dt = New DataTable
            query = "insert into pembelian values('" + tb_nonota.Text + "','" + dtptanggal.Value.ToString("yyyy-MM-dd") + "','" + tb_kodesupplier.Text + "','" + dtp_jt.Value.ToString("yyyy-MM-dd") + "','" + tb_totalharga.Text + "',0)"
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
            tb_kodesupplier.Text = ""
            dtp_jt.Value = DateTime.Now
            dtptanggal.Value = DateTime.Now
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv_barangbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btn_koreksi_Click(sender As Object, e As EventArgs) Handles btn_koreksi.Click
        tb_nonota.Enabled = True
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Try
            dt = New DataTable
            query = "insert into detail_pembelian values('" + tbkodebarang.Text + "','" + tb_nonota.Text + "','" + tbbatch.Text + "','" + tb_ed.Text + "','" + cb_satuan.Text + "','" + tb_hargabeli.Text + "','" + tb_jumlah.Text + "','" + tbdisc.Text + "','" + tb_harga.Text + "','" + tbnamabarang.Text + "',0,0)"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        query = "update barang set stokakhir=stokakhir + '" + tb_jumlah.Text + "' where itemid='" + tbkodebarang.Text + "'"
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

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and  `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tb_totalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv_barangbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

    End Sub

    Private Sub tb_nonota_TextChanged(sender As Object, e As EventArgs) Handles tb_nonota.TextChanged
        Try
            dt2 = New DataTable
            query = "select no_nota_pembelian, tanggal_pembelian, kode_supplier, tanggal_jt_pembelian, total_harga_pembelian from pembelian where no_nota_pembelian = '" + tb_nonota.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            dtptanggal.Value = dt2.Rows(0).Item("tanggal_pembelian").ToString
            tb_kodesupplier.Text = dt2.Rows(0).Item("kode_supplier")
            dtp_jt.Value = dt2.Rows(0).Item("tanggal_jt_pembelian").ToString
            tb_totalharga.Text = dt2.Rows(0).Item("total_harga_pembelian").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv_barangbeli.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_penjualan where no_nota_pembelian = '" + tb_nonota.Text + "' and  `delete` = 0"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tb_totalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_jumlah_TextChanged(sender As Object, e As EventArgs) Handles tb_jumlah.TextChanged
        Try
            harga2 = 0
            If harga2 = 0 Then
                harga2 = CInt(tb_hargabeli.Text) * CInt(tb_jumlah.Text)
            Else
                harga2 = 0
                harga2 = CInt(tb_hargabeli.Text) * CInt(tb_jumlah.Text)
            End If
            tb_harga.Text = harga2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbdisc_TextChanged(sender As Object, e As EventArgs) Handles tbdisc.TextChanged
        Try
            harga3 = 0
            If tb_harga.Text = harga2 Then
                harga3 = (CInt(tb_harga.Text) * (CInt(tbdisc.Text) / 100))
            ElseIf tb_harga.Text <> harga2 Then
                harga3 = 0
                tb_harga.Text = harga2
                harga3 = (CInt(tb_harga.Text) * (CInt(tbdisc.Text) / 100))
            End If
            tbhargadisc.Text = harga3
            harga3 = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbhargadisc_TextChanged(sender As Object, e As EventArgs) Handles tbhargadisc.TextChanged
        tb_harga.Text = CInt(tb_harga.Text) - CInt(tbhargadisc.Text)
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Formbarang.pilihbarang = True
        Formbarang.ShowDialog()
        tbkodebarang.Text = Formbarang.itemtest
        Try
            dt2 = New DataTable
            query = "select itemid, nama, hargabeli, nobatch, expiredate, satuan from barang where itemid = '" + tbkodebarang.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            tbnamabarang.Text = dt2.Rows(0).Item("nama")
            tb_hargabeli.Text = dt2.Rows(0).Item("hargabeli")
            tbbatch.Text = dt2.Rows(0).Item("nobatch")
            tb_ed.Text = dt2.Rows(0).Item("expiredate")
            cb_satuan.Text = dt2.Rows(0).Item("satuan")
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click



        If MessageBox.Show("Yakin akan melakukan delete?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            dt.Clear()
            query = "select sum(jumlah_barang) from detail_pembelian where kode_barang_pembelian='" + pilih + "' and no_nota_pembelian='" + tb_nonota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            simpanjumlahstok = dt.Rows(0).Item("sum(jumlah_barang)").ToString



            query = "update detail_pembelian set `delete` = 1 where kode_barang_pembelian = '" + pilih + "'"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()

            query = "update barang set stokakhir=stokakhir-'" + simpanjumlahstok + "' where itemid='" + pilih + "'"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()

            MessageBox.Show("Data Berhasil Dihapus")


        End If



        dt3.Clear()
        query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
        command = New MySqlCommand(query, connect)
        adapter = New MySqlDataAdapter(command)
        adapter.Fill(dt3)
        dgv_barangbeli.DataSource = dt3




        dt.Clear()
        harga = "select sum(total_harga) from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
        command = New MySqlCommand(harga, connect)
        adapter = New MySqlDataAdapter(command)
        adapter.Fill(dt)
        tb_totalharga.Text = dt.Rows(0).Item("sum(total_harga)")

    End Sub

    Private Sub dgv_barangbeli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_barangbeli.CellContentClick
        pilih = dgv_barangbeli.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btnsimpanhutang_Click(sender As Object, e As EventArgs) Handles btnsimpanhutang.Click
        If tb_kodesupplier.Text = "" Then
            MessageBox.Show("Lengkapi data terlebih dahulu")
        Else
            Try
                dt = New DataTable
                query = "insert into hutang values('" + tb_nonota.Text + "','" + tb_kodesupplier.Text + "','" + tb_totalharga.Text + "','" + dtptanggal.Value + "',0)"
                connect.Open()
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Data Berhasil Masuk")

                dt = New DataTable
                query = "insert into pembelian values('" + tb_nonota.Text + "','" + dtptanggal.Value.ToString("yyyy-MM-dd") + "','" + tb_kodesupplier.Text + "','" + dtp_jt.Value.ToString("yyyy-MM-dd") + "','" + tb_totalharga.Text + "',0,0)"
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
                tb_kodesupplier.Text = ""
                dtp_jt.Value = DateTime.Now
                dtptanggal.Value = DateTime.Now
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                dt3.Clear()
                query = "select * from detail_pembelian where no_nota_pembelian = '" + tb_nonota.Text + "' and `delete` = 0"
                adapter = New MySqlDataAdapter(query, connect)
                adapter = New MySqlDataAdapter(command)
                adapter.Fill(dt3)
                dgv_barangbeli.DataSource = dt3
            Catch ex As Exception
                MsgBox(ex.Message)
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            dt = New DataTable
            query = "insert into pembelian values('" + tb_nonota.Text + "','" + dtptanggal.Value.ToString("yyyy-MM-dd") + "','" + tb_kodesupplier.Text + "','" + dtp_jt.Value.ToString("yyyy-MM-dd") + "','" + tb_totalharga.Text + "',0)"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Masuk")
        Catch ex As Exception
            connect.Close()
        End Try
        Print_Menu_Pembelian.ShowDialog()
    End Sub
End Class