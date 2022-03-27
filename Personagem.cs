namespace DesafioRPG
{
    public class Personagem
    {
        public Personagem(string Name, int Level, int MagicPoints, int HealthPoints, string TipoHeroi)
        {
            this.Name = Name; // indicando os parametros a serem colocados dentro do parentesis na criação do 'new' personagem.
            this.Level = Level; // o 'this' refere-se à variáveis que estão alocadas dentro desta mesma classe. 
            this.MagicPoints = MagicPoints;
            this.HealthPoints = HealthPoints;
            this.TipoHeroi = TipoHeroi;
        }

        public Personagem(){

        }
        public string Name;
        public int Level;
        public int MagicPoints;
        public int HealthPoints;
        public string TipoHeroi;

     
        public string Caracteristicas(){
            return "\nNOME: " + this.Name + "\n" + "LEVEL: " + this.Level + "\n" + "MP: " +  this.MagicPoints + "\n" + "HP: " + this.HealthPoints + "\n" + "TYPE: " + this.TipoHeroi + "\n";
        }// criando um método dentro da superclasse;

        public override string ToString(){
            
            if (this.TipoHeroi =="Knight")
            {
                return this.Name + " atacou com sua espada.";
            }
            else if(this.TipoHeroi == "WhiteWizard")
            {
                return this.Name + " atacou com sua mágia branca.";
            }
            else if(this.TipoHeroi == "Ninja")
            {
                return this.Name + " atacou com sua katana.";
            }
            else
            {
                return " atacou.";
            }
        }
    }
}