using System;
using System.Runtime.CompilerServices;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Llamada Miembro Privado
            A.B b = new A.B();
            Console.WriteLine(b.GetValue());
            Console.ReadKey();
            #endregion

            #region Llamada Miembro Public

            I i = new I();
            i.Method1();

            #endregion

            #region Invalidar los Miembros Heredados con Override
            Clase_Padre_J padre = new Clase_Padre_J();
            Clase_Hija_K hija = new Clase_Hija_K();

            padre.VirtualMethod();
            padre.NoVirtualMethod();

            hija.VirtualMethod();
            hija.NoVirtualMethod();
            #endregion

        }
    }

    #region Miembros Privados
    public class A
    {
        // Value es privado y es visible en la clase B.
        private int value = 10;

        // La clase B es una clase anidada que se deriva de la clase A.
        public class B : A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }

    // La clase C se deriva de la clase A
    public class C : A
    {
        /*
        public int GetValue()
        {
            // El value no es accesible debido a su nivel de proteccion
            return this.value;
        }
        */
    }
    #endregion

    #region Miembros Protegidas
    public class D
    {
        protected int value = 10;
    }

    // la clase E deriva de la clase D
    public class E : D
    {
        public int GetValue()
        {
            return this.value;
        }
    }
    #endregion

    #region Miembro Internal
    public class F
    {
        internal int value = 10;
    }

    public class G : F
    {
        public int GetValue()
        {
            return this.value;
        }
    }

    #endregion

    #region Miembro Publico
    public class H
    {
        public void Method1()
        {
            // Method implementation
        }
    }

    public class I : H
    {

    }
    #endregion

    #region Invalidar los Miembros Heredados con Override
    public class Clase_Padre_J
    {
        public virtual void VirtualMethod()
        {
            // Codigo del metodo
        }

        public void NoVirtualMethod()
        {
            // Codigo del metodo
        }
    }

    public class Clase_Hija_K : Clase_Padre_J
    {
        public override void VirtualMethod()
        {
            // Codigo que sustituye el codigo base.
        }
    }

    #endregion

    #region Clase Abstracta
    public abstract class Clase_Padre_Abstract
    {
        public abstract void Method_1();
    }

    public class Clae_Hija_Abstract : Clase_Padre_Abstract
    {
        public override void Method_1()
        {
            
        }
    }

    #endregion
}
