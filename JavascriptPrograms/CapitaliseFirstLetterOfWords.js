
/*
function Operation(s2){
    for(let item of s2){  // this is going to display char by char with spaces.
        console.log(item);
    }
}*/

let sentence = "I want to be a cat";

function Operation(s2){
    let ResArr = [];
    let words = s2.split(' ');  // sort it word by word with a single blank space.
    for(let i=0;i<words.length;i++){ // for how many ever words there are 
        let word = words[i]
        ResArr.push(word[0].toUpperCase()+ word.slice(1));   // we are pushing words 1 by 1 into ResArr 
    }
    return ResArr;
}

let x = Operation(sentence);
console.log(x.join(' '));  // added a space btw ' '