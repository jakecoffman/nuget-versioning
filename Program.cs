using NuGet.Versioning;

Console.WriteLine(SemanticVersion.Parse("1.0.0") == SemanticVersion.Parse("1.0.0+1"));
