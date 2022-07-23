Imports System.Data.SqlClient

Public Class Form1
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String
    Public Sub New()
        InitializeComponent()

        Me.Text = "Cadastro De Pessoas Com SQL SERVER"
        Label_Titulo.Text = "Teste com Banco de Dados"
        Label_ID.Text = "Id:"
        Label_NOME.Text = "Nome:"
        Label_NUMERO.Text = "Numero: "
    End Sub

    Private Sub Button_AdicionarDados_Click(sender As Object, e As EventArgs) Handles Button_AdicionarDados.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=Cliente; User Id=sa;Password=123")
            strSQL = "INSERT INTO [dbo].[Cliente] ([NOME], [NUMERO]) VALUES (@NOME, @NUMERO)"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@NOME", TextBox_NOME.Text)
            comando.Parameters.AddWithValue("@numero", TextBox_NUMERO.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
            TextBox_ID.Text = ""
            TextBox_NOME.Text = ""
            TextBox_NUMERO.Text = ""
        End Try
    End Sub

    Private Sub Button_Exibir_Click(sender As Object, e As EventArgs) Handles Button_Exibir.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=Cliente; User Id=sa;Password=123")
            strSQL = "SELECT * FROM [dbo].[Cliente]"
            comando = New SqlCommand(strSQL, conexao)
            da = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
            TextBox_ID.Text = ""
            TextBox_NOME.Text = ""
            TextBox_NUMERO.Text = ""
        End Try
    End Sub

    Private Sub Button_Consultar_Click(sender As Object, e As EventArgs) Handles Button_Consultar.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=Cliente; User Id=sa;Password=123")
            strSQL = "SELECT * FROM [dbo].[Cliente] WHERE [ID] = @ID"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", TextBox_ID.Text)
            conexao.Open()
            dr = comando.ExecuteReader

            Do While dr.Read
                TextBox_NOME.Text = dr("nome")
                TextBox_NUMERO.Text = dr("numero")
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
            dr = Nothing
        End Try
    End Sub

    Private Sub Button_EditarDados_Click(sender As Object, e As EventArgs) Handles Button_EditarDados.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=Cliente; User Id=sa;Password=123")
            strSQL = "UPDATE [Cliente] SET [NOME] = @NOME, [NUMERO] = @NUMERO WHERE [ID] = @ID"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@NOME", TextBox_NOME.Text)
            comando.Parameters.AddWithValue("@NUMERO", TextBox_NUMERO.Text)
            comando.Parameters.AddWithValue("@ID", TextBox_ID.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
            TextBox_ID.Text = ""
            TextBox_NOME.Text = ""
            TextBox_NUMERO.Text = ""
        End Try
    End Sub

    Private Sub Button_Excluir_Click(sender As Object, e As EventArgs) Handles Button_Excluir.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=Cliente; User Id=sa;Password=123")
            strSQL = "DELETE FROM [Cliente] WHERE [ID] = @ID"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", TextBox_ID.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
            TextBox_ID.Text = ""
            TextBox_NOME.Text = ""
            TextBox_NUMERO.Text = ""
        End Try
    End Sub
End Class
