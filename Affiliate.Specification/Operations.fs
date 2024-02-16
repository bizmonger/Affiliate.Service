namespace Affiliate

open System.Threading.Tasks
open Language

module Operations =

    type Register  = Registration.Request -> Task<Result<Registration.Receipt, ErrorDescription>>
    type GetStatus = Registration.Receipt -> Task<Result<Registration.Status , ErrorDescription>>

    type ListCommision = Affiliate -> Task<Result<Commision, ErrorDescription>>
    type ListLeads     = Affiliate -> Task<Result<Lead     , ErrorDescription>>