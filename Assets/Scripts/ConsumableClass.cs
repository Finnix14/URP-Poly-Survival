using UnityEngine;

public class ConsumableClass : ItemClass
{
    public int addHealth = 10;

    public override void Use(/*PlayerController caller*/)
    {
        base.Use();
        Debug.Log(addHealth);
    }

    public override ConsumableClass GetConsumable() { return this; }
}
