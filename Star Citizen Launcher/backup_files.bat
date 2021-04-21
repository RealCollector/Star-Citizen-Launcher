@ECHO OFF

for /f "delims=" %%x in (%~dp0/config.txt) do (set "%%x")

echo "Star Citizen path: %star_citizen_path%"
echo "Backup path: %backup_config_path%"

mkdir "%backup_config_path%\Controls\Mappings\"

echo "Copying over control mappings"
copy /y "%star_citizen_path%\LIVE\USER\Client\0\Controls\Mappings\*.*" "%backup_config_path%\Controls\Mappings\*.*"
copy /y "%star_citizen_path%\LIVE\USER\Controls\Mappings\*.*" "%backup_config_path%\Controls\Mappings\*.*"

:: exit
