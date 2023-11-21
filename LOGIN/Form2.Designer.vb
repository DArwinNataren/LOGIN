<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        btnEliminar = New Button()
        btnActualizar = New Button()
        btnBuscar = New Button()
        btnCrear = New Button()
        txtCarrera = New TextBox()
        txtMatricula = New TextBox()
        txtApellidoMaterno = New TextBox()
        txtApellidoPaterno = New TextBox()
        txtNombre = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ButtonFace
        DataGridView1.Location = New Point(463, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(658, 238)
        DataGridView1.TabIndex = 31
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(363, 284)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(94, 29)
        btnEliminar.TabIndex = 30
        btnEliminar.Text = "BORRAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(249, 284)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(94, 29)
        btnActualizar.TabIndex = 29
        btnActualizar.Text = "ACTUALIZAR"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(131, 284)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 29)
        btnBuscar.TabIndex = 28
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(13, 284)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(94, 29)
        btnCrear.TabIndex = 27
        btnCrear.Text = "CREAR"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' txtCarrera
        ' 
        txtCarrera.Location = New Point(183, 218)
        txtCarrera.Name = "txtCarrera"
        txtCarrera.Size = New Size(274, 27)
        txtCarrera.TabIndex = 26
        ' 
        ' txtMatricula
        ' 
        txtMatricula.Location = New Point(183, 185)
        txtMatricula.Name = "txtMatricula"
        txtMatricula.Size = New Size(274, 27)
        txtMatricula.TabIndex = 25
        ' 
        ' txtApellidoMaterno
        ' 
        txtApellidoMaterno.Location = New Point(183, 147)
        txtApellidoMaterno.Name = "txtApellidoMaterno"
        txtApellidoMaterno.Size = New Size(274, 27)
        txtApellidoMaterno.TabIndex = 24
        ' 
        ' txtApellidoPaterno
        ' 
        txtApellidoPaterno.Location = New Point(183, 110)
        txtApellidoPaterno.Name = "txtApellidoPaterno"
        txtApellidoPaterno.Size = New Size(274, 27)
        txtApellidoPaterno.TabIndex = 23
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(183, 75)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(274, 27)
        txtNombre.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 20)
        Label6.TabIndex = 21
        Label6.Text = "CARRERA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 20)
        Label5.TabIndex = 20
        Label5.Text = "NUMERO DE CONTROL "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 20)
        Label4.TabIndex = 19
        Label4.Text = "APELLIDO PATERNO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 20)
        Label3.TabIndex = 18
        Label3.Text = "APELLIDO MATERNO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 17
        Label2.Text = "NOMBRE(s)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(76, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(491, 22)
        Label1.TabIndex = 16
        Label1.Text = "INSTITUTO TECNOLOGICO SUPERIOR DE CINTALAPA"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1130, 402)
        Controls.Add(DataGridView1)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnBuscar)
        Controls.Add(btnCrear)
        Controls.Add(txtCarrera)
        Controls.Add(txtMatricula)
        Controls.Add(txtApellidoMaterno)
        Controls.Add(txtApellidoPaterno)
        Controls.Add(txtNombre)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
