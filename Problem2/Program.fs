// You can run this program as follows with F# properly installed:
// dotnet run <number>


let rec generateFibToN (x : int, y : int, n : int) = 
    if x + y < n then
        x + y :: generateFibToN(y, x + y, n)
    else 
        [];;

// Actually generates the list
let listOfFib numberToGoTo = 0 :: 1 :: generateFibToN (0, 1, numberToGoTo)

// Gets the list of fibonacci numbers up to N and filters it to only contain the even numbers and then sums them
let generateAnswer listOfFib = 
    listOfFib
    |> List.filter(fun x -> x % 2 = 0)
    |> List.sum


[<EntryPoint>]
let main args = 
    for arg in args do 
        let numberToGoTo = arg |> int
        let listOfFibToN = listOfFib numberToGoTo
        let finalAnswer = generateAnswer listOfFibToN

        printfn "The sum of even Fibonacci numbers up to %d is %d" numberToGoTo finalAnswer

    0