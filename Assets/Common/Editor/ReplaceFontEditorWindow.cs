using UnityEngine;
using UnityEditor;
using Utils.Debugger;
using Plugins;
using TMPro;
using System.Collections.Generic;

namespace Editors
{
    public class ReplaceFontEditorWindow : EditorWindow
    {
        private Font newFont;
        private TMP_FontAsset newTMPfont;
        [SerializeField] private List<UnityEngine.UI.Text> specifiedLegacyTextObjects;
        [SerializeField] private List<TextMeshProUGUI> specifiedTMPObjects;
        private WindowType windowType;
        private FontType fontType;

        public static void ShowWindow()
        {
            EditorWindow window = GetWindow(typeof(ReplaceFontEditorWindow));
            window.titleContent = new GUIContent("Replace font Tool");

            window.maxSize = new Vector2(350, 350);
            window.minSize = new Vector2(350, 90);
        }

        private void OnGUI()
        {
            GUILayout.Space(10);

            ScriptableObject target = this;
            SerializedObject so = new SerializedObject(target);
            SerializedProperty specifiedLegacyTextObjectsProperty = so.FindProperty(nameof(specifiedLegacyTextObjects));
            SerializedProperty specifiedTMPObjectsProperty = so.FindProperty(nameof(specifiedTMPObjects));

            if (fontType == FontType.LegacyText)
                newFont = EditorGUILayout.ObjectField("New font", newFont, typeof(Font), false) as Font;
            else newTMPfont = EditorGUILayout.ObjectField("New font", newTMPfont, typeof(TMP_FontAsset), false) as TMP_FontAsset;

            if (windowType == WindowType.Specified)
                EditorGUILayout
                .PropertyField(fontType == FontType.LegacyText ? specifiedLegacyTextObjectsProperty : specifiedTMPObjectsProperty, true);

            windowType = (WindowType)EditorGUILayout.EnumPopup("Find place:", windowType);

            fontType = (FontType)EditorGUILayout.EnumPopup("Type:", fontType);

            if (GUILayout.Button("Replace"))
            {
                switch (windowType)
                {
                    case WindowType.CurrentScene:
                        if (fontType == FontType.LegacyText) ReplaceFont.ReplaceFontInScene(newFont);
                        else ReplaceFont.ReplaceFontInScene(newTMPfont);
                        break;

                    case WindowType.Prefabs:
                        if (fontType == FontType.LegacyText) ReplaceFont.ReplaceFontPrefab(newFont);
                        else ReplaceFont.ReplaceFontPrefab(newTMPfont);
                        break;

                    case WindowType.InProject:
                        if (fontType == FontType.LegacyText) ReplaceFont.ReplaceFontInProject(newFont);
                        else ReplaceFont.ReplaceFontInProject(newTMPfont);
                        break;

                    case WindowType.Specified:
                        if (fontType == FontType.LegacyText) ReplaceFont.ReplaceFontSpecified(newFont, specifiedLegacyTextObjects);
                        else ReplaceFont.ReplaceFontSpecified(newTMPfont, specifiedTMPObjects);
                        break;
                }
            }
            GUILayout.Space(10);
            so.ApplyModifiedProperties();
        }
    }

    public enum WindowType
    { [InspectorName("Current scene")] CurrentScene, Prefabs, Specified, [InspectorName("All files in project")] InProject }

    public enum FontType
    { LegacyText, TextMeshPro }
}