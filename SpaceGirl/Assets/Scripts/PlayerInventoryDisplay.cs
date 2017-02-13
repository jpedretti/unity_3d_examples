using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour {

    public Image iconStarYellow;

    public void OnChangeCarryingStar(int starCount)
    {

        iconStarYellow.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 100 * starCount);
    }
}
