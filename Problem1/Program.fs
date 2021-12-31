// If you have F# properly installed on your system and you are CD'ed into
// the Problem1 directory you can execute this program on integer inputs with the 
// following command: dotnet run <number> 

let addMultiplesOf3And5 listOfNumbers =
    listOfNumbers
    |> List.filter (fun x -> (x % 3 = 0 || x % 5 = 0))
    |> List.sum


[<EntryPoint>]
let main args = 
    for arg in args do 
        let numberToGoTo = arg |> int
        let listOfNumbers = [ for i in 1..numberToGoTo - 1 -> i]
        let answer = addMultiplesOf3And5 listOfNumbers 
        printfn "The sum of multiples of 3 and 5 up to %d is %d" numberToGoTo answer

    0