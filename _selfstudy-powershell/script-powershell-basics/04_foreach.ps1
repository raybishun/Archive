# foreach (iterating through a collection)
clear

# PS cmdline option
# Get-Service | select -Property name

$services = Get-Service

foreach($service in $services){
    Write-Host "$($service.name)"
}

