namespace JonThomas.AdventOfCode2021

open JonThomas.AdventOfCode2021

module Day2 =

    let filePath = ".\day2\Day2-Input.txt"

    // Record to hold movement values - one Movement for each line in the input file.
    type Movement = { direction: string; distance: int }

    // Convert a line from the file to a Movement-record
    let stringToMovement (line:string): Movement = 
        let result = line.Split([|' '|])
        { direction = result[0]; distance = int result[1] }

    let day21 = 

        // Main function:
        // Recursively go through each line from the file; Evaluate the first item in the list (the Head),
        // and then process the rest of the list (the Tail) with the result from the Head.
        let rec evaluateMovement (movement: string list) (horiz: int, verti: int) = 
            match movement with
            // Empty list means we're done
            | [] -> (horiz, verti)
            // Binding to head::tail
            | head::tail -> 
                let mov = stringToMovement head
                match mov with 
                | { direction = "down"; distance = howLong} -> evaluateMovement tail (horiz, verti + howLong)
                | { direction = "up"; distance = howLong} -> evaluateMovement tail (horiz, verti - howLong)
                | { direction = "forward"; distance = howLong} -> evaluateMovement tail (horiz + howLong, verti)
                | x -> printfn "Invalid direction : {%s}" x.direction; (-1, -1)

        // Read from file
        let lines = FileUtils.readFileAsStrings filePath

        // Start processing, by calling recursive function with initial values
        let (horiz, verti) = evaluateMovement lines (0,0)

        (horiz * verti), $"\nThe answer is {horiz * verti}\n(Distance = {horiz}, Depth = {verti})"

    let day22 = 

        // Main function:
        // Recursively go through each line from the file; Evaluate the first item in the list (the Head),
        // and then process the rest of the list (the Tail) with the result from the Head.
        let rec evaluateMovement (movement: string list) (horiz: int, verti: int, aim: int) = 
            match movement with
            // Empty list means we're done
            | [] -> (horiz, verti, aim)
            // Binding to head::tail
            | head::tail -> 
                let mov = stringToMovement head
                match mov with 
                | { direction = "down"; distance = howLong} -> evaluateMovement tail (horiz, verti, aim + howLong)
                | { direction = "up"; distance = howLong} -> evaluateMovement tail (horiz, verti, aim - howLong)
                | { direction = "forward"; distance = howLong} -> evaluateMovement tail (horiz + howLong, verti + (aim * howLong), aim)
                | x -> printfn "Invalid direction : {%s}" x.direction; (-1, -1, -1)

        // Read from file
        let lines = FileUtils.readFileAsStrings filePath

        // Start processing, by calling recursive function with initial values
        let (horiz, verti, aim) = evaluateMovement lines (0, 0, 0)

        (horiz * verti), $"\nThe answer is {horiz * verti}\n(Distance = {horiz}, Depth = {verti})"