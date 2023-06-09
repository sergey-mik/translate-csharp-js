console.log('My Enemies List!')
console.log('----------------')

// an array of objects called 'enemies'. Each object represents an enemy and has four properties.
const enemies = [
  {
    FirstName: 'Joshua',
    LastName: 'Flowers',
    Offenses: [
      'Being a jerk to me in elementary school',
      'Not being nice to me in elementary school',
    ],
    IsReallyHated: true,
  },
  {
    FirstName: 'Darth',
    LastName: 'Vader',
    Offenses: [
      "Cut off Luke's hand",
      'Murdered all those kids',
      'Unkind management practices',
    ],
    IsReallyHated: false,
  },
  {
    FirstName: 'Betty',
    LastName: 'Rudelady',
    Offenses: [
      'Phone calls in the theater',
      'Phone calls on the bus',
      'Phone calls in line at the grocery store',
      'Poor conversationalist',
    ],
    IsReallyHated: true,
  },
  {
    FirstName: 'Leon',
    LastName: 'Peck',
    Offenses: ['Keeps giving me a hotplate'],
    IsReallyHated: false,
  },
]

// loop that iterates over the 'enemies' array. It declares a constant 'myEnemy' that is assigned each object in the array in turn.
for (const myEnemy of enemies) {
  if (myEnemy.IsReallyHated) {
    console.log(`${myEnemy.FirstName} ${myEnemy.LastName} (Really, really dislike!)`);
  } else {
    console.log(`${myEnemy.FirstName} ${myEnemy.LastName}`);
  }
}
