Imports System.Data.SqlClient

Public Class Form3
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        ' Obtén los valores de los TextBoxes
        Dim nombre As String = txtNombre.Text
        Dim apellidoPaterno As String = txtApellidoPaterno.Text
        Dim apellidoMaterno As String = txtApellidoMaterno.Text
        Dim matricula As Integer = 0
        Dim usuario As String = TxtUsuario.Text
        Dim contraseña As String = TxtContraseña.Text

        ' Verifica si la matrícula es un número válido
        If Integer.TryParse(txtMatricula.Text, matricula) Then
            Dim carrera As String = txtCarrera.Text

            ' Establece la cadena de conexión
            Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"

            ' Crea una nueva conexión SqlConnection
            Using connection As New SqlConnection(connectionString)
                ' Crea la consulta SQL para insertar el nuevo registroDim query As String = "INSERT INTO Registro (Nombre, [Apellido Paterno], [Apellido Materno], Matricula, Carrera) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Matricula, @Carrera)"
                Dim query As String = "INSERT INTO Registro (Nombre, [Apellido Paterno], [Apellido Materno], [Numero de control], Carrera, Usuario, Contraseña) 
VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @NumeroDeControl, @Carrera, @Usuario, @Contraseña)"
                ' Crea un objeto SqlCommand con la consulta SQL y la conexión
                Using command As New SqlCommand(query, connection)
                    ' Agrega los parámetros a la consulta SQL
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno)
                    command.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno)
                    command.Parameters.AddWithValue("@NumeroDeControl", matricula)
                    command.Parameters.AddWithValue("@Carrera", carrera)
                    command.Parameters.AddWithValue("@Usuario", usuario)
                    command.Parameters.AddWithValue("@Contraseña", contraseña)

                    ' Abre la conexión
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario registrado correctamente.")
                        ' Puedes realizar acciones adicionales después de registrar al usuario
                    Else
                        MessageBox.Show("Error al registrar el usuario.")
                    End If

                    ' Cierra la conexión
                    connection.Close()
                    ' Muestra un mensaje indicando que el registro ha sido creado
                    MessageBox.Show("Nuevo registro creado correctamente.")
                End Using
            End Using
        Else
            ' Muestra un mensaje si la matrícula no es un número válido
            MessageBox.Show("Por favor, ingrese una matrícula válida (números enteros).")
        End If
        txtNombre.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtMatricula.Text = ""
        txtCarrera.Text = ""
        TxtUsuario.Text = ""
        TxtContraseña.Text = ""



    End Sub
End Class