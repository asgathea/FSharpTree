open System

let input = Console.ReadLine()
let inputs = input.Split( );
let height = inputs.[0] |> int
let mutable style = 0
let mutable spacing = height - 1
let mutable twig_row = 1
let space = " "
let mutable twig = "XX"

if inputs.Length > 1 then style <- inputs.[1] |> int
if style = 1 then twig <- "X*"

let print_char number_of char =
    let mutable count = number_of
    while count > 0 do
        printf "%s" char
        count <- count - 1

// print star
print_char spacing space
printfn "%s" "*"

// print 1st twig row
print_char spacing space
printfn "%s" "X"

// print other twig rows
while spacing > 0 do
    spacing <- spacing - 1
    print_char spacing space
    print_char twig_row twig
    printfn "%s" "X"
    twig_row <- twig_row + 1

// print stem
spacing <- height - 1
print_char spacing space
printfn "%s" "I"
