<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearDisenno
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.rbtn26mm = New System.Windows.Forms.RadioButton()
        Me.rbtn5mm = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblCrearDisenno = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(54, 114)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre: "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(54, 185)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción: "
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(255, 114)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(277, 26)
        Me.txtNombre.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(255, 185)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(277, 119)
        Me.txtDescripcion.TabIndex = 3
        '
        'rbtn26mm
        '
        Me.rbtn26mm.AutoSize = True
        Me.rbtn26mm.Checked = True
        Me.rbtn26mm.Location = New System.Drawing.Point(109, 413)
        Me.rbtn26mm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtn26mm.Name = "rbtn26mm"
        Me.rbtn26mm.Size = New System.Drawing.Size(75, 24)
        Me.rbtn26mm.TabIndex = 4
        Me.rbtn26mm.TabStop = True
        Me.rbtn26mm.Text = "2.6mm"
        Me.rbtn26mm.UseVisualStyleBackColor = True
        '
        'rbtn5mm
        '
        Me.rbtn5mm.AutoSize = True
        Me.rbtn5mm.Location = New System.Drawing.Point(307, 413)
        Me.rbtn5mm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtn5mm.Name = "rbtn5mm"
        Me.rbtn5mm.Size = New System.Drawing.Size(62, 24)
        Me.rbtn5mm.TabIndex = 5
        Me.rbtn5mm.Text = "5mm"
        Me.rbtn5mm.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(368, 471)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(112, 35)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Agregar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblCrearDisenno
        '
        Me.lblCrearDisenno.AutoSize = True
        Me.lblCrearDisenno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearDisenno.Location = New System.Drawing.Point(230, 39)
        Me.lblCrearDisenno.Name = "lblCrearDisenno"
        Me.lblCrearDisenno.Size = New System.Drawing.Size(139, 25)
        Me.lblCrearDisenno.TabIndex = 7
        Me.lblCrearDisenno.Text = "Crear Diseño"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(54, 345)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(61, 20)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio: "
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(255, 339)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(277, 26)
        Me.txtPrecio.TabIndex = 9
        '
        'CrearDisenno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 569)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCrearDisenno)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.rbtn5mm)
        Me.Controls.Add(Me.rbtn26mm)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblNombre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CrearDisenno"
        Me.Text = "Crear Diseño"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents rbtn26mm As RadioButton
    Friend WithEvents rbtn5mm As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblCrearDisenno As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
End Class
