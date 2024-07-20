using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InternationalImage : MonoBehaviour
{
    [SerializeField] Sprite _en;
    [SerializeField] Sprite _tr;
    [SerializeField] Sprite _ru;

    private void Start()
    {
        if(Language.Instance != null)
        {
            if (Language.Instance.CurrentLanguage == "en")
            {
                GetComponent<SpriteRenderer>().sprite = _en;
            }
            else if (Language.Instance.CurrentLanguage == "ru")
            {
                GetComponent<SpriteRenderer>().sprite = _ru;
            }
            else if (Language.Instance.CurrentLanguage == "tr")
            {
                GetComponent<SpriteRenderer>().sprite = _tr;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = _en;
            }
        }
        
    }
}
