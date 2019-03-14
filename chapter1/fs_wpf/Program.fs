open System
open System.Windows
open System.Windows.Controls

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

//[<EntryPoint>]
//let main argv = 
//    //printfn "%A" argv
//    0 // return an integer exit code
open Wpf_view
[<STAThread>]
do
    Application().Run (window)    |> ignore