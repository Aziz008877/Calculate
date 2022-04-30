using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TextCalculate
{
    public class ClearText : MonoBehaviour
    {
        [SerializeField] private List<Text> _allText;
        [SerializeField] private Text _resultText;
        
        private void SetTextNull(Text numberText)
        {
            numberText.text = null;
        }
        public void Clear()
        {
            foreach (var text in _allText)
            {
                SetTextNull(text);
            }
        }

        public void ClearResult()
        {
            SetTextNull(_resultText);
        }
    }
}
