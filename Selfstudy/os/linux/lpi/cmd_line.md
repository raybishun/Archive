# The Command Line

## Variables
```
printenv
    print environment variables.
    A varible in all UPPER_CASE is an env. variable.
```

## Quoting
```
#!/bin/sh
Echo "Hello; World"
    Hello; World
```

## Escaping
```
#!/bin/sh
Echo Hello\; World (note the esc character)
    Hello; World
```

## ls
```
ls -hal
```
* ls --help
* h = human-readable file/directory sizes
* a = all (or --all)
* l = long listing format

## Creating files
```
touch - create an empty file
echo apple >> fruit.txt - create file with text
```

## Multiple Commands
```
echo Hello; ls
```

## Getting help
```
ls --help
```

## Man Pages
* whatis - find man pages that exist for a given command.
```
man ls
man -k ls (search man pages)
```

## Info Pages
* More detailed than man pages
* Divided into different pages
* p = previous
* n = next
* q = quit
```
info ls 
```