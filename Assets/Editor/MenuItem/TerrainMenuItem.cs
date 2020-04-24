using SceneGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

public class TerrainMenuItem
{
    [MenuItem("TerrainMaker/CreateEmptyTerrain")]
    public static void CreateEmptyTerrain()
    {
        GameObject go = new GameObject("NewEmptyTerrain");
        TerrainBehaviour terrain = go.AddComponent<TerrainBehaviour>();
        Selection.activeGameObject = go;
    }
}