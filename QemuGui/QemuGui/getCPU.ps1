$ex = 'qemu-system-x86_64.exe -cpu help';

$f = $false;
$(Invoke-Expression $ex) -split '\r?\n' | Select-Object -Skip 1 | ForEach-Object {
    if ($_ -match 'Recognized CPUID flags:') {
        $f = $true;
    }
    if ($f -eq $false -and $_ -match '^\s*(?<Name>[A-Za-z0-9-]+)\s+(?<Desc>(?:\(.+?\)|[^\n]+))$') {
        Write-Host $Matches['Name']','$Matches['Desc'];
    }
}