::The declaration of variable below woulb be a local
SETLOCAL
::SET v=Local Value
::ECHO v=%v%

::This life example for using local variable
::Run this .cmd in the other cmd.exe and try print %PATH% first
SET PATH=%SystemRoot%\system32
ECHO %PATH%