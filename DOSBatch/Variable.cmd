@ECHO OFF
::The value of undeclared/uninitialized variables is an empty string, or "".
::DOS is case insensitive, so this convention isn’t enforced 
::but it’s a good idea to make your script’s easier to read and troubleshoot.

::command SET lists existing variables
SET

::declare a new variable, foo, and assigns value, bar, to it
::Do not use whitespace between the name and value; 
::Ex. SET foo = bar will not work but SET foo=bar will work.
SET foo=bar 
::In most situations you can read the value of a variable by 
::prefixing and postfixing the variable name with the % operator.
ECHO %foo%

::command SET lists existing variables
SET

::The /A switch supports arthimetic operations during assigments.
SET /A foo=2*4 
ECHO %foo%

SET foo=2*4
ECHO %foo%
::These dynamic varibles include %DATE%, %RANDOM%, and %CD%. 
::It would be a bad idea to overwrite these dynamic variables.
ECHO
ECHO %TEMP%

::You can read the command line arguments passed to your script using a special syntax. 
::The syntax is a single % character followed by the ordinal position of the argument 
::from 0 – 9.
ECHO
ECHO %0

PAUSE

