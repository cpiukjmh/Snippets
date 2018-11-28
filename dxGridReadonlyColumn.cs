
settings.CellEditorInitialize += (s, e) =>
        {
            var grid = s as ASPxGridView;
            //var eCol = e.Column;      
            if(e.Column.FieldName == "ProductName")
            {
                e.Editor.ReadOnly = !grid.IsNewRowEditing;
            }            
        };
