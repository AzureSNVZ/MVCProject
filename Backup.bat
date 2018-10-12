$x="D:\Backup"
$Z=Test-Path $x
$dts="D:\Backup\Publish$((Get-Date).ToString('yyyy-MM-dd'))"

if ($Z -ne $true){New-Item -ItemType Directory  -Path "D:\Backup"

}

New-Item -ItemType Directory -Path "D:\Backup\Publish$((Get-Date).ToString('yyyy-MM-dd'))"
Copy-Item 'C:\inetpub\wwwroot\MVCJenkins' -Destination $dts -Force -Recurse -Verbose
