console.log("Let's roll some dice, baby!")
console.log('---------------------------')

// The roll function takes two parameters, min and max, which represent the minimum and maximum values of the dice roll.
function roll(min, max) {
  min = Math.ceil(min)
  max = Math.floor(max)
  // Uses Math.floor and Math.random to generate a random integer between min and max (inclusive) and returns it.
  return Math.floor(Math.random() * (max - min + 1)) + min
}

// The numToString function takes an integer as a parameter and returns a string that represents the number
function numToString(num) {
  switch (num) {
    case 1:
      return 'one'
    case 2:
      return 'two'
    case 3:
      return 'three'
    case 4:
      return 'four'
    case 5:
      return 'five'
    case 6:
      return 'six'
    default:
      return 'Unknown'
  }
}

// The for loop runs 10 times, using the roll function to generate two random numbers between 1 and 6 for each round.
for (let i = 0; i < 10; i++) {
  let die1 = roll(1, 6)
  let die2 = roll(1, 6)

  // Uses the numToString function to convert each number to a word and creates a string that displays the result of the roll and whether or not it was a double.
  let message = `${numToString(die1)} + ${numToString(die2)} == ${die1 + die2}`
  if (die1 === die2) {
    message += ' DOUBLES!'
  }

  //  print the string to the console
  console.log(message)
}
