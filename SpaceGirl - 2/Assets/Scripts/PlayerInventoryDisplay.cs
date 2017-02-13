using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour {

    private const int NUM_INVENTORY_SLOTS = 10;
    private PickupUI[] slots = new PickupUI[NUM_INVENTORY_SLOTS];
    public GameObject slotGrid;
    public GameObject starSlotPrefab;

    private void Awake()
    {
        for (int i = 0; i < NUM_INVENTORY_SLOTS; i++)
        {
            var starSlotGO = Instantiate(starSlotPrefab);
            starSlotGO.transform.SetParent(slotGrid.transform);
            starSlotGO.transform.localScale = Vector3.one;
            slots[i] = starSlotGO.GetComponent<PickupUI>();
        }
    }

    public void OnChangeStarTotal(int starTotal)
    {
        for (int i = 0; i < NUM_INVENTORY_SLOTS; i++)
        {
            var slot = slots[i];
            if(i < starTotal)
            {
                slot.DisplayYellow();
            }
            else
            {
                slot.DisplayGrey();
            }
        }
    }
}
