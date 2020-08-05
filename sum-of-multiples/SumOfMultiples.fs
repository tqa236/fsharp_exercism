module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int =
    List.sum
        (List.filter (fun x -> not (List.forall (fun elem -> elem = 0 || x % elem <> 0) numbers))
             [ 1 .. upperBound - 1 ])
