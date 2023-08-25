function validateForm() {
    let university_Id = document.getElementById("universityId").value;
    let first_Name = document.getElementById("firstName").value;
    let last_Name = document.getElementById("lastName").value;
    let email = document.getElementById("email").value;
    let phone = document.getElementById("phone").value;
    if (phone.length != 11  || !phonevalidator(phone)) {
        document.getElementById("phoneValidationMessage").innerHTML = "Please enter correct phone number";

        return false;
    }
    if (!email.includes(".")) {
        document.getElementById("emailValidationMessage").innerHTML = "Please enter correct email address";
        return false;
    }
    if (university_Id.length < 13) {
        document.getElementById("universityIdValidationMsg").innerHTML = "Please enter correct University Id";
        return false;
    }
    for (let i = 0; i < university_Id.length; i++) {
        if ((university_Id[i] >= 'A' && university_Id[i] <= 'Z') || (university_Id[i] >= '0' && university_Id[i] <= '9') || (university_Id[i] == ' ')) {

        } else {
            document.getElementById("universityIdValidationMsg").innerHTML = "Please enter correct University Id";
            return false;
        }
    }

    return nameValidator(first_Name, "firstNameValidationMsg") && nameValidator(last_Name, "lastNameValidationMsg");
}

function nameValidator(name, validationId) {
    for (let i = 1; i < name.length; i++) {
        if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z')) {

        }
        else {
            document.getElementById(validationId).innerHTML = "Only English letter is acceptable for name";
            return false;
        }
    }
    if (name[0] >= 'A' && name[0] <= 'Z') {

    }
    else {
        document.getElementById(validationId).innerHTML = "First character of name should be Capital letter!";
        return false;
    }

    return true;
}
function phonevalidator(phone) {
    for (var i = 0; i < phone.length; i++) {
        if (phone[i] >= 0 && phone[i] <= 9) {

        } else {
            return false;
        }
    }
    return true;
}

