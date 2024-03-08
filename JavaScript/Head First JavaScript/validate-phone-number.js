// 123-4567
function validate(phoneNumber) {
  let numberParts = [];
  if (phoneNumber.charAt(3) === "-") {
    numberParts = phoneNumber.split("-");
  } else {
    numberParts = [phoneNumber];
  }
  let digits = 0;
  for (const numberPart of numberParts) {
    for (const digit of numberPart) {
      const digitNumber = Number(digit);
      if (digitNumber => 0 && digitNumber <= 9) {
        digits++;
      }
    }
  }
  if (digits === 7) {
    return true;
  } else {
    return false;
  }
}

console.log(validate("123-4567"));
console.log(validate("000-0000"));
console.log(validate(""));
console.log(validate("1"));
console.log(validate("-"));
console.log(validate("123-"));
console.log(validate("-4567"));
console.log(validate("1-4"));
console.log(validate("123-4"));
console.log(validate("1-4567"));
console.log(validate("-23-4567"));
console.log(validate("12--4567"));
console.log(validate("123--567"));
console.log(validate("123-456-"));
