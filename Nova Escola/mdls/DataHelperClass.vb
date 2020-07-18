Imports System
Imports System.Linq

Namespace Helpers
    Public Class DataHelper
        Private _DataSet As DataSet
        Private _DataMember As String = "FirstTable"

        Public Sub New(ByVal param As DSparametr)
            Select Case param
                Case DSparametr.simpleDS
                    MakeFirstTable()
                    Exit Select
                Case DSparametr.simpleBoolDS
                    MakeBoolFirstTable()
                    Exit Select
                Case DSparametr.simpleTimeDS
                    MakeTimeFirstTable()
                    Exit Select
                Case DSparametr.doubleDS
                    MakeFirstTable()
                    MakeSecondTable()
                    Exit Select
                Case DSparametr.relatedDS
                    MakeFirstTable()
                    MakeSecondTable()
                    MakeThirdTable()
                    MakeDataRelation()
                    Exit Select
            End Select
            DataSet.AcceptChanges()
        End Sub

        Private Sub MakeFirstTable()
            Dim table As New DataTable("FirstTable")
            Dim column As DataColumn
            'Dim row As DataRow

            column = New DataColumn()
            column.DataType = GetType(Image)
            column.ColumnName = "*"
            column.AutoIncrement = False
            column.Caption = "*"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "Turma"
            column.AutoIncrement = False
            column.Caption = "Turma"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "Disciplina"
            column.AutoIncrement = False
            column.Caption = "Disciplina"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "Mensagem"
            column.AutoIncrement = False
            column.Caption = "Mensagem"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            DataSet = New DataSet()
            DataSet.Tables.Add(table)

            'For i As Integer = 0 To 100
            '	row = table.NewRow()
            '	row("value1") = i
            '	row("value2") = 10 * i
            '             row("value3") = 100 * i

            '             table.Rows.Add(row)
            'Next i
        End Sub

        Private Sub MakeTimeFirstTable()
            Dim table As New DataTable("FirstTable")
            Dim column As DataColumn

            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "value1"
            column.AutoIncrement = False
            column.Caption = "value1"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(Date)
            column.ColumnName = "value2"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            DataSet = New DataSet()
            DataSet.Tables.Add(table)


        End Sub

        Private Sub MakeBoolFirstTable()
            Dim table As New DataTable("FirstTable")
            Dim column As DataColumn

            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "value1"
            column.AutoIncrement = False
            column.Caption = "value1"
            column.ReadOnly = False
            column.Unique = False

            table.Columns.Add(column)


            column = New DataColumn()
            column.DataType = GetType(Boolean)
            column.ColumnName = "value2"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False

            table.Columns.Add(column)

            DataSet = New DataSet()
            DataSet.Tables.Add(table)

        End Sub

        Private Sub MakeSecondTable()
            Dim table As New DataTable("SecondTable")
            Dim column As DataColumn

            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value4"
            column.AutoIncrement = False
            column.Caption = "value4"
            column.ReadOnly = False
            column.Unique = False

            table.Columns.Add(column)


            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value5"
            column.AutoIncrement = False
            column.Caption = "value5"
            column.ReadOnly = False
            column.Unique = False

            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value6"
            column.AutoIncrement = False
            column.Caption = "value6"
            column.ReadOnly = False
            column.Unique = False

            table.Columns.Add(column)

            DataSet.Tables.Add(table)

        End Sub

        Private Sub MakeThirdTable()
            Dim table As New DataTable("ThirdTable")
            Dim column As DataColumn

            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value7"
            column.AutoIncrement = False
            column.Caption = "value7"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value8"
            column.AutoIncrement = False
            column.Caption = "value7"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)

            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value9"
            column.AutoIncrement = False
            column.Caption = "Value9"
            column.ReadOnly = False
            column.Unique = False

            table.Columns.Add(column)

            DataSet.Tables.Add(table)

        End Sub

        Private Sub MakeDataRelation()
            Dim parentColumn As DataColumn = DataSet.Tables("FirstTable").Columns("value1")
            Dim childColumn As DataColumn = DataSet.Tables("SecondTable").Columns("value4")
            Dim relation As New DataRelation("value1_value4", parentColumn, childColumn)
            DataSet.Tables("SecondTable").ParentRelations.Add(relation)

            parentColumn = DataSet.Tables("SecondTable").Columns("value4")
            childColumn = DataSet.Tables("ThirdTable").Columns("value7")
            relation = New DataRelation("value4_value7", parentColumn, childColumn)
            DataSet.Tables("ThirdTable").ParentRelations.Add(relation)

        End Sub
        
        Public Property DataSet() As DataSet
            Get
                Return _DataSet
            End Get
            Set(ByVal value As DataSet)
                _DataSet = value
            End Set
        End Property

        Public Property DataMember() As String
            Get
                Return _DataMember
            End Get
            Set(ByVal value As String)
                _DataMember = value
            End Set
        End Property


        Public Shared Sub CommitTransactionStub()
            Throw New InvalidOperationException("Fake exception")
        End Sub

    End Class

    Public Enum DSparametr
        simpleDS = 0
        doubleDS = 1
        relatedDS = 2
        simpleBoolDS = 3
        simpleTimeDS = 4
    End Enum
End Namespace
