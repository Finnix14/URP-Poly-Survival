using UnityEngine;

[CreateAssetMenu(fileName = "Deez")]
public class ItemClass : ScriptableObject
{
    public string itemName = "New Item Name";
    public Sprite itemIcon = null;
    public bool isStackable = true;
    public int maxStackSize = 99;

    public virtual void Use(/*PlayerMController caller*/)
    {
        Debug.Log("Used: " + itemName);
    }

    public virtual ItemClass GetItem() { return this; }
    public virtual ConsumableClass GetConsumable() { return null; }
}
