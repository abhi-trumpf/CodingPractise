let word = "Pretty";

function CharMap(s){
    let result = {};   // we create an object cuz its a dictionary which is going to hold key-value pairs.
    // defining inside function so it flushes for every input.
    for(let item of s){
        if(result[item])   //the counter for that particular char - imp syntax 
        {
            result[item] = result[item] +1;
        }
        else{
            result[item] = 1;
        }
    }
    return result;
}

let x = CharMap(word);
console.log(x);





/*

You didn't hardcode rules for the letter 'P'.

You didn't hardcode rules for the letter 't'.

You just wrote one abstract sentence (result[item]), and the computer automatically warped its 
physical RAM layout into a customized table specifically matching the string "Pretty" */