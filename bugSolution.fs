let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y // explicitly update x
    x

let updatedX = add x y

printf "%d %d %d" x y updatedX // Now prints 30 20 30 because x is directly updated within the add function.