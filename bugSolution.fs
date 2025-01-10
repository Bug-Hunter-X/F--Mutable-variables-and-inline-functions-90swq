let x = 10
let y = 20

let add x y =  x + y

let inline add2 x y = x + y

let z = add x y
let w = add2 x y
printf "%d %d" z w