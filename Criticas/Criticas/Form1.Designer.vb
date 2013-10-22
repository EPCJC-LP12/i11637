<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NomeLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim ContratoLabel As System.Windows.Forms.Label
        Dim Nome_contratoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New Criticas.Database1DataSet()
        Me.RestauranteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestauranteTableAdapter = New Criticas.Database1DataSetTableAdapters.RestauranteTableAdapter()
        Me.TableAdapterManager = New Criticas.Database1DataSetTableAdapters.TableAdapterManager()
        Me.RestauranteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RestauranteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.MoradaTextBox = New System.Windows.Forms.TextBox()
        Me.ContratoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_contratoTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        ContratoLabel = New System.Windows.Forms.Label()
        Nome_contratoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestauranteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RestauranteBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestauranteBindingSource
        '
        Me.RestauranteBindingSource.DataMember = "Restaurante"
        Me.RestauranteBindingSource.DataSource = Me.Database1DataSet
        '
        'RestauranteTableAdapter
        '
        Me.RestauranteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CriticasTableAdapter = Nothing
        Me.TableAdapterManager.RestauranteTableAdapter = Me.RestauranteTableAdapter
        Me.TableAdapterManager.UpdateOrder = Criticas.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RestauranteBindingNavigator
        '
        Me.RestauranteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RestauranteBindingNavigator.BindingSource = Me.RestauranteBindingSource
        Me.RestauranteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RestauranteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RestauranteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RestauranteBindingNavigatorSaveItem})
        Me.RestauranteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RestauranteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RestauranteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RestauranteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RestauranteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RestauranteBindingNavigator.Name = "RestauranteBindingNavigator"
        Me.RestauranteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RestauranteBindingNavigator.Size = New System.Drawing.Size(502, 25)
        Me.RestauranteBindingNavigator.TabIndex = 0
        Me.RestauranteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'RestauranteBindingNavigatorSaveItem
        '
        Me.RestauranteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RestauranteBindingNavigatorSaveItem.Image = CType(resources.GetObject("RestauranteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RestauranteBindingNavigatorSaveItem.Name = "RestauranteBindingNavigatorSaveItem"
        Me.RestauranteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RestauranteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(255, 178)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(36, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(339, 175)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'MoradaLabel
        '
        MoradaLabel.AutoSize = True
        MoradaLabel.Location = New System.Drawing.Point(255, 204)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(45, 13)
        MoradaLabel.TabIndex = 3
        MoradaLabel.Text = "morada:"
        '
        'MoradaTextBox
        '
        Me.MoradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "morada", True))
        Me.MoradaTextBox.Location = New System.Drawing.Point(339, 201)
        Me.MoradaTextBox.Name = "MoradaTextBox"
        Me.MoradaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MoradaTextBox.TabIndex = 4
        '
        'ContratoLabel
        '
        ContratoLabel.AutoSize = True
        ContratoLabel.Location = New System.Drawing.Point(255, 230)
        ContratoLabel.Name = "ContratoLabel"
        ContratoLabel.Size = New System.Drawing.Size(49, 13)
        ContratoLabel.TabIndex = 5
        ContratoLabel.Text = "contrato:"
        '
        'ContratoTextBox
        '
        Me.ContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "contrato", True))
        Me.ContratoTextBox.Location = New System.Drawing.Point(339, 227)
        Me.ContratoTextBox.Name = "ContratoTextBox"
        Me.ContratoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContratoTextBox.TabIndex = 6
        '
        'Nome_contratoLabel
        '
        Nome_contratoLabel.AutoSize = True
        Nome_contratoLabel.Location = New System.Drawing.Point(255, 256)
        Nome_contratoLabel.Name = "Nome_contratoLabel"
        Nome_contratoLabel.Size = New System.Drawing.Size(78, 13)
        Nome_contratoLabel.TabIndex = 7
        Nome_contratoLabel.Text = "nome contrato:"
        '
        'Nome_contratoTextBox
        '
        Me.Nome_contratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "nome_contrato", True))
        Me.Nome_contratoTextBox.Location = New System.Drawing.Point(339, 254)
        Me.Nome_contratoTextBox.Name = "Nome_contratoTextBox"
        Me.Nome_contratoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_contratoTextBox.TabIndex = 8
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(44, 60)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 9
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestauranteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(128, 57)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 436)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(MoradaLabel)
        Me.Controls.Add(Me.MoradaTextBox)
        Me.Controls.Add(ContratoLabel)
        Me.Controls.Add(Me.ContratoTextBox)
        Me.Controls.Add(Nome_contratoLabel)
        Me.Controls.Add(Me.Nome_contratoTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.RestauranteBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestauranteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RestauranteBindingNavigator.ResumeLayout(False)
        Me.RestauranteBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As Criticas.Database1DataSet
    Friend WithEvents RestauranteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RestauranteTableAdapter As Criticas.Database1DataSetTableAdapters.RestauranteTableAdapter
    Friend WithEvents TableAdapterManager As Criticas.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RestauranteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RestauranteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MoradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContratoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nome_contratoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox

End Class
