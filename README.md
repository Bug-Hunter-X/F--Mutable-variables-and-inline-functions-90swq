# F# Mutable Variables and Inline Functions

This example demonstrates a subtle issue in F# related to mutable variables and inline functions.  Inline functions in F# perform optimizations that can prevent mutable variables from being used as arguments correctly. 

The `bug.fs` file shows a simple example where the `add2` function (inline) fails to compile when using mutable variables, while the regular function `add` works as expected. The `bugSolution.fs` file demonstrates the workaround.

## Bug Description:

The `add2` function will not compile because the mutable variables `x` and `y` cannot be passed to the inline function. This is because the compiler tries to optimize the inline function, and mutable variables can sometimes change unexpectedly during this optimization process. 

## Solution:

The solution is to either avoid using mutable variables or to refrain from using the `inline` keyword for functions that use mutable variables.