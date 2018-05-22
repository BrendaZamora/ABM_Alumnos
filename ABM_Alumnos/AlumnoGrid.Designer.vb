<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoGrid
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Nuevo = New System.Windows.Forms.Button
        Me.Elimina = New System.Windows.Forms.Button
        Me.Modifica = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        Me.AlumnoColectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NyaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoColectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NyaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.NacimientoDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnoColectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(509, 219)
        Me.DataGridView1.TabIndex = 0
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(147, 250)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(75, 32)
        Me.Nuevo.TabIndex = 1
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Elimina
        '
        Me.Elimina.Location = New System.Drawing.Point(240, 250)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(75, 32)
        Me.Elimina.TabIndex = 2
        Me.Elimina.Text = "Elimina"
        Me.Elimina.UseVisualStyleBackColor = True
        '
        'Modifica
        '
        Me.Modifica.Location = New System.Drawing.Point(332, 250)
        Me.Modifica.Name = "Modifica"
        Me.Modifica.Size = New System.Drawing.Size(75, 32)
        Me.Modifica.TabIndex = 3
        Me.Modifica.Text = "Modifica"
        Me.Modifica.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(426, 250)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 32)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'AlumnoColectionBindingSource
        '
        Me.AlumnoColectionBindingSource.DataSource = GetType(ABM_Alumnos.AlumnoColection)
        '
        'NyaDataGridViewTextBoxColumn
        '
        Me.NyaDataGridViewTextBoxColumn.DataPropertyName = "nya"
        Me.NyaDataGridViewTextBoxColumn.HeaderText = "nya"
        Me.NyaDataGridViewTextBoxColumn.Name = "NyaDataGridViewTextBoxColumn"
        Me.NyaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NacimientoDataGridViewTextBoxColumn
        '
        Me.NacimientoDataGridViewTextBoxColumn.DataPropertyName = "nacimiento"
        Me.NacimientoDataGridViewTextBoxColumn.HeaderText = "nacimiento"
        Me.NacimientoDataGridViewTextBoxColumn.Name = "NacimientoDataGridViewTextBoxColumn"
        Me.NacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlumnoGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 294)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Modifica)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AlumnoGrid"
        Me.Text = "AlumnoGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoColectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents Modifica As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents NyaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlumnoColectionBindingSource As System.Windows.Forms.BindingSource
End Class
