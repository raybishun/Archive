# =============================================================================
# Purpose: Delete local folder from Windows OS 
# Created: Sunday, July 15, 2018
# Author: Ray Bishun
# Modified: Saturday, July 21, 2018
# =============================================================================
$logFile = $env:TEMP + '\Remove-Folder-RB-071518.log'

$targetFolder1 = ${env:ProgramFiles(x86)} + '\app\archive'
$targetFolder2 = 'C:\Temp\archive'

function Get-TimeStamp
{
    return "[{0:MM/dd/yy} {0:HH:mm:ss}]" -f (Get-Date) 
}

function Remove-Folder-RB-071518 
{
<#
.SYNOPSIS
Deletes local archive store folder from Windows endpoint 
.DESCRIPTION
Removes the local archive store folder from Windows endpoints
.PARAMETER path
The folder that will be removed
.EXAMPLE
Remove-Folder-RB-071518 "c:\test\archive" -Recurse
#>
    [CmdletBinding(SupportsShouldProcess=$true)]
    param(
        [Parameter(
            Mandatory=$true,
            ValueFromPipeline=$true,
            ValueFromPipelineByPropertyName=$true
        )]
        [String[]]
        $Path ,

        [Switch]
        $Recurse
    )
    Process 
    {
        foreach($path in $Path) 
        {
            if(Test-Path $path) 
            {
                try
                {
                    # Remove-Item $path -Recurse:$Recurse -WhatIf:$WhatIfPreference
                    Remove-Item -ErrorVariable ev -ErrorAction 'Stop' $path -Recurse:$Recurse -WhatIf:$WhatIfPreference
                    Write-Output "$(Get-TimeStamp) Removed $path." | out-file -append $logFile
                } 
                catch 
                {
                    Write-Output "$(Get-TimeStamp) $ev" | out-file -append $logFile
                }
            }
            else
            {
                Write-Output "$(Get-TimeStamp) $path not found." | out-file -append $logFile
            }
        }
    }
}

Remove-Folder-RB-071518 $targetFolder1, $targetFolder2 -Recurse

# Test from ISE
# -------------------------------------------------------------------------------
#Remove-Folder-RB-071518 $targetFolder -Recurse -WhatIf

# Test from PS CMD prompt
# -------------------------------------------------------------------------------
#. .\remove_files.ps1
#dir Function: | findstr Remove-Folder-RB-071518
#help Remove-Folder-RB-071518
#help Remove-Folder-RB-071518 -Examples
#Remove-Archive-RB-071518 "c:\test\archive" -Recurse -WhatIf
#Remove-Archive-RB-071518 "c:\test\archive" -Recurse
#del function:\Remove-Folder-RB-071518
#dir Function: | findstr Remove-Folder-RB-071518