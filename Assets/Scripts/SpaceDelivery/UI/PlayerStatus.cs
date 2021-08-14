using UnityEngine;

namespace SpaceDelivery.UI
{
    public class PlayerStatus : MonoBehaviour
    {
        [SerializeField] private GameObject failUI;
        [SerializeField] private GameObject winUI;

        public void SetFail()
        {
            failUI.gameObject.SetActive(true);
        }

        public void SetWin()
        {
            winUI.gameObject.SetActive(true);
        }
    }
}
