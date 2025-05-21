import ErrorHandler from "./ErrorHandler.js";
import Validators from "./Validators.js";
import { Form } from "./SignUpForm.js";

const form = document.signUpForm;
const passwordInput = form.elements["PlainPassword"];
const emailInput = form.elements["Email"];

function checkFormInputs(event) {
  event.preventDefault();
  let isValid = true;

  const passwordMessages = Validators.validatePassword(passwordInput.value);
  if (passwordMessages.length > 0) {
    isValid = false;
    passwordMessages.forEach((message) => {
      ErrorHandler.showError(passwordInput, message);
    });
  }

  const emailError = Validators.validateEmail(emailInput.value);
  if (emailError != "") {
    isValid = false;
    ErrorHandler.showError(emailInput, emailError);
  }

  if (isValid) {
    document.getElementById("register-button").disabled = true;
    form.submit();
  }
}

form.addEventListener("submit", checkFormInputs);
