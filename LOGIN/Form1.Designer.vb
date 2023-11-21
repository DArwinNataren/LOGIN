<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TxtUsuario = New TextBox()
        TxtContraseña = New TextBox()
        BtnIngresar = New Button()
        BtnRegistrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(75, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 22)
        Label1.TabIndex = 0
        Label1.Text = "USUARIO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(42, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 22)
        Label2.TabIndex = 1
        Label2.Text = "CONTRASEÑA"
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TxtUsuario.Location = New Point(165, 64)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(232, 28)
        TxtUsuario.TabIndex = 2
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        TxtContraseña.Location = New Point(165, 119)
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.Size = New Size(232, 28)
        TxtContraseña.TabIndex = 3
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresar.ForeColor = Color.MidnightBlue
        BtnIngresar.Location = New Point(152, 180)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(107, 38)
        BtnIngresar.TabIndex = 4
        BtnIngresar.Text = "INGRESAR"
        BtnIngresar.UseVisualStyleBackColor = True
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnRegistrar.ForeColor = Color.MidnightBlue
        BtnRegistrar.Location = New Point(290, 180)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(107, 38)
        BtnRegistrar.TabIndex = 5
        BtnRegistrar.Text = "REGISTRAR"
        BtnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(539, 344)
        Controls.Add(BtnRegistrar)
        Controls.Add(BtnIngresar)
        Controls.Add(TxtContraseña)
        Controls.Add(TxtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnRegistrar As Button
End Class
