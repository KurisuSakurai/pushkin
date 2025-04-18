using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(DisplayNameAttribute))]
public class DisplayNameDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)attribute;
        string newLabel = displayNameAttribute.DisplayName;

        EditorGUI.PropertyField(position, property, new GUIContent(newLabel), true);
    }
}