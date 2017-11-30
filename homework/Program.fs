// Дополнительные сведения о F# см. на http://fsharp.org
// Дополнительную справку см. в проекте "Учебник по F#".
open System

type SquireRootResult =
    |NoRoots
    |OneRoot of double
    |TwoRoots of double * double //кортеж

//вычисление корней
let Calculate(a:double, b:double, c:double):SquireRootResult =
    let D = b*b - 4.0*a*c
    if D < 0.0 then NoRoots
    else if D = 0.0 then
        let r = -b/(2.0 * a)
        OneRoot r
    else
        let r1 = (-b + Math.Sqrt(D)) / (2.0 * a)
        let r2 = (-b - Math.Sqrt(D)) / (2.0 * a)
        TwoRoots (r1, r2)

 //вывод корней
let Print(a:double, b:double, c:double):unit =
    printf "Коэффициенты: a = %A, b = %A, c = %A. " a b c 
    let root = Calculate(a, b, c)
    let text = 
        match root with
        | NoRoots -> "Корней нет"
        | OneRoot(r) -> "Один корень " + r.ToString()
        | TwoRoots(r1, r2) -> "Два корня " + r1.ToString() + " и " + r2.ToString()
    printfn "%s" text

//пауза
let Pause() =
        match System.Diagnostics.Debugger.IsAttached with
        | true ->
           printfn "Нажмите любую кнопку, чтобы продолжить."
           System.Console.ReadLine() |> ignore
        | false -> ()

//ввод с клавиатуры
let rec Read() =
        printfn "Введите число"
        match System.Double.TryParse(System.Console.ReadLine()) with
        | false, _ -> printfn "Введите ещё раз"; Read()
        | _, x -> x

[<EntryPoint>]
let main _ = 
    let mutable a = Read();
    let mutable b = Read();
    let mutable c = Read();
    Print(a, b, c)

    printfn "Проверка, что программа работает"
    a <- 3.0
    b <- 6.0
    c <- 0.0
    Print(a, b, c)

    Pause()

    0

    
    

