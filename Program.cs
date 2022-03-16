using NuGet.Versioning;

Console.WriteLine(SemanticVersion.Parse("1.0.0") == SemanticVersion.Parse("1.0.0+1")); // True
Console.WriteLine(SemanticVersion.Parse("1.0.0-alpha") == SemanticVersion.Parse("1.0.0-ALPHA")); // True
//SemanticVersion.Parse("1.0.0.1"); // ArgumentException
//SemanticVersion.Parse("1") // ArgumentException
