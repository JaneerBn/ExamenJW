@page
@model PropertyManagerWeb.Pages.Account.LoginModel
@{
}

<form method="post">
    <div class="text-danger" asp-validation-summary="ModelOnly"></div>
    <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Email address</label>
        <input type="email" class="form-control"
               asp-for="Email"
               id="exampleInputEmail1" aria-describedby="emailHelp">
        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
        <div>
            <span class="text-danger" asp-validation-for="Email"></span>
        </div>
    </div>
    <div class="mb-3">
        <label for="exampleInputPassword1" class="form-label">Password</label>
        <input type="password" class="form-control"
               asp-for="Password"
               id="exampleInputPassword1">
        <div>
            <span class="text-danger" asp-validation-for="Password"></span>
        </div>
    </div>
    <div class="mb-3 form-check">
        <input type="checkbox" class="form-check-input" id="exampleCheck1">
        <label class="form-check-label" for="exampleCheck1">Check me out</label>
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
</form>
