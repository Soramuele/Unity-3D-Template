
# Unity 3D Template

This is a template for Unity projects made in `Unity 2022.3.61f1`.

This template includes a basic folder structure, assemby definitions, and other basic functions for starting a project.



## Table of Contents

1. [Overview](#overview)
    - [Getting Started](#getting-started)
    - [Template Basics](#template-basics)
1. [Best Practices](#best-practices)
    - [Project Structure](#project-structure)
    - [Coding Standards](#coding-standards)
1. [Features](#features)
    - [Input System](#input-system)
1. [Contributing](#contributing)
1. [License](#license)



## Overview

This repository represents the ideal starting point for Unity projects.

Ideally this template is meant for a 3rd person game but can be modified easily for any type of project.

### Getting Started

It is recommended to fork the repo and create a new project from there. Downloading a zip file will preset the project name as this repo, but can still be changed by renaming the folder.

#### Steps:
- Fork this repo and give it the name you want
- Clone your new repo on your computer
- Make sure `Unity 2022.3.61f1` or higher is installed
- In the Unity Hub click the _Add_ button and navigate to the folder where your project is located
- Open your project
- Enjoy

### Template Basics

Contains the following:

| Name | Description |
| --- | --- |
| [Assembly Definition](https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html) | Organize and optimize script compilation |
| [Cinemachine](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.10/manual/index.html) | Advanced camera system |
| [Input System](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14/manual/index.html) | Flexible, event-driven input handling across devices |
| [TextMeshPro](https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0/manual/index.html) | High-quality text rendering and formatting |
| [Universal RP](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@14.0/manual/index.html) | Efficient rendering pipeline for various platforms |



## Best Practices

### Project Structure

The project is structured and organized to be beneficial and readable for you and your team.

Everything is organized inside the `Asset/_Project` folder, keeping your files well organized. This is mainly done to prevent confusion between folders when importing a package.

Folders are created by type, so it's easy to find any file you need (as long as you keep everything organized).

**Benefits:**
- Files are separated from packages, keeping everything organized
- A consistent project structure aid readability and help recuding time searching for some file
- The project structure has consistency in presentation regardless of team location and language, or individual programmers

### Coding Standards

Coding standards define a programming style and helps you keep everything organized and clean.

This template follows:
- Naming conventions
- Formatting and Indentation
- Use of namespaces
- Comments
- Design Patterns

Writing clean and consistent code give benefits after just a short amount of work. This helps with implementation of new features, maintainance, minimalizing the amount of work when debugging and gives a clean communication between different programmers.

> [!TIP]
> It's recommended to use assembly definition to limit compiling time and disambiguation between scripts with the same name.



## Features

Here are more information about the features this template offers. Follow those guidelines if you want to understand better how the project works and how to modify it.

### Input System

This project offers a scalable input handler, implementing the **action map** interfaces. It's not versatile like the `PlayerInput` component but gives you better control over your input events, and with ScriptableObject it allows you to connect your inputs with every system that need them.

> [!IMPORTANT]
> This input system doesn't have integrated controls for UI as it's outside the scope and Unity still offers default InputAction for UI

**How it works**

- It reads callbacks from the _InputActionAsset_ script and fires an event based on your input
```
    // Player Events
    public UnityAction<Vector2> MovementEvent;
    public UnityAction JumpEvent;
    public UnityAction SprintEvent;
    public UnityAction SprintCancelledEvent;
    public UnityAction InteractionEvent;
    public UnityAction<Vector2> LookEvent;
    public UnityAction PauseEvent;
```
- `InputHandler` handles your _InputAction_ events and is a ScriptableObject, so it can easly connect with other scripts that needs input
```
    [SerializeField] Inputs.InputHandler inputHandler;
```
- Contains functions to change `Action Map`, enabling only the required action map
```
    SetGameplay() { ... }
    SetUI() { ... }
```

> [!NOTE]
> Note that unlike the `PlayerInput`component, this one doesn't have a way to recognize when changing input controls during gameplay (yet)



## Contributing

Contributions are always welcome!

See `contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.



## License

[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

Provided as-is under [MIT Licence](https://choosealicense.com/licenses/mit/)

