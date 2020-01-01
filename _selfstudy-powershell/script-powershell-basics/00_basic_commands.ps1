# basic commands
clear

help about*

dir variable: # global variables

dir function: # function drive

. .\06_functions.ps1 # loads a function into the function drive/shell, aka 'dot source a function'

#del function:\Get-DJOSInfo # delete a function from the function drive

Get-Process | Get-Member

Get-Command -noun psbreakpoint

help psbreakpoint

$PSVersionTable.PSVersion

cd $pshome = PS C:\Windows\System32\WindowsPowerShell\v1.0>

# open one of the custom ps1xml files to display how views are configured
# ps1xml view are used to format output, i.e. tables in the cmd prompt
notepad .\DotNetTypes.format.ps1xml # (under $pshome)
# Update-FormatData # used to tell PS to use your view
# Update-FormatData -AppendPath # add to existing view
# Update-FormatData -PrependPath # add your custom view first

# i.e.: Update-FormatData -AppendPath .\myView.format.ps1xml
# Get-DJOSInfo -computerName localhost

Get-Content Env:\PSModulePath

Get-Module -ListAvailable

# What is the difference between 'myError' and $myError?
    # myError is the name of the variable
    # $myError is the 'value' stored within the variable

# What is the debug prompt?
    # >>
    # enter via a breakpoint, or the -debug parameter
    
help gwmi
Get-Content C:\temp\errors.txt
Get-Host
Get-Content computers.txt
Get-WmiObject -class Win32_bios -ComputerName localhost
$ErrorActionPreference # default is to Continue if an error is encountered
$ErrorActionPreference = 'SilentlyContinue' # set to not show error message
$ErrorActionPreference = 'Continue' # set back to show error message
$ErrorActionPreference = 'stop' 