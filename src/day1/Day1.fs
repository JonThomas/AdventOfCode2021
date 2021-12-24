namespace JonThomas.AdventOfCode2021

open JonThomas.AdventOfCode2021

module Day1 =

    let day11 = 

        //let filePath = "C:\dev\AdventOfCode2021\src\day1\Day1-Input1.txt"
        let filePath = ".\src\day1\Day1-Input1.txt"
        let lines = FileUtils.readFile filePath 
        let lines2 = FileUtils.readFile filePath 
                    |> Seq.tail

        let decreasing = Seq.zip lines lines2
                        |> Seq.where (fun x -> (fst x) < (snd x))
                    // |> Seq.iter (fun x -> printfn "%d %d" (fst x) (snd x))

        printfn "The depth is decreasing %d number of times" (decreasing |> Seq.length)