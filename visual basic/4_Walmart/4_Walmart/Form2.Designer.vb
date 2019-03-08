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
        Me.components = New System.ComponentModel.Container()
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim Nom_ClienteLabel As System.Windows.Forms.Label
        Dim Apellido_ClienteLabel As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim SaldoLabel As System.Windows.Forms.Label
        Dim Fecha_de_nacimientoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim RecidenciaLabel As System.Windows.Forms.Label
        Dim No_TarjetaLabel As System.Windows.Forms.Label
        Dim PagoLabel As System.Windows.Forms.Label
        Dim CambioLabel As System.Windows.Forms.Label
        Dim Ultimo_registroLabel As System.Windows.Forms.Label
        Dim Usuario_walmartLabel As System.Windows.Forms.Label
        Dim Pass_walmartLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._4_WalmartDataSet = New _4_Walmart._4_WalmartDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New _4_Walmart._4_WalmartDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New _4_Walmart._4_WalmartDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.DPITextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.RecidenciaTextBox = New System.Windows.Forms.TextBox()
        Me.No_TarjetaTextBox = New System.Windows.Forms.TextBox()
        Me.PagoTextBox = New System.Windows.Forms.TextBox()
        Me.CambioTextBox = New System.Windows.Forms.TextBox()
        Me.Ultimo_registroTextBox = New System.Windows.Forms.TextBox()
        Me.Usuario_walmartTextBox = New System.Windows.Forms.TextBox()
        Me.Pass_walmartTextBox = New System.Windows.Forms.TextBox()
        IdClienteLabel = New System.Windows.Forms.Label()
        Nom_ClienteLabel = New System.Windows.Forms.Label()
        Apellido_ClienteLabel = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        SaldoLabel = New System.Windows.Forms.Label()
        Fecha_de_nacimientoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        RecidenciaLabel = New System.Windows.Forms.Label()
        No_TarjetaLabel = New System.Windows.Forms.Label()
        PagoLabel = New System.Windows.Forms.Label()
        CambioLabel = New System.Windows.Forms.Label()
        Ultimo_registroLabel = New System.Windows.Forms.Label()
        Usuario_walmartLabel = New System.Windows.Forms.Label()
        Pass_walmartLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._4_WalmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(11, 384)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(54, 13)
        IdClienteLabel.TabIndex = 51
        IdClienteLabel.Text = "Id Cliente:"
        '
        'Nom_ClienteLabel
        '
        Nom_ClienteLabel.AutoSize = True
        Nom_ClienteLabel.Location = New System.Drawing.Point(11, 410)
        Nom_ClienteLabel.Name = "Nom_ClienteLabel"
        Nom_ClienteLabel.Size = New System.Drawing.Size(67, 13)
        Nom_ClienteLabel.TabIndex = 53
        Nom_ClienteLabel.Text = "Nom Cliente:"
        '
        'Apellido_ClienteLabel
        '
        Apellido_ClienteLabel.AutoSize = True
        Apellido_ClienteLabel.Location = New System.Drawing.Point(11, 436)
        Apellido_ClienteLabel.Name = "Apellido_ClienteLabel"
        Apellido_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Apellido_ClienteLabel.TabIndex = 55
        Apellido_ClienteLabel.Text = "Apellido Cliente:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(11, 462)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(23, 13)
        NitLabel.TabIndex = 57
        NitLabel.Text = "Nit:"
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(11, 488)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(28, 13)
        DPILabel.TabIndex = 59
        DPILabel.Text = "DPI:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Location = New System.Drawing.Point(11, 514)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(35, 13)
        EdadLabel.TabIndex = 61
        EdadLabel.Text = "Edad:"
        '
        'SaldoLabel
        '
        SaldoLabel.AutoSize = True
        SaldoLabel.Location = New System.Drawing.Point(11, 540)
        SaldoLabel.Name = "SaldoLabel"
        SaldoLabel.Size = New System.Drawing.Size(35, 13)
        SaldoLabel.TabIndex = 63
        SaldoLabel.Text = "saldo:"
        '
        'Fecha_de_nacimientoLabel
        '
        Fecha_de_nacimientoLabel.AutoSize = True
        Fecha_de_nacimientoLabel.Location = New System.Drawing.Point(11, 567)
        Fecha_de_nacimientoLabel.Name = "Fecha_de_nacimientoLabel"
        Fecha_de_nacimientoLabel.Size = New System.Drawing.Size(109, 13)
        Fecha_de_nacimientoLabel.TabIndex = 65
        Fecha_de_nacimientoLabel.Text = "Fecha de nacimiento:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(371, 388)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 67
        DireccionLabel.Text = "Direccion:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(371, 414)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 69
        PaisLabel.Text = "Pais:"
        '
        'RecidenciaLabel
        '
        RecidenciaLabel.AutoSize = True
        RecidenciaLabel.Location = New System.Drawing.Point(371, 440)
        RecidenciaLabel.Name = "RecidenciaLabel"
        RecidenciaLabel.Size = New System.Drawing.Size(64, 13)
        RecidenciaLabel.TabIndex = 71
        RecidenciaLabel.Text = "Recidencia:"
        '
        'No_TarjetaLabel
        '
        No_TarjetaLabel.AutoSize = True
        No_TarjetaLabel.Location = New System.Drawing.Point(371, 466)
        No_TarjetaLabel.Name = "No_TarjetaLabel"
        No_TarjetaLabel.Size = New System.Drawing.Size(60, 13)
        No_TarjetaLabel.TabIndex = 73
        No_TarjetaLabel.Text = "No Tarjeta:"
        '
        'PagoLabel
        '
        PagoLabel.AutoSize = True
        PagoLabel.Location = New System.Drawing.Point(371, 492)
        PagoLabel.Name = "PagoLabel"
        PagoLabel.Size = New System.Drawing.Size(35, 13)
        PagoLabel.TabIndex = 75
        PagoLabel.Text = "Pago:"
        '
        'CambioLabel
        '
        CambioLabel.AutoSize = True
        CambioLabel.Location = New System.Drawing.Point(371, 518)
        CambioLabel.Name = "CambioLabel"
        CambioLabel.Size = New System.Drawing.Size(44, 13)
        CambioLabel.TabIndex = 77
        CambioLabel.Text = "cambio:"
        '
        'Ultimo_registroLabel
        '
        Ultimo_registroLabel.AutoSize = True
        Ultimo_registroLabel.Location = New System.Drawing.Point(371, 544)
        Ultimo_registroLabel.Name = "Ultimo_registroLabel"
        Ultimo_registroLabel.Size = New System.Drawing.Size(76, 13)
        Ultimo_registroLabel.TabIndex = 79
        Ultimo_registroLabel.Text = "Ultimo registro:"
        '
        'Usuario_walmartLabel
        '
        Usuario_walmartLabel.AutoSize = True
        Usuario_walmartLabel.Location = New System.Drawing.Point(371, 570)
        Usuario_walmartLabel.Name = "Usuario_walmartLabel"
        Usuario_walmartLabel.Size = New System.Drawing.Size(85, 13)
        Usuario_walmartLabel.TabIndex = 81
        Usuario_walmartLabel.Text = "Usuario walmart:"
        '
        'Pass_walmartLabel
        '
        Pass_walmartLabel.AutoSize = True
        Pass_walmartLabel.Location = New System.Drawing.Point(371, 596)
        Pass_walmartLabel.Name = "Pass_walmartLabel"
        Pass_walmartLabel.Size = New System.Drawing.Size(72, 13)
        Pass_walmartLabel.TabIndex = 83
        Pass_walmartLabel.Text = "Pass walmart:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Aqua
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(246, 660)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(233, 53)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Finalizar registro, Regresar a Inicio."
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 118)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        '_4_WalmartDataSet
        '
        Me._4_WalmartDataSet.DataSetName = "_4_WalmartDataSet"
        Me._4_WalmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me._4_WalmartDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.MercaderiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _4_Walmart._4_WalmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(760, 25)
        Me.ClientesBindingNavigator.TabIndex = 51
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(12, 155)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(728, 220)
        Me.ClientesDataGridView.TabIndex = 51
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_Cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom_Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido_Cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido_Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nit"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nit"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DPI"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DPI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Edad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "saldo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "saldo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fecha_de_nacimiento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha_de_nacimiento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Pais"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pais"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Recidencia"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Recidencia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "No_Tarjeta"
        Me.DataGridViewTextBoxColumn12.HeaderText = "No_Tarjeta"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Pago"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Pago"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "cambio"
        Me.DataGridViewTextBoxColumn14.HeaderText = "cambio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ultimo_registro"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ultimo_registro"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Usuario_walmart"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Usuario_walmart"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Pass_walmart"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Pass_walmart"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "IdCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(126, 381)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdClienteTextBox.TabIndex = 52
        '
        'Nom_ClienteTextBox
        '
        Me.Nom_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nom_Cliente", True))
        Me.Nom_ClienteTextBox.Location = New System.Drawing.Point(126, 407)
        Me.Nom_ClienteTextBox.Name = "Nom_ClienteTextBox"
        Me.Nom_ClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nom_ClienteTextBox.TabIndex = 54
        '
        'Apellido_ClienteTextBox
        '
        Me.Apellido_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellido_Cliente", True))
        Me.Apellido_ClienteTextBox.Location = New System.Drawing.Point(126, 433)
        Me.Apellido_ClienteTextBox.Name = "Apellido_ClienteTextBox"
        Me.Apellido_ClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Apellido_ClienteTextBox.TabIndex = 56
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nit", True))
        Me.NitTextBox.Location = New System.Drawing.Point(126, 459)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NitTextBox.TabIndex = 58
        '
        'DPITextBox
        '
        Me.DPITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DPI", True))
        Me.DPITextBox.Location = New System.Drawing.Point(126, 485)
        Me.DPITextBox.Name = "DPITextBox"
        Me.DPITextBox.Size = New System.Drawing.Size(200, 20)
        Me.DPITextBox.TabIndex = 60
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Edad", True))
        Me.EdadTextBox.Location = New System.Drawing.Point(126, 511)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EdadTextBox.TabIndex = 62
        '
        'SaldoTextBox
        '
        Me.SaldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "saldo", True))
        Me.SaldoTextBox.Location = New System.Drawing.Point(126, 537)
        Me.SaldoTextBox.Name = "SaldoTextBox"
        Me.SaldoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SaldoTextBox.TabIndex = 64
        '
        'Fecha_de_nacimientoDateTimePicker
        '
        Me.Fecha_de_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "Fecha_de_nacimiento", True))
        Me.Fecha_de_nacimientoDateTimePicker.Location = New System.Drawing.Point(126, 563)
        Me.Fecha_de_nacimientoDateTimePicker.Name = "Fecha_de_nacimientoDateTimePicker"
        Me.Fecha_de_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_de_nacimientoDateTimePicker.TabIndex = 66
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(486, 385)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox.TabIndex = 68
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(486, 411)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PaisTextBox.TabIndex = 70
        '
        'RecidenciaTextBox
        '
        Me.RecidenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Recidencia", True))
        Me.RecidenciaTextBox.Location = New System.Drawing.Point(486, 437)
        Me.RecidenciaTextBox.Name = "RecidenciaTextBox"
        Me.RecidenciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RecidenciaTextBox.TabIndex = 72
        '
        'No_TarjetaTextBox
        '
        Me.No_TarjetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "No_Tarjeta", True))
        Me.No_TarjetaTextBox.Location = New System.Drawing.Point(486, 463)
        Me.No_TarjetaTextBox.Name = "No_TarjetaTextBox"
        Me.No_TarjetaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_TarjetaTextBox.TabIndex = 74
        '
        'PagoTextBox
        '
        Me.PagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Pago", True))
        Me.PagoTextBox.Location = New System.Drawing.Point(486, 489)
        Me.PagoTextBox.Name = "PagoTextBox"
        Me.PagoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PagoTextBox.TabIndex = 76
        '
        'CambioTextBox
        '
        Me.CambioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cambio", True))
        Me.CambioTextBox.Location = New System.Drawing.Point(486, 515)
        Me.CambioTextBox.Name = "CambioTextBox"
        Me.CambioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CambioTextBox.TabIndex = 78
        '
        'Ultimo_registroTextBox
        '
        Me.Ultimo_registroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Ultimo_registro", True))
        Me.Ultimo_registroTextBox.Location = New System.Drawing.Point(486, 541)
        Me.Ultimo_registroTextBox.Name = "Ultimo_registroTextBox"
        Me.Ultimo_registroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ultimo_registroTextBox.TabIndex = 80
        '
        'Usuario_walmartTextBox
        '
        Me.Usuario_walmartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Usuario_walmart", True))
        Me.Usuario_walmartTextBox.Location = New System.Drawing.Point(486, 567)
        Me.Usuario_walmartTextBox.Name = "Usuario_walmartTextBox"
        Me.Usuario_walmartTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Usuario_walmartTextBox.TabIndex = 82
        '
        'Pass_walmartTextBox
        '
        Me.Pass_walmartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Pass_walmart", True))
        Me.Pass_walmartTextBox.Location = New System.Drawing.Point(486, 593)
        Me.Pass_walmartTextBox.Name = "Pass_walmartTextBox"
        Me.Pass_walmartTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pass_walmartTextBox.TabIndex = 84
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 737)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteTextBox)
        Me.Controls.Add(Nom_ClienteLabel)
        Me.Controls.Add(Me.Nom_ClienteTextBox)
        Me.Controls.Add(Apellido_ClienteLabel)
        Me.Controls.Add(Me.Apellido_ClienteTextBox)
        Me.Controls.Add(NitLabel)
        Me.Controls.Add(Me.NitTextBox)
        Me.Controls.Add(DPILabel)
        Me.Controls.Add(Me.DPITextBox)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(SaldoLabel)
        Me.Controls.Add(Me.SaldoTextBox)
        Me.Controls.Add(Fecha_de_nacimientoLabel)
        Me.Controls.Add(Me.Fecha_de_nacimientoDateTimePicker)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(RecidenciaLabel)
        Me.Controls.Add(Me.RecidenciaTextBox)
        Me.Controls.Add(No_TarjetaLabel)
        Me.Controls.Add(Me.No_TarjetaTextBox)
        Me.Controls.Add(PagoLabel)
        Me.Controls.Add(Me.PagoTextBox)
        Me.Controls.Add(CambioLabel)
        Me.Controls.Add(Me.CambioTextBox)
        Me.Controls.Add(Ultimo_registroLabel)
        Me.Controls.Add(Me.Ultimo_registroTextBox)
        Me.Controls.Add(Usuario_walmartLabel)
        Me.Controls.Add(Me.Usuario_walmartTextBox)
        Me.Controls.Add(Pass_walmartLabel)
        Me.Controls.Add(Me.Pass_walmartTextBox)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Clientes base de datos para el registro de walmart lite."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._4_WalmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents _4_WalmartDataSet As _4_WalmartDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _4_WalmartDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As _4_WalmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents Nom_ClienteTextBox As TextBox
    Friend WithEvents Apellido_ClienteTextBox As TextBox
    Friend WithEvents NitTextBox As TextBox
    Friend WithEvents DPITextBox As TextBox
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents SaldoTextBox As TextBox
    Friend WithEvents Fecha_de_nacimientoDateTimePicker As DateTimePicker
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents PaisTextBox As TextBox
    Friend WithEvents RecidenciaTextBox As TextBox
    Friend WithEvents No_TarjetaTextBox As TextBox
    Friend WithEvents PagoTextBox As TextBox
    Friend WithEvents CambioTextBox As TextBox
    Friend WithEvents Ultimo_registroTextBox As TextBox
    Friend WithEvents Usuario_walmartTextBox As TextBox
    Friend WithEvents Pass_walmartTextBox As TextBox
End Class
