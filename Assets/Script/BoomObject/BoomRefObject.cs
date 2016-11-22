using UnityEngine;
using System.Collections;

public class BoomRefObject : BoomObject
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomRefObject",new BoomRefObject());

    public override BoomClassUID GetRTTI()
    {
        return BoomRefObject.RTTI;
    }

    public BoomRefObject()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomRefObject();
    }


    protected int m_RefCount = 0;

    public int RefCount
    {
        get
        {
            return m_RefCount;
        }

    }

    public void AddRef()
    {
        m_RefCount++;
    }

    public void Release()
    {
        m_RefCount--;
    }
}