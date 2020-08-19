# TextAdventure.NET

This is supposed to be a framework for quickly and easily creating terminal-based adventure games with .NET.

## How it works

```c#
var gameBuilder = new GameBuilder();

gameBuilder.AddScene<StartScene>();
gameBuilder.AddScene<EndScene>();

var game = gameBuilder.Build("Hello World Game");

game.Launch();
```

For documentation and a getting started guide, please check out the [wiki](https://github.com/InDieTasten/TextAdventure.NET/wiki).

## Planned features include

- Scenes and transitions
- Requirement-based navigation
- History
- Save games
- Inventory
- Main Menu
- Text Templating
- Localization
- Extensible APIs for custom
  - Output/Rendering
  - Parsing/Input
  - Actions
  - Navigation requirements
  - Game flow
