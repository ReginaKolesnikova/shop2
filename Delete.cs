using System;

public class Class1
{
	public Class1()
	{
	}
}

<dl class="row">
	<div class="form-group row">
	<label asp-for="CreatedAt" class="col-sm-2 col-form-label"></label>
	@Html.DisplayFor(Model => Model.CreatedAt)
	</div>
	</dl>

<dl class="row">
	<div class="form-group row">
	<label asp-for="ModifiedAt" class="col-sm-2 col-form-label"></label>
	@Html.DisplayFor(Model => Model.ModifiedAt)
</div>
</dl>

<form asp-action="DeleteConfirmation">
	<input type="hidden" asp-form="Id" />
	<input type="submit" value="Delete" class="btn btn-danger" />
	<args asp-action="index" asp-controller="spaceships" class="btn btn-primary">Back</a>
	</form>
	</div>