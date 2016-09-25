﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3328.4
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
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsUploadTest
    Inherits DataSet
    
    Private tableupload_test As upload_testDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("upload_test")) Is Nothing) Then
                Me.Tables.Add(New upload_testDataTable(ds.Tables("upload_test")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property upload_test As upload_testDataTable
        Get
            Return Me.tableupload_test
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsUploadTest = CType(MyBase.Clone,dsUploadTest)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("upload_test")) Is Nothing) Then
            Me.Tables.Add(New upload_testDataTable(ds.Tables("upload_test")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableupload_test = CType(Me.Tables("upload_test"),upload_testDataTable)
        If (Not (Me.tableupload_test) Is Nothing) Then
            Me.tableupload_test.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsUploadTest"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsUploadTest.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ko-KR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableupload_test = New upload_testDataTable
        Me.Tables.Add(Me.tableupload_test)
    End Sub
    
    Private Function ShouldSerializeupload_test() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub upload_testRowChangeEventHandler(ByVal sender As Object, ByVal e As upload_testRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class upload_testDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnId As DataColumn
        
        Private columnfilename As DataColumn
        
        Private columnfile_size As DataColumn
        
        Private columncontent_type As DataColumn
        
        Private columncontent As DataColumn
        
        Friend Sub New()
            MyBase.New("upload_test")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property IdColumn As DataColumn
            Get
                Return Me.columnId
            End Get
        End Property
        
        Friend ReadOnly Property filenameColumn As DataColumn
            Get
                Return Me.columnfilename
            End Get
        End Property
        
        Friend ReadOnly Property file_sizeColumn As DataColumn
            Get
                Return Me.columnfile_size
            End Get
        End Property
        
        Friend ReadOnly Property content_typeColumn As DataColumn
            Get
                Return Me.columncontent_type
            End Get
        End Property
        
        Friend ReadOnly Property contentColumn As DataColumn
            Get
                Return Me.columncontent
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As upload_testRow
            Get
                Return CType(Me.Rows(index),upload_testRow)
            End Get
        End Property
        
        Public Event upload_testRowChanged As upload_testRowChangeEventHandler
        
        Public Event upload_testRowChanging As upload_testRowChangeEventHandler
        
        Public Event upload_testRowDeleted As upload_testRowChangeEventHandler
        
        Public Event upload_testRowDeleting As upload_testRowChangeEventHandler
        
        Public Overloads Sub Addupload_testRow(ByVal row As upload_testRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Addupload_testRow(ByVal filename As String, ByVal file_size As Integer, ByVal content_type As String, ByVal content() As Byte) As upload_testRow
            Dim rowupload_testRow As upload_testRow = CType(Me.NewRow,upload_testRow)
            rowupload_testRow.ItemArray = New Object() {Nothing, filename, file_size, content_type, content}
            Me.Rows.Add(rowupload_testRow)
            Return rowupload_testRow
        End Function
        
        Public Function FindById(ByVal Id As Integer) As upload_testRow
            Return CType(Me.Rows.Find(New Object() {Id}),upload_testRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As upload_testDataTable = CType(MyBase.Clone,upload_testDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Friend Sub InitVars()
            Me.columnId = Me.Columns("Id")
            Me.columnfilename = Me.Columns("filename")
            Me.columnfile_size = Me.Columns("file_size")
            Me.columncontent_type = Me.Columns("content_type")
            Me.columncontent = Me.Columns("content")
        End Sub
        
        Private Sub InitClass()
            Me.columnId = New DataColumn("Id", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId)
            Me.columnfilename = New DataColumn("filename", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfilename)
            Me.columnfile_size = New DataColumn("file_size", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfile_size)
            Me.columncontent_type = New DataColumn("content_type", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncontent_type)
            Me.columncontent = New DataColumn("content", GetType(System.Byte()), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncontent)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnId}, true))
            Me.columnId.AutoIncrement = true
            Me.columnId.AllowDBNull = false
            Me.columnId.ReadOnly = true
            Me.columnId.Unique = true
            Me.columnfilename.AllowDBNull = false
            Me.columnfile_size.AllowDBNull = false
            Me.columncontent_type.AllowDBNull = false
            Me.columncontent.AllowDBNull = false
        End Sub
        
        Public Function Newupload_testRow() As upload_testRow
            Return CType(Me.NewRow,upload_testRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New upload_testRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(upload_testRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.upload_testRowChangedEvent) Is Nothing) Then
                RaiseEvent upload_testRowChanged(Me, New upload_testRowChangeEvent(CType(e.Row,upload_testRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.upload_testRowChangingEvent) Is Nothing) Then
                RaiseEvent upload_testRowChanging(Me, New upload_testRowChangeEvent(CType(e.Row,upload_testRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.upload_testRowDeletedEvent) Is Nothing) Then
                RaiseEvent upload_testRowDeleted(Me, New upload_testRowChangeEvent(CType(e.Row,upload_testRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.upload_testRowDeletingEvent) Is Nothing) Then
                RaiseEvent upload_testRowDeleting(Me, New upload_testRowChangeEvent(CType(e.Row,upload_testRow), e.Action))
            End If
        End Sub
        
        Public Sub Removeupload_testRow(ByVal row As upload_testRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class upload_testRow
        Inherits DataRow
        
        Private tableupload_test As upload_testDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableupload_test = CType(Me.Table,upload_testDataTable)
        End Sub
        
        Public Property Id As Integer
            Get
                Return CType(Me(Me.tableupload_test.IdColumn),Integer)
            End Get
            Set
                Me(Me.tableupload_test.IdColumn) = value
            End Set
        End Property
        
        Public Property filename As String
            Get
                Return CType(Me(Me.tableupload_test.filenameColumn),String)
            End Get
            Set
                Me(Me.tableupload_test.filenameColumn) = value
            End Set
        End Property
        
        Public Property file_size As Integer
            Get
                Return CType(Me(Me.tableupload_test.file_sizeColumn),Integer)
            End Get
            Set
                Me(Me.tableupload_test.file_sizeColumn) = value
            End Set
        End Property
        
        Public Property content_type As String
            Get
                Return CType(Me(Me.tableupload_test.content_typeColumn),String)
            End Get
            Set
                Me(Me.tableupload_test.content_typeColumn) = value
            End Set
        End Property
        
        Public Property content As Byte()
            Get
                Return CType(Me(Me.tableupload_test.contentColumn),Byte())
            End Get
            Set
                Me(Me.tableupload_test.contentColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class upload_testRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As upload_testRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As upload_testRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As upload_testRow
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
