console.log("Do you believe in magic?");
console.log("------------------------");

// The createSpellBook function takes a title and an array of spells as arguments and returns an object with two properties
function createSpellBook(title, spells) {
  return {
    Title: title,
    Spells: spells
  };
}

// The createSpell function takes a name, an isEvil boolean, and an energyReqired value as arguments and returns an object with three properties
function createSpell(name, isEvil, energyReqired) {
  return {
    Name: name,
    IsEvil: isEvil,
    EnergyReqired: energyReqired
  };
}

// The allSpells array contains five objects created using the createSpell function
let allSpells = [
  createSpell("Turn enemy into a newt", true, 5.1),
  createSpell("Conjure some gold for a local charity", false, 2.99),
  createSpell("Give a deaf person the ability to heal", false, 12.2),
  createSpell("Make yourself emperor of the universe", true, 100.0),
  createSpell("Convince your relatives your political views are correct", false, 2921.5)
];

// Two objects, goodBook and evilBook, are created using the createSpellBook function. The allSpells array is filtered to separate good and evil spells
let goodBook = createSpellBook("Good Book", allSpells.filter(spell => !spell.IsEvil));
let evilBook = createSpellBook("Evil Book", allSpells.filter(spell => spell.IsEvil));

// The displaySpellBook function takes a book object as an argument and prints the book's title and spells to the console
function displaySpellBook(book) {
  console.log(book.Title)
  for (const aSpell of book.Spells) {
    console.log(`${aSpell.Name}`)
  }
}

//  The displaySpellBook function is called with both goodBook and evilBook objects to display their contents
displaySpellBook(goodBook);
displaySpellBook(evilBook);
