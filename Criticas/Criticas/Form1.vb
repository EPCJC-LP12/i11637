Public Class Form1

    Private Sub RestauranteBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles RestauranteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RestauranteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Restaurante' table. You can move, or remove it, as needed.
        Me.RestauranteTableAdapter.Fill(Me.Database1DataSet.Restaurante)

    End Sub
End Class
