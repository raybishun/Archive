# if-elseif-else
clear

[int]$age = Read-Host "Enter your age"

if($age -lt 18){
    Write-Host "You are under 18"
} elseif($age -lt 21){
    Write-Host "You are under 21"
} elseif($age -lt 65){
    Write-Host "You are under 65"
} else {
    Write-Host "You are 65 or older"
}