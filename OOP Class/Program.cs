// See https://aka.ms/new-console-template for more information

// Detta är ett meddelande

Hemsida webpage = new Hemsida();
string welcomeMsg = "Välkommen till detta program";
int int01 = 2;
int int02 = 3;
int sum = int01 + int02;
Console.WriteLine("Min favoritsiffra är " + sum);

webpage.printMain();

class Hemsida
{
    public string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 192." };
    string klassNamn = "Klass 1A";
    string start = "<!DOCTYPE html>\n<html>\n<body>\n<h1>Välkomna!";
    string end = "<main>\n<p>Kurs om C#</p>\n<p>Kurs om databaser</p>\n</main>\r\n</body>\r\n</html>";

    public void printMain()
    {
        Console.WriteLine(this.start + this.klassNamn + "</h1>");

        
        for (int i = 0; i < messagesToClass.Length; i++)
        {
            Console.WriteLine("<p><b>Meddelande:</b>" + this.messagesToClass[i] + "</p>");
        }
        
        Console.WriteLine(this.end);
    }
}




