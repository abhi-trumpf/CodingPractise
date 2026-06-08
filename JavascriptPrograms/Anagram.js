
function CheckAnagram(s1,s2){  // just need the variables no need str data type .
    let CorrectStringone = s1.toLowerCase().split('').sort().join('');
    let CorrectStringtwo = s2.toLowerCase().split('').sort().join('');

    if(CorrectStringone === CorrectStringtwo){
        return true;
    }

    else{
        return false
    }

}

let x = CheckAnagram("heart","earth");
console.log(x);