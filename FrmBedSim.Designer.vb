<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBedSim
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 34)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpecificationsToolStripMenuItem, Me.DataDistributionToolStripMenuItem})
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(84, 30)
        Me.InputToolStripMenuItem.Text = "Input"
        '
        'SpecificationsToolStripMenuItem
        '
        Me.SpecificationsToolStripMenuItem.Name = "SpecificationsToolStripMenuItem"
        Me.SpecificationsToolStripMenuItem.Size = New System.Drawing.Size(294, 34)
        Me.SpecificationsToolStripMenuItem.Text = "Specifications"
        '
        'DataDistributionToolStripMenuItem
        '
        Me.DataDistributionToolStripMenuItem.Name = "DataDistributionToolStripMenuItem"
        Me.DataDistributionToolStripMenuItem.Size = New System.Drawing.Size(294, 34)
        Me.DataDistributionToolStripMenuItem.Text = "Data Distribution"
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(297, 88)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidth = 62
        Me.DGV1.RowTemplate.Height = 33
        Me.DGV1.Size = New System.Drawing.Size(360, 225)
        Me.DGV1.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSave.Location = New System.Drawing.Point(476, 360)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 34)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmBedSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmBedSim"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecificationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDistributionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents BtnSave As Button
End Class
