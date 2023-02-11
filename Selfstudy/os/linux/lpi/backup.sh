#!/bin/bash
# Purpose: Backup files...
# Author: Ray
# Date: 03/24/2022

mkdir $1_$2
cp -R $1 $1_$2
echo Backup of $1 is complete.

# ./backup.sh testproject 03-24-22