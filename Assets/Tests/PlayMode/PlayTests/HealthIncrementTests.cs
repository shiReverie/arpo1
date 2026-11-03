using System.Collections;
using NUnit.Framework;
using Platformer.Mechanics;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthIncrementTests
{
    [UnityTest]
    public IEnumerator PlayMode_HealthIncrement_IncreasesButNotAboveMax()
    {
        GameObject obj = new GameObject("TestPlayer");
        obj.SetActive(false);
        Health health = obj.AddComponent<Health>();
        health.maxHP = 3;
        obj.SetActive(true); // Awake → currentHP = 3

        Assert.AreEqual(3, health.currentHP, "currentHP должен стартовать с maxHP");
        Assert.IsTrue(health.IsAlive, "Персонаж должен быть жив");

        health.Decrement();
        Assert.AreEqual(2, health.currentHP, "Decrement уменьшает HP на 1");

        health.Increment();
        Assert.AreEqual(3, health.currentHP, "Increment поднимает HP на 1");

        health.Increment();
        Assert.AreEqual(3, health.currentHP, "Increment не должен превышать maxHP");

        Object.Destroy(obj);
        yield return null;
    }
}