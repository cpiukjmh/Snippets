
        s.Columns.Add(c =>
        {
            c.FieldName = "Modified";
            c.Caption = "Modified";
            c.Width = Unit.Percentage(20);
            c.PropertiesEdit.NullDisplayText = "dd/MM/yyyy";
            c.ColumnType = MVCxGridViewColumnType.DateEdit;
            //c.EditFormSettings.Visible = DefaultBoolean.False;
            c.SetEditItemTemplateContent(col =>
            {
                Html.DevExpress().Label(lbSettings =>
                {
                    lbSettings.Name = "Modified";
                    lbSettings.Text = col.Text;
                }).Render();
            });

        });
