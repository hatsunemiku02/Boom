using UnityEngine;
using System.Collections;


namespace AStar
{
    /// <summary>
    /// 寻路节点
    /// </summary>
    public class PathFindNodeItem
    {
        // 是否是障碍物
        //public bool isWall;
        // 位置
        public Vector3 pos;
        // 格子坐标
        public int x, y;

        public float Height;


        // 与起点的长度
        public float gCost;
        // 与目标点的长度
        public float hCost;

        // 总的路径长度
        public float fCost
        {
            get { return gCost + hCost; }
        }

        // 父节点
        public PathFindNodeItem parent;

        public PathFindNodeItem(bool isWall, Vector3 pos, int x, int y)
        {
            //this.isWall = isWall;
            this.pos = pos;
            this.x = x;
            this.y = y;
        }
    }

}


