using Base.Types.Base;
using UnityEditor;
using UnityEngine;

namespace Base.Editor
{
    [CustomPropertyDrawer(typeof(Variable<>), true)]
    public class VariableDrawer : PropertyDrawer
    {
        private const int SwapButtonWidth = 30;

        private bool _editMode;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var swapButtonPosition = new Rect
            {
                x = position.x + position.width - SwapButtonWidth,
                y = position.y,
                width = SwapButtonWidth,
                height = EditorGUIUtility.singleLineHeight
            };

            if (GUI.Button(swapButtonPosition, "S"))
            {
                _editMode = !_editMode;
                GUI.FocusControl(null);
            }

            var variablePosition = position;
            variablePosition.width -= SwapButtonWidth + EditorGUIUtility.standardVerticalSpacing;
            variablePosition.height = EditorGUIUtility.singleLineHeight;


            if (property.objectReferenceValue == null || !_editMode)
            {
                EditorGUI.PropertyField(variablePosition, property, label);
            }
            else
            {
                var variableSo = new SerializedObject(property.objectReferenceValue);
                var value = variableSo.FindProperty("initialValue");

                EditorGUI.BeginChangeCheck();

                EditorGUI.PropertyField(variablePosition, value, label);

                if (EditorGUI.EndChangeCheck()) variableSo.ApplyModifiedProperties();
            }

            // var variableLabel = EditorGUI.BeginProperty(position, label, property);
            // var variablePosition = EditorGUI.PrefixLabel(position, variableLabel);
            //  variablePosition.height = EditorGUIUtility.singleLineHeight;
            //
            //  EditorGUI.BeginChangeCheck();
            //
            //  EditorGUI.ObjectField(variablePosition, property, GUIContent.none);
            //  
            //  if (property.objectReferenceValue != null)
            //  {
            //      var variableSo = new SerializedObject(property.objectReferenceValue);
            //      var value = variableSo.FindProperty("value");
            //
            //      
            //      var valuePosition = position;
            //      valuePosition.height = EditorGUIUtility.singleLineHeight;
            //      valuePosition.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            //
            //      // var intend = ++EditorGUI.indentLevel;
            //      // EditorGUI.indentLevel = 0;
            //      //EditorGUI.indentLevel++;
            //   var valueLabel = EditorGUI.BeginProperty(valuePosition, new GUIContent("Value:"), value);
            //   // valuePosition =  EditorGUI.PrefixLabel(valuePosition, valueLabel);
            //      EditorGUI.PropertyField(valuePosition, value, new GUIContent("Value:"));
            //
            //     // EditorGUI.indentLevel--;
            //          //EditorGUI.indentLevel = intend;
            //      
            //      if (EditorGUI.EndChangeCheck()) variableSo.ApplyModifiedProperties();
            //  }
            //  EditorGUI.EndProperty();
        }


        // public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        // {
        //     if (property.objectReferenceValue == null) return base.GetPropertyHeight(property, label);
        //
        //     var variableSo = new SerializedObject(property.objectReferenceValue);
        //     var variableIterator = variableSo.GetIterator();
        //
        //     var totalHeight = 0f;
        //
        //     while (variableIterator.NextVisible(true))
        //     {
        //         Debug.Log(variableIterator.name);
        //         totalHeight += EditorGUI.GetPropertyHeight(variableIterator, label, true) +
        //                        EditorGUIUtility.standardVerticalSpacing;
        //     }
        //
        //     return totalHeight;
        // }
    }
}