using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleDetection : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Image detectionImage;
    [Space]
    [SerializeField] private Color colorOn;
    [SerializeField] private Color colorOff;

    void Start()
    {
        EnableDetection(false);
    }

    public void EnableDetection(bool enable)
    {
        detectionImage.color = enable ? colorOn : colorOff;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
