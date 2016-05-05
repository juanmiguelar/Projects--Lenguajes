<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDisennos
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
        Me.dgridVerDisennos = New System.Windows.Forms.DataGridView()
        Me.btnCargar = New System.Windows.Forms.Button()
        CType(Me.dgridVerDisennos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridVerDisennos
        '
        Me.dgridVerDisennos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgridVerDisennos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridVerDisennos.Location = New System.Drawing.Point(63, 43)
        Me.dgridVerDisennos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgridVerDisennos.Name = "dgridVerDisennos"
        Me.dgridVerDisennos.Size = New System.Drawing.Size(588, 420)
        Me.dgridVerDisennos.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(489, 517)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(163, 51)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar diseños"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'VerDisennos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 580)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.dgridVerDisennos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "VerDisennos"
        Me.Text = "Ver Diseños"
        CType(Me.dgridVerDisennos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgridVerDisennos As DataGridView
    Friend WithEvents btnCargar As Button
End Class
