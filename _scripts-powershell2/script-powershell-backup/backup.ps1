Clear-Host
Set-Location "C:\Temp"

$src  = "C:\src\*"
$dsts = @("C:\dst1", "C:\dst2")

foreach($dst in $dsts)
{
    if(!(Test-Path -Path $dst))
    {
        New-Item $dst -Type Directory
    }

    Copy-Item $src -Destination $dst -Recurse -Force -Verbose
}

Write-Host "Done"


<#

#Copy-Item -Path $src -Destination $dst -Recurse -Force

<#
$policy = "RemoteSigned"
if((Get-ExecutionPolicy) -ne $policy)
{
    Set-ExecutionPolicy $policy -Force
    Exit
}
#>

<#
$policy = "Restricted"
if((Get-ExecutionPolicy) -eq $policy)
{
    Write-Host "exiting..."
    Exit
}
#>