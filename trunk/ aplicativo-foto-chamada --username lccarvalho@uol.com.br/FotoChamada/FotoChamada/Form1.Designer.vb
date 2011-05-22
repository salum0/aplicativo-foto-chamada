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
        Me.components = New System.ComponentModel.Container()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DbFotoChamadaDataSet = New FotoChamada.dbFotoChamadaDataSet()
        Me.ProfessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessorTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.ProfessorTableAdapter()
        Me.TableAdapterManager = New FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.VerTurmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DbFotoChamadaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosToolStripMenuItem, Me.ProfessoresToolStripMenuItem, Me.AlunosToolStripMenuItem, Me.TurmasToolStripMenuItem, Me.VerTurmasToolStripMenuItem})
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(390, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 230)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Professor:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProfessorBindingSource
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(63, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ProfessorID"
        '
        'DbFotoChamadaDataSet
        '
        Me.DbFotoChamadaDataSet.DataSetName = "dbFotoChamadaDataSet"
        Me.DbFotoChamadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfessorBindingSource
        '
        Me.ProfessorBindingSource.DataMember = "Professor"
        Me.ProfessorBindingSource.DataSource = Me.DbFotoChamadaDataSet
        '
        'ProfessorTableAdapter
        '
        Me.ProfessorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlunoTableAdapter = Nothing
        Me.TableAdapterManager.AlunoTurmaTableAdapter = Nothing
        Me.TableAdapterManager.AulaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursoTableAdapter = Nothing
        Me.TableAdapterManager.FotoDaAulaTableAdapter = Nothing
        Me.TableAdapterManager.FotoDoAlunoTableAdapter = Nothing
        Me.TableAdapterManager.HorarioTableAdapter = Nothing
        Me.TableAdapterManager.PresencaTableAdapter = Nothing
        Me.TableAdapterManager.ProfessorTableAdapter = Me.ProfessorTableAdapter
        Me.TableAdapterManager.TurmaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Turma:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(63, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(191, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 97)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data da Aula:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(98, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Nova Foto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(179, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Processar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VerTurmasToolStripMenuItem
        '
        Me.VerTurmasToolStripMenuItem.Name = "VerTurmasToolStripMenuItem"
        Me.VerTurmasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerTurmasToolStripMenuItem.Text = "&Ver Turmas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 271)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Foto Chamada"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DbFotoChamadaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DbFotoChamadaDataSet As FotoChamada.dbFotoChamadaDataSet
    Friend WithEvents ProfessorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfessorTableAdapter As FotoChamada.dbFotoChamadaDataSetTableAdapters.ProfessorTableAdapter
    Friend WithEvents TableAdapterManager As FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VerTurmasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
