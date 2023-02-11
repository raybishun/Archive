# Searching and Extracting Data from Files and Archiving

## Archiving Files
```
.tar
.zip

GZIP (.gz) - gunzip
BZIP2 (.bz2) - bunzip2
XZ (.xz) - unxz
```

## Data Search and Extraction using GREP
```
man grep

nano fruitstand.txt
    Fred apples 20
    Suzie oranges 5
    Mark watermellons 12
    Robert pears 4
    Terry oranges 9
    Lisa peaches 7
    Tim oranges 12
    Matt grapes 25
    Anne mangoes 7
    Greg pineapples 3
    Oliver rockmellons 2
    Betty limes 14

grep 'mellon' fruitstand.txt
    Mark watermellons 12
    Oliver rockmellons 2

grep -n 'mellon' fruitstand.txt
    3:Mark watermellons 12
    11:Oliver rockmellons 2

grep -E '[aeiou]{2,}' fruitstand.txt
    Suzie oranges 5
    Robert pears 4
    Lisa peaches 7
    Anne mangoes 7
    Greg pineapples 3

grep -E '2.+' fruitstand.txt
    Fred apples 20
    Matt grapes 25

grep -E '2$' fruitstand.txt
    Mark watermellons 12
    Tim oranges 12
    Oliver rockmellons 2

grep -E 'is|go|or' fruitstand.txt
    Suzie oranges 5
    Terry oranges 9
    Lisa peaches 7
    Tim oranges 12
    Anne mangoes 7

grep -E '^A-L' fruitstand.txt
    Fred apples 20
    Lisa peaches 7
    Anne mangoes 7
    Greg pineapples 3
    Betty limes 14

grep -E '^[^A-L]' fruitstand.txt
    Returns all names that don't start with a letter between A-L
```