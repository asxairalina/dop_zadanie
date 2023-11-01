


List<Flower> flowers = new List<Flower>();
//flowers.Add(new Flower());
flowers.Add(new Carnation());
flowers.Add(new Rose());

class Flower
{
    public string name { get; set; }
    public string color { get; set; }
    public bool harmless { get; set; }
    public int petals { get; set; }

    public Flower(string color, string name)
    {
        this.color = color;
        this.name = name;
        Console.WriteLine("the name is selected!");
        Console.WriteLine("color selected!");
    }

    public Flower(bool harmless)
    {
        
        this.harmless = harmless;
        Console.WriteLine("the type of flower is defined");
    }

    public Flower(int petals)
    {
        this.petals = petals;
    }
    public void Smell()
    {
        Console.WriteLine("this flower smells!");
    }

    public static void BubbleSort(int[] arr)
    {
        static void BubbleSort(int[] arr)
       {
            int n = arr.Length; for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                                    int temp = arr[j];
                        arr[j] = arr[j + 1]; arr[j + 1] = temp;
                    }
                }
            }
       }
    }
}

class Carnation: Flower
{
    public Carnation(string color, string name, bool harmless, int petals) : base(color, name, harmless, petals)
    {
        Console.WriteLine("Carnation created!");
    }
 

  

    public void grass()
    {
        Console.WriteLine("carnation has herbaceous or semi - herbaceous stem");
    }
}

class Rose:Flower
{
    public Rose(string color, string name) : base(color, name)
    {
        Console.WriteLine("Rose created!");
    }
    public Rose(bool harmless) : base(harmless)
    {
        Console.WriteLine("Rose created!");
    }
    public Rose(int petals) : base(petals)
    {
        Console.WriteLine("Rose created!");
    }

    public void thorns()
    {
        Console.WriteLine("the rose has thorns");
    }
}

