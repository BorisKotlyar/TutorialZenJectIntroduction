using UI.Core.Interface;
using UnityEngine;

namespace UI.Core
{
    public class UIMainHudView : IUIView
    {
        public void Show()
        {
            Debug.Log("Main HUD showed");
        }

        public void Hide()
        {
            Debug.Log("Hide HUD showed");
        }
    }
}