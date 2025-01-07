let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let updatedX = add x y

printf "%d %d %d" x y updatedX // Expecting 10 20 30 but get 10 20 30

//The issue is that despite x and y being mutable and the add function seemingly modifying them,
// the values printed still reflect the initial values because the add function doesn't actually change them.