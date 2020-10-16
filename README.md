# Mutagen.Bethesda.Analyzers

## What is it?
Currently in the research stage, this is a place to gather and compile information about known errors within Bethesda games that cause crashes, oddities, or other issues.

These will be used to power a tool that is able to quickly analyze a mod/load order and give a succinct listing of all the things that might cause CTDs, other issues, or perhaps look odd or atypical about a mod.

The focus would be offering all the interesting analysis results in one place that can be accessed and interacted with programatically by being exposed as a reusable library or CLI.  As such, any program could leverage the analyzer library to diagnose and evaluate the health of a mod or load order.   Perhaps down the road a GUI that can give a typical user all the details in one place in a way that succinct, and easily navigatable.

Another aspect that this library will strive for is live responsiveness.  It should have the ability to watch a folder/file and analyze + report issues in real time, short circuiting areas that did not change, and showing errors that show up or are removed in the mod/load order as the user modifies things on-disk.  Thus, they could hopefully leave the tool open and see the issues, while solving them elsewhere and seeing the errors disappear as they make the changes.

## How to Contribute
Not a coder?  No problem!  There's still things to do.

### Get Vocal About Your Bugs
If you're a modder, and have experienced a bug in a Bethesda game (lol) and have fixed it manually, then you can contribute!  **Make an issue describing the bug and how you triggered it, what you think was involved, and how you fixed it.**  This is one of the most important contributions to this project.

### Research Specifics
This project requires a lot of general research and testing that is unrelated to the C# code that will eventually be written.  Once a bug has been identified in general, there is a good amount of research that still needs to be done to iron out all the specifics.  What is the minimal trigger for the bug to occur, with as little outside noise as possible?  What are the concepts at play?  How severe is the error?  Does it crash the game?  Or just make something flicker weirdly?  How exactly would one reliably recognize the bug by poking around themselves?

### Code an Analyzer
If you are a coder, Analyzer snippets will need to be written to transform the distilled knowledge above into code that can identify the bug progromatically.  This stage is not yet ready to contribute to, as the core engine is still all theory; We're still in the bug catalog gathering stage.

## End Goal
Hopefully, if everything comes together, we'll all have a tool that can immediately identify the horde of bugs that a Bethesda mod setup can have and allow us to more easily digest and address them.
