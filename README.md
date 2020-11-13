# AssemblyExp

A .NET Assembly program encapsulation and extraction PoC.

## Build Requirements

1. Visual Studio 2019
1. Mono.Cecil NuGet package (already specified in `packages.config`)

## Runtime Requirements

1. .NET Framework 4+

## Quick Start

1. Build the "ProgramEncapsulator" and "ProgramExtractor" projects.
1. Start "ProgramEncapsulator" and do these steps:
   1. Select "extractor template loc," which MUST be the built "ProgramExtractor.exe" binary.
   1. Select "original program loc," which is the program to encapsulate.
   1. Select "output program loc," which is the packaged program to produce.
   1. Click on "encapsulate program" and close the window.
   ![Step 1a: Program Encapsulation](res/README\_1.PNG "Program Encapsulation")
   1. Now, the packaged program should exist.
   ![Step 1b: Program Encapsulation Output](res/README\_2.PNG "Program Encapsulation Output")
1. Start the packaged program and do these steps:
   1. Select "extraction loc," which by default contains the original encapsulated program name, and it's okay to rename it.
   1. Click on "extract program" and close the window.
   ![Step 2a: Program Extraction](res/README\_3.PNG "Program Extraction")
   1. Now, the extracted (restored) program should exist.
   ![Step 2b: Extracted Program](res/README\_4.PNG "Extracted Program")
   ![Step 2b: Running Extracted Program](res/README\_5.PNG "Running Extracted Program")
