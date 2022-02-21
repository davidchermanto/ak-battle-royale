using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private List<Character> characterData;
    [SerializeField] private List<CharacterManager> characters;

    private List<string> possibleCharacters;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        // read players into characters list

        // spawn all players
        foreach(Character character in characterData)
        {

        }

    }

    public void SpawnCharacter(Character character)
    {
        GameObject newCharacter = Instantiate(prefab);
        CharacterManager characterManager = newCharacter.GetComponent<CharacterManager>();

        characterManager.Setup(character);

        characters.Add(characterManager);
    }
}
