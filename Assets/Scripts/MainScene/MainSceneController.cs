using UI.Core.Interface;
using UnityEngine;

namespace MainScene
{
    public class MainSceneController
    {
        private readonly IUIStorage _uiStorage;

        public MainSceneController(IUIStorage uiStorage)
        {
            _uiStorage = uiStorage;

            ShowUI("mainView");
            ShowUI("hud");
        }

        private void ShowUI(string key)
        {
            var viewId = "mainView";
            var view = _uiStorage.Get(viewId);
            if (view == null)
            {
                Debug.LogError("[MainSceneController::ShowUI] view with id ["+viewId+"] doesn`t exists");
                return;
            }
            
            view.Show(); 
        }
    }
}