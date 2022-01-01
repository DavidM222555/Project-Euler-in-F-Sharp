
// Guided by https://dev.to/citizen428/comment/b896
let reverse (s : string) = 
    s 
    |> Seq.toArray
    |> Array.rev
    |> System.String

let isPalindromic (x : int) = 
    let stringOfX = string x 
    let reversedStringOfX = reverse stringOfX

    let result = if (stringOfX = reversedStringOfX) then true else false

    result

[<EntryPoint>]
let main args = 
    let startNumber = args[1]  |> int
    let endNumber = args[2] |> int

    let listOfNumbersFromStartToEnd = [startNumber..endNumber]

    let result = 
        listOfNumbersFromStartToEnd
        |> List.map (fun x -> List.map (fun y -> x * y) listOfNumbersFromStartToEnd)
        |> List.concat
        |> List.filter(fun z -> isPalindromic z)
        |> List.max

    printfn "The answer for the number of palindromic products from %d to %d is %d" startNumber endNumber result 
    
    0

