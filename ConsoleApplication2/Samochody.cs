public class Samochód
{
    private string marka;
    private string model;
    private int drzwi;
    private double pojemnosc;
    private double spalanie;
    private static int CarCount = 0;
    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public int Drzwi
    {
        get { return drzwi; }
        set { drzwi = value; }
    }
    public double Pojemnosc
    {
        get { return pojemnosc; }
        set { pojemnosc = value; }
    }
    public double Spalanie
    {
        get { return spalanie; }
        set { spalanie = value; }
    }


    public Samochód()
    {
        marka = "n/w";
        model = "n/w";
        drzwi = 0;
        pojemnosc = 0;
        spalanie = 0;
        CarCount++;
    }

    public Samochód(string marka, string model, int drzwi, double pojemnosc, double spalanie)
    {
        marka = Marka;
        model = Model;
        drzwi = Drzwi;
        pojemnosc = Pojemnosc;
        spalanie = Spalanie;
        CarCount++;
    }


    public string info
    {
        get
        {
            return (Marka + "\n" + Model + "\n" + Drzwi + "\n" + Pojemnosc + "\n" + Spalanie);
        }
    }


    public double SpalanieTrasa(double trasa)
    {
        return  (trasa * spalanie)/100.0;
    }


    public double CenaPaliwo(double trasa, double cena)
    {
        
        return ((trasa * spalanie) / 100.0) * cena ;
    }


    public int LiczbaSamochodów
    {
        get
        {
            return CarCount;
        }
    }
}
