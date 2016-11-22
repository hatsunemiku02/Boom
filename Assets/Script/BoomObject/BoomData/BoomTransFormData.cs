using UnityEngine;
using System.Collections;

public class BoomTransFormData : BoomData
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomTransFormData",new BoomTransFormData());

    public override BoomClassUID GetRTTI()
    {
        return BoomTransFormData.RTTI;
    }

    public BoomTransFormData()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomTransFormData();
    }

    private Transform m_transform;

    public override void Init(BoomEntity owner)
    {
        base.Init(owner);
        m_transform = Owner.UnityGO.GetComponent<Transform>();
    }

    public override void Discard()
    {
        
    }


    public Vector3 Position
    {
        set
        {
            m_transform.position = value;
        }
        get
        {
            return m_transform.position;
        }
    }

    public Quaternion Rotation
    {
        set
        {
            m_transform.rotation = Rotation;
        }
        get
        {
            return m_transform.rotation;
        }

    }
   

}
