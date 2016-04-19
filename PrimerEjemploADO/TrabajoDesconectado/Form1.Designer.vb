<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.EjemploTipado = New TrabajoDesconectado.EjemploTipado()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New TrabajoDesconectado.EjemploTipadoTableAdapters.PersonTableAdapter()
        Me.BusinessEntityIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameStyleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuffixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPromotionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalContactInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DemographicsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RowguidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjemploTipado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDatos
        '
        Me.grdDatos.AutoGenerateColumns = False
        Me.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BusinessEntityIDDataGridViewTextBoxColumn, Me.PersonTypeDataGridViewTextBoxColumn, Me.NameStyleDataGridViewCheckBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SuffixDataGridViewTextBoxColumn, Me.EmailPromotionDataGridViewTextBoxColumn, Me.AdditionalContactInfoDataGridViewTextBoxColumn, Me.DemographicsDataGridViewTextBoxColumn, Me.RowguidDataGridViewTextBoxColumn, Me.ModifiedDateDataGridViewTextBoxColumn})
        Me.grdDatos.DataSource = Me.PersonBindingSource1
        Me.grdDatos.Location = New System.Drawing.Point(21, 12)
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.Size = New System.Drawing.Size(881, 361)
        Me.grdDatos.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(21, 395)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(827, 395)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'EjemploTipado
        '
        Me.EjemploTipado.DataSetName = "EjemploTipado"
        Me.EjemploTipado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.EjemploTipado
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'BusinessEntityIDDataGridViewTextBoxColumn
        '
        Me.BusinessEntityIDDataGridViewTextBoxColumn.DataPropertyName = "BusinessEntityID"
        Me.BusinessEntityIDDataGridViewTextBoxColumn.HeaderText = "BusinessEntityID"
        Me.BusinessEntityIDDataGridViewTextBoxColumn.Name = "BusinessEntityIDDataGridViewTextBoxColumn"
        '
        'PersonTypeDataGridViewTextBoxColumn
        '
        Me.PersonTypeDataGridViewTextBoxColumn.DataPropertyName = "PersonType"
        Me.PersonTypeDataGridViewTextBoxColumn.HeaderText = "PersonType"
        Me.PersonTypeDataGridViewTextBoxColumn.Name = "PersonTypeDataGridViewTextBoxColumn"
        '
        'NameStyleDataGridViewCheckBoxColumn
        '
        Me.NameStyleDataGridViewCheckBoxColumn.DataPropertyName = "NameStyle"
        Me.NameStyleDataGridViewCheckBoxColumn.HeaderText = "NameStyle"
        Me.NameStyleDataGridViewCheckBoxColumn.Name = "NameStyleDataGridViewCheckBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'SuffixDataGridViewTextBoxColumn
        '
        Me.SuffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.HeaderText = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.Name = "SuffixDataGridViewTextBoxColumn"
        '
        'EmailPromotionDataGridViewTextBoxColumn
        '
        Me.EmailPromotionDataGridViewTextBoxColumn.DataPropertyName = "EmailPromotion"
        Me.EmailPromotionDataGridViewTextBoxColumn.HeaderText = "EmailPromotion"
        Me.EmailPromotionDataGridViewTextBoxColumn.Name = "EmailPromotionDataGridViewTextBoxColumn"
        '
        'AdditionalContactInfoDataGridViewTextBoxColumn
        '
        Me.AdditionalContactInfoDataGridViewTextBoxColumn.DataPropertyName = "AdditionalContactInfo"
        Me.AdditionalContactInfoDataGridViewTextBoxColumn.HeaderText = "AdditionalContactInfo"
        Me.AdditionalContactInfoDataGridViewTextBoxColumn.Name = "AdditionalContactInfoDataGridViewTextBoxColumn"
        '
        'DemographicsDataGridViewTextBoxColumn
        '
        Me.DemographicsDataGridViewTextBoxColumn.DataPropertyName = "Demographics"
        Me.DemographicsDataGridViewTextBoxColumn.HeaderText = "Demographics"
        Me.DemographicsDataGridViewTextBoxColumn.Name = "DemographicsDataGridViewTextBoxColumn"
        '
        'RowguidDataGridViewTextBoxColumn
        '
        Me.RowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.HeaderText = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.Name = "RowguidDataGridViewTextBoxColumn"
        '
        'ModifiedDateDataGridViewTextBoxColumn
        '
        Me.ModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate"
        Me.ModifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate"
        Me.ModifiedDateDataGridViewTextBoxColumn.Name = "ModifiedDateDataGridViewTextBoxColumn"
        '
        'PersonBindingSource1
        '
        Me.PersonBindingSource1.DataMember = "Person"
        Me.PersonBindingSource1.DataSource = Me.EjemploTipado
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 430)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.grdDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjemploTipado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdDatos As DataGridView
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents EjemploTipado As EjemploTipado
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As EjemploTipadoTableAdapters.PersonTableAdapter
    Friend WithEvents BusinessEntityIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameStyleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuffixDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPromotionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalContactInfoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DemographicsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RowguidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonBindingSource1 As BindingSource
End Class
