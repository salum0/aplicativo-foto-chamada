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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfessoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChamadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.CadastrosToolStripMenuItem, Me.ChamadaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosToolStripMenuItem, Me.ProfessoresToolStripMenuItem, Me.AlunosToolStripMenuItem, Me.TurmasToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CadastrosToolStripMenuItem.Text = "&Cadastros"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CursosToolStripMenuItem.Text = "&Cursos"
        '
        'ProfessoresToolStripMenuItem
        '
        Me.ProfessoresToolStripMenuItem.Name = "ProfessoresToolStripMenuItem"
        Me.ProfessoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfessoresToolStripMenuItem.Text = "&Professores"
        '
        'AlunosToolStripMenuItem
        '
        Me.AlunosToolStripMenuItem.Name = "AlunosToolStripMenuItem"
        Me.AlunosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlunosToolStripMenuItem.Text = "&Alunos"
        '
        'TurmasToolStripMenuItem
        '
        Me.TurmasToolStripMenuItem.Name = "TurmasToolStripMenuItem"
        Me.TurmasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TurmasToolStripMenuItem.Text = "&Turmas"
        '
        'ChamadaToolStripMenuItem
        '
        Me.ChamadaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarFotoToolStripMenuItem})
        Me.ChamadaToolStripMenuItem.Name = "ChamadaToolStripMenuItem"
        Me.ChamadaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ChamadaToolStripMenuItem.Text = "C&hamada"
        '
        'ImportarFotoToolStripMenuItem
        '
        Me.ImportarFotoToolStripMenuItem.Name = "ImportarFotoToolStripMenuItem"
        Me.ImportarFotoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportarFotoToolStripMenuItem.Text = "&Importar Foto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 271)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfessoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlunosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurmasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChamadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarFotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
