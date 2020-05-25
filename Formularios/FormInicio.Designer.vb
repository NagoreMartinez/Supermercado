<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonEmpleados = New System.Windows.Forms.Button()
        Me.PanelEmpleados = New System.Windows.Forms.Panel()
        Me.SupermercadoDataSet = New Formularios.SupermercadoDataSet()
        Me.EliminarEmpleado = New System.Windows.Forms.Button()
        Me.EditarPEmpleado = New System.Windows.Forms.Button()
        Me.NuevoEmpleado = New System.Windows.Forms.Button()
        Me.ButtonBuscar1 = New System.Windows.Forms.Button()
        Me.BuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelClientes = New System.Windows.Forms.Panel()
        Me.EditarPCliente = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.IDCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSUPERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EliminarCliente = New System.Windows.Forms.Button()
        Me.NuevoCliente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.IDPRODUCTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACADUCIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EliminarProducto = New System.Windows.Forms.Button()
        Me.EditarPProducto = New System.Windows.Forms.Button()
        Me.NuevoProducto = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CLIENTESTableAdapter = New Formularios.SupermercadoDataSetTableAdapters.CLIENTESTableAdapter()
        Me.PRODUCTOSTableAdapter = New Formularios.SupermercadoDataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOSTableAdapter = New Formularios.SupermercadoDataSetTableAdapters.EMPLEADOSTableAdapter()
        Me.IDEMPLEADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSUPERDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARIOMENSUALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.PanelEmpleados.SuspendLayout()
        CType(Me.SupermercadoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelClientes.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENÚ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.ButtonProductos)
        Me.Panel1.Controls.Add(Me.ButtonClientes)
        Me.Panel1.Controls.Add(Me.ButtonEmpleados)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 116)
        Me.Panel1.TabIndex = 1
        '
        'ButtonProductos
        '
        Me.ButtonProductos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductos.Location = New System.Drawing.Point(594, 53)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(156, 36)
        Me.ButtonProductos.TabIndex = 2
        Me.ButtonProductos.Text = "PRODUCTOS"
        Me.ButtonProductos.UseVisualStyleBackColor = False
        '
        'ButtonClientes
        '
        Me.ButtonClientes.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.Location = New System.Drawing.Point(331, 53)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(156, 36)
        Me.ButtonClientes.TabIndex = 2
        Me.ButtonClientes.Text = "CLIENTES"
        Me.ButtonClientes.UseVisualStyleBackColor = False
        '
        'ButtonEmpleados
        '
        Me.ButtonEmpleados.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEmpleados.Location = New System.Drawing.Point(52, 53)
        Me.ButtonEmpleados.Name = "ButtonEmpleados"
        Me.ButtonEmpleados.Size = New System.Drawing.Size(156, 36)
        Me.ButtonEmpleados.TabIndex = 1
        Me.ButtonEmpleados.Text = "EMPLEADOS"
        Me.ButtonEmpleados.UseVisualStyleBackColor = False
        '
        'PanelEmpleados
        '
        Me.PanelEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.PanelEmpleados.Controls.Add(Me.EliminarEmpleado)
        Me.PanelEmpleados.Controls.Add(Me.EditarPEmpleado)
        Me.PanelEmpleados.Controls.Add(Me.NuevoEmpleado)
        Me.PanelEmpleados.Controls.Add(Me.ButtonBuscar1)
        Me.PanelEmpleados.Controls.Add(Me.BuscarEmpleado)
        Me.PanelEmpleados.Controls.Add(Me.Label2)
        Me.PanelEmpleados.Location = New System.Drawing.Point(1, 143)
        Me.PanelEmpleados.Name = "PanelEmpleados"
        Me.PanelEmpleados.Size = New System.Drawing.Size(812, 389)
        Me.PanelEmpleados.TabIndex = 2
        '
        'SupermercadoDataSet
        '
        Me.SupermercadoDataSet.DataSetName = "SupermercadoDataSet"
        Me.SupermercadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EliminarEmpleado
        '
        Me.EliminarEmpleado.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EliminarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarEmpleado.Location = New System.Drawing.Point(590, 323)
        Me.EliminarEmpleado.Name = "EliminarEmpleado"
        Me.EliminarEmpleado.Size = New System.Drawing.Size(196, 51)
        Me.EliminarEmpleado.TabIndex = 6
        Me.EliminarEmpleado.Text = "Eliminar Perfil"
        Me.EliminarEmpleado.UseVisualStyleBackColor = False
        '
        'EditarPEmpleado
        '
        Me.EditarPEmpleado.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EditarPEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarPEmpleado.Location = New System.Drawing.Point(309, 323)
        Me.EditarPEmpleado.Name = "EditarPEmpleado"
        Me.EditarPEmpleado.Size = New System.Drawing.Size(196, 51)
        Me.EditarPEmpleado.TabIndex = 5
        Me.EditarPEmpleado.Text = "Editar Perfil"
        Me.EditarPEmpleado.UseVisualStyleBackColor = False
        '
        'NuevoEmpleado
        '
        Me.NuevoEmpleado.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.NuevoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoEmpleado.Location = New System.Drawing.Point(48, 322)
        Me.NuevoEmpleado.Name = "NuevoEmpleado"
        Me.NuevoEmpleado.Size = New System.Drawing.Size(196, 52)
        Me.NuevoEmpleado.TabIndex = 4
        Me.NuevoEmpleado.Text = "Registrar Empleado"
        Me.NuevoEmpleado.UseVisualStyleBackColor = False
        '
        'ButtonBuscar1
        '
        Me.ButtonBuscar1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ButtonBuscar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar1.Location = New System.Drawing.Point(661, 23)
        Me.ButtonBuscar1.Name = "ButtonBuscar1"
        Me.ButtonBuscar1.Size = New System.Drawing.Size(88, 33)
        Me.ButtonBuscar1.TabIndex = 3
        Me.ButtonBuscar1.Text = "Buscar"
        Me.ButtonBuscar1.UseVisualStyleBackColor = False
        '
        'BuscarEmpleado
        '
        Me.BuscarEmpleado.Location = New System.Drawing.Point(416, 27)
        Me.BuscarEmpleado.Name = "BuscarEmpleado"
        Me.BuscarEmpleado.Size = New System.Drawing.Size(211, 20)
        Me.BuscarEmpleado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(361, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Introduzca el DNI o nombre del empleado"
        '
        'PanelClientes
        '
        Me.PanelClientes.Controls.Add(Me.EditarPCliente)
        Me.PanelClientes.Controls.Add(Me.dgvClientes)
        Me.PanelClientes.Controls.Add(Me.EliminarCliente)
        Me.PanelClientes.Controls.Add(Me.NuevoCliente)
        Me.PanelClientes.Controls.Add(Me.Button1)
        Me.PanelClientes.Controls.Add(Me.BuscarCliente)
        Me.PanelClientes.Controls.Add(Me.Label3)
        Me.PanelClientes.Location = New System.Drawing.Point(19, 127)
        Me.PanelClientes.Name = "PanelClientes"
        Me.PanelClientes.Size = New System.Drawing.Size(779, 413)
        Me.PanelClientes.TabIndex = 3
        '
        'EditarPCliente
        '
        Me.EditarPCliente.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EditarPCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarPCliente.Location = New System.Drawing.Point(312, 357)
        Me.EditarPCliente.Name = "EditarPCliente"
        Me.EditarPCliente.Size = New System.Drawing.Size(196, 48)
        Me.EditarPCliente.TabIndex = 11
        Me.EditarPCliente.Text = "Editar Perfil"
        Me.EditarPCliente.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToOrderColumns = True
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCLIENTEDataGridViewTextBoxColumn, Me.IDSUPERDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.TELEFONODataGridViewTextBoxColumn})
        Me.dgvClientes.DataSource = Me.CLIENTESBindingSource
        Me.dgvClientes.Location = New System.Drawing.Point(121, 102)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(543, 226)
        Me.dgvClientes.TabIndex = 10
        '
        'IDCLIENTEDataGridViewTextBoxColumn
        '
        Me.IDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDCLIENTE"
        Me.IDCLIENTEDataGridViewTextBoxColumn.HeaderText = "IDCLIENTE"
        Me.IDCLIENTEDataGridViewTextBoxColumn.Name = "IDCLIENTEDataGridViewTextBoxColumn"
        '
        'IDSUPERDataGridViewTextBoxColumn
        '
        Me.IDSUPERDataGridViewTextBoxColumn.DataPropertyName = "IDSUPER"
        Me.IDSUPERDataGridViewTextBoxColumn.HeaderText = "IDSUPER"
        Me.IDSUPERDataGridViewTextBoxColumn.Name = "IDSUPERDataGridViewTextBoxColumn"
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        '
        'TELEFONODataGridViewTextBoxColumn
        '
        Me.TELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.Name = "TELEFONODataGridViewTextBoxColumn"
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.SupermercadoDataSet
        '
        'EliminarCliente
        '
        Me.EliminarCliente.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarCliente.Location = New System.Drawing.Point(572, 357)
        Me.EliminarCliente.Name = "EliminarCliente"
        Me.EliminarCliente.Size = New System.Drawing.Size(196, 48)
        Me.EliminarCliente.TabIndex = 9
        Me.EliminarCliente.Text = "Eliminar Perfil"
        Me.EliminarCliente.UseVisualStyleBackColor = False
        '
        'NuevoCliente
        '
        Me.NuevoCliente.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.NuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoCliente.Location = New System.Drawing.Point(29, 355)
        Me.NuevoCliente.Name = "NuevoCliente"
        Me.NuevoCliente.Size = New System.Drawing.Size(196, 52)
        Me.NuevoCliente.TabIndex = 7
        Me.NuevoCliente.Text = "Registrar Cliente"
        Me.NuevoCliente.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(680, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BuscarCliente
        '
        Me.BuscarCliente.Location = New System.Drawing.Point(450, 30)
        Me.BuscarCliente.Name = "BuscarCliente"
        Me.BuscarCliente.Size = New System.Drawing.Size(204, 20)
        Me.BuscarCliente.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(424, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Introduzca el DNI o nombre para buscar el cliente"
        '
        'PanelProductos
        '
        Me.PanelProductos.Controls.Add(Me.dgvProductos)
        Me.PanelProductos.Controls.Add(Me.EliminarProducto)
        Me.PanelProductos.Controls.Add(Me.EditarPProducto)
        Me.PanelProductos.Controls.Add(Me.NuevoProducto)
        Me.PanelProductos.Controls.Add(Me.Button5)
        Me.PanelProductos.Controls.Add(Me.BuscarProducto)
        Me.PanelProductos.Controls.Add(Me.Label4)
        Me.PanelProductos.Location = New System.Drawing.Point(13, 127)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(800, 405)
        Me.PanelProductos.TabIndex = 4
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.AutoGenerateColumns = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRODUCTODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn1, Me.PRECIODataGridViewTextBoxColumn, Me.FECHACADUCIDADDataGridViewTextBoxColumn})
        Me.dgvProductos.DataSource = Me.PRODUCTOSBindingSource
        Me.dgvProductos.Location = New System.Drawing.Point(181, 84)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(455, 214)
        Me.dgvProductos.TabIndex = 14
        '
        'IDPRODUCTODataGridViewTextBoxColumn
        '
        Me.IDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "IDPRODUCTO"
        Me.IDPRODUCTODataGridViewTextBoxColumn.HeaderText = "IDPRODUCTO"
        Me.IDPRODUCTODataGridViewTextBoxColumn.Name = "IDPRODUCTODataGridViewTextBoxColumn"
        '
        'NOMBREDataGridViewTextBoxColumn1
        '
        Me.NOMBREDataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn1.Name = "NOMBREDataGridViewTextBoxColumn1"
        '
        'PRECIODataGridViewTextBoxColumn
        '
        Me.PRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.Name = "PRECIODataGridViewTextBoxColumn"
        '
        'FECHACADUCIDADDataGridViewTextBoxColumn
        '
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.DataPropertyName = "FECHA CADUCIDAD"
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.HeaderText = "FECHA CADUCIDAD"
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.Name = "FECHACADUCIDADDataGridViewTextBoxColumn"
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.SupermercadoDataSet
        '
        'EliminarProducto
        '
        Me.EliminarProducto.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarProducto.Location = New System.Drawing.Point(578, 342)
        Me.EliminarProducto.Name = "EliminarProducto"
        Me.EliminarProducto.Size = New System.Drawing.Size(196, 51)
        Me.EliminarProducto.TabIndex = 13
        Me.EliminarProducto.Text = "Eliminar Datos"
        Me.EliminarProducto.UseVisualStyleBackColor = False
        '
        'EditarPProducto
        '
        Me.EditarPProducto.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EditarPProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarPProducto.Location = New System.Drawing.Point(307, 343)
        Me.EditarPProducto.Name = "EditarPProducto"
        Me.EditarPProducto.Size = New System.Drawing.Size(196, 48)
        Me.EditarPProducto.TabIndex = 12
        Me.EditarPProducto.Text = "Editar Datos"
        Me.EditarPProducto.UseVisualStyleBackColor = False
        '
        'NuevoProducto
        '
        Me.NuevoProducto.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.NuevoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoProducto.Location = New System.Drawing.Point(35, 341)
        Me.NuevoProducto.Name = "NuevoProducto"
        Me.NuevoProducto.Size = New System.Drawing.Size(196, 52)
        Me.NuevoProducto.TabIndex = 11
        Me.NuevoProducto.Text = "Registrar Producto"
        Me.NuevoProducto.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(621, 31)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 33)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'BuscarProducto
        '
        Me.BuscarProducto.Location = New System.Drawing.Point(370, 38)
        Me.BuscarProducto.Name = "BuscarProducto"
        Me.BuscarProducto.Size = New System.Drawing.Size(211, 20)
        Me.BuscarProducto.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Introduzca el ID del producto "
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AutoGenerateColumns = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEMPLEADODataGridViewTextBoxColumn, Me.IDTIPODataGridViewTextBoxColumn, Me.IDSUPERDataGridViewTextBoxColumn1, Me.DNIDataGridViewTextBoxColumn1, Me.NOMBREDataGridViewTextBoxColumn2, Me.EDADDataGridViewTextBoxColumn, Me.TELEFONODataGridViewTextBoxColumn1, Me.HORARIODataGridViewTextBoxColumn, Me.SALARIOMENSUALDataGridViewTextBoxColumn})
        Me.dgvEmpleados.DataSource = Me.EMPLEADOSBindingSource
        Me.dgvEmpleados.Location = New System.Drawing.Point(39, 80)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(726, 221)
        Me.dgvEmpleados.TabIndex = 7
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.SupermercadoDataSet
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'IDEMPLEADODataGridViewTextBoxColumn
        '
        Me.IDEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "IDEMPLEADO"
        Me.IDEMPLEADODataGridViewTextBoxColumn.HeaderText = "IDEMPLEADO"
        Me.IDEMPLEADODataGridViewTextBoxColumn.Name = "IDEMPLEADODataGridViewTextBoxColumn"
        '
        'IDTIPODataGridViewTextBoxColumn
        '
        Me.IDTIPODataGridViewTextBoxColumn.DataPropertyName = "IDTIPO"
        Me.IDTIPODataGridViewTextBoxColumn.HeaderText = "IDTIPO"
        Me.IDTIPODataGridViewTextBoxColumn.Name = "IDTIPODataGridViewTextBoxColumn"
        '
        'IDSUPERDataGridViewTextBoxColumn1
        '
        Me.IDSUPERDataGridViewTextBoxColumn1.DataPropertyName = "IDSUPER"
        Me.IDSUPERDataGridViewTextBoxColumn1.HeaderText = "IDSUPER"
        Me.IDSUPERDataGridViewTextBoxColumn1.Name = "IDSUPERDataGridViewTextBoxColumn1"
        '
        'DNIDataGridViewTextBoxColumn1
        '
        Me.DNIDataGridViewTextBoxColumn1.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn1.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn1.Name = "DNIDataGridViewTextBoxColumn1"
        '
        'NOMBREDataGridViewTextBoxColumn2
        '
        Me.NOMBREDataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn2.Name = "NOMBREDataGridViewTextBoxColumn2"
        '
        'EDADDataGridViewTextBoxColumn
        '
        Me.EDADDataGridViewTextBoxColumn.DataPropertyName = "EDAD"
        Me.EDADDataGridViewTextBoxColumn.HeaderText = "EDAD"
        Me.EDADDataGridViewTextBoxColumn.Name = "EDADDataGridViewTextBoxColumn"
        '
        'TELEFONODataGridViewTextBoxColumn1
        '
        Me.TELEFONODataGridViewTextBoxColumn1.DataPropertyName = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn1.HeaderText = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn1.Name = "TELEFONODataGridViewTextBoxColumn1"
        '
        'HORARIODataGridViewTextBoxColumn
        '
        Me.HORARIODataGridViewTextBoxColumn.DataPropertyName = "HORARIO"
        Me.HORARIODataGridViewTextBoxColumn.HeaderText = "HORARIO"
        Me.HORARIODataGridViewTextBoxColumn.Name = "HORARIODataGridViewTextBoxColumn"
        '
        'SALARIOMENSUALDataGridViewTextBoxColumn
        '
        Me.SALARIOMENSUALDataGridViewTextBoxColumn.DataPropertyName = "SALARIO MENSUAL"
        Me.SALARIOMENSUALDataGridViewTextBoxColumn.HeaderText = "SALARIO MENSUAL"
        Me.SALARIOMENSUALDataGridViewTextBoxColumn.Name = "SALARIOMENSUALDataGridViewTextBoxColumn"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEmpleados)
        Me.Controls.Add(Me.PanelClientes)
        Me.Controls.Add(Me.PanelProductos)
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelEmpleados.ResumeLayout(False)
        Me.PanelEmpleados.PerformLayout()
        CType(Me.SupermercadoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelClientes.ResumeLayout(False)
        Me.PanelClientes.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProductos.ResumeLayout(False)
        Me.PanelProductos.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonProductos As Button
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonEmpleados As Button
    Friend WithEvents PanelEmpleados As Panel
    Friend WithEvents EliminarEmpleado As Button
    Friend WithEvents EditarPEmpleado As Button
    Friend WithEvents NuevoEmpleado As Button
    Friend WithEvents ButtonBuscar1 As Button
    Friend WithEvents BuscarEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelClientes As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BuscarCliente As TextBox
    Friend WithEvents EliminarCliente As Button
    Friend WithEvents NuevoCliente As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelProductos As Panel
    Friend WithEvents EliminarProducto As Button
    Friend WithEvents EditarPProducto As Button
    Friend WithEvents NuevoProducto As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BuscarProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents SupermercadoDataSet As SupermercadoDataSet
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As SupermercadoDataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents IDCLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSUPERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As SupermercadoDataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents IDPRODUCTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHACADUCIDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditarPCliente As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As SupermercadoDataSetTableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents IDEMPLEADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTIPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSUPERDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents EDADDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HORARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALARIOMENSUALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
