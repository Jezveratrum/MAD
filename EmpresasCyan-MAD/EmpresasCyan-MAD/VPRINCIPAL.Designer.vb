<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ID_VPRINCIPAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID_VPRINCIPAL))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCON = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONEMPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONEMPR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONDEP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONPUE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONINC = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREG = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGEMPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGEMPR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGDEP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGPUE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGINC = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGINCGEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGINCEMPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGPER = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGPERGEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGPERGENEMPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGDED = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGDEDGEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREGDEDEMPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREPNOMGEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREPHEA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNREPNOM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCERSESGER = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.DataGridView2, "DataGridView2")
        Me.DataGridView2.Name = "DataGridView2"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.EmpresasCyan_image2
        resources.ApplyResources(Me.ConsultasToolStripMenuItem, "ConsultasToolStripMenuItem")
        Me.ConsultasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        '
        'ID_MNCON
        '
        Me.ID_MNCON.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNCONEMPL, Me.ID_MNCONEMPR, Me.ID_MNCONDEP, Me.ID_MNCONPUE, Me.ID_MNCONINC})
        resources.ApplyResources(Me.ID_MNCON, "ID_MNCON")
        Me.ID_MNCON.ForeColor = System.Drawing.Color.DarkGray
        Me.ID_MNCON.Name = "ID_MNCON"
        '
        'ID_MNCONEMPL
        '
        Me.ID_MNCONEMPL.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNCONEMPL.Name = "ID_MNCONEMPL"
        resources.ApplyResources(Me.ID_MNCONEMPL, "ID_MNCONEMPL")
        '
        'ID_MNCONEMPR
        '
        Me.ID_MNCONEMPR.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNCONEMPR.Name = "ID_MNCONEMPR"
        resources.ApplyResources(Me.ID_MNCONEMPR, "ID_MNCONEMPR")
        '
        'ID_MNCONDEP
        '
        Me.ID_MNCONDEP.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNCONDEP.Name = "ID_MNCONDEP"
        resources.ApplyResources(Me.ID_MNCONDEP, "ID_MNCONDEP")
        '
        'ID_MNCONPUE
        '
        Me.ID_MNCONPUE.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNCONPUE.Name = "ID_MNCONPUE"
        resources.ApplyResources(Me.ID_MNCONPUE, "ID_MNCONPUE")
        '
        'ID_MNCONINC
        '
        Me.ID_MNCONINC.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNCONINC.Name = "ID_MNCONINC"
        resources.ApplyResources(Me.ID_MNCONINC, "ID_MNCONINC")
        '
        'ID_MNREG
        '
        Me.ID_MNREG.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNREGEMPL, Me.ID_MNREGEMPR, Me.ID_MNREGDEP, Me.ID_MNREGPUE, Me.ID_MNREGINC, Me.ID_MNREGPER, Me.ID_MNREGDED})
        resources.ApplyResources(Me.ID_MNREG, "ID_MNREG")
        Me.ID_MNREG.ForeColor = System.Drawing.Color.DarkGray
        Me.ID_MNREG.Name = "ID_MNREG"
        '
        'ID_MNREGEMPL
        '
        Me.ID_MNREGEMPL.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGEMPL.Name = "ID_MNREGEMPL"
        resources.ApplyResources(Me.ID_MNREGEMPL, "ID_MNREGEMPL")
        '
        'ID_MNREGEMPR
        '
        Me.ID_MNREGEMPR.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGEMPR.Name = "ID_MNREGEMPR"
        resources.ApplyResources(Me.ID_MNREGEMPR, "ID_MNREGEMPR")
        '
        'ID_MNREGDEP
        '
        Me.ID_MNREGDEP.BackColor = System.Drawing.SystemColors.Control
        Me.ID_MNREGDEP.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGDEP.Name = "ID_MNREGDEP"
        resources.ApplyResources(Me.ID_MNREGDEP, "ID_MNREGDEP")
        '
        'ID_MNREGPUE
        '
        Me.ID_MNREGPUE.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGPUE.Name = "ID_MNREGPUE"
        resources.ApplyResources(Me.ID_MNREGPUE, "ID_MNREGPUE")
        '
        'ID_MNREGINC
        '
        Me.ID_MNREGINC.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNREGINCGEN, Me.ID_MNREGINCEMPL})
        Me.ID_MNREGINC.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGINC.Name = "ID_MNREGINC"
        resources.ApplyResources(Me.ID_MNREGINC, "ID_MNREGINC")
        '
        'ID_MNREGINCGEN
        '
        Me.ID_MNREGINCGEN.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGINCGEN.Name = "ID_MNREGINCGEN"
        resources.ApplyResources(Me.ID_MNREGINCGEN, "ID_MNREGINCGEN")
        '
        'ID_MNREGINCEMPL
        '
        Me.ID_MNREGINCEMPL.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGINCEMPL.Name = "ID_MNREGINCEMPL"
        resources.ApplyResources(Me.ID_MNREGINCEMPL, "ID_MNREGINCEMPL")
        '
        'ID_MNREGPER
        '
        Me.ID_MNREGPER.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNREGPERGEN, Me.ID_MNREGPERGENEMPL})
        Me.ID_MNREGPER.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGPER.Name = "ID_MNREGPER"
        resources.ApplyResources(Me.ID_MNREGPER, "ID_MNREGPER")
        '
        'ID_MNREGPERGEN
        '
        Me.ID_MNREGPERGEN.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGPERGEN.Name = "ID_MNREGPERGEN"
        resources.ApplyResources(Me.ID_MNREGPERGEN, "ID_MNREGPERGEN")
        '
        'ID_MNREGPERGENEMPL
        '
        Me.ID_MNREGPERGENEMPL.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGPERGENEMPL.Name = "ID_MNREGPERGENEMPL"
        resources.ApplyResources(Me.ID_MNREGPERGENEMPL, "ID_MNREGPERGENEMPL")
        '
        'ID_MNREGDED
        '
        Me.ID_MNREGDED.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNREGDEDGEN, Me.ID_MNREGDEDEMPL})
        Me.ID_MNREGDED.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGDED.Name = "ID_MNREGDED"
        resources.ApplyResources(Me.ID_MNREGDED, "ID_MNREGDED")
        '
        'ID_MNREGDEDGEN
        '
        Me.ID_MNREGDEDGEN.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGDEDGEN.Name = "ID_MNREGDEDGEN"
        resources.ApplyResources(Me.ID_MNREGDEDGEN, "ID_MNREGDEDGEN")
        '
        'ID_MNREGDEDEMPL
        '
        Me.ID_MNREGDEDEMPL.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREGDEDEMPL.Name = "ID_MNREGDEDEMPL"
        resources.ApplyResources(Me.ID_MNREGDEDEMPL, "ID_MNREGDEDEMPL")
        '
        'ID_MNREP
        '
        Me.ID_MNREP.BackColor = System.Drawing.SystemColors.Desktop
        Me.ID_MNREP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNREPNOMGEN, Me.ID_MNREPHEA, Me.ID_MNREPNOM})
        resources.ApplyResources(Me.ID_MNREP, "ID_MNREP")
        Me.ID_MNREP.ForeColor = System.Drawing.Color.DarkGray
        Me.ID_MNREP.Name = "ID_MNREP"
        '
        'ID_MNREPNOMGEN
        '
        Me.ID_MNREPNOMGEN.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREPNOMGEN.Name = "ID_MNREPNOMGEN"
        resources.ApplyResources(Me.ID_MNREPNOMGEN, "ID_MNREPNOMGEN")
        '
        'ID_MNREPHEA
        '
        Me.ID_MNREPHEA.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREPHEA.Name = "ID_MNREPHEA"
        resources.ApplyResources(Me.ID_MNREPHEA, "ID_MNREPHEA")
        '
        'ID_MNREPNOM
        '
        Me.ID_MNREPNOM.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNREPNOM.Name = "ID_MNREPNOM"
        resources.ApplyResources(Me.ID_MNREPNOM, "ID_MNREPNOM")
        '
        'ID_MNCERSESGER
        '
        resources.ApplyResources(Me.ID_MNCERSESGER, "ID_MNCERSESGER")
        Me.ID_MNCERSESGER.ForeColor = System.Drawing.Color.DarkGray
        Me.ID_MNCERSESGER.Name = "ID_MNCERSESGER"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Desktop
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.ID_MNCON, Me.ID_MNREG, Me.ID_MNREP, Me.ID_MNCERSESGER})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.DataGridView3, "DataGridView3")
        Me.DataGridView3.Name = "DataGridView3"
        '
        'ID_VPRINCIPAL
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.fondo_2
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ID_VPRINCIPAL"
        Me.ShowIcon = False
        Me.TopMost = True
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID_MNCON As ToolStripMenuItem
    Friend WithEvents ID_MNCONEMPL As ToolStripMenuItem
    Friend WithEvents ID_MNCONEMPR As ToolStripMenuItem
    Friend WithEvents ID_MNCONDEP As ToolStripMenuItem
    Friend WithEvents ID_MNCONPUE As ToolStripMenuItem
    Friend WithEvents ID_MNCONINC As ToolStripMenuItem
    Friend WithEvents ID_MNREG As ToolStripMenuItem
    Friend WithEvents ID_MNREGEMPL As ToolStripMenuItem
    Friend WithEvents ID_MNREGEMPR As ToolStripMenuItem
    Friend WithEvents ID_MNREGDEP As ToolStripMenuItem
    Friend WithEvents ID_MNREGPUE As ToolStripMenuItem
    Friend WithEvents ID_MNREGINC As ToolStripMenuItem
    Friend WithEvents ID_MNREP As ToolStripMenuItem
    Friend WithEvents ID_MNREPNOMGEN As ToolStripMenuItem
    Friend WithEvents ID_MNREPHEA As ToolStripMenuItem
    Friend WithEvents ID_MNREPNOM As ToolStripMenuItem
    Friend WithEvents ID_MNCERSESGER As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ID_MNREGPER As ToolStripMenuItem
    Friend WithEvents ID_MNREGPERGEN As ToolStripMenuItem
    Friend WithEvents ID_MNREGPERGENEMPL As ToolStripMenuItem
    Friend WithEvents ID_MNREGDED As ToolStripMenuItem
    Friend WithEvents ID_MNREGDEDGEN As ToolStripMenuItem
    Friend WithEvents ID_MNREGDEDEMPL As ToolStripMenuItem
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents ID_MNREGINCGEN As ToolStripMenuItem
    Friend WithEvents ID_MNREGINCEMPL As ToolStripMenuItem
End Class
