<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ID_VREGDEP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID_VREGDEP))
        Me.ID_BNREGDEP = New System.Windows.Forms.Button()
        Me.ID_TBSALBASDEP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID_CBEMPRDEP = New System.Windows.Forms.ComboBox()
        Me.ID_TBNOMDEP = New System.Windows.Forms.TextBox()
        Me.ID_BNCANDEP = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_BNREGDEP
        '
        Me.ID_BNREGDEP.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ID_BNREGDEP.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_BNREGDEP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ID_BNREGDEP.Location = New System.Drawing.Point(401, 683)
        Me.ID_BNREGDEP.Name = "ID_BNREGDEP"
        Me.ID_BNREGDEP.Size = New System.Drawing.Size(122, 36)
        Me.ID_BNREGDEP.TabIndex = 19
        Me.ID_BNREGDEP.Text = "Registrar"
        Me.ID_BNREGDEP.UseVisualStyleBackColor = False
        '
        'ID_TBSALBASDEP
        '
        Me.ID_TBSALBASDEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TBSALBASDEP.Location = New System.Drawing.Point(47, 145)
        Me.ID_TBSALBASDEP.Name = "ID_TBSALBASDEP"
        Me.ID_TBSALBASDEP.Size = New System.Drawing.Size(476, 26)
        Me.ID_TBSALBASDEP.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(54, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Salario base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(54, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Empresa"
        '
        'ID_CBEMPRDEP
        '
        Me.ID_CBEMPRDEP.FormattingEnabled = True
        Me.ID_CBEMPRDEP.Location = New System.Drawing.Point(47, 211)
        Me.ID_CBEMPRDEP.Name = "ID_CBEMPRDEP"
        Me.ID_CBEMPRDEP.Size = New System.Drawing.Size(476, 24)
        Me.ID_CBEMPRDEP.TabIndex = 14
        '
        'ID_TBNOMDEP
        '
        Me.ID_TBNOMDEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TBNOMDEP.Location = New System.Drawing.Point(47, 85)
        Me.ID_TBNOMDEP.Name = "ID_TBNOMDEP"
        Me.ID_TBNOMDEP.Size = New System.Drawing.Size(476, 26)
        Me.ID_TBNOMDEP.TabIndex = 13
        '
        'ID_BNCANDEP
        '
        Me.ID_BNCANDEP.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ID_BNCANDEP.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_BNCANDEP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ID_BNCANDEP.Location = New System.Drawing.Point(270, 683)
        Me.ID_BNCANDEP.Name = "ID_BNCANDEP"
        Me.ID_BNCANDEP.Size = New System.Drawing.Size(122, 36)
        Me.ID_BNCANDEP.TabIndex = 20
        Me.ID_BNCANDEP.Text = "Cancelar"
        Me.ID_BNCANDEP.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ID_BNREGDEP)
        Me.GroupBox1.Controls.Add(Me.ID_TBSALBASDEP)
        Me.GroupBox1.Controls.Add(Me.ID_BNCANDEP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ID_CBEMPRDEP)
        Me.GroupBox1.Controls.Add(Me.ID_TBNOMDEP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(30, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 766)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE DEPARTAMENTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(54, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(629, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 765)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.fondo_2
        Me.PictureBox1.Location = New System.Drawing.Point(20, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(510, 723)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'ID_VREGDEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1234, 816)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1250, 855)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1250, 855)
        Me.Name = "ID_VREGDEP"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ID_BNREGDEP As Button
    Friend WithEvents ID_TBSALBASDEP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_CBEMPRDEP As ComboBox
    Friend WithEvents ID_TBNOMDEP As TextBox
    Friend WithEvents ID_BNCANDEP As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
