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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.open_btn = New System.Windows.Forms.Button()
        Me.view_txt = New System.Windows.Forms.RichTextBox()
        Me.statistics = New System.Windows.Forms.ListBox()
        Me.statistics_clk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.last = New System.Windows.Forms.TextBox()
        Me.disp_clk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dec = New System.Windows.Forms.RadioButton()
        Me.Asce = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.last_lines = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(2419, 1437)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 26)
        Me.TextBox4.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Location = New System.Drawing.Point(1501, 922)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(340, 68)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox1"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(149, 29)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(99, 24)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Descending"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(8, 29)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(91, 24)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Ascending"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(2800, 1437)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(36, 26)
        Me.TextBox5.TabIndex = 10
        '
        'open_btn
        '
        Me.open_btn.Font = New System.Drawing.Font("High Tower Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_btn.Location = New System.Drawing.Point(228, 18)
        Me.open_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.open_btn.Name = "open_btn"
        Me.open_btn.Size = New System.Drawing.Size(228, 55)
        Me.open_btn.TabIndex = 15
        Me.open_btn.Text = "Click to open and read a file "
        Me.open_btn.UseVisualStyleBackColor = True
        '
        'view_txt
        '
        Me.view_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.view_txt.Location = New System.Drawing.Point(26, 83)
        Me.view_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.view_txt.Name = "view_txt"
        Me.view_txt.Size = New System.Drawing.Size(791, 484)
        Me.view_txt.TabIndex = 16
        Me.view_txt.Text = ""
        '
        'statistics
        '
        Me.statistics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statistics.FormattingEnabled = True
        Me.statistics.ItemHeight = 20
        Me.statistics.Location = New System.Drawing.Point(850, 83)
        Me.statistics.Name = "statistics"
        Me.statistics.Size = New System.Drawing.Size(382, 484)
        Me.statistics.TabIndex = 17
        '
        'statistics_clk
        '
        Me.statistics_clk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statistics_clk.Font = New System.Drawing.Font("High Tower Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statistics_clk.Location = New System.Drawing.Point(905, 14)
        Me.statistics_clk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.statistics_clk.Name = "statistics_clk"
        Me.statistics_clk.Size = New System.Drawing.Size(228, 55)
        Me.statistics_clk.TabIndex = 18
        Me.statistics_clk.Text = "Click to display file statistics"
        Me.statistics_clk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.last)
        Me.GroupBox1.Controls.Add(Me.disp_clk)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.last_lines)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1238, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 559)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display last few lines"
        '
        'last
        '
        Me.last.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.last.Location = New System.Drawing.Point(36, 176)
        Me.last.Multiline = True
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(393, 358)
        Me.last.TabIndex = 20
        '
        'disp_clk
        '
        Me.disp_clk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.disp_clk.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disp_clk.Location = New System.Drawing.Point(145, 125)
        Me.disp_clk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.disp_clk.Name = "disp_clk"
        Me.disp_clk.Size = New System.Drawing.Size(127, 43)
        Me.disp_clk.TabIndex = 19
        Me.disp_clk.Text = "Display"
        Me.disp_clk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dec)
        Me.GroupBox2.Controls.Add(Me.Asce)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose lines order"
        '
        'dec
        '
        Me.dec.AutoSize = True
        Me.dec.Location = New System.Drawing.Point(209, 20)
        Me.dec.Name = "dec"
        Me.dec.Size = New System.Drawing.Size(92, 24)
        Me.dec.TabIndex = 4
        Me.dec.TabStop = True
        Me.dec.Text = "Decending"
        Me.dec.UseVisualStyleBackColor = True
        '
        'Asce
        '
        Me.Asce.AutoSize = True
        Me.Asce.Location = New System.Drawing.Point(48, 20)
        Me.Asce.Name = "Asce"
        Me.Asce.Size = New System.Drawing.Size(91, 24)
        Me.Asce.TabIndex = 0
        Me.Asce.TabStop = True
        Me.Asce.Text = "Ascending"
        Me.Asce.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "lines"
        '
        'last_lines
        '
        Me.last_lines.Location = New System.Drawing.Point(253, 35)
        Me.last_lines.Name = "last_lines"
        Me.last_lines.Size = New System.Drawing.Size(33, 26)
        Me.last_lines.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the button below to display last"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1706, 601)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.statistics_clk)
        Me.Controls.Add(Me.statistics)
        Me.Controls.Add(Me.view_txt)
        Me.Controls.Add(Me.open_btn)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents open_btn As System.Windows.Forms.Button
    Friend WithEvents view_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents statistics As System.Windows.Forms.ListBox
    Friend WithEvents statistics_clk As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dec As System.Windows.Forms.RadioButton
    Friend WithEvents Asce As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents last_lines As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents last As System.Windows.Forms.TextBox
    Friend WithEvents disp_clk As System.Windows.Forms.Button

End Class
