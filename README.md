# Replace Font Plugin

This plugin allows you to replace the font in Text and TextMeshProUGUI components in your project, scene or prefab with a single font.

## Installation

To install the plugin, simply download and import the *ReplaceFontTool.unitypackage* into your project.

## Usage

The plugin provides several methods to replace the font in your project:

### Replace the Font in Specific components

This method replaces the font in specific Text or TextMeshProUGUI components.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. First select the font type on `Type` enum. Next select the font you want to use. Click on `Find place` enum and select `Specified`. Add all components where you need to replace the font to `Specified Objects` list. Click the `Replace` button.

![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/0df54a40-0ccf-4db1-8f90-4534d688c3e2)
![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/11e94b46-8b97-4ffb-8929-f7c6c2170a4f)

### Replace Font in Scene

This method replaces the font in all Text or TextMeshProUGUI components in the current scene.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. First select the font type on `Type` enum. Next select the font you want to use. Click on `Find place` enum and select `Current scene`. Click the `Replace` button.

![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/dd9ffbe6-641e-4131-a9b8-0478d1d9df8c)
![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/f27e1efc-4414-40ae-98a1-5dac8f8e688b)

### Replace Font in Prefab

This method replaces the font in all Text or TextMeshProUGUI components in all prefabs in your project.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. First select the font type on `Type` enum. Next select the font you want to use. Click on `Find place` enum and select `Prefabs`. Click the `Replace` button.

![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/2ee42eb7-b9ff-4334-ba5d-f32786b03685)
![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/7096e37e-3d60-4eea-87e3-326e032a16b8)

### Replace Font in Project

This method replaces the font in all Text or TextMeshProUGUI components in all scenes and prefabs in your project.

To use this method, go to `Tools > Project > Replace Font` in the Unity Editor. A window will appear, allowing you to select the font you want to use. First select the font type on `Type` enum. Next select the font you want to use. Click on `Find place` enum and select `All files in project`. Click the `Replace` button.

![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/65a838e1-ef8b-4550-972a-57b7d336da77)
![image](https://github.com/Son1kXDev/replacefontunity/assets/106654105/403bc918-82a0-48ce-89ec-36c2ab52e90b)

## Notes

- This plugin only replaces the font in Text and TextMeshProUGUI components. It does not replace the font in other components that use fonts, such as SpriteText.
- This plugin does not create a backup of your project before making changes. Please make sure to back up your project before using this plugin.
- This plugin does not support multiple fonts. You can only replace all Text and TextMeshProUGUI components with a single font at a time.
