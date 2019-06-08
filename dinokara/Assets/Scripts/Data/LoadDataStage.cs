using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace DinokarA.Assets.Scripts.Data
{
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

    public class LoadDataStage : MonoBehaviour
    {
        
    
        void Start()
    
        {
        
            string json = Resources.Load<TextAsset>("Data/stage").ToString();
            var _stage = JsonHelper.ListFromJson<Stage>(json);

    }
    
    
    }

}

