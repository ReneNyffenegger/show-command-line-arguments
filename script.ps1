write-host "$($myInvocation.myCommand.path)\$($myInvocation.myCommand.name) has recevied $($args.count) arguments:"

$args | foreach-object {
  "  $_"
}
