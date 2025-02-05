using System;
using System.Collections.Generic;
using EsercizioOOPGianluca;


// ESERCIZIO: BIBLIOTECA VIDEOGIOCHI
// In questo esercizio dovrai completare una semplice applicazione per gestire una collezione di videogiochi.
// Segui i commenti "TODO" e scegli tra le opzioni proposte o completa il codice mancante.

class Program
{
    static void Main(string[] args)
    {
        // TODO: Crea una nuova istanza di BibliotecaVideogiochi
        // Scrivi qui il codice...

        // TODO: Scegli l'opzione corretta per creare un nuovo videogioco
        // OPZIONE 1:
        var gioco1 = new Videogioco() { Titolo = "Super Mario", Genere = "Platform" };

        // OPZIONE 2:
        // var gioco1 = new Videogioco("Super Mario", "Platform", 1985);

        // TODO: Aggiungi il gioco alla biblioteca
        // Scrivi qui il codice...

        // TODO: Correggi il bug in questa sezione
        Console.WriteLine("Giochi nella biblioteca: " + biblioteca.ContaGiochi));  // Bug: parentesi non bilanciate

        // TODO: Completa il codice per aggiungere questi giochi
        // Suggerimento: alcuni sono dello stesso genere per testare la ricerca per genere
        var giochi = new List<Videogioco>
        {
            // Completa la lista con almeno 3 giochi...
        };

        // TODO: Scegli come aggiungere la lista di giochi alla biblioteca
        // OPZIONE 1:
        foreach (var gioco in giochi)
        {
            // ???
        }

        // OPZIONE 2:
        // giochi.ForEach(g => ???);

        // TODO: Implementa la ricerca per genere e stampa i risultati
        Console.WriteLine("\nGiochi del genere 'Platform':");
        var giochiPlatform = // Completa il codice...
        foreach (var gioco in giochiPlatform)
        {
            // Completa il codice...
        }

        // BONUS: Implementa questi scenari
        Console.WriteLine("\nSCENARI BONUS");

        // TODO: Stampa tutti i giochi in ordine alfabetico
        Console.WriteLine("\nGiochi in ordine alfabetico:");
        // Scrivi qui il codice...

        // TODO: Trova e stampa il gioco più vecchio nella biblioteca
        Console.WriteLine("\nGioco più vecchio:");
        // Scrivi qui il codice...

        // TODO: Calcola e stampa la percentuale di giochi completati
        Console.WriteLine("\nPercentuale giochi completati:");
        // Scrivi qui il codice...
    }

    // SUGGERIMENTO: Potresti voler creare un metodo helper per stampare le informazioni
    // Completa questo metodo
    static void StampaInfoBiblioteca(BibliotecaVideogiochi biblioteca)
    {
        // Scrivi qui il codice...
    }
}