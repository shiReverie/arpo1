using UnityEngine;

namespace Platformer.Mechanics
{
    public class Health : MonoBehaviour
    {
        public int maxHP = 3;
        public int currentHP { get; private set; }
        public bool IsAlive => currentHP > 0;

        private void Awake() => currentHP = maxHP;

        public void Decrement()
        {
            if (currentHP > 0) currentHP--;
        }

        public void Increment()
        {
            if (currentHP < maxHP) currentHP++;
        }
    }
}