# Account and Groups

## Accounts
```
cat /etc/passwd (accounts)
    ...
    ray:x:1000:1000:ray,,,:/home/ray:/bin/bash

sudo cat /etc/shadow (passwords; uses salted hash)
    ...
```

## Groups
```
cat /etc/group | grep ray
    adm:x:4:syslog,ray
    cdrom:x:24:ray
    sudo:x:27:ray
    dip:x:30:ray
    plugdev:x:46:ray
    lpadmin:x:120:ray
    lxd:x:132:ray
    ray:x:1000:
    sambashare:x:133:ray
```

## User Account Tools
```
whoami
    ray
id
    uid=1000(ray) gid=1000(ray) groups=1000(ray),4(adm),24(cdrom),27(sudo),30(dip),46(plugdev),120(lpadmin),132(lxd),133(sambashare)

who (system uptime/load average/who's logged in/what they're running)
    ray :0      2022-03-25 17:49 (:0)            <--local
    ray pts/1   2022-03-25 19:07 (192.168.0.107) <--remote

w
    2:47:40 up  4:57,  2 users,  load average: 0.00, 0.00, 0.00
    USER     TTY      FROM             LOGIN@   IDLE   JCPU   PCPU WHAT
    ray      :0       :0               17:49   ?xdm?   2:40   0.01s /usr/lib/gdm3/gdm-x-session --run-script env GNOME_SHELL
    ray      pts/1    192.168.0.107    19:07    1.00s  0.14s  0.01s w
```

## Creating accounts via the shell
```
sudo adduser jason
    And complete the user info prompts...

grep '^jason' /etc/passwd
    jason:x:1001:1001:Jason Parker,13,555-123-456,555-123-4567,Jason is the Linux Admin:/home/jason:/bin/bash

grep '^jason' -nu /etc/passwd
    49:jason:x:1001:1001:Jason Parker,13,555-123-456,555-123-4567,Jason is the Linux Admin:/home/jason:/bin/bash

sudo useradd -s /bin/bash -d /home/bruce -m -G jason bruce
sudo passwd bruce

grep '^bruce' -nu /etc/passwd
    51:bruce:x:1003:1003::/home/bruce:/bin/bash

man adduser
```

## Modifying and Deleting Accounts
```
sudo passwd -S jason        (report password status on the named account)
    jason P 03/26/2022 0 99999 7 -1

sudo chage -l jason
    Last password change                                    : Mar 26, 2022
    Password expires                                        : never
    Password inactive                                       : never
    Account expires                                         : never
    Minimum number of days between password change          : 0
    Maximum number of days between password change          : 99999
    Number of days of warning before password expires       : 7

id jason
    uid=1001(jason) gid=1001(jason) groups=1001(jason)

sudo usermod -l janson jason

id jason
    id: ‘jason’: no such user

id janson
    uid=1001(janson) gid=1001(jason) groups=1001(jason)

ls -ld /home/jason
    drwxr-xr-x 2 janson jason 4096 Mar 25 22:51 /home/jason

id jason
    id: ‘jason’: no such user

sudo groupmod -n janson jason

id janson
    uid=1001(janson) gid=1001(janson) groups=1001(janson)

sudo deluser --remove-home janson
    Looking for files to backup/remove ...
    Removing files ...
    Removing user `janson' ...
    userdel: group janson not removed because it has other members.
    Done.

sudo userdel -r bruce
    userdel: bruce mail spool (/var/mail/bruce) not found

id bruce
    
id: ‘bruce’: no such user

tail -15 /var/log/auth.log

grep -E 'userdel' /var/log/auth.log

```

## Managing Groups
```
sudo useradd -m tim -p <password>

id tim
    uid=1003(tim) gid=1003(tim) groups=1003(tim)

sudo groupadd students

sudo groupadd teachers

sudo groupadd admin

sudo usermod -a -G admin tim

sudo usermod -a -G teachers ray

grep admin /etc/group
    lpadmin:x:120:ray
    admin:x:1006:tim

grep teachers /etc/group
    teachers:x:1005:ray

cat /etc/group | more

man groupmod

sudo groupmod -n Staff admin

cat /etc/group 
```

## Root
```
su <username>
su <none> - root is default
```