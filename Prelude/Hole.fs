namespace Prelude

open System

(*-- http://www.fssnip.net/7V5/title/Emulating-Idrisstyle-holes --*)

[<AutoOpen>]
module Hole =
    type Hole = Hole

    [<CompilerMessage("Incomplete hole", 130)>]
    let (?) (_: Hole) (id: string) : 'T =
        sprintf "Incomplete hole '%s : %O'" id typeof<'T>
        |> NotImplementedException
        |> raise

(*
let abs n =
        if n >= 0 then n
        else Hole ?TODO_Negation

    // compile time warning:
    // Test.fs(28,15): warning FS0130: Incomplete hole
    // val abs : n:int -> int

    let y = abs 2 // successful
    let z = abs -1 // System.NotImplementedException: Incomplete hole 'TODO_Negation : System.Int32'
*)