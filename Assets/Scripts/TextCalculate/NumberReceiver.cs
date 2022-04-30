using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TextCalculate
{
    public class NumberReceiver : MonoBehaviour
    {
        [SerializeField] private List<Text> _numbers;
        
        private bool _isSymbolAdded = false;

        public void ChangeSymbolState(bool state)
        {
            _isSymbolAdded = state;
        }
        private void AddNumbersToText(Text numberText, int number)
        {
            numberText.text += number;
        }
        public void ReceiveText(int number)
        {
            AddNumbersToText(_isSymbolAdded == false ? _numbers[0] : _numbers[1], number);
        }
    }
}
