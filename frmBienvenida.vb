Public Class frmBienvenida
    Private Sub frmBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Bienvenida - Entrenadores y Premios 2026"
        Me.BackColor = Color.FromArgb(10, 50, 100)
        Me.Size = New Size(700, 550)
        Me.ControlBox = True
        
        ' Título principal
        Dim lblTitulo As New Label()
        lblTitulo.Text = "MUNDIAL 2026"
        lblTitulo.Font = New Font("Arial", 48, FontStyle.Bold)
        lblTitulo.ForeColor = Color.White
        lblTitulo.AutoSize = False
        lblTitulo.Width = Me.Width
        lblTitulo.Height = 100
        lblTitulo.Top = 40
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblTitulo)
        
        ' Subtítulo
        Dim lblSubtitulo As New Label()
        lblSubtitulo.Text = "Entrenadores y Premios"
        lblSubtitulo.Font = New Font("Arial", 24, FontStyle.Regular)
        lblSubtitulo.ForeColor = Color.LightCyan
        lblSubtitulo.AutoSize = False
        lblSubtitulo.Width = Me.Width
        lblSubtitulo.Height = 50
        lblSubtitulo.Top = lblTitulo.Top + lblTitulo.Height + 10
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblSubtitulo)
        
        ' Descripción
        Dim lblDescripcion As New Label()
        lblDescripcion.Text = "Aplicación de Gestión de Información"
        lblDescripcion.Font = New Font("Arial", 14)
        lblDescripcion.ForeColor = Color.LightGray
        lblDescripcion.AutoSize = False
        lblDescripcion.Width = Me.Width
        lblDescripcion.Height = 40
        lblDescripcion.Top = lblSubtitulo.Top + lblSubtitulo.Height + 20
        lblDescripcion.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblDescripcion)
        
        ' Botón Ingresar
        Dim btnIngresar As New Button()
        btnIngresar.Text = "Ingresar al Sistema"
        btnIngresar.Font = New Font("Arial", 14, FontStyle.Bold)
        btnIngresar.BackColor = Color.FromArgb(0, 150, 255)
        btnIngresar.ForeColor = Color.White
        btnIngresar.Width = 250
        btnIngresar.Height = 60
        btnIngresar.Top = lblDescripcion.Top + lblDescripcion.Height + 80
        btnIngresar.Left = (Me.Width - btnIngresar.Width) \ 2
        btnIngresar.Cursor = Cursors.Hand
        AddHandler btnIngresar.Click, AddressOf btnIngresar_Click
        Me.Controls.Add(btnIngresar)
        
        ' Botón Salir
        Dim btnSalir As New Button()
        btnSalir.Text = "Salir"
        btnSalir.Font = New Font("Arial", 12, FontStyle.Bold)
        btnSalir.BackColor = Color.FromArgb(255, 100, 100)
        btnSalir.ForeColor = Color.White
        btnSalir.Width = 150
        btnSalir.Height = 50
        btnSalir.Top = btnIngresar.Top + btnIngresar.Height + 15
        btnSalir.Left = (Me.Width - btnSalir.Width) \ 2
        btnSalir.Cursor = Cursors.Hand
        AddHandler btnSalir.Click, AddressOf btnSalir_Click
        Me.Controls.Add(btnSalir)
    End Sub
    
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)
        Dim frm As New frmMenuPrincipal()
        frm.Show()
        Me.Close()
    End Sub
    
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class
