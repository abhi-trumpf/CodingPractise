let userinput = [1,1,2,3,55,55,100];

function RemoveDuplicates(n1){
    let CorrArray = [];  // define inside function so value flushes itself after every run
    for(let i =0;i<n1.length;i++)
        {
            if(!CorrArray.includes(n1[i]))  // .includes() is correct .Contains() is only for c# language.
                {
                    CorrArray.push(n1[i]);
                }
        }
        return CorrArray;
    }
let x = RemoveDuplicates(userinput);
console.log("After removing duplicates:"+x);


                

