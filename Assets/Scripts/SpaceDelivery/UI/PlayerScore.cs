using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceDelivery.UI
{
    public class PlayerScore : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI countOfFoodText;
        [SerializeField] private Image foodImage;
        
        private int _countFood;

        public void UpdateScore()
        {
            _countFood++;
            countOfFoodText.text = $"{_countFood}";
        }

        public void DisableScore()
        {
            foodImage.enabled = false;
            countOfFoodText.text = $"";
        }
    }
}
