Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.Util
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices


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

    Private Sub ImportarFotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarFotoToolStripMenuItem.Click

        OpenFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim img As New Image(Of Bgr, Byte)(OpenFileDialog1.FileName)
            PictureBox1.Image = img.Bitmap
        End If

        Panel1.Visible = True
        Panel1.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFotoChamadaDataSet.Professor' table. You can move, or remove it, as needed.
        Me.ProfessorTableAdapter.Fill(Me.DbFotoChamadaDataSet.Professor)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        OpenFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim img As New Image(Of Bgr, Byte)(OpenFileDialog1.FileName)
            PictureBox1.Image = img.Bitmap

        End If

    End Sub

    Private Sub TurmasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurmasToolStripMenuItem.Click
        Dim frmTurmas As New frmTurmas()
        frmTurmas.ShowDialog()
    End Sub

    Private Sub VerTurmasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTurmasToolStripMenuItem.Click

        Dim frmVerTurmas As New frmVerTurmas()
        frmVerTurmas.ShowDialog()
    End Sub
End Class
