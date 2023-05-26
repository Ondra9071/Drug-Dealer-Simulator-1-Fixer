![Banner](https://i.imgur.com/puH6JNQ.jpg)
[![Download](https://img.shields.io/badge/Download-Now-Green?style=for-the-badge)](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/releases/download/1.0/DDS.Fixer.zip)
[![Downloads](https://img.shields.io/github/downloads/Ondra9071/CustomRPC/total?label=Downloads&style=for-the-badge)](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/releases/latest)
[![Stars](https://img.shields.io/github/stars/Ondra9071/CustomRPC?label=Stars&style=for-the-badge)](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/stargazers)
[![Forks](https://img.shields.io/github/forks/Ondra9071/CustomRPC?label=Forks&style=for-the-badge)](https://github.com/extatent/Ondra9071/Drug-Dealer-Simulator-1-Fixer/network/members)
# Drug Dealer-Simulator 1 Fixer
Edits Enviroment variable to fix the game crashing on start. Windows Only.

# How to fix the game
To fix the game, just download [this .zip file](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/releases/download/1.0/DDS.Fixer.zip), open **DDS Fixer.exe**, and you're done. If you get this message, it worked.
![Success image preview](https://i.imgur.com/hIH88hG.png)

# How it works?
The game has had a bug for a long time that hasn't been fixed until now. Specifically, there is an entry missing in Enviroment Variables that is causing the game to not turn on. This program adds the missing variable.

# How to fix the problem manually?
If you don't trust this program, you can fix the game manually. To do it, I recommend watching [this](https://www.youtube.com/watch?v=Lul7DZcbB9A) video.
But if you know, what you're doing, make this new **System Enviroment Variable**:
```
OPENSSL_ia32cap
~0x200000200000000
```
# Problems and Bugs
Here are the problems and bugs that I plan to address in the future. If you fixed them, please do not hesitate to send me a pull request, and I would be very grateful. Please also report problems and bugs in [GitHub Issues](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/issues).

# Policy for Open Source Contribution
I welcome and appreciate contributions in fixing bugs and enhancing features. However, please avoid submitting pull requests (PRs) that modify the template's existing design without discussing them with me. Please do not submit PRs that are not related to bug fixes or feature enhancements. Editing text in the README file is not encouraged (e.g., fixing grammar errors). PRs with unnecessary editing (e.g., adding unrelated text, changing the design of the template, modifying the README text arbitrarily) or unrelated changes (e.g., changes that are related to only their applications) will be marked as "spam" and "invalid".

If you are excited to contribute to the new features directly, please explain your design decisions and how your design matches this template's style in the PR. If you fix bugs, please explain which bug you fixed and how you fixed them. The explanations that you put in each PR can greatly help me determine if the changes can be merged into the master branch. PRs with no explanations will highly likely be rejected and marked as "wontfix".
