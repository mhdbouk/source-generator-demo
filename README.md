# Source Generator for Minimal APIs

## Description

This project demonstrates how to use a source generator to automatically register endpoints in a Minimal API project.

This is demonstrated in a detailed YouTube video, go check it out

[![How to Organize Your .NET Minimal APIs with Source Generator](https://img.youtube.com/vi/zf5j-W11-qo/0.jpg)](https://youtu.be/zf5j-W11-qo)

## Project Structure

- `MinimalApis/`: Contains the Minimal API project with various endpoint classes.
- `SourceGenerator/`: Contains the source generator project that generates endpoint registration code.

## How to Use

1. Create a new endpoint class and implement the `IEndpoint` interface
2. Once created, the `SourceGenerator` will include the new endpoint to the `MapAllEndpoints` call in `Program.cs`

## Note

### Update 1: Using `abstract static` method
Note that I have updated the IEndpoint interface to include a `abstract static` method, which will be used by the source generator to generate the endpoint registration code without the need to initialize the endpoint class. Thanks to `@jamesparson2476` for the suggestion.

```csharp
public interface IEndpoint
{
    public abstract static void MapAllEndpoints(WebApplication app);
}
```

### Update 2: Check for `IEndpoint` interface in `Initialize` method

Another change was to move the logic of checking for classes implementing `IEndpoint` interface to when we create the syntax provider in the `Initialize` method. This is to avoid the need to check for the interface in the `Execute` method, which is called for each syntax node. Thanks to `@haydensprogramming6766` for the suggestion.


If you have any more comment, please do share them in the comment section of the YouTube video.

## License

This project is licensed under the terms of the [LICENSE](LICENSE) file.