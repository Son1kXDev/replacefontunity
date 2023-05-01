using UnityEngine;
using UnityEditor;
using Plugins;
using TMPro;

namespace Editors
{
    public class ReplaceFontEditorWindow : EditorWindow
    {
        private Font newFont;
        private TMP_FontAsset newTMPfont;

        private WindowType windowType;
        private FontType fontType;

        public static void ShowWindow()
        {
            EditorWindow window = GetWindow(typeof(ReplaceFontEditorWindow));
            window.titleContent = new GUIContent("Replace font Tool");

            window.maxSize = new Vector2(350, 90);
            window.minSize = new Vector2(350, 90);
        }

        private void OnGUI()
        {
            GUILayout.Space(10);

            GUILayout.FlexibleSpace();

            switch (fontType)
            {
                case FontType.LegacyText:
                    newFont = EditorGUILayout.ObjectField("New font", newFont, typeof(Font), false) as Font;
                    break;

                case FontType.TextMeshPro:
                    newTMPfont = EditorGUILayout.ObjectField("New font", newTMPfont, typeof(TMP_FontAsset), false) as TMP_FontAsset;
                    break;
            }

            windowType = (WindowType)EditorGUILayout.EnumPopup("Find place:", windowType);

            fontType = (FontType)EditorGUILayout.EnumPopup("Type:", fontType);

            if (GUILayout.Button("Replace"))
            {
                switch (windowType)
                {
                    case WindowType.CurrentScene:
                        switch (fontType)
                        {
                            case FontType.LegacyText:
                                ReplaceFont.ReplaceFontInScene(newFont);
                                break;

                            case FontType.TextMeshPro:
                                ReplaceFont.ReplaceFontInScene(newTMPfont);
                                break;
                        }
                        break;

                    case WindowType.Prefabs:
                        switch (fontType)
                        {
                            case FontType.LegacyText:
                                ReplaceFont.ReplaceFontPrefab(newFont);
                                break;

                            case FontType.TextMeshPro:
                                ReplaceFont.ReplaceFontPrefab(newTMPfont);
                                break;
                        }
                        break;

                    case WindowType.InProject:
                        switch (fontType)
                        {
                            case FontType.LegacyText:
                                ReplaceFont.ReplaceFontInProject(newFont);
                                break;

                            case FontType.TextMeshPro:
                                ReplaceFont.ReplaceFontInProject(newTMPfont);
                                break;
                        }
                        break;
                }
            }
            GUILayout.Space(10);
        }
    }

    public enum WindowType
    {[InspectorName("Current scene")] CurrentScene, Prefabs, [InspectorName("All files in project")] InProject }

    public enum FontType
    { LegacyText, TextMeshPro }
}