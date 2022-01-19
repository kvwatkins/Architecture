namespace Prelude

(*
Notes -
    1) Composition is based on mathematical definition g after f in f# this is <<
    2) It followes that reverse composition in f# is >>
    3) The Y Combinator is impossible to implement in non lazy lauganges
        The implementation uses the Z combinator and implemeneted with GC collection in mind.
        This could also possibly be implemented with the rarely seen fixed keyword for cleaner syntax
        https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/fixed.

    Haskell Operators
        - ($)   - apply
        - (&)   - thrush
        - (.)   - compose
        - (<*>) - substitution
        - (=<<) - chain
References -
    https://hackage.haskell.org/package/data-aviary-0.4.0/docs/Data-Aviary-Birds.html
*)

[<AutoOpen>]
module Combinators =

    let id = id
    let constant x _ = x
    let compose f g x = f(g(x))
    let flip f x y = f y x
    let apply f x = f x
    let kite _ = id
    let thrush x f = f x
    let join f x = f x x
    let revCompose f g x = g(f(x))
    let substitution f g x = f(x) (g(x))
    let chain f g x = f (g(x)) x
    let liftA2 f g h x = f (g x) (h x)
    let on f g x y = f (g(x)) (g(y))
    let finch x y f = f y x
    let pairing x y f = f x y
    let join1 x y = y x x

    let fix' f x = 
            let r = ref Unchecked.defaultof<'a -> 'b>
            r.Value <- (f r.Value)
            f r.Value  x

    let I = id
    let K = constant
    let B = compose
    let C = flip
    let A = apply
    let Ki = kite
    let T = thrush
    let W = join
    let Q = revCompose
    let S = substitution
    let S_ = chain
    let S' = liftA2
    let P = on
    let F = finch
    let V = pairing
    let Y = fix'
    let W' = join1