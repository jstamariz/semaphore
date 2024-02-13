# Project explanation

This project emulates the line to buying into a coffee, the people who manages this cofee can just attend five people ot the same time, in order to manage the resource that I have (the people who attend) I'm suing the Semaphone class from the Threading namespace.

Each person takes his own time buying products, that's why I randomized it, the rule is that the person who wants to buy something should wait until an spot frees in the line, hence the `semaphone.WaitOne()` does the trick.

Hope this serves it's purpose of showing some basic concepts about async programming. :)

-- Jorge Tamariz
