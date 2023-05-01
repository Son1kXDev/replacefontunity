# Replace Font Plugin

This plugin allows you to replace the font in Text and TextMeshProUGUI components in your project, scene or prefab with a single font.

## Installation

To install the plugin, simply download and import the ReplaceFont.unitypackage into your project.

## Usage

The plugin provides several methods to replace the font in your project:

### Replace Font in Scene

This method replaces the font in all Text and TextMeshProUGUI components in the current scene.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. Once you have selected the font, click the "Replace Font in Scene" button.

### Replace Font in Prefab

This method replaces the font in all Text and TextMeshProUGUI components in all prefabs in your project.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. Once you have selected the font, click the "Replace Font in Prefab" button.

### Replace Font in Project

This method replaces the font in all Text and TextMeshProUGUI components in all scenes and prefabs in your project.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. Once you have selected the font, click the "Replace Font in Project" button.

## Notes

- This plugin only replaces the font in Text and TextMeshProUGUI components. It does not replace the font in other components that use fonts, such as SpriteText.
- This plugin does not create a backup of your project before making changes. Please make sure to back up your project before using this plugin.
- This plugin does not support undo/redo. Once you have replaced the font, the changes cannot be undone.
- This plugin does not support multiple fonts. You can only replace all Text and TextMeshProUGUI components with a single font at a time.
