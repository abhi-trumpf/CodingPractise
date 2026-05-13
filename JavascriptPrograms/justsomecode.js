console.log("hi");
function myFun(a, b, ...manyMoreArgs)
{
    console.log("a", a);
    console.log("b", b);
    console.log("manyMoreArgs", manyMoreArgs);
}

myFun("one", "two", "three", "four", "five", "six");
*/

/*
 const program = {
        num : 5
    };
    const guests = program.num || 0;
    console.log(guests);


*/
//1
/*const game = { players : [["Neuer", "Pavard", "Martinez", "Alaba", "Davies",
     "Kimmich", "Goretzka", "Coman", "Muller", "Gnabry", "Lewandowski"],
    ["Burki", "Schulz", "Hummels", "Akanji", "Hakimi",
     "Weigl", "Witsel", "Hazard", "Brandt", "Sancho", "Gotze"]]};

    const[player1,player2] = game.players;  // assign to player 1 and player 2 object not an array 
    */
    //console.log(player1);
    //console.log(player2);
    /*
   
    const [gk1, ...fieldPlayers1] = player1;
    const [gk2, ...fieldplayers2] = player2;

    console.log(gk1);
    console.log(gk2);

    const allPlayers = player1.concat(player2);
    console.log(allPlayers);

    const players1Final = [...player1, 'Thiago','Coutinho','erisic'];
    console.log(players1Final);

    const game1={odds :{ 
        team1:1.5,
        draw:2.5,
        team2:6
    }
        */
    //1.
    /*
    const game = { players : [["Neuer", "Pavard", "Martinez", "Alaba", "Davies",
     "Kimmich", "Goretzka", "Coman", "Muller", "Gnabry", "Lewandowski"],
    ["Burki", "Schulz", "Hummels", "Akanji", "Hakimi",
     "Weigl", "Witsel", "Hazard", "Brandt", "Sancho", "Gotze"]]};

    const[player1,player2] = game.players; 

    for(let i =1;i<10 ;i++){
        console.log(`${i},${player1[i]}`);// usebackticks and dollar symbol
    }


    //2.
    const game2 = {
    odds: {
        team1: 1.5,
        draw: 2.5,
        team2: 6
    }
};
    const odds = Object.values(game2.odds);  //like ova 
    let average = 0;
    let sum = 0;
    for (const odd of odds){
    //average+=odd;
    sum+=(odd);
    }
    average= sum/odds.length;
    console.log(average);

    */
    //3.

    /*
    const s1 = new Set(['apple','pasta']);
    const s2 = new Set(['pineapple','watermelon','apple']);
    // Intersection
    const s3 = new Set([...s2].filter(x => s1.has(x)));
    console.log(s3); // 
    */



    /*
    const italianfood = new Set(['apple','pasta','oliveoil','garlic','basil','tomatoes']);

    const mexicanfood = new Set(['apple','rice','pizza','garlic']);  //ag
    

    const commonfood = italianfood.intersection(mexicanfood);// whatever items are common

    console.log(...commonfood);

    const new_union1 = italianfood.union(mexicanfood);  // no repeating 

    console.log(new_union1);

    const diff_1 = italianfood.difference(mexicanfood);  // only unique elements
    console.log(diff_1);
    
    const diff_2 = mexicanfood.difference(italianfood);
    console.log(diff_2);


    const sym_diff = italianfood.symmetricDifference(mexicanfood);

    console.log(sym_diff);
    */

    /*
    const rest = new Map();
    rest.set('name','babloo');
    console.log(rest);
    rest.set(1,'yess');              // 1
    rest.set('name','abhi');          // 2 but gets deleted 
    console.log(rest.get('name'));
    //console.log(rest.get('true'));  //using set and get 

    // string na string number na number 
    const time = 20;
    rest.set('open',10);
    rest.set('close',30);
    rest.set('false','output is falseee');
    rest.set('true','output is true');
    console.log(time>rest.get('open') && (time<rest.get('close')));  // very important line
    rest.delete(2);
    console.log(rest);
    */

/*
    const question = new Map([
        ["what is the best programming language in the world?"],
        [1,"C"],
        [2,"Python"],
        [3,"JavaScript"],
        [4,"true"],
        [5,"false"],
    ]);

    for(const [key,val] of question){  // iteration in maps 
        console.log(...key);
        console.log(...val);
    }

    if(question.get(1)=="C"){    // 1 should not be a string
        console.log("YESSSSS");
    }

*/


const gameevents = new Map([
    [17,'GOAL'],
    [36,'SUBSTITUTION'],
    [47,'GOAL'],
    [61,'SUBSTITUTION'],
    [64,'YELLOW CARD'],
    [69,'RED CARD'],
    [70,'SUBSTITUTION'],
    [72,'SUBSTITUTION'],
    [76,'GOAL'],
    [80,'GOAL'],
    [92,'YELLOW CARD'],
]);

const array = [new Set(gameevents.values())];//creating a set values are going to be unique meaning no duplicates
console.log([...array]); // convert set to array  [... ]

gameevents.delete(64);   // important keyword 

console.log("an event happened, on average, every 9 minutes");


for(const [val,action] of gameevents){            //square brackets 
    if(val<50){
        console.log("1st half:");
        console.log(val)
    }

    else{
        console.log("2nd half");
        console.log(val);
    }
}

