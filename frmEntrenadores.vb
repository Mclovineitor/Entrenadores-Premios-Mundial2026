Public Class frmEntrenadores
    Inherits Form
    Private entrenadores As New List(Of String)
    
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "Gestionar Entrenadores"
        Me.Size = New Size(800, 650)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub
    
    Private Sub frmEntrenadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearControles()
        CargarEntrenadores()
    End Sub
    
    Private Sub CrearControles()
        ' Título
        Dim lblTitulo As New Label()
        lblTitulo.Text = "REGISTRO DE ENTRENADORES"
        lblTitulo.Font = New Font("Arial", 20, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(10, 50, 100)
        lblTitulo.Top = 20
        lblTitulo.Left = 20
        lblTitulo.AutoSize = True
        Me.Controls.Add(lblTitulo)
        
        ' Panel de datos
        Dim pnlDatos As New Panel()
        pnlDatos.Name = "pnlDatos"
        pnlDatos.BorderStyle = BorderStyle.FixedSingle
        pnlDatos.BackColor = Color.White
        pnlDatos.Top = 70
        pnlDatos.Left = 20
        pnlDatos.Width = Me.Width - 60
        pnlDatos.Height = 180
        Me.Controls.Add(pnlDatos)
        
        ' Nombre
        Dim lblNombre As New Label()
        lblNombre.Text = "Nombre del Entrenador:"
        lblNombre.Top = 15
        lblNombre.Left = 15
        pnlDatos.Controls.Add(lblNombre)
        
        Dim txtNombre As New TextBox()
        txtNombre.Name = "txtNombre"
        txtNombre.Top = 35
        txtNombre.Left = 15
        txtNombre.Width = 250
        pnlDatos.Controls.Add(txtNombre)
        
        ' País
        Dim lblPais As New Label()
        lblPais.Text = "País:"
        lblPais.Top = 15
        lblPais.Left = 300
        pnlDatos.Controls.Add(lblPais)
        
        Dim txtPais As New TextBox()
        txtPais.Name = "txtPais"
        txtPais.Top = 35
        txtPais.Left = 300
        txtPais.Width = 200
        pnlDatos.Controls.Add(txtPais)
        
        ' Equipo
        Dim lblEquipo As New Label()
        lblEquipo.Text = "Equipo:"
        lblEquipo.Top = 15
        lblEquipo.Left = 530
        pnlDatos.Controls.Add(lblEquipo)
        
        Dim txtEquipo As New TextBox()
        txtEquipo.Name = "txtEquipo"
        txtEquipo.Top = 35
        txtEquipo.Left = 530
        txtEquipo.Width = 200
        pnlDatos.Controls.Add(txtEquipo)
        
        ' Años
        Dim lblExperiencia As New Label()
        lblExperiencia.Text = "Años de Experiencia:"
        lblExperiencia.Top = 70
        lblExperiencia.Left = 15
        pnlDatos.Controls.Add(lblExperiencia)
        
        Dim nudExperiencia As New NumericUpDown()
        nudExperiencia.Name = "nudExperiencia"
        nudExperiencia.Top = 90
        nudExperiencia.Left = 15
        nudExperiencia.Width = 100
        nudExperiencia.Minimum = 0
        nudExperiencia.Maximum = 60
        pnlDatos.Controls.Add(nudExperiencia)
        
        ' Botón Agregar
        Dim btnAgregar As New Button()
        btnAgregar.Text = "Agregar"
        btnAgregar.BackColor = Color.FromArgb(0, 150, 255)
        btnAgregar.ForeColor = Color.White
        btnAgregar.Width = 100
        btnAgregar.Height = 40
        btnAgregar.Top = 90
        btnAgregar.Left = 300
        AddHandler btnAgregar.Click, AddressOf btnAgregar_Click
        pnlDatos.Controls.Add(btnAgregar)
        
        ' Botón Limpiar
        Dim btnLimpiar As New Button()
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.BackColor = Color.FromArgb(150, 150, 150)
        btnLimpiar.ForeColor = Color.White
        btnLimpiar.Width = 100
        btnLimpiar.Height = 40
        btnLimpiar.Top = 90
        btnLimpiar.Left = 420
        AddHandler btnLimpiar.Click, AddressOf btnLimpiar_Click
        pnlDatos.Controls.Add(btnLimpiar)
        
        ' ListBox
        Dim lstEntrenadores As New ListBox()
        lstEntrenadores.Name = "lstEntrenadores"
        lstEntrenadores.Top = 270
        lstEntrenadores.Left = 20
        lstEntrenadores.Width = Me.Width - 60
        lstEntrenadores.Height = 250
        Me.Controls.Add(lstEntrenadores)
        
        ' Botón Volver
        Dim btnVolver As New Button()
        btnVolver.Text = "Volver al Menú"
        btnVolver.BackColor = Color.FromArgb(255, 150, 0)
        btnVolver.ForeColor = Color.White
        btnVolver.Width = 150
        btnVolver.Height = 50
        btnVolver.Top = Me.Height - 80
        btnVolver.Left = (Me.Width - btnVolver.Width) \ 2
        AddHandler btnVolver.Click, AddressOf btnVolver_Click
        Me.Controls.Add(btnVolver)
    End Sub
    
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Dim pnl = Me.Controls("pnlDatos")
        Dim txtNombre = pnl.Controls("txtNombre")
        Dim txtPais = pnl.Controls("txtPais")
        Dim txtEquipo = pnl.Controls("txtEquipo")
        Dim nudExperiencia = pnl.Controls("nudExperiencia")
        
        If String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtPais.Text) Then
            MessageBox.Show("Por favor completa todos los campos", "Validación")
            Return
        End If
        
        Dim entrenador = $"{txtNombre.Text} | {txtPais.Text} | {txtEquipo.Text} | {nudExperiencia.Value} años"
        entrenadores.Add(entrenador)
        
        MessageBox.Show("Entrenador agregado exitosamente", "Éxito")
        CargarEntrenadores()
        LimpiarFormulario()
    End Sub
    
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarFormulario()
    End Sub
    
    Private Sub LimpiarFormulario()
        Dim pnl = Me.Controls("pnlDatos")
        pnl.Controls("txtNombre").Text = ""
        pnl.Controls("txtPais").Text = ""
        pnl.Controls("txtEquipo").Text = ""
        pnl.Controls("nudExperiencia").Value = 0
    End Sub
    
    Private Sub CargarEntrenadores()
        Dim lst = Me.Controls("lstEntrenadores")
        lst.Items.Clear()
        For Each entrenador In entrenadores
            lst.Items.Add(entrenador)
        Next
    End Sub
    
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Dim frm As New frmMenuPrincipal()
        frm.Show()
        Me.Close()
    End Sub
End Class
