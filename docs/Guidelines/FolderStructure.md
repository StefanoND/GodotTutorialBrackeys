# Folder Structure

Inspired by:

[Shantnu Tiwari](https://new.pythonforengineers.com/author/shantnu/)'s [How to structure your godot project so you don't get confused](https://new.pythonforengineers.com/blog/how-to-structure-your-godot-project-so-you-dont-get-confused/)
[Josh Anthony](https://joshanthony.info/)'s [How I structure my game projects](https://joshanthony.info/2021/12/06/how-i-structure-my-game-projects/)

## Folder structure example

| Type                                   | Convention | Info                      |
| -------------------------------------- | ---------- | ------------------------- |
| Directory Names                        | PascalCase | MyFolder                  |
| addons Directory Name                  | N/A        | addons                    |
| src Directory Name                     | N/A        | src                       |
| docs Directory Name                    | N/A        | docs                      |
| Test, Debug and Sample Directory Names | N/A        | \_test, \_debug, \_sample |

All folders are PascalCase
The only exceptions are:

- src and docs folders (which must be like shown here)
- \_test, \_debug and \_sample (which must be like shown here)

Leave auto-generated folders and files as-is

    /ProjectGenesis
    │
    ├─ docs/                        # Internal documentation
    ├─ Project/                     # Actual Godot Project
    │  │
    │  ├─ \_debug/                  # Debug Helper (Hand-made in-game debugger)
    │  ├─ \_tests/                  # Tests (unit, integration)
    │  ├─ \_sample/                 # Samples (System with their defaults for behavior check)
    │  ├─ addons/                   # Plugins/3rd-Party Content. All lower case
    │  ├─ Assets/                   # Resources to be used in the game
    │  │  ├─ 2D/                    # Art assets for 2D games
    │  │  │  └─ Sprites/            # Sprites
    │  │  ├─ 3D/                    # Art assets for 3D games
    │  │  │  ├─ Materials/          # Materials
    │  │  │  ├─ Models/             # 3D Models
    │  │  │  └─ Textures/           # Textures
    │  │  ├─ Animations/            # Animations in game
    │  │  ├─ Audio/                 # Audios for the game
    │  │  │  ├─ Sound/              # Sounds, effects, etc
    │  │  │  ├─ Voice/              # Voice acted audios
    │  │  │  └─ Music/              # Background music, game music, etc
    │  │  ├─ Effects/               # VFX
    │  │  ├─ Fonts/                 # Fonts used in the game
    │  │  ├─ Videos/                # In-Game Videos, Cutscenes, etc
    │  │  └─ .../                   # Materials, 3D Models, Sprites, Videos, etc
    │  ├─ Bridges/                  # Connectors of systems
    │  ├─ Config/                   # Exposed configuration from systems
    │  ├─ Core/                     # Generalized and Reusable systems, etc
    │  ├─ GameObjects/              # Everything that will be in the game
    │  │  ├─ AI/                    # AI for the game (behavior/state tree)
    │  │  ├─ Camera/                # Various cameras for the game
    │  │  └─ Entities/              # Objects that are rendered and seen in-game
    │  │     ├─ Characters/         # Objects that represent "live" beings
    │  │     │  ├─ NPCs/            # Non Playable Characters
    │  │     │  │  ├─ Companion/    # NPCs that helps the player
    │  │     │  │  ├─ Hostile/      # Hostile NPCs
    │  │     │  │  ├─ Neutral/      # Neutral/Friendly NPCs
    │  │     │  │  ├─ Quest/        # NPCs that gives quests
    │  │     │  │  └─ Special/      # Important NPCs
    │  │     │  └─ Player/          # Player Character
    │  │     ├─ Collectables/       # Objects that are collectable
    │  │     ├─ Consumables/        # Objects that are consumables
    │  │     └─ Interactables/      # Objects that are interactable
    │  ├─ GameWorld/                # Levels, maps, areas, etc that will be in the game
    │  ├─ Helpers/                  # Libraries with generalized helper codes
    │  ├─ Screens/                  # Finalized Scenes that will be seen by the player
    │  ├─ src/                      # Source code, GD and C# Scripts
    │  │  ├─ Consumables/
    │  │  ├─ Characters/
    │  │  │  └─ Player/
    │  │  └─ Systems/
    │  │     └─ System1/
    │  ├─ Systems/                  # Systems, features, etc of the game
    │  ├─ UI/                       # Generalized and Specific UIs
    │  ├─ Utils/                    # Dev tools/systems that won't be in the final game
    │  └─ .../                      # Extra folder required for specific needs
    ├─ .env                         # Environment variables
    ├─ .gitignore
    ├─ .editorconfig
    ├─ .clang-format / .clang-tidy / .clangd / etc.
    ├─ README.md
    ├─ package.json / pyproject.toml / etc.
    └─ ToImport/                    # Raw "non optimized for game" files

## INIT

Main Scene

## CORE_CONFIG

INIT's script and tells which screen file will be loaded first

## Directory Structure

Each directory have their own README further explaining their purpose.

### \_debug

Isolated system(s) to aid in debugging.

### \_samples

Individual systems at their default state.

### \_tests

Systems, features, functionalities, etc being worked on.

### Addons

3rd-Party content.

### Assets

Resources that are used in the game.

### Bridges

Connects systems together without affecting their reusability/modularity.

### Config

Exposed configurations from systems.

### Core

Generalized and Reusable systems, features, UIs, etc across multiple games.

### docs

Project's Documentations.

### GameObjects

Everything that will be in the game.

### GameWorld

Levels, maps, areas, etc that will be in the game.

### Helpers

Libraries with generalized helper functions, vars, consts, etc.

### Screens

"Finished" games part that will be visualized by the player: Game Screen, Menu
Screen, Loading Screen, etc

### src

Where all scripts in the game are.

Create a folder for each system, feature, etc and keep their Script type
(GDScript or C# Script) per folder.

### Systems

Systems, functionalities, features, etc of the game

### UI

Generalized and Specific UIs

### Utils

Anything that aids/helps with the development, that won't be in the final game.
