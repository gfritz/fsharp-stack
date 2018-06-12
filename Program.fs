// Learn more about F# at http://fsharp.org

open System
open Expecto

let rec evaluate (x: string) : char =
  match x with
  // ... cases
  | _ -> failwith "illogical"

[<Tests>]
let tests = testList "samples" [
    test "non-logic" {
        Expect.throws (fun _ -> evaluate "Kirkspeak" |> ignore) "illogical"
    }
]


[<EntryPoint>]
let main argv =
    Tests.runTestsInAssembly defaultConfig argv
