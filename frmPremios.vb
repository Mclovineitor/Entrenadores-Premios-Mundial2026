Public Class frmPremios
    Private premios As New List(Of String)
    
    Private Sub frmPremios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Gestionar Premios"
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.Size = New Size(800, 650)
        
        CrearControles()
        CargarPremios()
    End Sub
    
    Private Sub CrearControles()
        ' Título
        Dim lblTitulo As New Label()
        lblTitulo.Text = "REGISTRO DE PREMIOS"
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
        
        ' Etiqueta Tipo de Premio
        Dim lblTipoPremio As New Label()
        lblTipoPremio.Text = "Tipo de Premio:"
        lblTipoPremio.Top = 15
        lblTipoPremio.Left = 15
        pnlDatos.Controls.Add(lblTipoPremio)
        
        Dim cmbTipo As New ComboBox()
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Top = 35
        cmbTipo.Left = 15
        cmbTipo.Width = 200
        cmbTipo.Items.AddRange({"Campeón", "Subcampeón", "Tercer Lugar", "Mejor Portero", "Goleador"})
        pnlDatos.Controls.Add(cmbTipo)
        
        ' Etiqueta Equipo Ganador
        Dim lblEquipo As New Label()
        lblEquipo.Text = "Equipo Ganador:"
        lblEquipo.Top = 15
        lblEquipo.Left = 250
        pnlDatos.Controls.Add(lblEquipo)
        
        Dim txtEquipo As New TextBox()
        txtEquipo.Name = "txtEquipo"
        txtEquipo.Top = 35
        txtEquipo.Left = 250
        txtEquipo.Width = 200
        pnlDatos.Controls.Add(txtEquipo)
        
        ' Etiqueta Monto del Premio
        Dim lblMonto As New Label()
        lblMonto.Text = "Monto (Millones USD):"
        lblMonto.Top = 15
        lblMonto.Left = 480
        pnlDatos.Controls.Add(lblMonto)
        
        Dim nudMonto As New NumericUpDown()
        nudMonto.Name = "nudMonto"
        nudMonto.Top = 35
        nudMonto.Left = 480
        nudMonto.Width = 150
        nudMonto.Minimum = 0
        nudMonto.Maximum = 1000
        pnlDatos.Controls.Add(nudMonto)
        
        ' Etiqueta Descripción
        Dim lblDescripcion As New Label()
        lblDescripcion.Text = "Descripción:"
        lblDescripcion.Top = 70
        lblDescripcion.Left = 15
        pnlDatos.Controls.Add(lblDescripcion)
        
        Dim txtDescripcion As New TextBox()
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Top = 90
        txtDescripcion.Left = 15
        txtDescripcion.Width = 450
        pnlDatos.Controls.Add(txtDescripcion)
        
        ' Botón Agregar
        Dim btnAgregar As New Button()
        btnAgregar.Text = "Agregar"
        btnAgregar.BackColor = Color.FromArgb(0, 150, 255)
        btnAgregar.ForeColor = Color.White
        btnAgregar.Width = 100
        btnAgregar.Height = 40
        btnAgregar.Top = 90
        btnAgregar.Left = 480
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
        btnLimpiar.Left = 590
        AddHandler btnLimpiar.Click, AddressOf btnLimpiar_Click
        pnlDatos.Controls.Add(btnLimpiar)
        
        ' ListBox para mostrar premios
        Dim lstPremios As New ListBox()
        lstPremios.Name = "lstPremios"
        lstPremios.Top = 270
        lstPremios.Left = 20
        lstPremios.Width = Me.Width - 60
        lstPremios.Height = 250
        Me.Controls.Add(lstPremios)
        
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
        Dim cmbTipo = pnl.Controls("cmbTipo")
        Dim txtEquipo = pnl.Controls("txtEquipo")
        Dim nudMonto = pnl.Controls("nudMonto")
        Dim txtDescripcion = pnl.Controls("txtDescripcion")
        
        If cmbTipo.SelectedIndex = -1 Or String.IsNullOrEmpty(txtEquipo.Text) Then
            MessageBox.Show("Por favor completa todos los campos", "Validación")
            Return
        End If
        
        Dim premio = $"{cmbTipo.SelectedItem} - {txtEquipo.Text} - ${nudMonto.Value}M - {txtDescripcion.Text}"
        premios.Add(premio)
        
        MessageBox.Show("Premio agregado exitosamente", "Éxito")
        CargarPremios()
        LimpiarFormulario()
    End Sub
    
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarFormulario()
    End Sub
    
    Private Sub LimpiarFormulario()
        Dim pnl = Me.Controls("pnlDatos")
        pnl.Controls("cmbTipo").SelectedIndex = -1
        pnl.Controls("txtEquipo").Text = ""
        pnl.Controls("nudMonto").Value = 0
        pnl.Controls("txtDescripcion").Text = ""
    End Sub
    
    Private Sub CargarPremios()
        Dim lst = Me.Controls("lstPremios")
        lst.Items.Clear()
        For Each premio In premios
            lst.Items.Add(premio)
        Next
    End Sub
    
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Dim frm As New frmMenuPrincipal()
        frm.Show()
        Me.Close()
    End Sub
End Class
