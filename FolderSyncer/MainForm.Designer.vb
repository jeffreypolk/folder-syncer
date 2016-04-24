<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.btnSync = New System.Windows.Forms.Button()
        Me.bgAnalyze = New System.ComponentModel.BackgroundWorker()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(450, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(29, 43)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(415, 20)
        Me.txtSource.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Source Folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Target Folder"
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(29, 108)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(415, 20)
        Me.txtTarget.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(450, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(29, 152)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalyze.TabIndex = 6
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'btnSync
        '
        Me.btnSync.Location = New System.Drawing.Point(121, 152)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(75, 23)
        Me.btnSync.TabIndex = 0
        Me.btnSync.Text = "Synchronize"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'bgAnalyze
        '
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(212, 157)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 198)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSync)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Folder Syncer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
    Friend WithEvents btnSync As System.Windows.Forms.Button
    Friend WithEvents bgAnalyze As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
