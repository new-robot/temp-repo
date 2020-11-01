using System;

namespace temp_repo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour");

            AskQuestion("veuillez entrer votre pseudo :", "Voici votre pseudo: ");
            AskQuestion("veuillez entrer votre age :", "Voici votre age: ");
            DoYouLikeCats();

            // Fin
            Console.WriteLine("Appuyez sur un touche pour mettre fin au programme...");
            Console.ReadLine();
        }

        static void AskQuestion(string question, string reponse)
        {
            Console.WriteLine(question);
            string texte = Console.ReadLine();
            Console.WriteLine(reponse + texte);
            
        }

        static void DoYouLikeCats()
        {            
            bool goodAnswer = false;
            do
            {
                Console.WriteLine("Aimez-vous les chats ? (o/n)");
                string reponseChats = Console.ReadLine();
                if (reponseChats == "o")
                {
                    goodAnswer = true;
                    Console.WriteLine("D'accord, vous aimez les chats.");
                }
                else if (reponseChats == "n")
                {
                    goodAnswer = true;
                    Console.WriteLine("D'accord vous n'aimez pas les chats.");
                } 
                else
                {
                    Console.WriteLine("Veuillez choisir entre (o/n)");
                }
            } while (!goodAnswer);
        }
    }
}
