// An array of place names is declared and initialized
const names = [
  'Nashville',
  'Hong Kong',
  'The back yard',
  'Earth',
  'London',
  'The mall',
  'Ryman Auditorium',
  'The Great Wall of China',
]

console.log('All Place Names')

// loop is used to iterate through the names array and log each place name to the console
for (const name of names) {
  console.log(name)
}

console.log('\n')

// The filter() method is used on the names array to create a new array called theNames that contains only the place names starting with "The". The startsWith() method is used to check if a place name starts with the specified string.
const theNames = names.filter((n) => n.startsWith('The'))

console.log("'The' Place Names")

// Loop is used to iterate through the theNames array and log each filtered place name to the console.
for (const theName of theNames) {
  console.log(theName)
}
