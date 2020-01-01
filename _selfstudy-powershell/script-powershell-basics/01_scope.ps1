# scope
clear

# showing scope
write-host "Try 1: $test"
$test = 100
write-host "Try 2: $test"

$global:test2 = 100
write-host "Try3: $test2"

function mine {

}
