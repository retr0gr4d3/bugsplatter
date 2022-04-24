# Patch notes for project bugsplatter.

## Version 0.5.0
`staging-alpha` has become `dontuse-staging-alpha` as it is now deprecated. The name will change to something more graceful in time, but will suffice for now.

The UI has been redesigned to be more tabular rather than having buttons everywhere. It was good for getting the baseline of functionality sorted, but now we can make it more elegant.

Since the entire app has been rewritten, I will use this as an entire changelog since the start of the project:

The way the user interacts with this tool has been redesigned, utilising TabControl rather than having buttons and text everywhere. It is INCREDIBLY more friendly.

 - Introduced a screen for checking the latest release on GitHub.
Note: this screen will not disappear until the user selects either yes or no. And until one of those buttons are pressed, it will not open the main bugsplatter window. Originally this behaviour was unintentional, but it worked out better than expected in the long run, so now it is functionality:tm:.

 - Introduced "About", "Audio", "Networking" and "Debug" as individual tabs.
 Each tab now contains information related to it's usage (except Debug). The about page contains a hint on how to use it, and there is a link to the GitHub project for those who want a sanity check. The Audio tab contains info related to the command it uses, as with networking. They also contain hints on optimal usage, etc.

 - Added new functionality for rebooting directly from the app.
 Certain commands require a reboot, and the app will declare when one is necessary.

 - Separated the networking tool into three segments.
 One button for each stage, essentially. Release and Renew (ipconfig), DNS Flush (and register, ipconfig) and  finally Winsock Reset (netsh), which needs a reboot.

 There is a link to my website now, at the bottom right. That will change to the webpage for the entire "QuickFix" repo.