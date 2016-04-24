<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsForm))
        Me.lvResults = New System.Windows.Forms.ListView()
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvResults
        '
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chType, Me.chFile})
        Me.lvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvResults.Location = New System.Drawing.Point(0, 0)
        Me.lvResults.MultiSelect = False
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(815, 291)
        Me.lvResults.TabIndex = 0
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'chType
        '
        Me.chType.Text = "Type"
        Me.chType.Width = 120
        '
        'chFile
        '
        Me.chFile.Text = "File"
        Me.chFile.Width = 650
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 291)
        Me.Controls.Add(Me.lvResults)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResultsForm"
        Me.Text = "Results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents chType As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFile As System.Windows.Forms.ColumnHeader
End Class
