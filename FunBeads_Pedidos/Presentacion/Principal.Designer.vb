<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DisennoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecificoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecificoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecificoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem, Me.DisennoToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'DisennoToolStripMenuItem
        '
        Me.DisennoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem1, Me.AdministrarToolStripMenuItem, Me.VerToolStripMenuItem1, Me.EliminarToolStripMenuItem2})
        Me.DisennoToolStripMenuItem.Name = "DisennoToolStripMenuItem"
        Me.DisennoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.DisennoToolStripMenuItem.Text = "Diseños"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem, Me.AdministrarToolStripMenuItem1, Me.VerToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem2, Me.AdministrarToolStripMenuItem2, Me.VerToolStripMenuItem2, Me.EliminarToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CrearToolStripMenuItem.Text = "Crear"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspecificoToolStripMenuItem, Me.PorClienteToolStripMenuItem})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'EspecificoToolStripMenuItem
        '
        Me.EspecificoToolStripMenuItem.Name = "EspecificoToolStripMenuItem"
        Me.EspecificoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EspecificoToolStripMenuItem.Text = "Especifico"
        '
        'PorClienteToolStripMenuItem
        '
        Me.PorClienteToolStripMenuItem.Name = "PorClienteToolStripMenuItem"
        Me.PorClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PorClienteToolStripMenuItem.Text = "Por cliente"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CrearToolStripMenuItem1
        '
        Me.CrearToolStripMenuItem1.Name = "CrearToolStripMenuItem1"
        Me.CrearToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CrearToolStripMenuItem1.Text = "Crear"
        '
        'VerToolStripMenuItem1
        '
        Me.VerToolStripMenuItem1.Name = "VerToolStripMenuItem1"
        Me.VerToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VerToolStripMenuItem1.Text = "Ver"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'AdministrarToolStripMenuItem1
        '
        Me.AdministrarToolStripMenuItem1.Name = "AdministrarToolStripMenuItem1"
        Me.AdministrarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AdministrarToolStripMenuItem1.Text = "Administrar"
        '
        'CrearToolStripMenuItem2
        '
        Me.CrearToolStripMenuItem2.Name = "CrearToolStripMenuItem2"
        Me.CrearToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.CrearToolStripMenuItem2.Text = "Crear"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspecificoToolStripMenuItem2})
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspecificoToolStripMenuItem1, Me.PorTipoToolStripMenuItem})
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'VerToolStripMenuItem2
        '
        Me.VerToolStripMenuItem2.Name = "VerToolStripMenuItem2"
        Me.VerToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.VerToolStripMenuItem2.Text = "Ver"
        '
        'AdministrarToolStripMenuItem2
        '
        Me.AdministrarToolStripMenuItem2.Name = "AdministrarToolStripMenuItem2"
        Me.AdministrarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AdministrarToolStripMenuItem2.Text = "Administrar"
        '
        'EspecificoToolStripMenuItem1
        '
        Me.EspecificoToolStripMenuItem1.Name = "EspecificoToolStripMenuItem1"
        Me.EspecificoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EspecificoToolStripMenuItem1.Text = "Especifico"
        '
        'PorTipoToolStripMenuItem
        '
        Me.PorTipoToolStripMenuItem.Name = "PorTipoToolStripMenuItem"
        Me.PorTipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PorTipoToolStripMenuItem.Text = "Por tipo"
        '
        'EspecificoToolStripMenuItem2
        '
        Me.EspecificoToolStripMenuItem2.Name = "EspecificoToolStripMenuItem2"
        Me.EspecificoToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EspecificoToolStripMenuItem2.Text = "Especifico"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DisennoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecificoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EspecificoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PorTipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EspecificoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
