using SceneGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(RenameAttribute))]
public class RenameDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        RenameAttribute rename = (RenameAttribute)attribute;
        label.text = rename.mName;
        EditorGUI.PropertyField(position, property, label);
    }
}