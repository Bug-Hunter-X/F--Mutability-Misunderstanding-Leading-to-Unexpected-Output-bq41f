# F# Mutability Bug

This repository demonstrates a common misunderstanding regarding mutability in F#. The `bug.fs` file contains code that exhibits unexpected behavior due to an incorrect assumption about how mutable variables interact with functions.

The `bugSolution.fs` file provides a corrected version that clarifies the correct way to handle mutable variables in this scenario.

## Setup

1. Clone this repository.
2. Open the `.fs` files in your preferred F# IDE (e.g., Visual Studio, Rider).
3. Run the code and observe the results.

## Issue Description

The initial code demonstrates the following issues: Incorrect handling of mutable variables in functions, leading to unexpected output.  The solution improves code clarity and correctness.

## Bug Solution

The solution clearly shows how to correctly modify mutable variables within functions for the expected output.