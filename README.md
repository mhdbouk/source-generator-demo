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

## License

This project is licensed under the terms of the [LICENSE](LICENSE) file.