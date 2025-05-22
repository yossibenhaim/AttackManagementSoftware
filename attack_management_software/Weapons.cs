namespace attack_management_software
{


public class Weapons : IAtteckTool
    {
        public string name { get; set; }
        public string purpose { get; set; }
        public int countOfAattack { get; set; }
        public int countOfGas { get; set; }

        public Weapons(string name, string purpose, int countOfAattack, int countOfGas)
        {
            Name = name;
            Purpose = purpose;
            CountOfAttack = countOfAattack;
            CountOfGas = countOfGas;
        }
        public void changeCountAttack()
        {
            CountOfAttack --;
        }
        public void changeCountGas()
        {
            CountOfGas -= 5;
        }


    }
}