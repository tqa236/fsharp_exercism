module DifferenceOfSquares

let squareOfSum (number: int): int = pown (List.sum [ 1..number ]) 2

let sumOfSquares (number: int): int =
    List.sum [ for i in 1..number -> i * i ]

let differenceOfSquares (number: int): int =
    squareOfSum number - sumOfSquares number
