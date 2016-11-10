using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoomEntity : BoomObject
{
   
    protected Dictionary<System.Type, BoomData> m_DataList;

    protected Dictionary<System.Type, BoomData> m_DataList2;

    public GameObject UnityGO
    {
        get;
        set;
    }

    // Only used for boom function
    public void AddData(BoomData data)
    {
        m_DataList.Add(data.GetType(), data);
    }
    // Only used for boom function
    public void RemoveData(BoomData data)
    {
        m_DataList.Remove(data.GetType());
    }
    
    // Only used for boom function
    public bool HaveData(System.Type type)
    {
        if (m_DataList.ContainsKey(type))
        {
            return true;
        }
        return false;
    }
}
