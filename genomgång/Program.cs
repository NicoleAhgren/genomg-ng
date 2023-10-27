// komposition :"har-en"

// Ny klass eller inte?
// Lite data skiljer = ingen ny klass
//Funkion skiljer = ny klass
// komposition eller arv?
// "är en" : arv
// "har en" : komposition

// Fighter f1 = new Fighter();
// f1.strength = 12;

Axe a = new Axe();
Sword s = new Sword();

Weapon w = new Axe();

a.Attack();

Console.WriteLine(w.Name);



List<Weapon> weapons = new List<Weapon>();
weapons.Add(new Axe());


Console.ReadLine();



// Console.WriteLine(a.Name);

// Console.WriteLine(S.Name);