Public Class Form1

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub CursosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CursosToolStripMenuItem.Click
        Dim frmCursos As New frmCursos()
        frmCursos.ShowDialog()
    End Sub

    Private Sub ProfessoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfessoresToolStripMenuItem.Click
        Dim frmProfessores As New frmProfessores()
        frmProfessores.ShowDialog()

    End Sub

    Private Sub AlunosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlunosToolStripMenuItem.Click
        Dim frmAlunos As New frmAlunos()
        frmAlunos.ShowDialog()

    End Sub
End Class
