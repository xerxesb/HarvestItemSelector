open FsHttp
open FSharp.Data
open FSharp.Data.JsonExtensions

let r = http {
    GET "https://reqres.in/api/users"
}

let jv = r
         |> toJson

jv
|> fun json -> json?total.AsString()
|> printfn "%s"

jv
|> fun json -> json?data.AsArray()
|> Seq.length
|> printfn "%O"