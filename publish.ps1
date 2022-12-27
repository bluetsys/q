Get-Content .\RuntimeIdentifiers.txt | % {
	write-host $_
    if($_ -match $regex){
		  dotnet publish -c Release -r $_ -p:PublishTrimmed=true -p:PublishSingleFile=true -p:ReadyToRun=true -p:selfcontained=true
    }
}
