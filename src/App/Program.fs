open System

let input = Console.ReadLine()
let input_values = input.Split( );
let tree_height = input_values.[0] |> int
let space = " "
let mutable chosen_twigs = "XX"

if input_values.Length > 1 then chosen_twigs <- "X" + input_values.[1]

let twigs = chosen_twigs

let spacing_per_row row = tree_height - row - 1

let print_char number_of char =
    let mutable count = number_of
    while count > 0 do
        printf "%s" char
        count <- count - 1

// print star
let center_spacing = spacing_per_row 0
print_char center_spacing space
printfn "%s" "*"

// print 1st twig row
print_char center_spacing space
printfn "%s" "X"

// print other twig rows
let mutable current_row = 1
while current_row < tree_height do
    let row_spacing = spacing_per_row current_row
    print_char row_spacing space
    print_char current_row twigs
    printfn "%s" "X"
    current_row <- current_row + 1

// print stem
print_char center_spacing space
printfn "%s" "I"
