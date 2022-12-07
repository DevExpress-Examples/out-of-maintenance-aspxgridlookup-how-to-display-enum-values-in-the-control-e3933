Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub gridLookup_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim gl As ASPxGridLookup = CType(sender, ASPxGridLookup)
		gl.GridView.Width = Unit.Pixel(165)
		gl.DataSource = CreateDataIEnumerableSourceFromEnum(GetType(CustomEnum))
		gl.DataBind()
	End Sub
	Private Function CreateDataIEnumerableSourceFromEnum(ByVal enumType As Type) As IEnumerable(Of Object)
		'C# Only

		'foreach(int item in Enum.GetValues(enumType)) {
		'    yield return new { ItemID = item, ItemText = Enum.GetName(enumType, item) };
		'}

		Dim dataSource As New List(Of Object)()

		For Each item As Integer In System.Enum.GetValues(enumType)
			dataSource.Add(New With {Key .ItemID = item, Key .ItemText = System.Enum.GetName(enumType, item)})
		Next item

		Return dataSource
	End Function
End Class

Friend Enum CustomEnum As Integer
	Item1
	Item2
	Item3
	Item4
	Item5
	Item6
	Item7
	Item8
	Item9
	Item10
End Enum