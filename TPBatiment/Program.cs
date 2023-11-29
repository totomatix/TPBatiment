using TPBatiment;

List<Batiment> batiments = new List<Batiment>();

batiments.Add(new Batiment("1 rue toto","rouge"));
batiments.Add(new Maison("1 rue tata","bleue",3));

foreach (Batiment bat in batiments)
{
    Console.WriteLine(bat);
}