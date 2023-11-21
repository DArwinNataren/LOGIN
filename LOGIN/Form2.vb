
Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"
    Dim connection As SqlConnection = New SqlConnection(connectionString)
    'Boton para crear un registro en la base de datos
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        ' Obtén los valores de los TextBoxes
        Dim nombre As String = txtNombre.Text
        Dim apellidoPaterno As String = txtApellidoPaterno.Text
        Dim apellidoMaterno As String = txtApellidoMaterno.Text
        Dim matricula As Integer = 0

        ' Verifica si la matrícula es un número válido
        If Integer.TryParse(txtMatricula.Text, matricula) Then
            Dim carrera As String = txtCarrera.Text

            ' Establece la cadena de conexión
            Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"

            ' Crea una nueva conexión SqlConnection
            Using connection As New SqlConnection(connectionString)
                ' Crea la consulta SQL para insertar el nuevo registroDim query As String = "INSERT INTO Registro (Nombre, [Apellido Paterno], [Apellido Materno], Matricula, Carrera) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Matricula, @Carrera)"
                Dim query As String = "INSERT INTO Registro (Nombre, [Apellido Paterno], [Apellido Materno], [Numero de control], Carrera) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @NumeroDeControl, @Carrera)"

                ' Crea un objeto SqlCommand con la consulta SQL y la conexión
                Using command As New SqlCommand(query, connection)
                    ' Agrega los parámetros a la consulta SQL
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno)
                    command.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno)
                    command.Parameters.AddWithValue("@NumeroDeControl", matricula)
                    command.Parameters.AddWithValue("@Carrera", carrera)

                    ' Abre la conexión
                    connection.Open()

                    ' Ejecuta la consulta SQL (inserta el nuevo registro en la base de datos)
                    command.ExecuteNonQuery()

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

    End Sub
    ' Botón para buscar un registro por matrícula
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Obtén el valor de búsqueda ingresado por el usuario
        Dim valorBusqueda As String = InputBox("Ingrese el dato a buscar")
        ' Establece la cadena de conexión
        Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"

        ' Crea una nueva conexión SqlConnection
        Using connection As New SqlConnection(connectionString)
            ' Crea la consulta SQL para buscar el registro en la base de datos
            Dim query As String = "SELECT * FROM Registro WHERE Nombre LIKE @ValorBusqueda OR [Apellido Paterno] LIKE @ValorBusqueda OR [Apellido Materno] LIKE @ValorBusqueda OR [Numero de control] LIKE @ValorBusqueda OR Carrera LIKE @ValorBusqueda"

            ' Crea un objeto SqlCommand con la consulta SQL y la conexión
            Using command As New SqlCommand(query, connection)
                ' Agrega el parámetro de búsqueda a la consulta SQL
                command.Parameters.AddWithValue("@ValorBusqueda", "%" & valorBusqueda & "%")

                Try
                    ' Abre la conexión
                    connection.Open()

                    ' Ejecuta la consulta SQL y obtén el primer resultado
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    ' Verifica si hay resultados
                    If reader.Read() Then
                        ' Asigna los datos encontrados a los TextBoxes
                        txtNombre.Text = reader("Nombre").ToString()
                        txtApellidoPaterno.Text = reader("Apellido Paterno").ToString()
                        txtApellidoMaterno.Text = reader("Apellido Materno").ToString()
                        txtMatricula.Text = reader("Numero de control").ToString()
                        txtCarrera.Text = reader("Carrera").ToString()

                        ' Muestra un mensaje indicando que el registro ha sido encontrado
                        MessageBox.Show("Registro encontrado.")
                    Else
                        ' Muestra un mensaje si no se encontraron registros
                        MessageBox.Show("No se encontraron registros para la búsqueda proporcionada.")
                    End If

                    ' Cierra el lector y la conexión
                    reader.Close()
                    connection.Close()

                Catch ex As Exception
                    ' Muestra un mensaje si hay un error en la base de datos
                    MessageBox.Show("Error al buscar el registro: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    ' Botón para actualizar un registro existente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' Obtén la matrícula ingresada por el usuario
        Dim matricula As Integer = 0
        If Integer.TryParse(txtMatricula.Text, matricula) Then
            ' Obtén los nuevos valores de los TextBoxes
            Dim nombre As String = txtNombre.Text
            Dim apellidoPaterno As String = txtApellidoPaterno.Text
            Dim apellidoMaterno As String = txtApellidoMaterno.Text
            Dim carrera As String = txtCarrera.Text

            ' Establece la cadena de conexión
            Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"

            ' Crea una nueva conexión SqlConnection
            Using connection As New SqlConnection(connectionString)
                ' Crea la consulta SQL para actualizar el registro existente basado en la matrícula
                Dim query As String = "UPDATE Registro SET Nombre = @Nombre, [Apellido Paterno] = @ApellidoPaterno, [Apellido Materno] = @ApellidoMaterno, Carrera = @Carrera WHERE [Numero de control] = @Matricula"

                ' Crea un objeto SqlCommand con la consulta SQL y la conexión
                Using command As New SqlCommand(query, connection)
                    ' Agrega los parámetros a la consulta SQL
                    command.Parameters.AddWithValue("@Nombre", nombre)
                    command.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno)
                    command.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno)
                    command.Parameters.AddWithValue("@Carrera", carrera)
                    command.Parameters.AddWithValue("@Matricula", matricula)

                    Try
                        ' Abre la conexión
                        connection.Open()

                        ' Ejecuta la consulta SQL (actualiza el registro en la base de datos)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Cierra la conexión
                        connection.Close()

                        ' Verifica si se actualizó el registro
                        If rowsAffected > 0 Then
                            ' Muestra un mensaje indicando que el registro ha sido actualizado
                            MessageBox.Show("Registro actualizado correctamente.")
                            ' Recarga los datos en el DataGridView después de la actualización
                            LoadData()
                        Else
                            ' Muestra un mensaje si no se encontró el registro para actualizar
                            MessageBox.Show("No se encontró el registro para actualizar.")
                        End If
                    Catch ex As Exception
                        ' Muestra un mensaje si hay un error en la base de datos
                        MessageBox.Show("Error al actualizar el registro: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            ' Muestra un mensaje si la matrícula no es un número válido
            MessageBox.Show("Por favor, ingrese una matrícula válida (números enteros) para buscar.")
        End If
        txtNombre.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtMatricula.Text = ""
        txtCarrera.Text = ""
    End Sub
    ' Botón para eliminar un registro existente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim matricula As Integer

        ' Verifica si la matrícula es un número válido
        If Integer.TryParse(txtMatricula.Text, matricula) Then
            ' Establece la cadena de conexión
            Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"

            ' Crea una nueva conexión SqlConnection
            Using connection As New SqlConnection(connectionString)
                ' Crea la consulta SQL para eliminar el registro basado en el número de control
                Dim query As String = "DELETE FROM Registro WHERE [Numero de control] = @NumeroDeControl"

                ' Crea un objeto SqlCommand con la consulta SQL y la conexión
                Using command As New SqlCommand(query, connection)
                    ' Agrega el parámetro a la consulta SQL
                    command.Parameters.AddWithValue("@NumeroDeControl", matricula)

                    Try
                        ' Abre la conexión
                        connection.Open()

                        ' Ejecuta la consulta SQL (elimina el registro de la base de datos)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Cierra la conexión
                        connection.Close()

                        ' Verifica si se eliminó el registro
                        If rowsAffected > 0 Then
                            ' Muestra un mensaje indicando que el registro ha sido eliminado
                            MessageBox.Show("Registro eliminado correctamente.")
                        Else
                            ' Muestra un mensaje si no se encontró el registro para eliminar
                            MessageBox.Show("No se encontró el registro para eliminar.")
                        End If
                    Catch ex As Exception
                        ' Muestra un mensaje si hay un error en la base de datos
                        MessageBox.Show("Error al eliminar el registro: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            ' Muestra un mensaje si la matrícula no es un número válido
            MessageBox.Show("Por favor, ingrese una matrícula válida (números enteros) para eliminar.")
        End If
        txtNombre.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtMatricula.Text = ""
        txtCarrera.Text = ""
        ' Recargar datos en el DataGridView después de la eliminación (si es necesario)
        ' LoadData()
    End Sub

    ' Temporizador para actualizar el DataGridView cada 2 segundos (2000 milisegundos)
    Dim WithEvents timer As New Timer With {.Interval = 2000}

    ' Método para cargar datos en el DataGridView al cargar el formulario y configurar el temporizador
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        ' Inicia el temporizador
        timer.Start()
    End Sub

    ' Manejador de eventos para el temporizador (se ejecuta cada vez que el temporizador se dispara)
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Carga datos en el DataGridView
        LoadData()
    End Sub
    Private Sub LoadData()
        ' Establece la cadena de conexión
        Dim connectionString As String = "Data Source=DARWINAMAURY;Initial Catalog=Practica;Integrated Security=True"
        ' Crea una nueva conexión SqlConnection
        Using connection As New SqlConnection(connectionString)
            ' Crea la consulta SQL para seleccionar los datos de la tabla
            Dim query As String = "SELECT * FROM Registro"

            ' Crea un adaptador de datos y un DataTable para almacenar los resultados de la consulta
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()

            Try
                ' Abre la conexión y llena el DataTable con los datos de la tabla
                connection.Open()
                adapter.Fill(table)
            Catch ex As Exception
                ' Muestra un mensaje si hay un error al cargar los datos
                MessageBox.Show("Error al cargar los datos: " & ex.Message)
            Finally
                ' Cierra la conexión
                connection.Close()
            End Try

            ' Asigna el DataTable al DataGridView
            DataGridView1.DataSource = table
        End Using
    End Sub
End Class