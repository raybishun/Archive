for($i = 1; $i -le 10; $i++)
{
    Write-Host $i;
}



$i = 0;
Do{
    $i++;
    Write-Host $i;
}while($i -ne 10)



$days = ("Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun")

foreach($day in $days)
{
    Write-Host $day
}



$files = @(Get-ChildItem C:\Temp\)
foreach($file in $files)
{
    Write-Host $file;
}