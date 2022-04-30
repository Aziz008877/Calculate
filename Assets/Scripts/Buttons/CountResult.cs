using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
    public class CountResult : MonoBehaviour
    {
        [SerializeField] private List<Text> _countText;
        [SerializeField] private Text _symbol;
        private float _result;
        [SerializeField] private Text _resultText;

        public void Count()
        {
            var numberOne = float.Parse(_countText[0].text);
            var numberTwo = float.Parse(_countText[1].text);
            
            switch (_symbol.text)
            {
                case "+":
                    _result = numberOne + numberTwo;
                    break;
                case "-":
                    _result = numberOne - numberTwo;
                    break;
                case "*":
                    _result = numberOne * numberTwo;
                    break;
                case "/":
                    _result = numberOne / numberTwo;
                    break;
                default:
                    print("Error was captured");
                    break;
            }
            _resultText.text = _result.ToString();
        }
        

        public void SendSymbol(string symbol)
        {
            _symbol.text = symbol;
        }
    }
}
