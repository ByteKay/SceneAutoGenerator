using SceneGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

public partial class TerrainManagerEditor
{
    [MenuItem("TerrainMaker/PreviewTerrain")]
    public static void PreviewTerrain()
    {
        var win = GetWindow<TerrainManagerEditor>("PreviewTerrain");
        win.Show();
    }

    protected void OnGUI()
    {
        if (serializedObject != null)
        {
            if (GUILayout.Button("CreateTerrain"))
            {
                GameObject go = new GameObject("NewTerrain");
                TerrainBehaviour terrainBehaviour = go.AddComponent<TerrainBehaviour>();
                terrains.Add(terrainBehaviour);
                go.transform.SetParent(rootTransform, false);
                Selection.activeGameObject = go;
            }

            serializedObject.Update();
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(assetLstProperty, true);
            if (EditorGUI.EndChangeCheck())
            {
                serializedObject.ApplyModifiedProperties();
            }
        }

    }
}


public partial class TerrainManagerEditor : EditorWindow
{
    private Transform rootTransform;
    private SerializedObject serializedObject;
    private SerializedProperty assetLstProperty;
    [SerializeField]
    protected List<TerrainBehaviour> terrains = new List<TerrainBehaviour>();

    protected void OnEnable()
    {
        rootTransform = GameObject.FindWithTag("root").transform;
        serializedObject = new SerializedObject(this);
        assetLstProperty = serializedObject.FindProperty("terrains");
        terrains.AddRange(GameObject.FindObjectsOfType<TerrainBehaviour>());
    }
}