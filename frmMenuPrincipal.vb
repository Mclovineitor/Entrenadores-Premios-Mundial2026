Public Class frmMenuPrincipal
    Inherits Form
    
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "Menú Principal - Entrenadores y Premios 2026"
        Me.Size = New Size(700, 550)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub
    
    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearControles()
    End Sub
    
    Private Sub CrearControles()
        ' Título
        Dim lblTitulo As New Label()
        lblTitulo.Text = "MENÚ PRINCIPAL"
        lblTitulo.Font = New Font("Arial", 28, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(10, 50, 100)
        lblTitulo.AutoSize = False
        lblTitulo.Width = Me.Width
        lblTitulo.Height = 60
        lblTitulo.Top = 30
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblTitulo)
        
        ' Botón Entrenadores
        Dim btnEntrenadores As New Button()
        btnEntrenadores.Text = "Gestionar Entrenadores"
        btnEntrenadores.Font = New Font("Arial", 13, FontStyle.Bold)
        btnEntrenadores.BackColor = Color.FromArgb(0, 150, 255)
        btnEntrenadores.ForeColor = Color.White
        btnEntrenadores.Width = 250
        btnEntrenadores.Height = 60
        btnEntrenadores.Top = 120
        btnEntrenadores.Left = (Me.Width - btnEntrenadores.Width) \ 2
        btnEntrenadores.Cursor = Cursors.Hand
        AddHandler btnEntrenadores.Click, AddressOf btnEntrenadores_Click
        Me.Controls.Add(btnEntrenadores)
        
        ' Botón Premios
        Dim btnPremios As New Button()
        btnPremios.Text = "Gestionar Premios"
        btnPremios.Font = New Font("Arial", 13, FontStyle.Bold)
        btnPremios.BackColor = Color.FromArgb(0, 180, 100)
        btnPremios.ForeColor = Color.White
        btnPremios.Width = 250
        btnPremios.Height = 60
        btnPremios.Top = btnEntrenadores.Top + btnEntrenadores.Height + 20
        btnPremios.Left = (Me.Width - btnPremios.Width) \ 2
        btnPremios.Cursor = Cursors.Hand
        AddHandler btnPremios.Click, AddressOf btnPremios_Click
        Me.Controls.Add(btnPremios)
        
        ' Botón Volver
        Dim btnVolver As New Button()
        btnVolver.Text = "Volver"
        btnVolver.Font = New Font("Arial", 12, FontStyle.Bold)
        btnVolver.BackColor = Color.FromArgb(255, 150, 0)
        btnVolver.ForeColor = Color.White
        btnVolver.Width = 150
        btnVolver.Height = 50
        btnVolver.Top = btnPremios.Top + btnPremios.Height + 30
        btnVolver.Left = (Me.Width - btnVolver.Width) \ 2
        btnVolver.Cursor = Cursors.Hand
        AddHandler btnVolver.Click, AddressOf btnVolver_Click
        Me.Controls.Add(btnVolver)
        
        ' Botón Salir
        Dim btnSalir As New Button()
        btnSalir.Text = "Salir"
        btnSalir.Font = New Font("Arial", 12, FontStyle.Bold)
        btnSalir.BackColor = Color.FromArgb(255, 100, 100)
        btnSalir.ForeColor = Color.White
        btnSalir.Width = 150
        btnSalir.Height = 50
        btnSalir.Top = btnVolver.Top + btnVolver.Height + 10
        btnSalir.Left = (Me.Width - btnSalir.Width) \ 2
        btnSalir.Cursor = Cursors.Hand
        AddHandler btnSalir.Click, AddressOf btnSalir_Click
        Me.Controls.Add(btnSalir)
    End Sub
    
    Private Sub btnEntrenadores_Click(sender As Object, e As EventArgs)
        Dim frm As New frmEntrenadores()
        frm.Show()
        Me.Close()
    End Sub
    
    Private Sub btnPremios_Click(sender As Object, e As EventArgs)
        Dim frm As New frmPremios()
        frm.Show()
        Me.Close()
    End Sub
    
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Dim frm As New frmBienvenida()
        frm.Show()
        Me.Close()
    End Sub
    
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class
