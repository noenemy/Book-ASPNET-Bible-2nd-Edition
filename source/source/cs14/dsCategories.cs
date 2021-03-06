﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.2914.16
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace adonet_cs {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class dsCategories : System.Data.DataSet {
        
        private CategoriesDataTable tableCategories;
        
        public dsCategories() {
            this.InitClass();
        }
        
        private dsCategories(SerializationInfo info, StreamingContext context) {
            this.InitClass();
            this.GetSerializationData(info, context);
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CategoriesDataTable Categories {
            get {
                return this.tableCategories;
            }
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.ReadXml(reader, XmlReadMode.IgnoreSchema);
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        private void InitClass() {
            this.DataSetName = "dsCategories";
            this.Namespace = "http://tempuri.org/dsCategories.xsd";
            this.tableCategories = new CategoriesDataTable();
            this.Tables.Add(this.tableCategories);
        }
        
        private bool ShouldSerializeCategories() {
            return false;
        }
        
        public delegate void CategoriesRowChangeEventHandler(object sender, CategoriesRowChangeEvent e);
        
        public class CategoriesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCategoryID;
            
            private DataColumn columnCategoryName;
            
            private DataColumn columnDescription;
            
            private DataColumn columnPicture;
            
            internal CategoriesDataTable() : 
                    base("Categories") {
                this.InitClass();
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn CategoryIDColumn {
                get {
                    return this.columnCategoryID;
                }
            }
            
            internal DataColumn CategoryNameColumn {
                get {
                    return this.columnCategoryName;
                }
            }
            
            internal DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            
            internal DataColumn PictureColumn {
                get {
                    return this.columnPicture;
                }
            }
            
            public CategoriesRow this[int index] {
                get {
                    return ((CategoriesRow)(this.Rows[index]));
                }
            }
            
            public event CategoriesRowChangeEventHandler CategoriesRowChanged;
            
            public event CategoriesRowChangeEventHandler CategoriesRowChanging;
            
            public event CategoriesRowChangeEventHandler CategoriesRowDeleted;
            
            public event CategoriesRowChangeEventHandler CategoriesRowDeleting;
            
            public void AddCategoriesRow(CategoriesRow row) {
                this.Rows.Add(row);
            }
            
            public CategoriesRow AddCategoriesRow(string CategoryName, string Description, System.Byte[] Picture) {
                CategoriesRow rowCategoriesRow = ((CategoriesRow)(this.NewRow()));
                rowCategoriesRow.ItemArray = new object[] {
                        null,
                        CategoryName,
                        Description,
                        Picture};
                this.Rows.Add(rowCategoriesRow);
                return rowCategoriesRow;
            }
            
            public CategoriesRow FindByCategoryID(int CategoryID) {
                return ((CategoriesRow)(this.Rows.Find(new object[] {
                            CategoryID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            private void InitClass() {
                this.columnCategoryID = new DataColumn("CategoryID", typeof(int), "", System.Data.MappingType.Element);
                this.columnCategoryID.AutoIncrement = true;
                this.columnCategoryID.AllowDBNull = false;
                this.columnCategoryID.ReadOnly = true;
                this.columnCategoryID.Unique = true;
                this.Columns.Add(this.columnCategoryID);
                this.columnCategoryName = new DataColumn("CategoryName", typeof(string), "", System.Data.MappingType.Element);
                this.columnCategoryName.AllowDBNull = false;
                this.Columns.Add(this.columnCategoryName);
                this.columnDescription = new DataColumn("Description", typeof(string), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescription);
                this.columnPicture = new DataColumn("Picture", typeof(System.Byte[]), "", System.Data.MappingType.Element);
                this.Columns.Add(this.columnPicture);
                this.PrimaryKey = new DataColumn[] {
                        this.columnCategoryID};
            }
            
            public CategoriesRow NewCategoriesRow() {
                return ((CategoriesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                // We need to ensure that all Rows in the tabled are typed rows.
                // Table calls newRow whenever it needs to create a row.
                // So the following conditions are covered by Row newRow(Record record)
                // * Cursor calls table.addRecord(record) 
                // * table.addRow(object[] values) calls newRow(record)    
                return new CategoriesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(CategoriesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CategoriesRowChanged != null)) {
                    this.CategoriesRowChanged(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CategoriesRowChanging != null)) {
                    this.CategoriesRowChanging(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CategoriesRowDeleted != null)) {
                    this.CategoriesRowDeleted(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CategoriesRowDeleting != null)) {
                    this.CategoriesRowDeleting(this, new CategoriesRowChangeEvent(((CategoriesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveCategoriesRow(CategoriesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        public class CategoriesRow : DataRow {
            
            private CategoriesDataTable tableCategories;
            
            internal CategoriesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableCategories = ((CategoriesDataTable)(this.Table));
            }
            
            public int CategoryID {
                get {
                    return ((int)(this[this.tableCategories.CategoryIDColumn]));
                }
                set {
                    this[this.tableCategories.CategoryIDColumn] = value;
                }
            }
            
            public string CategoryName {
                get {
                    return ((string)(this[this.tableCategories.CategoryNameColumn]));
                }
                set {
                    this[this.tableCategories.CategoryNameColumn] = value;
                }
            }
            
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableCategories.DescriptionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("이 값은 DBNull이므로 가져올 수 없습니다.", e);
                    }
                }
                set {
                    this[this.tableCategories.DescriptionColumn] = value;
                }
            }
            
            public System.Byte[] Picture {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableCategories.PictureColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("이 값은 DBNull이므로 가져올 수 없습니다.", e);
                    }
                }
                set {
                    this[this.tableCategories.PictureColumn] = value;
                }
            }
            
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableCategories.DescriptionColumn);
            }
            
            public void SetDescriptionNull() {
                this[this.tableCategories.DescriptionColumn] = System.Convert.DBNull;
            }
            
            public bool IsPictureNull() {
                return this.IsNull(this.tableCategories.PictureColumn);
            }
            
            public void SetPictureNull() {
                this[this.tableCategories.PictureColumn] = System.Convert.DBNull;
            }
        }
        
        public class CategoriesRowChangeEvent : EventArgs {
            
            private CategoriesRow eventRow;
            
            private System.Data.DataRowAction eventAction;
            
            public CategoriesRowChangeEvent(CategoriesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public CategoriesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
