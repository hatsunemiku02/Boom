using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace AStar
{
    public class Grid : MonoBehaviour
    {
        public GameObject NodeWall;
        public GameObject Node;
        public float CanPathThrethhold = 1.0f;
        public float G = 1.0f;
        // 节点半径
        public float NodeRadius = 0.25f;
        // 过滤墙体所在的层
        public LayerMask WhatLayer;

        // 玩家
        public Transform player;
        // 目标
        public Transform destPos;



        private PathFindNodeItem[,] grid;
        private int w, h;

        private GameObject WallRange, PathRange;
        private List<GameObject> pathObj = new List<GameObject>();

        void Awake()
        {
            // 初始化格子
            w = Mathf.RoundToInt(transform.localScale.x * 2);
            h = Mathf.RoundToInt(transform.localScale.y * 2);
            grid = new PathFindNodeItem[w, h];

            WallRange = new GameObject("WallRange");
            PathRange = new GameObject("PathRange");

            // 将墙的信息写入格子中
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Vector3 pos = new Vector3(x * 0.5f, y * 0.5f, 0);
                    // 通过节点中心发射圆形射线，检测当前位置是否可以行走
                    bool isWall = Physics.CheckSphere(pos, NodeRadius, WhatLayer);
                    // 构建一个节点
                    grid[x, y] = new PathFindNodeItem(isWall, pos, x, y);
                    if (isWall)
                    {
                        grid[x, y].Height = 3.0f;
                    }

                    // 如果是墙体，则画出不可行走的区域
                    if (isWall)
                    {
                        GameObject obj = GameObject.Instantiate(NodeWall, pos, Quaternion.identity) as GameObject;
                        obj.transform.SetParent(WallRange.transform);
                    }
                    else
                    {
                        //	GameObject obj = GameObject.Instantiate( Node, pos, Quaternion.identity ) as GameObject;
                        //				/	obj.transform.SetParent( WallRange.transform );

                    }
                }
            }

        }

        // 根据坐标获得一个节点
        public PathFindNodeItem getItem(Vector3 position)
        {
            int x = Mathf.RoundToInt(position.x) * 2;
            int y = Mathf.RoundToInt(position.y) * 2;
            x = Mathf.Clamp(x, 0, w - 1);
            y = Mathf.Clamp(y, 0, h - 1);
            return grid[x, y];
        }

        // 取得周围的节点
        public List<PathFindNodeItem> getNeibourhood(PathFindNodeItem node)
        {
            List<PathFindNodeItem> list = new List<PathFindNodeItem>();
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    // 如果是自己，则跳过
                    if (i == 0 && j == 0)
                        continue;
                    int x = node.x + i;
                    int y = node.y + j;
                    // 判断是否越界，如果没有，加到列表中
                    if (x < w && x >= 0 && y < h && y >= 0)
                        list.Add(grid[x, y]);
                }
            }
            return list;
        }

        // 更新路径
        public void updatePath(List<PathFindNodeItem> lines)
        {
            int curListSize = pathObj.Count;
            for (int i = 0, max = lines.Count; i < max; i++)
            {
                if (i < curListSize)
                {
                    pathObj[i].transform.position = lines[i].pos;
                    pathObj[i].SetActive(true);
                }
                else
                {
                    GameObject obj = GameObject.Instantiate(Node, lines[i].pos, Quaternion.identity) as GameObject;
                    obj.transform.SetParent(PathRange.transform);
                    pathObj.Add(obj);
                }
            }
            for (int i = lines.Count; i < curListSize; i++)
            {
                pathObj[i].SetActive(false);
            }
        }
    }
}


