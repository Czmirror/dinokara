using System.Collections;
using System.Collections.Generic;
using DinokarA.Assets.Scripts.Data;
using UnityEngine;


public class LoadStageData : MonoBehaviour
{
    [SerializeField]
    private string currentStageName;
    public string CurrentStage
    {
        get { return currentStageName; }
    }

    private Stage currentStageData;
    public Stage CurrentStageData
    {
        get { return currentStageData; }
    }

    
    void Start()
    {
        var _stage_name = PlayerPrefs.GetString("CurrentStage", "Stage1");
        var _jsonPath = "Data/" + _stage_name;
        
        string json = Resources.Load<TextAsset>(_jsonPath).ToString();
        Stage _stage = JsonUtility.FromJson<Stage>(json);
        currentStageData = _stage;
    }

}
