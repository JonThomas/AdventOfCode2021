namespace JonThomas.AdventOfCode2021

open System.IO

module FileUtils =

    let sep = Path.DirectorySeparatorChar

    let readFileAsIntegers (filePath: string) : seq<int> =
        let osIndepententPath = filePath.Replace('\\', sep)
        System.IO.File.ReadLines(osIndepententPath)
        |> Seq.map(fun x -> (int)x)

    let readFileAsStrings (filePath: string): list<string> =
        let osIndepententPath = filePath.Replace('\\', sep)
        System.IO.File.ReadLines(osIndepententPath)
        |> Seq.toList

