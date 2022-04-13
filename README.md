# QuickFix (WIP)
QuickFix (working title) is an easy troubleshooter for Windows-based bugs and glitches.

## The files contained here do not represent the final product. Proceed with caution, always check the source. I cannot confirm whether any forks or branches of this project are safe.

Please note that this is Staging, my entire working directory is just dumped to this branch. You can find the solution to the project [here](https://github.com/retr0gr4d3/QuickFix/blob/staging/Project_QuickFix.sln), I will also be uploading the built application made before upload. 

This project uses the CMD utility to "shortcut" the process of manual problem solving in Windows. It is intended to help users who do not know how to fix certain issues in Windows from audio bugs to networking issues and freeing storage space by properly emptying temp folders and directories.

This tool will evolve and take better shape as I continue the journey into C# and .NET.

---

Currently planned implementations are:
 - ~~One-click Networking Reset (QuickerFix - basic)~~
 - ~~One-click Networking Reset (QuickFix - the whole kit and kaboodle)~~
 - About section (Explanation of tools, intended use, etc)

Planned, but might not be possible for a while:
 - One-click TEMP directory deletions for the main culprit locations.
 - One-click restart for Explorer.exe for issues related to taskbar and desktop functionality.

Planned UI/UX updates:
 - Tidy main UI up
 - Removal of red warning label and its implications.
 - Addition of a "main" main page (move actions behind a selection wall, which doubles up as a confirmation button.)

---
## Feature list (v0.2.0).

The current staging branch has the following functionality enabled:
 - Audio service restart (check [here](https://github.com/retr0gr4d3/QuickFix/issues/) for known issues.)
 - Simple network service restart (using `/release` and `/renew`)
 - Full network service restart (using the above, combined with `/flushdns` `/registerdns` and `winsock reset`.)
 - Two debug buttons. One opens a cmd prompt with text using `/K`, the other uses `/C` which hides the prompt.)
