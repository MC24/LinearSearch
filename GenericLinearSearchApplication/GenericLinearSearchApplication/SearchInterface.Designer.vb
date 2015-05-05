<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchInterface
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
        Me.createIntegersButton = New System.Windows.Forms.Button()
        Me.createDoublesButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchKeyTextbox = New System.Windows.Forms.TextBox()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.dataListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'createIntegersButton
        '
        Me.createIntegersButton.Location = New System.Drawing.Point(12, 12)
        Me.createIntegersButton.Name = "createIntegersButton"
        Me.createIntegersButton.Size = New System.Drawing.Size(83, 59)
        Me.createIntegersButton.TabIndex = 0
        Me.createIntegersButton.Text = "Create integers"
        Me.createIntegersButton.UseVisualStyleBackColor = True
        '
        'createDoublesButton
        '
        Me.createDoublesButton.Location = New System.Drawing.Point(194, 12)
        Me.createDoublesButton.Name = "createDoublesButton"
        Me.createDoublesButton.Size = New System.Drawing.Size(83, 59)
        Me.createDoublesButton.TabIndex = 1
        Me.createDoublesButton.Text = "Create doubles"
        Me.createDoublesButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(12, 286)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(265, 23)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Search Key:"
        '
        'searchKeyTextbox
        '
        Me.searchKeyTextbox.Location = New System.Drawing.Point(111, 246)
        Me.searchKeyTextbox.Name = "searchKeyTextbox"
        Me.searchKeyTextbox.Size = New System.Drawing.Size(166, 20)
        Me.searchKeyTextbox.TabIndex = 4
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultLabel.Location = New System.Drawing.Point(12, 324)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(265, 23)
        Me.resultLabel.TabIndex = 5
        '
        'dataListBox
        '
        Me.dataListBox.FormattingEnabled = True
        Me.dataListBox.Location = New System.Drawing.Point(12, 77)
        Me.dataListBox.Name = "dataListBox"
        Me.dataListBox.Size = New System.Drawing.Size(265, 160)
        Me.dataListBox.TabIndex = 6
        '
        'SearchInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 362)
        Me.Controls.Add(Me.dataListBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.searchKeyTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.createDoublesButton)
        Me.Controls.Add(Me.createIntegersButton)
        Me.Name = "SearchInterface"
        Me.Text = "Generic Linear Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createIntegersButton As System.Windows.Forms.Button
    Friend WithEvents createDoublesButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchKeyTextbox As System.Windows.Forms.TextBox
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents dataListBox As System.Windows.Forms.ListBox

End Class
