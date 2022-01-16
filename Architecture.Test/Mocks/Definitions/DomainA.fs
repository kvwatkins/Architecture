﻿namespace Architecture.Test.Mocks.Definitions

open Architecture

[<AutoOpen>]
module DomainA =
    type DomainAAction =
        | IncAField1 of int
        | IncAField2 of int

    type DomainAState = { AField1: int; AField2: int }

    type DomainAEnvironment =
        { PrintAField1: int -> Effect<Never>
          PrintAField2: int -> Effect<Never> }
