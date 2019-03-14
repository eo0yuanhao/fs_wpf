namespace Wpf_view
module NamedUiElement=
    open System.Windows.Controls
    open WpfApp1

    let window:MainWindow= WpfApp1.MainWindow() |> unbox
    let button1:Button= window.FindName("button1") |> unbox
    let textbox = window.FindName("textbox") :?> TextBox
    let tip1 = window.FindName("tip1") :?> Label