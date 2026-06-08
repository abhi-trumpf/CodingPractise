const prompt = require('prompt-sync')();
function CalcRomanToInteger(s2)  // in javascript u need to pass just s2 as paramter
{
    const romanMap = {
    'I': 1,
    'V': 5,
    'X': 10,
    'L': 50,
    'C': 100,
    'D': 500,
    'M': 1000
    };
let total = 0;
//When you use `for (let items of s2)`, JavaScript doesn't give you the index numbers 
//(0, 1, 2). It hands you the **actual, raw letters** directly!
for(let i=0;i<s2.length;i++)
{
    let first = romanMap[s2[i]];// take char in a string ah
    let second = romanMap[s2[i+1]]; // having 1st and 2nd is good      
    // - It is an "index-based map lookup" that retrieves a value from an object 
  //dictionary using a specific character from the string index. 
  // If there is a second number, and it is bigger than the first one (e.g., IV) -> SUBTRACT!
        if (second && first < second) {
            total = total - first;
        }
        else{
            total += first;
        }
}

/*
so we take consecutive check which one is greater and based on that 
do addition or subtraction with respect to our total */

console.log(`total is ${total}`);// this braces also imp.
}

// 1. Ask for input (Program pauses here until you hit ENTER)
let userInput = prompt("Enter the ROMAN VALUE: ");

// 2. Only proceed if user actually typed something
if (userInput) {
    CalcRomanToInteger(userInput.toUpperCase());
} else {
    console.log("No input detected. Exiting...");
}

