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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAX CALCULATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(290, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(251, 41)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightCoral
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 69)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(333, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 41)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightCoral
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(625, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 69)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TAX RATE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(646, 135)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 41)
        Me.ComboBox2.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(505, 205)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 41)
        Me.TextBox2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 92)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(869, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 92)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(530, 188)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1023, 576)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "TAX CALCULATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
End Class
