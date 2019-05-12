Public Class TestCasesForm
    Private Sub TestCasesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group32DataSet.TestCasesTable' table. You can move, or remove it, as needed.
        Me.TestCasesTableTableAdapter.Fill(Me.Group32DataSet.TestCasesTable)

    End Sub
End Class