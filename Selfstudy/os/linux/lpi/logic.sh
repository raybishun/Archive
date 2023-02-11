#!/bin/bash
# Purpose: ...
# Author: Ray
# Date: 03/24/2022

if [ $# != 1 ]
then
    echo Usage - One int arg required.
    exit
fi

if [ $1 = '1' ]
then
    echo The arg entered was 1
    exit
fi

if [ $1 = '2' ]
then
    echo The arg entered was 2
    exit
else
    echo The arg entered was NOT 2
    exit
fi