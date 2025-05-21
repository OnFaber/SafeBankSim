class Validators {
  static messages = [];

  static validatePassword(password) {
    this.clearMessages();

    if (!password) {
      this.messages.push("Password obbligatoria");
      return this.messages;
    }
    const hasValidLength = password.length >= 8;
    const hasValidSpecial = /[!"£$%&\/()=?'^*]/.test(password);
    const hasValidNumber = /\d/.test(password);
    const hasValidLower = /[a-z]/.test(password);
    const hasValidUpper = /[A-Z]/.test(password);

    if (!hasValidLength)
      this.messages.push(
        "La password deve essere lunga tra 16 e 128 caratteri.",
      );
    if (!hasValidSpecial)
      this.messages.push(
        "La password deve contenere almeno un carattere speciale.",
      );
    if (!hasValidNumber)
      this.messages.push("La password deve contenere almeno un numero.");
    if (!hasValidLower)
      this.messages.push(
        "La password deve contenere almeno una lettera minuscola.",
      );
    if (!hasValidUpper)
      this.messages.push(
        "La password deve contenere almeno una lettera maiuscola.",
      );

    return this.messages;
  }

  static validateEmail(email) {
    const invalidDomains = [];
    const emailPattern = /^[^\s@]+@[a-zA-Z]+\.[a-zA-Z]+$/;

    if (!email) {
      return "email obbligatoria";
    }

    if (!emailPattern.test(email)) {
      return "Inserisci una email valida";
    } else {
      const emailDomain = email.split("@")[1];
      if (invalidDomains.includes(emailDomain)) {
        return `Dominio ${emailDomain} non ammesso`;
      } else {
        return "";
      }
    }
  }

  static clearMessages() {
    this.messages = [];
  }
}

export default Validators;
