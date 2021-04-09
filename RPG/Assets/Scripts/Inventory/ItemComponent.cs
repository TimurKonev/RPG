using UnityEngine;

public abstract class ItemComponent : MonoBehaviour
{
    public bool CanUse => Time.time >= _nextUsedTime;
    
    protected float _nextUsedTime;
    public abstract void Use();

}