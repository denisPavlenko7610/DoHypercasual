using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceDelivery.Utils
{
    public class SceneLoader : MonoBehaviour
    {
        private bool _transitionIsDone;
        private string _nextSceneName;

        public void Start()
        {
            LoadGame();
        }

        private void LoadGame()
        {
            string currentScene = SceneManager.GetActiveScene().name;
            var sceneStatus =
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Additive);
            sceneStatus.completed += (e) => SceneManager.UnloadSceneAsync(currentScene);
        }
    }
}