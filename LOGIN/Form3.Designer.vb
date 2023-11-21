<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TxtUsuario = New TextBox()
        Label1 = New Label()
        TxtContraseña = New TextBox()
        Label7 = New Label()
        btnCrear = New Button()
        SuspendLayout()
        ' 
        ' txtCarrera
        ' 
        txtCarrera.Location = New Point(201, 182)
        txtCarrera.Name = "txtCarrera"
        txtCarrera.Size = New Size(274, 27)
        txtCarrera.TabIndex = 36
        ' 
        ' txtMatricula
        ' 
        txtMatricula.Location = New Point(201, 149)
        txtMatricula.Name = "txtMatricula"
        txtMatricula.Size = New Size(274, 27)
        txtMatricula.TabIndex = 35
        ' 
        ' txtApellidoMaterno
        ' 
        txtApellidoMaterno.Location = New Point(201, 111)
        txtApellidoMaterno.Name = "txtApellidoMaterno"
        txtApellidoMaterno.Size = New Size(274, 27)
        txtApellidoMaterno.TabIndex = 34
        ' 
        ' txtApellidoPaterno
        ' 
        txtApellidoPaterno.Location = New Point(201, 74)
        txtApellidoPaterno.Name = "txtApellidoPaterno"
        txtApellidoPaterno.Size = New Size(274, 27)
        txtApellidoPaterno.TabIndex = 33
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(201, 39)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(274, 27)
        txtNombre.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 191)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 20)
        Label6.TabIndex = 31
        Label6.Text = "CARRERA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 20)
        Label5.TabIndex = 30
        Label5.Text = "NUMERO DE CONTROL "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 20)
        Label4.TabIndex = 29
        Label4.Text = "APELLIDO PATERNO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 20)
        Label3.TabIndex = 28
        Label3.Text = "APELLIDO MATERNO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 27
        Label2.Text = "NOMBRE(s)"
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(201, 228)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(274, 27)
        TxtUsuario.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 37
        Label1.Text = "USUARIO"
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Location = New Point(201, 275)
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.Size = New Size(274, 27)
        TxtContraseña.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 284)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 20)
        Label7.TabIndex = 39
        Label7.Text = "CONTRASEÑA"
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(298, 345)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(94, 29)
        btnCrear.TabIndex = 41
        btnCrear.Text = "CREAR"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCrear)
        Controls.Add(TxtContraseña)
        Controls.Add(Label7)
        Controls.Add(TxtUsuario)
        Controls.Add(Label1)
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
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCrear As Button
End Class
