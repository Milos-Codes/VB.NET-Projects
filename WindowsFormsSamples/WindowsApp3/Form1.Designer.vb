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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.LabelB = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelPovrsina = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(56, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(409, 254)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Location = New System.Drawing.Point(63, 301)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(15, 16)
        Me.LabelA.TabIndex = 1
        Me.LabelA.Text = "a"
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.Location = New System.Drawing.Point(484, 131)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(15, 16)
        Me.LabelB.TabIndex = 2
        Me.LabelB.Text = "b"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 302)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 22)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(522, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 22)
        Me.TextBox2.TabIndex = 4
        '
        'LabelPovrsina
        '
        Me.LabelPovrsina.AutoSize = True
        Me.LabelPovrsina.Location = New System.Drawing.Point(64, 385)
        Me.LabelPovrsina.Name = "LabelPovrsina"
        Me.LabelPovrsina.Size = New System.Drawing.Size(154, 16)
        Me.LabelPovrsina.TabIndex = 5
        Me.LabelPovrsina.Text = "Povrsina pravougaonika"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(264, 381)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 22)
        Me.TextBox3.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LabelPovrsina)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelB)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelA As Label
    Friend WithEvents LabelB As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelPovrsina As Label
    Friend WithEvents TextBox3 As TextBox
End Class
