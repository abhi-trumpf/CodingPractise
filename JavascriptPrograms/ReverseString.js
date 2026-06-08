let s2 = "hello";
let ResString = [];
function ReverseString(s2)
{ 
    for(let i =s2.length-1;i >=0;i--){
        ResString.push(s2[i]);
    }
    console.log("Reversed String:" + ResString.join(''));// use.join to group up individual chars as a word.
    // array of chars -> string -> which is a word 
}
ReverseString(s2);

