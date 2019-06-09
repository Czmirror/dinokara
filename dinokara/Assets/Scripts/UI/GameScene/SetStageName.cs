using UnityEngine;
using TMPro;
using DinokarA.Assets.Scripts.Data;
using DinokarA.Assets.Scripts.Manager;

namespace DinokarA.Assets.Scripts.UI
{
    public class SetStageName : MonoBehaviour
    {
        [SerializeField] private GameObject blockEditorManager;
        [SerializeField] private LoadStageData loadStageData;
        
        private void Update()
        {
            if (loadStageData == null)
            {
                loadStageData = blockEditorManager.GetComponent<LoadStageData>();
                Stage _stage = blockEditorManager.GetComponent<LoadStageData>().CurrentStageData;
                gameObject.GetComponent<TextMeshProUGUI>().text = _stage.stage_name;
            }
        }
    }
}
