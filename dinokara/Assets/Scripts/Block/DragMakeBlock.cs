using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DinokarA.Assets.Scripts.Block
{

    public class DragMakeBlock : MonoBehaviour
    {
        [SerializeField] private GameObject _block;

        [SerializeField] private bool makeFlag = false;

        private void OnMouseDown()
        {
            if (!makeFlag)
            {
                var _position = gameObject.transform.position;
                //Instantiate(_block, _position, Quaternion.identity);
                makeFlag = true;
            }
        }

        private void OnMouseDrag()
        {
            Vector3 objectPointInScreen
                = Camera.main.WorldToScreenPoint(this.transform.position);

            Vector3 mousePointInScreen
                = new Vector3(Input.mousePosition.x,
                    Input.mousePosition.y,
                    objectPointInScreen.z);

            Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
            mousePointInWorld.z = this.transform.position.z;
            this.transform.position = mousePointInWorld;
        }

    }

}
