namespace Affiliate

open System

module Language =

    type ErrorDescription = exn

    type Amount = {
        Value    : double
        Currency : string
    }

    type ContactMethod = {
        Type  : string
        Value : string
    }

    type Person = {
        FirstName : string
        LastName  : string
        ContactMethod : ContactMethod seq
    }

    type Affiliate =  {
        Member : Person
    }

    type QtyDetails = {
        Qty   : float
        Unit  : string
    }

    type Item = {
        Name  : string
        Description : string
        Price : Amount
        Qty   : QtyDetails
    }

    type Items = Item seq

    type PlatformItems = {
        Platform : string
        Items    : Items
    }

    type Transaction = PlatformItems

    type Commision = {
        Affiliate   : Affiliate
        Transaction : Transaction
    }

    type Lead = {
        Prospect : Person
        Items    : PlatformItems
    }

    type Leads = Lead seq
    
    module Registration =

        type Request = { Candidate : Person }

        type Receipt = {
            Registration : Request
            Timestamp    : DateTime
        }

        type Status = {
            Receipt   : Receipt
            Value     : string
            Timestamp : DateTime
        }