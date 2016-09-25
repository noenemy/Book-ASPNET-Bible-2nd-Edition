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
Public Class dsRegion
    Inherits System.Data.DataSet
    
    Private table_Region As _RegionDataTable
    
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
    Public ReadOnly Property _Region As _RegionDataTable
        Get
            Return Me.table_Region
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
        Me.DataSetName = "dsRegion"
        Me.Namespace = "http://tempuri.org/dsRegion.xsd"
        Me.table_Region = New _RegionDataTable
        Me.Tables.Add(Me.table_Region)
    End Sub
    
    Private Function ShouldSerialize_Region() As Boolean
        Return false
    End Function
    
    Public Delegate Sub _RegionRowChangeEventHandler(ByVal sender As Object, ByVal e As _RegionRowChangeEvent)
    
    Public Class _RegionDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnRegionID As DataColumn
        
        Private columnRegionDescription As DataColumn
        
        Friend Sub New()
            MyBase.New("Region")
            Me.InitClass
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property RegionIDColumn As DataColumn
            Get
                Return Me.columnRegionID
            End Get
        End Property
        
        Friend ReadOnly Property RegionDescriptionColumn As DataColumn
            Get
                Return Me.columnRegionDescription
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As _RegionRow
            Get
                Return CType(Me.Rows(index),_RegionRow)
            End Get
        End Property
        
        Public Event _RegionRowChanged As _RegionRowChangeEventHandler
        
        Public Event _RegionRowChanging As _RegionRowChangeEventHandler
        
        Public Event _RegionRowDeleted As _RegionRowChangeEventHandler
        
        Public Event _RegionRowDeleting As _RegionRowChangeEventHandler
        
        Public Overloads Sub Add_RegionRow(ByVal row As _RegionRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Add_RegionRow(ByVal RegionID As Integer, ByVal RegionDescription As String) As _RegionRow
            Dim row_RegionRow As _RegionRow = CType(Me.NewRow,_RegionRow)
            row_RegionRow.ItemArray = New Object() {RegionID, RegionDescription}
            Me.Rows.Add(row_RegionRow)
            Return row_RegionRow
        End Function
        
        Public Function FindByRegionID(ByVal RegionID As Integer) As _RegionRow
            Return CType(Me.Rows.Find(New Object() {RegionID}),_RegionRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Private Sub InitClass()
            Me.columnRegionID = New DataColumn("RegionID", GetType(System.Int32), "", System.Data.MappingType.Element)
            Me.columnRegionID.AllowDBNull = false
            Me.columnRegionID.Unique = true
            Me.Columns.Add(Me.columnRegionID)
            Me.columnRegionDescription = New DataColumn("RegionDescription", GetType(System.String), "", System.Data.MappingType.Element)
            Me.columnRegionDescription.AllowDBNull = false
            Me.Columns.Add(Me.columnRegionDescription)
            Me.PrimaryKey = New DataColumn() {Me.columnRegionID}
        End Sub
        
        Public Function New_RegionRow() As _RegionRow
            Return CType(Me.NewRow,_RegionRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            'We need to ensure that all Rows in the tabled are typed rows.
            'Table calls newRow whenever it needs to create a row.
            'So the following conditions are covered by Row newRow(Record record)
            '* Cursor calls table.addRecord(record) 
            '* table.addRow(object[] values) calls newRow(record)    
            Return New _RegionRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(_RegionRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me._RegionRowChangedEvent) Is Nothing) Then
                RaiseEvent _RegionRowChanged(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me._RegionRowChangingEvent) Is Nothing) Then
                RaiseEvent _RegionRowChanging(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me._RegionRowDeletedEvent) Is Nothing) Then
                RaiseEvent _RegionRowDeleted(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me._RegionRowDeletingEvent) Is Nothing) Then
                RaiseEvent _RegionRowDeleting(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Public Sub Remove_RegionRow(ByVal row As _RegionRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    Public Class _RegionRow
        Inherits DataRow
        
        Private table_Region As _RegionDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.table_Region = CType(Me.Table,_RegionDataTable)
        End Sub
        
        Public Property RegionID As Integer
            Get
                Return CType(Me(Me.table_Region.RegionIDColumn),Integer)
            End Get
            Set
                Me(Me.table_Region.RegionIDColumn) = value
            End Set
        End Property
        
        Public Property RegionDescription As String
            Get
                Return CType(Me(Me.table_Region.RegionDescriptionColumn),String)
            End Get
            Set
                Me(Me.table_Region.RegionDescriptionColumn) = value
            End Set
        End Property
    End Class
    
    Public Class _RegionRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As _RegionRow
        
        Private eventAction As System.Data.DataRowAction
        
        Public Sub New(ByVal row As _RegionRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As _RegionRow
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