using SceneGenerator;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TerrainBehaviour))]
public class TerrainBehaviourEditor : Editor
{
    private TerrainBehaviour mTargetTerrain;

    private void OnEnable()
    {
        mTargetTerrain = (TerrainBehaviour)target;
    }

    private void OnDisable()
    {
        mTargetTerrain = null;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        mTargetTerrain.OnInspectorGUI();
        // 1. EditorUtility.SetDirty(Object)
        // 2. serializedObject.FindProperty("Name").stringValue = "Codinggamer";
        //    serializedObject.ApplyModifiedProperties();
    }

    private void OnSceneGUI()
    {

    }

    private void OnDrawGizmos()
    {
        mTargetTerrain.OnDrawGizmos();
    }
}
