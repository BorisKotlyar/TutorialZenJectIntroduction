using UI.Core.Interface;
using UnityEngine;

namespace UI.Core
{
    public class UIView : IUIView
    {
        public void Show()
        {
            Debug.Log("Show run");
        }

        public void Hide()
        {
            Debug.Log("Hide run");
        }
    }
}