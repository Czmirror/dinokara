using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class JsonHelper
{
    public static List<T> ListFromJson<T>(string json)
    {
        var newJson = "{ \"list\": " + json + "}";
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
        return wrapper.list;
    }

    [Serializable]
    class Wrapper<T>
    {
        public List<T> list;
    }
}

[Serializable]
public class Stage
{
    public int id;
    public string stage_name;
    public int time;
    public string description;
    public List<Block> block;
}

public class Block
{
    public int normal;
    public int hard;
}


public class LoadDataStage : MonoBehaviour
{
    void Start()
    {
        string json = Resources.Load<TextAsset>("Data/stage").ToString();
        var _stage = JsonHelper.ListFromJson<Stage>(json);
        ;
        Debug.Log(_stage[0].id);
        Debug.Log(_stage[0].stage_name);

    }
}
