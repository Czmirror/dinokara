using UnityEngine;
using TMPro;
using DinokarA.Assets.Scripts.Data;
using DinokarA.Assets.Scripts.Manager;

namespace DinokarA.Assets.Scripts.UI
{
    public class SetStageName : MonoBehaviour
    {
        [SerializeField] private Stage stage;

        private void Update()
        {
            if (stage == null)
            {
                stage = GetStageData.GetStage();
                gameObject.GetComponent<TextMeshProUGUI>().text = stage.stage_name;
            }
        }
    }
}
