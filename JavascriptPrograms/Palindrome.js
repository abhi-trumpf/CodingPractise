//2.Palindrome.js
/*
const prompt = require('prompt-sync')(); // 🟢 ADD THIS LINE TO THE VERY TOP!
let s2;
s2 = prompt("enter the string");
/*
for(let item of s2){
    console.log(item);
}*/
// 1. split('') breaks "hello" into ['h', 'e', 'l', 'l', 'o']   -  split into indicidual letters
// 2. reverse() flips it to ['o', 'l', 'l', 'e', 'h']
// 3. join('') glues it back into a string: "olleh"
/*
let reversedStr = s2.split('').reverse().join('');    // initialise with let then use .split('').reverse().join('');
console.log(`reversed string is, ${reversedStr}`);     // use backticks 
if(s2 == reversedStr)
{
    console.log("palindrome")
}
else{
    console.log("not palindrome");
}
*/

let userinput = 121;
let original = userinput;       // store  orginal val seperately
let rev = 0;
while(userinput >0){
    rev = (rev*10) + userinput%10;  // imp multiply by 10.
    userinput = Math.floor(userinput/10);  // Math.floor to get correct quotient.
}
if(rev == original){
    console.log("Palindrome");
}
else{
    console.log("not a Palindome");
}

