using Base.Events;
using UnityEditor;
using UnityEngine;

namespace Base.Editor
{
    [CustomEditor(typeof(GameEvent), false)]
    public class GameEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var @event = target as GameEvent;
            if (GUILayout.Button("Rise")) @event!.Raise();
        }
    }
}