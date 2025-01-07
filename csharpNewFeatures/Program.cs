




string[] words = new string[]
{
    "The","quick","brown","fox","jumps","over","the","lazy","dog"
};

//TODO:The index-from-end operator indexes from the end of a sequence
//note that the end is not zero-based, ^1 is the last time
Console.WriteLine(words[^1]);

//TODO : The range operator (..) defines a range
string[] wordRange = words[2..5];
Console.WriteLine($"{string.Join(",",wordRange)}");
wordRange = words[..];
Console.WriteLine($"{string.Join(",", wordRange)}");
wordRange = words[2..];
Console.WriteLine($"{string.Join(",", wordRange)}");
wordRange = words[..5];
Console.WriteLine($"{string.Join(",", wordRange)}");

//TODO: Indexes and ranges can be variables too
Index idx = ^4;
Console.WriteLine(words[idx]);

Range rng = 3..^1;
wordRange = words[rng];
Console.WriteLine($"{string.Join(",",wordRange)}");