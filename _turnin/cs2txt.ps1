Get-ChildItem -Filter "*.cs" | Rename-Item -NewName {$_.name -replace '.cs','.txt'}
