﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.2914.16
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code")>  _
Public Class dsCategories
    Inherits System.Data.DataSet
    
    Private tableCategories As CategoriesDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
    End Sub
    
    Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Me.InitClass
        Me.GetSerializationData(info, context)
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Categories As CategoriesDataTable
        Get
            Return Me.tableCategories
        End Get
    End Property
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.ReadXml(reader, XmlReadMode.IgnoreSchema)
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Private Sub InitClass()
        Me.DataSetName = "dsCategories"
        Me.Namespace = "http://tempuri.org/dsCategories.xsd"
        Me.tableCategories = New CategoriesDataTable
        Me.Tables.Add(Me.tableCategories)
    End Sub
    
    Private Function ShouldSerializeCategories() As Boolean
        Return false
    End Function
    
    Public Delegate Sub CategoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As CategoriesRowChangeEvent)
    
    Public Class CategoriesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCategoryID As DataColumn
        
        Private columnCategoryName As DataColumn
        
        Private columnDescription As DataColumn
        
        Private columnPicture As DataColumn
        
        Friend Sub New()
            MyBase.New("Categories")
            Me.InitClass
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CategoryIDColumn As DataColumn
            Get
                Return Me.columnCategoryID
            End Get
        End Property
        
        Friend ReadOnly Property CategoryNameColumn As DataColumn
            Get
                Return Me.columnCategoryName
            End Get
        End Property
        
        Friend ReadOnly Property DescriptionColumn As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property
        
        Friend ReadOnly Property PictureColumn As DataColumn
            Get
                Return Me.columnPicture
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As CategoriesRow
            Get
                Return CType(Me.Rows(index),CategoriesRow)
            End Get
        End Property
        
        Public Event CategoriesRowChanged As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowChanging As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowDeleted As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowDeleting As CategoriesRowChangeEventHandler
        
        Public Overloads Sub AddCategoriesRow(ByVal row As CategoriesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCategoriesRow(ByVal CategoryName As String, ByVal Description As String, ByVal Picture() As Byte) As CategoriesRow
            Dim rowCategoriesRow As CategoriesRow = CType(Me.NewRow,CategoriesRow)
            rowCategoriesRow.ItemArray = New Object() {Nothing, CategoryName, Description, Picture}
            Me.Rows.Add(rowCategoriesRow)
            Return rowCategoriesRow
        End Function
        
        Public Function FindByCategoryID(ByVal CategoryID As Integer) As CategoriesRow
            Return CType(Me.Rows.Find(New Object() {CategoryID}),CategoriesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Private Sub InitClass()
            Me.columnCategoryID = New DataColumn("CategoryID", GetType(System.Int32), "", System.Data.MappingType.Element)
            Me.columnCategoryID.AutoIncrement = true
            Me.columnCategoryID.AllowDBNull = false
            Me.columnCategoryID.ReadOnly = true
            Me.columnCategoryID.Unique = true
            Me.Columns.Add(Me.columnCategoryID)
            Me.columnCategoryName = New DataColumn("CategoryName", GetType(System.String), "", System.Data.MappingType.Element)
            Me.columnCategoryName.AllowDBNull = false
            Me.Columns.Add(Me.columnCategoryName)
            Me.columnDescription = New DataColumn("Description", GetType(System.String), "", System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnPicture = New DataColumn("Picture", GetType(System.Byte()), "", System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPicture)
            Me.PrimaryKey = New DataColumn() {Me.columnCategoryID}
        End Sub
        
        Public Function NewCategoriesRow() As CategoriesRow
            Return CType(Me.NewRow,CategoriesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            'We need to ensure that all Rows in the tabled are typed rows.
            'Table calls newRow whenever it needs to create a row.
            'So the following conditions are covered by Row newRow(Record record)
            '* Cursor calls table.addRecord(record) 
            '* table.addRow(object[] values) calls newRow(record)    
            Return New CategoriesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CategoriesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CategoriesRowChangedEvent) Is Nothing) Then
                RaiseEvent CategoriesRowChanged(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CategoriesRowChangingEvent) Is Nothing) Then
                RaiseEvent CategoriesRowChanging(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CategoriesRowDeletedEvent) Is Nothing) Then
                RaiseEvent CategoriesRowDeleted(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CategoriesRowDeletingEvent) Is Nothing) Then
                RaiseEvent CategoriesRowDeleting(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCategoriesRow(ByVal row As CategoriesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    Public Class CategoriesRow
        Inherits DataRow
        
        Private tableCategories As CategoriesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCategories = CType(Me.Table,CategoriesDataTable)
        End Sub
        
        Public Property CategoryID As Integer
            Get
                Return CType(Me(Me.tableCategories.CategoryIDColumn),Integer)
            End Get
            Set
                Me(Me.tableCategories.CategoryIDColumn) = value
            End Set
        End Property
        
        Public Property CategoryName As String
            Get
                Return CType(Me(Me.tableCategories.CategoryNameColumn),String)
            End Get
            Set
                Me(Me.tableCategories.CategoryNameColumn) = value
            End Set
        End Property
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableCategories.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("이 값은 DBNull이므로 가져올 수 없습니다.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property Picture As Byte()
            Get
                Try 
                    Return CType(Me(Me.tableCategories.PictureColumn),Byte())
                Catch e As InvalidCastException
                    Throw New StrongTypingException("이 값은 DBNull이므로 가져올 수 없습니다.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.PictureColumn) = value
            End Set
        End Property
        
        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableCategories.DescriptionColumn)
        End Function
        
        Public Sub SetDescriptionNull()
            Me(Me.tableCategories.DescriptionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPictureNull() As Boolean
            Return Me.IsNull(Me.tableCategories.PictureColumn)
        End Function
        
        Public Sub SetPictureNull()
            Me(Me.tableCategories.PictureColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    Public Class CategoriesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As CategoriesRow
        
        Private eventAction As System.Data.DataRowAction
        
        Public Sub New(ByVal row As CategoriesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As CategoriesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
