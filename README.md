![Banner](https://i.imgur.com/puH6JNQ.jpg)
[![Download](https://img.shields.io/badge/Download-Now-Green?style=for-the-badge)](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/releases/download/1.0/DDS.Fixer.zip)
[![Downloads](https://img.shields.io/github/downloads/Ondra9071/CustomRPC/total?label=Downloads&style=for-the-badge)](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/releases/latest)
[![Stars](https://img.shields.io/github/stars/Ondra9071/CustomRPC?label=Stars&style=for-the-badge)](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/stargazers)
[![Forks](https://img.shields.io/github/forks/Ondra9071/CustomRPC?label=Forks&style=for-the-badge)](https://github.com/extatent/Ondra9071/Drug-Dealer-Simulator-1-Fixer/network/members)
# Drug Dealer-Simulator 1 Fixer
Edits Enviroment variable to fix the game crashing on start. Windows Only.

# How to fix the game
To fix the game, just download [this .zip file](https://github.com/Ondra9071/Drug-Dealer-Simulator-1-Fixer/releases/download/latest/DDS.Fixer.zip), open **DDS Fixer.exe**, and you're done. If you get this message, it worked.
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
