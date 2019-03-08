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
        Me.components = New System.ComponentModel.Container()
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim SueldoLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Dim AguinaldoLabel As System.Windows.Forms.Label
        Dim Bono14Label As System.Windows.Forms.Label
        Dim BonosLabel As System.Windows.Forms.Label
        Dim BonificacionLabel As System.Windows.Forms.Label
        Dim ISRLabel As System.Windows.Forms.Label
        Dim IGSSLabel As System.Windows.Forms.Label
        Dim IRTRALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me._4_WalmartDataSet = New _4_Walmart._4_WalmartDataSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New _4_Walmart._4_WalmartDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New _4_Walmart._4_WalmartDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.SueldoTextBox = New System.Windows.Forms.TextBox()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.AguinaldoTextBox = New System.Windows.Forms.TextBox()
        Me.Bono14TextBox = New System.Windows.Forms.TextBox()
        Me.BonosTextBox = New System.Windows.Forms.TextBox()
        Me.BonificacionTextBox = New System.Windows.Forms.TextBox()
        Me.ISRTextBox = New System.Windows.Forms.TextBox()
        Me.IGSSTextBox = New System.Windows.Forms.TextBox()
        Me.IRTRATextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        SueldoLabel = New System.Windows.Forms.Label()
        PuestoLabel = New System.Windows.Forms.Label()
        AguinaldoLabel = New System.Windows.Forms.Label()
        Bono14Label = New System.Windows.Forms.Label()
        BonosLabel = New System.Windows.Forms.Label()
        BonificacionLabel = New System.Windows.Forms.Label()
        ISRLabel = New System.Windows.Forms.Label()
        IGSSLabel = New System.Windows.Forms.Label()
        IRTRALabel = New System.Windows.Forms.Label()
        CType(Me._4_WalmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(10, 381)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        IdEmpleadoLabel.TabIndex = 51
        IdEmpleadoLabel.Text = "Id Empleado:"
        AddHandler IdEmpleadoLabel.Click, AddressOf Me.IdEmpleadoLabel_Click
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(10, 407)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 53
        NombreLabel.Text = "Nombre:"
        AddHandler NombreLabel.Click, AddressOf Me.NombreLabel_Click
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(10, 433)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 55
        ApellidoLabel.Text = "Apellido:"
        AddHandler ApellidoLabel.Click, AddressOf Me.ApellidoLabel_Click
        '
        'SueldoLabel
        '
        SueldoLabel.AutoSize = True
        SueldoLabel.Location = New System.Drawing.Point(10, 459)
        SueldoLabel.Name = "SueldoLabel"
        SueldoLabel.Size = New System.Drawing.Size(43, 13)
        SueldoLabel.TabIndex = 57
        SueldoLabel.Text = "Sueldo:"
        AddHandler SueldoLabel.Click, AddressOf Me.SueldoLabel_Click
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Location = New System.Drawing.Point(10, 485)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(43, 13)
        PuestoLabel.TabIndex = 59
        PuestoLabel.Text = "Puesto:"
        AddHandler PuestoLabel.Click, AddressOf Me.PuestoLabel_Click
        '
        'AguinaldoLabel
        '
        AguinaldoLabel.AutoSize = True
        AguinaldoLabel.Location = New System.Drawing.Point(10, 511)
        AguinaldoLabel.Name = "AguinaldoLabel"
        AguinaldoLabel.Size = New System.Drawing.Size(57, 13)
        AguinaldoLabel.TabIndex = 61
        AguinaldoLabel.Text = "Aguinaldo:"
        AddHandler AguinaldoLabel.Click, AddressOf Me.AguinaldoLabel_Click
        '
        'Bono14Label
        '
        Bono14Label.AutoSize = True
        Bono14Label.Location = New System.Drawing.Point(257, 385)
        Bono14Label.Name = "Bono14Label"
        Bono14Label.Size = New System.Drawing.Size(47, 13)
        Bono14Label.TabIndex = 63
        Bono14Label.Text = "Bono14:"
        AddHandler Bono14Label.Click, AddressOf Me.Bono14Label_Click
        '
        'BonosLabel
        '
        BonosLabel.AutoSize = True
        BonosLabel.Location = New System.Drawing.Point(257, 411)
        BonosLabel.Name = "BonosLabel"
        BonosLabel.Size = New System.Drawing.Size(40, 13)
        BonosLabel.TabIndex = 65
        BonosLabel.Text = "Bonos:"
        AddHandler BonosLabel.Click, AddressOf Me.BonosLabel_Click
        '
        'BonificacionLabel
        '
        BonificacionLabel.AutoSize = True
        BonificacionLabel.Location = New System.Drawing.Point(257, 437)
        BonificacionLabel.Name = "BonificacionLabel"
        BonificacionLabel.Size = New System.Drawing.Size(68, 13)
        BonificacionLabel.TabIndex = 67
        BonificacionLabel.Text = "Bonificacion:"
        AddHandler BonificacionLabel.Click, AddressOf Me.BonificacionLabel_Click
        '
        'ISRLabel
        '
        ISRLabel.AutoSize = True
        ISRLabel.Location = New System.Drawing.Point(257, 463)
        ISRLabel.Name = "ISRLabel"
        ISRLabel.Size = New System.Drawing.Size(28, 13)
        ISRLabel.TabIndex = 69
        ISRLabel.Text = "ISR:"
        AddHandler ISRLabel.Click, AddressOf Me.ISRLabel_Click
        '
        'IGSSLabel
        '
        IGSSLabel.AutoSize = True
        IGSSLabel.Location = New System.Drawing.Point(257, 489)
        IGSSLabel.Name = "IGSSLabel"
        IGSSLabel.Size = New System.Drawing.Size(35, 13)
        IGSSLabel.TabIndex = 71
        IGSSLabel.Text = "IGSS:"
        AddHandler IGSSLabel.Click, AddressOf Me.IGSSLabel_Click
        '
        'IRTRALabel
        '
        IRTRALabel.AutoSize = True
        IRTRALabel.Location = New System.Drawing.Point(257, 515)
        IRTRALabel.Name = "IRTRALabel"
        IRTRALabel.Size = New System.Drawing.Size(43, 13)
        IRTRALabel.TabIndex = 73
        IRTRALabel.Text = "IRTRA:"
        AddHandler IRTRALabel.Click, AddressOf Me.IRTRALabel_Click
        '
        '_4_WalmartDataSet
        '
        Me._4_WalmartDataSet.DataSetName = "_4_WalmartDataSet"
        Me._4_WalmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me._4_WalmartDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.MercaderiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _4_Walmart._4_WalmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(760, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 0
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
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
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(12, 152)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(728, 220)
        Me.EmpleadosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sueldo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sueldo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Puesto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Puesto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Aguinaldo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Aguinaldo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Bono14"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Bono14"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Bonos"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Bonos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Bonificacion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Bonificacion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ISR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ISR"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IGSS"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IGSS"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IRTRA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IRTRA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 118)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(85, 378)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEmpleadoTextBox.TabIndex = 52
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(85, 404)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 54
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(85, 430)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 56
        '
        'SueldoTextBox
        '
        Me.SueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Sueldo", True))
        Me.SueldoTextBox.Location = New System.Drawing.Point(85, 456)
        Me.SueldoTextBox.Name = "SueldoTextBox"
        Me.SueldoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SueldoTextBox.TabIndex = 58
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(85, 482)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PuestoTextBox.TabIndex = 60
        '
        'AguinaldoTextBox
        '
        Me.AguinaldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Aguinaldo", True))
        Me.AguinaldoTextBox.Location = New System.Drawing.Point(85, 508)
        Me.AguinaldoTextBox.Name = "AguinaldoTextBox"
        Me.AguinaldoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AguinaldoTextBox.TabIndex = 62
        '
        'Bono14TextBox
        '
        Me.Bono14TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Bono14", True))
        Me.Bono14TextBox.Location = New System.Drawing.Point(332, 382)
        Me.Bono14TextBox.Name = "Bono14TextBox"
        Me.Bono14TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bono14TextBox.TabIndex = 64
        '
        'BonosTextBox
        '
        Me.BonosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Bonos", True))
        Me.BonosTextBox.Location = New System.Drawing.Point(332, 408)
        Me.BonosTextBox.Name = "BonosTextBox"
        Me.BonosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BonosTextBox.TabIndex = 66
        '
        'BonificacionTextBox
        '
        Me.BonificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Bonificacion", True))
        Me.BonificacionTextBox.Location = New System.Drawing.Point(332, 434)
        Me.BonificacionTextBox.Name = "BonificacionTextBox"
        Me.BonificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BonificacionTextBox.TabIndex = 68
        '
        'ISRTextBox
        '
        Me.ISRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "ISR", True))
        Me.ISRTextBox.Location = New System.Drawing.Point(332, 460)
        Me.ISRTextBox.Name = "ISRTextBox"
        Me.ISRTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISRTextBox.TabIndex = 70
        '
        'IGSSTextBox
        '
        Me.IGSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IGSS", True))
        Me.IGSSTextBox.Location = New System.Drawing.Point(332, 486)
        Me.IGSSTextBox.Name = "IGSSTextBox"
        Me.IGSSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IGSSTextBox.TabIndex = 72
        '
        'IRTRATextBox
        '
        Me.IRTRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IRTRA", True))
        Me.IRTRATextBox.Location = New System.Drawing.Point(332, 512)
        Me.IRTRATextBox.Name = "IRTRATextBox"
        Me.IRTRATextBox.Size = New System.Drawing.Size(100, 20)
        Me.IRTRATextBox.TabIndex = 74
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Aqua
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(479, 423)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(233, 53)
        Me.Button5.TabIndex = 75
        Me.Button5.Text = "Finalizar registro, Regresar a Inicio."
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 555)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(SueldoLabel)
        Me.Controls.Add(Me.SueldoTextBox)
        Me.Controls.Add(PuestoLabel)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(AguinaldoLabel)
        Me.Controls.Add(Me.AguinaldoTextBox)
        Me.Controls.Add(Bono14Label)
        Me.Controls.Add(Me.Bono14TextBox)
        Me.Controls.Add(BonosLabel)
        Me.Controls.Add(Me.BonosTextBox)
        Me.Controls.Add(BonificacionLabel)
        Me.Controls.Add(Me.BonificacionTextBox)
        Me.Controls.Add(ISRLabel)
        Me.Controls.Add(Me.ISRTextBox)
        Me.Controls.Add(IGSSLabel)
        Me.Controls.Add(Me.IGSSTextBox)
        Me.Controls.Add(IRTRALabel)
        Me.Controls.Add(Me.IRTRATextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Datos de empleados y nuevos empleados registrados."
        CType(Me._4_WalmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _4_WalmartDataSet As _4_WalmartDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As _4_WalmartDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As _4_WalmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmpleadosDataGridView As DataGridView
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents SueldoTextBox As TextBox
    Friend WithEvents PuestoTextBox As TextBox
    Friend WithEvents AguinaldoTextBox As TextBox
    Friend WithEvents Bono14TextBox As TextBox
    Friend WithEvents BonosTextBox As TextBox
    Friend WithEvents BonificacionTextBox As TextBox
    Friend WithEvents ISRTextBox As TextBox
    Friend WithEvents IGSSTextBox As TextBox
    Friend WithEvents IRTRATextBox As TextBox
    Friend WithEvents Button5 As Button
End Class
