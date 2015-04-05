// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open FillDatabase
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    FillDatabase.fillWithMockData
    Console.ReadLine() |> ignore
    0 // return an integer exit code
    