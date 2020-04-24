using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SceneGenerator
{
    public class TerrainData
    {
        private TerrainOuterFar mFar;
        private TerrainOuterNear mNear;
        private TerrainRoad mRoad;
        private TerrainWalkable mWalkable;
        private List<TerrainInnerHole> mInnerHoles;
    }
}


