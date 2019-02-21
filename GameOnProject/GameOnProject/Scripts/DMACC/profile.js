function updateProfile() {
    var FirstName = $("#firstName").val();
    var LastName = $("#lastName").val();
    var Gender = $("#gender").val();
    var Email = $("#email").val();
    var PhoneNumber = $("#phoneNumber").val();

    $.ajax({
        url: "UpdateProfile",
        dataType: "json",
        data: {
            FirstName: FirstName,
            LastName: LastName,
            Gender: Gender,
            Email: Email,
            PhoneNumber: PhoneNumber
        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden")
                .addClass("visible");
        }
    })
}