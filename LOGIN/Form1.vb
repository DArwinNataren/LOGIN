Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim usuario As String = TxtUsuario.Text.Trim()
        Dim contraseña As String = TxtContraseña.Text.Trim()

        ' Verificar que el nombre de usuario y la contraseña no estén vacíos
        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña.")
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT Usuario, Contraseña FROM Registro WHERE Usuario = @Usuario AND Contraseña = @Contraseña"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.Parameters.AddWithValue("@Contraseña", contraseña)

                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    Form2.Show()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos.")
                End If
            End Using
        End Using
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Form3.Show()
    End Sub
End Class
