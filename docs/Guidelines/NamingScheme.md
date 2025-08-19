# Naming Scheme

Inspired by Unreal Engine's Naming Scheme

## Folders

| Type            | Convention | Info     |
| --------------- | ---------- | -------- |
| Directory Names | PascalCase | MyFolder |

## Files

| Type               | Convention     | Prefix | Suffix | Example                       | Note                                                  |
| ------------------ | -------------- | ------ | ------ | ----------------------------- | ----------------------------------------------------- |
| GD Script          | snake_case     |        |        | my_script.gd                  |                                                       |
| C# Script          | PascalCase     |        |        | MyScript.cs                   |                                                       |
| (C++) Header       | PascalCase     |        |        | MyScript.h                    |                                                       |
| C++ File           | PascalCase     |        |        | MyScript.cpp                  |                                                       |
| Textures           | T_PascalCase   | T\_    |        | T_Texture.{png,tga}           |                                                       |
| Texture Variations | T_PascalCase   |        | \_01-󰛤 | T_Texture_01.{png,tga}        | This is suffixed before any other suffix like: \_01_N |
| Normal Textures    | T_PascalCase_N | T\_    | \_N    | T_Texture_N.{png,tga}         |                                                       |
| Mesh               | M_PascalCase   | M\_    |        | M_Mesh.fbx                    |                                                       |
| Material           | PascalCase_M   |        | \_M    | Material_M.{png,tga}          |                                                       |
| Sound              | S_PascalCase   | S\_    |        | S_MySound.{ogg,mid}           |                                                       |
| Video              | V_PascalCase   | V\_    |        | V_MyVideo.webm                |                                                       |
| Font               | F_PascalCase   | F\_    |        | F_MyFont.{ttf,otf,woff,woff2} |                                                       |

## GDScript Specific

## C# Specific

| Type              | Prefix        | Suffix | Example        | Note                      |
| ----------------- | ------------- | ------ | -------------- | ------------------------- |
| Interfaces        | I             |        | IMyInterface   |                           |
| Enumerators       | E             |        | EMyEnum        |                           |
| Public Variables  | PascalCase    |        | MyPublicVar    |                           |
| Private Variables | \_camelCase   |        | \_myPrivateVar |                           |
| Constant          | CONSTANT_CASE |        | MY_CONSTANT    |                           |
| Booleans          | isPascalCase  |        | isDoorOpenned  | Question-like, past tense |

## C++ Specific

WIP
