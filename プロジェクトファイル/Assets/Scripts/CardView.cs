using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText, powerText, costText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel) // cardModel�̃f�[�^�擾�Ɣ��f
    {
        nameText.text = cardModel.name;
        powerText.text = cardModel.power.ToString();
        costText.text = cardModel.cost.ToString();
        iconImage.sprite = cardModel.icon;
    }
}