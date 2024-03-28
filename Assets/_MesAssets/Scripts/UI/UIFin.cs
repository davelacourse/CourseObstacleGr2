using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIFin : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtCollisionsTotal = default;
    [SerializeField] private TMP_Text _txtTempsFinal = default;

    private void Start()
    {
        _txtTempsTotal.text = "Temps total : " + (Time.time - GameManager.Instance.TempsDepart).ToString("f2") + " sec.";
        _txtCollisionsTotal.text = "Collisions totales : " + GameManager.Instance.Collisions.ToString();
        _txtTempsFinal.text = "Temps final : " + ((Time.time - GameManager.Instance.TempsDepart) 
            + GameManager.Instance.Collisions).ToString("f2") + " sec.";
    }

}
