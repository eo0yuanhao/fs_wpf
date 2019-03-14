module Wpf_view
open System
open System.Windows
open System.Windows.Controls

let window:Window = Application.LoadComponent(new Uri("/MainWindow.xaml",UriKind.Relative)) |> unbox
let button1:Button = window.FindName("button1") |> unbox
let input1:TextBox = window.FindName("input1") :?> TextBox
let tip1: Label = window.FindName("tip1") :?> Label