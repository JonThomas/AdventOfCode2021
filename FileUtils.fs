namespace JonThomas.AdventOfCode2021

module FileUtils =
    let readFile (filePath: string) : seq<int> =
        System.IO.File.ReadLines(filePath)
        |> Seq.map(fun x -> (int)x)
