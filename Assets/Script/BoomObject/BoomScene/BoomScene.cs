using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoomScene : BoomObject {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomScene", new BoomScene());

    public override BoomClassUID GetRTTI()
    {
        return BoomScene.RTTI;
    }

    public BoomScene()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomScene();
    }

    public string ScenePrefabName
    {
        get;
        set;
    }

    private List<BoomSceneObj> m_SceneObjArray;



}
