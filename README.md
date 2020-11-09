# Herencia


La Herencia junto con el Polimorfismo y la Encapsulación, es una de las tres características principales de la programación orientada a objetos.
La Herencia permite crear clases que reutilizan extienden y modifican el comportamiento definido de otras clases.
Las clases cuyos miembros se heredan se denominan clase base y la clase que hereda esos miembros se denominan clase deriva

En **C# admiten herencia única**, es decir, una clase solo puede heredar de una clase única. Sin embargo, la herencia es transitiva, lo que le permite definir una jerrarquia de herencia para un conjunto de tipos.

Los **Constructor** y los **Finalizadores** no se heredan.

Si bien las clases derivadas heredan todos los demás miembros de una clase base, que dichos miembros estén o no visibles depende de su accesibilidad.

</br>

La accesibilidad de miembros afecta su visibilidad en las clases derivadas del siguiente modo:

1. Los miembros **Privated** (Privados) solo son visibles en las clases derivadas que están anidadas en la clase base.
 
2. Los miembros **Protected** (Protegidos) solo son visibles en las clases derivadas.
 
3. Los miembros **Internal**  solo son visibles en las clases derivadas que se encuentra en el mismo ensamblado que la clase base.
No son visible  en las clases derivadas ubicadas en  un ensamblado diferente a la clase base.
 
4. Los miembros **públicos** son visibles en las clases derivadas y forman parte de la interfaz pública de dichas clases.

Las clases derivadas pueden también invalidar los miembros heredados al proporcionar una implementación alternativas. Para poder invalidar un miembro, el miembro de la clase base debe marcarse con la palabra clave **Virtual** de forma predeterminada. Los miembros de la clase base no están marcados como virtual y no se pueden invalidar.
Para invalidar o también llamado sobrescribir un miembro debemos usar la palabra clave **Override**.
