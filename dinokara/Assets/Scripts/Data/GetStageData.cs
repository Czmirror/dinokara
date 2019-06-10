using UnityEngine;

namespace DinokarA.Assets.Scripts.Data
{
    // ステージデーターをJSONから取得
    public class GetStageData : MonoBehaviour
    {
        public static Stage GetStage(string stage_name = null)
        {
            if (stage_name == null)
            {
                stage_name = GetPlayerPrefs.GetCurrentStage();
            }

            var _jsonPath = "Data/" + stage_name;

            string json = Resources.Load<TextAsset>(_jsonPath).ToString();
            Stage _stage = JsonUtility.FromJson<Stage>(json);

            return _stage;
        }
    }
}
