using UnityEngine;
using UnityEditor;
using Editors;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.SceneManagement;
using TMPro;

namespace Plugins
{
    public static class ReplaceFont
    {
        [MenuItem("Tools/Project/Replace Font")]
        private static void ReplaceFontMenuItem()
        {
            ReplaceFontEditorWindow.ShowWindow();
        }

        public static void ReplaceFontInScene(Font font)
        {
            if (font == null)
            {
                EditorUtility.DisplayDialog("Replace font Result", "Font is null", "Ok");
                return;
            }

            List<Component> components = null;
            var currentScene = EditorSceneManager.GetActiveScene();

            var textComponents = Resources.FindObjectsOfTypeAll<Text>();

            foreach (var component in textComponents)
            {
                if (component.gameObject.scene != currentScene) return;

                component.font = font;
                if (components == null) components = new();
                components.Add(component);
                Debug.Log($"Replaced: {component.name}", component);
            }

            if (components != null)
                EditorUtility.DisplayDialog("Replace font Result", "Successfuly replaced font on current scene", "Ok");
            else
                EditorUtility.DisplayDialog("Replace font Result", "Can't find any text components on current scene", "Ok");
        }

        public static void ReplaceFontInScene(TMP_FontAsset font)
        {
            if (font == null)
            {
                EditorUtility.DisplayDialog("Replace font Result", "Font is null", "Ok");
                return;
            }

            List<Component> components = null;
            var currentScene = EditorSceneManager.GetActiveScene();

            var textComponents = Resources.FindObjectsOfTypeAll<TextMeshProUGUI>();

            foreach (var component in textComponents)
            {
                if (component.gameObject.scene != currentScene) return;

                component.font = font;
                if (components == null) components = new();
                components.Add(component);
                Debug.Log($"Replaced: {component.name}", component);
            }

            if (components != null)
                EditorUtility.DisplayDialog("Replace font Result", "Successfuly replaced font on current scene", "Ok");
            else
                EditorUtility.DisplayDialog("Replace font Result", "Can't find any text components on current scene", "Ok");
        }

        public static void ReplaceFontPrefab(Font font)
        {
            if (font == null)
            {
                EditorUtility.DisplayDialog("Replace font Result", "Font is null", "Ok");
                return;
            }

            string[] prefabsPaths = AssetDatabase.GetAllAssetPaths().
                Where(path => path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();

            List<Component> components = null;

            foreach (string path in prefabsPaths)
            {
                if (path.Contains("Packages")) continue;

                using (var prefabScope = new PrefabUtility.EditPrefabContentsScope(path))
                {
                    var prefab = prefabScope.prefabContentsRoot;

                    var prefabTexts = prefab.GetComponentsInChildren<Text>(true);
                    foreach (Text component in prefabTexts)
                    {
                        component.font = font;
                        if (components == null) components = new();
                        components.Add(component);
                    }
                    Debug.Log($"Replaced: {prefab.name}", prefab);
                }
            }

            if (components != null)
                EditorUtility.DisplayDialog("Replace font Result", "Successfuly replaced font in project", "Ok");
            else
                EditorUtility.DisplayDialog("Replace font Result", "Can't find any text components", "Ok");
        }

        public static void ReplaceFontPrefab(TMP_FontAsset font)
        {
            if (font == null)
            {
                EditorUtility.DisplayDialog("Replace font Result", "Font is null", "Ok");
                return;
            }

            string[] prefabsPaths = AssetDatabase.GetAllAssetPaths().
                Where(path => path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();

            List<Component> components = null;

            foreach (string path in prefabsPaths)
            {
                if (path.Contains("Packages")) continue;

                using (var prefabScope = new PrefabUtility.EditPrefabContentsScope(path))
                {
                    var prefab = prefabScope.prefabContentsRoot;

                    var prefabTexts = prefab.GetComponentsInChildren<TextMeshProUGUI>(true);
                    foreach (TextMeshProUGUI component in prefabTexts)
                    {
                        component.font = font;
                        if (components == null) components = new();
                        components.Add(component);
                    }
                    Debug.Log($"Replaced: {prefab.name}", prefab);
                }
            }

            if (components != null)
                EditorUtility.DisplayDialog("Replace font Result", "Successfuly replaced font in project", "Ok");
            else
                EditorUtility.DisplayDialog("Replace font Result", "Can't find any text components", "Ok");
        }

        public static void ReplaceFontInProject(Font font)
        {
            if (font == null)
            {
                EditorUtility.DisplayDialog("Replace font Result", "Font is null", "Ok");
                return;
            }

            string[] scenesPaths = AssetDatabase.GetAllAssetPaths().
                Where(path => path.EndsWith(".unity", System.StringComparison.OrdinalIgnoreCase)).ToArray();
            string[] prefabsPaths = AssetDatabase.GetAllAssetPaths().
                Where(path => path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();

            List<Component> components = null;

            foreach (string path in prefabsPaths)
            {
                if (path.Contains("Packages")) continue;

                using (var prefabScope = new PrefabUtility.EditPrefabContentsScope(path))
                {
                    var prefab = prefabScope.prefabContentsRoot;

                    var prefabTexts = prefab.GetComponentsInChildren<Text>(true);
                    foreach (Text component in prefabTexts)
                    {
                        component.font = font;
                        if (components == null) components = new();
                        components.Add(component);
                    }
                    Debug.Log($"Replaced: {prefab.name}", prefab);
                }
            }

            var currentScene = EditorSceneManager.GetActiveScene().path;
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

            var textComponents = Component.FindObjectsOfType<Text>();

            foreach (string scene in scenesPaths)
            {
                EditorSceneManager.OpenScene(scene);
                foreach (var component in textComponents)
                {
                    component.font = font;
                    if (components == null) components = new();
                    components.Add(component);
                    Debug.Log($"Replaced: {component.name}", component);
                }

                EditorSceneManager.SaveOpenScenes();
            }

            EditorSceneManager.OpenScene(currentScene);

            if (components != null)
                EditorUtility.DisplayDialog("Replace font Result", "Successfuly replaced font in project", "Ok");
            else
                EditorUtility.DisplayDialog("Replace font Result", "Can't find any text components", "Ok");
        }

        public static void ReplaceFontInProject(TMP_FontAsset font)
        {
            if (font == null)
            {
                EditorUtility.DisplayDialog("Replace font Result", "Font is null", "Ok");
                return;
            }

            string[] scenesPaths = AssetDatabase.GetAllAssetPaths().
                Where(path => path.EndsWith(".unity", System.StringComparison.OrdinalIgnoreCase)).ToArray();
            string[] prefabsPaths = AssetDatabase.GetAllAssetPaths().
                Where(path => path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();

            List<Component> components = null;

            foreach (string path in prefabsPaths)
            {
                if (path.Contains("Packages")) continue;

                using (var prefabScope = new PrefabUtility.EditPrefabContentsScope(path))
                {
                    var prefab = prefabScope.prefabContentsRoot;

                    var prefabTexts = prefab.GetComponentsInChildren<TextMeshProUGUI>(true);
                    foreach (TextMeshProUGUI component in prefabTexts)
                    {
                        component.font = font;
                        if (components == null) components = new();
                        components.Add(component);
                    }
                    Debug.Log($"Replaced: {prefab.name}", prefab);
                }
            }

            var currentScene = EditorSceneManager.GetActiveScene().path;
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

            foreach (string scene in scenesPaths)
            {
                EditorSceneManager.OpenScene(scene);

                var textComponents = Resources.FindObjectsOfTypeAll<TextMeshProUGUI>();

                foreach (var component in textComponents)
                {
                    component.font = font;
                    if (components == null) components = new();
                    components.Add(component);
                    Debug.Log($"Replaced: {component.name}");
                }

                EditorSceneManager.SaveOpenScenes();
            }

            EditorSceneManager.OpenScene(currentScene);

            if (components != null)
                EditorUtility.DisplayDialog("Replace font Result", "Successfuly replaced font in project", "Ok");
            else
                EditorUtility.DisplayDialog("Replace font Result", "Can't find any text components", "Ok");
        }
    }
}