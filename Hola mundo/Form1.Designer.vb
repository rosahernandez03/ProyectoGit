<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btntexto = New System.Windows.Forms.Button()
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.Borrartexto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btntexto
        '
        Me.Btntexto.Location = New System.Drawing.Point(97, 79)
        Me.Btntexto.Name = "Btntexto"
        Me.Btntexto.Size = New System.Drawing.Size(75, 23)
        Me.Btntexto.TabIndex = 0
        Me.Btntexto.Text = "Hola mundo"
        Me.Btntexto.UseVisualStyleBackColor = True
        '
        'txttexto
        '
        Me.txttexto.Location = New System.Drawing.Point(97, 44)
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(252, 20)
        Me.txttexto.TabIndex = 1
        '
        'Borrartexto
        '
        Me.Borrartexto.Location = New System.Drawing.Point(285, 78)
        Me.Borrartexto.Name = "Borrartexto"
        Me.Borrartexto.Size = New System.Drawing.Size(75, 23)
        Me.Borrartexto.TabIndex = 2
        Me.Borrartexto.Text = "Borrar texto"
        Me.Borrartexto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Borrartexto)
        Me.Controls.Add(Me.txttexto)
        Me.Controls.Add(Me.Btntexto)
        Me.Name = "Form1"
        Me.Text = "Hola mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btntexto As Button
    Friend WithEvents txttexto As TextBox
    Friend WithEvents Borrartexto As Button
End Class
