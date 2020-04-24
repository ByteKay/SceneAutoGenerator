using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SceneGenerator
{
    [Serializable]
    public class Polygon
    {
        public List<Vector3> mPoints;

        public Polygon()
        {
            mPoints = new List<Vector3>();
        }

        public Vector3 this [int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new Exception(string.Format("{1} out of range {2}", index, Count));
                }
                return mPoints[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    return;
                }
                mPoints[index] = value;
            }
        }

        public void AddPoint(Vector3 p)
        {
            mPoints.Add(p);
        }

        public void RemovePoint(Vector3 p)
        {
            int index = mPoints.FindIndex((item) => { return item == p; });
            if (index >= 0)
            {
                RemovePoint(index);
            }
        }
        
        public void RemovePoint(int index)
        {
            if (HasPoint())
            {
                mPoints.RemoveAt(index);
            }
        }

        public void RemovePoint()
        {
            if (HasPoint())
            {
                RemovePoint(Count - 1);
            }
        }

        public bool HasPoint()
        {
            return mPoints.Count > 0;
        }

        public int Count
        {
            get
            {
                return mPoints.Count;
            }
        }


#if UNITY_EDITOR
        public void OnDrawGizmos()
        {
            for (int i = 0; i < Count; ++i)
            {
                if (Count > 1)
                {
                    int j = i + 1;
                    if (Count > 2)
                    {
                        if (j == Count)
                        {
                            j = 0;
                        }
                        Gizmos.DrawLine(this[i], this[j]);
                    }
                    else
                    {
                        if (j < Count)
                        {
                            Gizmos.DrawLine(this[i], this[j]);
                        }
                    }
                }
                Gizmos.DrawSphere(this[i], 1);
            }
        }
#endif

    }
}
