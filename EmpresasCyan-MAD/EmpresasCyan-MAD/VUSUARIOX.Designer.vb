<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ID_VUSUARIOX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID_VUSUARIOX))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONEMPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCONNOM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNRESPAG = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID_MNCERSESEMPL = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(23, 94)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1192, 700)
        Me.DataGridView2.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1237, 10)
        Me.DataGridView1.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Desktop
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.ID_MNCONEMPL, Me.ID_MNCERSESEMPL})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 7, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 57)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.EmpresasCyan_image2
        Me.ConsultasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConsultasToolStripMenuItem.Enabled = False
        Me.ConsultasToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ConsultasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(111, 48)
        Me.ConsultasToolStripMenuItem.Text = "                  "
        '
        'ID_MNCONEMPL
        '
        Me.ID_MNCONEMPL.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ID_MNCONNOM, Me.ID_MNRESPAG})
        Me.ID_MNCONEMPL.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_MNCONEMPL.ForeColor = System.Drawing.Color.DarkGray
        Me.ID_MNCONEMPL.Name = "ID_MNCONEMPL"
        Me.ID_MNCONEMPL.Size = New System.Drawing.Size(117, 48)
        Me.ID_MNCONEMPL.Text = "CONSULTAS"
        '
        'ID_MNCONNOM
        '
        Me.ID_MNCONNOM.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNCONNOM.Name = "ID_MNCONNOM"
        Me.ID_MNCONNOM.Size = New System.Drawing.Size(210, 22)
        Me.ID_MNCONNOM.Text = "Nómina"
        '
        'ID_MNRESPAG
        '
        Me.ID_MNRESPAG.ForeColor = System.Drawing.Color.DimGray
        Me.ID_MNRESPAG.Name = "ID_MNRESPAG"
        Me.ID_MNRESPAG.Size = New System.Drawing.Size(210, 22)
        Me.ID_MNRESPAG.Text = "Resumen de pagos"
        '
        'ID_MNCERSESEMPL
        '
        Me.ID_MNCERSESEMPL.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_MNCERSESEMPL.ForeColor = System.Drawing.Color.DarkGray
        Me.ID_MNCERSESEMPL.Name = "ID_MNCERSESEMPL"
        Me.ID_MNCERSESEMPL.Size = New System.Drawing.Size(149, 48)
        Me.ID_MNCERSESEMPL.Text = "CERRAR SESIÓN"
        '
        'ID_VUSUARIOX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.fondo_2
        Me.ClientSize = New System.Drawing.Size(1234, 816)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1250, 855)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1250, 855)
        Me.Name = "ID_VUSUARIOX"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID_MNCONEMPL As ToolStripMenuItem
    Friend WithEvents ID_MNCONNOM As ToolStripMenuItem
    Friend WithEvents ID_MNCERSESEMPL As ToolStripMenuItem
    Friend WithEvents ID_MNRESPAG As ToolStripMenuItem
End Class
