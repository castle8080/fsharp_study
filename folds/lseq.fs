namespace LSeq

(*
 * This was an exercise to write my own sequence like data structure which is lazy.
 *)

module LSeq =
    // The sequence is represented as either being empty or
    // as a value followed by a function returning the remaining.
    type lseq<'a> =
        | Empty
        | Value of value: 'a * next: (unit -> 'a lseq)

    // Create an empty sequence
    let empty<'a> = lseq.Empty

    // Is this an empty sequence or not.
    let isEmpty (xs: 'a lseq) =
        match xs with
            | Empty -> true
            | _ -> false

    let head (xs: 'a lseq) =
        match xs with
            | Empty -> raise (System.NullReferenceException())
            | Value (v, _) -> v

    let tail (xs: 'a lseq) =
        match xs with
            | Empty -> raise (System.NullReferenceException())
            | Value (_, next) -> next()

    let rec unfold (f: 's -> ('a * 's) option) (state: 's): 'a lseq =
        match f state with
            | Some (x, nState) -> lseq.Value(x, fun () -> unfold f nState)
            | None -> lseq.Empty
        
    let infinite (x: 'a) (_next: 'a -> 'a): lseq<'a> =
        let extract (lazyx: unit -> 'a) =
            let x = lazyx()
            Some(x, fun () -> _next x)
        unfold extract (fun () -> x)

    let map (f: 'a -> 'b) (xs: 'a lseq) =
        let extract (xs: 'a lseq): ('b * 'a lseq) option =
            match xs with
                | Empty -> None
                | Value (x, _next) -> Some(f x, tail xs)
        unfold extract xs

    let zip (xs: 'a lseq) (ys: 'b lseq): ('a * 'b) lseq =
        let extract (xs: 'a lseq, ys: 'b lseq): (('a * 'b) * ('a lseq * 'b lseq)) option =
            match (xs, ys) with
                | (Empty, _) -> None
                | (_, Empty) -> None
                | (Value(x, xNext), Value(y, yNext)) ->
                    Some((x, y), (tail xs, tail ys))
        unfold extract (xs, ys)

    let counter start =
        infinite (start) (fun x -> x + 1)
    
    let withN (xs: 'a lseq): ('a * int) lseq =
        zip xs (counter 1)

    let takeWhile (p: 'a -> bool) (xs: 'a lseq) : 'a lseq =
        let extract (xs: 'a lseq): ('a * 'a lseq) option =
            match xs with
                | Empty -> None
                | Value(x, xNext) ->
                    if p x then
                        Some(x, tail xs)
                    else
                        None
        unfold extract xs

    let take (n: int) (xs: 'a lseq): 'a lseq =
        xs
        |> withN
        |> takeWhile (fun (x, i)-> i <= n)
        |> map fst

    let rec fold (f: 'a -> 'b -> 'b) (initial: 'b) (xs: 'a lseq): 'b =
        match xs with
            | Empty -> initial
            | Value(x, xNext) -> fold f (f x initial) (tail xs)

    let toList (xs: 'a lseq): 'a list =
        fold (fun x xl -> x :: xl) [] xs |> List.rev

    let rec filter (p: 'a -> bool) (xs: 'a lseq): 'a lseq =
        match xs with
            | Empty -> Empty
            | Value(x, xNext) ->
                if p x then
                    Value(x, (fun () -> filter p (tail xs)))
                else
                    filter p (tail xs)

    let find (f: 'a -> bool) (xs: 'a lseq): 'a =
        xs
        |> filter f
        |> head