<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnSinus = New System.Windows.Forms.Button()
        Me.btnCosinus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unesi ugao"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(162, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(473, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(162, 260)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(473, 22)
        Me.TextBox2.TabIndex = 2
        '
        'btnSinus
        '
        Me.btnSinus.Location = New System.Drawing.Point(162, 106)
        Me.btnSinus.Name = "btnSinus"
        Me.btnSinus.Size = New System.Drawing.Size(129, 118)
        Me.btnSinus.TabIndex = 3
        Me.btnSinus.Text = "sin(x)"
        Me.btnSinus.UseVisualStyleBackColor = True
        '
        'btnCosinus
        '
        Me.btnCosinus.Location = New System.Drawing.Point(489, 104)
        Me.btnCosinus.Name = "btnCosinus"
        Me.btnCosinus.Size = New System.Drawing.Size(136, 120)
        Me.btnCosinus.TabIndex = 4
        Me.btnCosinus.Text = "cos(x)"
        Me.btnCosinus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 334)
        Me.Controls.Add(Me.btnCosinus)
        Me.Controls.Add(Me.btnSinus)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnSinus As Button
    Friend WithEvents btnCosinus As Button
End Class
