Public Class frmVerTurmas

    Private Sub TurmaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurmaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TurmaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub

    Private Sub frmVerTurmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Turma' table. You can move, or remove it, as needed.
        Me.TurmaTableAdapter.Fill(Me.DbFotoChamadaDataSet.Turma)

    End Sub
End Class