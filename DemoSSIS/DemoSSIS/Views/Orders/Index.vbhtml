@ModelType IEnumerable(Of DemoSSIS.Order)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PackageId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OrderId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompletedBy)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompletedDateTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SkidDateTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProductGroupCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EquivalentWeightedMean)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EntDate)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PackageId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OrderId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CompletedBy)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CompletedDateTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SkidDateTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ProductGroupCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EquivalentWeightedMean)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EntDate)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
