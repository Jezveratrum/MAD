<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ID_VREGPUE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID_VREGPUE))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID_CBEMPRPUE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID_TBNOMPUE = New System.Windows.Forms.TextBox()
        Me.ID_TBNIVSALPUE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID_BNCANPUE = New System.Windows.Forms.Button()
        Me.ID_BNREGPUE = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ID_CBEMPRPUE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ID_TBNOMPUE)
        Me.GroupBox1.Controls.Add(Me.ID_TBNIVSALPUE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(571, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 719)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE PUESTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(73, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Empresa"
        '
        'ID_CBEMPRPUE
        '
        Me.ID_CBEMPRPUE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ID_CBEMPRPUE.FormattingEnabled = True
        Me.ID_CBEMPRPUE.Location = New System.Drawing.Point(66, 164)
        Me.ID_CBEMPRPUE.Name = "ID_CBEMPRPUE"
        Me.ID_CBEMPRPUE.Size = New System.Drawing.Size(476, 28)
        Me.ID_CBEMPRPUE.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(73, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nivel salarial"
        '
        'ID_TBNOMPUE
        '
        Me.ID_TBNOMPUE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TBNOMPUE.Location = New System.Drawing.Point(66, 50)
        Me.ID_TBNOMPUE.Name = "ID_TBNOMPUE"
        Me.ID_TBNOMPUE.Size = New System.Drawing.Size(476, 26)
        Me.ID_TBNOMPUE.TabIndex = 13
        '
        'ID_TBNIVSALPUE
        '
        Me.ID_TBNIVSALPUE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TBNIVSALPUE.Location = New System.Drawing.Point(66, 107)
        Me.ID_TBNIVSALPUE.Name = "ID_TBNIVSALPUE"
        Me.ID_TBNIVSALPUE.Size = New System.Drawing.Size(476, 26)
        Me.ID_TBNIVSALPUE.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(73, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'ID_BNCANPUE
        '
        Me.ID_BNCANPUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ID_BNCANPUE.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_BNCANPUE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ID_BNCANPUE.Location = New System.Drawing.Point(842, 644)
        Me.ID_BNCANPUE.Name = "ID_BNCANPUE"
        Me.ID_BNCANPUE.Size = New System.Drawing.Size(122, 36)
        Me.ID_BNCANPUE.TabIndex = 17
        Me.ID_BNCANPUE.Text = "Cancelar"
        Me.ID_BNCANPUE.UseVisualStyleBackColor = False
        '
        'ID_BNREGPUE
        '
        Me.ID_BNREGPUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ID_BNREGPUE.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_BNREGPUE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ID_BNREGPUE.Location = New System.Drawing.Point(973, 644)
        Me.ID_BNREGPUE.Name = "ID_BNREGPUE"
        Me.ID_BNREGPUE.Size = New System.Drawing.Size(122, 36)
        Me.ID_BNREGPUE.TabIndex = 16
        Me.ID_BNREGPUE.Text = "Registrar"
        Me.ID_BNREGPUE.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(25, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(526, 716)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.fondo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(13, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 685)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ID_VREGPUE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1234, 816)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ID_BNCANPUE)
        Me.Controls.Add(Me.ID_BNREGPUE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1250, 855)
        Me.MinimumSize = New System.Drawing.Size(1250, 855)
        Me.Name = "ID_VREGPUE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPRESAS CYAN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ID_TBNOMPUE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_CBEMPRPUE As ComboBox
    Friend WithEvents ID_TBNIVSALPUE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ID_BNCANPUE As Button
    Friend WithEvents ID_BNREGPUE As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
