using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AStar
{
    public class FindPath : MonoBehaviour
    {
        private Grid grid;
        private PlayerAtt player;
        public bool findNextFrame = false;


        // Use this for initialization
        void Start()
        {
            grid = GetComponent<Grid>();
            player = GetComponent<PlayerAtt>();
        }

        // Update is called once per frame
        void Update()
        {
            if (findNextFrame)
            {
                FindingPath(player, grid.player.position, grid.destPos.position);
                findNextFrame = false;
            }

        }

        // A*寻路
        void FindingPath(PlayerAtt player, Vector3 s, Vector3 e)
        {
            PathFindNodeItem startNode = grid.getItem(s);
            PathFindNodeItem endNode = grid.getItem(e);

            List<PathFindNodeItem> openSet = new List<PathFindNodeItem>();
            HashSet<PathFindNodeItem> closeSet = new HashSet<PathFindNodeItem>();
            openSet.Add(startNode);

            while (openSet.Count > 0)
            {
                PathFindNodeItem curNode = openSet[0];

                for (int i = 0, max = openSet.Count; i < max; i++)
                {
                    if (openSet[i].fCost <= curNode.fCost)
                    {
                        curNode = openSet[i];
                    }
                }

                openSet.Remove(curNode);
                closeSet.Add(curNode);

                // 找到的目标节点
                if (curNode == endNode)
                {
                    Debug.Log("cost is :" + curNode.gCost.ToString());
                    generatePath(startNode, endNode);
                    return;
                }

                // 判断周围节点，选择一个最优的节点
                foreach (var item in grid.getNeibourhood(curNode))
                {
                    // 如果是墙或者已经在关闭列表中

                    float neibourCost = CaculateNodeCost(player, curNode, item);
                    if (neibourCost == -1.0f || closeSet.Contains(item))
                        continue;
                    // 计算当前相领节点现开始节点距离
                    float newCost = curNode.gCost + neibourCost;
                    // 如果距离更小，或者原来不在开始列表中
                    if (newCost < item.gCost || !openSet.Contains(item))
                    {
                        // 更新与开始节点的距离
                        item.gCost = newCost;
                        // 更新与终点的距离
                        item.hCost = getDistanceNodes(item, endNode) / player.moveSpeed;
                        // 更新父节点为当前选定的节点
                        item.parent = curNode;
                        // 如果节点是新加入的，将它加入打开列表中
                        if (!openSet.Contains(item))
                        {
                            openSet.Add(item);
                        }
                    }
                }
            }

            generatePath(startNode, null);
        }

        // 生成路径
        void generatePath(PathFindNodeItem startNode, PathFindNodeItem endNode)
        {
            List<PathFindNodeItem> path = new List<PathFindNodeItem>();
            if (endNode != null)
            {
                PathFindNodeItem temp = endNode;
                while (temp != startNode)
                {
                    path.Add(temp);
                    temp = temp.parent;
                }
                // 反转路径
                path.Reverse();
            }
            // 更新路径
            grid.updatePath(path);
        }

        // 获取两个节点之间的距离
        float getDistanceNodes(PathFindNodeItem a, PathFindNodeItem b)
        {
            float ret;
            float cntX = Mathf.Abs(a.x - b.x);
            float cntY = Mathf.Abs(a.y - b.y);
            // 判断到底是那个轴相差的距离更远
            if (cntX > cntY)
            {
                ret = 14.14f * cntY + 10.0f * (cntX - cntY);
            }
            else
            {
                ret = 14.14f * cntX + 10.0f * (cntY - cntX);
            }

            float heightdiff = Mathf.Abs(b.Height - a.Height);
            ret += heightdiff;
            return ret;
        }

        float CaculateNodeCost(PlayerAtt player, PathFindNodeItem a, PathFindNodeItem b)
        {
            bool needClimb = false;
            bool needJump = false;
            if (b.Height - a.Height > grid.CanPathThrethhold)
            {
                needClimb = true;
            }
            else if (a.Height - b.Height > grid.CanPathThrethhold)
            {
                needJump = true;
            }
            float distance = getDistanceNodes(a, b);
            float cost = distance / player.moveSpeed;

            if (needClimb)
            {
                if (player.climbSpeed > 0.0f)
                {
                    float climpcost = (b.Height - a.Height) / player.climbSpeed;
                    cost += climpcost;
                }
                else
                {
                    cost = -1.0f;
                }
            }
            if (needJump)
            {

            }
            return cost;
        }

    }
}


