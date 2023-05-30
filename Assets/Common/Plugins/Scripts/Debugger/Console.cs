using System.Reflection;
using UnityEngine;

#if UNITY_EDITOR

using UnityEditor;

#endif

namespace Utils.Debugger
{
    public enum DColor
    {
        white, black, red, green, blue, gray, yellow, orange, cyan, magenta
    }

    public enum DType
    {
        bold, italic, bolditalic
    }

    public static class Console
    {
        private static bool EnableDebugMode
        {
#if UNITY_EDITOR
            get
            {
                return EditorPrefs.GetBool("DebugMode", false);
            }
            set
            {
                EditorPrefs.SetBool("DebugMode", value);
            }
#else
            get { return false; }
            set { }
#endif
        }

        public static void Clear()
        {
#if UNITY_EDITOR
            var assembly = Assembly.GetAssembly(typeof(SceneView));
            var type = assembly.GetType("UnityEditor.LogEntries");
            var method = type.GetMethod("Clear");
            method.Invoke(new object(), null);
#endif
        }

#if UNITY_EDITOR

        [MenuItem("Tools/Console/Clear Console &%#c", priority = 1)]
        private static void ClearMenuItem()
        {
            if (EditorUtility.DisplayDialog("Clear Debug Console", "Are you sure you want to clear debug console?", "Yes", "Cansel"))
            {
                Clear();
            }
        }

        [MenuItem("Tools/Console/Debug Mode", true)]
        private static bool ValidateEnableDebug()
        {
            Menu.SetChecked("Tools/Console/Debug Mode", EnableDebugMode);
            return true;
        }

        [MenuItem("Tools/Console/Debug Mode", priority = 100)]
        private static void EnableDebug()
        {
            EnableDebugMode = !EnableDebugMode;
        }

#endif

        public static void LogValue(string lable, object message)
        {
            if (!EnableDebugMode) return;
            Debug.Log($"<color=white><b>{lable}</b></color>: {message}");
        }

        public static void LogValue(string lable, object message, Object context)
        {
            if (!EnableDebugMode) return;
            Debug.Log($"<color=white><b>{lable}</b></color>: {message}", context);
        }

        public static void LogValue(string lable, object message, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=white>{message}</color>");
                    break;

                case DColor.black:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=black>{message}</color>");
                    break;

                case DColor.red:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=red>{message}</color>");
                    break;

                case DColor.green:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=green>{message}</color>");
                    break;

                case DColor.blue:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=blue>{message}</color>");
                    break;

                case DColor.gray:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=gray>{message}</color>");
                    break;

                case DColor.yellow:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=yellow>{message}</color>");
                    break;

                case DColor.orange:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=orange>{message}</color>");
                    break;

                case DColor.cyan:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=cyan>{message}</color>");
                    break;

                case DColor.magenta:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=magenta>{message}</color>");
                    break;

                default:
                    Debug.Log($"<color=white><b>{lable}</b></color>: {message}");
                    break;
            }
        }

        public static void LogValue(string lable, object message, Object context, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=white>{message}</color>", context);
                    break;

                case DColor.black:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=black>{message}</color>", context);
                    break;

                case DColor.red:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=red>{message}</color>", context);
                    break;

                case DColor.green:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=green>{message}</color>", context);
                    break;

                case DColor.blue:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=blue>{message}</color>", context);
                    break;

                case DColor.gray:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=gray>{message}</color>", context);
                    break;

                case DColor.yellow:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=yellow>{message}</color>", context);
                    break;

                case DColor.orange:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=orange>{message}</color>", context);
                    break;

                case DColor.cyan:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=cyan>{message}</color>", context);
                    break;

                case DColor.magenta:
                    Debug.Log($"<color=white><b>{lable}</b></color>: <color=magenta>{message}</color>", context);
                    break;

                default:
                    Debug.Log($"<color=white><b>{lable}</b></color>: {message}", context);
                    break;
            }
        }

        public static void Log(object message)
        {
            if (!EnableDebugMode) return;
            Debug.Log(message);
        }

        public static void Log(object message, Object context)
        {
            if (!EnableDebugMode) return;
            Debug.Log(message, context);
        }

        public static void Log(object message, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.Log($"<color=white>{message}</color>");
                    break;

                case DColor.black:
                    Debug.Log($"<color=black>{message}</color>");
                    break;

                case DColor.red:
                    Debug.Log($"<color=red>{message}</color>");
                    break;

                case DColor.green:
                    Debug.Log($"<color=green>{message}</color>");
                    break;

                case DColor.blue:
                    Debug.Log($"<color=blue>{message}</color>");
                    break;

                case DColor.gray:
                    Debug.Log($"<color=gray>{message}</color>");
                    break;

                case DColor.yellow:
                    Debug.Log($"<color=yellow>{message}</color>");
                    break;

                case DColor.orange:
                    Debug.Log($"<color=orange>{message}</color>");
                    break;

                case DColor.cyan:
                    Debug.Log($"<color=cyan>{message}</color>");
                    break;

                case DColor.magenta:
                    Debug.Log($"<color=magenta>{message}</color>");
                    break;

                default:
                    Debug.Log(message);
                    break;
            }
        }

        public static void Log(object message, Object context, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.Log($"<color=white>{message}</color>", context);
                    break;

                case DColor.black:
                    Debug.Log($"<color=black>{message}</color>", context);
                    break;

                case DColor.red:
                    Debug.Log($"<color=red>{message}</color>", context);
                    break;

                case DColor.green:
                    Debug.Log($"<color=green>{message}</color>", context);
                    break;

                case DColor.blue:
                    Debug.Log($"<color=blue>{message}</color>", context);
                    break;

                case DColor.gray:
                    Debug.Log($"<color=gray>{message}</color>", context);
                    break;

                case DColor.yellow:
                    Debug.Log($"<color=yellow>{message}</color>", context);
                    break;

                case DColor.orange:
                    Debug.Log($"<color=orange>{message}</color>", context);
                    break;

                case DColor.cyan:
                    Debug.Log($"<color=cyan>{message}</color>", context);
                    break;

                case DColor.magenta:
                    Debug.Log($"<color=magenta>{message}</color>", context);
                    break;

                default:
                    Debug.Log(message, context);
                    break;
            }
        }

        public static void Log(object message, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.Log($"<b>{message}</b>");
                    break;

                case DType.italic:
                    Debug.Log($"<i>{message}</i>");
                    break;

                case DType.bolditalic:
                    Debug.Log($"<b><i>{message}</i></b>");
                    break;

                default:
                    Debug.Log(message);
                    break;
            }
        }

        public static void Log(object message, Object context, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.Log($"<b>{message}</b>", context);
                    break;

                case DType.italic:
                    Debug.Log($"<i>{message}</i>", context);
                    break;

                case DType.bolditalic:
                    Debug.Log($"<b><i>{message}</i></b>", context);
                    break;

                default:
                    Debug.Log(message, context);
                    break;
            }
        }

        public static void Log(object message, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=white><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=white><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=white><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=white>{message}</color>");
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=black><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=black><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=black><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=black>{message}</color>");
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=red><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=red><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=red><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=red>{message}</color>");
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=green><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=green><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=green><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=green>{message}</color>");
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=blue><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=blue><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=blue><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=blue>{message}</color>");
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=gray><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=gray><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=gray><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=gray>{message}</color>");
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=yellow><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=yellow><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=yellow><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=yellow>{message}</color>");
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=orange><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=orange><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=orange><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=orange>{message}</color>");
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=cyan><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=cyan><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=cyan><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=cyan>{message}</color>");
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=magenta><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.Log($"<color=magenta><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=magenta><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.Log($"<color=magenta>{message}</color>");
                            break;
                    }
                    break;

                default:
                    Debug.Log(message);
                    break;
            }
        }

        public static void Log(object message, Object context, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=white><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=white><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=white><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=white>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=black><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=black><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=black><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=black>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=red><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=red><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=red><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=red>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=green><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=green><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=green><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=green>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=blue><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=blue><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=blue><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=blue>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=gray><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=gray><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=gray><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=gray>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=yellow><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=yellow><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=yellow><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=yellow>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=orange><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=orange><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=orange><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=orange>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=cyan><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=cyan><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=cyan><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=cyan>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.Log($"<color=magenta><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.Log($"<color=magenta><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.Log($"<color=magenta><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.Log($"<color=magenta>{message}</color>", context);
                            break;
                    }
                    break;

                default:
                    Debug.Log(message, context);
                    break;
            }
        }

        public static void LogAssertion(object message)
        {
            if (!EnableDebugMode) return;
            Debug.LogAssertion(message);
        }

        public static void LogAssertion(object message, Object context)
        {
            if (!EnableDebugMode) return;
            Debug.LogAssertion(message, context);
        }

        public static void LogAssertion(object message, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.LogAssertion($"<color=white>{message}</color>");
                    break;

                case DColor.black:
                    Debug.LogAssertion($"<color=black>{message}</color>");
                    break;

                case DColor.red:
                    Debug.LogAssertion($"<color=red>{message}</color>");
                    break;

                case DColor.green:
                    Debug.LogAssertion($"<color=green>{message}</color>");
                    break;

                case DColor.blue:
                    Debug.LogAssertion($"<color=blue>{message}</color>");
                    break;

                case DColor.gray:
                    Debug.LogAssertion($"<color=gray>{message}</color>");
                    break;

                case DColor.yellow:
                    Debug.LogAssertion($"<color=yellow>{message}</color>");
                    break;

                case DColor.orange:
                    Debug.LogAssertion($"<color=orange>{message}</color>");
                    break;

                case DColor.cyan:
                    Debug.LogAssertion($"<color=cyan>{message}</color>");
                    break;

                case DColor.magenta:
                    Debug.LogAssertion($"<color=magenta>{message}</color>");
                    break;

                default:
                    Debug.LogAssertion(message);
                    break;
            }
        }

        public static void LogAssertion(object message, Object context, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.LogAssertion($"<color=white>{message}</color>", context);
                    break;

                case DColor.black:
                    Debug.LogAssertion($"<color=black>{message}</color>", context);
                    break;

                case DColor.red:
                    Debug.LogAssertion($"<color=red>{message}</color>", context);
                    break;

                case DColor.green:
                    Debug.LogAssertion($"<color=green>{message}</color>", context);
                    break;

                case DColor.blue:
                    Debug.LogAssertion($"<color=blue>{message}</color>", context);
                    break;

                case DColor.gray:
                    Debug.LogAssertion($"<color=gray>{message}</color>", context);
                    break;

                case DColor.yellow:
                    Debug.LogAssertion($"<color=yellow>{message}</color>", context);
                    break;

                case DColor.orange:
                    Debug.LogAssertion($"<color=orange>{message}</color>", context);
                    break;

                case DColor.cyan:
                    Debug.LogAssertion($"<color=cyan>{message}</color>", context);
                    break;

                case DColor.magenta:
                    Debug.LogAssertion($"<color=magenta>{message}</color>", context);
                    break;

                default:
                    Debug.LogAssertion(message, context);
                    break;
            }
        }

        public static void LogAssertion(object message, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.LogAssertion($"<b>{message}</b>");
                    break;

                case DType.italic:
                    Debug.LogAssertion($"<i>{message}</i>");
                    break;

                case DType.bolditalic:
                    Debug.LogAssertion($"<b><i>{message}</i></b>");
                    break;

                default:
                    Debug.LogAssertion(message);
                    break;
            }
        }

        public static void LogAssertion(object message, Object context, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.LogAssertion($"<b>{message}</b>", context);
                    break;

                case DType.italic:
                    Debug.LogAssertion($"<i>{message}</i>", context);
                    break;

                case DType.bolditalic:
                    Debug.LogAssertion($"<b><i>{message}</i></b>", context);
                    break;

                default:
                    Debug.LogAssertion(message, context);
                    break;
            }
        }

        public static void LogAssertion(object message, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=white><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=white><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=white><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=white>{message}</color>");
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=black><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=black><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=black><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=black>{message}</color>");
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=red><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=red><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=red><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=red>{message}</color>");
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=green><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=green><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=green><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=green>{message}</color>");
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=blue><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=blue><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=blue><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=blue>{message}</color>");
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=gray><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=gray><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=gray><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=gray>{message}</color>");
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=yellow><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=yellow><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=yellow><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=yellow>{message}</color>");
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=orange><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=orange><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=orange><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=orange>{message}</color>");
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=cyan><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=cyan><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=cyan><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=cyan>{message}</color>");
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=magenta><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=magenta><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=magenta><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogAssertion($"<color=magenta>{message}</color>");
                            break;
                    }
                    break;

                default:
                    Debug.LogAssertion(message);
                    break;
            }
        }

        public static void LogAssertion(object message, Object context, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=white><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=white><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=white><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=white>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=black><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=black><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=black><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=black>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=red><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=red><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=red><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=red>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=green><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=green><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=green><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=green>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=blue><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=blue><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=blue><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=blue>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=gray><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=gray><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=gray><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=gray>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=yellow><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=yellow><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=yellow><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=yellow>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=orange><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=orange><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=orange><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=orange>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=cyan><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=cyan><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=cyan><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=cyan>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogAssertion($"<color=magenta><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogAssertion($"<color=magenta><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogAssertion($"<color=magenta><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogAssertion($"<color=magenta>{message}</color>", context);
                            break;
                    }
                    break;

                default:
                    Debug.LogAssertion(message, context);
                    break;
            }
        }

        public static void LogError(object message)
        {
            if (!EnableDebugMode) return;
            Debug.LogError(message);
        }

        public static void LogError(object message, Object context)
        {
            if (!EnableDebugMode) return;
            Debug.LogError(message, context);
        }

        public static void LogError(object message, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.LogError($"<color=white>{message}</color>");
                    break;

                case DColor.black:
                    Debug.LogError($"<color=black>{message}</color>");
                    break;

                case DColor.red:
                    Debug.LogError($"<color=red>{message}</color>");
                    break;

                case DColor.green:
                    Debug.LogError($"<color=green>{message}</color>");
                    break;

                case DColor.blue:
                    Debug.LogError($"<color=blue>{message}</color>");
                    break;

                case DColor.gray:
                    Debug.LogError($"<color=gray>{message}</color>");
                    break;

                case DColor.yellow:
                    Debug.LogError($"<color=yellow>{message}</color>");
                    break;

                case DColor.orange:
                    Debug.LogError($"<color=orange>{message}</color>");
                    break;

                case DColor.cyan:
                    Debug.LogError($"<color=cyan>{message}</color>");
                    break;

                case DColor.magenta:
                    Debug.LogError($"<color=magenta>{message}</color>");
                    break;

                default:
                    Debug.LogError(message);
                    break;
            }
        }

        public static void LogError(object message, Object context, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.LogError($"<color=white>{message}</color>", context);
                    break;

                case DColor.black:
                    Debug.LogError($"<color=black>{message}</color>", context);
                    break;

                case DColor.red:
                    Debug.LogError($"<color=red>{message}</color>", context);
                    break;

                case DColor.green:
                    Debug.LogError($"<color=green>{message}</color>", context);
                    break;

                case DColor.blue:
                    Debug.LogError($"<color=blue>{message}</color>", context);
                    break;

                case DColor.gray:
                    Debug.LogError($"<color=gray>{message}</color>", context);
                    break;

                case DColor.yellow:
                    Debug.LogError($"<color=yellow>{message}</color>", context);
                    break;

                case DColor.orange:
                    Debug.LogError($"<color=orange>{message}</color>", context);
                    break;

                case DColor.cyan:
                    Debug.LogError($"<color=cyan>{message}</color>", context);
                    break;

                case DColor.magenta:
                    Debug.LogError($"<color=magenta>{message}</color>", context);
                    break;

                default:
                    Debug.LogError(message, context);
                    break;
            }
        }

        public static void LogError(object message, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.LogError($"<b>{message}</b>");
                    break;

                case DType.italic:
                    Debug.LogError($"<i>{message}</i>");
                    break;

                case DType.bolditalic:
                    Debug.LogError($"<b><i>{message}</i></b>");
                    break;

                default:
                    Debug.LogError(message);
                    break;
            }
        }

        public static void LogError(object message, Object context, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.LogError($"<b>{message}</b>", context);
                    break;

                case DType.italic:
                    Debug.LogError($"<i>{message}</i>", context);
                    break;

                case DType.bolditalic:
                    Debug.LogError($"<b><i>{message}</i></b>", context);
                    break;

                default:
                    Debug.LogError(message, context);
                    break;
            }
        }

        public static void LogError(object message, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=white><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=white><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=white><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=white>{message}</color>");
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=black><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=black><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=black><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=black>{message}</color>");
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=red><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=red><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=red><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=red>{message}</color>");
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=green><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=green><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=green><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=green>{message}</color>");
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=blue><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=blue><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=blue><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=blue>{message}</color>");
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=gray><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=gray><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=gray><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=gray>{message}</color>");
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=yellow><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=yellow><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=yellow><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=yellow>{message}</color>");
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=orange><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=orange><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=orange><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=orange>{message}</color>");
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=cyan><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=cyan><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=cyan><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=cyan>{message}</color>");
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=magenta><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=magenta><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=magenta><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogError($"<color=magenta>{message}</color>");
                            break;
                    }
                    break;

                default:
                    Debug.LogError(message);
                    break;
            }
        }

        public static void LogError(object message, Object context, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=white><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=white><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=white><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=white>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=black><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=black><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=black><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=black>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=red><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=red><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=red><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=red>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=green><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=green><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=green><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=green>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=blue><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=blue><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=blue><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=blue>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=gray><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=gray><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=gray><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=gray>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=yellow><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=yellow><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=yellow><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=yellow>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=orange><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=orange><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=orange><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=orange>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=cyan><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=cyan><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=cyan><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=cyan>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogError($"<color=magenta><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogError($"<color=magenta><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogError($"<color=magenta><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogError($"<color=magenta>{message}</color>", context);
                            break;
                    }
                    break;

                default:
                    Debug.LogError(message, context);
                    break;
            }
        }

        public static void LogWarning(object message)
        {
            if (!EnableDebugMode) return;
            Debug.LogWarning(message);
        }

        public static void LogWarning(object message, Object context)
        {
            if (!EnableDebugMode) return;
            Debug.LogWarning(message, context);
        }

        public static void LogWarning(object message, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.LogWarning($"<color=white>{message}</color>");
                    break;

                case DColor.black:
                    Debug.LogWarning($"<color=black>{message}</color>");
                    break;

                case DColor.red:
                    Debug.LogWarning($"<color=red>{message}</color>");
                    break;

                case DColor.green:
                    Debug.LogWarning($"<color=green>{message}</color>");
                    break;

                case DColor.blue:
                    Debug.LogWarning($"<color=blue>{message}</color>");
                    break;

                case DColor.gray:
                    Debug.LogWarning($"<color=gray>{message}</color>");
                    break;

                case DColor.yellow:
                    Debug.LogWarning($"<color=yellow>{message}</color>");
                    break;

                case DColor.orange:
                    Debug.LogWarning($"<color=orange>{message}</color>");
                    break;

                case DColor.cyan:
                    Debug.LogWarning($"<color=cyan>{message}</color>");
                    break;

                case DColor.magenta:
                    Debug.LogWarning($"<color=magenta>{message}</color>");
                    break;

                default:
                    Debug.LogWarning(message);
                    break;
            }
        }

        public static void LogWarning(object message, Object context, DColor color)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    Debug.LogWarning($"<color=white>{message}</color>", context);
                    break;

                case DColor.black:
                    Debug.LogWarning($"<color=black>{message}</color>", context);
                    break;

                case DColor.red:
                    Debug.LogWarning($"<color=red>{message}</color>", context);
                    break;

                case DColor.green:
                    Debug.LogWarning($"<color=green>{message}</color>", context);
                    break;

                case DColor.blue:
                    Debug.LogWarning($"<color=blue>{message}</color>", context);
                    break;

                case DColor.gray:
                    Debug.LogWarning($"<color=gray>{message}</color>", context);
                    break;

                case DColor.yellow:
                    Debug.LogWarning($"<color=yellow>{message}</color>", context);
                    break;

                case DColor.orange:
                    Debug.LogWarning($"<color=orange>{message}</color>", context);
                    break;

                case DColor.cyan:
                    Debug.LogWarning($"<color=cyan>{message}</color>", context);
                    break;

                case DColor.magenta:
                    Debug.LogWarning($"<color=magenta>{message}</color>", context);
                    break;

                default:
                    Debug.LogWarning(message, context);
                    break;
            }
        }

        public static void LogWarning(object message, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.LogWarning($"<b>{message}</b>");
                    break;

                case DType.italic:
                    Debug.LogWarning($"<i>{message}</i>");
                    break;

                case DType.bolditalic:
                    Debug.LogWarning($"<b><i>{message}</i></b>");
                    break;

                default:
                    Debug.LogWarning(message);
                    break;
            }
        }

        public static void LogWarning(object message, Object context, DType type)
        {
            if (!EnableDebugMode) return;
            switch (type)
            {
                case DType.bold:
                    Debug.LogWarning($"<b>{message}</b>", context);
                    break;

                case DType.italic:
                    Debug.LogWarning($"<i>{message}</i>", context);
                    break;

                case DType.bolditalic:
                    Debug.LogWarning($"<b><i>{message}</i></b>", context);
                    break;

                default:
                    Debug.LogWarning(message, context);
                    break;
            }
        }

        public static void LogWarning(object message, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=white><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=white><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=white><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=white>{message}</color>");
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=black><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=black><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=black><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=black>{message}</color>");
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=red><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=red><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=red><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=red>{message}</color>");
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=green><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=green><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=green><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=green>{message}</color>");
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=blue><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=blue><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=blue><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=blue>{message}</color>");
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=gray><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=gray><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=gray><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=gray>{message}</color>");
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=yellow><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=yellow><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=yellow><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=yellow>{message}</color>");
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=orange><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=orange><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=orange><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=orange>{message}</color>");
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=cyan><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=cyan><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=cyan><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=cyan>{message}</color>");
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=magenta><b>{message}</b></color>");
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=magenta><i>{message}</i></color>");
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=magenta><b><i>{message}</i></b></color>");
                            break;

                        default:
                            Debug.LogWarning($"<color=magenta>{message}</color>");
                            break;
                    }
                    break;

                default:
                    Debug.LogWarning(message);
                    break;
            }
        }

        public static void LogWarning(object message, Object context, DColor color, DType type)
        {
            if (!EnableDebugMode) return;
            switch (color)
            {
                case DColor.white:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=white><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=white><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=white><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=white>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.black:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=black><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=black><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=black><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=black>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.red:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=red><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=red><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=red><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=red>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.green:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=green><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=green><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=green><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=green>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.blue:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=blue><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=blue><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=blue><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=blue>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.gray:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=gray><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=gray><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=gray><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=gray>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.yellow:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=yellow><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=yellow><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=yellow><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=yellow>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.orange:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=orange><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=orange><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=orange><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=orange>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.cyan:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=cyan><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=cyan><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=cyan><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=cyan>{message}</color>", context);
                            break;
                    }
                    break;

                case DColor.magenta:
                    switch (type)
                    {
                        case DType.bold:
                            Debug.LogWarning($"<color=magenta><b>{message}</b></color>", context);
                            break;

                        case DType.italic:
                            Debug.LogWarning($"<color=magenta><i>{message}</i></color>", context);
                            break;

                        case DType.bolditalic:
                            Debug.LogWarning($"<color=magenta><b><i>{message}</i></b></color>", context);
                            break;

                        default:
                            Debug.LogWarning($"<color=magenta>{message}</color>", context);
                            break;
                    }
                    break;

                default:
                    Debug.LogWarning(message, context);
                    break;
            }
        }

        public static void LogException(System.Exception exception)
        {
            if (!EnableDebugMode) return;
            Debug.LogException(exception);
        }

        public static void LogException(System.Exception exception, Object context)
        {
            if (!EnableDebugMode) return;
            Debug.LogException(exception, context);
        }
    }
}