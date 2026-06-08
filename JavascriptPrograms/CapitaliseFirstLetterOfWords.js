let sentence = "I want to be a cat";

function Operation(s2) {
  let ResArr = [];
  let words = s2.split(" ");
  for (let i = 0; i < words.length; i++) {
    let word = words[i];
    ResArr.push(word[0].toUpperCase() + word.slice(1));
  }
  return ResArr;
}

let x = Operation(sentence);
console.log(x.join(" "));
