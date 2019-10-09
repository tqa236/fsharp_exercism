module TwoFer

let twoFer (input: string option): string =
    let input = defaultArg input "you"
    "One for " + input + ", one for me."