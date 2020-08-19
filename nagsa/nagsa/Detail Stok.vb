Imports MySql.Data.MySqlClient
Public Class Detail_Stok
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Dim dt4 As New DataTable
    Dim pilih As String

    Private Sub Detail_Stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_ed.Value = DateTime.Now
        dtp_tanggal.Value = DateTime.Now

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If rbbeli.Checked = True Then
            query = "insert into detail_stok value('" + tbkode.Text + "','" + tbnama.Text + "','" + tbbatch.Text + "','" + dtp_ed.Value + "','" + tbjumlah.Text + "','" + dtp_tanggal.Value + "','Pembelian',0,'" + tbno_nota.Text + "')"
        ElseIf rbjual.Checked = True Then
            query = "insert into detail_stok value('" + tbkode.Text + "','" + tbnama.Text + "','" + tbbatch.Text + "','" + dtp_ed.Value + "','" + tbjumlah.Text + "','" + dtp_tanggal.Value + "','Penjualan',0,'" + tbno_nota.Text + "')"
        End If
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Data Berhasil Masuk")
        tbkode.Text = " "
        tbnama.Text = " "
        tbbatch.Text = " "
        dtp_ed.Value = DateTime.Now
        tbjumlah.Text = " "
        dtp_tanggal.Value = DateTime.Now

        Try
            dt.Clear()
            query = "select * from detail_stok where no_nota = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            dgv1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If rbbeli.Checked = True Then
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian ='" + tbno_nota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv2.DataSource = dt3
        ElseIf rbjual.Checked = True Then
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan='" + tbno_nota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv2.DataSource = dt3
        End If

        Try
            dt.Clear()
            query = "select * from detail_stok where no_nota = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            dgv1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Formbarang.pilihbarang = True
        Formbarang.ShowDialog()
        tbkode.Text = Formbarang.itemtest
        Try
            dt2 = New DataTable
            query = "select itemid, nama, nobatch, expiredate from barang where itemid = '" + tbkode.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            tbnama.Text = dt2.Rows(0).Item("nama")
            tbbatch.Text = dt2.Rows(0).Item("nobatch")
            dtp_ed.Value = dt2.Rows(0).Item("expiredate")
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btncari_nota_Click(sender As Object, e As EventArgs) Handles btncari_nota.Click
        If rbbeli.Checked = True Then
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian ='" + tbno_nota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv2.DataSource = dt3
        ElseIf rbjual.Checked = True Then
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan='" + tbno_nota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv2.DataSource = dt3
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        tbno_nota.Text = " "
        If rbbeli.Checked = True Then
            dt3.Clear()
            query = "select * from detail_pembelian where no_nota_pembelian ='" + tbno_nota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv2.DataSource = dt3
        ElseIf rbjual.Checked = True Then
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan='" + tbno_nota.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgv2.DataSource = dt3
        End If

            dt.Clear()
            query = "select * from detail_stok where no_nota = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            dgv1.DataSource = dt
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        dt = New DataTable
        query = "update detail_stok set `delete` = 0 where kode_barang = '" + pilih + "'"
        If MessageBox.Show("Yakin akan melakukan delete?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Dihapus")
        End If

        Try
            dt.Clear()
            query = "select * from detail_stok where no_nota = '" + tbno_nota.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            dgv1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        pilih = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Print_Detail_Stok.ShowDialog()
    End Sub
End Class