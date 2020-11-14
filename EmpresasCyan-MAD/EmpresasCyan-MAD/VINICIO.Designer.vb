<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ID_PANTALLAPRINCIPAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID_PANTALLAPRINCIPAL))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NóminageneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeadcounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NóminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Desktop
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SolicitudesToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.PuestosToolStripMenuItem})
        resources.ApplyResources(Me.ConsultasToolStripMenuItem, "ConsultasToolStripMenuItem")
        Me.ConsultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        resources.ApplyResources(Me.EmpleadosToolStripMenuItem, "EmpleadosToolStripMenuItem")
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        resources.ApplyResources(Me.EmpresasToolStripMenuItem, "EmpresasToolStripMenuItem")
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        resources.ApplyResources(Me.DepartamentosToolStripMenuItem, "DepartamentosToolStripMenuItem")
        '
        'PuestosToolStripMenuItem
        '
        Me.PuestosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PuestosToolStripMenuItem.Name = "PuestosToolStripMenuItem"
        resources.ApplyResources(Me.PuestosToolStripMenuItem, "PuestosToolStripMenuItem")
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.EmpresasToolStripMenuItem1, Me.DepartamentosToolStripMenuItem1, Me.PuestosToolStripMenuItem1})
        resources.ApplyResources(Me.RegistroToolStripMenuItem, "RegistroToolStripMenuItem")
        Me.RegistroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NóminageneralToolStripMenuItem, Me.HeadcounterToolStripMenuItem, Me.NóminaToolStripMenuItem})
        resources.ApplyResources(Me.ReportesToolStripMenuItem, "ReportesToolStripMenuItem")
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        '
        'NóminageneralToolStripMenuItem
        '
        Me.NóminageneralToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.NóminageneralToolStripMenuItem.Name = "NóminageneralToolStripMenuItem"
        resources.ApplyResources(Me.NóminageneralToolStripMenuItem, "NóminageneralToolStripMenuItem")
        '
        'HeadcounterToolStripMenuItem
        '
        Me.HeadcounterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HeadcounterToolStripMenuItem.Name = "HeadcounterToolStripMenuItem"
        resources.ApplyResources(Me.HeadcounterToolStripMenuItem, "HeadcounterToolStripMenuItem")
        '
        'NóminaToolStripMenuItem
        '
        Me.NóminaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.NóminaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.NóminaToolStripMenuItem.Name = "NóminaToolStripMenuItem"
        resources.ApplyResources(Me.NóminaToolStripMenuItem, "NóminaToolStripMenuItem")
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.AyudaToolStripMenuItem, "AyudaToolStripMenuItem")
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        '
        'SolicitudesToolStripMenuItem
        '
        Me.SolicitudesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop
        resources.ApplyResources(Me.SolicitudesToolStripMenuItem, "SolicitudesToolStripMenuItem")
        Me.SolicitudesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SolicitudesToolStripMenuItem.Name = "SolicitudesToolStripMenuItem"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        resources.ApplyResources(Me.EmpresaToolStripMenuItem, "EmpresaToolStripMenuItem")
        '
        'EmpresasToolStripMenuItem1
        '
        Me.EmpresasToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.EmpresasToolStripMenuItem1.Name = "EmpresasToolStripMenuItem1"
        resources.ApplyResources(Me.EmpresasToolStripMenuItem1, "EmpresasToolStripMenuItem1")
        '
        'DepartamentosToolStripMenuItem1
        '
        Me.DepartamentosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DepartamentosToolStripMenuItem1.Name = "DepartamentosToolStripMenuItem1"
        resources.ApplyResources(Me.DepartamentosToolStripMenuItem1, "DepartamentosToolStripMenuItem1")
        '
        'PuestosToolStripMenuItem1
        '
        Me.PuestosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PuestosToolStripMenuItem1.Name = "PuestosToolStripMenuItem1"
        resources.ApplyResources(Me.PuestosToolStripMenuItem1, "PuestosToolStripMenuItem1")
        '
        'ID_PANTALLAPRINCIPAL
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ID_PANTALLAPRINCIPAL"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NóminageneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeadcounterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NóminaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem1 As ToolStripMenuItem
End Class
