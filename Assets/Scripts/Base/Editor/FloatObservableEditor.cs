using Base.Types.Base;
using UnityEditor;
using UnityEngine;

namespace Base.Editor
{
    [CustomEditor(typeof(Observable<>), true)]
    public class FloatObservableEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            dynamic observable = target;
            if (GUILayout.Button("Notify")) observable.NotifyValueChanged();
        }
    }
}