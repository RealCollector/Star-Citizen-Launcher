<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_GetLaunchPath = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_GetGamePath = New System.Windows.Forms.Button()
        Me.FolderBrowserL = New System.Windows.Forms.FolderBrowserDialog()
        Me.Lbl_LaunchPath = New System.Windows.Forms.Label()
        Me.Btn_Launch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_GamePath = New System.Windows.Forms.Label()
        Me.Lbl_BackupPath = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(49, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "                                    "
        '
        'Btn_GetLaunchPath
        '
        Me.Btn_GetLaunchPath.BackColor = System.Drawing.Color.DimGray
        Me.Btn_GetLaunchPath.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Btn_GetLaunchPath.FlatAppearance.BorderSize = 10
        Me.Btn_GetLaunchPath.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_GetLaunchPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_GetLaunchPath.Location = New System.Drawing.Point(283, 160)
        Me.Btn_GetLaunchPath.Name = "Btn_GetLaunchPath"
        Me.Btn_GetLaunchPath.Size = New System.Drawing.Size(127, 34)
        Me.Btn_GetLaunchPath.TabIndex = 4
        Me.Btn_GetLaunchPath.Text = "Select"
        Me.Btn_GetLaunchPath.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(82, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "                                     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Btn_GetGamePath
        '
        Me.Btn_GetGamePath.BackColor = System.Drawing.Color.DimGray
        Me.Btn_GetGamePath.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_GetGamePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_GetGamePath.Location = New System.Drawing.Point(283, 225)
        Me.Btn_GetGamePath.Name = "Btn_GetGamePath"
        Me.Btn_GetGamePath.Size = New System.Drawing.Size(127, 34)
        Me.Btn_GetGamePath.TabIndex = 4
        Me.Btn_GetGamePath.Text = "Select"
        Me.Btn_GetGamePath.UseVisualStyleBackColor = False
        '
        'Lbl_LaunchPath
        '
        Me.Lbl_LaunchPath.AutoSize = True
        Me.Lbl_LaunchPath.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_LaunchPath.Location = New System.Drawing.Point(430, 171)
        Me.Lbl_LaunchPath.Name = "Lbl_LaunchPath"
        Me.Lbl_LaunchPath.Size = New System.Drawing.Size(73, 15)
        Me.Lbl_LaunchPath.TabIndex = 6
        Me.Lbl_LaunchPath.Text = "asdfasdfasdf"
        '
        'Btn_Launch
        '
        Me.Btn_Launch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Launch.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Launch.Location = New System.Drawing.Point(949, 317)
        Me.Btn_Launch.Name = "Btn_Launch"
        Me.Btn_Launch.Size = New System.Drawing.Size(127, 34)
        Me.Btn_Launch.TabIndex = 7
        Me.Btn_Launch.Text = "Run SC"
        Me.Btn_Launch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(67, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "                                        "
        '
        'Lbl_GamePath
        '
        Me.Lbl_GamePath.AutoSize = True
        Me.Lbl_GamePath.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_GamePath.Location = New System.Drawing.Point(430, 235)
        Me.Lbl_GamePath.Name = "Lbl_GamePath"
        Me.Lbl_GamePath.Size = New System.Drawing.Size(95, 15)
        Me.Lbl_GamePath.TabIndex = 10
        Me.Lbl_GamePath.Text = "asdfasdfasdfasdf"
        '
        'Lbl_BackupPath
        '
        Me.Lbl_BackupPath.AutoSize = True
        Me.Lbl_BackupPath.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_BackupPath.Location = New System.Drawing.Point(283, 323)
        Me.Lbl_BackupPath.Name = "Lbl_BackupPath"
        Me.Lbl_BackupPath.Size = New System.Drawing.Size(95, 15)
        Me.Lbl_BackupPath.TabIndex = 11
        Me.Lbl_BackupPath.Text = "asdfasdfasdfasdf"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1112, 377)
        Me.Controls.Add(Me.Lbl_BackupPath)
        Me.Controls.Add(Me.Lbl_GamePath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Launch)
        Me.Controls.Add(Me.Lbl_LaunchPath)
        Me.Controls.Add(Me.Btn_GetGamePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_GetLaunchPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Star Citizen Easy Launch "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_GetLaunchPath As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_GetGamePath As Button
    Friend WithEvents FolderBrowserL As FolderBrowserDialog
    Friend WithEvents Lbl_LaunchPath As Label
    Friend WithEvents Btn_Launch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_GamePath As Label
    Friend WithEvents Lbl_BackupPath As Label
End Class
