# Bitbucket Notes

## Create and Clone Repo
```
mkdir bitbucket

cd bitbucket

git clone https://rbishun@bitbucket.org/rbishun/cademo.git
	Bitbucket Cloud recently stopped supporting account passwords for Git authentication.
	See our community post for more details: https://atlassian.community/t5/x/x/ba-p/1948231

https://bitbucket.org/dashboard/overview

Personal settings\App passwords\Create app passwords\Create

Save the password to a secure vault - you will not be able to view it again!

git clone https://rbishun@bitbucket.org/rbishun/cademo.git
	Cloning into 'cademo'...
	remote: Enumerating objects: 3, done.
	remote: Counting objects: 100% (3/3), done.
	remote: Compressing objects: 100% (2/2), done.
	remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
	Unpacking objects: 100% (3/3), 584 bytes | 7.00 KiB/s, done.
```

## Create a Web Page from VS Code
1.  index.html
2. ! and tab (an Emmet Abbreviation)
3. ul>li.items$*10 (use Emmet to add 10 list items)


## Commit and Push
```
git status
	index.html

git add index.html

git status
	 new file:   index.html
	 
git commit -m "commit 1 index.html"

git push
```

## Git Credential Helper
* Used to cache credentials
```
git config --local credential.helper
git config --global credential.helper
git config --system credential.helper
	manager-core
git config --show-origin --get credential.helper
	file:C:/Program Files/Git/etc/gitconfig manager-core

cat "C:/Program files/Git/etc/gitconfig" manager-core
```