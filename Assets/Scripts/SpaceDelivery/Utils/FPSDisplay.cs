using UnityEngine;

namespace SpaceDelivery.Utils
{
    public class FPSDisplay : MonoBehaviour
    {
        [SerializeField] private Color color = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float deltaTime;
        private float _mintFPS;
        private float _maxMSec;
        private float msec;
        private float fps;

        private void Start()
        {
            InvokeRepeating("StartShowFPS", 5f, 0.2f);
            _mintFPS = int.MaxValue;
            _maxMSec = 0;
        }

        void OnGUI()
        {
            int w = Screen.width, h = Screen.height;

            GUIStyle style = new GUIStyle();

            Rect rect = new Rect(10, 20, w, h * 2 / 100);
            style.alignment = TextAnchor.UpperLeft;
            style.fontSize = h * 2 / 100;
            style.normal.textColor = color;
            msec = deltaTime * 1000.0f;
            fps = 1.0f / deltaTime;
            if (fps < _mintFPS)
            {
                _mintFPS = fps;
            }

            if (msec > _maxMSec)
            {
                _maxMSec = msec;
            }

            string text = string.Format("{0:0.0} ms ({1:0.} fps) (min FPS: {2:0.}) (max msec: {3:0.0})", msec, fps,
                _mintFPS, _maxMSec);
            GUI.Label(rect, text, style);
        }

        private void StartShowFPS()
        {
            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        }
    }
}