using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class HealEssense : CollectibleItem
{
    public int _healPoints { get; private set; } = 50;
}
