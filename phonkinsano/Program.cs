namespace MiLibreria{

    abstract class Persona{
        public string nombre;

        public int dni;

        public void caminar(){
            System.Console.WriteLine("Esta caminando");
        }

        public string correr(){
            return "esta corriendoooo";
        }

         public abstract void llorar();
        }
       

    class Alumno : Persona{
            public int legajo;
            public int dni;

            public void rendir(){
                System.Console.WriteLine("esta rindiendo...");
            }
        public override void llorar()
        {
            System.Console.WriteLine("el alumno esta llorando");
        }
    }
  
    class Profesor : Persona{
                public int sueldo;
                public void tomarExamen(){

                }
        public override void llorar()
        {
            System.Console.WriteLine("El profe esta llorando");
        }
    }
            }
        
            
        
    
