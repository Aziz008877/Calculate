using UnityEngine;
using UnityEngine.Events;

namespace Buttons
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private float _ID;
        
        [SerializeField] private UnityEvent<float> _onNumberTyped;

        public void SendClickedNumber()
        {
            _onNumberTyped?.Invoke(_ID);
        }
    }
}
