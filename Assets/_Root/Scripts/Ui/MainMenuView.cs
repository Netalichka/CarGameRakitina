using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSetting;


        public void Init(UnityAction StartGame, UnityAction OpenSettings)
        {
            _buttonStart.onClick.AddListener(StartGame);
            _buttonSetting.onClick.AddListener(OpenSettings);
        }
           

        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSetting.onClick.RemoveAllListeners();
        }
           
    }
}
