<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fee_Record
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSTALLMENTSSTUDENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FULLPAIDSTUDENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WholeDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OldDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewRecordToolStripMenuItem, Me.WholeDataToolStripMenuItem, Me.OldDatabaseToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(899, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllDetailsToolStripMenuItem})
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AddNewRecordToolStripMenuItem.Text = "Fees Details"
        '
        'ViewAllDetailsToolStripMenuItem
        '
        Me.ViewAllDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSTALLMENTSSTUDENTSToolStripMenuItem, Me.FULLPAIDSTUDENTSToolStripMenuItem})
        Me.ViewAllDetailsToolStripMenuItem.Name = "ViewAllDetailsToolStripMenuItem"
        Me.ViewAllDetailsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewAllDetailsToolStripMenuItem.Text = "View All Details"
        '
        'INSTALLMENTSSTUDENTSToolStripMenuItem
        '
        Me.INSTALLMENTSSTUDENTSToolStripMenuItem.Name = "INSTALLMENTSSTUDENTSToolStripMenuItem"
        Me.INSTALLMENTSSTUDENTSToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.INSTALLMENTSSTUDENTSToolStripMenuItem.Text = "INSTALLMENT'S STUDENTS"
        '
        'FULLPAIDSTUDENTSToolStripMenuItem
        '
        Me.FULLPAIDSTUDENTSToolStripMenuItem.Name = "FULLPAIDSTUDENTSToolStripMenuItem"
        Me.FULLPAIDSTUDENTSToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.FULLPAIDSTUDENTSToolStripMenuItem.Text = "FULL PAID STUDENTS"
        '
        'WholeDataToolStripMenuItem
        '
        Me.WholeDataToolStripMenuItem.Name = "WholeDataToolStripMenuItem"
        Me.WholeDataToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.WholeDataToolStripMenuItem.Text = "Whole Data"
        '
        'OldDatabaseToolStripMenuItem
        '
        Me.OldDatabaseToolStripMenuItem.Name = "OldDatabaseToolStripMenuItem"
        Me.OldDatabaseToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.OldDatabaseToolStripMenuItem.Text = "Old Database"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "back"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(899, 407)
        Me.DataGridView1.TabIndex = 1
        '
        'Fee_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 431)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fee_Record"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "HELLP"
        Me.Text = "Fee_Record"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddNewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents INSTALLMENTSSTUDENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FULLPAIDSTUDENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WholeDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OldDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
