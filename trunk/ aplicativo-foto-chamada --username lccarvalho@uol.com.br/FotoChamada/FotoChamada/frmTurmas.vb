Public Class frmTurmas

    Private Sub TurmaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurmaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TurmaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub

    Private Sub frmTurmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Horario' table. You can move, or remove it, as needed.
        Me.HorarioTableAdapter.Fill(Me.DbFotoChamadaDataSet.Horario)
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
        turmasRow.TurmaID = ComboBox1.SelectedValue.Trim & TextBox1.Text.Trim
        turmasRow.Curso = ComboBox1.SelectedValue
        turmasRow.Professor = ComboBox2.SelectedValue
        turmasRow.Inicio = InicioDateTimePicker.Value
        turmasRow.Termino = TerminoDateTimePicker.Value
        DbFotoChamadaDataSet.Turma.AddTurmaRow(turmasRow)


        Me.Validate()
        Me.TurmaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)
        Me.DialogResult = DialogResult.OK

    End Sub

    'Não Funciona...
    Private Sub TabPage2_MouseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.MouseClick

        Label3.Text = ComboBox1.SelectedValue.Trim & TextBox1.Text.Trim

    End Sub

End Class