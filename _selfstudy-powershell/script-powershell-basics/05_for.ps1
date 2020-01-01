# for
clear

# PS cmdline option
0..9 | ForEach-Object {$_}


for([int] $i=0; $i -lt 10; $i++){
    Write-Host $i
}


