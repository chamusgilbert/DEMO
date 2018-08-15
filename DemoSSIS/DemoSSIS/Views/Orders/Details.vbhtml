@ModelType DemoSSIS.Order
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Order</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PackageId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PackageId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OrderId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OrderId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CompletedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CompletedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CompletedDateTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CompletedDateTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SkidDateTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SkidDateTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ProductGroupCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ProductGroupCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EquivalentWeightedMean)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EquivalentWeightedMean)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EntDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EntDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
