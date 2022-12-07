using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void gridLookup_Init(object sender, EventArgs e) {
        ASPxGridLookup gl = (ASPxGridLookup)sender;
        gl.GridView.Width = Unit.Pixel(165);
        gl.DataSource = CreateDataIEnumerableSourceFromEnum(typeof(CustomEnum));
        gl.DataBind();
    }
    private IEnumerable<object> CreateDataIEnumerableSourceFromEnum(Type enumType) {
        //C# Only

        //foreach(int item in Enum.GetValues(enumType)) {
        //    yield return new { ItemID = item, ItemText = Enum.GetName(enumType, item) };
        //}

        List<object> dataSource = new List<object>();

        foreach(int item in Enum.GetValues(enumType)) {
            dataSource.Add(new { ItemID = item, ItemText = Enum.GetName(enumType, item) });
        }

        return dataSource;
    }
}

internal enum CustomEnum : int {
    Item1,
    Item2,
    Item3,
    Item4,
    Item5,
    Item6,
    Item7,
    Item8,
    Item9,
    Item10
}