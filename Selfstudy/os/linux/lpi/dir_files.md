# Directories and Files

## FHS
* FileSystem Hierarchy Standard.
* Distinguishes between sharable/unsharable files, as well as static/variable files.

## Directory Structure
```
\ <-- root directory
    \bin
    \sbin
    \dev
    \etc
    \home
    \root
```

## Home
```
cd ~
pwd
    /home/ray
```

## File and Directory Naming
* Unlike Windows, these are 3 different files: `test.txt`, `TeST.txt`, `Test.txt`

## File References
1. Absolute
2. Home Directory
3. Relative

### Absolute
* References that are relative to the root dir
* Always begin with a /
* I.e., /home/user1/file.txt

### Home Directory
```
~
```

### Relative
```
. this directory
.. parent directory
```

## File Creation/Management
```
touch my_empty_file.txt
cp - copy files
mv - move/rename files
```

## Links
1. Hard links - a dup dir entry where both entries point to the same file.
```
ln original_name link_name
```
2. Symbolic links - a file that refers to another file by name.
```
ln -s original_name link_name
```

## Wildcards 
```
?? - b??l       = bowl, ball, bull
*  - b*l        = bowl, ball, bull, bl, bbll, brawl
[] - b[ao][lw]l = bowl, ball

ls b??l
```

## Case Sensitivity
* Unlike Windows, Linux is case sensitive (files and folders)
* Case sensitivity is a function of the Linux filesystem (not the OS)


## Manipulating Directories
* On Linux, dir are really files that hold other files.
```
mkdir
rmdir       (the dir must be empty)
rmdir -p    (delete empty sub-dir)
rm -r       (will remove dir even if they contain files)
```

## Exercise
```
touch bale.txt; touch ball.txt
touch bowl.txt; touch bull.txt
mkdir Folder1; mkdir Folder2

mv bull.txt Folder2/bull.txt
mv bowl.txt Folder2/bowl.txt

mv *.txt Folder1

touch .balehidden.txt

mv .balehidden.txt Folder1

mv ba??.txt Folder1

cd ~/Documents/Folder1

mv ../Folder2/b??l.txt
    bale.txt
    ball.txt
    bowl.txt
    bull.txt

ls -la b[ao][wl]l.txt
    ball.txt
    bowl.txt

mkdir Folder3
mv Folder3 Ray (rename Folder3 to Ray)
rm Ray

man rm

rm -r Folder1
```