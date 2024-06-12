using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageCounter : MonoBehaviour
{
    public PlayData data;
    [SerializeField] private TextMeshProUGUI damageCounter;
    void Update()
    {
        damageCounter.text = "Damage : " + data.DamageScore();
    }
}
