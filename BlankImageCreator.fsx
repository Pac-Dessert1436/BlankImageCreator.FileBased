#r "nuget: System.Drawing.Common"

open System.Drawing
open System

let width: int =
    try
        printfn "Enter width for blank image: "
        Console.ReadLine() |> int
    with :? FormatException ->
        printfn "! Program aborted with invalid input."
        printfn "! Please enter a valid integer for image width."
        exit 0

let height: int =
    try
        printfn "Enter height for blank image: "
        Console.ReadLine() |> int
    with :? FormatException ->
        printfn "! Program aborted with invalid input."
        printfn "! Please enter a valid integer for image height."
        exit 0

if OperatingSystem.IsWindowsVersionAtLeast(6, 1) then
    use bitmap: Bitmap = new Bitmap(width, height)

    let outputPath: string = sprintf "blank_%dx%d.png" width height
    bitmap.Save(outputPath, Imaging.ImageFormat.Png)

    printfn "Generated blank PNG image: %s" outputPath
else
    failwith "This program only supports Windows 7 or later."

