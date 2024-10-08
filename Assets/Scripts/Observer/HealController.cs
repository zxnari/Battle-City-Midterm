using UnityEngine;
namespace Chapter.Observer
{
    public class HealController : Subject
    {
        public float CurrentHealth
        {
            get { return health; }
        }
        [SerializeField] private float health = 0.0f;
        public void HealDamage(float amount)
        {
            health += amount;
            NotifyObservers();
        }
    }
}