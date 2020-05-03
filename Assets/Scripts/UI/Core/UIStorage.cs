using System.Collections.Generic;
using UI.Core.Interface;

namespace UI.Core
{
    public class UIStorage : IUIStorage
    {
        private readonly Dictionary<string, IUIView> _viewDictionary = new Dictionary<string, IUIView>();

        public UIStorage()
        {
            _viewDictionary.Add("mainView", new UIView());
            _viewDictionary.Add("hud", new UIMainHudView());
        }

        public IUIView Get(string id)
        {
            if (_viewDictionary.ContainsKey(id))
            {
                return _viewDictionary[id];
            }
            
            return null;
        }
    }
}