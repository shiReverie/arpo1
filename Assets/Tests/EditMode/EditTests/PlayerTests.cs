using NUnit.Framework;
using Blocks.Character;
using UnityEngine;
using UnityEditor.SceneManagement;

public class PlayerTests
{
    private const string MainScenePath = "Assets/Scenes/SampleScene.unity";

    [Test]
    public void EditMode_PlayerCharacter_IsConfigured()
    {
        var scene = EditorSceneManager.OpenScene(MainScenePath, OpenSceneMode.Single);
        Assert.IsTrue(scene.IsValid(), "Не удалось открыть сцену SampleScene!");

        // В Build Blocks главный компонент персонажа — BuildingBlocksCharacter.
        // FindAnyObjectByType — актуальная замена устаревшему FindFirstObjectByType.
        var character = Object.FindAnyObjectByType<BuildingBlocksCharacter>();
        Assert.IsNotNull(character,
            "На сцене не найден объект с компонентом BuildingBlocksCharacter!");

        Assert.IsTrue(character.gameObject.activeInHierarchy,
            "Персонаж должен быть активен на сцене!");

        // BuildingBlocksCharacter реализует IDamageable — значит, персонаж
        // умеет получать урон, и механика здоровья работает через него.
        // Это публичный контракт, в отличие от internal-модулей.
        Assert.IsInstanceOf<IDamageable>(character,
            "BuildingBlocksCharacter должен реализовывать IDamageable!");

        // Тег «Player» в шаблоне Build Blocks не гарантирован — фиксируем
        // его в лог, но тест не валим, если его нет.
        TestContext.WriteLine($"Тег объекта-персонажа: {character.gameObject.tag}");
    }
}