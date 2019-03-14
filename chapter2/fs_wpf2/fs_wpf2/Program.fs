// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open System.Windows
open System.Windows.Controls

module ui = Wpf_view.NamedUiElement
//[<EntryPoint>]
[<STAThread>]
//let main argv = 
    //printfn "%A" argv    
    //0 // return an integer exit code
do      
    let win=ui.window
    ui.button1.Click.Add (fun x-> ui.tip1.Content <- ui.textbox.Text)
    Application().Run win |> ignore

