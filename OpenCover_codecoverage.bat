"HelloByErik\packages\OpenCover.4.5.3207\OpenCover.Console.exe" -target:runtests.bat -register:user
move results.xml Testresults\results.xml
"HelloByErik\packages\ReportGenerator.2.0.1.0\ReportGenerator.exe" -reports:TestResults\results.xml -targetdir:TestResults\coverage
