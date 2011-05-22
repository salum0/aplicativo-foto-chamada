<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurmas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurmas))
        Dim CursoLabel As System.Windows.Forms.Label
        Dim ProfessorLabel As System.Windows.Forms.Label
        Dim InicioLabel As System.Windows.Forms.Label
        Dim TerminoLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DbFotoChamadaDataSet = New FotoChamada.dbFotoChamadaDataSet()
        Me.TurmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurmaTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.TurmaTableAdapter()
        Me.TableAdapterManager = New FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager()
        Me.TurmaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TurmaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TerminoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursoTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.CursoTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CursoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProfessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessorTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.ProfessorTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CursoLabel = New System.Windows.Forms.Label()
        ProfessorLabel = New System.Windows.Forms.Label()
        InicioLabel = New System.Windows.Forms.Label()
        TerminoLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DbFotoChamadaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TurmaBindingNavigator.SuspendLayout()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(377, 210)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(CursoLabel)
        Me.TabPage1.Controls.Add(ProfessorLabel)
        Me.TabPage1.Controls.Add(InicioLabel)
        Me.TabPage1.Controls.Add(Me.InicioDateTimePicker)
        Me.TabPage1.Controls.Add(TerminoLabel)
        Me.TabPage1.Controls.Add(Me.TerminoDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(369, 184)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DbFotoChamadaDataSet
        '
        Me.DbFotoChamadaDataSet.DataSetName = "dbFotoChamadaDataSet"
        Me.DbFotoChamadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurmaBindingSource
        '
        Me.TurmaBindingSource.DataMember = "Turma"
        Me.TurmaBindingSource.DataSource = Me.DbFotoChamadaDataSet
        '
        'TurmaTableAdapter
        '
        Me.TurmaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlunoTableAdapter = Nothing
        Me.TableAdapterManager.AlunoTurmaTableAdapter = Nothing
        Me.TableAdapterManager.AulaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CursoTableAdapter = Me.CursoTableAdapter
        Me.TableAdapterManager.FotoDaAulaTableAdapter = Nothing
        Me.TableAdapterManager.FotoDoAlunoTableAdapter = Nothing
        Me.TableAdapterManager.HorarioTableAdapter = Nothing
        Me.TableAdapterManager.PresencaTableAdapter = Nothing
        Me.TableAdapterManager.ProfessorTableAdapter = Me.ProfessorTableAdapter
        Me.TableAdapterManager.TurmaTableAdapter = Me.TurmaTableAdapter
        Me.TableAdapterManager.UpdateOrder = FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TurmaBindingNavigator
        '
        Me.TurmaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TurmaBindingNavigator.BindingSource = Me.TurmaBindingSource
        Me.TurmaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TurmaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TurmaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TurmaBindingNavigatorSaveItem})
        Me.TurmaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TurmaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TurmaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TurmaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TurmaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TurmaBindingNavigator.Name = "TurmaBindingNavigator"
        Me.TurmaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TurmaBindingNavigator.Size = New System.Drawing.Size(402, 25)
        Me.TurmaBindingNavigator.TabIndex = 1
        Me.TurmaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TurmaBindingNavigatorSaveItem
        '
        Me.TurmaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TurmaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TurmaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TurmaBindingNavigatorSaveItem.Name = "TurmaBindingNavigatorSaveItem"
        Me.TurmaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TurmaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CursoLabel
        '
        CursoLabel.AutoSize = True
        CursoLabel.Location = New System.Drawing.Point(17, 53)
        CursoLabel.Name = "CursoLabel"
        CursoLabel.Size = New System.Drawing.Size(37, 13)
        CursoLabel.TabIndex = 2
        CursoLabel.Text = "Curso:"
        '
        'ProfessorLabel
        '
        ProfessorLabel.AutoSize = True
        ProfessorLabel.Location = New System.Drawing.Point(17, 79)
        ProfessorLabel.Name = "ProfessorLabel"
        ProfessorLabel.Size = New System.Drawing.Size(54, 13)
        ProfessorLabel.TabIndex = 4
        ProfessorLabel.Text = "Professor:"
        '
        'InicioLabel
        '
        InicioLabel.AutoSize = True
        InicioLabel.Location = New System.Drawing.Point(17, 106)
        InicioLabel.Name = "InicioLabel"
        InicioLabel.Size = New System.Drawing.Size(35, 13)
        InicioLabel.TabIndex = 6
        InicioLabel.Text = "Inicio:"
        '
        'InicioDateTimePicker
        '
        Me.InicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TurmaBindingSource, "Inicio", True))
        Me.InicioDateTimePicker.Location = New System.Drawing.Point(77, 102)
        Me.InicioDateTimePicker.Name = "InicioDateTimePicker"
        Me.InicioDateTimePicker.Size = New System.Drawing.Size(268, 20)
        Me.InicioDateTimePicker.TabIndex = 7
        '
        'TerminoLabel
        '
        TerminoLabel.AutoSize = True
        TerminoLabel.Location = New System.Drawing.Point(17, 132)
        TerminoLabel.Name = "TerminoLabel"
        TerminoLabel.Size = New System.Drawing.Size(48, 13)
        TerminoLabel.TabIndex = 8
        TerminoLabel.Text = "Termino:"
        '
        'TerminoDateTimePicker
        '
        Me.TerminoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TurmaBindingSource, "Termino", True))
        Me.TerminoDateTimePicker.Location = New System.Drawing.Point(77, 128)
        Me.TerminoDateTimePicker.Name = "TerminoDateTimePicker"
        Me.TerminoDateTimePicker.Size = New System.Drawing.Size(268, 20)
        Me.TerminoDateTimePicker.TabIndex = 9
        '
        'CursoBindingSource
        '
        Me.CursoBindingSource.DataMember = "Curso"
        Me.CursoBindingSource.DataSource = Me.DbFotoChamadaDataSet
        '
        'CursoTableAdapter
        '
        Me.CursoTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CursoBindingSource, "CursoID", True))
        Me.ComboBox1.DataSource = Me.CursoBindingSource1
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "CursoID"
        '
        'CursoBindingSource1
        '
        Me.CursoBindingSource1.DataMember = "Curso"
        Me.CursoBindingSource1.DataSource = Me.DbFotoChamadaDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProfessorBindingSource
        Me.ComboBox2.DisplayMember = "Nome"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(77, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(268, 21)
        Me.ComboBox2.TabIndex = 11
        Me.ComboBox2.ValueMember = "ProfessorID"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Turma:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(309, 51)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTurmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 300)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TurmaBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmTurmas"
        Me.Text = "frmTurmas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DbFotoChamadaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TurmaBindingNavigator.ResumeLayout(False)
        Me.TurmaBindingNavigator.PerformLayout()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DbFotoChamadaDataSet As FotoChamada.dbFotoChamadaDataSet
    Friend WithEvents TurmaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurmaTableAdapter As FotoChamada.dbFotoChamadaDataSetTableAdapters.TurmaTableAdapter
    Friend WithEvents TableAdapterManager As FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TurmaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TurmaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TerminoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CursoTableAdapter As FotoChamada.dbFotoChamadaDataSetTableAdapters.CursoTableAdapter
    Friend WithEvents CursoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CursoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfessorTableAdapter As FotoChamada.dbFotoChamadaDataSetTableAdapters.ProfessorTableAdapter
    Friend WithEvents ProfessorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
