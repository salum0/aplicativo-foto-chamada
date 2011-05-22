Public Class frmProfessores

    Private Sub ProfessorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfessorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfessorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub

    Private Sub frmProfessores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Professor' table. You can move, or remove it, as needed.
        Me.ProfessorTableAdapter.Fill(Me.DbFotoChamadaDataSet.Professor)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.ProfessorBindingSource.EndEdit()
            Me.ProfessorTableAdapter.Update(Me.DbFotoChamadaDataSet.Professor)
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class