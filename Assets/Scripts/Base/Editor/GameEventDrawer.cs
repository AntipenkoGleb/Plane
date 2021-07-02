using Base.Events;
using UnityEditor;
using UnityEngine;

namespace Base.Editor
{
    [CustomPropertyDrawer(typeof(GameEvent))]
    public class GameEventDrawer : PropertyDrawer
    {
        private readonly float _buttonWidth = 30;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var eventLabel = EditorGUI.BeginProperty(position, label, property);
            var eventPosition = EditorGUI.PrefixLabel(position, eventLabel);

            var buttonRect = new Rect(eventPosition.x + eventPosition.width - _buttonWidth, eventPosition.y,
                _buttonWidth,
                eventPosition.height);

            eventPosition.width -= _buttonWidth + EditorGUIUtility.standardVerticalSpacing;

            EditorGUI.BeginChangeCheck();

            EditorGUI.indentLevel = 0;
            EditorGUI.PropertyField(eventPosition, property, GUIContent.none);

            if (EditorGUI.EndChangeCheck()) property.serializedObject.ApplyModifiedProperties();

            GUI.enabled = Application.isPlaying;
            if (GUI.Button(buttonRect, ">"))
            {
                var target = property.objectReferenceValue as GameEvent;
                target.Raise();
            }

            EditorGUI.EndProperty();
        }
    }
}