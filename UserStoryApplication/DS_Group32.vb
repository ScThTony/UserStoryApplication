Partial Class DS_Group32
    Partial Public Class TestCasesTableDataTable
        Private Sub TestCasesTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TestCaseNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace DS_Group32TableAdapters
    
    Partial Public Class MemberTableTableAdapter
    End Class
End Namespace

