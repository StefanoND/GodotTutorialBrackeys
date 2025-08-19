# Debug

Custom system that to aid with debugging code in-game, by providing a
comprehensive, extensible way to render debugging information widgets.

The \_debug directory is where the code that makes this system work is stored.
It is as isolated from the game logic as possible, keeping even the scenes and
scripts in this separated directory as well.

Note the directory name starts with an underscore. In many programming
languages, starting a name with an underscore indicates that this is private to
some particular scope or class. That’s roughly the idea by using it here.

Nothing in \_debug is used to make game logic run, prepending the "\_" helps
communicate that.

This directory is specifically filtered out of game exports. This is only
intended to be used in a dev environment. So there's no reason to include them
in official release game builds.
