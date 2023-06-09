var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string Bp1, Bp2, Bp3, Bp4, Bp5, Bp6, Bp7, Bp8;
string BV1, BJ1, BS1,  BD,  BK, BS2, BJ2 ,BV2;

string �p1, �p2, �p3, �p4, �p5, �p6, �p7, �p8;
string �V1, �J1, �S1, �D, �K, �S2, �J2, �V2;



// Vytvo�en� prom�nn�ch pro �achov� figurky BP1 je B�l�P��k1 atd...
Bp1 = "A2"; �p1 = "A7";
Bp2 = "B2"; �p2 = "B7";
Bp3 = "C2"; �p3 = "C7";
Bp4 = "D2"; �p4 = "D7";
Bp5 = "E2"; �p5 = "E7";
Bp6 = "F2"; �p6 = "F7";
Bp7 = "G2"; �p7 = "G7";
Bp8 = "H2"; �p8 = "H7";
BV1 = "A1"; �V1 = "A8";
BJ1 = "B1"; �J1 = "B8";
BS1 = "C1"; �S1 = "C8";
BD  = "D1"; �D  = "D8";
BK  = "E1"; �K  = "E8";
BS2 = "F1"; �S2 = "F8";
BJ2 = "G1"; �J2 = "G8";
BV2 = "H1"; �V2 = "H8";


app.MapGet("/Bp1", () =>
{
    return Bp1;
});

app.MapGet("/Bp1/{zmenaBp1}", (string zmenaBp1) =>
{
    Bp1 = zmenaBp1;

    Dictionary<string, string> promenne = new Dictionary<string, string>();
    // P�id�n� prom�nn�ch do slovn�ku
    promenne.Add("Bp1", Bp1);
    promenne.Add("Bp2", Bp2);
    promenne.Add("Bp3", Bp3);
    promenne.Add("Bp4", Bp4);
    promenne.Add("Bp5", Bp5);
    promenne.Add("Bp6", Bp6);
    promenne.Add("Bp7", Bp7);
    promenne.Add("Bp8", Bp8);
    promenne.Add("BV1", BV1);
    promenne.Add("BJ1", BJ1);
    promenne.Add("BS1", BS1);
    promenne.Add("BD", BD);
    promenne.Add("BK", BK);
    promenne.Add("BS2", BS2);
    promenne.Add("BJ2", BJ2);
    promenne.Add("BV2", BV2);
    promenne.Add("�p1", �p1);
    promenne.Add("�p2", �p2);
    promenne.Add("�p3", �p3);
    promenne.Add("�p4", �p4);
    promenne.Add("�p5", �p5);
    promenne.Add("�p6", �p6);
    promenne.Add("�p7", �p7);
    promenne.Add("�p8", �p8);
    promenne.Add("�V1", �V1);
    promenne.Add("�J1", �J1);
    promenne.Add("�S1", �S1);
    promenne.Add("�D", �D);
    promenne.Add("�K", �K);
    promenne.Add("�S2", �S2);
    promenne.Add("�J2", �J2);
    promenne.Add("�V2", �V2);

    // P�idej dal�� prom�nn�

    // Proch�zen� slovn�ku
    foreach (var kvp in promenne)
    {
        string nazevPromenne = kvp.Key;
        string hodnotaPromenne = kvp.Value;

        // Kontrola, zda jin� prom�nn� ji� m� stejnou hodnotu
        bool hodnotaSeOpakuje = promenne.Any(p => p.Key != nazevPromenne && p.Value == hodnotaPromenne);

        if (hodnotaSeOpakuje)
        {
            Console.WriteLine("Nen� mo�n� nastavit hodnotu prom�nn� " + nazevPromenne + ", proto�e ji� existuje jin� prom�nn� s touto hodnotou.");
        }
        else
        {
            Console.WriteLine("Hodnota prom�nn� " + nazevPromenne + " je unik�tn�.");
        }
    }




    //
    return "Zm�na provedena";
});

app.Run();