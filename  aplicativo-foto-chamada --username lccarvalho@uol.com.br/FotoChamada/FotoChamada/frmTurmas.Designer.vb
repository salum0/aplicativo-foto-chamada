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
        Dim CursoLabel As System.Windows.Forms.Label
        Dim ProfessorLabel As System.Windows.Forms.Label
        Dim InicioLabel As System.Windows.Forms.Label
        Dim TerminoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurmas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProfessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFotoChamadaDataSet = New FotoChamada.dbFotoChamadaDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TurmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerminoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HorarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TurmaTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.TurmaTableAdapter()
        Me.TableAdapterManager = New FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager()
        Me.CursoTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.CursoTableAdapter()
        Me.HorarioTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.HorarioTableAdapter()
        Me.ProfessorTableAdapter = New FotoChamada.dbFotoChamadaDataSetTableAdapters.ProfessorTableAdapter()
        Me.TurmaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TurmaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CursoLabel = New System.Windows.Forms.Label()
        ProfessorLabel = New System.Windows.Forms.Label()
        InicioLabel = New System.Windows.Forms.Label()
        TerminoLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFotoChamadaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.HorarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TurmaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        InicioLabel.Size = New System.Drawing.Size(37, 13)
        InicioLabel.TabIndex = 6
        InicioLabel.Text = "Início:"
        '
        'TerminoLabel
        '
        TerminoLabel.AutoSize = True
        TerminoLabel.Location = New System.Drawing.Point(17, 132)
        TerminoLabel.Name = "TerminoLabel"
        TerminoLabel.Size = New System.Drawing.Size(48, 13)
        TerminoLabel.TabIndex = 8
        TerminoLabel.Text = "Término:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
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
        Me.TabPage1.Text = "Geral"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(309, 51)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 13
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
        'DbFotoChamadaDataSet
        '
        Me.DbFotoChamadaDataSet.DataSetName = "dbFotoChamadaDataSet"
        Me.DbFotoChamadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CursoBindingSource
        '
        Me.CursoBindingSource.DataMember = "Curso"
        Me.CursoBindingSource.DataSource = Me.DbFotoChamadaDataSet
        '
        'CursoBindingSource1
        '
        Me.CursoBindingSource1.DataMember = "Curso"
        Me.CursoBindingSource1.DataSource = Me.DbFotoChamadaDataSet
        '
        'InicioDateTimePicker
        '
        Me.InicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TurmaBindingSource, "Inicio", True))
        Me.InicioDateTimePicker.Location = New System.Drawing.Point(77, 102)
        Me.InicioDateTimePicker.Name = "InicioDateTimePicker"
        Me.InicioDateTimePicker.Size = New System.Drawing.Size(268, 20)
        Me.InicioDateTimePicker.TabIndex = 7
        '
        'TurmaBindingSource
        '
        Me.TurmaBindingSource.DataMember = "Turma"
        Me.TurmaBindingSource.DataSource = Me.DbFotoChamadaDataSet
        '
        'TerminoDateTimePicker
        '
        Me.TerminoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TurmaBindingSource, "Termino", True))
        Me.TerminoDateTimePicker.Location = New System.Drawing.Point(77, 128)
        Me.TerminoDateTimePicker.Name = "TerminoDateTimePicker"
        Me.TerminoDateTimePicker.Size = New System.Drawing.Size(268, 20)
        Me.TerminoDateTimePicker.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.HorarioDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(369, 184)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Horários"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(110, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horários da turma:"
        '
        'HorarioDataGridView
        '
        Me.HorarioDataGridView.AutoGenerateColumns = False
        Me.HorarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HorarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.HorarioDataGridView.DataSource = Me.HorarioBindingSource
        Me.HorarioDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.HorarioDataGridView.Name = "HorarioDataGridView"
        Me.HorarioDataGridView.Size = New System.Drawing.Size(360, 139)
        Me.HorarioDataGridView.TabIndex = 0
        '
        'HorarioBindingSource
        '
        Me.HorarioBindingSource.DataMember = "Horario"
        Me.HorarioBindingSource.DataSource = Me.DbFotoChamadaDataSet
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(369, 184)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Alunos"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.HorarioTableAdapter = Me.HorarioTableAdapter
        Me.TableAdapterManager.PresencaTableAdapter = Nothing
        Me.TableAdapterManager.ProfessorTableAdapter = Me.ProfessorTableAdapter
        Me.TableAdapterManager.TurmaTableAdapter = Me.TurmaTableAdapter
        Me.TableAdapterManager.UpdateOrder = FotoChamada.dbFotoChamadaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CursoTableAdapter
        '
        Me.CursoTableAdapter.ClearBeforeFill = True
        '
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'ProfessorTableAdapter
        '
        Me.ProfessorTableAdapter.ClearBeforeFill = True
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TurmaBindingNavigatorSaveItem
        '
        Me.TurmaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TurmaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TurmaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TurmaBindingNavigatorSaveItem.Name = "TurmaBindingNavigatorSaveItem"
        Me.TurmaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TurmaBindingNavigatorSaveItem.Text = "Save Data"
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DiaSemana"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dia da Semana"
        Me.DataGridViewTextBoxColumn3.Items.AddRange(New Object() {"domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sábado"})
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HoraInicio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hora Início"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HoraTermino"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "H. Término"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 90
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
        Me.Text = "Cadastro de Turmas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ProfessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFotoChamadaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.HorarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TurmaBindingNavigator.ResumeLayout(False)
        Me.TurmaBindingNavigator.PerformLayout()
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
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents HorarioTableAdapter As FotoChamada.dbFotoChamadaDataSetTableAdapters.HorarioTableAdapter
    Friend WithEvents HorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HorarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
