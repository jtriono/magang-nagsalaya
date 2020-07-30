Imports MySql.Data.MySqlClient
Public Class Retur_Penjualan
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
    Dim dt4 As New DataTable
    Dim dt5 As New DataTable
    Dim numtakenout As String
    Dim pilih As String
    Dim masuk As String
    Dim simpandetail As String

    Private Sub Retur_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tbtotalharga.Font = New Font(tbtotalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        tbno_nota.Font = New Font(tbno_nota.Font.FontFamily, 15)
        Label3.Font = New Font(Label3.Font.FontFamily, 15)
        tbnopenjualan.Font = New Font(tbnopenjualan.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 15)
        dtppilihtanggal.Font = New Font(dtppilihtanggal.Font.FontFamily, 15)
        Label5.Font = New Font(Label5.Font.FontFamily, 15)
        tbkode_cust.Font = New Font(tbkode_cust.Font.FontFamily, 15)

        tbno_nota.Enabled = False
        tbtotalharga.Enabled = False

        tbnopenjualan.Text = " "
        tbkode_cust.Text = " "
        tbtotalharga.Text = "0"

        Try
            autogenerate = ""
            dt = New DataTable
            query = "select no_retur_penjualan from retur_penjualan"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "6880000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "688000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "68800" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "6880" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "688" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_retur_jual where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_jual where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturjual.DataSource = dt3
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
            query = "update detail_penjualan set retur = 1 where no_nota_penjualan = '" + tbnopenjualan.Text + "' and kode_barang = '" + masuk + "'"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Dim baliktanggal As String = dt4.Rows(simpandetail).Item(3)
        Dim tahun As String = baliktanggal.Substring(6, 4)
        Dim bulan As String = baliktanggal.Substring(3, 2)
        Dim tgl As String = baliktanggal.Substring(0, 2)
        Dim tglbaru As String = tahun + "-" + bulan + "-" + tgl

        query = "insert into detail_retur_jual values('" + dt4.Rows(simpandetail).Item(0) + "','" + dt4.Rows(simpandetail).Item(1) + "','" + dt4.Rows(simpandetail).Item(2) + "','" + tglbaru + "','" + dt4.Rows(simpandetail).Item(4) + "','" + dt4.Rows(simpandetail).Item(5).ToString + "','" + dt4.Rows(simpandetail).Item(6).ToString + "','" + dt4.Rows(simpandetail).Item(7).ToString + "','" + dt4.Rows(simpandetail).Item(8).ToString + "','" + dt4.Rows(simpandetail).Item(9) + "',0,1)"
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_penjualan where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception
        End Try

        Try
            dt5.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt5)
            dgvreturjual.DataSource = dt5
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan ='" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 0"
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
            query = "insert into retur_penjualan values('" + tbno_nota.Text + "','" + dtppilihtanggal.Value.ToString("yyyy-MM-dd") + "','" + tbkode_cust.Text + "','" + tbtotalharga.Text + "',0,'" + tbnopenjualan.Text + "')"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Masuk")

            autogenerate = ""
            dt = New DataTable
            query = "select no_retur_penjualan from retur_penjualan"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "6880000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "688000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "68800" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "6880" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "688" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
            dtppilihtanggal.Value = DateTime.Now
            tbkode_cust.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_jual where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturjual.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


       
    End Sub

    Private Sub tbno_nota_TextChanged(sender As Object, e As EventArgs) Handles tbno_nota.TextChanged
        Try
            dt2 = New DataTable
            query = "select no_retur_penjualan, tanggal_retur_penjualan, kode_cust, totalharga_retur_penjualan,no_nota_penjualan from retur_penjualan where no_retur_penjualan = '" + tbno_nota.Text + "'"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            dtppilihtanggal.Value = dt2.Rows(0).Item("tanggal_retur_penjualan").ToString
            tbnopenjualan.Text = dt2.Rows(0).Item("no_nota_penjualan")
            tbkode_cust.Text = dt2.Rows(0).Item("kode_cust")
            tbtotalharga.Text = dt2.Rows(0).Item("totalharga_retur_penjualan").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try

        Try
            dt.Clear()
            harga = "select sum(total_harga) from detail_retur_jual where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)")
        Catch ex As Exception

        End Try

        Try
            dt3.Clear()
            query = "select * from detail_retur_jual where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
            dgvreturjual.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dt3.Clear()
            query = "select * from detail_penjualan where no_nota_penjualan ='" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 0"
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
        simpandetail = dgvdetailbarang.CurrentRow.Index
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        dt = New DataTable
        query = "update detail_penjualan set retur = 0 where kode_barang = '" + pilih + "'"
        If MessageBox.Show("Yakin akan melakukan delete?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Berhasil Dihapus")
        End If

        query = "delete from detail_retur_jual where kode_barang='" + dt4.Rows(simpandetail).Item(0) + "' and no_nota_penjualan='" + dt4.Rows(simpandetail).Item(1) + "'"
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()

            dt.Clear()
        harga = "select sum(total_harga) from detail_penjualan where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(harga, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
        tbtotalharga.Text = dt.Rows(0).Item("sum(total_harga)").ToString


            dt3.Clear()
        query = "select * from detail_penjualan where no_nota_penjualan = '" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 1"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt3)
        dgvreturjual.DataSource = dt3

        dt4.Clear()
        query = "select * from detail_penjualan where no_nota_penjualan ='" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 0"
        command = New MySqlCommand(query, connect)
        adapter = New MySqlDataAdapter(command)
        adapter.Fill(dt4)
        dgvdetailbarang.DataSource = dt4

    End Sub

    Private Sub dgvreturjual_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreturjual.CellContentClick
        pilih = dgvreturjual.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            dt4.Clear()
            query = "select * from penjualan where no_nota_penjualan='" + tbnopenjualan.Text + "' and `delete`=0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt4)
            tbkode_cust.Text = dt4.Rows(0).Item("kode_customer").ToString
            dt4 = New DataTable
            query = "select * from detail_penjualan where no_nota_penjualan ='" + tbnopenjualan.Text + "' and `delete` = 0 and retur = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt4)
            dgvdetailbarang.DataSource = dt4
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class