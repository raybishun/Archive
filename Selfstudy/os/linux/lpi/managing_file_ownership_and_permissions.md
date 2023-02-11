# Managing File Ownership and Permissions

## Managing File Ownership
```
man chown

man chgrp

mkdir ownership
touch foo1.txt
touch foo2.txt
mkdir foodir

ls -hal
    -rw-rw-r-- 1 ray ray    0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray ray    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray ray 4.0K Mar 26 22:33 foodir

 sudo chown tim foo1.txt

 ls -l
    -rw-rw-r-- 1 tim ray    0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray ray    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray ray 4096 Mar 26 22:33 foodir

sudo chown tim:Staff foo2.txt
    -rw-rw-r-- 1 tim ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 tim Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray ray   4096 Mar 26 22:33 foodir

sudo chown ray:Staff foodir
    -rw-rw-r-- 1 tim ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 tim Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir
```

## Managing File Permissions
- '-' file
- 'd' directory
- 'l' symbolic link
- 'p' named pipe
- 's' socket
- 'b' block device
- 'c' character device
- OWNER permissions - GROUP permissions - OTHER (aka WORLD) permissions
- Permissions: R/W/E
- [-] rwx rwx rwx
- r + w + e  =  4 + 2 + 1 = 7 (octal, base-8)

## Permission Table (example)
|  Permission | 3-Digit Octal | Permission  |
|---|---|---|
| rwx rwx rwx  | 777  | r,w,x for all users  |
| rwx r-x ---  | 750  | r,e for owner and group; owner also has w; other no access  |
| rw- r-- r--  | 644  | r,w for owner; r for all others |
| r-- --- --- | 400 | r for owner, no permission for all others |

## Setting Permissions
```
ls -l
    -rw-rw-r-- 1 tim ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 tim Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir

sudo chown ray foo1.txt
sudo chown ray foo2.txt
    -rw-rw-r-- 1 ray ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir

man chmod

chmod 777 foo1.txt
ls -l
    -rwxrwxrwx 1 ray ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir

chmod 642 foo1.txt
ls -l
    -rw-r---w- 1 ray ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir

chmod 644 foo1.txt
    -rw-r--r-- 1 ray ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir
```

## Sticky Bits
- On Linux, a user can actually `delete` a file without having `write` permission to it - thus the need for `sticky bits`.
- When this special flag is enabled, only the owner of a file can delete it.
- octal 1 = on
- octal 0 = off

## Turn On Sticky Bit
```
chmod 1644 foo1.txt
ls -l
    -rw-r--r-T 1 ray ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir
```

## Turn Off Sticky Bit
```
chmod 0644 foo1.txt
ls -l
    -rw-r--r-- 1 ray ray      0 Mar 26 22:32 foo1.txt
    -rw-rw-r-- 1 ray Staff    0 Mar 26 22:33 foo2.txt
    drwxrwxr-x 2 ray Staff 4096 Mar 26 22:33 foodir
```