const prompt = require('prompt-sync')();
function IntegerToRoman() {
    const valmap =     // we need to create a const map
        [
        { val: 1000, sym: "M" }, { val: 900, sym: "CM" },
        { val: 500, sym: "D" },  { val: 400, sym: "CD" },
        { val: 100, sym: "C" },  { val: 90, sym: "XC" },
        { val: 50, sym: "L" },   { val: 40, sym: "XL" },
        { val: 10, sym: "X" },   { val: 9, sym: "IX" },
        { val: 5, sym: "V" },    { val: 4, sym: "IV" },
        { val: 1, sym: "I" }
     ];

    let userInput = prompt("Enter an integer: ");
    let num = parseInt(userInput);  // number version of string
    let result = "";

    for (let item of valMap) {
    while (num >= item.val) {
        result += item.sym;
        num -= item.val;
    }
}


}