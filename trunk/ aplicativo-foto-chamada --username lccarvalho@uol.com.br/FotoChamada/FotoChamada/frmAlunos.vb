Public Class frmAlunos

    Private Sub AlunoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlunoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlunoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub

    Private Sub frmAlunos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Aluno' table. You can move, or remove it, as needed.
        Me.AlunoTableAdapter.Fill(Me.DbFotoChamadaDataSet.Aluno)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.AlunoBindingSource.EndEdit()
            Me.AlunoTableAdapter.Update(Me.DbFotoChamadaDataSet.Aluno)
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class