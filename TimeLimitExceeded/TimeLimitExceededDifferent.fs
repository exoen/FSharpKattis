open System
open System.IO
open System.Threading

let AbsoluteDifference x y = abs (x - y)

let readLines () = seq {
    use sr = new StreamReader (Console.OpenStandardInput())
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

[<EntryPoint>]
    let main argv =
        //Sleep past time limit
        Thread.Sleep(5);

        let lines = readLines();
        for line in lines do
            let splittedLine = line.Split(" ");
            printfn "%d" (AbsoluteDifference (splittedLine.[0] |> int64) (splittedLine.[1] |> int64))
        0