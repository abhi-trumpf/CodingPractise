const prompt = require("prompt-sync")();
function CalcRomanToInteger(s2) {
  const romanMap = {
    I: 1,
    V: 5,
    X: 10,
    L: 50,
    C: 100,
    D: 500,
    M: 1000,
  };
  let total = 0;

  for (let i = 0; i < s2.length; i++) {
    let first = romanMap[s2[i]];
    let second = romanMap[s2[i + 1]];

    if (second && first < second) {
      total = total - first;
    } else {
      total += first;
    }
  }

  console.log(`total is ${total}`);
}

let userInput = prompt("Enter the ROMAN VALUE: ");

if (userInput) {
  CalcRomanToInteger(userInput.toUpperCase());
} else {
  console.log("No input detected. Exiting...");
}
