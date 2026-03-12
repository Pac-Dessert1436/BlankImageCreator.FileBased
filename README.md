# BlankImageCreator.FileBased

## Description
`BlankImageCreator.FileBased` is a simple program that creates blank PNG images of specified dimensions. It is available as both a C# file-based application and an F# script, requiring [.NET 10.0 or later](https://dotnet.microsoft.com/download/dotnet/10.0).

## Features
- Create blank PNG images with custom dimensions
- Simple command-line interface
- Available in both C# and F# implementations
- Lightweight and dependency-free

## Installation & Usage
First, clone the repository and navigate to the project directory:
```bash
git clone https://github.com/Pac-Dessert1436/BlankImageCreator.FileBased.git
cd BlankImageCreator.FileBased
```

### C# File-Based App
```bash
dotnet run BlankImageCreator.cs <width> <height>

# For example, to create a blank 800x600 pixel image:
dotnet run BlankImageCreator.cs 800 600
```

### F# Script
```bash
dotnet fsi BlankImageCreator.fsx
# The script will prompt you for width and height interactively
```

## Project Structure
```
EmptyImageCreator/
├── BlankImageCreator.cs    # C# implementation
├── BlankImageCreator.fsx   # F# script implementation
├── blank_30x30.png         # Example output
├── LICENSE
└── README.md
```

## Example Output
The program creates blank PNG images with the specified dimensions. For example, running with dimensions 30x30 will generate a file like `blank_30x30.png`.

## License
This program is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.