namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Mon prénom est Pierre-Yves et mon jeu préféré est persona 5");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton age ?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Quel est ton prénom ?");
        String name = Console.ReadLine();
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age < 18)
        {
            Console.WriteLine("Tu es mineur");
        }
        else
        {
            Console.WriteLine("Tu es majeur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'argent as tu ?");
        int money = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("Voici 4 armes :");
        Console.WriteLine("1: Dague 5 euros / 2: Arc 15 euros / 3: Hache 30 euros / 4: Épée Longue 50 euros");
        int weapon1 = 5;
        int weapon2 = 15;
        int weapon3 = 30;
        int weapon4 = 50;
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Choisis une de ces armes grâce a son numéro !");
        int weaponChoice = Convert.ToInt32(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (weaponChoice == 1)
        {
            if (money >= weapon1)
            {
                Console.WriteLine("bien joué tu as acquéri une jolie dague pour la modique somme de 5 euros !");
            }
            else
            {
                Console.WriteLine("tu es trop pauvre looser !");
            }
        }
        if (weaponChoice == 2)
        {
            if (money >= weapon2)
            {
                Console.WriteLine("bien joué tu as acquéri un joli arc pour la modique somme de 15 euros !");
            }
            else
            {
                Console.WriteLine("tu es trop pauvre looser !");
            }
        }
        if (weaponChoice == 3)
        {
            if (money >= weapon3)
            {
                Console.WriteLine("bien joué tu as acquéri une jolie hache pour la modique somme de 30 euros !");
            }
            else
            {
                Console.WriteLine("tu es trop pauvre looser !");
            }
        }
        if (weaponChoice == 4)
        {
            if (money >= weapon4)
            {
                Console.WriteLine("bien joué tu as acquéri une jolie épée longue pour la modique somme de 50 euros !");
            }
            else
            {
                Console.WriteLine("tu es trop pauvre looser !");
            }
        }
        if (weaponChoice == 0 || weaponChoice > 4)
        {
            Console.WriteLine("Il fallait choisir une des 4 armes looser...");
            Console.WriteLine("GAME OVER !");
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}