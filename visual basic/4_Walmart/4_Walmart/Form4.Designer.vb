<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim IdMercaderiaLabel As System.Windows.Forms.Label
        Dim NomProdLabel As System.Windows.Forms.Label
        Dim MarcaProdLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim Precio_compraLabel As System.Windows.Forms.Label
        Dim Precio_ventaLabel As System.Windows.Forms.Label
        Dim No_facturaLabel As System.Windows.Forms.Label
        Dim Fecha_vencimientoLabel As System.Windows.Forms.Label
        Dim Fecha_compraLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me._4_WalmartDataSet = New _4_Walmart._4_WalmartDataSet()
        Me.MercaderiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MercaderiaTableAdapter = New _4_Walmart._4_WalmartDataSetTableAdapters.MercaderiaTableAdapter()
        Me.TableAdapterManager = New _4_Walmart._4_WalmartDataSetTableAdapters.TableAdapterManager()
        Me.MercaderiaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MercaderiaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MercaderiaDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IdMercaderiaTextBox = New System.Windows.Forms.TextBox()
        Me.NomProdTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaProdTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.No_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_vencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_compraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        IdMercaderiaLabel = New System.Windows.Forms.Label()
        NomProdLabel = New System.Windows.Forms.Label()
        MarcaProdLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Precio_compraLabel = New System.Windows.Forms.Label()
        Precio_ventaLabel = New System.Windows.Forms.Label()
        No_facturaLabel = New System.Windows.Forms.Label()
        Fecha_vencimientoLabel = New System.Windows.Forms.Label()
        Fecha_compraLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CType(Me._4_WalmartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MercaderiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MercaderiaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MercaderiaBindingNavigator.SuspendLayout()
        CType(Me.MercaderiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdMercaderiaLabel
        '
        IdMercaderiaLabel.AutoSize = True
        IdMercaderiaLabel.Location = New System.Drawing.Point(12, 381)
        IdMercaderiaLabel.Name = "IdMercaderiaLabel"
        IdMercaderiaLabel.Size = New System.Drawing.Size(75, 13)
        IdMercaderiaLabel.TabIndex = 52
        IdMercaderiaLabel.Text = "Id Mercaderia:"
        '
        'NomProdLabel
        '
        NomProdLabel.AutoSize = True
        NomProdLabel.Location = New System.Drawing.Point(12, 407)
        NomProdLabel.Name = "NomProdLabel"
        NomProdLabel.Size = New System.Drawing.Size(57, 13)
        NomProdLabel.TabIndex = 54
        NomProdLabel.Text = "Nom Prod:"
        '
        'MarcaProdLabel
        '
        MarcaProdLabel.AutoSize = True
        MarcaProdLabel.Location = New System.Drawing.Point(12, 433)
        MarcaProdLabel.Name = "MarcaProdLabel"
        MarcaProdLabel.Size = New System.Drawing.Size(65, 13)
        MarcaProdLabel.TabIndex = 56
        MarcaProdLabel.Text = "Marca Prod:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(12, 459)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 58
        CategoriaLabel.Text = "Categoria:"
        '
        'Precio_compraLabel
        '
        Precio_compraLabel.AutoSize = True
        Precio_compraLabel.Location = New System.Drawing.Point(12, 485)
        Precio_compraLabel.Name = "Precio_compraLabel"
        Precio_compraLabel.Size = New System.Drawing.Size(78, 13)
        Precio_compraLabel.TabIndex = 60
        Precio_compraLabel.Text = "Precio compra:"
        '
        'Precio_ventaLabel
        '
        Precio_ventaLabel.AutoSize = True
        Precio_ventaLabel.Location = New System.Drawing.Point(338, 381)
        Precio_ventaLabel.Name = "Precio_ventaLabel"
        Precio_ventaLabel.Size = New System.Drawing.Size(69, 13)
        Precio_ventaLabel.TabIndex = 62
        Precio_ventaLabel.Text = "precio venta:"
        '
        'No_facturaLabel
        '
        No_facturaLabel.AutoSize = True
        No_facturaLabel.Location = New System.Drawing.Point(338, 407)
        No_facturaLabel.Name = "No_facturaLabel"
        No_facturaLabel.Size = New System.Drawing.Size(60, 13)
        No_facturaLabel.TabIndex = 64
        No_facturaLabel.Text = "No factura:"
        '
        'Fecha_vencimientoLabel
        '
        Fecha_vencimientoLabel.AutoSize = True
        Fecha_vencimientoLabel.Location = New System.Drawing.Point(338, 434)
        Fecha_vencimientoLabel.Name = "Fecha_vencimientoLabel"
        Fecha_vencimientoLabel.Size = New System.Drawing.Size(97, 13)
        Fecha_vencimientoLabel.TabIndex = 66
        Fecha_vencimientoLabel.Text = "fecha vencimiento:"
        '
        'Fecha_compraLabel
        '
        Fecha_compraLabel.AutoSize = True
        Fecha_compraLabel.Location = New System.Drawing.Point(338, 460)
        Fecha_compraLabel.Name = "Fecha_compraLabel"
        Fecha_compraLabel.Size = New System.Drawing.Size(75, 13)
        Fecha_compraLabel.TabIndex = 68
        Fecha_compraLabel.Text = "fecha compra:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(338, 485)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 70
        CantidadLabel.Text = "cantidad:"
        '
        '_4_WalmartDataSet
        '
        Me._4_WalmartDataSet.DataSetName = "_4_WalmartDataSet"
        Me._4_WalmartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MercaderiaBindingSource
        '
        Me.MercaderiaBindingSource.DataMember = "Mercaderia"
        Me.MercaderiaBindingSource.DataSource = Me._4_WalmartDataSet
        '
        'MercaderiaTableAdapter
        '
        Me.MercaderiaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.MercaderiaTableAdapter = Me.MercaderiaTableAdapter
        Me.TableAdapterManager.UpdateOrder = _4_Walmart._4_WalmartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MercaderiaBindingNavigator
        '
        Me.MercaderiaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MercaderiaBindingNavigator.BindingSource = Me.MercaderiaBindingSource
        Me.MercaderiaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MercaderiaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MercaderiaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MercaderiaBindingNavigatorSaveItem})
        Me.MercaderiaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MercaderiaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MercaderiaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MercaderiaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MercaderiaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MercaderiaBindingNavigator.Name = "MercaderiaBindingNavigator"
        Me.MercaderiaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MercaderiaBindingNavigator.Size = New System.Drawing.Size(760, 25)
        Me.MercaderiaBindingNavigator.TabIndex = 0
        Me.MercaderiaBindingNavigator.Text = "BindingNavigator1"
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
        'MercaderiaBindingNavigatorSaveItem
        '
        Me.MercaderiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MercaderiaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MercaderiaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MercaderiaBindingNavigatorSaveItem.Name = "MercaderiaBindingNavigatorSaveItem"
        Me.MercaderiaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MercaderiaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MercaderiaDataGridView
        '
        Me.MercaderiaDataGridView.AutoGenerateColumns = False
        Me.MercaderiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MercaderiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.MercaderiaDataGridView.DataSource = Me.MercaderiaBindingSource
        Me.MercaderiaDataGridView.Location = New System.Drawing.Point(12, 152)
        Me.MercaderiaDataGridView.Name = "MercaderiaDataGridView"
        Me.MercaderiaDataGridView.Size = New System.Drawing.Size(728, 220)
        Me.MercaderiaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMercaderia"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMercaderia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomProd"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NomProd"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MarcaProd"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MarcaProd"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio_compra"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio_compra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "No_factura"
        Me.DataGridViewTextBoxColumn7.HeaderText = "No_factura"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha_vencimiento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fecha_vencimiento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fecha_compra"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fecha_compra"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(728, 118)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'IdMercaderiaTextBox
        '
        Me.IdMercaderiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "IdMercaderia", True))
        Me.IdMercaderiaTextBox.Location = New System.Drawing.Point(115, 378)
        Me.IdMercaderiaTextBox.Name = "IdMercaderiaTextBox"
        Me.IdMercaderiaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdMercaderiaTextBox.TabIndex = 53
        '
        'NomProdTextBox
        '
        Me.NomProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "NomProd", True))
        Me.NomProdTextBox.Location = New System.Drawing.Point(115, 404)
        Me.NomProdTextBox.Name = "NomProdTextBox"
        Me.NomProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomProdTextBox.TabIndex = 55
        '
        'MarcaProdTextBox
        '
        Me.MarcaProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "MarcaProd", True))
        Me.MarcaProdTextBox.Location = New System.Drawing.Point(115, 430)
        Me.MarcaProdTextBox.Name = "MarcaProdTextBox"
        Me.MarcaProdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MarcaProdTextBox.TabIndex = 57
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(115, 456)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CategoriaTextBox.TabIndex = 59
        '
        'Precio_compraTextBox
        '
        Me.Precio_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "Precio_compra", True))
        Me.Precio_compraTextBox.Location = New System.Drawing.Point(115, 482)
        Me.Precio_compraTextBox.Name = "Precio_compraTextBox"
        Me.Precio_compraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_compraTextBox.TabIndex = 61
        '
        'Precio_ventaTextBox
        '
        Me.Precio_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "precio_venta", True))
        Me.Precio_ventaTextBox.Location = New System.Drawing.Point(441, 378)
        Me.Precio_ventaTextBox.Name = "Precio_ventaTextBox"
        Me.Precio_ventaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_ventaTextBox.TabIndex = 63
        '
        'No_facturaTextBox
        '
        Me.No_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "No_factura", True))
        Me.No_facturaTextBox.Location = New System.Drawing.Point(441, 404)
        Me.No_facturaTextBox.Name = "No_facturaTextBox"
        Me.No_facturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_facturaTextBox.TabIndex = 65
        '
        'Fecha_vencimientoDateTimePicker
        '
        Me.Fecha_vencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MercaderiaBindingSource, "fecha_vencimiento", True))
        Me.Fecha_vencimientoDateTimePicker.Location = New System.Drawing.Point(441, 430)
        Me.Fecha_vencimientoDateTimePicker.Name = "Fecha_vencimientoDateTimePicker"
        Me.Fecha_vencimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_vencimientoDateTimePicker.TabIndex = 67
        '
        'Fecha_compraDateTimePicker
        '
        Me.Fecha_compraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MercaderiaBindingSource, "fecha_compra", True))
        Me.Fecha_compraDateTimePicker.Location = New System.Drawing.Point(441, 456)
        Me.Fecha_compraDateTimePicker.Name = "Fecha_compraDateTimePicker"
        Me.Fecha_compraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_compraDateTimePicker.TabIndex = 69
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(441, 482)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 71
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Aqua
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(238, 534)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(233, 53)
        Me.Button5.TabIndex = 76
        Me.Button5.Text = "Finalizar registro, Regresar a Inicio."
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 611)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(IdMercaderiaLabel)
        Me.Controls.Add(Me.IdMercaderiaTextBox)
        Me.Controls.Add(NomProdLabel)
        Me.Controls.Add(Me.NomProdTextBox)
        Me.Controls.Add(MarcaProdLabel)
        Me.Controls.Add(Me.MarcaProdTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(Precio_compraLabel)
        Me.Controls.Add(Me.Precio_compraTextBox)
        Me.Controls.Add(Precio_ventaLabel)
        Me.Controls.Add(Me.Precio_ventaTextBox)
        Me.Controls.Add(No_facturaLabel)
        Me.Controls.Add(Me.No_facturaTextBox)
        Me.Controls.Add(Fecha_vencimientoLabel)
        Me.Controls.Add(Me.Fecha_vencimientoDateTimePicker)
        Me.Controls.Add(Fecha_compraLabel)
        Me.Controls.Add(Me.Fecha_compraDateTimePicker)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MercaderiaDataGridView)
        Me.Controls.Add(Me.MercaderiaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Compra y Venta de productos  registro de productos y nuevos productos ingresados." &
    ""
        CType(Me._4_WalmartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MercaderiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MercaderiaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MercaderiaBindingNavigator.ResumeLayout(False)
        Me.MercaderiaBindingNavigator.PerformLayout()
        CType(Me.MercaderiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _4_WalmartDataSet As _4_WalmartDataSet
    Friend WithEvents MercaderiaBindingSource As BindingSource
    Friend WithEvents MercaderiaTableAdapter As _4_WalmartDataSetTableAdapters.MercaderiaTableAdapter
    Friend WithEvents TableAdapterManager As _4_WalmartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MercaderiaBindingNavigator As BindingNavigator
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
    Friend WithEvents MercaderiaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MercaderiaDataGridView As DataGridView
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IdMercaderiaTextBox As TextBox
    Friend WithEvents NomProdTextBox As TextBox
    Friend WithEvents MarcaProdTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents Precio_compraTextBox As TextBox
    Friend WithEvents Precio_ventaTextBox As TextBox
    Friend WithEvents No_facturaTextBox As TextBox
    Friend WithEvents Fecha_vencimientoDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_compraDateTimePicker As DateTimePicker
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Button5 As Button
End Class
