module Leap

let leapYear (year: int): bool =
    let isDivisibleBy a b = a % b = 0
    (isDivisibleBy year 4 && not (isDivisibleBy year 100))
    || isDivisibleBy year 400
