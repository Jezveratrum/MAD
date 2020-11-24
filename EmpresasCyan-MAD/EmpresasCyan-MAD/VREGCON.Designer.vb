<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ID_VREGCON
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_TBNOMCON = New System.Windows.Forms.TextBox()
        Me.ID_BNREGINC = New System.Windows.Forms.Button()
        Me.ID_BNCANINC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(579, 719)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EmpresasCyan_MAD.My.Resources.Resources.fondo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 685)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ID_TBNOMCON)
        Me.GroupBox1.Controls.Add(Me.ID_BNREGINC)
        Me.GroupBox1.Controls.Add(Me.ID_BNCANINC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(610, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 722)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'ID_TBNOMCON
        '
        Me.ID_TBNOMCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TBNOMCON.Location = New System.Drawing.Point(52, 60)
        Me.ID_TBNOMCON.MaximumSize = New System.Drawing.Size(400, 156)
        Me.ID_TBNOMCON.MaxLength = 300
        Me.ID_TBNOMCON.MinimumSize = New System.Drawing.Size(510, 156)
        Me.ID_TBNOMCON.Name = "ID_TBNOMCON"
        Me.ID_TBNOMCON.Size = New System.Drawing.Size(510, 156)
        Me.ID_TBNOMCON.TabIndex = 17
        Me.ID_TBNOMCON.UseWaitCursor = True
        '
        'ID_BNREGINC
        '
        Me.ID_BNREGINC.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ID_BNREGINC.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_BNREGINC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ID_BNREGINC.Location = New System.Drawing.Point(442, 668)
        Me.ID_BNREGINC.Name = "ID_BNREGINC"
        Me.ID_BNREGINC.Size = New System.Drawing.Size(122, 36)
        Me.ID_BNREGINC.TabIndex = 22
        Me.ID_BNREGINC.Text = "Registrar"
        Me.ID_BNREGINC.UseVisualStyleBackColor = False
        '
        'ID_BNCANINC
        '
        Me.ID_BNCANINC.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ID_BNCANINC.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ID_BNCANINC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ID_BNCANINC.Location = New System.Drawing.Point(304, 668)
        Me.ID_BNCANINC.Name = "ID_BNCANINC"
        Me.ID_BNCANINC.Size = New System.Drawing.Size(122, 36)
        Me.ID_BNCANINC.TabIndex = 23
        Me.ID_BNCANINC.Text = "Cancelar"
        Me.ID_BNCANINC.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(59, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'ID_VREGCON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1234, 816)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1250, 855)
        Me.Name = "ID_VREGCON"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ID_TBNOMCON As TextBox
    Friend WithEvents ID_BNREGINC As Button
    Friend WithEvents ID_BNCANINC As Button
    Friend WithEvents Label1 As Label
End Class
