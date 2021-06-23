const form = document.getElementById("register-form");
const inputPassword = document.getElementById("password");
const inputConfirmPassword = document.getElementById("confirmpassword");

function checkStrongPassword() {
	const strongPassword = new RegExp("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})")
	if (strongPassword.test(inputPassword.value)) {
		inputPassword.setCustomValidity("");
		inputPassword.reportValidity();
	} else {
		inputPassword.setCustomValidity("Your password must contain\n- at least 8 characters\n- at least one capital letter\n- at least one small letter\n- at least one number");
		inputPassword.reportValidity();
	}
}

function checkConfirmPassword() {
	if (inputPassword.value == inputConfirmPassword.value && inputConfirmPassword.value != '') {
		inputConfirmPassword.setCustomValidity("");
		inputPassword.reportValidity();
	} else {
		inputConfirmPassword.setCustomValidity("Password confirmation mismatch");
		inputPassword.reportValidity();
	}
}

form.addEventListener("submit", event => {
	event.preventDefault();
	console.log("Form submitted!");
	const formData = new FormData(form);
	const data = {};
	for (const [key, value] of formData.entries()) data[key] = value;
	console.log(data);
});

inputPassword.addEventListener("input", () => {
	checkStrongPassword();
	checkConfirmPassword();
});
inputConfirmPassword.addEventListener("input", checkConfirmPassword);