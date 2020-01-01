<# 
===============================================================================
Functions
===============================================================================
#>
clear
$DJErrorLogFile = 'c:\errors.txt'

function Get-DJOSInfo
{
    [CmdletBinding(SupportsShouldProcess=$True, ConfirmImpact='Low')] # SupportsShouldProcess supports '-whatif', ConfirmImpact suppports '-confirm'
    param(
        [Parameter(Mandatory=$True,
                    ValueFromPipeline=$True,
                    ValueFromPipelineByPropertyName=$True)]
        [Alias('hostname')]
        [ValidateLength(5, 20)] # computer name must be between 5 and 20 chars
        [ValidateCount(1, 10)]  # input (computer names) must be between 1 and 10
        [string[]]$computerName, 

        [switch]$nameLog
    )
    BEGIN 
    {
        Write-Debug "Started BEGIN block"
        
        if($nameLog)
        {
            Write-Verbose "Finding name log file"
            $i = 0
            Do 
            {
                $logFile = "names-$i.txt"
                $i++
            } while(Test-Path $logFile)
            Write-Verbose "Log file name will be $logFile"
        } 
        else 
        {
            Write-Verbose "Name log off"
        }

        Write-Debug "Finished setting name log" # Write-Debug only shows when -debug switch used
    }
    PROCESS 
    {
        
        Write-Debug "Starting the PROCESS..."

        # $ErrorActionPreference = 'SilentlyContinue' # don't show error message, just continue (*** this is a bad idea)

        foreach ($computer in $computername)
        {
            if($pscmdlet.ShouldProcess($computer))
            {

                #Write-Host $computer
            
                Write-Debug "Starting to connect to a computer..."

                Write-Verbose "Now connecting to $computer"
            
                if($nameLog)
                {
                    $computer | Out-File $logFile -append
                }

                try
                {
                    $continue = $true
                    $os = Get-WmiObject -ErrorVariable myErr -ErrorAction 'Stop' -computerName $computer -class Win32_OperatingSystem | 
                        Select Caption, BuildNumber, OSArchitecture, ServicePackMajorVersion
                } 
                catch 
                {
                    Write-Verbose "Connection to $computer failed"
                    $continue = $false
                    $computer | out-file $DJErrorLogFile
                    $myErr | out-file c:\temp\errormessages.txt
                }

                if($continue)
                {
                    Write-Verbose "Connection to $computer succeeded"

                    $bios = Get-WmiObject -computerName $computer -class Win32_BIOS | 
                        Select SerialNumber
                    $processor = Get-WmiObject -computerName $computer -class Win32_Processor | 
                        Select AddressWidth -first 1
            
                    Write-Debug "Finished querying, ready to create output" 
            
                    # Replace the '-bit' in '64-bit'
                    $Formated_OSArchitecture = $os.OSArchitecture -replace '-bit',''

                    # Create a hash table
                    $properties = @{'ComputerName'=$computer;
                                    'OSVersion'=$os.Caption;
                                    'OSBuild'=$os.BuildNumber;
                                    'OSArchitecture'=$Formated_OSArchitecture;
                                    'OSSPVersion'=$os.servicepackmajorversion;
                                    'BIOSSerial'=$bios.SerialNumber;
                                    'ProcArchitecture'=$processor.addresswidth}

                    $obj = New-Object -TypeName PSObject -Property $properties
                    $obj.PSObject.TypeNames.Insert(0, 'My.Awesome.InventoryThing')
                }
                Write-Debug "Created output; ready to write to pipeline"
            
                Write-Output $obj
            }
        }
    }
    END {}
}

# =============================================================================
# Tests from within ISE
# =============================================================================
# Get-DJOSInfo -computerName localhost
# Get-DJOSInfo -computerName 127.0.0.1, not-on-line, localhost -verbose -namelog
# Get-DJOSInfo -computerName 127.0.0.1, not-on-line, localhost -verbose
# Get-Content computers.txt | Get-DJOSInfo -nameLog
# Get-DJOSInfo -host localhost

# Import-Module ActiveDirectory
# Get-ADComputer -filter * | Select-Object @{n='ComputerName';e={$_.Name}} | Get-DJOSInfo

# =============================================================================
# Tests from CMD prompt
# =============================================================================
#. .\06_functions.ps1 # loads a function into the function drive/shell
# Get-DJOSInfo -host localhost
# del Function:\Get-DJOSInfo

# =============================================================================
# Tests from CMD prompt
# =============================================================================
# Get-DJOSInfo -computerName localhost -debug -verbose # -debut and -verbose >> debug mode

# Get-DJOSInfo -computerName localhost | Format-Table -Property *
# Get-DJOSInfo -computerName localhost | Format-List -Property *
