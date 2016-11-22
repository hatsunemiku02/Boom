using UnityEngine;
using System.Collections;

public class BoomData : BoomRefObject {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomData",new BoomData());

    public override BoomClassUID GetRTTI()
    {
        return BoomData.RTTI;
    }

    public BoomData()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomData();
    }


    public BoomEntity Owner
    {
        get
        {
            return m_Owner;
        }
    }

    private BoomEntity m_Owner;
    public virtual void Init(BoomEntity owner)
    {
        m_Owner = owner;
    }

    public virtual void Discard()
    {
        Debug.LogError(" executing base boom Discard function! ");
    }
}



