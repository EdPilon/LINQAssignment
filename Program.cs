using System.Text.Json;

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


// [1.21d] Are there any character(s) with no alias (Mario series)?
bool MarioNoAlias = marios.Any(c => c.Alias.Count == 0);
Console.WriteLine($"Are there characters that have no alias? {MarioNoAlias}");
// [1.21e] How many character(s) with no alias (Mario series)?
Console.WriteLine($"How many? {marios.Count(c => c.Alias.Count == 0)}");
// [1.21f] List the character(s) with no alias (Mario series) - return character name and alias only.
foreach(var obj in marios.Where(c => c.Alias.Count == 0).Select(c => new { c.Name, c.Series}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
}

// [1.21g] Are there any character(s) with no alias (Donkey Kong series)?
bool DKNoAlias = dks.Any(c => c.Alias.Count == 0);
Console.WriteLine($"Are there characters that have no alias? {DKNoAlias}");
// [1.21h] How many character(s) with no alias (Donkey Kong series)?
Console.WriteLine($"How many? {dks.Count(c => c.Alias.Count == 0)}");
// [1.21i] List the character(s) with no alias (Donkey Kong series) - return character name and alias only.
foreach(var obj in dks.Where(c => c.Alias.Count == 0).Select(c => new { c.Name, c.Series}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
}

//[1.22a] Do any character(s) have an alias of Snowmad King (return type must be boolean)?
bool Snowmad = characters.Any(c => c.Alias.Any(alias => alias == "Snowmad King"));
Console.WriteLine($"Are there characters that have 'Snowmad King' as an alias? {Snowmad}");
//[1.22b] List the character(s) that have an alias of Snowmad King - return character name and alias only.
foreach(var obj in characters.Where(c => c.Alias.Any(alias => alias == "Snowmad King")).Select(c => new { c.Name, c.Alias}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Alias)}");
}

//[1.23a] Do any character(s) that have an alias of Winter Kong (return type must be boolean)?
bool Winter = characters.Any(c => c.Alias.Any(alias => alias == "Winter Kong"));
Console.WriteLine($"Are there characters that have 'Winter Kong' as an alias? {Winter}");
//[1.23b] List the character(s) that have an alias of Winter Kong - return character name and alias only.
foreach(var obj in characters.Where(c => c.Alias.Any(alias => alias == "Winter Kong")).Select(c => new { c.Name, c.Alias}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Alias)}");
}

//[1.24a] How many character(s) have a species of Kremling?
int Kremling = characters.Count(c => c.Species == "Kremling");
Console.WriteLine($"How many characters are Kremling? {Kremling}");
//[1.24b] List the character(s) that have a species of Kremling - return character name only.
foreach(var obj in characters.Where(c => c.Species == "Kremling").Select(c => new { c.Name}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name}");
}

//[1.25a] How many character(s) in the Mario series are Human species?
bool Human = marios.Any(c => c.Species == "Human");
Console.WriteLine($"Are there characters that are Human? {Human}");
//[1.25b] List the character(s) in the Mario series that are Human species - return character name only.
foreach(var obj in marios.Where(c => c.Species == "Human").Select(c => new { c.Name}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name}");
}

//[1.25c] How many character(s) in the Mario series are Koopa species?
bool Koopa = marios.Any(c => c.Species == "Koopa");
Console.WriteLine($"Are there characters that are Koopa? {Koopa}");
//[1.25d] List the character(s) in the Mario series that are Koopa species - return character name only.
foreach(var obj in marios.Where(c => c.Species == "Koopa").Select(c => new { c.Name}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name}");
}

//[1.25e] How many character(s) in the Mario series are something other than Human or Koopa species?
int Kouman = characters.Count(c => (c.Species != "Human") && (c.Species != "Koopa"));
Console.WriteLine($"How many characters are not human or koopa? {Kouman}");
//[1.25f] List the character(s) in the Mario series that are something other than Human or Koopa species - return character name and species only.
foreach(var obj in marios.Where(c => (c.Species != "Human") && (c.Species != "Koopa")).Select(c => new { c.Name, c.Species}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Species)}");
}
//[1.26] List the character(s) in the Donkey Kong series that are something other than Human or Kong species - return character name and species only?
foreach(var obj in dks.Where(c => (c.Species != "Human") && (c.Species != "Kong")).Select(c => new { c.Name, c.Species}).OrderBy(c => c.Name))
{
    Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Species)}");
}







