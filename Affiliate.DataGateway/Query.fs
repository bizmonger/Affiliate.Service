namespace Affiliate.DataGateway

open System
open Affiliate.Operations

module Query =

    let status : GetStatus =

        fun receipt -> task { return Error <| Exception("TODO") }

    let commision : ListCommision =

        fun affiliate -> task { return Error <| Exception("TODO") }

    let leads : ListLeads =

        fun affiliate -> task { return Error <| Exception("TODO") }