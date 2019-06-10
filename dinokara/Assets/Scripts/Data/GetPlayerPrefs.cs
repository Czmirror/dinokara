using UnityEngine;

namespace DinokarA.Assets.Scripts.Data
{
    public class GetPlayerPrefs : MonoBehaviour
    {
        // 現在のステージ名を取得
        public static string GetCurrentStage()
        {
            var _stage_name = PlayerPrefs.GetString("CurrentStage", "Stage1");

            return _stage_name;
        }
    }
}
