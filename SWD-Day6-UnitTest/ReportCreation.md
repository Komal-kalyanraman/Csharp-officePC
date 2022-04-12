

Coverage report generation setup MS document
"https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=linux"


Step 1:
Running " dotnet test --collect:"XPlat Code Coverage" "

C:\Users\koy5cob\Desktop\PE-SWD\swd-day6\SWD-Day6> dotnet test --collect:"XPlat Code Coverage"

Step 2:
Running "reportgenerator -reports:"C:\Users\koy5cob\Desktop\PE-SWD\swd-day6\SWD-Day6-UnitTest\TestResults\35843450-7652-4235-90f6-d772b05590fa\coverage.cobertura.xml" -targetdir:"CoverageReport" -reporttypes:Html"
C:\Users\koy5cob\Desktop\PE-SWD\swd-day6\SWD-Day6> reportgenerator -reports:"C:\Users\koy5cob\Desktop\PE-SWD\swd-day6\SWD-Day6-UnitTest\TestResults\35843450-7652-4235-90f6-d772b05590fa\coverage.cobertura.xml" -targetdir:"CoverageReport" -reporttypes:Html

NOTE: Make sure the test result location is correct in the command