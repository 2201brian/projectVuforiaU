 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.Events;


public class CylinderInteraction : MonoBehaviour
{   
    public UnityEvent OnOpen;
    public UnityEvent OnClose;

    private Animator _animator;
    private  bool _isOpen;
    private int _hash_IsOpen = Animator.StringToHash("isOpen");
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown() {
        _isOpen = !_isOpen;
        if (_isOpen)
        {
            OnOpen.Invoke();
        } else 
        {
            OnClose.Invoke();
        }

        _animator.SetBool(_hash_IsOpen, _isOpen);
    }

}
