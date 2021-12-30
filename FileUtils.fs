namespace JonThomas.AdventOfCode2021

module FileUtils =
    let readFileAsIntegers (filePath: string) : seq<int> =
        System.IO.File.ReadLines(filePath)
        |> Seq.map(fun x -> (int)x)

    let readFileAsStrings (filePath: string): list<string> =
        System.IO.File.ReadLines(filePath)
        |> Seq.toList

