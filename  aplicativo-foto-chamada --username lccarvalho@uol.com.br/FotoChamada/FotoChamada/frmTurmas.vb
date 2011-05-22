Public Class frmTurmas

    Private Sub TurmaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurmaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TurmaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub

    Private Sub frmTurmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Professor' table. You can move, or remove it, as needed.
        Me.ProfessorTableAdapter.Fill(Me.DbFotoChamadaDataSet.Professor)
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Curso' table. You can move, or remove it, as needed.
        Me.CursoTableAdapter.Fill(Me.DbFotoChamadaDataSet.Curso)
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Turma' table. You can move, or remove it, as needed.
        Me.TurmaTableAdapter.Fill(Me.DbFotoChamadaDataSet.Turma)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim turmasRow As dbFotoChamadaDataSet.TurmaRow
        turmasRow = DbFotoChamadaDataSet.Turma.NewTurmaRow()

        Dim teste As String
        teste = ComboBox1.ValueMember.Trim & TextBox1.Text.Trim
        MsgBox(teste)

        turmasRow.TurmaID = ComboBox1.ValueMember.Trim & TextBox1.Text.Trim
        turmasRow.Curso = ComboBox1.ValueMember
        turmasRow.Professor = ComboBox2.ValueMember
        turmasRow.Inicio = InicioDateTimePicker.Value
        turmasRow.Termino = TerminoDateTimePicker.Value

        DbFotoChamadaDataSet.Turma.AddTurmaRow(turmasRow)
        Me.Validate()
        Me.TurmaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub
End Class