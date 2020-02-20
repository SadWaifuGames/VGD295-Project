using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FishFacts : MonoBehaviour
{
    
    public Text fishText;
    public string[] fishFacts =
     {
        "Only the female Angler fish have a luminescent antenna like lure for attracting food",
        "Angler fish’s antenna glow at the end due to bacteria living inside the luminescent bulb",
        "Male Angler fish do not have a luminescent antenna and therefore latch onto the females by biting them in order to survive",
        "Clownfish live in sea anemones which have poisonous tentacles but don’t harm the Clownfish because they have a mucous layer protecting them",
        "Puffer fish have enough toxins to kill around thirty humans",
        "Puffer fish bloat themselves into a ball like shape to intimidate predators",
        "Puffer fish do not have scales but instead have sharp spines that are almost hidden within the skin until the puffer fish bloats itself",
        "Flounders can change the color of their skin within seconds to blend into the environment",
        "Flounders are nocturnal and lie in wait motionless on the sea floor waiting to ambush prey",
        "Flounders are flat and oval like with two eyes on one side of the fish’s face",
        "Blue Tang fish are important to the coral reefs because they eat the algae off of the coral surface",
        "Blue Tang fish have incredibly sharp fins that are harmful if grabbed or touched",
        "Blue Tang males battle for dominance using their sharp spines as swords",
        "When threatened Blue Tang fish will play dead by lying on the ocean floor",
        "Starfish are brainless and bloodless as well as can live up to thirty-five years",
        "A starfish’s stomach protrudes from its body to eat and absorb its food before returning inside the starfish",
        "Starfish can regenerate or regrow limbs but can take up to a year to do so",
        "Jellyfish are brainless, bloodless and boneless but have long tentacles that sting and paralize its victims",
        "Jellyfish eat and dispose of waste through one hole, the mouth",
        "Blobfish do not have teeth so they scour the ocean floor to suck in any prey",
        "Blobfish look like ordinary fish in the ocean but when out of the water they sag into a sad looking puddle",
        "Sea turtles can’t retract back into their shell-like land turtles can",
        "Baby Sea Turtles gender depends on the climate temperature of the nests. The warmer the location means females and the colder means males",
        "Sea turtles can live up to 100 years old and can hold their breath for up to 5 hours",
        "Octopus has three hearts and can change their color to blend into the background",
        "Octopus tend to shoot out a black ink like substance when threatened in order to ninja away",


    };


    // Start is called before the first frame update
    void Start()
    {
        string myString = fishFacts[Random.Range(0, fishFacts.Length)];
        fishText.text = myString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
