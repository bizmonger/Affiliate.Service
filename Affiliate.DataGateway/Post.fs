namespace Affiliate.DataGateway

open System
open Affiliate

module Post =

    let registration : Operations.Register =

        fun request -> task { return Error <| Exception("TODO") }
