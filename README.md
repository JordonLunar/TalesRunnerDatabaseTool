# TalesRunner Database Tool
An advanced tool coded using VB.NET aimed to help server owners augment their TalesRunner databases remotely.
**PRE-USE SETUP, PLEASE READ** (this setup guide is updated as of version 3.0.0)

1. YOU MUST GO INTO THE VB PROJECT AND CHANGE ALL IP ADDRESSES TO YOUR OWN SERVER IP ADDRESS

2. YOU MUST CREATE A TABLE IN THE DATABASE **'tr_game_db'** CALLED **"tblGMTool"** WITH ROWS CALLED **"fdNick"**, **"fdID"**, **"fdPassword"**, **"fdClearance"**

## 🚀 Features

### User Management
- **Search & View:** Easily find users by nickname and view their account details.
- **Account Creation:** Create new user accounts directly through the tool.
- **Ban/Unban System:** Manage user access with dedicated ban and unban modules.
- **Permission Management:** Manage tool users and access levels.

### Economy & Character Management
- **Currency Editing:** Modify User TR and Cash balances.
- **Experience Management:** Edit user EXP levels.
- **Inventory & Gifts:** 
  - Search for Item IDs.
  - Send gifts directly to users.
  - Manage storage gifts and custom items.

### Server Maintenance & Rankings
- **Rank Updates:** Trigger stored procedures to update:
  - User Ranks
  - Farm Ranks
  - Item Collection Ranks
  - Guild Match Ranks
- **Server Notices:** Send maintenance notices to the server.
- **Piero Customization:** Change Piero colors.

## 🛠️ Technologies Used
- **Language:** VB.NET
- **Framework:** .NET Framework (Windows Forms)
- **Database:** Microsoft SQL Server
- **Dependencies:** 
  - `MySql.Data.dll` (for potential MySQL integration)
  - `INIControl.dll` (for configuration management)
  - `BouncyCastle.Crypto.dll`
  - `Renci.SshNet.dll`

## 📋 Prerequisites
- Windows OS
- .NET Framework 4.5 or higher (depending on the build)
- Access to the TalesRunner SQL Server database (`tr_gamesvr_db`)

## ⚙️ Configuration

The tool uses an INI file for database connectivity. You can configure this through the **Database Info** section in the application or by manually editing `databaseconfig.ini`.

Required database parameters:
- **IP:** Server IP address
- **US:** Database Username (e.g., `sa`)
- **PW:** Database Password
- **DB:** Database Name (default: `tr_gamesvr_db`)

## 📁 Project Structure

- `Full GM Tool.sln`: Visual Studio Solution file.
- `Full GM Tool/`: Main source code directory.
  - `Form1.vb`: Login and main entry point.
  - `Form2.vb`: Primary administration dashboard.
  - `DatabaseInfo.vb`: Database connection settings.
  - `*.Designer.vb`: UI layout definitions.
  - `bin/Debug/`: Contains the compiled executables and dependencies.

---
*Note: This tool is intended for server administrators only. Ensure you have proper backups before performing bulk database operations.*

