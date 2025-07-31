# 🧠 Core Module

This folder contains the core components of the **MegaToolbox** CLI suite. It serves as the central hub for launching and managing all tools in the project.

---

## 📁 Contents

- **Launcher.cs** – Main entry point and CLI menu system.
- **ToolRegistry.cs** – Registers and provides access to all available tools.
- **Interfaces.cs** – Defines shared interfaces like `ITool`.

---

## 🧩 Purpose

The Core module is responsible for:

- Displaying the main menu
- Handling user input
- Launching selected tools
- Managing tool metadata

---

## 🛠️ How It Works

1. Tools implement the `ITool` interface.
2. `ToolRegistry` collects all tools into a list.
3. `Launcher` displays the list and runs the selected tool.

---

## 🔄 Extending

To add a new tool:

1. Implement `ITool` in the `/Tools` folder.
2. Add it to the list in `ToolRegistry.cs`.
