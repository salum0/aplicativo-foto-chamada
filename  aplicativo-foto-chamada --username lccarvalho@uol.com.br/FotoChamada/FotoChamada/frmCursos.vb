Public Class frmCursos

    Private Sub CursoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFotoChamadaDataSet)

    End Sub

    Private Sub frmCursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Curso' table. You can move, or remove it, as needed.
        Me.CursoTableAdapter.Fill(Me.DbFotoChamadaDataSet.Curso)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Me.Validate()
            Me.CursoBindingSource.EndEdit()
            Me.CursoTableAdapter.Update(Me.DbFotoChamadaDataSet.Curso)
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            MsgBox("Update failed")
        End Try

    End Sub
End Class