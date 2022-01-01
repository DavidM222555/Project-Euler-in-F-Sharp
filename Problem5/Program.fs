// This program can be run as 'dotnet run n' where n is the number of multiples you want to check up to

let isMultipleOfNumbersUpToN N numberToTest = 
    let result =
        [1..N]
        |> List.forall (fun x -> (numberToTest % x = 0))

    result


[<EntryPoint>]
let main args =
    let multiplesToGoUpTo = args[0] |> int

    // Create an infinite sequence of all numbers in increments of multiplesToGoUpTo.
    // This takes advantage of the fact that the answer to this problem will have to be a multiple of multiplesToGoUpTo by definition,
    // so we can save ourselves a decent amount of checking by not including all interim elements
    let seqToCheck = 
        Seq.initInfinite (fun n -> n * multiplesToGoUpTo)
        |> Seq.filter(fun x -> x <> 0)
    
    let answer = 
        seqToCheck 
        |> Seq.find(fun x -> isMultipleOfNumbersUpToN multiplesToGoUpTo x) 

    printfn "The first number to be a multiple of all numbers from 1 to %d is %d" multiplesToGoUpTo answer

    0