
// In our journal club we were talking about functions like fold and unfold.
// I was saying that many other common functions can be written in terms of
// these functions. The following code are some examples of implementing
// common higher order functions in terms of fold.

open LSeq

module M =

    // Fold is implemented here using recursion.
    // This should be tail recursive.
    let rec fold (f: 'a -> 'b -> 'a) (initial: 'a) (xs: 'b list): 'a =
        if List.isEmpty xs then
            initial
        else
            fold f (f initial (List.head xs)) (List.tail xs)

    // Reverses a list using fold
    let rev (xs: 'a list): 'a list =
        fold (fun yl x -> x :: yl) [] xs

    // foldBack is similar to fold except it starts at the back of the list.
    // This is also commonly called fold right.
    let foldBack (f: 'a -> 'b -> 'b) (xs: 'a list) (initial: 'b): 'b =
        fold (fun s x -> f x s) initial (rev xs)

    // Map using a foldBack.
    let map (f: 'a -> 'b) (items: 'a list): 'b list =
        List.foldBack (fun x ys -> (f x) :: ys) items []

    // Filtering using fold back.
    let filter (p: 'a -> bool) (xs: 'a list): 'a list =
        let apply (x: 'a) (xs: 'a list): 'a list =
            if p x then
                x :: xs
            else
                xs
        foldBack apply xs []

    // Collect using fold back.
    let collect (f: 'a -> 'b list) (xs: 'a list): 'b list =
        foldBack (fun x ys -> List.append (f x) ys) xs []

    // Reduce using fold
    let reduce (f: 'a -> 'a -> 'a) (xs: 'a list): 'a =
        fold f (List.head xs) (List.tail xs)

    // maxBy using reduce
    let maxBy (f: 'a -> 'b) (xs: 'a list): 'a =
        let xsWMax = map (fun x -> (x, f x)) xs
        let apply (a, amax) (b, bmax) =
            if bmax > amax then (a, amax) else (b, bmax)
        reduce apply xsWMax |> fst

    // max using maxBy
    let max (f: 'a -> 'b) (xs: 'a list): 'a =
        maxBy id xs

    // Sum using reduce
    let sum (xs: 'a list): 'a =
        reduce (+) xs

    // There are some other functions I was considering which don't
    // seem quite right implementing with fold or unfold
    // Specifically would be find. I am wondering if there is a
    // more generic higher order function that stops processing
    // at some point.

    // I could implement find using filter.
    // Now that I think about it, I think it could make sense to implement
    // find in terms of common functions such as this.
    // I believe the issue I have with find implemented like this for lists
    // is that it evaluates the predicate for the whole list even when it doesn't
    // need to. Having lazy versions of these functions (over sequences) might make sense.
    let find (p: 'a -> bool) (xs: 'a list): 'a =
        filter p xs |> List.head

let main =
    let xs = [1;2;3]
    for s in M.map (fun x -> x * x) xs do
        printfn $"{s}"
    printfn $"{M.sum xs}"

    printfn "Trying out lazy sequence"
    let xx =
        LSeq.counter 0
        |> LSeq.filter (fun x -> (x % 2) = 0)
        |> LSeq.take 10
        |> LSeq.toList

    for x in xx do
        printfn $"{x}"

main