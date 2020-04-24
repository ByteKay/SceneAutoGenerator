using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace SceneGenerator
{

#if UNITY_EDITOR
    public partial class TerrainBehaviour
    {

        public void OnDrawGizmos()
        {
            for (int i = 0; i < Count; ++i)
            {
                Polygons[i].OnDrawGizmos();
            }
        }

        public void OnInspectorGUI()
        {
            GUILayout.Space(16);
            EditorGUILayout.BeginVertical(GUI.skin.GetStyle("Window"));
            if (GUILayout.Button("添加区域"))
            {
                AddPolygon();
            }
            EditorGUILayout.EndVertical();
        }
    }

#endif

    [Serializable]
    public partial class TerrainBehaviour : MonoBehaviour
    {
        private TerrainData mTerrainData = new TerrainData();
        private int mPolygonIndex = -1;

        [OnChangedCall("PolygonChanged")]
        public List<Polygon> Polygons = new List<Polygon>();

        public void AddPolygon()
        {
            Polygons.Add(new Polygon());
            mPolygonIndex = Polygons.Count - 1;
        }

        public int Count
        {
            get
            {
                return Polygons.Count;
            }
        }

        public void PolygonChanged()
        {
            Debug.Log("PolygonChanged");
        }

    }
}
