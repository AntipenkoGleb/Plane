// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using Base.Types.Base;
using UnityEditor;
using UnityEngine;

namespace Base.Editor
{
    [CustomPropertyDrawer(typeof(VariableReference<,>), true)]
    public class FloatReferenceDrawer : PropertyDrawer
    {
        private readonly string[] popupOptions = {"Constant", "Variable"};
        private SerializedProperty constantValue;


        private GUIStyle popupStyle;

        private SerializedProperty useConstant;
        private SerializedProperty variable;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            popupStyle ??= new GUIStyle(GUI.skin.GetStyle("PaneOptions")) {imagePosition = ImagePosition.ImageOnly};

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            // Get properties
            useConstant ??= property.FindPropertyRelative("useConstant");
            constantValue ??= property.FindPropertyRelative("constantValue");
            variable ??= property.FindPropertyRelative("variable");

            // Calculate rect for configuration button
            var buttonRect = new Rect(position);
            buttonRect.yMin += popupStyle.margin.top;
            buttonRect.width = popupStyle.fixedWidth + popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            // // Store old indent level and set it to 0, the PrefixLabel takes care of it
            // var indent = EditorGUI.indentLevel;
            // EditorGUI.indentLevel = 0;

            var result = EditorGUI.Popup(buttonRect, useConstant.boolValue ? 0 : 1, popupOptions, popupStyle);


            useConstant.boolValue = result == 0;

            //  EditorGUI.indentLevel++;

            EditorGUI.PropertyField(position,
                useConstant.boolValue ? constantValue : variable,
                GUIContent.none);

            //   EditorGUI.indentLevel--;

            if (EditorGUI.EndChangeCheck())
                property.serializedObject.ApplyModifiedProperties();

            // EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (useConstant != null && useConstant.boolValue || variable == null)
                return base.GetPropertyHeight(property, label);
            return EditorGUI.GetPropertyHeight(variable);
        }
    }
}