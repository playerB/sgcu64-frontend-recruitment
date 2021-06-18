const form = document.getElementById("register-form");
form.addEventListener("submit", (event) => {
    //event.preventDefault();
    const formData = new FormData(form);
    const data = {};
    for (const [key, value] of formData.entries()) {
        /* USER CODE Begin: Validate data */
        data[key] = value;
        if (data["password"] != data["confirmpassword"]) {
			document
                .getElementById("confirmpassword")
                .setCustomValidity("Password confirmation mismatch");
            document.getElementById("confirmpassword").reportValidity();
        } else {
            document.getElementById("confirmpassword").setCustomValidity('');
			document.getElementById("confirmpassword").reportValidity();
        }
        /* USER CODE Begin: Validate data */
    }
    console.log(data);
	console.log(data["password"] != data["confirmpassword"]);
    /* USER CODE Begin: What happened next after recieve form data (Optional) */

    /* USER CODE END: What happened next after recieve form data (Optional) */
});
