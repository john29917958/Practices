function getIncreaseSalaryFunc() {
  let salary = 0;

  function increaseSalary() {
    let message = "Salary is ";
    salary = salary + 1000;
    console.log(message + salary);
  }

  return increaseSalary;
}

let increaseSalary = getIncreaseSalaryFunc();
for (let i = 0; i < 99999; i++) {
  increaseSalary(); // This prints my current salary
}
