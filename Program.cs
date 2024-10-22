﻿using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// [1.19a] How many character(s) were created in 1981 (all series)?
Console.WriteLine($"How many characters created in 1981 {characters.Count(c => c.YearCreated == 1981)}");

// [1.19b] List the character(s) created in that 1981 (all series) - return character name and series only.
foreach(var obj in characters.Where(c => c.YearCreated == 1981).Select(c => new { c.Name, c.Series }).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
}

//[1.19c] How many character(s) were created in 1981 (Mario series)?
Console.WriteLine($"How many? {marios.Count(c => c.YearCreated == 1981)}");

//[1.19d] List the character(s) created in that 1981 (Mario series) - return character name only.
foreach(var obj in marios.Where(c => c.YearCreated == 1981).Select(c => new { c.Name}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name}");
}

//[1.19e] How many character(s) were created in 1981 (Donkey Kong series)?
Console.WriteLine($"How many? {dks.Count(c => c.YearCreated == 1981)}");

//[1.19f] List the character(s) created in that 1981 (Donkey Kong series) - return character name only.
foreach(var obj in marios.Where(c => c.YearCreated == 1981).Select(c => new { c.Name}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name}");
}

//[1.20a] How many character(s) made their first appearance in Donkey Kong 64
Console.WriteLine($"How many? {dks.Count(c => c.FirstAppearance == "Donkey Kong 64")}");

//[1.20b] List the character(s) that made their first appearance in Donkey Kong 64 - return character name only.
foreach(var obj in dks.Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => new { c.Name}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name}");
}

// [1.21a] Are there any character(s) with no alias (all series)?
bool CharacterNoAlias = characters.Any(c => c.Alias.Count == 0);
Console.WriteLine($"Are there characters that have no alias? {CharacterNoAlias}");
// [1.21b] How many character(s) with no alias (all series)?
Console.WriteLine($"How many? {characters.Count(c => c.Alias.Count == 0)}");
// [1.21c] List the character(s) with no alias (all series) - return character name, alias and series only.
foreach(var obj in characters.Where(c => c.Alias.Count == 0).Select(c => new { c.Name, c.Series}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
}


// [1.21a] Are there any character(s) with no alias (all series)?
bool MarioNoAlias = marios.Any(c => c.Alias.Count == 0);
Console.WriteLine($"Are there characters that have no alias? {MarioNoAlias}");
// [1.21b] How many character(s) with no alias (all series)?
Console.WriteLine($"How many? {marios.Count(c => c.Alias.Count == 0)}");
// [1.21c] List the character(s) with no alias (all series) - return character name, alias and series only.
foreach(var obj in marios.Where(c => c.Alias.Count == 0).Select(c => new { c.Name, c.Series}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
}

// [1.21a] Are there any character(s) with no alias (all series)?
bool DKNoAlias = dks.Any(c => c.Alias.Count == 0);
Console.WriteLine($"Are there characters that have no alias? {DKNoAlias}");
// [1.21b] How many character(s) with no alias (all series)?
Console.WriteLine($"How many? {dks.Count(c => c.Alias.Count == 0)}");
// [1.21c] List the character(s) with no alias (all series) - return character name, alias and series only.
foreach(var obj in dks.Where(c => c.Alias.Count == 0).Select(c => new { c.Name, c.Series}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
}